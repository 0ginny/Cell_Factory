using MES_Project;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace test_base.Properties
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
            hopeDatePicker1.Visible = false;
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hopeDatePicker1.Size = new System.Drawing.Size(250, 270);
            hopeDatePicker1.Visible = true;
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Product_Load(object sender, EventArgs e)
        {

        }

        private void hopeDatePicker1_Click(object sender, EventArgs e)
        {
            hopeDatePicker1.Visible = false;
        }
    }
}
