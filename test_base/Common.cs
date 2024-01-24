using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace MES
{
    public class Common
    {
        //public static DBMySql _db = new DBMySql();
        public Dictionary<string, bool> menuExpandDictionary = new Dictionary<string, bool>();
        public Dictionary<string, int> DICT_REMOVE_INDEX = new Dictionary<string, int>();
        public string menuProdcutionExpand = "menuProdcutionExpand";
        public string menuFacilityExpand = "menuFacilityExpand";
        public string menuMaterialExpand = "menuMaterialExpand";
        public string menuQualityExpand = "menuQualityExpand";
        public string menuMasterExpand = "menuMasterExpand";
        public string defaultTab = "새 탭";
        public Dictionary<string, string> userInformation = new Dictionary<string, string>();

        public Common()
        {
            menuExpandDictionary.Add(menuProdcutionExpand, false);
            menuExpandDictionary.Add(menuFacilityExpand, false);
            menuExpandDictionary.Add(menuMaterialExpand, false);
            menuExpandDictionary.Add(menuQualityExpand, false);
            menuExpandDictionary.Add(menuMasterExpand, false);

            ////임시 데이터 삽입 
            //userInformation.Add("name", "김학식");
            //userInformation.Add("department", "설비");
            //userInformation.Add("usesr_id", "admin");
            //userInformation.Add("authority", "3");
            //userInformation.Add("position", "과장");
        }
        /*
        public void SetUserInformation(string id)
        {
            string sql = $"SELECT users_id, name, department, position, authority FROM users WHERE users_id = '{id}'";
            DataTable dt = _db.SelectSql(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    string colName = dt.Columns[j].ColumnName;
                    string colValue = dt.Rows[i][j].ToString();
                    userInformation.Add(colName, colValue);
                    Console.WriteLine(colName);
                    Console.WriteLine(colValue);
                }
            }

        }
        */

        public void SetWindowState(Form form)
        {
            if (form.WindowState == FormWindowState.Normal)
            {
                form.WindowState = FormWindowState.Maximized;
            }
            else
            {
                form.WindowState = FormWindowState.Normal;
            }
        }

        /*public void ToggleMenuContainer(ref System.Windows.Forms.FlowLayoutPanel menuContainer, ref Timer transitionTimer, string menuItemKey, int expandHeight, int collapseHeight)
        {
            if (!menuExpandDictionary[menuItemKey])
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= expandHeight)
                {
                    transitionTimer.Stop();
                    menuExpandDictionary[menuItemKey] = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= collapseHeight)
                {
                    transitionTimer.Stop();
                    menuExpandDictionary[menuItemKey] = false;
                }
            }
        }

        */
        public void IntializeDateTimePicker(ref DateTimePicker firstTime, ref DateTimePicker lastTime) //데이트타임픽커 기본값 설정
        {
            firstTime.CustomFormat = "yyyy-MM-dd";
            firstTime.Format = DateTimePickerFormat.Custom;
            lastTime.CustomFormat = "yyyy-MM-dd";
            lastTime.Format = DateTimePickerFormat.Custom;


            // endDate를 현재 날짜로 설정
            DateTime endDate = DateTime.Now;

            // startDate를 endDate에서 7일 전으로 설정
            DateTime startDate = endDate.AddDays(-7);

            //기본값 설정
            firstTime.Value = startDate;
            lastTime.Value = endDate;
        }

        public bool authorityCheck()
        {
            if (userInformation["authority"] == "1")
            {

                return true;
            }
            return false;
        }

        /*
        public void setProductData(string scheduleId)
        {

            string sql = $"SELECT production_schedule_id, quantity, product_type_id,  DATE_FORMAT( write_date, '%Y-%m-%d') as write_date  FROM production_schedule WHERE production_schedule_id = '{scheduleId}'";
            DataTable dt = _db.SelectSql(sql);
            string sql2 = $"insert product (product_lot, production_date, production_schedule_id, storage) values ";

            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("INSERT INTO product (product_lot, production_date, production_schedule_id, storage) VALUES ");

            for (int j = 1; j < Int32.Parse(dt.Rows[0][1].ToString())+1; j++)
            {
                string quantity = dt.Rows[0][1].ToString();
                string lot = dt.Rows[0][2].ToString()+ "-"+scheduleId + "-" + j.ToString("D5");
                string date = dt.Rows[0][3].ToString();
                string storage = "창고B";

                sqlBuilder.Append($"('{lot}', '{date}', '{scheduleId}', '{storage}')");

                // 마지막 반복이 아닌 경우 쉼표와 공백 추가
                if (j < Int32.Parse(dt.Rows[0][1].ToString()))
                {
                    sqlBuilder.Append(", ");
                }

            }
            string finalQuery = sqlBuilder.ToString();
            Console.WriteLine(finalQuery);
            _db.Sql(finalQuery);

        }
        */

        public void ChangeButtonStyles(Control container, Color backColor, Color foreColor, FlatStyle style)
        {
            foreach (Control control in container.Controls)
            {
                if (control is Button)
                {
                    Console.WriteLine("called");
                    Button button = (Button)control;
                    button.BackColor = backColor;
                    button.ForeColor = foreColor;
                    button.FlatStyle = style;
                }

                // If you have containers (e.g., panels) holding buttons, you might want to recurse through them
                if (control.HasChildren)
                {
                    ChangeButtonStyles(control, backColor, foreColor, style);
                }
            }
        }

    }
}
