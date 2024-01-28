using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Runtime.InteropServices.JavaScript.JSType;
using test_base.Properties;
using System.Data;

namespace test_base
{
    internal class Error_Management
    {
        // mysql에 접속하기 위한 전역 변수
        mysql my;

        public Error_Management()
        {
            my = new mysql();
        }


        //----------------------------------지문

        // 날짜와 제품의 종류를 선택하고 검색 버튼을 누르면
        // 특정 시간 범위에 발생한 불량의 종류와 횟수를 차트와 그리드뷰에 출력

        // 차트에는 불량의 종류와 횟수를 출력
        // 그리드뷰에는 특정 시간 범위에 발생한 불량의 종류와 횟수를 출력

        public void Error_view(DateTime Selectdate, string Selectproduct, DataGridView dataGridView1, DataGridView dataGridView2, Chart chart1, Chart chart2, Chart chart3, Chart chart4)
        {
            // 선택한 날짜를 받을 변수
            string date = Selectdate.ToString("yyyy-MM-dd");

            // 셀 불량 그리드뷰
            Cell_Error_Gridview(date, Selectproduct, dataGridView1);
            
            // 셀 불량 차트 2개
            Cell_Error_Chart(date, Selectproduct, chart1, chart2);

            // 용접 불량 그리드뷰
            Welding_Error_Gridview(date, Selectproduct, dataGridView2);
            
            // 용접 불량 차트 2개
            Welding_Error_Chart(date, Selectproduct, chart3, chart4);
        }

        /// <summary>
        /// 셀 불량 그리드뷰
        /// </summary>
        /// <param name="Selectdate">선택한 날짜를 받을 변수</param>
        /// <param name="Selectproduct">선택한 제품을 받을 변수</param>
        /// <param name="dataGridView">그리드뷰를 그릴 명령</param>
        public void Cell_Error_Gridview(string Selectdate, string Selectproduct, DataGridView dataGridView)
        {
            // 셀 불량의 종류와 시간을 조회할 쿼리
            // 이물질 여부 contaminant / 표면 결함 surface / 전압 voltage / 불량 여부 test1
            string query = $"SELECT contaminant, surface, voltage, COUNT(*) as '횟수' " +
                           $"FROM electrode_test " +
                           $"WHERE date = '{Selectdate}' AND #### = '{Selectproduct}' AND test1 = #### " +
                           $"GROUP BY contaminant, surface, voltage";

            my.fillDataGrid(query, dataGridView);
        }

        // 셀 불량 차트 2개
        public void Cell_Error_Chart(string Selectdate, string Selectproduct, Chart chart1, Chart chart2)
        {
            // 셀 불량의 종류와 시간을 조회할 쿼리
            // 이물질 여부 contaminant / 표면 결함 surface / 전압 voltage / 불량 여부 test1
            string query = $"SELECT contaminant, surface, voltage, COUNT(*) as count " +
                           $"FROM electrode_test " +
                           $"WHERE date = '{Selectdate}' AND #### = '{Selectproduct}' AND test1 = #### " +
                           $"GROUP BY contaminant, surface, voltage";

            my.fillDataDualChart(query, chart1, chart2);
        }

        // 용접불량 그리드뷰
        public void Welding_Error_Gridview(string Selectdate, string Selectproduct, DataGridView dataGridView)
        {
            //
            string query = $"SELECT #### COUNT(*) as count " +
                           $"FROM stacking_test " +
                           $"WHERE date = '{Selectdate}' AND #### = '{Selectproduct}' AND test2 = #### ";

            my.fillDataGrid(query, dataGridView);
        }

        // 용접 불량 차트 2개
        public void Welding_Error_Chart(string Selectdate, string Selectproduct, Chart chart1, Chart chart2)
        {
            //
            string query = $"SELECT #### COUNT(*) as count " +
                           $"FROM stacking_test " +
                           $"WHERE date = '{Selectdate}' AND #### = '{Selectproduct}' AND test2 = #### ";

            my.fillDataDualChart(query, chart1, chart2);
        }


        //--------------------------------------영진
        public string start_date { get; set; } = "2024-01-24";
        public string end_date { get; set; } = "2024-01-24";


        /// <summary>
        /// 셀에러 리스트를 보여주는 메서드
        /// </summary>
        /// <param name="dgv"></param>
        public void Cell_Error_list(DataGridView dgv)
        {
            string sql = $@"select 
                            cell_id, 
                            fault_content, 
                            contain, 
                            surface, 
                            voltage, 
                            fault_test_time  from cell
                            where 
                            b_test1 = 1 and
                            fault_test_time BETWEEN DATE('{start_date}') AND DATE_ADD(DATE('{end_date}'), INTERVAL 1 DAY);";

            DataTable dt = my.GetDataToTable(sql);

            // DataGridView에 데이터 추가
            foreach (DataRow dr in dt.Rows)
            {
                string cell_id = dr["cell_id"].ToString();
                string fault_content = dr["fault_content"].ToString();
                string contain = dr["contain"].ToString();
                string surface = dr["surface"].ToString();
                string voltage = dr["voltage"].ToString();
                string fault_test_time = dr["fault_test_time"].ToString();
                string detail;

                // 값에 따라 가공
                switch (fault_content)
                {
                    case "전압불량":
                        detail = $"{voltage} V";
                        break;
                    case "이물질불량":
                        detail =  $"{contain} ppm";
                        break;
                    case "표면결함":
                        detail = surface + " μm"; // 마이크로미터 기호 추가
                        break;
                    // 다른 경우에 대한 추가적인 가공 로직을 여기에 추가할 수 있습니다.
                    default:
                        detail = $"{voltage} V";
                        break;
                }

                // DataGridView에 행 추가
                dgv.Rows.Add(cell_id, fault_content, detail, fault_test_time);
            }
            dgv.ClearSelection();
        }
        
        /// <summary>
        /// 스택불량을 리스트에 보여주는 메서드
        /// </summary>
        /// <param name="dgv"></param>
        public void Stack_Error_list(DataGridView dgv)
        {
            string sql = $@"select 
                        stacking_id,
                        sta_err_cont,
                        presure,
                        weld_temp,
                        fault_fin_time
                        from stacking
                        where 
                        b_test2 = 1 and
                        fault_fin_time BETWEEN DATE('{start_date}') AND DATE_ADD(DATE('{end_date}'), INTERVAL 1 DAY);";


            DataTable dt = my.GetDataToTable(sql);

            // DataGridView에 데이터 추가
            foreach (DataRow dr in dt.Rows)
            {
                string detail;
                // 값에 따라 가공
                switch (dr[1].ToString())
                {
                    case "프레스압 문제":
                        detail = $"{dr[2]} bar";
                        break;
                    case "용접 온도 문제":
                        detail = $"{dr[3]} {"\u2103"}";
                        break;
                    // 다른 경우에 대한 추가적인 가공 로직을 여기에 추가할 수 있습니다.
                    default:
                        detail = $"{dr[2]} bar";
                        break;
                }

                // DataGridView에 행 추가
                dgv.Rows.Add(dr[0], dr[1], detail, dr[4]);
            }
            dgv.ClearSelection();
        }


        public DataTable Cerr_cnt_table()
        {
            string sql = $@"
select
fault_content,
count(cell_id)
from cell
where
fault_test_time BETWEEN DATE('{start_date}') AND DATE_ADD(DATE('{end_date}'), INTERVAL 1 DAY)
group by fault_content;
                            ";
            return my.GetDataToTable (sql);

        }

        public DataTable Serr_cnt_table()
        {
            string sql = $@"
select 
sta_err_cont,
count(stacking_id)
from stacking
where
fault_fin_time BETWEEN DATE('{start_date}') AND DATE_ADD(DATE('{end_date}'), INTERVAL 1 DAY)
group by sta_err_cont;
                            ";
            return my.GetDataToTable(sql);
        }

        public int volt_err { get; set; } = 0;
        public int contain_err { get; set; } = 0;
        public int surface_err { get; set; } = 0; 
        public int press_err { get; set; } = 0; 
        public int temp_err { get; set; } = 0;


        public void setPieChartData()
        {
            DataTable dt_cell = Cerr_cnt_table();
            DataTable dt_stack = Serr_cnt_table();

            foreach (DataRow dr in dt_cell.Rows)
            {
                Console.WriteLine(dr[0].ToString() + "      " + int.Parse(dr[1].ToString()));

                switch (dr[0].ToString())
                {
                    case "전압불량":
                        volt_err = int.Parse(dr[1].ToString());
                        break;
                    case "이물질불량":
                        contain_err = int.Parse(dr[1].ToString());
                        break;
                    case "표면결함":
                        surface_err = int.Parse(dr[1].ToString());
                        break;
                    default:
                        break;
                }
            }

            foreach (DataRow dr in dt_stack.Rows)
            {

                Console.WriteLine(dr[0].ToString() + "      " + int.Parse(dr[1].ToString()));
                switch (dr[0].ToString())
                {
                    case "프레스압 문제":
                        press_err = int.Parse(dr[1].ToString());
                        break;
                    case "용접 온도 문제":
                        temp_err = int.Parse(dr[1].ToString());
                        break;
                    default:
                        break;
                }
            }
        }




    }
}
