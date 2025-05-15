using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace MySqlCon
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStr = "Server=127.0.0.1;Port=3306;Database=mysql;Uid=root;Pwd=123456;Charset=utf8";
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                Console.WriteLine("MySQL 연결 성공");
            }
            catch (Exception ex)
            {
                Console.WriteLine("MySQL 연결 실패 : " + ex.Message);
            }
        }
    }
}
