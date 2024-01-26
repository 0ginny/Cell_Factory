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

namespace test_base
{
    public partial class AddOrder : Form
    {
        mysql my;
        int last_ord;
        public AddOrder()
        {
            InitializeComponent();
            my = new mysql();
            last_ord = my.GetNextID("orders", "ord_id", 3);
        }




        private void button5_Click(object sender, EventArgs e)
        {
            string plan_day = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string d_day = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string selectedValue;
            switch (comboBox2.Text)
            {
                case "리튬 이온 배터리":
                    selectedValue = "prod001";
                    break;

                case "NiMH 배터리":
                    selectedValue = "prod002";
                    break;

                case "납산 배터리":
                    selectedValue = "prod003";
                    break;

                // 추가적인 항목이 있다면 여기에 계속해서 추가할 수 있습니다.

                default:
                    selectedValue = null;
                    // 선택된 항목이 없거나 일치하는 항목이 없는 경우에 대한 처리
                    break;
            }

            string nextOrderId = "ord" + last_ord.ToString("D4");

            string sql = $@"insert into orders(ord_id, prod_id, ord_num, company, d_date, ord_time, plan_date, i_fin)
                                    values ( '{nextOrderId}','{selectedValue}', {textBox2.Text}, '{textBox1.Text}','{d_day}',now(), '{plan_day}' , -1);";
            Console.WriteLine(sql);
            my.sendsql(sql);
            MessageBox.Show("등록완료!", "안내");
            last_ord++;
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            comboBox2.DisplayMember = "Text";
            comboBox2.ValueMember = "Value";

            comboBox2.Items.Add(new { Text = "리튬 이온 배터리", Value = "prod001" });
            comboBox2.Items.Add(new { Text = "NiMH 배터리", Value = "prod002" });
            comboBox2.Items.Add(new { Text = "납산 배터리", Value = "prod003" });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
