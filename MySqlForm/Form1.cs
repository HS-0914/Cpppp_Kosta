using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace MySqlForm
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = DBHelper.GetConnection();
                conn.Open();
                //Console.WriteLine("MySQL 연결 성공");
                MessageBox.Show("MySQL 연결 성공");
            }
            catch(Exception ex)
            {
                //Console.WriteLine("MySQL 연결 실패 : " + ex.Message);
                MessageBox.Show("MySQL 연결 실패 : " + ex.Message);
            }
        }
    }
    public class DBHelper
    {
        private static string connStr = "Server=127.0.0.1;Port=3306;Database=mysql;Uid=root;Pwd=123456;Charset=utf8";
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connStr);
        }
    }

}
