using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace test_base
{
    public partial class Dashboard : Form
    {


        public Dashboard()
        {
            InitializeComponent();
            Load += Dashboard_Load;
            circleProgressBar();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            // 이미지를 프로젝트 리소스에서 가져와서 PictureBox의 이미지로 설정
            pictureBox1.Image = Properties.Resources.실시간모니터링_그림;
            pictureBox2.Image = Properties.Resources.녹색_1단;

            // dataGridView1에 헤더 추가
            dataGridView1.ColumnCount = 3; // 열의 수 설정
            dataGridView1.Columns[0].Name = "시간"; // 첫 번째 열의 헤더
            dataGridView1.Columns[1].Name = "알람"; // 두 번째 열의 헤더
            dataGridView1.Columns[2].Name = "횟수"; // 세 번째 열의 헤더
        }
        private void circleProgressBar()
        {
            circleProgressBar1.Value = 75;
        }

        private void label1_Click(object sender, EventArgs e)// label을 클릭해서 사용해야 할 기능이 있는지 의문
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer4_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = ColorTranslator.FromHtml("#002EDE");
            button2.BackColor = ColorTranslator.FromHtml("#FFCC00");
            button3.BackColor = ColorTranslator.FromHtml("#1FC695");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = ColorTranslator.FromHtml("#1F6BFF");
            button2.BackColor = ColorTranslator.FromHtml("#EBBC00");
            button3.BackColor = ColorTranslator.FromHtml("#1FC695");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = ColorTranslator.FromHtml("#1F6BFF");
            button2.BackColor = ColorTranslator.FromHtml("#FFCC00");
            button3.BackColor = ColorTranslator.FromHtml("#1AA67D");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.BackColor = ColorTranslator.FromHtml("#1F6BFF");
            button2.BackColor = ColorTranslator.FromHtml("#FFCC00");
            button3.BackColor = ColorTranslator.FromHtml("#1FC695");
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
