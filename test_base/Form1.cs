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

        private void label1_Click(object sender, EventArgs e)// ����������Ʈ 3�� Title Ŭ���� ȣ��
        {
            // label�� Ŭ���ؼ� ����ؾ� �� ����� �ִ��� �ǹ�
        }

        private void button1_Click(object sender, EventArgs e)// Dashboard Ŭ���� ȣ��
        {
            Dashboard DashboardSc = new Dashboard();
            DashboardSc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            DashboardSc.TopLevel = false;
            DashboardSc.Dock = DockStyle.Fill;

            panel4.Controls.Clear();
            panel4.Controls.Add(DashboardSc);

            DashboardSc.Show();
        }

        private void button2_Click(object sender, EventArgs e)// Error Management Ŭ���� ȣ��
        {
            Error ErrorSc = new Error();
            ErrorSc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ErrorSc.TopLevel = false;
            ErrorSc.Dock = DockStyle.Fill;

            panel4.Controls.Clear();
            panel4.Controls.Add(ErrorSc);

            ErrorSc.Show();
        }

        private void button3_Click(object sender, EventArgs e)// ProductData Ŭ���� ȣ��
        {
            Product ProductSc = new Product();
            ProductSc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ProductSc.TopLevel = false;
            ProductSc.Dock = DockStyle.Fill;

            panel4.Controls.Clear();
            panel4.Controls.Add(ProductSc);

            ProductSc.Show();
        }

        private void button4_Click(object sender, EventArgs e)// Calinder Ŭ���� ȣ��
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
            // flowLayoutPanel1�� ȭ�鿡 �׷��� �� � ������ ���������� ������ �� �ֽ��ϴ�.
            // �ַ� �׷������� ��Ҹ� Ŀ�����ϰ� �߰��ϰų� Ư�� ���ǿ� ���� �׸��� �����ϴ� �� ���˴ϴ�.
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            // Panel ��Ʈ���� �ٽ� �׷��� �� �߻��ϸ�, �ַ� ����� ���� �׸��̳� �׷����� ǥ���� �� Ȱ��˴ϴ�.
        }
    }
}
