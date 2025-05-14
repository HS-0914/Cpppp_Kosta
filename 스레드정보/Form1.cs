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

namespace 스레드정보
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread th = Thread.CurrentThread;
            th.Name = "threadInfo";

            textBox1.Text += "스레드 이름 : " + th.Name + "\n";
            textBox1.Text += "스레드 상태 : " + th.ThreadState + "\n";
            textBox1.Text += "스레드 우선순위 : " + th.Priority + "\n";
        }
    }
}
/*

*/