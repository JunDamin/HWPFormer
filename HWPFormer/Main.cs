using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using HWPHelper;
using System.Collections.Generic;

namespace HWPFormer
{
    public partial class Main : Form
    {
        private const string FilePathChecker = "FilePathChecker";
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        bool isAutoSave = false;
        private HwpWrapper hwp;

        public Main()
        {
            InitializeComponent();
            hwp = new HwpWrapper(axHwpCtrl1);
            /// register 등록이 내부망에서 안됨
            /// SetRegister();
            setupToolBar();
            SetupPage();
            InitialDesign();
            Thread thread = new Thread(() => AskPermission());
            thread.Start();
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
            Thread.Sleep(4000);
            MessageBox.Show("잠시후 나타날 HwpCtrl 접근 허가요청에서 \"모두 허용(A)\"을 눌러주세요.", "확인", MessageBoxButtons.OK);
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
            if (hwp.filePath != string.Empty) hwp.AskSave();
            hwp.filePath = string.Empty;

            var path = "templates\\page.hwp";
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
                hwp.filePath = openFileDialog.FileName;
                hwp.OpenFile(hwp.filePath);
            }
        }

        private bool SaveHWP()
        {
            if (hwp.filePath == string.Empty)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "hwp files (*.hwp)|*.hwp";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    hwp.filePath = saveFileDialog.FileName;
                    hwp.SaveAsFile(hwp.filePath);
                }
                else return false;
            }
            else
            {
                hwp.SaveAsFile(hwp.filePath);
            }
            return true;
        }



        private void TimerEvent(object sender, EventArgs e)
        {
            hwp.SaveFile();
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
                hwp.CheckSavePath();
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

        private void InitialDesign()
        {
            filePanel.Visible = false;
            contentsPanel.Visible = false;
            formatFlowLayoutPanel.Visible = false;
            var templates = new[] { 
                ("title", "제목"), 
                ("subtitle", "부제목"),
                ("subsubtitle", "부부제목"), 
                ("subsubsubtitle", "부부부제목"),  
                ("summary", "성과요약"),
                ("strategy", "전략체계1"), 
                ("cascading", "전략체계2"), 
                ("h_table", "가로표1"),
                ("h_table2", "가로표2"),
                ("h_table3", "가로표3"),
                ("h_table_2level", "가로표4"),
                ("v_table", "세로표1"),
                ("v_table2", "세로표2"), 
                ("v_table3", "세로표3")
            };
            foreach ( (string name, string text) in templates)
                {

                Button btn = CreateSubBtn(name, text);
                btn.Click += new EventHandler(FormatBtn_Click);
                formatFlowLayoutPanel.Controls.Add(btn);
                }
            switchFormPanel(false);
        }

        private Button CreateSubBtn(string name, string text)
        {
            Button btn = new Button();
            btn.AutoSize = true;
            btn.Dock = System.Windows.Forms.DockStyle.Top;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            btn.ForeColor = System.Drawing.Color.LightGray;
            btn.Location = new System.Drawing.Point(0, 520);
            btn.Name = name;
            btn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            btn.Size = new System.Drawing.Size(300, 40);
            btn.Text = text;
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn.UseVisualStyleBackColor = false;
            return btn;
        }

        void FormatBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            var path = $"templates\\{btn.Name}.hwp";
            InsertFile(path);
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
            ShowSubMenu(formatFlowLayoutPanel);
            switchFormPanel(false);
        }

        private void contents_Click(object sender, EventArgs e)
        {
            ShowSubMenu(contentsPanel);
            switchFormPanel(false);
        }

        private void newFile_Click(object sender, EventArgs e)
        {
            NewHWP();
        }

        private Form activeForm = null;
        private void OpenChildForm(Form1 childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            MainContainer.Panel1.Controls.Add(childForm);
            //childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void switchFormPanel(bool onoff)
        {
            MainContainer.SplitterDistance = onoff ? 500 : 0 ;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            switchFormPanel(true);
            if (activeForm == null)
                OpenChildForm(new Form1(hwp));
            else if (activeForm.GetType() != typeof(Form1))
                OpenChildForm(new Form1(hwp));
        }

        private void open_Click(object sender, EventArgs e)
        {
            OpenHWP();
        }
    }
}