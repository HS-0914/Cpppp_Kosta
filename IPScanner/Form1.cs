using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPScanner
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string GetMyBaseIP()
        {
            foreach (IPAddress ip in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if(ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    string[] parts = ip.ToString().Split('.');
                    if(parts.Length == 4)
                    {
                        return $"{parts[0]}.{parts[1]}.{parts[2]}";
                    }
                }
            }

            return null;
        }

        private async void btnScan_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string baseIP = GetMyBaseIP();
            if(baseIP == null)
            {
                listBox1.Items.Add("로컬 IP를 가져올 수 없습니다.");
                return;
            }

            for (int i = 0; i < 255; i++)
            {
                string ip = $"{baseIP}.{i}";

                // 핑 보내기
                if (await isPingSuccerss(ip))
                {
                    listBox1.Items.Add($"{ip} : 응답 있음");
                }
            }
            listBox1.Items.Add("스캔 완료");
        }
        private async Task<bool> isPingSuccerss(string ip)
        {
            try
            {
                Ping ping = new Ping();
                PingReply reply = await ping.SendPingAsync(ip, 300);
                return reply.Status == IPStatus.Success;
            }
            catch
            {
                return false;
            }
        }
    }
}
