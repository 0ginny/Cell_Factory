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

        public Product()
        {
            InitializeComponent();


            panel17.Visible = false;
            dataGridView1.ReadOnly = true; // DataGridView를 초기에 읽기 전용으로 설정

            pd = new Product_Details();

        }

        private void Product_Load_1(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Add("OD20231231001", "LG엔솔", "A제품", "2", "2024년 1월 29일", "12월 31일 09시 35분", "2024년 1월 27일");
            //dataGridView1.Rows.Add("OD20231231002", "LG엔솔", "B제품", "2", "2024년 1월 29일", "12월 31일 10시 35분", "2024년 1월 27일");
            //dataGridView1.Rows.Add("OD20231231003", "LG엔솔", "C제품", "2", "2024년 1월 29일", "12월 31일 11시 35분", "2024년 1월 27일");
            pd.Plan_Order_list(dataGridView1);
            //dataGridView2.Rows.Add("S23122301", "54MP", "1002", "1분03초");
            //dataGridView2.Rows.Add("S23122302", "54MP", "1002", "1분03초");
            //dataGridView2.Rows.Add("S23122303", "54MP", "1002", "1분03초");
            //dataGridView2.Rows.Add("S23122304", "54MP", "1002", "1분03초");
            //dataGridView2.Rows.Add("S23122305", "54MP", "1002", "1분03초");
            //dataGridView2.Rows.Add("S23122306", "54MP", "1002", "1분03초");
            //dataGridView3.Rows.Add("OD20231231001", "LG엔솔", "A제품", "3", "2024년 1월 29일", "완료시간", "2분 15초");
            //dataGridView3.Rows.Add("OD20231231001", "LG엔솔", "A제품", "3", "2024년 1월 29일", "완료시간", "2분 15초");
            pd.Fin_Order_list(dataGridView3);
            //dataGridView4.Rows.Add("A231215001", "4.3", "1.5", "0.15");
            //dataGridView4.Rows.Add("A231215002", "1.7", "1.1", "0.17");
            //dataGridView4.Rows.Add("A231215003", "5.5", "1.2", "0.13");
            //dataGridView4.Rows.Add("B231215004", "3.9", "1.5", "0.16");
            //dataGridView4.Rows.Add("B231215005", "4.1", "1.7", "0.7");
            //dataGridView4.Rows.Add("B231215006", "3.9", "1.3", "0.61");
            //dataGridView4.Rows.Add("C231215007", "4.2", "1.4", "0.43");
            //dataGridView4.Rows.Add("C231215008", "5.0", "1.9", "0.36");
            //dataGridView4.Rows.Add("C231215009", "4.5", "1.0", "0.4");
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
