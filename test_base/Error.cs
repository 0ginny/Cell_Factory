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
using ReaLTaiizor.Controls;

namespace test_base
{
    public partial class Error : Form
    {
        public Error()
        {
            InitializeComponent();
            hopeDatePicker1.Visible = false;

            // 초기에 콤보박스에 A셀, B셀, C셀 추가
            comboBox1.Items.Add("A셀");
            comboBox1.Items.Add("B셀");
            comboBox1.Items.Add("C셀");

            // 오늘 날짜를 label2에 표시
            label2.Text = DateTime.Now.ToString("yyyy년 MM월 dd일");
            
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

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Error_Load(object sender, EventArgs e)
        {
            weldingDG.Rows.Add("온도", "1200", "10시 15분 42초");
            weldingDG.Rows.Add("압력", "50", "11시 15분 42초");

            SellDG.Rows.Add("이물질", "0.04", "09시 15분 42초");
            SellDG.Rows.Add("전압", "4.2", "15시 15분 42초");
            SellDG.Rows.Add("표면 결함", "0.12", "17시 15분 42초");



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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 콤보박스에서 선택한 항목에 대한 동작을 정의
            string selectedCell = comboBox1.SelectedItem as string;

            if (selectedCell != null)
            {
                // 여기에 선택한 항목에 대한 동작을 추가하세요.
                MessageBox.Show($"선택한 셀: {selectedCell}");
            }
        }

        private void parrotPieGraph1_Click(object sender, EventArgs e)
        {

        }
    }
}
