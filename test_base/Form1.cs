using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System;
using System.Diagnostics;
using test_base.Properties;
using static System.Windows.Forms.DataFormats;


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
            Dashboard DashboardSc = new Dashboard();
            DashboardSc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            DashboardSc.TopLevel = false;
            DashboardSc.Dock = DockStyle.Fill;

            panel4.Controls.Clear();
            panel4.Controls.Add(DashboardSc);

            DashboardSc.Show();
        }

        private void button2_Click(object sender, EventArgs e)// Error Management 클릭시 호출
        {
            Error ErrorSc = new Error();
            ErrorSc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ErrorSc.TopLevel = false;
            ErrorSc.Dock = DockStyle.Fill;

            panel4.Controls.Clear();
            panel4.Controls.Add(ErrorSc);

            ErrorSc.Show();
        }

        private void button3_Click(object sender, EventArgs e)// ProductData 클릭시 호출
        {
            Product ProductSc = new Product();
            ProductSc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ProductSc.TopLevel = false;
            ProductSc.Dock = DockStyle.Fill;

            panel4.Controls.Clear();
            panel4.Controls.Add(ProductSc);

            ProductSc.Show();
        }

        private void button4_Click(object sender, EventArgs e)// Calinder 클릭시 호출
        {
            Calinder CalinderSc = new Calinder();
            CalinderSc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            CalinderSc.TopLevel = false;
            CalinderSc.Dock = DockStyle.Fill;

            panel4.Controls.Clear();
            panel4.Controls.Add(CalinderSc);

            CalinderSc.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // flowLayoutPanel1이 화면에 그려질 때 어떤 동작을 수행할지를 정의할 수 있습니다.
            // 주로 그래픽적인 요소를 커스텀하게 추가하거나 특정 조건에 따라 그림을 변경하는 데 사용됩니다.
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            // Panel 컨트롤이 다시 그려질 때 발생하며, 주로 사용자 지정 그림이나 그래픽을 표시할 때 활용됩니다.
        }
    }
}
