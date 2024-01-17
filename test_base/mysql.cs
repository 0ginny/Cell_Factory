using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_base

{
    internal class mysql
    {
        public string connect_str { get; set; } = "Server=222.108.180.36;Port=3306;Database=mes_1;Uid=EDU_STUDENT;Pwd=1234";

        public DataTable GetDataToTable(string SQL)
        {
            DataTable dt = new DataTable();
            try
            {
                MySqlConnection conn = new MySqlConnection(connect_str);
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = SQL;
                da.SelectCommand = cmd;
                conn.Open();
                da.Fill(dt);
                conn.Close();
            }
            catch {
                Console.WriteLine($"조회실패, {SQL}");
            }
            return dt;
        }


        public void InsertData(string table_str, string data_str)
        {
            string insertQuery = $"INSERT INTO {table_str} VALUES ({data_str}) ; ";

            try
            {

                using (MySqlConnection connection = new MySqlConnection(connect_str))
                {
                    Console.WriteLine(insertQuery);

                    connection.Open();
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);

                    // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                    if (command.ExecuteNonQuery() == 1)
                    {
                        //Console.WriteLine("인서트 성공");
                    }
                    else
                    {
                        Console.WriteLine(insertQuery, "인서트 실패");
                    }

                }
            }
            catch {
                Console.WriteLine(insertQuery, "인서트 실패");    
            }
            

        }

        public void deleteData(string table_str, string where_str)
        {
            string insertQuery = $"delete from {table_str} where {where_str} ;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connect_str))
                {
                    Console.WriteLine(insertQuery);

                    connection.Open();
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);

                    // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                    if (command.ExecuteNonQuery() == 1)
                    {
                        
                    }
                    else
                    {
                        Console.WriteLine("삭제 실패");
                    }

                }
            }
            catch
            {
                //Console.WriteLine(insertQuery, "삭제 실패");

            }

        }


        public void sendsql(string insertQuery)
        {

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connect_str))
                {

                    Console.WriteLine(insertQuery);
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);
                    // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                    if (command.ExecuteNonQuery() == 1)
                    {

                    }
                    else
                    {
                        Console.WriteLine("쿼리문 인식 실패");
                    }
                }
            }
            catch
            {
                //Console.WriteLine(insertQuery, "전송 실패");
            }
        }

        public void fillDataGrid(string sql, DataGridView dgv)
        {
            dgv.DataSource = GetDataToTable(sql);
        }






    }
}
