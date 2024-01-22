using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES_Project
{
    public partial class Calendar_shipmen_status : Form
    {
        int month, year;
        //lets create a static variable that we can pass to another form for month and year;
        public static int static_month, static_year;
        string[] monthAbbreviations = { "", "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        public Calendar_shipmen_status()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            displaDays();
        }

        /*
        private void displaDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            static_month = month;
            static_year = year;
            //LETS get the first day of the month.

            DateTime startofthemonth = new DateTime(year, month, 1);
            //get the count of days of the month.
            int days = DateTime.DaysInMonth(year, month);
            //conver the starofthemonth to integer

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //first lets create a blank usercontrol.
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //now lets create usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }*/

        private void displaDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            // Format the month as two digits
            String monthname = now.ToString("MM");
            label11.Text = monthname + " ";

            label10.Text = monthAbbreviations[month];

            static_month = month;
            static_year = year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        /*
        private void btnnext_Click(object sender, EventArgs e)
        {
            //clear container
            daycontainer.Controls.Clear();

            //incerment month to go to next month
            month++;
            static_month = month;
            static_year = year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            //get the count of days of the month.
            int days = DateTime.DaysInMonth(year, month);
            //conver the starofthemonth to integer

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //first lets create a blank usercontrol.
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //now lets create usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }*/

        private void btnnext_Click(object sender, EventArgs e)
        {
            // clear container
            daycontainer.Controls.Clear();

            // increment month to go to next month
            month++;
            if (month > 12)
            {
                month = 1;
                year++;
            }
            static_month = month;
            static_year = year;

            // Format the month as two digits
            DateTime startofthemonth = new DateTime(year, month, 1);
            String monthname = startofthemonth.ToString("MM");
            label11.Text = monthname + " ";

            label10.Text = monthAbbreviations[month];

            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        /*
        private void btnprevious_Click(object sender, EventArgs e)
        {
            //clear container
            daycontainer.Controls.Clear();

            //decrement month to go to previous month
            month--;
            static_month = month;
            static_year = year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            //get the count of days of the month.
            int days = DateTime.DaysInMonth(year, month);
            //conver the starofthemonth to integer

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //first lets create a blank usercontrol.
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //now lets create usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }*/

        private void btnprevious_Click(object sender, EventArgs e)
        {
            // clear container
            daycontainer.Controls.Clear();

            // decrement month to go to previous month
            month--;
            if (month < 1)
            {
                month = 12;
                year--;
            }
            static_month = month;
            static_year = year;

            // Format the month as two digits
            DateTime startofthemonth = new DateTime(year, month, 1);
            String monthname = startofthemonth.ToString("MM");
            label11.Text = monthname + " ";

            label10.Text = monthAbbreviations[month];

            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LBDATE_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer3_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
