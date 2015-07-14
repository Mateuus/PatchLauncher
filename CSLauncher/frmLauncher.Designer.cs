namespace CSLauncher
{
    partial class frmLauncher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
       // private SkinFramework.SkinningManager skinningManager;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLauncher));
           // this.skinningManager = new SkinFramework.SkinningManager();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblCurrentSize = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblCurrentVersion = new System.Windows.Forms.Label();
            this.btnOptions = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Login_Start = new System.Windows.Forms.Button();
            this.background2 = new System.Windows.Forms.Panel();
            this.img_senha = new System.Windows.Forms.PictureBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.fillet2 = new System.Windows.Forms.Panel();
            this.Background1 = new System.Windows.Forms.Panel();
            this.img_email = new System.Windows.Forms.PictureBox();
            this.User = new System.Windows.Forms.TextBox();
            this.fillet1 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Login_Start_Off = new System.Windows.Forms.Button();
            this.wbLauncher = new System.Windows.Forms.WebBrowser();
            this.Minimized = new System.Windows.Forms.Button();
            this.fechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.background2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_senha)).BeginInit();
            this.Background1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinningManager
            // 
           // this.skinningManager.DefaultSkin = SkinFramework.DefaultSkin.Office2007Luna;
           // this.skinningManager.ParentForm = this;
            // 
            // lblPercentage
            // 
            resources.ApplyResources(this.lblPercentage, "lblPercentage");
            this.lblPercentage.Name = "lblPercentage";
            // 
            // lblCurrentSize
            // 
            resources.ApplyResources(this.lblCurrentSize, "lblCurrentSize");
            this.lblCurrentSize.Name = "lblCurrentSize";
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // lblCurrentVersion
            // 
            resources.ApplyResources(this.lblCurrentVersion, "lblCurrentVersion");
            this.lblCurrentVersion.Name = "lblCurrentVersion";
            // 
            // btnOptions
            // 
            resources.ApplyResources(this.btnOptions, "btnOptions");
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Name = "label9";
            // 
            // Login_Start
            // 
            this.Login_Start.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.Login_Start, "Login_Start");
            this.Login_Start.FlatAppearance.BorderSize = 0;
            this.Login_Start.ForeColor = System.Drawing.Color.White;
            this.Login_Start.Name = "Login_Start";
            this.Login_Start.UseVisualStyleBackColor = false;
            // 
            // background2
            // 
            this.background2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.background2.Controls.Add(this.img_senha);
            this.background2.Controls.Add(this.Pass);
            this.background2.Controls.Add(this.fillet2);
            resources.ApplyResources(this.background2, "background2");
            this.background2.Name = "background2";
            // 
            // img_senha
            // 
            resources.ApplyResources(this.img_senha, "img_senha");
            this.img_senha.Name = "img_senha";
            this.img_senha.TabStop = false;
            // 
            // Pass
            // 
            this.Pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.Pass, "Pass");
            this.Pass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Pass.Name = "Pass";
            // 
            // fillet2
            // 
            this.fillet2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.fillet2, "fillet2");
            this.fillet2.Name = "fillet2";
            // 
            // Background1
            // 
            this.Background1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Background1.Controls.Add(this.img_email);
            this.Background1.Controls.Add(this.User);
            this.Background1.Controls.Add(this.fillet1);
            resources.ApplyResources(this.Background1, "Background1");
            this.Background1.Name = "Background1";
            // 
            // img_email
            // 
            resources.ApplyResources(this.img_email, "img_email");
            this.img_email.Name = "img_email";
            this.img_email.TabStop = false;
            // 
            // User
            // 
            this.User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.User, "User");
            this.User.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.User.Name = "User";
            // 
            // fillet1
            // 
            this.fillet1.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.fillet1, "fillet1");
            this.fillet1.Name = "fillet1";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.logo, "logo");
            this.logo.Name = "logo";
            this.logo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Login_Start_Off
            // 
            this.Login_Start_Off.BackColor = System.Drawing.Color.Green;
            this.Login_Start_Off.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Login_Start_Off, "Login_Start_Off");
            this.Login_Start_Off.ForeColor = System.Drawing.Color.White;
            this.Login_Start_Off.Name = "Login_Start_Off";
            this.Login_Start_Off.UseVisualStyleBackColor = false;
            // 
            // wbLauncher
            // 
            resources.ApplyResources(this.wbLauncher, "wbLauncher");
            this.wbLauncher.Name = "wbLauncher";
            this.wbLauncher.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // Minimized
            // 
            this.Minimized.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Minimized, "Minimized");
            this.Minimized.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Minimized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Minimized.Name = "Minimized";
            this.Minimized.UseVisualStyleBackColor = false;
            // 
            // fechar
            // 
            this.fechar.BackColor = System.Drawing.Color.Transparent;
            this.fechar.FlatAppearance.BorderSize = 2;
            this.fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.fechar, "fechar");
            this.fechar.Name = "fechar";
            this.fechar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.lblCurrentVersion);
            this.panel1.Controls.Add(this.lblCurrentSize);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // frmLauncher
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSLauncher.Properties.Resources.backgroundimg;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Login_Start);
            this.Controls.Add(this.background2);
            this.Controls.Add(this.Background1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Login_Start_Off);
            this.Controls.Add(this.wbLauncher);
            this.Controls.Add(this.Minimized);
            this.Controls.Add(this.fechar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmLauncher";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.frmLauncher_Load);
            this.background2.ResumeLayout(false);
            this.background2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_senha)).EndInit();
            this.Background1.ResumeLayout(false);
            this.Background1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblCurrentSize;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblCurrentVersion;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Login_Start;
        private System.Windows.Forms.Panel background2;
        private System.Windows.Forms.PictureBox img_senha;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.Panel fillet2;
        private System.Windows.Forms.Panel Background1;
        private System.Windows.Forms.PictureBox img_email;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.Panel fillet1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Login_Start_Off;
        private System.Windows.Forms.WebBrowser wbLauncher;
        private System.Windows.Forms.Button Minimized;
        private System.Windows.Forms.Button fechar;
        private System.Windows.Forms.Panel panel1;
    }
}

