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
    public partial class MainForm : Form
    {

        private TabControl tabControl1;
        tabGenerate tabManager;



        public MainForm()
        {
            InitializeComponent();

            PanelDragger pd = new PanelDragger(panel1, this);
            tabManager = new tabGenerate(tabControl1);
        }

        private void label1_Click(object sender, EventArgs e)// 최종프로젝트 3조 Title 클릭시 호출
        {
            // label을 클릭해서 사용해야 할 기능이 있는지 의문
        }

        private void button1_Click(object sender, EventArgs e)// Dashboard 클릭시 호출
        {

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

            tabManager.AddOrSelectTabPage(button1.Text, typeof(Dashboard));

        }

        private void button2_Click(object sender, EventArgs e)// Error Management 클릭시 호출
        {
            
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

            tabManager.AddOrSelectTabPage(button2.Text, typeof(Error));

        }

        private void button3_Click(object sender, EventArgs e)// ProductData 클릭시 호출
        {
            

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
            tabManager.AddOrSelectTabPage(button3.Text, typeof(Product));

        }

        private void button4_Click(object sender, EventArgs e)// Calinder 클릭시 호출
        {
            
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
            tabManager.AddOrSelectTabPage(button4.Text, typeof(Calinder));

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
