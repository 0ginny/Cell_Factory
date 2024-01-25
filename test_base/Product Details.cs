using MySqlX.XDevAPI.Relational;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace test_base
{
    internal class Product_Details
    {
        // mysql에 접속하기 위한 전역 변수
        mysql my;

        public Product_Details()
        {
            my = new mysql();
        }
        /// <summary>
        /// 달력의 날짜를 선택시 선택한 날짜를 기준으로 >Stacking 데이터를 조회하여 그리드뷰에 출력
        /// </summary>
        /// <param name="Selectdate">선택한 날짜의 정보를 받는 변수</param>
        /// <param name="dataGridView">Stacking 데이터를 그리드뷰에 출력</param>
        public void stack_gridview(DateTime Selectdate, DataGridView dataGridView)
        {
            // 선택한 날짜를 받을 변수
            string date = Selectdate.ToString("yyyy-MM-dd");

            // 선택한 날짜를 기준으로 스태킹 시작시간의 내림차순으로 조회하는 쿼리문
            // 출력 순서 : 스택킹id / 불량여부 / 스태킹 시작시간 / 프레스 압력 / 양품시 이송완료 시간 / 불량시 처리완료 시간
            string query = $"SELECT stacking, test2, stacking_Sttime, presure, good_Drtime, faulty_Drtime " +
                           $"FROM stacking_test WHERE date = '{date}' ORDER BY stacking_Sttime DESC";
            /*
            string query = $@"SELECT A.stacking, A.test2, A.stacking_Sttime, A.presure, A.good_Drtime, A.faulty_Drtime, B.additionalColumn1, B.additionalColumn2
                              FROM stacking_test AS A
                              LEFT JOIN otherTable AS B ON A.someForeignKey = B.somePrimaryKey
                              WHERE A.date = '{date}'
                              ORDER BY A.stacking_Sttime DESC";
            */

            my.fillDataGrid(query, dataGridView);
        }

        /// <summary>
        /// 하나의 스태킹 선택시 해당 스태킹의 Lot 데이터를 조회하여 그리드뷰에 출력
        /// </summary>
        /// <param name="selectedRow">선택한 Stacking 데이터를 받는 변수</param>
        /// <param name="dataGridView">Lot 데이터를 그리드뷰에 출력</param>
        public void Lot_gridview(DataGridViewRow selectedRow, DataGridView dataGridView)
        {
            // 행에서 stacking 정보 가져오기
            string selectedStacking = selectedRow.Cells["stacking"].Value.ToString();

            // 선택한 그리드뷰의 아이템을 기준으로 조회하는 쿼리문
            // 출력 순서 : lotid / 불량 여부 / 
            string query = $"SELECT lotid, test1,  FROM electrode_test WHERE stacking = '{selectedStacking}'";
            // lotid / 투입시각 input_time / 이물질 여부 contaminant / 표면 결함 여부 surface / 전압 voltage / 불량 여부 test1 / 불량 분류 시각 faulty_Cltime / stacking_id stacking / 층수 level / 스태킹 도착 시각 stacking_Artime

            my.fillDataGrid(query, dataGridView);
        }



        //----------------------------------영진

        public string start_date { get; set; } = "2024-01-24";
        public string end_date { get; set; } = "2024-02-24";

        public static string FormatStringToDate(string tdrDate)
        {
            return DateTime.ParseExact(tdrDate, "yyyyMMdd", null).ToString("yyyy-MM-dd");
        }



        public void Plan_Order_list(DataGridView dgv)
        {
            string sql = $@"select 
                            A.ord_id, 
                            A.company, 
                            B.prod_name, 
                            A.ord_num,                             
                            A.ord_time,
                            A.d_date,
                            A.plan_date
                            from 
                            (select * from orders where ord_fin_time is null and
                            d_date between date('{start_date}') and date('{end_date}')+1)
                             as A
                            inner join product as B
                            on A.prod_id = B.prod_id;";

            //my.fillDataGrid(sql, dgv);
            //DataTable dt = my.GetDataToTable(sql);

            //foreach (DataRow row in dt.Rows)
            //{
            //    dgv.Rows.Add(row[0], row[1], row[2], row[3], row[4], FormatStringToDate(row[5].ToString()), FormatStringToDate(row[6].ToString()));
            //}
            my.fillDataGrid_for(sql, dgv,7);
            dgv.ClearSelection();
        }

        public void Fin_Order_list(DataGridView dgv)
        {
            string sql = $@"select 
                            A.ord_id, 
                            A.company, 
                            B.prod_name, 
                            A.ord_num,                             
                            A.d_date,
                            A.ord_fin_time,
                            A.leadtime
                            from 
                            (select * from orders where ord_fin_time is not null and
                            d_date between date('{start_date}') and date('{end_date}')+1)
                             as A
                            inner join product as B
                            on A.prod_id = B.prod_id;";
            my.fillDataGrid_for(sql, dgv, 7);
            dgv.ClearSelection();

        }
    }
}
