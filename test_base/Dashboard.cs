using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using LiveCharts.WinForms;
using MySql.Data;
using MySql.Data.MySqlClient;
using static ReaLTaiizor.Drawing.Poison.PoisonPaint;

namespace test_base
{
    public partial class Dashboard : Form
    {
        // 클래스 전역 선언
        DashBord_Class dash;
        CSS css;
        public Dashboard()
        {
            InitializeComponent();
            Load += Dashboard_Load;

            circleProgressBar();
            css = new CSS();



            // 클래스 객체 생성
            dash = new DashBord_Class();

            //standard gauge
            solidGauge1.From = 0;
            solidGauge1.To = 100;
            solidGauge1.Value = 50;
            
            // 설비운전 라벨 설정
            label13.Visible = false;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // 이미지를 프로젝트 리소스에서 가져와서 PictureBox의 이미지로 설정

            //pictureBox1.Image = Properties.Resources.실시간모니터링_그림;




            pictureBox2.Image = Properties.Resources.녹색_1단;


            pictureBox2.Image = Properties.Resources.녹색_1단;

            // 이미 생성된 패널1에 둥근 테두리, 테두리 색상, 테두리 굵기 설정
            css.ApplyRoundedBorder(panel1, 20, ColorTranslator.FromHtml("#D1D9E7"), 2); // 20은 반지름 값, 2는 테두리 굵기, 조절 가능
            css.ApplyRoundedBorder(panel2, 20, ColorTranslator.FromHtml("#D1D9E7"), 2); // 20은 반지름 값, 2는 테두리 굵기, 조절 가능
            css.ApplyRoundedBorder(panel3, 20, ColorTranslator.FromHtml("#D1D9E7"), 2); // 20은 반지름 값, 2는 테두리 굵기, 조절 가능
            css.ApplyRoundedBorder(panel4, 20, ColorTranslator.FromHtml("#D1D9E7"), 2); // 20은 반지름 값, 2는 테두리 굵기, 조절 가능
            css.ApplyRoundedBorder(panel5, 20, ColorTranslator.FromHtml("#D1D9E7"), 2); // 20은 반지름 값, 2는 테두리 굵기, 조절 가능
            css.ApplyRoundedBorder(panel6, 20, ColorTranslator.FromHtml("#D1D9E7"), 2); // 20은 반지름 값, 2는 테두리 굵기, 조절 가능

            // 금일 발생 에러 리스트 표시
            dash.today_error_list(dataGridView1);
            // 금일 착수 예정 리스트 표시
            dash.plan_order_list(dataGridView2);

            InitializeSolidGauge();
        }
        private void InitializeSolidGauge()
        {
            // SolidGauge의 폰트 색상을 변경합니다.
            solidGauge1.ForeColor = ColorTranslator.FromHtml("#3C4E71");
        }

     
        private void circleProgressBar() { 

            // 불량내역, 생산량, 용접온도 출력 메서드 호출
            // dash.Display(dataGridView1, chart1, chart2);
        }

        private void SetHalfDoughnutChart()
        {
            
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer4_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //button1.BackColor = ColorTranslator.FromHtml("#002EDE");
            //button2.BackColor = ColorTranslator.FromHtml("#FFCC00");
            //button3.BackColor = ColorTranslator.FromHtml("#1FC695");

            // 선택한 제품의 텍스트를 저장
            //dash.change_state(button1);

            button1.BackColor = ColorTranslator.FromHtml("#1F6BFF");
            //button2.BackColor = ColorTranslator.FromHtml("#EBBC00");
            button3.BackColor = ColorTranslator.FromHtml("#1FC695");

            // 선택한 제품의 텍스트를 저장
            //dash.change_state(button2);

            label13.Visible = true;
            parrotCircleProgressBar1.IsAnimated = true;
            // 버튼 클릭 시 Label13의 텍스트를 "가동중"으로 변경
            label13.Text = " 가동중";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = ColorTranslator.FromHtml("#1F6BFF");
            //button2.BackColor = ColorTranslator.FromHtml("#EBBC00");
            button3.BackColor = ColorTranslator.FromHtml("#1FC695");

            // 선택한 제품의 텍스트를 저장
            //dash.change_state(button2);

            label13.Visible = true;
            parrotCircleProgressBar1.IsAnimated = true;
            // 버튼 클릭 시 Label13의 텍스트를 "가동중"으로 변경
            label13.Text = " 가동중";

        }

        private void button3_Click(object sender, EventArgs e)
        {

            //button1.BackColor = ColorTranslator.FromHtml("#1F6BFF");
            //button2.BackColor = ColorTranslator.FromHtml("#FFCC00");
            //button3.BackColor = ColorTranslator.FromHtml("#1AA67D");

            // 선택한 제품의 텍스트를 저장
            // dash.change_state(button3);


            button1.BackColor = ColorTranslator.FromHtml("#1F6BFF");
            //button2.BackColor = ColorTranslator.FromHtml("#FFCC00");
            button3.BackColor = ColorTranslator.FromHtml("#1FC695");

            // 발주제품, 수량 DB에 저장
            //dash.send_order(textBox1);

            label13.Visible = true;
            parrotCircleProgressBar1.IsAnimated = false;
            // 버튼 클릭 시 Label13의 텍스트를 "정지"로 변경
            label13.Text = "  정지";
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            button1.BackColor = ColorTranslator.FromHtml("#1F6BFF");
            //button2.BackColor = ColorTranslator.FromHtml("#FFCC00");
            button3.BackColor = ColorTranslator.FromHtml("#1FC695");

            // 발주제품, 수량 DB에 저장
            //dash.send_order(textBox1);

            label13.Visible = true;
            parrotCircleProgressBar1.IsAnimated = false;
            // 버튼 클릭 시 Label13의 텍스트를 "가동중"으로 변경
            label13.Text = "  정지";

        }
        
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
