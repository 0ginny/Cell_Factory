using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_Project
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
            //fontFileName = "Fonts/Pretendard-Light.otf";
            //fontFilePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fontFileName);
            //Console.WriteLine(fontFilePath);

            //LoadExternalFont(fontFilePath);
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

            //// 기존 폰트 Dispose
            //if (dataGridView.Font != null)
            //{
            //    dataGridView.Font.Dispose();
            //}

            // DataGridView의 폰트 설정
            dataGridView.Font = newFont;
        }


        public void AutoResizeColumns(DataGridView dataGridView)
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Optional: Set the last column to fill remaining space
            dataGridView.Columns[dataGridView.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        //public void SetColumnWidths(DataGridView dataGridView, params int[] columnWidthRatios)
        //{
        //    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

        //    if (columnWidthRatios.Length != dataGridView.Columns.Count)
        //    {
        //        throw new ArgumentException("The number of ratios must match the number of columns.");
        //    }

        //    float totalRatio = columnWidthRatios.Sum();

        //    for (int i = 0; i < dataGridView.Columns.Count; i++)
        //    {
        //        dataGridView.Columns[i].Width = (int)((columnWidthRatios[i] / totalRatio) * dataGridView.ClientSize.Width);
        //    }
        //}




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
    }
}
