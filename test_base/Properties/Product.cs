using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_base.Properties
{
    public partial class Product : Form
    {
        Product_Details pd;
        CSS css;
        public Product()
        {
            InitializeComponent();


            panel17.Visible = false;
            dataGridView1.ReadOnly = true; // DataGridView를 초기에 읽기 전용으로 설정

            pd = new Product_Details();
            css = new CSS();

            //패널 라운드
            css.ApplyRoundedBorder(panel2, 20, ColorTranslator.FromHtml("#D1D9E7"), 2);
            css.ApplyRoundedBorder(panel3, 20, ColorTranslator.FromHtml("#D1D9E7"), 2);
            css.ApplyRoundedBorder(panel5, 20, ColorTranslator.FromHtml("#D1D9E7"), 2);
            css.ApplyRoundedBorder(panel6, 20, ColorTranslator.FromHtml("#D1D9E7"), 2);
            css.ApplyRoundedBorder(panel17, 20, ColorTranslator.FromHtml("#D1D9E7"), 2);
            css.ApplyRoundedBorder(button1, 20, ColorTranslator.FromHtml("#D1D9E7"), 2);
            css.ApplyRoundedBorder(button3, 20, ColorTranslator.FromHtml("#D1D9E7"), 2);


        }

        private void Product_Load_1(object sender, EventArgs e)
        {
            
            //pd.Plan_Order_list(dataGridView1);
            //pd.Fin_Order_list(dataGridView3);
            
        }



        private void button4_Click(object sender, EventArgs e)
        {
            panel17.Visible = false;
        }

        /// <summary>
        /// 검색 범위 저장
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            // 시작날짜 비교
            DateTime startDate = hopeDatePicker1.Date;
            DateTime endDate = hopeDatePicker2.Date;
            int compareResult = DateTime.Compare(startDate, endDate);

            if (compareResult > 0)
            {
                // 시작 날짜가 종료 날짜보다 미래에 있는 경우
                MessageBox.Show("시작 날짜는 종료 날짜보다 이전이어야 합니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // 오류 처리 등 추가 작업 수행
            }
            else
            {
                // 시작 날짜가 종료 날짜와 같거나 과거인 경우
                pd.start_date = startDate.ToString("yyyy-MM-dd");
                pd.end_date = endDate.ToString("yyyy-MM-dd");
                panel17.Visible = false;
                //목록 변경
                pd.Plan_Order_list(dataGridView1);
                pd.Fin_Order_list(dataGridView3);
                dataGridView4.Rows.Clear();
                dataGridView2.Rows.Clear();

                // 필요한 작업 수행
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            // AddOrder 폼을 생성
            AddOrder addOrderForm = new AddOrder();

            // 현재 폼 위에 Modal로 열기
            addOrderForm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel17.Visible = true;
            hopeDatePicker1.Date = DateTime.MinValue;
            hopeDatePicker2.Date = DateTime.MinValue;
            label_clear();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pd.Cell_list_inStack(dataGridView2, dataGridView4);
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pd.Stack_list_inOrder(dataGridView3, dataGridView2);

        }

        private void hopeDatePicker1_onDateChanged(DateTime newDateTime)
        {
            label10.Text = hopeDatePicker1.Date.ToString("yyyy년 MM월 dd일");
            label10.Visible = true;
            label8.Visible = true;
        }

        private void hopeDatePicker2_onDateChanged(DateTime newDateTime)
        {
            label9.Text = hopeDatePicker2.Date.ToString("yyyy년 MM월 dd일");
            label9.Visible = true;

        }

        private void label_clear()
        {
            label10.Visible = false;
            label9.Visible =  false;
            label8.Visible = false;
        }
    }
}
