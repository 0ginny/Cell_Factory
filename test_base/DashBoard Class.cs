using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace test_base
{
    internal class DashBord_Class
    {
        // mysql에 접속하기 위한 전역 변수
        mysql mysql;

        // 선택한 제품의 종류를 저장하기 위한 변수
        public string btn_state { get; set; } = null;

        /// <summary>
        /// 선택 제품 저장
        /// </summary>
        /// <param name="btn">선택 제품 저장</param>
        public void change_state(Button btn)
        {
            btn_state = btn.Text;
        }

        /// <summary>
        /// 발주 제품을 데이터베이스에 저장
        /// </summary>
        /// <param name="txt">발주 제품을 데이터베이스에 저장</param>
        public void send_order(TextBox text)
        {

            // 발주 코드를 어떻게 넣을 것인가??----------------------

            string sql = $@"INSERT INTO #### 
                            VALUES ('{btn_state}','{Int32.Parse(text.Text.ToString())})";
            
            mysql.sendsql(sql);
        }

        /// <summary>
        /// 대쉬보드 그리드뷰, 차트 출력 메서드 호출 메서드
        /// </summary>
        /// <param name="dataGridView">불량내역 그리드뷰 출력 메서드</param>
        /// <param name="chart1">생산량 차트 출력 메서드</param>
        /// <param name="chart2">용접온도 차트 출력 메서드</param>
        public void Display(DataGridView dataGridView, Chart chart1, Chart chart2)
        {
            // 불량내역 그리드뷰 출력 메서드 호출
            fillDataGrid(dataGridView);

            // 생산량 차트 출력 메서드 호출
            Production_Quantity(chart1);

            // 용접온도 차트 출력 메서드 호출
            Welding_Temp(chart2);
        }

        /// <summary>
        /// 불량 내역 데이터그리드 출력
        /// </summary>
        /// <param name="dgv">불량 내역 데이터그리드 출력</param>
        public void fillDataGrid(DataGridView dgv)
        {

            // (판단시간), (위치 : 셀, 스태킹) , (원인 : 각 원인)


            string sql = $@"SELECT  COUNT(*) as '횟수'
                            FROM stacking_test";

            mysql.fillDataGrid(sql, dgv);
        }

        /// <summary>
        /// 생산량 차트 출력
        /// </summary>
        /// <param name="chart">생산량 차트 출력</param>
        public void Production_Quantity(Chart chart)
        {
            string query = $@"SELECT #### 
                              FROM ####";

            mysql.fillDataChart(query, chart);
        }

        /// <summary>
        /// 용접온도 차트 출력
        /// </summary>
        /// <param name="chart">용접온도 차트 출력</param>
        public void Welding_Temp(Chart chart)
        {
            string query = $@"SELECT #### 
                              FROM ####";

            mysql.fillDataChart(query, chart);
        }
    }
}
