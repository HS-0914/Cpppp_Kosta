using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ThreadStateForm
{
    public partial class Form1 : Form
    {
        private Thread thd;
        private string strState;
        delegate void CrossCall();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnThreadStart_Click(object sender, EventArgs e)
        {

            /*
            thd = new Thread(new ThreadStart(ThreadFunction));
            txtThreadState.Text += "스레드 식별 : " + thd.GetHashCode() + "\r\n";
            txtThreadState.Text += "스레드 상태 : " + thd.ThreadState + "\r\n";
            thd.Start();
            txtThreadState.Text += "스레드 상태 : " + thd.ThreadState + "\r\n";
            */

            txtThreadState.Clear();
            txtThreadState.Text += "스레드풀 시작" + "\r\n";

            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadFunction), i);
            }
            txtThreadState.Text += "스레드풀 종료" + "\r\n";
        }

        private void ThreadFunction(object obj)
        {
            txtThreadState.Invoke(new CrossCall(ThreadState));
            strState = "스레드 상태 : " + Thread.CurrentThread.ThreadState + "\r\n";
            Thread.Sleep(1000);
        }

        private void ThreadState()
        {
            txtThreadState.Text += strState;
        }
    }
}
