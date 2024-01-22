using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_base.Properties
{
    public partial class Product : Form
    {
        // 클래스 전역 선언
        Product_Details Details;

        public Product()
        {
            InitializeComponent();

            // 클래스 객체 생성
            Details = new Product_Details();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)// 날짜를 선택하기 위한 버튼
        {
            // 달력을 호출할 코드 작성
            

            // 선택한 날짜를 전달하여 그리드뷰에 스태킹의 정보를 출력
            // Details.stack_gridview(datetimePicker1.value, dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)// stacking 그리드뷰의 셀을 선택하면 호출되는 메소드
        {
            // 선택한 행의 정보를 전달하여 그리드뷰에 셀의 정보를 출력
            Details.Lot_gridview(dataGridView1.Rows[e.RowIndex], dataGridView2);
        }
    }
}
