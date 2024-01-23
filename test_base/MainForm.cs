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

        private void label1_Click(object sender, EventArgs e)// ����������Ʈ 3�� Title Ŭ���� ȣ��
        {
            // label�� Ŭ���ؼ� ����ؾ� �� ����� �ִ��� �ǹ�
        }

        private void button1_Click(object sender, EventArgs e)// Dashboard Ŭ���� ȣ��
        {

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

            tabManager.AddOrSelectTabPage(button1.Text, typeof(Dashboard));

        }

        private void button2_Click(object sender, EventArgs e)// Error Management Ŭ���� ȣ��
        {
            
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

            tabManager.AddOrSelectTabPage(button2.Text, typeof(Error));

        }

        private void button3_Click(object sender, EventArgs e)// ProductData Ŭ���� ȣ��
        {
            

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
            tabManager.AddOrSelectTabPage(button3.Text, typeof(Product));

        }

        private void button4_Click(object sender, EventArgs e)// Calinder Ŭ���� ȣ��
        {
            
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
            tabManager.AddOrSelectTabPage(button4.Text, typeof(Calinder));

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
