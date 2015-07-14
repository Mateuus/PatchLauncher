using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using SkinFramework;
using CSLauncher.Updater;
using Microsoft.Win32;

namespace CSLauncher
{
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
            this.Text = VersionConfig.GetConfigs().Title;
        }
        RegistryKey baseRegistryKey = Registry.CurrentUser;

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveCnfigs();
            MessageBox.Show("Configs Saved.");
        }

        public bool SaveCnfigs()
        {
            try
            {
                string res_ = "";
                string mus_ = "";
                string sou_ = "";
                string winMode_ = "";
                string bit_ = "";
                RegistryKey myKey;

                if (rd640.Checked)
                    res_ = "00000000";
                else if (rd800.Checked)
                    res_ = "00000001";
                else if (rd1024.Checked)
                    res_ = "00000002";
                else if (rd1280.Checked)
                    res_ = "00000003";

                if (cbIsMusicOn.Checked)
                    mus_ = "00000001";
                else
                    mus_ = "00000000";

                if (cbIsSoundOn.Checked)
                    sou_ = "00000001";
                else
                    sou_ = "00000000";

                if (cbIsWinMode.Checked)
                    winMode_ = "00000001";
                else
                    winMode_ = "00000000";

                if (rb16bit.Checked)
                    bit_ = "00000000";
                else if (rb32Bit.Checked)
                    bit_ = "00000001";

                myKey = Registry.CurrentUser.OpenSubKey(@"Software\Webzen\Mu\Config", true);
                myKey.SetValue("Resolution", res_, RegistryValueKind.DWord);
                myKey.SetValue("MusicOnOff", mus_, RegistryValueKind.DWord);
                myKey.SetValue("SoundOnOff", sou_, RegistryValueKind.DWord);
                myKey.SetValue("WindowMode", winMode_, RegistryValueKind.DWord);
                myKey.SetValue("ColorDepth", bit_, RegistryValueKind.DWord);
                myKey.SetValue("ID", txtUserID.Text, RegistryValueKind.String);

                return true;
            }
            catch (Exception e)
            {
                // AAAAAAAAAAARGH, an error!
                return false;
            }
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {
            var myKey = Registry.CurrentUser.OpenSubKey(@"Software\Webzen\Mu\Config", true);
            string res_ =Convert.ToString(myKey.GetValue("Resolution"));
            if (res_ == "0")
                rd640.Checked = true;
            else if (res_ == "1")
                rd800.Checked = true;
            else if (res_ == "2")
                rd1024.Checked = true;
            else if (res_ == "3")
                rd1280.Checked = true;

            string mus_ = Convert.ToString(myKey.GetValue("MusicOnOff"));
            if (mus_ == "0")
                cbIsMusicOn.Checked = false;
            else
                cbIsMusicOn.Checked = true;
            string sou_ = Convert.ToString(myKey.GetValue("SoundOnOff"));
            if (sou_ == "0")
                cbIsSoundOn.Checked = false;
            else
                cbIsSoundOn.Checked = true;
            string winM_ = Convert.ToString(myKey.GetValue("WindowMode"));
            if (winM_ == "1")
                cbIsWinMode.Checked = true;
            else
                cbIsWinMode.Checked = false;
            string col_ = Convert.ToString(myKey.GetValue("ColorDepth"));
            if (col_ == "0")
                rb16bit.Checked = true;
            else
                rb32Bit.Checked = true;

            txtUserID.Text = Convert.ToString(myKey.GetValue("ID"));
        }


    }
}
