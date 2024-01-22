using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace test_base
{
    public partial class Error : Form
    {
        // 클래스 전역 선언
        Error_Management error;

        public Error()
        {
            InitializeComponent();

            hopeDatePicker1.Visible = false;

            // 클래스 객체 생성
            error = new Error_Management();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Error_Load(object sender, EventArgs e)
        {

        }


        private void hopeDatePicker1_Click(object sender, EventArgs e)
        {
            hopeDatePicker1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hopeDatePicker1.Size = new System.Drawing.Size(250, 270);
            hopeDatePicker1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)// 날짜와 제품의 종류에 대한 불량 검색을 위한 버튼
        {
            // 선택한 날짜와 제품의 종류를 그리드뷰 2개, 차트 4개에 출력
            // error.Error_view(dateTimePicker1, comboBox1.SelectedItem.ToString(), dataGridView1, dataGridView2, chart1, chart2, chart3, chart4);

        }
    }
}
