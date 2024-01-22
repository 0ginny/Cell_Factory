using MES_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace test_base.Properties
{
    public partial class Product : Form
    {
        // 클래스 전역 선언
        Product_Details Details;

        public Product()
        {
            InitializeComponent();
            hopeDatePicker1.Visible = false;

            // 클래스 객체 생성
            Details = new Product_Details();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            hopeDatePicker1.Size = new System.Drawing.Size(250, 270);
            hopeDatePicker1.Visible = true;
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Product_Load(object sender, EventArgs e)
        {

        }

        private void hopeDatePicker1_Click(object sender, EventArgs e)
        {
            hopeDatePicker1.Visible = false;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)// stacking 그리드뷰의 셀을 선택하면 호출되는 메소드
        {
            // 선택한 행의 정보를 전달하여 그리드뷰에 셀의 정보를 출력
            Details.Lot_gridview(dataGridView1.Rows[e.RowIndex], dataGridView2);
        }
    }
}
