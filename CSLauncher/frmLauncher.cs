using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
//using SkinFramework;
using CSLauncher.Updater;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace CSLauncher
{
    public partial class frmLauncher : Form 
    {

        //var's
        int TogMove;
        int MValX;
        int MValY;
     
        public frmLauncher()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            wbLauncher.ScriptErrorsSuppressed = true;
            _FormInstance = this;
            btnStart.Enabled = false;
            Configs_ = VersionConfig.GetConfigs();
            Configs_.LoadLocalConfig();
            Configs_.LoadRemoteConfig();
            wbLauncher.Navigate(Configs_.BrowserURL);
            this.Text = Configs_.Title;
        }

        #region Delete Files

        private void DoDeleteFiles()
        {
            try
            {
                foreach (string file_ in Configs_.RemoveFileList)
                {
                    if (!string.IsNullOrEmpty(file_))
                    {
                        DeleteFile(file_);
                    }
                }

            }
            catch { }
        }

        private void DeleteFile(string FileName_)
        {
            if (File.Exists(FileName_))
                File.Delete(FileName_);
        }

        #endregion

        private VersionConfig Configs_ = null;
        public static frmLauncher _FormInstance;
        private int _FileDownloaded = 0;
        private FileDownloader fDownloader_;
        public void UpdateProgressBar(int Value_)
        {
            progressBar1.Value = Value_;
        }

        public void FileDownloadCompleted()
        {
            _FileDownloaded++;
            if (Configs_.IsDownloadJustLast)
                CompleteUpdate();
            else
            {
                if (fDownloader_.FileList.Count == fDownloader_.DownloadedCnt)
                {
                    CompleteUpdate();
                }
            }
        }

        private void CompleteUpdate()
        {
            ExtractFiles();
            lblPercentage.Text = "100 %";
            lblCurrentSize.Text = "Update completed";
            progressBar1.Value = 100;
            btnStart.Enabled = true;
            lblCurrentVersion.Text = "Current Version : " + Configs_.RemoteVersion;
            File.WriteAllText("Version.txt", Configs_.RemoteVersion.ToString());
            DoDeleteFiles();
        }

        private void ExtractFiles()
        {
            List<int> extractList_ = Configs_.GetVersionList();
            for (int i = 0; i < extractList_.Count; i++)
            {
                RarUtility.Extract(Path.GetTempPath() + "\\" + extractList_[i] + ".rar");
            }
        }

        public void UpdateState(double BytesIn, double TotalBytes_, double Percentage_)
        {
            try
            {
                Thread.Sleep(1);
                lblCurrentSize.Text = BytesIn.ToString() + " Kb \\ " + TotalBytes_ + " Kb";
                lblPercentage.Text = Percentage_.ToString().Substring(0, Percentage_.ToString().IndexOf('.')) + " %";
            }
            catch { }
        }

        private void frmLauncher_Load(object sender, EventArgs e)
        {

            Thread thr_ = new Thread(new ThreadStart(DoUpdate));
            thr_.IsBackground = false;
            thr_.Start();
        }

        private void DoUpdate()
        {
            lblCurrentVersion.Text = "Current Version : " + Configs_.LocalVersion;
            Configs_.LoadRemoteConfig();
            List<int> updateList_ = Configs_.GetVersionList();
            if (updateList_.Count > 0)
            {
                fDownloader_ = new FileDownloader();
                fDownloader_.FileList = updateList_;
                fDownloader_.DownloadFile(Configs_.DownloadUrl);
            }
            else
                btnStart.Enabled = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            /*if (File.Exists(Configs_.StartFile))
                LaunchCommandLineApp(Configs_.StartFile);
            else
                MessageBox.Show("File not found." + Configs_.StartFile);*/

            label9.Visible = false;

            string Username = User.Text;
            string Password = Pass.Text;

            string Risposta = new WebClient().DownloadString("http://www.lambero.com.br/newpatch/login/login.php?username=" + Username + "&password=" + Password);
            switch (Risposta.ToLower())
            {
                case "1":
                    {
                        label9.Text = "Conta não Registrada";
                        label9.Visible = true;
                        //MessageBox.Show("Conta não Registrada");
                        break;
                    }
                case "2":
                    {
                        label9.Text = "Senha Incorreta";
                        label9.Visible = true;
                        // MessageBox.Show("Senha Incorreta");
                        break;
                    }
                case "3":
                    {

                        string ExeType = "1rag1";
                        string output = String.Format("-t:{0} {1} {2}", Password, Username, ExeType);
                        Process.Start("CLambeRO.exe", output);

                       
                       ///Process.Start("CLambeRO.exe", "-t:{0} {1} {2}" + Password + Username + ExeType);

                       Application.Exit();

                        //MessageBox.Show("Login aceito!");
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Erro com o servidor remoto, por favor deixe-a tentar mais tarde!");
                        break;
                    }
            }
        }

        void LaunchCommandLineApp(string FileName_)
        {
            // Use ProcessStartInfo class
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = FileName_;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //connect /u127.0.0.1 /p44405
            startInfo.Arguments = string.Format("\\ClambeRO.exe -t:{0} {1}", Configs_.IPAddress, Configs_.Port);
            try
            {
                // Start the process with the info we specified.
                // Call WaitForExit and then the using statement will close.
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch
            {
                // Log error.
            }
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
           /* frmOptions frm_ = new frmOptions();
            frm_.ShowDialog();*/
            Process.Start("opensetup.exe");
        }


        private void User_TextChanged(object sender, EventArgs e)
        {

        }

        private void User_MouseClick(object sender, MouseEventArgs e)
        {
            if (User.Text == "Login")
            {
                User.Text = "";
            }
            else
            {

            }


            Background1.BackColor = SystemColors.ButtonFace;
            fillet1.BackColor = Color.SteelBlue;

            //background2.BackColor = SystemColors.ButtonHighlight;
            fillet2.BackColor = Color.Transparent;

            background2.BorderStyle = BorderStyle.None;
            fillet2.BorderStyle = BorderStyle.None;

        }

        private void Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pass_MouseClick(object sender, MouseEventArgs e)
        {
            if (Pass.Text == "Senha")
            {
                Pass.Text = "";
                Pass.UseSystemPasswordChar = true;
            }
            else
            {

            }



            background2.BackColor = SystemColors.ButtonFace;
            fillet2.BackColor = Color.SteelBlue;

            //Background1.BackColor = SystemColors.ButtonHighlight;
            fillet1.BackColor = Color.Transparent;

            Background1.BorderStyle = BorderStyle.None;
            fillet1.BorderStyle = BorderStyle.None;
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmLauncher_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void frmLauncher_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void frmLauncher_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void Login_Start_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.lambero.com.br");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.forum.lambero.com.br");
        }

    }
}
