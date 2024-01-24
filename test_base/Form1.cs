using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System;
using System.Diagnostics;
using test_base.Properties;
using static System.Windows.Forms.DataFormats;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using MES_Project;


namespace test_base
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)// 최종프로젝트 3조 Title 클릭시 호출
        {
            // label을 클릭해서 사용해야 할 기능이 있는지 의문
        }

        private void button1_Click(object sender, EventArgs e)// Dashboard 클릭시 호출
        {
            // Dashboard 인스턴스 생성
            Dashboard DashboardSc = new Dashboard();

            // 폼 테두리 스타일을 없애고
            DashboardSc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            // TopLevel 속성을 false로 설정하여 다른 컨트롤에 중첩될 수 있도록 함
            DashboardSc.TopLevel = false;

            // Dock 속성을 Fill로 설정하여 부모 컨트롤에 맞게 크기를 조정
            DashboardSc.Dock = DockStyle.Fill;

            // panel4 컨트롤 내의 모든 컨트롤을 제거
            panel4.Controls.Clear();

            // panel4 컨트롤에 Dashboard 폼 추가
            panel4.Controls.Add(DashboardSc);

            //폰트변경
            button1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#216BFF");
            button2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3C4E71");
            button3.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3C4E71");
            button4.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3C4E71");

            //이미지변경
            button1.Image = Properties.Resources.re대시보드2;
            button2.Image = Properties.Resources.re불량관리1;
            button3.Image = Properties.Resources.re제품1;
            button4.Image = Properties.Resources.re캘린더1;

            // Dashboard 폼을 보여줌
            DashboardSc.Show();
        }

        private void button2_Click(object sender, EventArgs e)// Error Management 클릭시 호출
        {
            // Error 인스턴스 생성
            Error ErrorSc = new Error();

            // 폼 테두리 스타일을 없애고
            ErrorSc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            // TopLevel 속성을 false로 설정하여 다른 컨트롤에 중첩될 수 있도록 함
            ErrorSc.TopLevel = false;

            // Dock 속성을 Fill로 설정하여 부모 컨트롤에 맞게 크기를 조정
            ErrorSc.Dock = DockStyle.Fill;

            // panel4 컨트롤 내의 모든 컨트롤을 제거
            panel4.Controls.Clear();

            // panel4 컨트롤에 Error 폼 추가
            panel4.Controls.Add(ErrorSc);

            //폰트변경
            button2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#216BFF");
            button3.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3C4E71");
            button4.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3C4E71");
            button1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3C4E71");

            //이미지변경
            button1.Image = Properties.Resources.re대시보드1;
            button2.Image = Properties.Resources.re불량관리2;
            button3.Image = Properties.Resources.re제품1;
            button4.Image = Properties.Resources.re캘린더1;

            // Error 폼을 보여줌
            ErrorSc.Show();

        }

        private void button3_Click(object sender, EventArgs e)// ProductData 클릭시 호출
        {
            // Product 인스턴스 생성
            Product ProductSc = new Product();

            // 폼 테두리 스타일을 없애고
            ProductSc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            // TopLevel 속성을 false로 설정하여 다른 컨트롤에 중첩될 수 있도록 함
            ProductSc.TopLevel = false;

            // Dock 속성을 Fill로 설정하여 부모 컨트롤에 맞게 크기를 조정
            ProductSc.Dock = DockStyle.Fill;

            // panel4 컨트롤 내의 모든 컨트롤을 제거
            panel4.Controls.Clear();

            // panel4 컨트롤에 Product 폼 추가
            panel4.Controls.Add(ProductSc);

            //폰트변경
            button3.ForeColor = System.Drawing.ColorTranslator.FromHtml("#216BFF");
            button4.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3C4E71");
            button1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3C4E71");
            button2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3C4E71");

            //이미지변경
            button1.Image = Properties.Resources.re대시보드1;
            button2.Image = Properties.Resources.re불량관리1;
            button3.Image = Properties.Resources.re제품2;
            button4.Image = Properties.Resources.re캘린더1;
            // Product 폼을 보여줌
            ProductSc.Show();

        }

        private void button4_Click(object sender, EventArgs e)// Calinder 클릭시 호출
        {
            // Calinder 인스턴스 생성
            Calendar_shipmen_status CalinderSc = new Calendar_shipmen_status();

            // 폼 테두리 스타일을 없애고
            CalinderSc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            // TopLevel 속성을 false로 설정하여 다른 컨트롤에 중첩될 수 있도록 함
            CalinderSc.TopLevel = false;

            // Dock 속성을 Fill로 설정하여 부모 컨트롤에 맞게 크기를 조정
            CalinderSc.Dock = DockStyle.Fill;

            // panel4 컨트롤 내의 모든 컨트롤을 제거
            panel4.Controls.Clear();

            // panel4 컨트롤에 Calinder 폼 추가
            panel4.Controls.Add(CalinderSc);

            //폰트변경
            button4.ForeColor = System.Drawing.ColorTranslator.FromHtml("#216BFF");
            button1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3C4E71");
            button2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3C4E71");
            button3.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3C4E71");

            //이미지변경
            button1.Image = Properties.Resources.re대시보드1;
            button2.Image = Properties.Resources.re불량관리1;
            button3.Image = Properties.Resources.re제품1;
            button4.Image = Properties.Resources.re캘린더2;
            // Calinder 폼을 보여줌
            CalinderSc.Show();

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)// side menu base
        {
            // flowLayoutPanel1이 화면에 그려질 때 어떤 동작을 수행할지를 정의할 수 있습니다.
            // 주로 그래픽적인 요소를 커스텀하게 추가하거나 특정 조건에 따라 그림을 변경하는 데 사용됩니다.
        }

        private void panel5_Paint(object sender, PaintEventArgs e)// side menu space
        {
            // Panel 컨트롤이 다시 그려질 때 발생하며, 주로 사용자 지정 그림이나 그래픽을 표시할 때 활용됩니다.
        }
    }
}
