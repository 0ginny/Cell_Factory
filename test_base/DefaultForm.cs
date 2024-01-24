using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_base
{
    public partial class DefaultForm : Form
    {
        public DefaultForm()
        {
            InitializeComponent();
        }

        // FormSetSize 메서드 정의
        public void FormSetSize(int width, int height)
        {
            // 폼의 크기 설정 코드 작성
            this.Size = new Size(width, height);
        }
    }
}
