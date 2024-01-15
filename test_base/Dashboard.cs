using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            // 이미지를 프로젝트 리소스에서 가져와서 PictureBox의 이미지로 설정
            pictureBox1.Image = Properties.Resources.실시간모니터링_그림;
            pictureBox2.Image = Properties.Resources.하양_1단;
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
    }
}
