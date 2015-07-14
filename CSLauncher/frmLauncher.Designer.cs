namespace CSLauncher
{
    partial class frmLauncher
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
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblCurrentSize = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnOptions = new System.Windows.Forms.Button();
            this.lblCurrentVersion = new System.Windows.Forms.Label();
            this.wbLauncher = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // skinningManager
            // 
            this.skinningManager.DefaultSkin = SkinFramework.DefaultSkin.Office2007Luna;
            this.skinningManager.ParentForm = this;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(576, 256);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(0, 13);
            this.lblPercentage.TabIndex = 9;
            // 
            // lblCurrentSize
            // 
            this.lblCurrentSize.AutoSize = true;
            this.lblCurrentSize.Location = new System.Drawing.Point(90, 303);
            this.lblCurrentSize.Name = "lblCurrentSize";
            this.lblCurrentSize.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentSize.TabIndex = 8;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(622, 256);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(115, 70);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 272);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(610, 21);
            this.progressBar1.TabIndex = 6;
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(6, 303);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(78, 23);
            this.btnOptions.TabIndex = 10;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // lblCurrentVersion
            // 
            this.lblCurrentVersion.AutoSize = true;
            this.lblCurrentVersion.Location = new System.Drawing.Point(481, 313);
            this.lblCurrentVersion.Name = "lblCurrentVersion";
            this.lblCurrentVersion.Size = new System.Drawing.Size(88, 13);
            this.lblCurrentVersion.TabIndex = 11;
            this.lblCurrentVersion.Text = "Current Version : ";
            // 
            // wbLauncher
            // 
            this.wbLauncher.Dock = System.Windows.Forms.DockStyle.Top;
            this.wbLauncher.Location = new System.Drawing.Point(0, 0);
            this.wbLauncher.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbLauncher.Name = "wbLauncher";
            this.wbLauncher.Size = new System.Drawing.Size(749, 250);
            this.wbLauncher.TabIndex = 12;
            // 
            // frmLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 340);
            this.Controls.Add(this.wbLauncher);
            this.Controls.Add(this.lblCurrentVersion);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblCurrentSize);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLauncher";
            this.Text = "Mu Online";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.frmLauncher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblCurrentSize;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Label lblCurrentVersion;
        private System.Windows.Forms.WebBrowser wbLauncher;
    }
}

