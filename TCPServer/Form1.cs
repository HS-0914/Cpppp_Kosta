using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPServer
{
    public partial class Form1: Form
    {
        TcpListener Server; // 서버 소켓
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
            txtInput.Clear(); ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //new ThreadStart("안에 메소드 등록");
            ThreadStart ts = new ThreadStart(Listen);
            Thread thread = new Thread(ts);
            thread.Start();
        }

        private void Listen()
        {
            //AddTextDelegate AddText = new AddTextDelegate(txtView.AppendText);
            AddTextDelegate AddText = txtView.AppendText;

            // new IPAddress(0) -> localhost, 127.0.0.1
            IPAddress addr = new IPAddress(0);
            int port = 9000;

            Server = new TcpListener(addr, port); // 소켓 생성 및 바인딩
            Server.Start(); // 서버 시작

            Invoke(AddText, "서버 시작" + Environment.NewLine);

            Client = Server.AcceptTcpClient(); // 클라이언트 연결 수락

            Connected = true;

            Invoke(AddText, "클라이언트와 연결" + Environment.NewLine);

            Stream = Client.GetStream();
            Reader = new StreamReader(Stream);
            Writer = new StreamWriter(Stream);

            ThreadStart ts = new ThreadStart(Receive);
            Thread rcvThread = new Thread(ts);
            rcvThread.Start();
        }
        private void Receive() 
        {
            AddTextDelegate AddText = txtView.AppendText;
            while (Connected)
            {
                if (Stream.CanRead)
                {
                    string temp = Reader.ReadLine();
                    if(temp.Length > 0)
                    {
                        Invoke(AddText, "상대방" + Environment.NewLine);

                    }
                }
            }
        }
    }
}
