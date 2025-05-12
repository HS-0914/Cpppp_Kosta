using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public class WinForm : Form
    {
        public WinForm()
        {
            // c# 제공 delegate -> EventHandler
            this.Click += new EventHandler(ClickEvent);
        }
        private void ClickEvent(object sender, EventArgs e)
        {
            MessageBox.Show("마우스 클릭 이벤트를 처리합니다.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Application.Run(new WinForm());
        }
    }
}
