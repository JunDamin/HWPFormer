using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HWPFormer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void formBtn_Click_1(object sender, EventArgs e)
        {
            var path = "forms\\form1.hwp";
            axHwpCtrl1.Open(Path.GetFullPath(path));
            axHwpCtrl1.PutFieldText("name", name.Text);
            axHwpCtrl1.PutFieldText("value", value.Text);
        }
    }
}
