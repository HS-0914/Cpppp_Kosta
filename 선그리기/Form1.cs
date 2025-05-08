using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 선그리기
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            /* x자 그리기
            Pen p = new Pen(Color.Red, 5);
            Point start = new Point(50, 50);
            Point end = new Point(250, 250);
            g.DrawLine(p, start, end);

            start = new Point(250, 50);
            end = new Point(50, 250);
            g.DrawLine(p, start, end);
            */

            /* 사각형 그리기 */
            Pen p = new Pen(Color.Blue, 10);
            Rectangle rc1 = new Rectangle(30, 20, 200, 200);
            g.DrawRectangle(p, rc1);

            Brush b = new SolidBrush(Color.Red);
            Rectangle rc2 = new Rectangle(240, 20, 200, 200);
            g.FillRectangle(b, rc2);
        }
    }
}
