using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogEx
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnModal_Click(object sender, EventArgs e)
        {
            ModalForm modal = new ModalForm();
            modal.ShowDialog();
        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            ModalessForm modal = new ModalessForm();
            modal.Show();
        }
    }
}
