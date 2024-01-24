using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace test_base
{
    internal class DashBord_Class
    {
        // mysql에 접속하기 위한 전역 변수
        mysql my;

        public string today { get; set; } = "2024-01-24";
        // 선택한 제품의 종류를 저장하기 위한 변수
        public string btn_state { get; set; } = null;

        public DashBord_Class()
        {
            my = new mysql();
        }

        /*
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
            
            my.sendsql(sql);
        }
        */

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

            my.fillDataGrid(sql, dgv);
        }

        /// <summary>
        /// 생산량 차트 출력
        /// </summary>
        /// <param name="chart">생산량 차트 출력</param>
        public void Production_Quantity(Chart chart)
        {
            string query = $@"SELECT #### 
                              FROM ####";

            my.fillDataChart(query, chart);
        }

        /// <summary>
        /// 용접온도 차트 출력
        /// </summary>
        /// <param name="chart">용접온도 차트 출력</param>
        public void Welding_Temp(Chart chart)
        {
            string query = $@"SELECT #### 
                              FROM ####";

            my.fillDataChart(query, chart);
        }



        //---------------------------영진 작성
        /// <summary>
        /// 오늘 착수예정인 주문을 보여준다.
        /// </summary>
        /// <param name="dgv">주문지시가 나타날 데이터 그리드 뷰</param>
        public void plan_order_list(DataGridView dgv)
        {

            string sql = $@"select 
                            A.ord_id, 
                            A.company, 
                            B.prod_name, 
                            A.ord_num, 
                            A.i_fin from 
                            (select * from orders where plan_date = ' {today} ')
                             as A
                            inner join product as B
                            on A.prod_id = B.prod_id;";

            DataTable dt = my.GetDataToTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                Image imageToShow;

                switch (Int16.Parse(dr[4].ToString()))
                {
                    case 1:
                        imageToShow = Properties.Resources.완료;
                        break;
                    case 0:
                        imageToShow = Properties.Resources.진행중;
                        break;
                    case -1:
                        imageToShow = Properties.Resources.대기;
                        break;
                    default:
                        // 기본값을 설정하거나 예외 처리를 수행할 수 있습니다.
                        imageToShow = Properties.Resources.에러발생;
                        break;
                }

                dgv.Rows.Add(dr[2], dr[3],imageToShow);

            }
            dgv.ClearSelection();
        }

        public void today_error_list(DataGridView dgv)
        {
            string sql = $@"select 
                    DATE_FORMAT(fault_test_time,'%H:%i:%s'),
                    fault_content,
                    cell_id
                    from cell
                    where 
                    b_test1 = 1 and
                    fault_test_time like '{today}%';";

            DataTable dt = my.GetDataToTable(sql);

            foreach (DataRow dr in dt.Rows)
            {
                //dgv.Rows.Add("오전 09시 34분 21초", "전압불량", "A231215001");
                dgv.Rows.Add(dr[0], dr[1], dr[2]);
            }
            dgv.ClearSelection();
        }
    }
}
