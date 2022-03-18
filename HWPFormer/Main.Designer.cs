namespace HWPFormer
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ControlMenu = new System.Windows.Forms.Panel();
            this.contentsPanel = new System.Windows.Forms.Panel();
            this.Form1 = new System.Windows.Forms.Button();
            this.contents = new System.Windows.Forms.Button();
            this.formatPanel = new System.Windows.Forms.Panel();
            this.v_table3 = new System.Windows.Forms.Button();
            this.v_table2 = new System.Windows.Forms.Button();
            this.v_table = new System.Windows.Forms.Button();
            this.h_table_2level = new System.Windows.Forms.Button();
            this.h_table3 = new System.Windows.Forms.Button();
            this.h_table2 = new System.Windows.Forms.Button();
            this.h_table = new System.Windows.Forms.Button();
            this.cascading = new System.Windows.Forms.Button();
            this.strategy = new System.Windows.Forms.Button();
            this.summary = new System.Windows.Forms.Button();
            this.subsubsubtitle = new System.Windows.Forms.Button();
            this.subsubtitle = new System.Windows.Forms.Button();
            this.subtitle = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Button();
            this.formats = new System.Windows.Forms.Button();
            this.filePanel = new System.Windows.Forms.Panel();
            this.autoSave = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.newFile = new System.Windows.Forms.Button();
            this.files = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.LogoName = new System.Windows.Forms.TextBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.HwpPanel = new System.Windows.Forms.Panel();
            this.axHwpCtrl1 = new AxHWPCONTROLLib.AxHwpCtrl();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.ControlMenu.SuspendLayout();
            this.contentsPanel.SuspendLayout();
            this.formatPanel.SuspendLayout();
            this.filePanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.HwpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axHwpCtrl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlMenu
            // 
            this.ControlMenu.AutoScroll = true;
            this.ControlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ControlMenu.Controls.Add(this.contentsPanel);
            this.ControlMenu.Controls.Add(this.contents);
            this.ControlMenu.Controls.Add(this.formatPanel);
            this.ControlMenu.Controls.Add(this.formats);
            this.ControlMenu.Controls.Add(this.filePanel);
            this.ControlMenu.Controls.Add(this.files);
            this.ControlMenu.Controls.Add(this.logoPanel);
            this.ControlMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.ControlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.ControlMenu.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ControlMenu.ForeColor = System.Drawing.Color.DarkGray;
            this.ControlMenu.Location = new System.Drawing.Point(0, 0);
            this.ControlMenu.Name = "ControlMenu";
            this.ControlMenu.Size = new System.Drawing.Size(300, 1240);
            this.ControlMenu.TabIndex = 1;
            // 
            // contentsPanel
            // 
            this.contentsPanel.AutoScroll = true;
            this.contentsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.contentsPanel.Controls.Add(this.Form1);
            this.contentsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.contentsPanel.Location = new System.Drawing.Point(0, 955);
            this.contentsPanel.Name = "contentsPanel";
            this.contentsPanel.Size = new System.Drawing.Size(300, 108);
            this.contentsPanel.TabIndex = 10;
            // 
            // Form1
            // 
            this.Form1.AutoSize = true;
            this.Form1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Form1.FlatAppearance.BorderSize = 0;
            this.Form1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Form1.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Form1.ForeColor = System.Drawing.Color.LightGray;
            this.Form1.Location = new System.Drawing.Point(0, 0);
            this.Form1.Name = "Form1";
            this.Form1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Form1.Size = new System.Drawing.Size(300, 40);
            this.Form1.TabIndex = 4;
            this.Form1.Text = "폼1";
            this.Form1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Form1.UseVisualStyleBackColor = false;
            this.Form1.Click += new System.EventHandler(this.Form1_Click);
            // 
            // contents
            // 
            this.contents.AutoSize = true;
            this.contents.Dock = System.Windows.Forms.DockStyle.Top;
            this.contents.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.contents.FlatAppearance.BorderSize = 0;
            this.contents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(51)))));
            this.contents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contents.ForeColor = System.Drawing.Color.LightGray;
            this.contents.Location = new System.Drawing.Point(0, 910);
            this.contents.Name = "contents";
            this.contents.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.contents.Size = new System.Drawing.Size(300, 45);
            this.contents.TabIndex = 9;
            this.contents.Text = "구성예제";
            this.contents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contents.UseVisualStyleBackColor = false;
            this.contents.Click += new System.EventHandler(this.contents_Click);
            // 
            // formatPanel
            // 
            this.formatPanel.AutoSize = true;
            this.formatPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.formatPanel.Controls.Add(this.v_table3);
            this.formatPanel.Controls.Add(this.v_table2);
            this.formatPanel.Controls.Add(this.v_table);
            this.formatPanel.Controls.Add(this.h_table_2level);
            this.formatPanel.Controls.Add(this.h_table3);
            this.formatPanel.Controls.Add(this.h_table2);
            this.formatPanel.Controls.Add(this.h_table);
            this.formatPanel.Controls.Add(this.cascading);
            this.formatPanel.Controls.Add(this.strategy);
            this.formatPanel.Controls.Add(this.summary);
            this.formatPanel.Controls.Add(this.subsubsubtitle);
            this.formatPanel.Controls.Add(this.subsubtitle);
            this.formatPanel.Controls.Add(this.subtitle);
            this.formatPanel.Controls.Add(this.title);
            this.formatPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.formatPanel.Location = new System.Drawing.Point(0, 350);
            this.formatPanel.Name = "formatPanel";
            this.formatPanel.Size = new System.Drawing.Size(300, 560);
            this.formatPanel.TabIndex = 8;
            // 
            // v_table3
            // 
            this.v_table3.AutoSize = true;
            this.v_table3.Dock = System.Windows.Forms.DockStyle.Top;
            this.v_table3.FlatAppearance.BorderSize = 0;
            this.v_table3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.v_table3.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.v_table3.ForeColor = System.Drawing.Color.LightGray;
            this.v_table3.Location = new System.Drawing.Point(0, 520);
            this.v_table3.Name = "v_table3";
            this.v_table3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.v_table3.Size = new System.Drawing.Size(300, 40);
            this.v_table3.TabIndex = 16;
            this.v_table3.Text = "세로표3";
            this.v_table3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.v_table3.UseVisualStyleBackColor = false;
            this.v_table3.Click += new System.EventHandler(this.v_table3_Click);
            // 
            // v_table2
            // 
            this.v_table2.AutoSize = true;
            this.v_table2.Dock = System.Windows.Forms.DockStyle.Top;
            this.v_table2.FlatAppearance.BorderSize = 0;
            this.v_table2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.v_table2.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.v_table2.ForeColor = System.Drawing.Color.LightGray;
            this.v_table2.Location = new System.Drawing.Point(0, 480);
            this.v_table2.Name = "v_table2";
            this.v_table2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.v_table2.Size = new System.Drawing.Size(300, 40);
            this.v_table2.TabIndex = 15;
            this.v_table2.Text = "세로표2";
            this.v_table2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.v_table2.UseVisualStyleBackColor = false;
            this.v_table2.Click += new System.EventHandler(this.v_table2_Click);
            // 
            // v_table
            // 
            this.v_table.AutoSize = true;
            this.v_table.Dock = System.Windows.Forms.DockStyle.Top;
            this.v_table.FlatAppearance.BorderSize = 0;
            this.v_table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.v_table.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.v_table.ForeColor = System.Drawing.Color.LightGray;
            this.v_table.Location = new System.Drawing.Point(0, 440);
            this.v_table.Name = "v_table";
            this.v_table.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.v_table.Size = new System.Drawing.Size(300, 40);
            this.v_table.TabIndex = 14;
            this.v_table.Text = "세로표1";
            this.v_table.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.v_table.UseVisualStyleBackColor = false;
            this.v_table.Click += new System.EventHandler(this.v_table_Click);
            // 
            // h_table_2level
            // 
            this.h_table_2level.AutoSize = true;
            this.h_table_2level.Dock = System.Windows.Forms.DockStyle.Top;
            this.h_table_2level.FlatAppearance.BorderSize = 0;
            this.h_table_2level.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.h_table_2level.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.h_table_2level.ForeColor = System.Drawing.Color.LightGray;
            this.h_table_2level.Location = new System.Drawing.Point(0, 400);
            this.h_table_2level.Name = "h_table_2level";
            this.h_table_2level.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.h_table_2level.Size = new System.Drawing.Size(300, 40);
            this.h_table_2level.TabIndex = 13;
            this.h_table_2level.Text = "가로표4";
            this.h_table_2level.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.h_table_2level.UseVisualStyleBackColor = false;
            this.h_table_2level.Click += new System.EventHandler(this.h_table_2level_Click);
            // 
            // h_table3
            // 
            this.h_table3.AutoSize = true;
            this.h_table3.Dock = System.Windows.Forms.DockStyle.Top;
            this.h_table3.FlatAppearance.BorderSize = 0;
            this.h_table3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.h_table3.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.h_table3.ForeColor = System.Drawing.Color.LightGray;
            this.h_table3.Location = new System.Drawing.Point(0, 360);
            this.h_table3.Name = "h_table3";
            this.h_table3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.h_table3.Size = new System.Drawing.Size(300, 40);
            this.h_table3.TabIndex = 12;
            this.h_table3.Text = "가로표3";
            this.h_table3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.h_table3.UseVisualStyleBackColor = false;
            this.h_table3.Click += new System.EventHandler(this.h_table3_Click);
            // 
            // h_table2
            // 
            this.h_table2.AutoSize = true;
            this.h_table2.Dock = System.Windows.Forms.DockStyle.Top;
            this.h_table2.FlatAppearance.BorderSize = 0;
            this.h_table2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.h_table2.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.h_table2.ForeColor = System.Drawing.Color.LightGray;
            this.h_table2.Location = new System.Drawing.Point(0, 320);
            this.h_table2.Name = "h_table2";
            this.h_table2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.h_table2.Size = new System.Drawing.Size(300, 40);
            this.h_table2.TabIndex = 11;
            this.h_table2.Text = "가로표2";
            this.h_table2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.h_table2.UseVisualStyleBackColor = false;
            this.h_table2.Click += new System.EventHandler(this.h_table2_Click);
            // 
            // h_table
            // 
            this.h_table.AutoSize = true;
            this.h_table.Dock = System.Windows.Forms.DockStyle.Top;
            this.h_table.FlatAppearance.BorderSize = 0;
            this.h_table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.h_table.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.h_table.ForeColor = System.Drawing.Color.LightGray;
            this.h_table.Location = new System.Drawing.Point(0, 280);
            this.h_table.Name = "h_table";
            this.h_table.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.h_table.Size = new System.Drawing.Size(300, 40);
            this.h_table.TabIndex = 10;
            this.h_table.Text = "가로표1";
            this.h_table.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.h_table.UseVisualStyleBackColor = false;
            this.h_table.Click += new System.EventHandler(this.h_table_Click);
            // 
            // cascading
            // 
            this.cascading.AutoSize = true;
            this.cascading.Dock = System.Windows.Forms.DockStyle.Top;
            this.cascading.FlatAppearance.BorderSize = 0;
            this.cascading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cascading.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cascading.ForeColor = System.Drawing.Color.LightGray;
            this.cascading.Location = new System.Drawing.Point(0, 240);
            this.cascading.Name = "cascading";
            this.cascading.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.cascading.Size = new System.Drawing.Size(300, 40);
            this.cascading.TabIndex = 9;
            this.cascading.Text = "전략체계도2";
            this.cascading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cascading.UseVisualStyleBackColor = false;
            this.cascading.Click += new System.EventHandler(this.cascading_Click);
            // 
            // strategy
            // 
            this.strategy.AutoSize = true;
            this.strategy.Dock = System.Windows.Forms.DockStyle.Top;
            this.strategy.FlatAppearance.BorderSize = 0;
            this.strategy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.strategy.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.strategy.ForeColor = System.Drawing.Color.LightGray;
            this.strategy.Location = new System.Drawing.Point(0, 200);
            this.strategy.Name = "strategy";
            this.strategy.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.strategy.Size = new System.Drawing.Size(300, 40);
            this.strategy.TabIndex = 8;
            this.strategy.Text = "전략체계도";
            this.strategy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.strategy.UseVisualStyleBackColor = false;
            this.strategy.Click += new System.EventHandler(this.strategy_Click);
            // 
            // summary
            // 
            this.summary.AutoSize = true;
            this.summary.Dock = System.Windows.Forms.DockStyle.Top;
            this.summary.FlatAppearance.BorderSize = 0;
            this.summary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.summary.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.summary.ForeColor = System.Drawing.Color.LightGray;
            this.summary.Location = new System.Drawing.Point(0, 160);
            this.summary.Name = "summary";
            this.summary.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.summary.Size = new System.Drawing.Size(300, 40);
            this.summary.TabIndex = 7;
            this.summary.Text = "핵심성과";
            this.summary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.summary.UseVisualStyleBackColor = false;
            this.summary.Click += new System.EventHandler(this.summary_Click);
            // 
            // subsubsubtitle
            // 
            this.subsubsubtitle.AutoSize = true;
            this.subsubsubtitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.subsubsubtitle.FlatAppearance.BorderSize = 0;
            this.subsubsubtitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subsubsubtitle.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.subsubsubtitle.ForeColor = System.Drawing.Color.LightGray;
            this.subsubsubtitle.Location = new System.Drawing.Point(0, 120);
            this.subsubsubtitle.Name = "subsubsubtitle";
            this.subsubsubtitle.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.subsubsubtitle.Size = new System.Drawing.Size(300, 40);
            this.subsubsubtitle.TabIndex = 6;
            this.subsubsubtitle.Text = "부부부제목";
            this.subsubsubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subsubsubtitle.UseVisualStyleBackColor = false;
            this.subsubsubtitle.Click += new System.EventHandler(this.subsubsubtitle_Click);
            // 
            // subsubtitle
            // 
            this.subsubtitle.AutoSize = true;
            this.subsubtitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.subsubtitle.FlatAppearance.BorderSize = 0;
            this.subsubtitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subsubtitle.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.subsubtitle.ForeColor = System.Drawing.Color.LightGray;
            this.subsubtitle.Location = new System.Drawing.Point(0, 80);
            this.subsubtitle.Name = "subsubtitle";
            this.subsubtitle.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.subsubtitle.Size = new System.Drawing.Size(300, 40);
            this.subsubtitle.TabIndex = 5;
            this.subsubtitle.Text = "부부제목";
            this.subsubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subsubtitle.UseVisualStyleBackColor = false;
            this.subsubtitle.Click += new System.EventHandler(this.subsubtitle_Click);
            // 
            // subtitle
            // 
            this.subtitle.AutoSize = true;
            this.subtitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.subtitle.FlatAppearance.BorderSize = 0;
            this.subtitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtitle.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.subtitle.ForeColor = System.Drawing.Color.LightGray;
            this.subtitle.Location = new System.Drawing.Point(0, 40);
            this.subtitle.Name = "subtitle";
            this.subtitle.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.subtitle.Size = new System.Drawing.Size(300, 40);
            this.subtitle.TabIndex = 4;
            this.subtitle.Text = "부제목";
            this.subtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subtitle.UseVisualStyleBackColor = false;
            this.subtitle.Click += new System.EventHandler(this.subtitle_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.FlatAppearance.BorderSize = 0;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title.ForeColor = System.Drawing.Color.LightGray;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.title.Size = new System.Drawing.Size(300, 40);
            this.title.TabIndex = 3;
            this.title.Text = "제목";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.title.UseVisualStyleBackColor = false;
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // formats
            // 
            this.formats.AutoSize = true;
            this.formats.Dock = System.Windows.Forms.DockStyle.Top;
            this.formats.FlatAppearance.BorderSize = 0;
            this.formats.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(51)))));
            this.formats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.formats.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.formats.ForeColor = System.Drawing.Color.LightGray;
            this.formats.Location = new System.Drawing.Point(0, 305);
            this.formats.Name = "formats";
            this.formats.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.formats.Size = new System.Drawing.Size(300, 45);
            this.formats.TabIndex = 6;
            this.formats.Text = "경영평가 양식 패키지";
            this.formats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.formats.UseVisualStyleBackColor = false;
            this.formats.Click += new System.EventHandler(this.formats_Click);
            // 
            // filePanel
            // 
            this.filePanel.AutoSize = true;
            this.filePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.filePanel.Controls.Add(this.autoSave);
            this.filePanel.Controls.Add(this.open);
            this.filePanel.Controls.Add(this.save);
            this.filePanel.Controls.Add(this.newFile);
            this.filePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filePanel.Location = new System.Drawing.Point(0, 145);
            this.filePanel.Name = "filePanel";
            this.filePanel.Size = new System.Drawing.Size(300, 160);
            this.filePanel.TabIndex = 5;
            // 
            // autoSave
            // 
            this.autoSave.AutoSize = true;
            this.autoSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.autoSave.FlatAppearance.BorderSize = 0;
            this.autoSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autoSave.ForeColor = System.Drawing.Color.LightGray;
            this.autoSave.Location = new System.Drawing.Point(0, 120);
            this.autoSave.Name = "autoSave";
            this.autoSave.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.autoSave.Size = new System.Drawing.Size(300, 40);
            this.autoSave.TabIndex = 5;
            this.autoSave.Text = "자동저장 켜기";
            this.autoSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.autoSave.UseVisualStyleBackColor = false;
            this.autoSave.Click += new System.EventHandler(this.AutoSave_Click);
            // 
            // open
            // 
            this.open.AutoSize = true;
            this.open.Dock = System.Windows.Forms.DockStyle.Top;
            this.open.FlatAppearance.BorderSize = 0;
            this.open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open.ForeColor = System.Drawing.Color.LightGray;
            this.open.Location = new System.Drawing.Point(0, 80);
            this.open.Name = "open";
            this.open.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.open.Size = new System.Drawing.Size(300, 40);
            this.open.TabIndex = 3;
            this.open.Text = "불러오기";
            this.open.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.open.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.AutoSize = true;
            this.save.Dock = System.Windows.Forms.DockStyle.Top;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.ForeColor = System.Drawing.Color.LightGray;
            this.save.Location = new System.Drawing.Point(0, 40);
            this.save.Name = "save";
            this.save.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.save.Size = new System.Drawing.Size(300, 40);
            this.save.TabIndex = 2;
            this.save.Text = "저장하기";
            this.save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // newFile
            // 
            this.newFile.AutoSize = true;
            this.newFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.newFile.FlatAppearance.BorderSize = 0;
            this.newFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newFile.ForeColor = System.Drawing.Color.LightGray;
            this.newFile.Location = new System.Drawing.Point(0, 0);
            this.newFile.Name = "newFile";
            this.newFile.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.newFile.Size = new System.Drawing.Size(300, 40);
            this.newFile.TabIndex = 6;
            this.newFile.Text = "새로 만들기";
            this.newFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newFile.UseVisualStyleBackColor = true;
            this.newFile.Click += new System.EventHandler(this.newFile_Click);
            // 
            // files
            // 
            this.files.AutoSize = true;
            this.files.Dock = System.Windows.Forms.DockStyle.Top;
            this.files.FlatAppearance.BorderSize = 0;
            this.files.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(51)))));
            this.files.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.files.ForeColor = System.Drawing.Color.LightGray;
            this.files.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.files.Location = new System.Drawing.Point(0, 100);
            this.files.Name = "files";
            this.files.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.files.Size = new System.Drawing.Size(300, 45);
            this.files.TabIndex = 0;
            this.files.Text = "파일관리";
            this.files.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.files.UseVisualStyleBackColor = false;
            this.files.Click += new System.EventHandler(this.files_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.Controls.Add(this.LogoName);
            this.logoPanel.Controls.Add(this.Logo);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(300, 100);
            this.logoPanel.TabIndex = 11;
            // 
            // LogoName
            // 
            this.LogoName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LogoName.BackColor = System.Drawing.SystemColors.WindowText;
            this.LogoName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogoName.Font = new System.Drawing.Font("나눔스퀘어 Bold", 13.875F);
            this.LogoName.ForeColor = System.Drawing.SystemColors.Info;
            this.LogoName.Location = new System.Drawing.Point(100, 26);
            this.LogoName.Name = "LogoName";
            this.LogoName.ReadOnly = true;
            this.LogoName.Size = new System.Drawing.Size(200, 42);
            this.LogoName.TabIndex = 1;
            this.LogoName.Text = "Hwp Helper";
            // 
            // Logo
            // 
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.Logo.Image = global::HWPHelper.Properties.Resources.ai;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Padding = new System.Windows.Forms.Padding(5);
            this.Logo.Size = new System.Drawing.Size(100, 100);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.Controls.Add(this.HwpPanel);
            this.MainPanel.Controls.Add(this.childFormPanel);
            this.MainPanel.Location = new System.Drawing.Point(300, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1650, 1240);
            this.MainPanel.TabIndex = 4;
            // 
            // HwpPanel
            // 
            this.HwpPanel.Controls.Add(this.axHwpCtrl1);
            this.HwpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HwpPanel.Location = new System.Drawing.Point(0, 0);
            this.HwpPanel.Name = "HwpPanel";
            this.HwpPanel.Size = new System.Drawing.Size(1650, 1240);
            this.HwpPanel.TabIndex = 2;
            // 
            // axHwpCtrl1
            // 
            this.axHwpCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axHwpCtrl1.Enabled = true;
            this.axHwpCtrl1.Location = new System.Drawing.Point(0, 0);
            this.axHwpCtrl1.Name = "axHwpCtrl1";
            this.axHwpCtrl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axHwpCtrl1.OcxState")));
            this.axHwpCtrl1.Size = new System.Drawing.Size(1650, 1240);
            this.axHwpCtrl1.TabIndex = 0;
            this.axHwpCtrl1.NotifyMessage += new AxHWPCONTROLLib._DHwpCtrlEvents_NotifyMessageEventHandler(this.axHwpCtrl1_NotifyMessage);
            // 
            // childFormPanel
            // 
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(0, 0);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(1650, 1240);
            this.childFormPanel.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1950, 1240);
            this.Controls.Add(this.ControlMenu);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "한글 자동화";
            this.ControlMenu.ResumeLayout(false);
            this.ControlMenu.PerformLayout();
            this.contentsPanel.ResumeLayout(false);
            this.contentsPanel.PerformLayout();
            this.formatPanel.ResumeLayout(false);
            this.formatPanel.PerformLayout();
            this.filePanel.ResumeLayout(false);
            this.filePanel.PerformLayout();
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.HwpPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axHwpCtrl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ControlMenu;
        private System.Windows.Forms.Button files;
        private System.Windows.Forms.Panel HwpPanel;
        private AxHWPCONTROLLib.AxHwpCtrl axHwpCtrl1;
        private System.Windows.Forms.Panel contentsPanel;
        private System.Windows.Forms.Button contents;
        private System.Windows.Forms.Panel formatPanel;
        private System.Windows.Forms.Button formats;
        private System.Windows.Forms.Panel filePanel;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button title;
        private System.Windows.Forms.Button autoSave;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Button cascading;
        private System.Windows.Forms.Button strategy;
        private System.Windows.Forms.Button summary;
        private System.Windows.Forms.Button subsubsubtitle;
        private System.Windows.Forms.Button subsubtitle;
        private System.Windows.Forms.Button subtitle;
        private System.Windows.Forms.Button v_table3;
        private System.Windows.Forms.Button v_table2;
        private System.Windows.Forms.Button v_table;
        private System.Windows.Forms.Button h_table_2level;
        private System.Windows.Forms.Button h_table3;
        private System.Windows.Forms.Button h_table2;
        private System.Windows.Forms.Button h_table;
        private System.Windows.Forms.Button newFile;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.TextBox LogoName;
        private System.Windows.Forms.Button Form1;
        private System.Windows.Forms.Panel childFormPanel;
        private System.Windows.Forms.Panel MainPanel;
    }
}

