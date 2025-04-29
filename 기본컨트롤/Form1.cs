using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 기본컨트롤
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strOrder = "";
            lblResult.Text = "";

            if(ckbA.Checked == true)
            {
                strOrder += ckbA.Text + "\n";
            }
            if(ckbB.Checked == true)
            {
                strOrder += ckbB.Text + "\n";
            }
            if(ckbC.Checked == true)
            {
                strOrder += ckbC.Text + "\n";
            }
            if(ckbD.Checked == true)
            {
                strOrder += ckbD.Text + "\n";
            }
            lblResult.Text = strOrder;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                MessageBox.Show("개인정보 동의");
            }
            else
            {
                MessageBox.Show("개인정보 미동의");
            }
        }

        private void ckbC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnReci_Click(object sender, EventArgs e)
        {
            string strText = txtRequire.Text + "\n";
            MessageBox.Show(strText);
        }

        private void cbPay_SelectedIndexChanged(object sender, EventArgs e)
        {

            lbArea.Items.Clear();

            if (cbPay.SelectedIndex == 0)
            {
                lbArea.Items.Add("일시불");
                lbArea.Items.Add("3개월할부");
                lbArea.Items.Add("6개월할부");
            }
            else if (cbPay.SelectedIndex == 1)
            {
                lbArea.Items.Add("국민은행");
                lbArea.Items.Add("농협은행");
                lbArea.Items.Add("기업은행");
                lbArea.Items.Add("기업은행");
                lbArea.Items.Add("새마을금고");
                lbArea.Items.Add("카카오뱅크");
            }
            else if (cbPay.SelectedIndex == 2)
            {
                lbArea.Items.Add("카드");
                lbArea.Items.Add("포인트");
            }
            else if (cbPay.SelectedIndex == 3)
            {
                lbArea.Items.Add("일시불");
                lbArea.Items.Add("3개월할부");
                lbArea.Items.Add("6개월할부");
            }
            else if (cbPay.SelectedIndex == 4)
            {
                lbArea.Items.Add("일시불");
            }
            else if (cbPay.SelectedIndex == 5)
            {
                lbArea.Items.Add("장부");
                lbArea.Items.Add("외상불가");
            }
        }

        private void lbArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
