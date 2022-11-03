using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using HWPHelper;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
            formatFlowLayoutPanel.Visible = true;

            /* read json to form format*/
            JObject jObject = JObject.Parse(File.ReadAllText("menu.json"));

            Console.WriteLine(jObject.ToString());

            foreach (JToken menu in jObject["menus"])
            {
                CreateMenu(menu);
            }
            switchFormPanel(false);
        }

        private void CreateMenu(JToken menu)
        {
            JToken btns = menu["btns"];
            string name = menu["name"].ToString();
            FlowLayoutPanel panel = CreatePanel(name);
            foreach (JToken btn in btns)
            {

                Button button = CreateSubBtn(btn["name"].ToString(), btn["text"].ToString());
                button.Click += new EventHandler(FormatBtn_Click);
                panel.Controls.Add(button);
            }


            Button panelbtn = CreateBtn(name);
            panelbtn.Click += new System.EventHandler((object sender, EventArgs e) => { ShowSubMenu(panel);});
            formatFlowLayoutPanel.Controls.Add(panelbtn);
            formatFlowLayoutPanel.Controls.Add(panel);
        }

        private FlowLayoutPanel CreatePanel(string name)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Name = name;

            panel.AutoSize = true;
            panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            panel.Dock = System.Windows.Forms.DockStyle.Top;
            panel.Location = new System.Drawing.Point(0, 350);
            panel.MinimumSize = new System.Drawing.Size(300, 45);
            panel.Size = new System.Drawing.Size(300, 45);
            panel.TabIndex = 12;
            panel.Visible = false;

            return panel;
        }

        private Button CreateBtn(string name) {

            Button btn = new Button();
            btn.AutoSize = true;
            btn.Dock = System.Windows.Forms.DockStyle.Top;
            btn.BackColor = BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(51)))));
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            btn.ForeColor = System.Drawing.Color.LightGray;
            btn.Location = new System.Drawing.Point(0, 305);
            btn.Name = "formats";
            btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            btn.Size = new System.Drawing.Size(500, 45);
            btn.TabIndex = 6;
            btn.Text = name;
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn.UseVisualStyleBackColor = false;
            return btn;
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

            var path = $"images\\{name}.png";
            btn.Image = System.Drawing.Image.FromFile(path);
            return btn;
        }

        void FormatBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            var path = $"templates\\{btn.Name}.hwp";
            this.Cursor = new Cursor(Cursor.Current.Handle);

            Cursor.Current = Cursors.WaitCursor;
            hwp.InsertFile(path);
            Cursor.Current = Cursors.Default;
            hwp.Select();
        }

        void menuBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            ShowSubMenu(formatFlowLayoutPanel);
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