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
using tast_base;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Draw = System.Drawing;
using System.Windows.Forms;
using MES;
using System.Windows.Forms.DataVisualization.Charting;

namespace test_base
{
    public partial class MainForm : Form
    {


        private tabGenerate tabManager;
        public static Common common;
        public TabControl tabControl1;
        Menubar menu;

        private static MainForm instance;
        public static MainForm Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new MainForm();
                }
                return instance;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            common = new Common();
            PanelDragger pd = new PanelDragger(panel1, this);


            // TabControl �ʱ�ȭ
            tabControl1 = new TabControl();
            Controls.Add(tabControl1);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;

            tabManager = new tabGenerate(tabControl1);
            menu = new Menubar(tabControl1);

            // tabGenerate Ŭ���� �ν��Ͻ�ȭ �� �ʱ�ȭ
            //tabManager.Init(); // �ʱ�ȭ �޼��� ȣ��

            // �⺻ �� �߰�

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

            //tabManager.AddOrSelectTabPage(button1.Text, typeof(Dashboard));
            menu.OpenForm<Dashboard>(button1.Text);
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



        //----------------------------------------------tab-----------------------

        private Draw.Point _imageLocation = new Draw.Point(15, 5);
        private Draw.Point _imgHitArea = new Draw.Point(13, 2);
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                // �� �������� �׸��� �޼���

                // �ʿ��� �׷��� �� �귯�� �ʱ�ȭ
                Draw.Image img;
                Draw.Font f = this.Font;
                Draw.Rectangle r = e.Bounds;
                Draw.Brush SelectedBackBrush = new SolidBrush(Color.FromArgb((byte)230, (byte)230, (byte)230)); // ���õ� �� ����
                Draw.Brush NoneSelectedBackBrush = new SolidBrush(Color.FromArgb((byte)224, (byte)223, (byte)230)); // ���õ��� ���� �� ����
                Draw.Brush ForeBrush = new SolidBrush(Color.Black);// �����

                // ���� �ؽ�Ʈ �� ��ġ ����
                string title = this.tabControl1.TabPages[e.Index].Text;
                r = this.tabControl1.GetTabRect(e.Index);
                r.Offset(10, 10);

                // ���õ� ���� ������ ������� ó��
                if (this.tabControl1.SelectedIndex == e.Index)
                    e.Graphics.FillRectangle(new Draw.SolidBrush(Draw.Color.White), e.Bounds);

                // ���� �ǿ� ���� close ��ư �̹��� �� ��Ÿ�� ����
                if (this.tabControl1.SelectedTab == this.tabControl1.TabPages[e.Index])
                {
                    img = Properties.Resources.Close_Black;
                    f = new Font(e.Font, FontStyle.Bold);
                    e.Graphics.FillRectangle(SelectedBackBrush, e.Bounds);
                }
                else
                {
                    img = Properties.Resources.Close_Gray;
                    f = e.Font;
                    //e.Graphics.FillRectangle(NoneSelectedBackBrush, e.Bounds);
                }

                // �� ������ �ؽ�Ʈ �׸���
                e.Graphics.DrawString(title, f, ForeBrush, new Draw.PointF(r.X, r.Y));

                // �� �������� �ݱ� ��ư �̹��� �׸���
                e.Graphics.DrawImage(img, new Draw.Point(r.X + this.tabControl1.GetTabRect(e.Index).Width - _imageLocation.X - 22, _imageLocation.Y + 4));
                img.Dispose();
                img = null;

                // ���õ� �� ���ο� ���� ����� �ڿ� ����
                if (e.Index == this.tabControl1.SelectedIndex)
                {
                    f.Dispose();
                    SelectedBackBrush.Dispose();
                }
                else
                {
                    SelectedBackBrush.Dispose();
                    ForeBrush.Dispose();
                }
            }
            catch (Exception)
            {
                // ���� ó��
            }
        }

        int tabindex = 0;
        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            TabControl tc = (TabControl)sender;
            tabindex = tc.SelectedIndex;
            Draw.Point p = e.Location;
            int _tabWidth = 0;
            _tabWidth = this.tabControl1.GetTabRect(tc.SelectedIndex).Width - (_imgHitArea.X) - 18;
            Draw.Rectangle r = this.tabControl1.GetTabRect(tc.SelectedIndex);
            r.Offset(_tabWidth, _imgHitArea.Y + 4);
            r.Width = 16;
            r.Height = 16;
            if (r.Contains(p))
            {
                // ���콺 Ŭ���� ��ġ�� �ݱ� ��ư�� �ִ��� Ȯ��
                System.Windows.Forms.TabPage TabP = (System.Windows.Forms.TabPage)tc.TabPages[tc.SelectedIndex];

                if (TabP.Text == common.defaultTab)
                {
                    // �⺻ ���� �������� ����
                    return;
                }

                // �� ������ ����
                tc.TabPages.Remove(TabP);
                int index = common.DICT_REMOVE_INDEX[TabP.Text];
                common.DICT_REMOVE_INDEX.Remove(TabP.Text);

                // ���������� ������ �� ĭ�� ���
                for (int i = index; i < common.DICT_REMOVE_INDEX.Count; i++)
                {
                    string tempstring = common.DICT_REMOVE_INDEX.FirstOrDefault(x => x.Value == i + 1).Key;
                    int tempint = common.DICT_REMOVE_INDEX[tempstring];
                    common.DICT_REMOVE_INDEX.Remove(tempstring);
                    common.DICT_REMOVE_INDEX.Add(tempstring, tempint - 1);
                }

                // ���� ��� ���ŵ� ��� �⺻ ���� ����
                if (common.DICT_REMOVE_INDEX.Count == 0)
                {
                    ChangeTab(common.defaultTab);
                }
            }
        }

        public void AddOrSelectTabPage(string title, Type formType, TabControl contorl)
        {
            if (!common.DICT_REMOVE_INDEX.ContainsKey(title))
            {
                // ���� �������� ������ ���ο� ���� �߰�

                // �������� �� �ν��Ͻ� ����
                dynamic form = Activator.CreateInstance(formType);
                SubscribeToFormCloseEvent(form);
                form.TopLevel = false;

                // �� ������ �߰� �� ����
                contorl.TabPages.Add(title);
                contorl.TabPages[contorl.TabPages.Count - 1].Controls.Add(form);
                contorl.SelectedIndex = contorl.TabPages.Count - 1;
                contorl.TabPages[contorl.TabPages.Count - 1].Controls.Add(form);

                // �⺻ ���� ��� ���� ũ�� ����
                if (title == common.defaultTab)
                {
                    form.FormSetSize(contorl.ClientRectangle.Width, contorl.ClientRectangle.Height);
                }

                // �� �ε��� ����
                common.DICT_REMOVE_INDEX.Add(title, contorl.SelectedIndex);

                // ���� Dock �Ӽ� ����
                form.Dock = DockStyle.Fill;
                form.Show();
            }
            else
            {
                // ���� �̹� �����ϸ� �ش� ������ �̵�
                contorl.SelectedTab = contorl.TabPages[common.DICT_REMOVE_INDEX[title]];
            }
        }

        public void SubscribeToFormCloseEvent(dynamic form)
        {
            // FormCloseEvent �̺�Ʈ�� ���� �ڵ鷯 ���
            var eventInfo = form.GetType().GetEvent("FormCloseEvent");
            if (eventInfo != null)
            {
                var delegateType = eventInfo.EventHandlerType;
                var handler = Delegate.CreateDelegate(delegateType, this, "DeleteTabpage");
                eventInfo.AddEventHandler(form, handler);
            }
        }

        private void DeleteTabpage(string temp)
        {
            // �� �������� �����ϴ� �޼���

            Console.WriteLine("Called delete tabPage");

            int aint = 0;
            for (int i = 0; i < tabControl1.TabPages.Count; i++)
            {
                if (tabControl1.TabPages[i].Text == temp)
                {
                    aint = i;
                }
            }

            // ���õ� �� ������ ����
            tabControl1.TabPages.RemoveAt(aint);

            // ������ ���� �ε��� ����
            int index = common.DICT_REMOVE_INDEX[temp];
            common.DICT_REMOVE_INDEX.Remove(temp);

            // ������ �� ������ ���� ������ ���
            if (common.DICT_REMOVE_INDEX.Count > 2)
            {
                for (int i = index; i < common.DICT_REMOVE_INDEX.Count; i++)
                {
                    string tempstring = common.DICT_REMOVE_INDEX.FirstOrDefault(x => x.Value == i + 1).Key;
                    int tempint = common.DICT_REMOVE_INDEX[tempstring];
                    common.DICT_REMOVE_INDEX.Remove(tempstring);
                    common.DICT_REMOVE_INDEX.Add(tempstring, tempint - 1);
                }
            }

            // ���� �ϳ��� ���� ���� ��� ������ ���� ����
            tabControl1.SelectedIndex = aint - 1;
        }

        public void ChangeTab(string title)
        {
            // ���� �����ϰų� �߰��ϴ� �޼���

            if (common.DICT_REMOVE_INDEX.Count > 5)
            {
                // ���� �ִ� ������ �ʰ��ϴ� ��� �޽��� ǥ�� �� �߰� ���� ����
                MessageBox.Show("���� �ִ� 6������ �� �� �ֽ��ϴ�.");
                return;
            }

            if (common.DICT_REMOVE_INDEX.ContainsKey(common.defaultTab))
            {
                // �⺻ ���� �̹� �����ϴ� ��� ����
                DeleteTabpage(common.defaultTab);
            }

            // ���õ� �ǿ� ���� ������ �� �߰� �Ǵ� ����
            switch (title)
            {
                case "�� ��":
                    AddOrSelectTabPage(title, typeof(DefaultForm), tabControl1);
                    break;
                case "��ú���":
                    AddOrSelectTabPage(title, typeof(Dashboard), tabControl1);
                    break;
                case "�ҷ�����":
                    AddOrSelectTabPage(title, typeof(Error), tabControl1);
                    break;
                case "��ǰ����":
                    AddOrSelectTabPage(title, typeof(Product), tabControl1);
                    break;
                case "Ķ����":
                    AddOrSelectTabPage(title, typeof(Calinder), tabControl1);
                    break;
                    // ... (�ٸ� �ǵ鿡 ���� �߰� �� ���� ����)
            };
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
