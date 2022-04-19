using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using HWPHelper;
using System.Collections.Generic;

namespace HWPFormer
{
    public partial class MainForm : Form
    {
        private const string FilePathChecker = "FilePathChecker";
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private HwpWrapper hwp;
        bool isAutoSave = false;
        

        public MainForm()
        {
            InitializeComponent();
            hwp = new HwpWrapper(axHwpCtrl1);
            /// register 등록이 내부망에서 안됨
            /// SetRegister();
            hwp.setupToolBar();
            hwp.SetupPage();
            InitialDesign();
            Thread thread = new Thread(() => hwp.AskPermission());
            thread.Start();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            /// Ask when the program closing. 
            /// 
            base.OnFormClosing(e);
            var ans = hwp.PreClosingConfirmation();
            if (ans == System.Windows.Forms.DialogResult.Yes)
            {
                if (hwp.SaveHWP())
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
            hwp.SaveHWP();
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
            hwp.InsertFile(path);
            hwp.Select();
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
            hwp.NewHWP();
            hwp.Select();
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
            hwp.OpenHWP();
        }
    }
}