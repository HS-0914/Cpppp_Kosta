using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if(txtName.Text == ""|| txtName.Text == "" || txtOrg.Text == "" )
            {
                MessageBox.Show("공백 금지");
            }
            else
            {
                string name = txtName.Text;
                string phone = txtPhone.Text;
                string org = txtOrg.Text;
                string[] strArr = new string[] { name, phone, org };

                ListViewItem item = new ListViewItem(strArr);
                listView1.Items.Add(item);
            }


            txtName.Clear();
            txtPhone.Clear();
            txtOrg.Clear();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = listView1.FocusedItem.Index;
            listView1.Items.RemoveAt(selectedIndex);
        }
    }
}
