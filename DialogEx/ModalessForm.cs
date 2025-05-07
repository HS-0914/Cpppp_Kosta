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
    public partial class ModalessForm: Form
    {
        public string str;
        public ModalessForm()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (str.Contains(txtSearch.Text)){
                MessageBox.Show("성공");
            }
            else
            {
                MessageBox.Show("실패");
            }
        }
    }
}
