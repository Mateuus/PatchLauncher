using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ConfigCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string content_ = txtDownloadUrl.Text + "\r\n" +
                txtRemoteUrl.Text + "\r\n" +
                txtStartFile.Text + "\r\n" +
                txtBrowserUrl.Text + "\r\n" +
                cbIsJustLast.Checked + "\r\n" +
                txtTitle.Text + "\r\n" +
                txtIPAddress.Text + "\r\n" +
                txtPort.Text + "\r\n" +
                txtDeleteUrl.Text;
            content_ = SecureStringManager.Encrypt(content_, "28755");
            SaveFile("config.dat", content_);
        }

        private void SaveFile(string FileName_, string Content_)
        {
            File.WriteAllText(FileName_, Content_);
            MessageBox.Show("File Saved.");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


    }
}
