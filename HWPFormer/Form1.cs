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
using HWPHelper;

namespace HWPFormer
{
    public partial class Form1 : Form
    {
        private HwpWrapper hwp;
        private bool isNew;
        public Form1(HwpWrapper hwpctrl)
        {

            hwp = hwpctrl;
            isNew = true;
            InitializeComponent();
        }

        private void formBtn_Click(object sender, EventArgs e)
        {
            // MainForm.AskSave();
            var path = "forms\\form1.hwp";
            hwp.OpenFile(Path.GetFullPath(path));
            hwp.PutFieldText("name", name.Text);
            hwp.PutFieldText("value", value.Text);
        }
    }
}
