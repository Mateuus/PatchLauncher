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
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblCurrentSize = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblCurrentVersion = new System.Windows.Forms.Label();
            this.btnOptions = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.background2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_senha)).BeginInit();
            this.Background1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPercentage
            // 
            resources.ApplyResources(this.lblPercentage, "lblPercentage");
            this.lblPercentage.Name = "lblPercentage";
            // 
            // lblCurrentSize
            // 
            resources.ApplyResources(this.lblCurrentSize, "lblCurrentSize");
            this.lblCurrentSize.BackColor = System.Drawing.Color.Transparent;
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
            this.lblCurrentVersion.BackColor = System.Drawing.Color.Transparent;
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
            this.img_senha.Image = global::CSLauncher.Properties.Resources.appbar_interface_password;
            resources.ApplyResources(this.img_senha, "img_senha");
            this.img_senha.Name = "img_senha";
            this.img_senha.TabStop = false;
            // 
            // Pass
            // 
            this.Pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.Pass, "Pass");
            this.Pass.ForeColor = System.Drawing.Color.Black;
            this.Pass.Name = "Pass";
            this.Pass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pass_MouseClick);
            this.Pass.TextChanged += new System.EventHandler(this.Pass_TextChanged);
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
            this.img_email.Image = global::CSLauncher.Properties.Resources.appbar_interface_textbox;
            resources.ApplyResources(this.img_email, "img_email");
            this.img_email.Name = "img_email";
            this.img_email.TabStop = false;
            // 
            // User
            // 
            this.User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.User, "User");
            this.User.ForeColor = System.Drawing.Color.Black;
            this.User.Name = "User";
            this.User.MouseClick += new System.Windows.Forms.MouseEventHandler(this.User_MouseClick);
            this.User.TextChanged += new System.EventHandler(this.User_TextChanged);
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
            this.logo.Image = global::CSLauncher.Properties.Resources.logo;
            resources.ApplyResources(this.logo, "logo");
            this.logo.Name = "logo";
            this.logo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CSLauncher.Properties.Resources.menu_login;
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
            this.wbLauncher.Url = new System.Uri("http://www.lambero.com.br/newpatch/novidades.php", System.UriKind.Absolute);
            // 
            // Minimized
            // 
            this.Minimized.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Minimized, "Minimized");
            this.Minimized.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Minimized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Minimized.Name = "Minimized";
            this.Minimized.UseVisualStyleBackColor = false;
            this.Minimized.Click += new System.EventHandler(this.Minimized_Click);
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
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.lblCurrentSize);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblCurrentVersion);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmLauncher
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSLauncher.Properties.Resources.backgroundimg;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.background2);
            this.Controls.Add(this.Background1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Login_Start_Off);
            this.Controls.Add(this.wbLauncher);
            this.Controls.Add(this.Minimized);
            this.Controls.Add(this.fechar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmLauncher";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.frmLauncher_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLauncher_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLauncher_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmLauncher_MouseUp);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

