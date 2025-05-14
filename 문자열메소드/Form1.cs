using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 문자열메소드
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            //string subStr = str.Substring(7, 1);
            //if(subStr == "1"||subStr == "3")
            //{
            //    label1.Text = "남성";
            //}
            //else if(subStr == "2" || subStr == "4")
            //{
            //    label1.Text = "여성";
            //}
            //else
            //{
            //    label1.Text = "외국인";
            //}
            label1.Text = "";
            string[] strArr = str.Split(",");

            foreach(string arr in strArr)
            {
                label1.Text += "\n" + arr;
            }
            
        }
    }
}
