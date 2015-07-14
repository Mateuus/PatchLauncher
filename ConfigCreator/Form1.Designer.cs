namespace ConfigCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRemoteUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDownloadUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEncrptionKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStartFile = new System.Windows.Forms.TextBox();
            this.txtBrowserUrl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbIsJustLast = new System.Windows.Forms.CheckBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDeleteUrl = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save Config";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Remote Config Url :";
            // 
            // txtRemoteUrl
            // 
            this.txtRemoteUrl.Location = new System.Drawing.Point(111, 20);
            this.txtRemoteUrl.Name = "txtRemoteUrl";
            this.txtRemoteUrl.Size = new System.Drawing.Size(252, 20);
            this.txtRemoteUrl.TabIndex = 2;
            this.txtRemoteUrl.Text = "http://localhost/iispath/RemoteConfig.txt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Download Url :";
            // 
            // txtDownloadUrl
            // 
            this.txtDownloadUrl.Location = new System.Drawing.Point(111, 46);
            this.txtDownloadUrl.Name = "txtDownloadUrl";
            this.txtDownloadUrl.Size = new System.Drawing.Size(252, 20);
            this.txtDownloadUrl.TabIndex = 4;
            this.txtDownloadUrl.Text = "http://localhost/iispath/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Encryption Key :";
            // 
            // txtEncrptionKey
            // 
            this.txtEncrptionKey.Location = new System.Drawing.Point(111, 76);
            this.txtEncrptionKey.Name = "txtEncrptionKey";
            this.txtEncrptionKey.Size = new System.Drawing.Size(252, 20);
            this.txtEncrptionKey.TabIndex = 6;
            this.txtEncrptionKey.Text = "2828";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Start File  :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtStartFile
            // 
            this.txtStartFile.Location = new System.Drawing.Point(111, 105);
            this.txtStartFile.Name = "txtStartFile";
            this.txtStartFile.Size = new System.Drawing.Size(252, 20);
            this.txtStartFile.TabIndex = 8;
            this.txtStartFile.Text = "Main.exe";
            // 
            // txtBrowserUrl
            // 
            this.txtBrowserUrl.Location = new System.Drawing.Point(111, 131);
            this.txtBrowserUrl.Name = "txtBrowserUrl";
            this.txtBrowserUrl.Size = new System.Drawing.Size(252, 20);
            this.txtBrowserUrl.TabIndex = 10;
            this.txtBrowserUrl.Text = "http://www.google.com";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Browser Url :";
            // 
            // cbIsJustLast
            // 
            this.cbIsJustLast.AutoSize = true;
            this.cbIsJustLast.Location = new System.Drawing.Point(214, 220);
            this.cbIsJustLast.Name = "cbIsJustLast";
            this.cbIsJustLast.Size = new System.Drawing.Size(151, 17);
            this.cbIsJustLast.TabIndex = 11;
            this.cbIsJustLast.Text = "Download only last update";
            this.cbIsJustLast.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(111, 157);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(252, 20);
            this.txtTitle.TabIndex = 12;
            this.txtTitle.Text = "Mu Online Server";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Title :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtIPAddress);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(425, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 177);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Starter Configs";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(8, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(267, 39);
            this.label9.TabIndex = 15;
            this.label9.Text = "This area for 97D versions which direct connect via CS\r\nport and ip address. \r\nLe" +
    "ave it blank if higher then 97\r\n";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(81, 46);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(53, 20);
            this.txtPort.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Port :";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(81, 20);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(201, 20);
            this.txtIPAddress.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Server IP :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtDeleteUrl);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtRemoteUrl);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTitle);
            this.groupBox2.Controls.Add(this.txtDownloadUrl);
            this.groupBox2.Controls.Add(this.cbIsJustLast);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBrowserUrl);
            this.groupBox2.Controls.Add(this.txtEncrptionKey);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtStartFile);
            this.groupBox2.Location = new System.Drawing.Point(12, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 254);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Delete Config Url :";
            // 
            // txtDeleteUrl
            // 
            this.txtDeleteUrl.Location = new System.Drawing.Point(111, 183);
            this.txtDeleteUrl.Name = "txtDeleteUrl";
            this.txtDeleteUrl.Size = new System.Drawing.Size(252, 20);
            this.txtDeleteUrl.TabIndex = 15;
            this.txtDeleteUrl.Text = "http://localhost/iispath/deleteconfig.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 294);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mu Launcher - Config Creator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRemoteUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDownloadUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEncrptionKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStartFile;
        private System.Windows.Forms.TextBox txtBrowserUrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbIsJustLast;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDeleteUrl;
    }
}

