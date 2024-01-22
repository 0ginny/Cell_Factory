using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace test_base
{
    public partial class Dashboard : Form
    {
        // 클래스 전역 선언
        DashBord_Class dash;

        public Dashboard()
        {
            InitializeComponent();
            Load += Dashboard_Load;
            SetHalfDoughnutChart();

            // 클래스 객체 생성
            dash = new DashBord_Class();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // 이미지를 프로젝트 리소스에서 가져와서 PictureBox의 이미지로 설정
            pictureBox1.Image = Properties.Resources.실시간모니터링_그림;
            pictureBox2.Image = Properties.Resources.하양_1단;

            // 불량내역, 생산량, 용접온도 출력 메서드 호출
            // dash.Display(dataGridView1, chart1, chart2);
        }

        private void SetHalfDoughnutChart()
        {
            // 차트 영역 추가
            ChartArea chartArea1 = new ChartArea();
            chart1.ChartAreas.Add(chartArea1);

            // 시리즈 추가
            Series series1 = new Series();
            series1.Points.Add(15);
            series1.Points.Add(35);
            chart1.Series.Add(series1);

            // 차트 타입을 반원 차트로 변경
            chart1.Series[0].ChartType = SeriesChartType.Doughnut;

            // 반원 차트 설정
            chart1.Series[0]["DoughnutRadius"] = "50";
            chart1.Series[0]["PieDrawingStyle"] = "Concave";
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer4_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = ColorTranslator.FromHtml("#002EDE");
            button2.BackColor = ColorTranslator.FromHtml("#FFCC00");
            button3.BackColor = ColorTranslator.FromHtml("#1FC695");

            // 선택한 제품의 텍스트를 저장
            dash.change_state(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = ColorTranslator.FromHtml("#1F6BFF");
            button2.BackColor = ColorTranslator.FromHtml("#EBBC00");
            button3.BackColor = ColorTranslator.FromHtml("#1FC695");

            // 선택한 제품의 텍스트를 저장
            dash.change_state(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = ColorTranslator.FromHtml("#1F6BFF");
            button2.BackColor = ColorTranslator.FromHtml("#FFCC00");
            button3.BackColor = ColorTranslator.FromHtml("#1AA67D");

            // 선택한 제품의 텍스트를 저장
            dash.change_state(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.BackColor = ColorTranslator.FromHtml("#1F6BFF");
            button2.BackColor = ColorTranslator.FromHtml("#FFCC00");
            button3.BackColor = ColorTranslator.FromHtml("#1FC695");

            // 발주제품, 수량 DB에 저장
            dash.send_order(textBox1);
        }
    }
}
