using MySqlX.XDevAPI.Relational;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        string select_order;
        string select_stack;

        DataGridView dgv_stack;
        string chk = "0";
        /// <summary>
        /// 선택된 오더의 스택들을 보여주는 매서드, 이벤트 안에 넣어야함.
        /// </summary>
        /// <param name="dgv1"></param>
        /// <param name="dgv2"></param>
        public void Stack_list_inOrder(DataGridView dgv1,  DataGridView dgv2)
        {
            dgv_stack = dgv2;
            DataGridViewRow row = dgv1.SelectedRows[0];
            select_order = row.Cells[0].Value.ToString();

            string sql = $@"select 
                            stacking_id,
                            presure as 프레스압,
                            weld_temp as 용접온도,
                            cycle_time as 싸이클타임
                            from stacking
                            where ord_id = '{select_order}';";
            //DataTable dt = my.GetDataToTable(sql);

            //foreach (DataRow dr in dt.Rows)
            //{
            //    chk = dr[4].ToString();
            //    dgv2.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
            //}

            my.fillDataGrid(sql,dgv_stack);
            //dgv_stack.Columns[5].Visible = false;

            // 숨기고자 하는 열의 인덱스 (4번째 열)
            //int columnIndexToHide = 4;
            //dgv_stack.Columns[columnIndexToHide].Visible = false;
            dgv_stack.ClearSelection();
        }

        // 4번째 열이면서 값이 1인 경우
         private void Dgv2_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string pcodeValue = dgv_stack.Rows[rowIndex].Cells["stacking_id"].Value.ToString();

            DataRow[] matchingRows = getErrorStack().Select("stacking_id = '" + pcodeValue + "'");

            // 만약 dt2에 pcode값이 존재하면 해당 행의 배경색을 변경
            if (matchingRows.Length > 0)
            {
                SetCellStyle(row: dgv_stack.Rows[rowIndex], backColor: Color.Yellow);
            }
            else
            {
                // dt2에 pcode값이 없는 경우 기본 스타일 유지
                SetCellStyle(row: dgv_stack.Rows[rowIndex], backColor: dgv_stack.DefaultCellStyle.BackColor);
            }
        }

        private void SetCellStyle(DataGridViewRow row, Color backColor)
        {
            row.DefaultCellStyle.BackColor = backColor;
            // 여기서 필요에 따라 다른 스타일 변경을 수행할 수 있음
        }


        public DataTable getErrorStack()
        {
            string SQL = $@"select 
                            stacking_id,
                            where ord_id = '{select_order}'
                            and not b_test2 ; ";
            return my.GetDataToTable(SQL);
        }



        public void Cell_list_inStack(DataGridView dgv1, DataGridView dgv2)
        {
            DataGridViewRow row = dgv1.SelectedRows[0];
            select_stack = row.Cells[0].Value.ToString();

            string sql = $@"select 
                            cell_id,
                            voltage,
                            contain,
                            surface
                            from cell
                            where stacking_id = '{select_stack}';";

            DataTable dt = my.GetDataToTable(sql);
            dgv2.Rows.Clear();
            // DataGridView에 데이터 추가
            foreach (DataRow dr in dt.Rows)
            {
                string cell_id = dr["cell_id"].ToString();
                string contain = dr["contain"].ToString();
                string surface = dr["surface"].ToString();
                string voltage = dr["voltage"].ToString();

                voltage = $"{voltage} V";
                contain = $"{contain} %";
                surface = surface + " μm";


                // DataGridView에 행 추가
                dgv2.Rows.Add(cell_id, voltage, contain, surface);
            }


            dgv2.ClearSelection();
        }
    }
}
