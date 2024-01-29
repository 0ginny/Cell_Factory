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
using System.IO.Pipelines;

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

            Console.WriteLine($"{err.surface_err}), {err.contain_err}), {err.volt_err}), {err.press_err}), {err.temp_err}),)");
            // 초기에 콤보박스에 A셀, B셀, C셀 추가
            //comboBox1.Items.Add("A셀");
            //comboBox1.Items.Add("B셀");
            //comboBox1.Items.Add("C셀");

            // 오늘 날짜를 label2에 표시
            label2.Text = DateTime.Now.ToString("오늘 yyyy년 MM월 dd일");



            renewChart();

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
            label_clear();
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


        private void button4_Click(object sender, EventArgs e)
        {
            panel17.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 시작날짜 비교
            DateTime startDate = hopeDatePicker1.Date;
            DateTime endDate = hopeDatePicker2.Date;
            int compareResult = DateTime.Compare(startDate, endDate);

            if (compareResult > 0)
            {
                // 시작 날짜가 종료 날짜보다 미래에 있는 경우
                MessageBox.Show("시작 날짜는 종료 날짜보다 이전이어야 합니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // 오류 처리 등 추가 작업 수행
            }
            else
            {
                // 시작 날짜가 종료 날짜와 같거나 과거인 경우
                err.start_date = startDate.ToString("yyyy-MM-dd");
                err.end_date = endDate.ToString("yyyy-MM-dd");
                panel17.Visible = false;
                //목록 변경
                err.Cell_Error_list(dgv_cell_error);
                err.Stack_Error_list(dgv_stacking_error);
                renewChart();
                label2.Text = label6.Text + "  ~  " + label7.Text;
                // 필요한 작업 수행
            }




        }
        
        private void button3_Click(object sender, EventArgs e)// 날짜와 제품의 종류에 대한 불량 검색을 위한 버튼
        {
            // 선택한 날짜와 제품의 종류를 그리드뷰 2개, 차트 4개에 출력
            // error.Error_view(dateTimePicker1, comboBox1.SelectedItem.ToString(), dataGridView1, dataGridView2, chart1, chart2, chart3, chart4);

        }

        private void hopeDatePicker1_onDateChanged(DateTime newDateTime)
        {
            label6.Text = hopeDatePicker1.Date.ToString("yyyy년 MM월 dd일"); // 날짜 형식은 원하는 대로 설정
            label6.Visible = true;
            label8.Visible = true;
        }

        private void hopeDatePicker2_onDateChanged(DateTime newDateTime)
        {
            label7.Text = hopeDatePicker2.Date.ToString("yyyy년 MM월 dd일"); // 날짜 형식은 원하는 대로 설정
            label7.Visible = true;

        }

        private void label_clear()
        {
            label6.Visible = false;
            label8.Visible = false;
            label7.Visible = false;
        }

        private Func<ChartPoint, string> LabelPointFunc()
        {
            return chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
        }
        private void renewChart()
        {
            err.setPieChartData();

            // Pie 차트1

            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "이물질",
                    FontSize = 16,
                    Values = new ChartValues<int> {err.contain_err},
                    PushOut = 15,
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "전압",
                    FontSize = 16,
                    Values = new ChartValues<int> {err.volt_err},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "표면 결함",
                    FontSize = 16,
                    Values = new ChartValues<int> {err.surface_err},
                    DataLabels = true,
                    LabelPoint = labelPoint
                }
            };
            pieChart1.LegendLocation = LegendLocation.Bottom;

            //파이차트2
            Func<ChartPoint, string> labelPoint1 = chartPoint1 =>
                string.Format("{0} ({1:P})", chartPoint1.Y, chartPoint1.Participation);

            pieChart2.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "압력",
                    FontSize = 16,
                    Values = new ChartValues<int> {err.press_err},
                    PushOut = 15,
                    DataLabels = true,
                    LabelPoint = labelPoint1
                },
                new PieSeries
                {
                    Title = "온도",
                    FontSize = 16,
                    Values = new ChartValues<int> {err.temp_err},
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
                    FontSize = 14,
                    Values = new ChartValues<double> {err.contain_err},
                    StackMode = StackMode.Values, // this is not necessary, values is the default stack mode
                    DataLabels = true
                },
                new StackedColumnSeries
                {
                    Title = "전압",
                    FontSize = 14,
                    Values = new ChartValues<double> {err.volt_err},
                    StackMode = StackMode.Values,
                    DataLabels = true
                },
                new StackedColumnSeries
                {
                    Title = "표면 결함",
                    FontSize = 14,
                    Values = new ChartValues<double> {err.surface_err},
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
                    Title = "압력",
                    FontSize = 14,
                    Values = new ChartValues<double> {err.press_err},
                    StackMode = StackMode.Values, // this is not necessary, values is the default stack mode
                    DataLabels = true
                },
                new StackedColumnSeries
                {
                    Title = "온도",
                    FontSize = 14,
                    Values = new ChartValues<double> {err.temp_err},
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
    }
}
