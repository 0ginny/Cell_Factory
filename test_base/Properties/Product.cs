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
            
            pd.Plan_Order_list(dataGridView1);
            
            pd.Fin_Order_list(dataGridView3);
            
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            panel17.Size = new System.Drawing.Size(500, 320);
            panel17.Visible = true;
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void hopeDatePicker1_Click(object sender, EventArgs e)
        {
            hopeDatePicker1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel17.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel17.Visible = false;
        }

        private void hopeDatePicker1_Click_1(object sender, EventArgs e)
        {

        }
        private void hopeDatePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void hopeDatePicker2_Click(object sender, EventArgs e)
        {
            label9.Text = hopeDatePicker1.Date.ToString("yyyy년 MM월 dd일"); // 날짜 형식은 원하는 대로 설정
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
        }

        private void hopeDatePicker2_onDateChanged(DateTime newDateTime)
        {
            label9.Text = hopeDatePicker2.Date.ToString("yyyy년 MM월 dd일");
        }
    }
}
