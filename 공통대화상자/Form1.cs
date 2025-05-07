using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 공통대화상자
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            if (Ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = Ofd.FileName + " 파일을 엽니다.";
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Sfd.Filter = "모든 파일(*.*)|(*.*)";
            if(Sfd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = Sfd.FileName + " 파일을 저장합니다.";
            }
        }

        private void BtnFont_Click(object sender, EventArgs e)
        {
            if (Fd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = Fd.Font;
            }
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            if (Cd.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = Cd.Color;
            }
        }
    }
}
