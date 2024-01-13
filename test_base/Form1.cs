using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System;
using System.Diagnostics;
using test_base.Properties;
using static System.Windows.Forms.DataFormats;
using MySql.Data;
using MySql.Data.MySqlClient;


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
            // Dashboard �ν��Ͻ� ����
            Dashboard DashboardSc = new Dashboard();

            // �� �׵θ� ��Ÿ���� ���ְ�
            DashboardSc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            // TopLevel �Ӽ��� false�� �����Ͽ� �ٸ� ��Ʈ�ѿ� ��ø�� �� �ֵ��� ��
            DashboardSc.TopLevel = false;

            // Dock �Ӽ��� Fill�� �����Ͽ� �θ� ��Ʈ�ѿ� �°� ũ�⸦ ����
            DashboardSc.Dock = DockStyle.Fill;

            // panel4 ��Ʈ�� ���� ��� ��Ʈ���� ����
            panel4.Controls.Clear();

            // panel4 ��Ʈ�ѿ� Dashboard �� �߰�
            panel4.Controls.Add(DashboardSc);

            // Dashboard ���� ������
            DashboardSc.Show();
        }

        private void button2_Click(object sender, EventArgs e)// Error Management Ŭ���� ȣ��
        {
            // Error �ν��Ͻ� ����
            Error ErrorSc = new Error();

            // �� �׵θ� ��Ÿ���� ���ְ�
            ErrorSc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            // TopLevel �Ӽ��� false�� �����Ͽ� �ٸ� ��Ʈ�ѿ� ��ø�� �� �ֵ��� ��
            ErrorSc.TopLevel = false;

            // Dock �Ӽ��� Fill�� �����Ͽ� �θ� ��Ʈ�ѿ� �°� ũ�⸦ ����
            ErrorSc.Dock = DockStyle.Fill;

            // panel4 ��Ʈ�� ���� ��� ��Ʈ���� ����
            panel4.Controls.Clear();

            // panel4 ��Ʈ�ѿ� Error �� �߰�
            panel4.Controls.Add(ErrorSc);

            // Error ���� ������
            ErrorSc.Show();

        }

        private void button3_Click(object sender, EventArgs e)// ProductData Ŭ���� ȣ��
        {
            // Product �ν��Ͻ� ����
            Product ProductSc = new Product();

            // �� �׵θ� ��Ÿ���� ���ְ�
            ProductSc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            // TopLevel �Ӽ��� false�� �����Ͽ� �ٸ� ��Ʈ�ѿ� ��ø�� �� �ֵ��� ��
            ProductSc.TopLevel = false;

            // Dock �Ӽ��� Fill�� �����Ͽ� �θ� ��Ʈ�ѿ� �°� ũ�⸦ ����
            ProductSc.Dock = DockStyle.Fill;

            // panel4 ��Ʈ�� ���� ��� ��Ʈ���� ����
            panel4.Controls.Clear();

            // panel4 ��Ʈ�ѿ� Product �� �߰�
            panel4.Controls.Add(ProductSc);

            // Product ���� ������
            ProductSc.Show();

        }

        private void button4_Click(object sender, EventArgs e)// Calinder Ŭ���� ȣ��
        {
            // Calinder �ν��Ͻ� ����
            Calinder CalinderSc = new Calinder();

            // �� �׵θ� ��Ÿ���� ���ְ�
            CalinderSc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            // TopLevel �Ӽ��� false�� �����Ͽ� �ٸ� ��Ʈ�ѿ� ��ø�� �� �ֵ��� ��
            CalinderSc.TopLevel = false;

            // Dock �Ӽ��� Fill�� �����Ͽ� �θ� ��Ʈ�ѿ� �°� ũ�⸦ ����
            CalinderSc.Dock = DockStyle.Fill;

            // panel4 ��Ʈ�� ���� ��� ��Ʈ���� ����
            panel4.Controls.Clear();

            // panel4 ��Ʈ�ѿ� Calinder �� �߰�
            panel4.Controls.Add(CalinderSc);

            // Calinder ���� ������
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
