using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class _250428: Form
    {
        public _250428()
        {
            InitializeComponent();
        }

        // 1
        private void button_1_Click(object sender, EventArgs e)
        {
            int age = int.Parse(input_1.Text);
            if (age > 0 && (age <= 15 || age >= 65))
            {
                result_1.Text = "할인 대상입니다.";
            }
            else
            {
                result_1.Text = "할인 대상이 아닙니다.";
            }
        }
    }
}
