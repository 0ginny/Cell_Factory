using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_base
{
    internal class MqttObject
    {
        public bool mag_start { get; set; } = false;
        public bool X0 { get; set; } = false;
        public bool X1 { get; set; } = false;
        public bool X2 { get; set; } = false;
        public bool X3 { get; set; } = false;
        public bool X4 { get; set; } = false;
        public bool X5 { get; set; } = false;
        public bool X6 { get; set; } = false;
        public bool X7 { get; set; } = false;
        public bool X8 { get; set; } = false;
        public bool X9 { get; set; } = false;
        public bool XA { get; set; } = false;
        public bool XB { get; set; } = false;
        public bool XC { get; set; } = false;
        public bool XD { get; set; } = false;
        public bool XE { get; set; } = false;
        public bool XF { get; set; } = false;
        public bool X10 { get; set; } = false;
        public bool X11 { get; set; } = false;
        public bool X12 { get; set; } = false;
        public bool X13 { get; set; } = false;
        public bool X14 { get; set; } = false;
        public bool X15 { get; set; } = false;
        public bool Y20 { get; set; } = false;
        public bool Y21 { get; set; } = false;
        public bool Y22 { get; set; } = false;
        public bool Y23 { get; set; } = false;
        public bool Y24 { get; set; } = false;
        public bool Y25 { get; set; } = false;
        public bool Y26 { get; set; } = false;
        public bool Y27 { get; set; } = false;
        public bool Y28 { get; set; } = false;
        public bool Y29 { get; set; } = false;
        public bool Y2A { get; set; } = false;
        public bool Y2B { get; set; } = false;
        public bool Y2C { get; set; } = false;
        public bool Y2D { get; set; } = false;
        public bool Y2E { get; set; } = false;
        public bool Y2F { get; set; } = false;
        public bool Y30 { get; set; } = false;
        public bool Y31 { get; set; } = false;
        public bool Y32 { get; set; } = false;
        public bool Y33 { get; set; } = false;
        public bool Y34 { get; set; } = false;
        public bool Y35 { get; set; } = false;
        public bool M60 { get; set; } = false;
        public bool M61 { get; set; } = false;
        public bool M62 { get; set; } = false;
        public bool M63 { get; set; } = false;
        public bool M64 { get; set; } = false;
        public bool M65 { get; set; } = false;
        public bool M66 { get; set; } = false;
        public bool M67 { get; set; } = false;
        public bool M68 { get; set; } = false;
        public bool M69 { get; set; } = false;

        // Integer variables
        public int D5 { get; set; } = 0;
        public int D10 { get; set; } = 0;
        public int floar { get; set; } = 0;

        // String variables
        public string ord_id { get; set; } = string.Empty;
        public string company { get; set; } = string.Empty;
        public string prod_id { get; set; } = string.Empty;
        public string prod_name { get; set; } = string.Empty;

        // More integer variables
        public int ord_num { get; set; } = 0;
        public int prod_volt_max { get; set; } = 0;
        public int prod_volt_min { get; set; } = 0;
        public int prod_contain { get; set; } = 0;
        public int prod_surface { get; set; } = 0;
        public int total { get; set; } = 0;
        public int plan { get; set; } = 0;
        public int cell_id { get; set; } = 0;
        public int stacking_id { get; set; } = 0;
    }
}
