using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 조건문
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            int kuk = int.Parse(txtKuk.Text);
            int eng= int.Parse(txtEng.Text);
            int math = int.Parse(txtMath.Text);

            int total = kuk + eng + math;
            double avg = total / 3;
            lblAvg.Text = avg.ToString();

            /*
            if (avg >= 90 && avg <= 100)
            {
                lblgrade.Text = "A학점";
            }
            else if (avg >= 80 && avg < 90)
            {
                lblgrade.Text = "B학점";
            }
            else if (avg >= 70 && avg < 80)
            {
                lblgrade.Text = "C학점";
            }
            else if (avg >= 60 && avg < 70)
            {
                lblgrade.Text = "D학점";
            }
            else if (avg >= 50 && avg < 60)
            {
                lblgrade.Text = "E학점";
            }
            else if (avg >= 0 && avg < 50)
            {
                lblgrade.Text = "F학점";
            }
            else
            {
                lblgrade.Text = "잘못된입력";
            }
            */

            switch (avg / 10)
            {
                case 10:
                case 9:
                    lblgrade.Text = "A학점";
                    break;
                case 8:
                    lblgrade.Text = "B학점";
                    break;
                case 7:
                    lblgrade.Text = "C학점";
                    break;
                case 6:
                    lblgrade.Text = "D학점";
                    break;
                case 5:
                    lblgrade.Text = "E학점";
                    break;
                case 4:
                case 3:
                case 2:
                case 1:
                case 0:
                    lblgrade.Text = "F학점";
                    break;
                default:
                    lblgrade.Text = "잘못된입력";
                    break;

            }


            if (total > 250 && total <= 300)
            {
                label1.Text = "합격";
            }
            else if (total > 0 && total <= 250)
            {
                label1.Text = "불합격";
            }
            else
            {
                label1.Text = "잘못된입력";
            }
        }
    }
}
