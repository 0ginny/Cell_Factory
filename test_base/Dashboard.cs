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

        //1층 셀이동
        private int pictureBox1Y = 238; // pB_1stack의 초기 Y 위치
        private int moveCountPB1 = 0;
        private bool goingDownPB1 = true;
        private System.Windows.Forms.Timer timerPB1;
        //2층 셀이동
        int pictureBox5Y = 182; // PictureBox5의 초기 Y 위치
        System.Windows.Forms.Timer timer1; // System.Windows.Forms.Timer 사용
        private int moveCount = 0;
        private bool goingDown = true;
        //3층 셀이동
        private int pictureBox3Y = 131; // pB_3stack의 초기 Y 위치
        private int moveCountPB3 = 0;
        private bool goingDownPB3 = true;
        private System.Windows.Forms.Timer timerPB3;

        //레이저 1층이동
        private int pictureBoxLaserY = 297; // pB_laser의 초기 Y 위치
        private int moveAmountLaser = 5;
        private System.Windows.Forms.Timer timerLaser;

        //레이저 2층 이동
        private int pictureBoxLaserY1a = 257; // pB_laser의 초기 Y 위치
        private int moveAmountLaser1a = 5;
        private System.Windows.Forms.Timer timerLaser1a;

        //레이저on/off
        private bool laserImageToggle = false; // 이미지 토글 상태 변수

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

            // Timer 이벤트 핸들러 추가 --1층 셀이동
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += Timer1_Tick;
            timer1.Interval = 150;

            // Timer 이벤트 핸들러 추가 --2층 셀이동
            timerPB1 = new System.Windows.Forms.Timer();
            timerPB1.Tick += TimerPB1_Tick;
            timerPB1.Interval = 150;

            // Timer 이벤트 핸들러 추가 --3층 셀이동
            timerPB3 = new System.Windows.Forms.Timer();
            timerPB3.Tick += TimerPB3_Tick;
            timerPB3.Interval = 150;

            // Timer 이벤트 핸들러 추가 -- pB_laser 1층 레이저
            timerLaser = new System.Windows.Forms.Timer();
            timerLaser.Tick += TimerLaser_Tick;
            timerLaser.Interval = 150; // 이동 간격 조절 가능

            // Timer 이벤트 핸들러 추가 -- pB_laser 2층 레이저
            timerLaser1a = new System.Windows.Forms.Timer();
            timerLaser1a.Tick += TimerLaser_Tick1a;
            timerLaser1a.Interval = 150; // 이동 간격 조절 가능
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // 이미지를 프로젝트 리소스에서 가져와서 PictureBox의 이미지로 설정

            //pictureBox1.Image = Properties.Resources.실시간모니터링_그림;

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
        private void circleProgressBar()
        {

            // 불량내역, 생산량, 용접온도 출력 메서드 호출
            // dash.Display(dataGridView1, chart1, chart2);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {

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

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        // 2층 셀이동
        private void button2_Click_1(object sender, EventArgs e)
        {
            // Timer를 시작하기 전에 초기화
            pictureBox5Y = 182;
            pB_2stack.Location = new Point(600, pictureBox5Y);

            // 이동 횟수 및 방향 초기화
            moveCount = 0;
            goingDown = true;

            // Timer를 시작
            timer1.Start();
        }
        // 2층 셀이동
        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Timer 이벤트 핸들러

            const int moveAmount = 5; // 이동량

            // PictureBox5를 5씩 아래로 이동
            pictureBox5Y += moveAmount;
            pB_2stack.Location = new Point(600, pictureBox5Y);

            // Timer 정지
            if (pictureBox5Y >= 217)
            {
                timer1.Stop();
            }
        }
        //1층 셀이동
        private void Bt_1stack_Click(object sender, EventArgs e)
        {
            // Timer를 시작하기 전에 초기화
            pictureBox1Y = 238;
            pB_1stack.Location = new Point(600, pictureBox1Y);

            // 이동 횟수 및 방향 초기화
            moveCountPB1 = 0;
            goingDownPB1 = true;

            // Timer를 시작
            timerPB1.Start();
        }
        //1층 셀이동
        private void TimerPB1_Tick(object sender, EventArgs e)
        {
            const int moveAmount = 5; // 이동량

            // PictureBox1을 5씩 아래 또는 위로 이동
            if (goingDownPB1)
            {
                pictureBox1Y += moveAmount;
                pB_1stack.Location = new Point(600, pictureBox1Y);
            }
            else
            {
                pictureBox1Y -= moveAmount;
                pB_1stack.Location = new Point(600, pictureBox1Y);
            }

            // Timer 정지
            if (pictureBox1Y >= 273)
            {
                timerPB1.Stop();
            }
            else if (pictureBox1Y <= 238)
            {
                goingDownPB1 = true;
                moveCountPB1++;
            }
        }
        //3층 셀이동
        private void Bt_3stack_Click(object sender, EventArgs e)
        {
            // Timer를 시작하기 전에 초기화
            pictureBox3Y = 131;
            pB_3stack.Location = new Point(600, pictureBox3Y);

            // 이동 횟수 및 방향 초기화
            moveCountPB3 = 0;
            goingDownPB3 = true;

            // Timer를 시작
            timerPB3.Start();
        }
        //3층 셀이동
        private void TimerPB3_Tick(object sender, EventArgs e)
        {
            const int moveAmount = 5; // 이동량

            // PictureBox3을 5씩 아래 또는 위로 이동
            if (goingDownPB3)
            {
                pictureBox3Y += moveAmount;
                pB_3stack.Location = new Point(600, pictureBox3Y);
            }
            else
            {
                pictureBox3Y -= moveAmount;
                pB_3stack.Location = new Point(600, pictureBox3Y);
            }

            // Timer 정지
            if (pictureBox3Y >= 159)
            {
                timerPB3.Stop();
            }
            else if (pictureBox3Y <= 131)
            {
                goingDownPB3 = true;
                moveCountPB3++;
            }
        }
        //레이저 1층
        private void Bt_Servo1_Click(object sender, EventArgs e)
        {
            // Timer를 시작하기 전에 초기화
            pictureBoxLaserY = 297;
            pB_laser.Location = new Point(382, pictureBoxLaserY);

            // Timer를 시작
            timerLaser.Start();
        }
        //레이저 1층
        private void TimerLaser_Tick(object sender, EventArgs e)
        {
            // Timer 이벤트 핸들러

            // pB_laser를 5씩 아래로 이동
            pictureBoxLaserY -= moveAmountLaser;
            pB_laser.Location = new Point(382, pictureBoxLaserY);

            // Timer 정지
            if (pictureBoxLaserY <= 257)
            {
                timerLaser.Stop();
            }
        }
        //레이저 on/off
        private void Bt_Laser_Click(object sender, EventArgs e)
        {
            // 이미지 토글
            laserImageToggle = !laserImageToggle;

            // 이미지 변경
            if (laserImageToggle)
            {
                pB_laser.Image = Properties.Resources.레이저2;
            }
            else
            {
                pB_laser.Image = Properties.Resources.레이저1;
            }
        }
        //레이저2층
        private void Bt_Servo2_Click(object sender, EventArgs e)
        {
            // Timer를 시작하기 전에 초기화
            pictureBoxLaserY1a = 257;
            pB_laser.Location = new Point(382, pictureBoxLaserY1a);

            // Timer를 시작
            timerLaser1a.Start();
        }
        //레이저2층
        private void TimerLaser_Tick1a(object sender, EventArgs e)
        {
            // Timer 이벤트 핸들러

            // pB_laser를 5씩 아래로 이동
            pictureBoxLaserY1a -= moveAmountLaser1a;
            pB_laser.Location = new Point(382, pictureBoxLaserY1a);

            // Timer 정지
            if (pictureBoxLaserY1a <= 197)
            {
                timerLaser1a.Stop();
            }
        }
    }
}
