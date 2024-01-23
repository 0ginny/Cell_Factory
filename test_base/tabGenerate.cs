using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace test_base
{
    internal class tabGenerate
    {
        private TabControl tabControl;
        private Dictionary<string, int> tabIndices; // 탭과 인덱스를 저장하는 딕셔너리
        private Point imageLocation = new Point(15, 5);
        private Point imgHitArea = new Point(13, 2);

        // 생성자
        public tabGenerate(TabControl tabControl)
        {
            //this.tabControl = tabControl;
            // 생성자에서 tabControl을 초기화
            this.tabControl = tabControl ?? throw new ArgumentNullException(nameof(tabControl));
            this.tabIndices = new Dictionary<string, int>();
        }

        // 탭을 생성하거나 선택하는 메서드
        public void AddOrSelectTabPage(string title, Type formType)
        {
            if (!tabIndices.ContainsKey(title))
            {
                dynamic form = Activator.CreateInstance(formType);
                SubscribeToFormCloseEvent(form);
                form.TopLevel = false;

                // 탭을 추가하고 선택
                tabControl.TabPages.Add(title);
                tabControl.TabPages[tabControl.TabPages.Count - 1].Controls.Add(form);
                tabControl.SelectedIndex = tabControl.TabPages.Count - 1;
                tabControl.TabPages[tabControl.TabPages.Count - 1].Controls.Add(form);

                if (title == "DefaultTab")
                {
                    form.FormSetSize(tabControl.ClientRectangle.Width, tabControl.ClientRectangle.Height);
                }

                // 딕셔너리에 탭과 인덱스 추가
                tabIndices.Add(title, tabControl.SelectedIndex);

                // 탭을 도킹 및 표시
                form.Dock = DockStyle.Fill;
                form.Show();
            }
            else
            {
                // 이미 있는 탭이면 해당 탭으로 이동
                tabControl.SelectedTab = tabControl.TabPages[tabIndices[title]];
            }
        }

        // 폼의 종료 이벤트에 구독하는 메서드
        public void SubscribeToFormCloseEvent(dynamic form)
        {
            var eventInfo = form.GetType().GetEvent("FormCloseEvent");
            if (eventInfo != null)
            {
                var delegateType = eventInfo.EventHandlerType;
                var handler = Delegate.CreateDelegate(delegateType, this, "DeleteTabpage");
                eventInfo.AddEventHandler(form, handler);
            }
        }

        // 탭을 삭제하는 메서드
        private void DeleteTabpage(string temp)
        {
            Console.WriteLine("Called delete tabPage");

            int tabIndex = 0;
            for (int i = 0; i < tabControl.TabPages.Count; i++)
            {
                if (tabControl.TabPages[i].Text == temp)
                {
                    tabIndex = i;
                }
            }
            tabControl.TabPages.RemoveAt(tabIndex);

            int index = tabIndices[temp];

            // 딕셔너리에서 탭을 제거하고 나머지 탭을 앞으로 당김
            tabIndices.Remove(temp);
            for (int i = index; i < tabIndices.Count; i++)
            {
                string tempString = tabIndices.FirstOrDefault(x => x.Value == i + 1).Key;
                int tempInt = tabIndices[tempString];
                tabIndices.Remove(tempString);
                tabIndices.Add(tempString, tempInt - 1);
            }

            // 선택된 탭을 앞 탭으로 변경
            tabControl.SelectedIndex = tabIndex - 1;
        }

        // 탭의 모양을 그리는 이벤트 핸들러
        public void TabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                Image img;
                Font f = tabControl.Font;
                Rectangle r = e.Bounds;
                Brush selectedBackBrush = new SolidBrush(Color.FromArgb(230, 230, 230));
                Brush noneSelectedBackBrush = new SolidBrush(Color.FromArgb(224, 223, 230));
                Brush foreBrush = new SolidBrush(Color.Black);

                string title = tabControl.TabPages[e.Index].Text;
                r = tabControl.GetTabRect(e.Index);
                r.Offset(10, 10);

                // 선택된 탭의 배경 색은 흰색으로 처리
                if (tabControl.SelectedIndex == e.Index)
                    e.Graphics.FillRectangle(new SolidBrush(Color.White), e.Bounds);

                if (tabControl.SelectedTab == tabControl.TabPages[e.Index])
                {
                    img = Properties.Resources.Close_Black;
                    f = new Font(e.Font, FontStyle.Bold);
                    e.Graphics.FillRectangle(selectedBackBrush, e.Bounds);
                }
                else
                {
                    img = Properties.Resources.Close_Gray;
                    f = e.Font;
                }

                // 탭의 텍스트 그리기
                e.Graphics.DrawString(title, f, foreBrush, new PointF(r.X, r.Y));

                // 탭의 닫기 버튼 그리기
                e.Graphics.DrawImage(img, new Point(r.X + tabControl.GetTabRect(e.Index).Width - imageLocation.X - 22, imageLocation.Y + 4));
                img.Dispose();
                img = null;

                if (e.Index == tabControl.SelectedIndex)
                {
                    f.Dispose();
                    selectedBackBrush.Dispose();
                }
                else
                {
                    selectedBackBrush.Dispose();
                    foreBrush.Dispose();
                }
            }
            catch (Exception)
            {
            }
        }

        // 탭을 클릭하여 닫기 버튼이 눌렸을 때의 이벤트 핸들러
        public void TabControl_MouseClick(object sender, MouseEventArgs e)
        {
            TabControl tc = (TabControl)sender;
            int tabIndex = tc.SelectedIndex;
            Point p = e.Location;
            int tabWidth = 0;
            tabWidth = tc.GetTabRect(tc.SelectedIndex).Width - (imgHitArea.X) - 18;
            Rectangle r = tc.GetTabRect(tc.SelectedIndex);
            r.Offset(tabWidth, imgHitArea.Y + 4);
            r.Width = 16;
            r.Height = 16;

            if (r.Contains(p))
            {
                System.Windows.Forms.TabPage tabPage = (System.Windows.Forms.TabPage)tc.TabPages[tc.SelectedIndex];

                if (tabPage.Text == "DefaultTab")
                {
                    return;
                }
                tc.TabPages.Remove(tabPage);
                int index = tabIndices[tabPage.Text];
                tabIndices.Remove(tabPage.Text);

                // 탭을 앞으로 한 칸씩 땡김
                for (int i = index; i < tabIndices.Count; i++)
                {
                    string tempString = tabIndices.FirstOrDefault(x => x.Value == i + 1).Key;
                    int tempInt = tabIndices[tempString];
                    tabIndices.Remove(tempString);
                    tabIndices.Add(tempString, tempInt - 1);
                }

                if (tabIndices.Count == 0)
                {
                    AddOrSelectTabPage("DefaultTab", typeof(DefaultForm));
                }
            }
        }
    }
}