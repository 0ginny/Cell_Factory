using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
//using static MES_Project.Monitoring;
//using static MES_Project.MonitoringFacilityOperationStatus;

namespace MES_Project
{
    public partial class EventForm : Form
    {
        
        public EventForm()
        {
            InitializeComponent();
            List<string[]> ProdOrderDataTB = getProdOrderData();
            ProdOrderDatagrid(ProdOrderDataTB, PorbOrderDatagrid);
        }

        private void EventForm_Load(object sender, EventArgs e)
        {

        }
        public static List<string[]> getProdOrderData()
        {
            List<string[]> ProdOrderDataTB = new List<string[]>();

            string connectionString = "Server=222.108.180.36;Port=3306;Database=mes_1;UID=EDU_STUDENT;PWD=1234;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    //string query = @"SELECT po.*, pr.prod_name FROM tb_prod_order po JOIN tb_products pr ON po.prod_code = pr.prod_code;";
                    string query = @"SELECT A.p_order_id, A.company_name, A.prod_num, A.D_day, A.prod_code, C.prod_name, B.fin_o_date FROM tb_prod_order AS A left JOIN tb_fin_prod_order AS B ON A.p_order_id = B.p_order_id
INNER JOIN tb_products AS C ON A.prod_code = C.prod_code;";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string[] row = new string[reader.FieldCount];
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    row[i] = reader[i].ToString();
                                }
                                ProdOrderDataTB.Add(row);
                            }
                        }
                    }
                }
                else
                {
                    // 연결 실패 처리
                    Console.WriteLine("DB연결 실패!");
                }

            }
            catch (Exception ex)
            {
                // 예외 처리
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return ProdOrderDataTB;
        }
        public static void ProdOrderDatagrid(List<string[]> ProdOrderDataTB, DataGridView PorbOrderDatagrid)
        {
            String ClickDate = Calendar_shipmen_status.static_year + "-" + Calendar_shipmen_status.static_month + "-" + UserControlDays.static_day;
            //System.Windows.Forms.MessageBox.Show($"클릭한 날짜 : {ClickDate}");
            // DataGridView 초기화
            PorbOrderDatagrid.Rows.Clear();
            PorbOrderDatagrid.Columns.Clear();
            PorbOrderDatagrid.RowHeadersVisible = false;

            string[] columnNames = { "주문id", "회사명", "주문갯수", "납기일", "제품코드", "제품명", "완료일자" }; // 원하는 컬럼명으로 변경

            // 각 컬럼에 대한 고정된 너비 설정
            int[] columnWidths = { 80, 100, 60, 100, 60, 100, 100 }; // 원하는 너비로 변경

            // 컬럼 추가 및 너비 설정
            for (int i = 0; i < columnNames.Length; i++)
            {
                string columnName = columnNames[i];
                int columnWidth = columnWidths[i];

                // 컬럼 추가
                PorbOrderDatagrid.Columns.Add(columnName, columnName);

                // 너비 설정
                PorbOrderDatagrid.Columns[columnName].Width = columnWidth;
                PorbOrderDatagrid.Columns[columnName].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                PorbOrderDatagrid.Columns[columnName].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                // 헤더의 텍스트를 가운데 정렬
            }
            /*
            foreach (var rowData in ProdOrderDataTB)
            {
                // D_day가 ClickDate와 같으면 데이터그리드에 추가
                if (DateTime.Parse(rowData[3]) == DateTime.Parse(ClickDate))
                {
                    // 행 추가
                    int rowIndex = PorbOrderDatagrid.Rows.Add(rowData[0], rowData[1], rowData[2], DateTime.Parse(rowData[3]).ToShortDateString(), rowData[4], rowData[5], DateTime.Parse(rowData[6]).ToShortDateString());

                    // 행의 각 셀을 가운데 정렬
                    foreach (DataGridViewCell cell in PorbOrderDatagrid.Rows[rowIndex].Cells)
                    {
                        cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                }
            }*/
            foreach (var rowData in ProdOrderDataTB)
            {
                // D_day가 ClickDate와 같으면 데이터그리드에 추가
                if (DateTime.Parse(rowData[3]) == DateTime.Parse(ClickDate))
                {
                    DateTime finODate;

                    // 파싱이 성공하면 true, 실패하면 false
                    bool parseSuccess = DateTime.TryParse(rowData[6], out finODate);

                    // 행 추가
                    int rowIndex = PorbOrderDatagrid.Rows.Add(
                        rowData[0],
                        rowData[1],
                        rowData[2],
                        DateTime.Parse(rowData[3]).ToShortDateString(),
                        rowData[4],
                        rowData[5],
                        parseSuccess ? finODate.ToShortDateString() : string.Empty
                    );

                    // 행의 각 셀을 가운데 정렬
                    foreach (DataGridViewCell cell in PorbOrderDatagrid.Rows[rowIndex].Cells)
                    {
                        cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                }
            }
        }
    }
}
