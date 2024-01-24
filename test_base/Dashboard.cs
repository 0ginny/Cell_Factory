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

        public Dashboard()
        {
            InitializeComponent();
            Load += Dashboard_Load;

            circleProgressBar();



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
            ApplyRoundedBorder(panel1, 20, ColorTranslator.FromHtml("#D1D9E7"), 2); // 20은 반지름 값, 2는 테두리 굵기, 조절 가능
            ApplyRoundedBorder(panel2, 20, ColorTranslator.FromHtml("#D1D9E7"), 2); // 20은 반지름 값, 2는 테두리 굵기, 조절 가능
            ApplyRoundedBorder(panel3, 20, ColorTranslator.FromHtml("#D1D9E7"), 2); // 20은 반지름 값, 2는 테두리 굵기, 조절 가능
            ApplyRoundedBorder(panel4, 20, ColorTranslator.FromHtml("#D1D9E7"), 2); // 20은 반지름 값, 2는 테두리 굵기, 조절 가능
            ApplyRoundedBorder(panel5, 20, ColorTranslator.FromHtml("#D1D9E7"), 2); // 20은 반지름 값, 2는 테두리 굵기, 조절 가능
            ApplyRoundedBorder(panel6, 20, ColorTranslator.FromHtml("#D1D9E7"), 2); // 20은 반지름 값, 2는 테두리 굵기, 조절 가능

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

        // 패널 라운드 설정(클래스 부탁함 ㅎㅎ ㅋㅋ ㅈㅅ;;)
        private void ApplyRoundedBorder(Control control, int radius, Color borderColor, int borderSize)
        {
            // 컨트롤의 Paint 이벤트에 핸들러 추가
            control.Paint += (sender, e) => DrawRoundedBorder(sender as Control, radius, borderColor, borderSize);

            // GraphicsPath를 사용하여 둥근 경계를 만듭니다.
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90); // 좌상단
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90); // 우상단
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90); // 우하단
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90); // 좌하단
            path.CloseAllFigures();

            // 컨트롤에 경로를 설정하여 둥근 경계를 적용
            control.Region = new Region(path);
        }

        // 둥근 테두리 및 테두리 그리기
        private void DrawRoundedBorder(Control control, int radius, Color borderColor, int borderSize)
        {
            using (Pen borderPen = new Pen(borderColor, borderSize))
            {
                // Graphics 객체를 얻어와서 테두리를 그립니다.
                using (Graphics g = control.CreateGraphics())
                {
                    g.DrawPath(borderPen, CreateRoundedRectanglePath(control.ClientRectangle, radius));
                }
            }
        }

        // 둥근 사각형 경로 생성
        private GraphicsPath CreateRoundedRectanglePath(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90); // 좌상단
            path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90); // 우상단
            path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90); // 우하단
            path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90); // 좌하단
            path.CloseAllFigures();
            return path;
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
