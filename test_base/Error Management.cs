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

namespace test_base
{
    internal class Error_Management
    {
        // mysql에 접속하기 위한 전역 변수
        mysql mysql;

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

            mysql.fillDataGrid(query, dataGridView);
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

            mysql.fillDataDualChart(query, chart1, chart2);
        }

        // 용접불량 그리드뷰
        public void Welding_Error_Gridview(string Selectdate, string Selectproduct, DataGridView dataGridView)
        {
            //
            string query = $"SELECT #### COUNT(*) as count " +
                           $"FROM stacking_test " +
                           $"WHERE date = '{Selectdate}' AND #### = '{Selectproduct}' AND test2 = #### ";

            mysql.fillDataGrid(query, dataGridView);
        }

        // 용접 불량 차트 2개
        public void Welding_Error_Chart(string Selectdate, string Selectproduct, Chart chart1, Chart chart2)
        {
            //
            string query = $"SELECT #### COUNT(*) as count " +
                           $"FROM stacking_test " +
                           $"WHERE date = '{Selectdate}' AND #### = '{Selectproduct}' AND test2 = #### ";

            mysql.fillDataDualChart(query, chart1, chart2);
        }
    }
}
