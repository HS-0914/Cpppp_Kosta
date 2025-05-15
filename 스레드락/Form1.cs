using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 스레드락
{
    public partial class Form1: Form
    {
        private string thdCode;
        private delegate void CrossCall();
        private int money;
        private object lockObject = new object();
        private static Mutex mutex = new Mutex(false, "mtxObj");
        public Form1()
        {
            InitializeComponent();
            thdCode = null;
            money = 10000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            ThreadStart ts1 = new ThreadStart(ThreadTeller);
            ThreadStart ts2 = new ThreadStart(ThreadTeller);
            ThreadStart ts3 = new ThreadStart(ThreadTeller);

            Thread mobile = new Thread(ts1);
            Thread internet= new Thread(ts2);
            Thread tel= new Thread(ts3);

            mobile.Start();
            internet.Start();
            tel.Start();
        }

        private void ThreadTeller()
        {
            int task = 0;
            //lock (lockObject)
            //Monitor.Enter(lockObject);
            mutex.WaitOne();
            {
                while (task < 5)
                {
                    money = money + 1000;
                    textBox1.Invoke(new CrossCall(ThreadState));
                    thdCode = "뱅킹고유번호 " + Thread.CurrentThread.GetHashCode() + " 입금잔액 : " + money + "원" + "\r\n";
                    Thread.Sleep(100);
                    task++;
                }
            }
            //Monitor.Exit(lockObject);
            mutex.ReleaseMutex();

        }

        private void ThreadState()
        {
            textBox1.Text += thdCode;
        }
    }
}


/* C++ 기반 스레드 동기화
이벤트
크리티컬섹션
세마포어
뮤텍스

C# ㅣㄱ반
lock
모니터
뮤텍스
*/