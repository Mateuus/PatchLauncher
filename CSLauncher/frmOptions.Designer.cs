namespace CSLauncher
{
    partial class frmOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private SkinFramework.SkinningManager skinningManager;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            catch
            {
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.skinningManager = new SkinFramework.SkinningManager();
            this.btnSave = new System.Windows.Forms.Button();
            this.rd640 = new System.Windows.Forms.RadioButton();
            this.rd800 = new System.Windows.Forms.RadioButton();
            this.rd1024 = new System.Windows.Forms.RadioButton();
            this.rd1280 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbIsWinMode = new System.Windows.Forms.CheckBox();
            this.cbIsSoundOn = new System.Windows.Forms.CheckBox();
            this.cbIsMusicOn = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.rb16bit = new System.Windows.Forms.RadioButton();
            this.rb32Bit = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinningManager
            // 
            this.skinningManager.DefaultSkin = SkinFramework.DefaultSkin.Office2007Luna;
            this.skinningManager.ParentForm = this;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(19, 169);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(410, 41);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rd640
            // 
            this.rd640.AutoSize = true;
            this.rd640.Location = new System.Drawing.Point(18, 14);
            this.rd640.Name = "rd640";
            this.rd640.Size = new System.Drawing.Size(71, 17);
            this.rd640.TabIndex = 8;
            this.rd640.TabStop = true;
            this.rd640.Tag = "a";
            this.rd640.Text = "640 * 480";
            this.rd640.UseVisualStyleBackColor = true;
            // 
            // rd800
            // 
            this.rd800.AutoSize = true;
            this.rd800.Location = new System.Drawing.Point(18, 37);
            this.rd800.Name = "rd800";
            this.rd800.Size = new System.Drawing.Size(71, 17);
            this.rd800.TabIndex = 10;
            this.rd800.TabStop = true;
            this.rd800.Tag = "a";
            this.rd800.Text = "800 * 600";
            this.rd800.UseVisualStyleBackColor = true;
            // 
            // rd1024
            // 
            this.rd1024.AutoSize = true;
            this.rd1024.Location = new System.Drawing.Point(18, 60);
            this.rd1024.Name = "rd1024";
            this.rd1024.Size = new System.Drawing.Size(77, 17);
            this.rd1024.TabIndex = 11;
            this.rd1024.TabStop = true;
            this.rd1024.Tag = "a";
            this.rd1024.Text = "1024 * 768";
            this.rd1024.UseVisualStyleBackColor = true;
            // 
            // rd1280
            // 
            this.rd1280.AutoSize = true;
            this.rd1280.Location = new System.Drawing.Point(18, 83);
            this.rd1280.Name = "rd1280";
            this.rd1280.Size = new System.Drawing.Size(83, 17);
            this.rd1280.TabIndex = 12;
            this.rd1280.TabStop = true;
            this.rd1280.Tag = "a";
            this.rd1280.Text = "1280 * 1024";
            this.rd1280.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rd640);
            this.panel1.Controls.Add(this.rd1280);
            this.panel1.Controls.Add(this.rd800);
            this.panel1.Controls.Add(this.rd1024);
            this.panel1.Location = new System.Drawing.Point(19, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 117);
            this.panel1.TabIndex = 13;
            // 
            // cbIsWinMode
            // 
            this.cbIsWinMode.AutoSize = true;
            this.cbIsWinMode.Location = new System.Drawing.Point(19, 15);
            this.cbIsWinMode.Name = "cbIsWinMode";
            this.cbIsWinMode.Size = new System.Drawing.Size(109, 17);
            this.cbIsWinMode.TabIndex = 14;
            this.cbIsWinMode.Text = "Windows Mode ?";
            this.cbIsWinMode.UseVisualStyleBackColor = true;
            // 
            // cbIsSoundOn
            // 
            this.cbIsSoundOn.AutoSize = true;
            this.cbIsSoundOn.Location = new System.Drawing.Point(19, 39);
            this.cbIsSoundOn.Name = "cbIsSoundOn";
            this.cbIsSoundOn.Size = new System.Drawing.Size(83, 17);
            this.cbIsSoundOn.TabIndex = 15;
            this.cbIsSoundOn.Text = "Sound On ?";
            this.cbIsSoundOn.UseVisualStyleBackColor = true;
            // 
            // cbIsMusicOn
            // 
            this.cbIsMusicOn.AutoSize = true;
            this.cbIsMusicOn.Location = new System.Drawing.Point(19, 62);
            this.cbIsMusicOn.Name = "cbIsMusicOn";
            this.cbIsMusicOn.Size = new System.Drawing.Size(80, 17);
            this.cbIsMusicOn.TabIndex = 16;
            this.cbIsMusicOn.Text = "Music On ?";
            this.cbIsMusicOn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbIsMusicOn);
            this.panel2.Controls.Add(this.cbIsWinMode);
            this.panel2.Controls.Add(this.cbIsSoundOn);
            this.panel2.Location = new System.Drawing.Point(156, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(134, 117);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtUserID);
            this.panel3.Controls.Add(this.rb16bit);
            this.panel3.Controls.Add(this.rb32Bit);
            this.panel3.Location = new System.Drawing.Point(308, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(121, 117);
            this.panel3.TabIndex = 18;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(14, 15);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 20);
            this.txtUserID.TabIndex = 11;
            this.txtUserID.Text = "UserID";
            // 
            // rb16bit
            // 
            this.rb16bit.AutoSize = true;
            this.rb16bit.Location = new System.Drawing.Point(14, 62);
            this.rb16bit.Name = "rb16bit";
            this.rb16bit.Size = new System.Drawing.Size(52, 17);
            this.rb16bit.TabIndex = 8;
            this.rb16bit.TabStop = true;
            this.rb16bit.Tag = "b";
            this.rb16bit.Text = "16 Bit";
            this.rb16bit.UseVisualStyleBackColor = true;
            // 
            // rb32Bit
            // 
            this.rb32Bit.AutoSize = true;
            this.rb32Bit.Location = new System.Drawing.Point(14, 85);
            this.rb32Bit.Name = "rb32Bit";
            this.rb32Bit.Size = new System.Drawing.Size(52, 17);
            this.rb32Bit.TabIndex = 10;
            this.rb32Bit.TabStop = true;
            this.rb32Bit.Tag = "b";
            this.rb32Bit.Text = "32 Bit";
            this.rb32Bit.UseVisualStyleBackColor = true;
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 228);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Name = "frmOptions";
            this.Text = "Duel Mu Online";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rd640;
        private System.Windows.Forms.RadioButton rd1280;
        private System.Windows.Forms.RadioButton rd800;
        private System.Windows.Forms.RadioButton rd1024;
        private System.Windows.Forms.CheckBox cbIsMusicOn;
        private System.Windows.Forms.CheckBox cbIsSoundOn;
        private System.Windows.Forms.CheckBox cbIsWinMode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rb16bit;
        private System.Windows.Forms.RadioButton rb32Bit;
        private System.Windows.Forms.TextBox txtUserID;
    }
}

