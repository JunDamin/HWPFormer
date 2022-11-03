namespace HWPFormer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ControlMenu = new System.Windows.Forms.Panel();
            this.contentsPanel = new System.Windows.Forms.Panel();
            this.Form1 = new System.Windows.Forms.Button();
            this.contents = new System.Windows.Forms.Button();
            this.formatFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.filePanel = new System.Windows.Forms.Panel();
            this.autoSave = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.newFile = new System.Windows.Forms.Button();
            this.files = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.version = new System.Windows.Forms.Label();
            this.LogoName = new System.Windows.Forms.TextBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.MainContainer = new System.Windows.Forms.SplitContainer();
            this.ContentFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.axHwpCtrl1 = new AxHWPCONTROLLib.AxHwpCtrl();
            this.ControlMenu.SuspendLayout();
            this.contentsPanel.SuspendLayout();
            this.filePanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).BeginInit();
            this.MainContainer.Panel1.SuspendLayout();
            this.MainContainer.Panel2.SuspendLayout();
            this.MainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axHwpCtrl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlMenu
            // 
            this.ControlMenu.AutoScroll = true;
            this.ControlMenu.AutoScrollMargin = new System.Drawing.Size(10, 0);
            this.ControlMenu.AutoSize = true;
            this.ControlMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ControlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ControlMenu.Controls.Add(this.contentsPanel);
            this.ControlMenu.Controls.Add(this.contents);
            this.ControlMenu.Controls.Add(this.formatFlowLayoutPanel);
            this.ControlMenu.Controls.Add(this.filePanel);
            this.ControlMenu.Controls.Add(this.files);
            this.ControlMenu.Controls.Add(this.logoPanel);
            this.ControlMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.ControlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.ControlMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ControlMenu.ForeColor = System.Drawing.Color.DarkGray;
            this.ControlMenu.Location = new System.Drawing.Point(0, 0);
            this.ControlMenu.MinimumSize = new System.Drawing.Size(400, 0);
            this.ControlMenu.Name = "ControlMenu";
            this.ControlMenu.Size = new System.Drawing.Size(400, 1240);
            this.ControlMenu.TabIndex = 1;
            // 
            // contentsPanel
            // 
            this.contentsPanel.AutoScroll = true;
            this.contentsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.contentsPanel.Controls.Add(this.Form1);
            this.contentsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.contentsPanel.Location = new System.Drawing.Point(0, 395);
            this.contentsPanel.Name = "contentsPanel";
            this.contentsPanel.Size = new System.Drawing.Size(400, 108);
            this.contentsPanel.TabIndex = 10;
            // 
            // Form1
            // 
            this.Form1.AutoSize = true;
            this.Form1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Form1.FlatAppearance.BorderSize = 0;
            this.Form1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Form1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Form1.ForeColor = System.Drawing.Color.LightGray;
            this.Form1.Location = new System.Drawing.Point(0, 0);
            this.Form1.Name = "Form1";
            this.Form1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Form1.Size = new System.Drawing.Size(400, 40);
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
            this.contents.Location = new System.Drawing.Point(0, 350);
            this.contents.Name = "contents";
            this.contents.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.contents.Size = new System.Drawing.Size(400, 45);
            this.contents.TabIndex = 9;
            this.contents.Text = "구성예제";
            this.contents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contents.UseVisualStyleBackColor = false;
            this.contents.Visible = false;
            this.contents.Click += new System.EventHandler(this.contents_Click);
            // 
            // formatFlowLayoutPanel
            // 
            this.formatFlowLayoutPanel.AutoSize = true;
            this.formatFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.formatFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.formatFlowLayoutPanel.Location = new System.Drawing.Point(0, 305);
            this.formatFlowLayoutPanel.MinimumSize = new System.Drawing.Size(500, 45);
            this.formatFlowLayoutPanel.Name = "formatFlowLayoutPanel";
            this.formatFlowLayoutPanel.Size = new System.Drawing.Size(500, 45);
            this.formatFlowLayoutPanel.TabIndex = 12;
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
            this.filePanel.Size = new System.Drawing.Size(400, 160);
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
            this.autoSave.Size = new System.Drawing.Size(400, 40);
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
            this.open.Size = new System.Drawing.Size(400, 40);
            this.open.TabIndex = 3;
            this.open.Text = "불러오기";
            this.open.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
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
            this.save.Size = new System.Drawing.Size(400, 40);
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
            this.newFile.Size = new System.Drawing.Size(400, 40);
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
            this.files.Size = new System.Drawing.Size(400, 45);
            this.files.TabIndex = 0;
            this.files.Text = "파일관리";
            this.files.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.files.UseVisualStyleBackColor = false;
            this.files.Click += new System.EventHandler(this.files_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.Controls.Add(this.version);
            this.logoPanel.Controls.Add(this.LogoName);
            this.logoPanel.Controls.Add(this.Logo);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(400, 100);
            this.logoPanel.TabIndex = 11;
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(156, 68);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(81, 29);
            this.version.TabIndex = 2;
            this.version.Text = "v.0.1.0";
            // 
            // LogoName
            // 
            this.LogoName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LogoName.BackColor = System.Drawing.SystemColors.WindowText;
            this.LogoName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F);
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
            // MainContainer
            // 
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer.Location = new System.Drawing.Point(400, 0);
            this.MainContainer.Name = "MainContainer";
            // 
            // MainContainer.Panel1
            // 
            this.MainContainer.Panel1.Controls.Add(this.ContentFlowLayoutPanel);
            this.MainContainer.Panel1MinSize = 0;
            // 
            // MainContainer.Panel2
            // 
            this.MainContainer.Panel2.Controls.Add(this.axHwpCtrl1);
            this.MainContainer.Panel2MinSize = 0;
            this.MainContainer.Size = new System.Drawing.Size(1550, 1240);
            this.MainContainer.SplitterDistance = 25;
            this.MainContainer.SplitterWidth = 1;
            this.MainContainer.TabIndex = 5;
            // 
            // ContentFlowLayoutPanel
            // 
            this.ContentFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ContentFlowLayoutPanel.Name = "ContentFlowLayoutPanel";
            this.ContentFlowLayoutPanel.Size = new System.Drawing.Size(25, 1240);
            this.ContentFlowLayoutPanel.TabIndex = 0;
            // 
            // axHwpCtrl1
            // 
            this.axHwpCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axHwpCtrl1.Enabled = true;
            this.axHwpCtrl1.Location = new System.Drawing.Point(0, 0);
            this.axHwpCtrl1.Name = "axHwpCtrl1";
            this.axHwpCtrl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axHwpCtrl1.OcxState")));
            this.axHwpCtrl1.Size = new System.Drawing.Size(1524, 1240);
            this.axHwpCtrl1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1950, 1240);
            this.Controls.Add(this.MainContainer);
            this.Controls.Add(this.ControlMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "한글 자동화";
            this.ControlMenu.ResumeLayout(false);
            this.ControlMenu.PerformLayout();
            this.contentsPanel.ResumeLayout(false);
            this.contentsPanel.PerformLayout();
            this.filePanel.ResumeLayout(false);
            this.filePanel.PerformLayout();
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.MainContainer.Panel1.ResumeLayout(false);
            this.MainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).EndInit();
            this.MainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axHwpCtrl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button files;
        private System.Windows.Forms.Panel contentsPanel;
        private System.Windows.Forms.Button contents;
        private System.Windows.Forms.FlowLayoutPanel formatFlowLayoutPanel;
        private System.Windows.Forms.Panel filePanel;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button autoSave;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Button newFile;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.TextBox LogoName;
        private System.Windows.Forms.Button Form1;
        private System.Windows.Forms.SplitContainer MainContainer;
        private AxHWPCONTROLLib.AxHwpCtrl axHwpCtrl1;
        private System.Windows.Forms.FlowLayoutPanel ContentFlowLayoutPanel;
        private System.Windows.Forms.Label version;
        public System.Windows.Forms.Panel ControlMenu;
    }
}

