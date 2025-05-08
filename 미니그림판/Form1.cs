using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 미니그림판
{
    public partial class Form1: Form
    {
        int shape;

        Point ptStart;
        Point ptEnd;

        Pen mypen;
        int rtWidth;
        int rtHeight;

        Boolean bPress;

        Graphics g;

        Rectangle rect;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            shape = 0;
            ptStart = new Point(0, 0);
            ptEnd = new Point(0, 0);
            mypen = new Pen(Color.Black, 5);
            rtWidth = 0;
            rtHeight = 0;
            bPress = false;
            g = Graphics.FromHwnd(this.Handle);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (shape == 0)
            {
                // 선 그리기
                if (bPress)
                {
                    g.Clear(Color.White);
                    ptEnd = e.Location;
                    g.DrawLine(mypen, ptStart, ptEnd);
                }
            }
            else if (shape == 1)
            {
                // 사각형 그리기
                if (bPress)
                {
                    g.Clear(Color.White);
                    rtWidth = Math.Abs(e.X - ptStart.X);
                    rtHeight = Math.Abs(e.Y - ptStart.Y);

                    rect = new Rectangle(ptStart.X, ptStart.Y, rtWidth, rtHeight);
                    g.DrawRectangle(mypen, rect);
                }
            }
            else if (shape == 2)
            {
                // 원 그리기
                if (bPress)
                {
                    g.Clear(Color.White);
                    rtWidth = Math.Abs(e.X - ptStart.X);
                    rtHeight = Math.Abs(e.Y - ptStart.Y);

                    rect = new Rectangle(ptStart.X, ptStart.Y, rtWidth, rtHeight);
                    g.DrawEllipse(mypen, rect);
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            bPress = true;
            ptStart = e.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            bPress = false;
        }

        private void ToolStripNew_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }

        private void ToolStripExit_Click(object sender, EventArgs e)
        {
           
        }

        private void ToolStripLine_Click(object sender, EventArgs e)
        {
            // 직선 그리기
            this.shape = 0;
        }

        private void ToolStripRect_Click(object sender, EventArgs e)
        {
            // 사각형 그리기
            this.shape = 1;

        }

        private void ToolStripCircle_Click(object sender, EventArgs e)
        {
            // 원 그리기
            this.shape = 2;

        }

        private void ToolStripBtnBlack_Click(object sender, EventArgs e)
        {
            mypen.Color = Color.Black;
        }

        private void ToolStripBtnRed_Click(object sender, EventArgs e)
        {
            mypen.Color = Color.Red;
        }

        private void ToolStripBtnGreen_Click(object sender, EventArgs e)
        {
            mypen.Color = Color.Green;
        }

        private void ToolStripBtnBlue_Click(object sender, EventArgs e)
        {
            mypen.Color = Color.Blue;
        }

        private void ToolStripBtnLine_Click(object sender, EventArgs e)
        {
            // 직선 그리기
            this.shape = 0;
        }

        private void ToolStripBtnRect_Click(object sender, EventArgs e)
        {
            // 사각형 그리기
            this.shape = 1;
        }

        private void ToolStripBtnCircle_Click(object sender, EventArgs e)
        {
            // 원 그리기
            this.shape = 2;
        }

        private void ToolStripColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                mypen.Color = colorDialog1.Color;
            }
        }
    }
}
