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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Dashboard DashboardSc = new Dashboard();
            DashboardSc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            DashboardSc.TopLevel = false;
            DashboardSc.Dock = DockStyle.Fill;

            panel4.Controls.Clear();
            panel4.Controls.Add(DashboardSc);

            DashboardSc.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Product ProductSc = new Product();
            ProductSc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ProductSc.TopLevel = false;
            ProductSc.Dock = DockStyle.Fill;

            panel4.Controls.Clear();
            panel4.Controls.Add(ProductSc);

            ProductSc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Error ErrorSc = new Error();
            ErrorSc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ErrorSc.TopLevel = false;
            ErrorSc.Dock = DockStyle.Fill;

            panel4.Controls.Clear();
            panel4.Controls.Add(ErrorSc);

            ErrorSc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calinder CalinderSc = new Calinder();
            CalinderSc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            CalinderSc.TopLevel = false;
            CalinderSc.Dock = DockStyle.Fill;

            panel4.Controls.Clear();
            panel4.Controls.Add(CalinderSc);

            CalinderSc.Show();
        }
    }
}
