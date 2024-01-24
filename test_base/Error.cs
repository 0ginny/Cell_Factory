using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.Wpf;
using LiveCharts;
using MySql.Data;
using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;

namespace test_base
{
    public partial class Error : Form
    {
        public Error()
        {
            InitializeComponent();
            panel17.Visible = false;


            // 초기에 콤보박스에 A셀, B셀, C셀 추가
            comboBox1.Items.Add("A셀");
            comboBox1.Items.Add("B셀");
            comboBox1.Items.Add("C셀");

            // 오늘 날짜를 label2에 표시
            label2.Text = DateTime.Now.ToString("yyyy년 MM월 dd일");

            //pie 차트1
            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "이물질",
                    Values = new ChartValues<double> {3},
                    PushOut = 15,
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "전압",
                    Values = new ChartValues<double> {4},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "표면 결함",
                    Values = new ChartValues<double> {6},
                    DataLabels = true,
                    LabelPoint = labelPoint
                }
            };
            //파이차트2
            Func<ChartPoint, string> labelPoint1 = chartPoint1 =>
                string.Format("{0} ({1:P})", chartPoint1.Y, chartPoint1.Participation);

            pieChart2.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "용접",
                    Values = new ChartValues<double> {4},
                    PushOut = 15,
                    DataLabels = true,
                    LabelPoint = labelPoint1
                },
                new PieSeries
                {
                    Title = "온도",
                    Values = new ChartValues<double> {2},
                    DataLabels = true,
                    LabelPoint = labelPoint1
                }
            };

            pieChart2.LegendLocation = LegendLocation.Bottom;

            //막대차트1
            cartesianChart1.Series = new SeriesCollection
            {
                new StackedColumnSeries
                {
                    Title = "이물질",
                    Values = new ChartValues<double> {3},
                    StackMode = StackMode.Values, // this is not necessary, values is the default stack mode
                    DataLabels = true
                },
                new StackedColumnSeries
                {
                    Title = "전압",
                    Values = new ChartValues<double> {4},
                    StackMode = StackMode.Values,
                    DataLabels = true
                },
                new StackedColumnSeries
                {
                    Title = "표면 결함",
                    Values = new ChartValues<double> {6},
                    StackMode = StackMode.Values,
                    DataLabels = true
                }

            };

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Cell 불량",
                Labels = new[] { "" },
                Separator = DefaultAxes.CleanSeparator
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "",
                LabelFormatter = value => value + "개"
            });
            //막대차트2
            cartesianChart2.Series = new SeriesCollection
            {
                new StackedColumnSeries
                {
                    Title = "용접",
                    Values = new ChartValues<double> {4},
                    StackMode = StackMode.Values, // this is not necessary, values is the default stack mode
                    DataLabels = true
                },
                new StackedColumnSeries
                {
                    Title = "온도",
                    Values = new ChartValues<double> {2},
                    StackMode = StackMode.Values,
                    DataLabels = true
                }
            };

            cartesianChart2.AxisX.Add(new Axis
            {
                Title = "Stacking 불량",
                Labels = new[] { "" },
                Separator = DefaultAxes.CleanSeparator
            });

            cartesianChart2.AxisY.Add(new Axis
            {
                Title = "",
                LabelFormatter = value => value + "개"
            });

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Error_Load(object sender, EventArgs e)
        {
            weldingDG.Rows.Add("온도", "1200", "10시 15분 42초");
            weldingDG.Rows.Add("압력", "50", "11시 15분 42초");

            SellDG.Rows.Add("이물질", "0.04", "09시 15분 42초");
            SellDG.Rows.Add("전압", "4.2", "15시 15분 42초");
            SellDG.Rows.Add("표면 결함", "0.12", "17시 15분 42초");

            ApplyRoundedBorder(panel5, 20, ColorTranslator.FromHtml("#D1D9E7"), 2); // 20은 반지름 값, 2는 테두리 굵기, 조절 가능
            ApplyRoundedBorder(panel6, 20, ColorTranslator.FromHtml("#D1D9E7"), 2); // 20은 반지름 값, 2는 테두리 굵기, 조절 가능
            ApplyRoundedBorder(panel7, 20, ColorTranslator.FromHtml("#D1D9E7"), 2); // 20은 반지름 값, 2는 테두리 굵기, 조절 가능
            ApplyRoundedBorder(panel8, 20, ColorTranslator.FromHtml("#D1D9E7"), 2); // 20은 반지름 값, 2는 테두리 굵기, 조절 가능
            ApplyRoundedBorder(panel17, 20, ColorTranslator.FromHtml("#D1D9E7"), 2); // 20은 반지름 값, 2는 테두리 굵기, 조절 가능
            ApplyRoundedBorder(button1, 20, ColorTranslator.FromHtml("#D1D9E7"), 2); // 20은 반지름 값, 2는 테두리 굵기, 조절 가능
            ApplyRoundedBorder(button3, 20, ColorTranslator.FromHtml("#D1D9E7"), 2); // 20은 반지름 값, 2는 테두리 굵기, 조절 가능

        }

        private void hopeDatePicker1_Click(object sender, EventArgs e)
        {
            label6.Text = hopeDatePicker1.Date.ToString("yyyy년 MM월 dd일"); // 날짜 형식은 원하는 대로 설정
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel17.Size = new System.Drawing.Size(500, 320);
            panel17.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 콤보박스에서 선택한 항목에 대한 동작을 정의
            string selectedCell = comboBox1.SelectedItem as string;

            if (selectedCell != null)
            {
                // 여기에 선택한 항목에 대한 동작을 추가하세요.
                MessageBox.Show($"선택한 셀: {selectedCell}");
            }
        }

        private void parrotPieGraph1_Click(object sender, EventArgs e)
        {

        }

        private void hopeDatePicker2_Click(object sender, EventArgs e)
        {
            label7.Text = hopeDatePicker2.Date.ToString("yyyy년 MM월 dd일"); // 날짜 형식은 원하는 대로 설정
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel17.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel17.Visible = false;
        }
        private void ApplyRoundedBorder(Control control, int radius, Color borderColor, int borderSize)
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
