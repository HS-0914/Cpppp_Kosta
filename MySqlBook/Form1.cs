using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace MySqlBook
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                string sql = $"insert into bookinfo (title, author, publisher, publishdate, price) values " +
                    $"('{txtTitle.Text}', '{txtAuthor.Text}', '{txtPulblisher.Text}', " +
                    $"'{dtpPublishDate.Value:yyyy-MM-dd HH:mm:ss}', '{txtPrice.Text}');";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            LoadBooks();
            // ;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            LoadBooks();
        }
        private void LoadBooks()
        {
            using(MySqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                string sql = "select * from bookinfo";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvBooks.DataSource = dt;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (dgvBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("수정할 도서를 선택하세요");
                return;
            }

            int rowIndex = dgvBooks.SelectedRows[0].Index;
            int bookid = Convert.ToInt32(dgvBooks.Rows[rowIndex].Cells["id"].Value);

            string title = txtTitle.Text.Trim();
            string author = txtAuthor.Text.Trim();
            string publisher = txtPulblisher.Text.Trim();
            DateTime publishDate = dtpPublishDate.Value;
            int price;

            if(dgvBooks.SelectedRows.Count == 0)
            {
                return;
            }

            if(!int.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("가격은 숫자여야합니다.");
                return;
            }

            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();

                string sql = $"update bookinfo set title='{title}', author = '{author}', " +
                    $"publisher='{publisher}', publishdate = '{publishDate:yyyy-MM-dd HH:mm:ss}', price = {price} " +
                    $"where id = {bookid}";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("도서 업데이트 됨");
            LoadBooks();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgvBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("삭제할 도서를 선택하세요");
                return;
            }

            int bookid = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells["id"].Value);
            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();

                string sql = "delete from bookinfo where id=@id";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", bookid);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("도서 삭제 됨");
            LoadBooks();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = DBHelper.GetConnection();
                conn.Open();
                //Console.WriteLine("MySQL 연결 성공");
                MessageBox.Show("MySQL 연결 성공");
            }
            catch (Exception ex)
            {
                //Console.WriteLine("MySQL 연결 실패 : " + ex.Message);
                MessageBox.Show("MySQL 연결 실패 : " + ex.Message);
            }
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            //MessageBox.Show("클릭");
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBooks.Rows[e.RowIndex];

                txtTitle.Text = row.Cells["title"].Value.ToString();
                txtAuthor.Text = row.Cells["author"].Value.ToString();
                txtPulblisher.Text = row.Cells["publisher"].Value.ToString();

                if (DateTime.TryParse(row.Cells["PublishDate"].Value.ToString(), out DateTime date))
                {
                    dtpPublishDate.Value = date;
                }
                txtPrice.Text = row.Cells["price"].Value.ToString();
            }
        }
    }

    public class DBHelper
    {
        private const string SERVER = "127.0.0.1";
        private const string PORT = "3306";

        private static string connStr =
            $"Server={SERVER};Port={PORT};Database=kosta;Uid=root;Pwd=123456;Charset=utf8";
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connStr);
        }
    }
}
