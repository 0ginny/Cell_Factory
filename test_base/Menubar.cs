using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_base;
using test_base.Properties;

namespace tast_base

{
    internal class Menubar
    {
        private TabControl tabControl;

        CSS css;



        public Menubar(TabControl tabControl)
        {
            css = new CSS();
            this.tabControl = tabControl;
            this.tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.tabControl.DrawItem += TabControl_DrawItem;
            this.tabControl.MouseDown += TabControl_MouseDown;



        }

        private void TabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                //Font f = this.tabControl.Font;
                Font f = new Font("맑은 고딕", 10, FontStyle.Bold);
                Rectangle r = e.Bounds;
                Brush titleBrush = new SolidBrush(Color.Black);
                string title = this.tabControl.TabPages[e.Index].Text;

                r.Offset(2, 2);

                // SelectedTab의 Background Color 는 White으로 처리
                if (this.tabControl.SelectedIndex == e.Index)
                    e.Graphics.FillRectangle(new SolidBrush(Color.LightGray), e.Bounds);

                // 각 Tab별로 close button 에 대한 image값
                Image img = (this.tabControl.SelectedTab == this.tabControl.TabPages[e.Index])
                            ? Resources.Close_Black
                            : Resources.Close_Gray;

                // TabPage Text
                e.Graphics.DrawString(title, f, titleBrush, new PointF(r.X, r.Y));

                int newWidth = 8; // 원하는 너비
                int newHeight = 8; // 원하는 높이

                img = ResizeImage(img, newWidth, newHeight);

                // TabPage 의 닫기 버튼
                r = this.tabControl.GetTabRect(e.Index);
                int x = r.Right - 15; // 조절 가능한 값
                int y = r.Top + (r.Height - img.Height) / 2;
                e.Graphics.DrawImage(img, new Point(x, y));
            }
            catch (Exception)
            {
                // 예외 처리
            }
        }

        public Image ResizeImage(Image image, int newWidth, int newHeight)
        {
            Bitmap resizedBitmap = new Bitmap(newWidth, newHeight);

            using (Graphics g = Graphics.FromImage(resizedBitmap))
            {
                g.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            return resizedBitmap;
        }

        private void TabControl_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < this.tabControl.TabPages.Count; i++)
            {
                Rectangle r = this.tabControl.GetTabRect(i);
                r = new Rectangle(r.Right-20, r.Top, 32, 32); // 수정된 부분
                if (r.Contains(e.Location))
                {
                    this.CloseForm(this.tabControl.TabPages[i].Text);
                    break;
                }
            }
        }

        public void OpenForm<T>(string tabName) where T : Form, new()
        {
            tabName += "    ";

            TabPage tabPage = FindTabPage(tabName);

            if (tabPage == null)
            {
                T formInstance = Activator.CreateInstance<T>();
                formInstance.FormClosed += (sender, e) => FormClosedHandler(formInstance);
                formInstance.MdiParent = null;
                formInstance.Dock = DockStyle.Fill;
                formInstance.TopLevel = false;

                tabPage = new TabPage(tabName);
                tabPage.Controls.Add(formInstance);
                tabControl.TabPages.Add(tabPage);

                //css.FormFontChange(formInstance); // font 바꾸는 코드

                formInstance.Show(); // Form을 표시하는 코드 추가



                tabControl.SelectedTab = tabPage;
            }
            else
            {
                tabControl.SelectedTab = tabPage;
            }
        }

        private void FormClosedHandler<T>(T formInstance) where T : Form
        {
            //css.FormFontChange(null);
            CloseForm(formInstance.Text); // 여기서 formInstance.Text를 tabName으로 변경
            formInstance = null;
        }

        private void CloseForm(string tabName)
        {
            TabPage tabPage = FindTabPage(tabName);
            if (tabPage != null)
            {
                tabControl.TabPages.Remove(tabPage);
            }
        }

        private TabPage FindTabPage(string tabName)
        {
            foreach (TabPage tabPage in tabControl.TabPages)
            {
                if (tabPage.Text == tabName)
                {
                    return tabPage;
                }
            }
            return null;
        }

        

    }


}
