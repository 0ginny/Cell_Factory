using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_base

{
    internal class CSS
    {

        private Font previousFont; // 클래스 레벨의 멤버 변수로 이전 폰트를 추적


        public void labelChange(Label label)
        {
            System.Drawing.Font ft = new System.Drawing.Font("맑은 고딕", 15, FontStyle.Bold);
            label.Font = ft;
        }


        public System.Drawing.Font Font { get; set; } = new System.Drawing.Font("맑은 고딕", 9);

        public string fontFileName;
        public string fontFilePath;


        public CSS()
        {

        }

        private void LoadExternalFont(string fontFilePath)
        {
            PrivateFontCollection privateFontCollection = new PrivateFontCollection();
            privateFontCollection.AddFontFile(fontFilePath);

            // 로드한 폰트를 사용하여 Font 객체 생성
            Font externalFont = new Font(privateFontCollection.Families[0], 8);
            Font = externalFont;
        }


        public void FormFontChange(Form form)
        {
            try
            {
                ChangeControlFont(form);
            }
            catch (Exception ex)
            {
                // 예외 발생 시 디버깅을 위해 로그를 남기거나 출력
                Console.WriteLine($"Exception in FormFontChange: {ex.Message}");
            }
        }

        private void ChangeControlFont(Control control)
        {

            // 컨트롤의 폰트 변경
            control.Font = Font;

            // ----
            // 하위 컨트롤에 대한 재귀적 호출
            foreach (Control childControl in control.Controls)
            {
                ChangeControlFont(childControl);
            }
        }

        public void ChangeDataGridViewFont(DataGridView dataGridView)
        {
            // 새로운 폰트로 변경
            Font newFont = new Font("맑은 고딕", 9, FontStyle.Bold);

            dataGridView.Font = newFont;
        }


        public void AutoResizeColumns(DataGridView dataGridView)
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Optional: Set the last column to fill remaining space
            dataGridView.Columns[dataGridView.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }





        public void SetColumnWidths(DataGridView dataGridView, params int[] columnWidthRatios)
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            if (columnWidthRatios.Length != dataGridView.Columns.Count)
            {
                throw new ArgumentException("The number of ratios must match the number of columns.");
            }

            float totalRatio = columnWidthRatios.Sum();

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].Width = (int)((columnWidthRatios[i] / totalRatio) * dataGridView.ClientSize.Width);
            }
        }


        public void ApplyRoundedBorder(Control control, int radius, Color borderColor, int borderSize)
        {
            // 컨트롤의 Paint 이벤트에 핸들러 추가
            control.Paint += (sender, e) => DrawRoundedBorder(sender as Control, radius, borderColor, borderSize);

            // GraphicsPath를 사용하여 둥근 경계를 만듭니다.
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90); // 좌상단
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90); // 우상단
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90); // 우하단
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90); // 좌하단
            path.CloseAllFigures();

            // 컨트롤에 경로를 설정하여 둥근 경계를 적용
            control.Region = new Region(path);
        }

        // 둥근 테두리 및 테두리 그리기
        private void DrawRoundedBorder(Control control, int radius, Color borderColor, int borderSize)
        {
            using (Pen borderPen = new Pen(borderColor, borderSize))
            {
                // Graphics 객체를 얻어와서 테두리를 그립니다.
                using (Graphics g = control.CreateGraphics())
                {
                    g.DrawPath(borderPen, CreateRoundedRectanglePath(control.ClientRectangle, radius));
                }
            }
        }

        // 둥근 사각형 경로 생성
        private GraphicsPath CreateRoundedRectanglePath(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90); // 좌상단
            path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90); // 우상단
            path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90); // 우하단
            path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90); // 좌하단
            path.CloseAllFigures();
            return path;
        }
    }
}
