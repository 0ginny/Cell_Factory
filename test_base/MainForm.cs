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


            // TabControl 초기화
            tabControl1 = new TabControl();
            Controls.Add(tabControl1);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;

            tabManager = new tabGenerate(tabControl1);
            menu = new Menubar(tabControl1);

            // tabGenerate 클래스 인스턴스화 및 초기화
            //tabManager.Init(); // 초기화 메서드 호출

            // 기본 탭 추가

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

            //tabManager.AddOrSelectTabPage(button1.Text, typeof(Dashboard));
            menu.OpenForm<Dashboard>(button1.Text);
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



        //----------------------------------------------tab-----------------------

        private Draw.Point _imageLocation = new Draw.Point(15, 5);
        private Draw.Point _imgHitArea = new Draw.Point(13, 2);
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                // 탭 페이지를 그리는 메서드

                // 필요한 그래픽 및 브러시 초기화
                Draw.Image img;
                Draw.Font f = this.Font;
                Draw.Rectangle r = e.Bounds;
                Draw.Brush SelectedBackBrush = new SolidBrush(Color.FromArgb((byte)230, (byte)230, (byte)230)); // 선택된 탭 배경색
                Draw.Brush NoneSelectedBackBrush = new SolidBrush(Color.FromArgb((byte)224, (byte)223, (byte)230)); // 선택되지 않은 탭 배경색
                Draw.Brush ForeBrush = new SolidBrush(Color.Black);// 전경색

                // 탭의 텍스트 및 위치 설정
                string title = this.tabControl1.TabPages[e.Index].Text;
                r = this.tabControl1.GetTabRect(e.Index);
                r.Offset(10, 10);

                // 선택된 탭의 배경색을 흰색으로 처리
                if (this.tabControl1.SelectedIndex == e.Index)
                    e.Graphics.FillRectangle(new Draw.SolidBrush(Draw.Color.White), e.Bounds);

                // 현재 탭에 대한 close 버튼 이미지 및 스타일 설정
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

                // 탭 페이지 텍스트 그리기
                e.Graphics.DrawString(title, f, ForeBrush, new Draw.PointF(r.X, r.Y));

                // 탭 페이지의 닫기 버튼 이미지 그리기
                e.Graphics.DrawImage(img, new Draw.Point(r.X + this.tabControl1.GetTabRect(e.Index).Width - _imageLocation.X - 22, _imageLocation.Y + 4));
                img.Dispose();
                img = null;

                // 선택된 탭 여부에 따라 사용한 자원 해제
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
                // 예외 처리
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
                // 마우스 클릭한 위치에 닫기 버튼이 있는지 확인
                System.Windows.Forms.TabPage TabP = (System.Windows.Forms.TabPage)tc.TabPages[tc.SelectedIndex];

                if (TabP.Text == common.defaultTab)
                {
                    // 기본 탭은 제거하지 않음
                    return;
                }

                // 탭 페이지 제거
                tc.TabPages.Remove(TabP);
                int index = common.DICT_REMOVE_INDEX[TabP.Text];
                common.DICT_REMOVE_INDEX.Remove(TabP.Text);

                // 탭페이지를 앞으로 한 칸씩 당김
                for (int i = index; i < common.DICT_REMOVE_INDEX.Count; i++)
                {
                    string tempstring = common.DICT_REMOVE_INDEX.FirstOrDefault(x => x.Value == i + 1).Key;
                    int tempint = common.DICT_REMOVE_INDEX[tempstring];
                    common.DICT_REMOVE_INDEX.Remove(tempstring);
                    common.DICT_REMOVE_INDEX.Add(tempstring, tempint - 1);
                }

                // 탭이 모두 제거된 경우 기본 탭을 선택
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
                // 탭이 존재하지 않으면 새로운 탭을 추가

                // 동적으로 폼 인스턴스 생성
                dynamic form = Activator.CreateInstance(formType);
                SubscribeToFormCloseEvent(form);
                form.TopLevel = false;

                // 탭 페이지 추가 및 설정
                contorl.TabPages.Add(title);
                contorl.TabPages[contorl.TabPages.Count - 1].Controls.Add(form);
                contorl.SelectedIndex = contorl.TabPages.Count - 1;
                contorl.TabPages[contorl.TabPages.Count - 1].Controls.Add(form);

                // 기본 탭인 경우 폼의 크기 설정
                if (title == common.defaultTab)
                {
                    form.FormSetSize(contorl.ClientRectangle.Width, contorl.ClientRectangle.Height);
                }

                // 탭 인덱스 저장
                common.DICT_REMOVE_INDEX.Add(title, contorl.SelectedIndex);

                // 폼의 Dock 속성 설정
                form.Dock = DockStyle.Fill;
                form.Show();
            }
            else
            {
                // 탭이 이미 존재하면 해당 탭으로 이동
                contorl.SelectedTab = contorl.TabPages[common.DICT_REMOVE_INDEX[title]];
            }
        }

        public void SubscribeToFormCloseEvent(dynamic form)
        {
            // FormCloseEvent 이벤트에 대한 핸들러 등록
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
            // 탭 페이지를 삭제하는 메서드

            Console.WriteLine("Called delete tabPage");

            int aint = 0;
            for (int i = 0; i < tabControl1.TabPages.Count; i++)
            {
                if (tabControl1.TabPages[i].Text == temp)
                {
                    aint = i;
                }
            }

            // 선택된 탭 페이지 제거
            tabControl1.TabPages.RemoveAt(aint);

            // 삭제된 탭의 인덱스 저장
            int index = common.DICT_REMOVE_INDEX[temp];
            common.DICT_REMOVE_INDEX.Remove(temp);

            // 삭제된 탭 이후의 탭을 앞으로 당김
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

            // 탭이 하나도 남지 않은 경우 마지막 탭을 선택
            tabControl1.SelectedIndex = aint - 1;
        }

        public void ChangeTab(string title)
        {
            // 탭을 변경하거나 추가하는 메서드

            if (common.DICT_REMOVE_INDEX.Count > 5)
            {
                // 탭의 최대 개수를 초과하는 경우 메시지 표시 및 추가 동작 방지
                MessageBox.Show("탭은 최대 6개까지 열 수 있습니다.");
                return;
            }

            if (common.DICT_REMOVE_INDEX.ContainsKey(common.defaultTab))
            {
                // 기본 탭이 이미 존재하는 경우 삭제
                DeleteTabpage(common.defaultTab);
            }

            // 선택된 탭에 따라 적절한 탭 추가 또는 선택
            switch (title)
            {
                case "새 탭":
                    AddOrSelectTabPage(title, typeof(DefaultForm), tabControl1);
                    break;
                case "대시보드":
                    AddOrSelectTabPage(title, typeof(Dashboard), tabControl1);
                    break;
                case "불량관리":
                    AddOrSelectTabPage(title, typeof(Error), tabControl1);
                    break;
                case "제품관리":
                    AddOrSelectTabPage(title, typeof(Product), tabControl1);
                    break;
                case "캘린더":
                    AddOrSelectTabPage(title, typeof(Calinder), tabControl1);
                    break;
                    // ... (다른 탭들에 대한 추가 및 선택 로직)
            };
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
