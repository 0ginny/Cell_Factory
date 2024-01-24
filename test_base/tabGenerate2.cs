using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace test_base
{
    internal class tabGenerate2
    {
        private static TabControl tabControl;

        private Dictionary<string, int> tabIndices;
        private Point imageLocation = new Point(15, 5);
        private Point imgHitArea = new Point(13, 2);

        public tabGenerate2(TabControl tabControl)
        {
            tabGenerate2.tabControl = tabControl ?? throw new ArgumentNullException(nameof(tabControl));
            tabGenerate2.tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabGenerate2.tabControl.DrawItem += TabControl_DrawItem;
            tabGenerate2.tabControl.MouseDown += TabControl_MouseClick;

            tabIndices = new Dictionary<string, int>();
        }

        public void AddOrSelectTabPage(string title, Type formType)
        {
            if (!tabIndices.ContainsKey(title))
            {
                dynamic form = Activator.CreateInstance(formType);
                SubscribeToFormCloseEvent(form);
                form.TopLevel = false;

                tabControl.TabPages.Add(title);
                tabControl.TabPages[tabControl.TabPages.Count - 1].Controls.Add(form);
                tabControl.SelectedIndex = tabControl.TabPages.Count - 1;
                tabControl.TabPages[tabControl.TabPages.Count - 1].Controls.Add(form);

                if (title == "DefaultTab")
                {
                    // Replace with the appropriate method from DefaultForm
                    form.SetFormSize(tabControl.ClientRectangle.Width, tabControl.ClientRectangle.Height);
                }

                tabIndices.Add(title, tabControl.SelectedIndex);

                form.Dock = DockStyle.Fill;
                form.Show();
            }
            else
            {
                tabControl.SelectedTab = tabControl.TabPages[tabIndices[title]];
            }
        }

        private void SubscribeToFormCloseEvent(dynamic form)
        {
            var eventInfo = form.GetType().GetEvent("FormClosed");
            if (eventInfo != null)
            {
                var delegateType = eventInfo.EventHandlerType;
                var handler = Delegate.CreateDelegate(delegateType, this, "DeleteTabpage");
                eventInfo.AddEventHandler(form, handler);
            }
        }

        // 탭 페이지 삭제 메서드
        private void DeleteTabpage(object sender, EventArgs e)
        {
            // 현재 선택된 탭 페이지의 인덱스를 가져옴
            int tabIndex = tabControl.SelectedIndex;

            // 현재 선택된 탭 페이지의 제목을 가져옴
            string tabTitle = tabControl.SelectedTab.Text;

            // 탭 페이지를 제거
            tabControl.TabPages.RemoveAt(tabIndex);

            // 딕셔너리에서 탭 정보를 제거
            tabIndices.Remove(tabTitle);

            // 남은 탭의 인덱스를 조정
            for (int i = tabIndex; i < tabIndices.Count; i++)
            {
                string tempTitle = tabIndices.FirstOrDefault(x => x.Value == i + 1).Key;
                int tempIndex = tabIndices[tempTitle];
                tabIndices.Remove(tempTitle);
                tabIndices.Add(tempTitle, tempIndex - 1);
            }

            // 선택된 탭을 앞 탭으로 변경 (마지막 탭일 경우 마지막 탭을 선택)
            tabControl.SelectedIndex = (tabIndex > 0) ? tabIndex - 1 : Math.Min(tabIndices.Values.DefaultIfEmpty(0).Min(), tabControl.TabCount - 1);

            Console.WriteLine("Called delete tabPage");

            // 여기에서 사용되지 않는 매개변수 temp 대신에 e를 활용할 수 있습니다.
            string temp = ((TabPage)sender).Text;

            tabIndex = 0;
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
                // 예외 처리
            }
        }

        private void TabControl_MouseClick(object sender, MouseEventArgs e)
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