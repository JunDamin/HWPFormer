using System.Windows.Forms;
using System;
using System.IO;
using System.Timers;

namespace HWPFormer
{
    public partial class Main : Form
    {
        private const string FilePathChecker = "FilePathChecker";
        string filePath = string.Empty;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        bool isAutoSave = false;
        
        public Main()
        {
            InitializeComponent();
            /// register 등록이 내부망에서 안됨
            /// SetRegister();
            setupToolBar();
            SetupPage();
            CustomizeDesign();
            AskPermission();
        }

        public void SetRegister()
        {
            const string HNCRoot = @"HKEY_Current_User\Software\HNC\HwpCtrl\Modules";
            axHwpCtrl1.Clear();
            string myProjectPath = Path.GetFullPath(".\\");
            if (Microsoft.Win32.Registry.GetValue(HNCRoot, "FilePathCheckerModuleExample", "Not Exist").Equals("Not Exist"))
            {
                Microsoft.Win32.Registry.SetValue(HNCRoot, "FilePathCheckerModuleExample", myProjectPath + "FilePathCheckerModuleExample.dll");
            }
            axHwpCtrl1.RegisterModule("FilePathCheckDLL", "FilePathCheckerModuleExample");
        }

        private void AskPermission()
        {
            MessageBox.Show("다음 한글의 허가요청에서 모두 허용을 눌러주세요.", "확인", MessageBoxButtons.OK);
            NewHWP();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
        /// Ask when the program closing. 
        /// 
            base.OnFormClosing(e);
            var ans = PreClosingConfirmation();
            if (ans == System.Windows.Forms.DialogResult.Yes)
            {
                if (SaveHWP())
                {
                    Dispose(true);
                    Application.Exit();
                }
                else e.Cancel = true;
            }
            else if (ans == System.Windows.Forms.DialogResult.No)
            {
                Dispose(true);
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private DialogResult PreClosingConfirmation()
        {
            DialogResult res = MessageBox.Show("프로그램을 종료하면 저장하지 않은 내용은 모두 사라집니다. 내용을 저장하시겠습니까?", "저장하기", MessageBoxButtons.YesNoCancel);
            return res;
        }

        private void NewHWP()
        {
            if (filePath != string.Empty) AskSave();
            filePath = string.Empty;

            var path = "template\\page.hwp";
            OpenFile(Path.GetFullPath(path));
            if (isAutoSave)
            {
                AutoSave();

            }
        }
        private void OpenHWP()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "hwp files (*.hwp)|*.hwp|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;
                OpenFile(filePath);
            }
        }

        private bool SaveHWP()
        {
            if (filePath == string.Empty)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "hwp files (*.hwp)|*.hwp";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog.FileName;
                    SaveAsFile(filePath);
                }
                else return false;
            }
            else
            {
                SaveAsFile(filePath);
            }
            return true;
        }

        public void CheckSavePath()
        {
            if (filePath == string.Empty)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "hwp files (*.hwp)|*.hwp";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog.FileName;
                    SaveAsFile(filePath);
                }
            }

        }
        private void AskSave()
        {
            DialogResult res = MessageBox.Show("기존 내용을 모두 저장하시겠습니까?", "저장하기", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                SaveAsFile(filePath);
            }
        }

        private void TimerEvent(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void AutoSave()
        {
            if (isAutoSave)
            {
                timer.Stop();
                autoSave.Text = "자동저장 켜기";
                autoSave.BackColor = filePanel.BackColor;
                autoSave.ForeColor = filePanel.ForeColor;
                isAutoSave = false;
            }
            else
            {
                CheckSavePath();
                timer.Interval = 10000;
                timer.Tick += new EventHandler(TimerEvent);
                timer.Start();
                autoSave.Text = "자동저장 끄기";
                autoSave.ForeColor = System.Drawing.Color.FromArgb(120, 147, 149);
                autoSave.BackColor = System.Drawing.Color.FromArgb(229, 227, 201);
                isAutoSave = true;
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            SaveHWP();
        }


        private void AutoSave_Click(object sender, EventArgs e)
        {
            AutoSave();
        }

        private void axHwpCtrl1_NotifyMessage(object sender, AxHWPCONTROLLib._DHwpCtrlEvents_NotifyMessageEvent e)
        {

        }

        private void CustomizeDesign()
        {
            filePanel.Visible = false;
            contentsPanel.Visible = false;
            formatPanel.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void files_Click(object sender, EventArgs e)
        {
            ShowSubMenu(filePanel);
        }

        private void formats_Click(object sender, EventArgs e)
        {
            ShowSubMenu(formatPanel);
            isHwpPanel = true;
            switchPanel();
        }

        private void contents_Click(object sender, EventArgs e)
        {
            ShowSubMenu(contentsPanel);
            isHwpPanel = false;
            switchPanel();
        }

        private void title_Click(object sender, EventArgs e)
        {
            var path = "template\\title.hwp";
            InsertFile(path);
        }

        private void subtitle_Click(object sender, EventArgs e)
        {
            var path = "template\\subtitle.hwp";
            InsertFile(path);
        }

        private void subsubtitle_Click(object sender, EventArgs e)
        {
            var path = "template\\subsubtitle.hwp";
            InsertFile(path);
        }

        private void subsubsubtitle_Click(object sender, EventArgs e)
        {
            var path = "template\\subsubsubtitle.hwp";
            InsertFile(path);
        }

        private void summary_Click(object sender, EventArgs e)
        {
            var path = "template\\summary.hwp";
            InsertFile(path);
        }

        private void strategy_Click(object sender, EventArgs e)
        {
            var path = "template\\strategy.hwp";
            InsertFile(path);
        }

        private void cascading_Click(object sender, EventArgs e)
        {
            var path = "template\\cascading.hwp";
            InsertFile(path);
        }

        private void h_table_Click(object sender, EventArgs e)
        {
            var path = "template\\h_table.hwp";
            InsertFile(path);
        }

        private void h_table2_Click(object sender, EventArgs e)
        {
            var path = "template\\h_table2.hwp";
            InsertFile(path);
        }

        private void h_table3_Click(object sender, EventArgs e)
        {
            var path = "template\\h_table3.hwp";
            InsertFile(path);
        }

        private void h_table_2level_Click(object sender, EventArgs e)
        {
            var path = "template\\h_table_2level.hwp";
            InsertFile(path);
        }

        private void v_table_Click(object sender, EventArgs e)
        {
            var path = "template\\v_table.hwp";
            InsertFile(path);
        }

        private void v_table2_Click(object sender, EventArgs e)
        {
            var path = "template\\v_table2.hwp";
            InsertFile(path);
        }

        private void v_table3_Click(object sender, EventArgs e)
        {
            var path = "template\\v_table3.hwp";
            InsertFile(path);
        }

        private void newFile_Click(object sender, EventArgs e)
        {
            NewHWP();
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(childForm);
            //childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private bool isHwpPanel = true;
        private void switchPanel()
        {
            HwpPanel.Visible = isHwpPanel;
            childFormPanel.Visible = !(isHwpPanel);
            isHwpPanel = !(isHwpPanel);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            isHwpPanel = false;
            switchPanel();
            if (activeForm == null)
                OpenChildForm(new Form1());
            else if (activeForm.GetType() != typeof(Form1))
                OpenChildForm(new Form1());
        }
    }
}