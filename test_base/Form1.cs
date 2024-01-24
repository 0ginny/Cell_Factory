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

            //��Ʈ����
            button1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#216BFF");
            button2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3C4E71");
            button3.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3C4E71");
            button4.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3C4E71");

            //�̹�������
            button1.Image = Properties.Resources.re��ú���2;
            button2.Image = Properties.Resources.re�ҷ�����1;
            button3.Image = Properties.Resources.re��ǰ1;
            button4.Image = Properties.Resources.reĶ����1;

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

            //��Ʈ����
            button2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#216BFF");
            button3.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3C4E71");
            button4.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3C4E71");
            button1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3C4E71");

            //�̹�������
            button1.Image = Properties.Resources.re��ú���1;
            button2.Image = Properties.Resources.re�ҷ�����2;
            button3.Image = Properties.Resources.re��ǰ1;
            button4.Image = Properties.Resources.reĶ����1;

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

            //��Ʈ����
            button3.ForeColor = System.Drawing.ColorTranslator.FromHtml("#216BFF");
            button4.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3C4E71");
            button1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3C4E71");
            button2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3C4E71");

            //�̹�������
            button1.Image = Properties.Resources.re��ú���1;
            button2.Image = Properties.Resources.re�ҷ�����1;
            button3.Image = Properties.Resources.re��ǰ2;
            button4.Image = Properties.Resources.reĶ����1;
            // Product ���� ������
            ProductSc.Show();

        }

        private void button4_Click(object sender, EventArgs e)// Calinder Ŭ���� ȣ��
        {
            // Calinder �ν��Ͻ� ����
            Calendar_shipmen_status CalinderSc = new Calendar_shipmen_status();

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

            //��Ʈ����
            button4.ForeColor = System.Drawing.ColorTranslator.FromHtml("#216BFF");
            button1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3C4E71");
            button2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3C4E71");
            button3.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3C4E71");

            //�̹�������
            button1.Image = Properties.Resources.re��ú���1;
            button2.Image = Properties.Resources.re�ҷ�����1;
            button3.Image = Properties.Resources.re��ǰ1;
            button4.Image = Properties.Resources.reĶ����2;
            // Calinder ���� ������
            CalinderSc.Show();

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)// side menu base
        {
            // flowLayoutPanel1�� ȭ�鿡 �׷��� �� � ������ ���������� ������ �� �ֽ��ϴ�.
            // �ַ� �׷������� ��Ҹ� Ŀ�����ϰ� �߰��ϰų� Ư�� ���ǿ� ���� �׸��� �����ϴ� �� ���˴ϴ�.
        }

        private void panel5_Paint(object sender, PaintEventArgs e)// side menu space
        {
            // Panel ��Ʈ���� �ٽ� �׷��� �� �߻��ϸ�, �ַ� ����� ���� �׸��̳� �׷����� ǥ���� �� Ȱ��˴ϴ�.
        }
    }
}
