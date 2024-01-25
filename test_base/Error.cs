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
        // 클래스 전역 선언
        Error_Management err;
        CSS css;
        public Error()
        {
            InitializeComponent();


            //hopeDatePicker1.Visible = false;

            // 클래스 객체 생성
            err = new Error_Management();
            css = new CSS();
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

            css.ApplyRoundedBorder(panel5, 20, ColorTranslator.FromHtml("#D1D9E7"), 2); // 20은 반지름 값, 2는 테두리 굵기, 조절 가능
            css.ApplyRoundedBorder(panel6, 20, ColorTranslator.FromHtml("#D1D9E7"), 2); // 20은 반지름 값, 2는 테두리 굵기, 조절 가능
            css.ApplyRoundedBorder(panel7, 20, ColorTranslator.FromHtml("#D1D9E7"), 2); // 20은 반지름 값, 2는 테두리 굵기, 조절 가능
            css.ApplyRoundedBorder(panel8, 20, ColorTranslator.FromHtml("#D1D9E7"), 2); // 20은 반지름 값, 2는 테두리 굵기, 조절 가능
            css.ApplyRoundedBorder(panel17, 20, ColorTranslator.FromHtml("#D1D9E7"), 2); // 20은 반지름 값, 2는 테두리 굵기, 조절 가능
            css.ApplyRoundedBorder(button1, 20, ColorTranslator.FromHtml("#D1D9E7"), 2); // 20은 반지름 값, 2는 테두리 굵기, 조절 가능
            css.ApplyRoundedBorder(button3, 20, ColorTranslator.FromHtml("#D1D9E7"), 2); // 20은 반지름 값, 2는 테두리 굵기, 조절 가능



            //---------------------------datagrid
            err.Cell_Error_list(dgv_cell_error);
            err.Stack_Error_list(dgv_stacking_error);

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
        
        private void button3_Click(object sender, EventArgs e)// 날짜와 제품의 종류에 대한 불량 검색을 위한 버튼
        {
            // 선택한 날짜와 제품의 종류를 그리드뷰 2개, 차트 4개에 출력
            // error.Error_view(dateTimePicker1, comboBox1.SelectedItem.ToString(), dataGridView1, dataGridView2, chart1, chart2, chart3, chart4);

        }
    }
}
