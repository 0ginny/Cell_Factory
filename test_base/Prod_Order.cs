using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_base
{
    internal class Prod_Order
    {
        // mysql에 접속하기 위한 전역 변수
        mysql mysql;

        // 선택한 제품의 종류를 저장하기 위한 변수
        public string btn_state { get; set; } = null;

        /// <summary>
        /// 선택 제품 저장
        /// </summary>
        /// <param name="btn">선택 제품 저장</param>
        public void change_state(Button btn)
        {
            btn_state = btn.Text;
        }

        /// <summary>
        /// 발주 제품을 데이터베이스에 저장
        /// </summary>
        /// <param name="txt">발주 제품을 데이터베이스에 저장</param>
        public void send_order(TextBox text)
        {
            string sql = $" insert into #### valuse ('{btn_state}','{Int32.Parse(text.Text.ToString())})";
            mysql.sendsql(sql);
        }

        /// <summary>
        /// 불량 내역 데이터그리드 출력
        /// </summary>
        /// <param name="dgv">불량 내역 데이터그리드 출력</param>
        public void fillDataGrid(DataGridView dgv)
        {
            string sql = "SELECT #### FROM ####";
            mysql.fillDataGrid(sql, dgv);
        }
    }
}
