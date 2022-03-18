namespace HWPFormer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.formBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.value = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // formBtn
            // 
            this.formBtn.Location = new System.Drawing.Point(258, 36);
            this.formBtn.Name = "formBtn";
            this.formBtn.Size = new System.Drawing.Size(242, 97);
            this.formBtn.TabIndex = 14;
            this.formBtn.Text = "생성하기";
            this.formBtn.UseVisualStyleBackColor = true;
            this.formBtn.Click += new System.EventHandler(this.formBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Location = new System.Drawing.Point(43, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "금액";
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(132, 98);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(100, 35);
            this.value.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(43, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "이름";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(132, 36);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 35);
            this.name.TabIndex = 10;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1476, 847);
            this.Controls.Add(this.formBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.value);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button formBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
    }
}