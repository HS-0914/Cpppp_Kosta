using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPClient
{


    public partial class Form1: Form
    {

        TcpClient Client;   // 클라이언트 소켓

        NetworkStream Stream;
        StreamReader Reader;
        StreamWriter Writer;

        Thread receiveThread;

        bool Connected;
        private delegate void AddTextDelegate(string strText);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            txtView.AppendText("나 : " + txtInput + Environment.NewLine);
            Writer.WriteLine(txtInput.Text);
            Writer.Flush();
            txtInput.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string IP = "127.0.0.1";
            int port = 9000;

            Client = new TcpClient();
            Client.Connect(IP, port);

            Stream = Client.GetStream();
            Connected = true;

            txtView.AppendText("서버에 접속 성공!!" + Environment.NewLine);

            Reader = new StreamReader(Stream);
            Writer = new StreamWriter(Stream);

            //수신을 위한 스레드
            ThreadStart ts = new ThreadStart(Receive);
            Thread rcvthread = new Thread(ts);
            rcvthread.Start();

        }

        private void Receive()
        {
            AddTextDelegate AddText = txtView.AppendText;
            while (Connected)
            {
                if (Stream.CanRead)
                {
                    string temp = Reader.ReadLine();
                    if (temp.Length > 0)
                    {
                        Invoke(AddText, "상대방" + Environment.NewLine);

                    }
                }
            }
        }
    }
}
