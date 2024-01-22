using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES_Project
{
    public partial class UserControlDays : UserControl
    {
        //String connString = "server = localhost;user id=root;database=db_calendar;ssImode=none";
        String connString = "Server=222.108.180.36;" +
                            "Port=3306;" +
                            "Database=mes_1;" +
                            "UID=EDU_STUDENT;" +
                            "PWD=1234;";

        //let us create another static variable for day;
        public static string static_day;
        
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void days(int numday)
        {
            lbdays.Text = numday + "";
            DisplayEvent();
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            //start timer if usercontroldays is click
            //timer1.Start();
            EventForm eventform = new EventForm();
            //eventform.StartPosition = FormStartPosition.CenterScreen;
            eventform.StartPosition = FormStartPosition.CenterParent;

            // 메인 폼의 정중앙에 모달로 이벤트 폼을 띄우기
            eventform.ShowDialog(this);

            //eventform.Show();
        }

        /*
        private void DisplayEvent()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            // 날짜 값이 한 자리일 경우 앞에 0을 추가
            string formattedDay = lbdays.Text.Length == 1 ? "0" + lbdays.Text : lbdays.Text;
            // 날짜 값을 정수로 변환
            int dayValue = int.Parse(formattedDay);
            // 만약 날짜 값이 1보다 작으면 1로 설정
            dayValue = Math.Max(dayValue, 1);
            // 다시 문자열로 변환하여 사용
            formattedDay = dayValue.ToString();

            string sql = @"SELECT
                        po.company_name,
                        pr.prod_name,
                        po.prod_num
                   FROM
                        tb_prod_order po
                   JOIN
                        tb_products pr ON po.prod_code = pr.prod_code
                   WHERE
                        po.D_day = ?";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("po.D_day", $"{Form3.static_year}-{Form3.static_month}-{formattedDay}");

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                // 받아온 데이터를 라벨에 표시
                lbevent.Text = $"{reader["company_name"]} {Environment.NewLine} {reader["prod_name"]} {Environment.NewLine} {reader["prod_num"]}ea";
                // 라벨을 가운데 정렬로 설정
                lbevent.TextAlign = ContentAlignment.MiddleCenter;
            }

            reader.Close();
            cmd.Dispose();
            conn.Close();
        }*/

        /*
        private void DisplayEvent()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            // 날짜 값이 한 자리일 경우 앞에 0을 추가
            string formattedDay = lbdays.Text.Length == 1 ? "0" + lbdays.Text : lbdays.Text;
            // 날짜 값을 정수로 변환
            int dayValue = int.Parse(formattedDay);
            // 만약 날짜 값이 1보다 작으면 1로 설정
            dayValue = Math.Max(dayValue, 1);
            // 다시 문자열로 변환하여 사용
            formattedDay = dayValue.ToString();

            //string sql = @"SELECT po.p_order_id, po.company_name, pr.prod_name, po.prod_num FROM tb_prod_order po JOIN tb_products pr ON po.prod_code = pr.prod_code WHERE po.D_day = ?";
            string sql = @"SELECT A.p_order_id, A.company_name, A.prod_num, A.D_day, A.prod_code, B.fin_o_date, C.prod_name FROM tb_prod_order AS A left JOIN tb_fin_prod_order AS B ON A.p_order_id = B.p_order_id
INNER JOIN tb_products AS C ON A.prod_code = C.prod_code WHERE A.D_day = ?";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("A.D_day", $"{Form3.static_year}-{Form3.static_month}-{formattedDay}");

            MySqlDataReader reader = cmd.ExecuteReader();

            // 첫 번째 데이터를 표시
            if (reader.Read())
            {
                // 받아온 데이터를 라벨에 표시
                lbevent.Text = $"{reader["company_name"]} {Environment.NewLine} {reader["prod_name"]} {Environment.NewLine} {reader["prod_num"]}ea";
                // 라벨을 가운데 정렬로 설정
                lbevent.TextAlign = ContentAlignment.MiddleCenter;

                // 나머지 데이터의 개수를 가져옴
                int additionalDataCount = 0;
                while (reader.Read())
                {
                    additionalDataCount++;
                }

                if (additionalDataCount > 0)
                {
                    // 나머지 데이터의 개수를 라벨에 추가로 표시
                    lbevent.Text += $"{Environment.NewLine} 그 외에 {additionalDataCount}건";
                }
            }

            reader.Close();
            cmd.Dispose();
            conn.Close();
        }*/

        private void DisplayEvent()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            string formattedDay = lbdays.Text.Length == 1 ? "0" + lbdays.Text : lbdays.Text;
            int dayValue = int.Parse(formattedDay);
            dayValue = Math.Max(dayValue, 1);
            formattedDay = dayValue.ToString();

            string sql = @"SELECT A.p_order_id, A.company_name, A.prod_num, A.D_day, A.prod_code, B.fin_o_date, C.prod_name FROM tb_prod_order AS A left JOIN tb_fin_prod_order AS B ON A.p_order_id = B.p_order_id
                   INNER JOIN tb_products AS C ON A.prod_code = C.prod_code WHERE A.D_day = ?";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("A.D_day", $"{Calendar_shipmen_status.static_year}-{Calendar_shipmen_status.static_month}-{formattedDay}");

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string companyName = reader["company_name"].ToString();
                string prodName = reader["prod_name"].ToString();
                string prodNum = reader["prod_num"].ToString();
                string finODate = reader["fin_o_date"] != DBNull.Value ? reader.GetDateTime("fin_o_date").ToString("yyyy-MM-dd") : null;


                // Set label text
                lbevent.Text = $"{companyName} {Environment.NewLine} {prodName} {Environment.NewLine} {prodNum}ea";

                // Set label text color based on fin_o_date presence
                lbevent.ForeColor = string.IsNullOrEmpty(finODate) ? Color.Red : Color.Blue;

                // Center-align the label
                lbevent.TextAlign = ContentAlignment.MiddleCenter;

                int additionalDataCount = 0;
                while (reader.Read())
                {
                    additionalDataCount++;
                }

                if (additionalDataCount > 0)
                {
                    lbevent.Text += $"{Environment.NewLine} 그 외에 {additionalDataCount}건";
                }
            }

            reader.Close();
            cmd.Dispose();
            conn.Close();
        }

        /*private void DisplayEvent()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            // 날짜 값이 한 자리일 경우 앞에 0을 추가
            string formattedDay = lbdays.Text.Length == 1 ? "0" + lbdays.Text : lbdays.Text;
            // 날짜 값을 정수로 변환
            int dayValue = int.Parse(formattedDay);
            // 만약 날짜 값이 1보다 작으면 1로 설정
            dayValue = Math.Max(dayValue, 1);
            // 다시 문자열로 변환하여 사용
            formattedDay = dayValue.ToString();

            string sql = @"SELECT
                    po.*,
                    pr.prod_name
               FROM
                    tb_prod_order po
               JOIN
                    tb_products pr ON po.prod_code = pr.prod_code
               WHERE
                    po.D_day = ?";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("po.D_day", $"{Form3.static_year}-{Form3.static_month}-{formattedDay}");

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lbevent.Text = reader["event"].ToString();
            }

            reader.Close();
            cmd.Dispose();
            conn.Close();
        }*/

        //Create a new method to display event
        /*public void displayEvent()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            String sql = "SELECT * FROM krs_test4 where date = ?";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;

            // 날짜 값이 한 자리일 경우 앞에 0을 추가
            string formattedDay = lbdays.Text.Length == 1 ? "0" + lbdays.Text : lbdays.Text;
            // 날짜 값을 정수로 변환
            int dayValue = int.Parse(formattedDay);
            // 만약 날짜 값이 1보다 작으면 1로 설정
            dayValue = Math.Max(dayValue, 1);
            // 다시 문자열로 변환하여 사용
            formattedDay = dayValue.ToString();

            //cmd.Parameters.AddWithValue("date", Form3.static_year + "-" + Form3.static_month + "-" + lbdays.Text);
            cmd.Parameters.AddWithValue("date", Form3.static_year + "-" + Form3.static_month + "-" + formattedDay);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lbevent.Text = reader["event"].ToString();
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }*/


        //create a timer for auto display event if new event is added

        /*private void timer1_Tick(object sender, EventArgs e)
        {
            //call the displayEvent method
            //displayEvent();
        }*/
    }
}
