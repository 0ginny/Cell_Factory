using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_base
{
    internal class Prod_Order
    {

        mysql my;
        public string btn_state { get; set; } = null;


        public Prod_Order() {
            my = new mysql();
        }


        public void change_state(Button btn)
        {
            btn_state = btn.Text;
        }


        /// <summary>
        /// ~~~ 테이블에 주문 정보를 저장하는 함수
        /// </summary>
        /// <param name="txt">생산 수량을 저장한 텍스트 박스</param>
        public void send_order(TextBox txt)
        {
            string sql = $" insert into ~~~ valuse ('{btn_state}','{Int32.Parse(txt.Text.ToString())}) ; ";
            my.sendsql(sql);
        }










    }


}
