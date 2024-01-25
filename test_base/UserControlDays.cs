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
        // 데이터베이스 연결 문자열
        String connString = "Server=222.108.180.36;" +
                            "Port=3306;" +
                            "Database=robot_3;" +
                            "UID=EDU_STUDENT;" +
                            "PWD=1234;";

        // 다른 Form에서 현재 선택된 날짜를 전달하기 위한 정적 변수
        public static string static_day;

        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        // 해당 UserControl에 날짜를 표시하는 메서드
        public void days(int numday)
        {
            lbdays.Text = numday + "";
            DisplayEvent();
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            // 현재 선택된 날짜를 정적 변수에 저장
            static_day = lbdays.Text;

            // 이벤트 폼을 생성하고 모달로 띄움
            EventForm eventform = new EventForm();
            eventform.StartPosition = FormStartPosition.CenterParent;
            eventform.ShowDialog(this);
        }

        // 해당 날짜에 대한 이벤트를 데이터베이스에서 조회하고, 결과에 따라 라벨에 표시하는 메서드
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

            // SQL 쿼리
            string sql = @"select  
                            A.ord_id,
                            A.company,
                            B.prod_name,
                            A.ord_num,
                            A.ord_fin_time,
                            A.d_date
                            from orders as A
                            inner join product as B
                            on A.prod_id = B.prod_id 
                            WHERE A.d_date = ?";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("A.d_date", $"{Calendar_shipmen_status.static_year}-{Calendar_shipmen_status.static_month}-{formattedDay}");

            MySqlDataReader reader = cmd.ExecuteReader();

            // 첫 번째 데이터를 표시
            if (reader.Read())
            {
                // 받아온 데이터를 라벨에 표시
                string companyName = reader["company"].ToString();
                string prodName = reader["prod_name"].ToString();
                string prodNum = reader["ord_num"].ToString();
                string finODate = reader["ord_fin_time"] != DBNull.Value ? reader.GetDateTime("ord_fin_time").ToString("yyyy-MM-dd") : null;

                // 라벨에 텍스트 설정
                lbevent.Text = $"{companyName} {Environment.NewLine} {prodName} {Environment.NewLine} {prodNum}ea";

                // 완료 날짜의 존재 여부에 따라 라벨 텍스트 색상 설정
                lbevent.ForeColor = string.IsNullOrEmpty(finODate) ? Color.Red : Color.Blue;

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
        }
    }
}
