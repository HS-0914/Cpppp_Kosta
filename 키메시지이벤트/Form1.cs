using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 키메시지이벤트
{
    public partial class Form1: Form
    {
        private string str = "";
        private string subStr = "";
        public Form1()
        {
            InitializeComponent();
        }

        // 입력되면 무조건
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                subStr = str.Substring(str.Length - 1, 1);
                if (char.GetUnicodeCategory(char.Parse(subStr))
                    ==
                    System.Globalization.UnicodeCategory.OtherLetter)
                {
                    str = str.Substring(0, str.Length - 1);
                }
            }
        }

        // 입력한 것 중 문자일때(a, b, backspace, ...)
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Back)
            {
                if(str.Length > 0)
                {
                    str = str.Substring(0, str.Length - 1);
                }
            }
            else
            {
                str += e.KeyChar;
            }
            label1.Text = str;
            int x = (ClientSize.Width - label1.PreferredWidth) / 2;
            label1.Location = new Point(x, label1.Location.Y);
        }
    }
}

/*
 int x = (ClientSize.Width - lblToast.PreferredWidth) / 2;
            lblToast.Location = new Point(x, lblToast.Location.Y);
 */