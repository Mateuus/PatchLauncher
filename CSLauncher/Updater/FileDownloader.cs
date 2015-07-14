using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace CSLauncher.Updater
{
    public class FileDownloader
    {
        private List<int> _FileList;

        public List<int> FileList
        {
            get { return _FileList; }
            set { _FileList = value; }
        }


        private int _DownloadedCnt;

        public int DownloadedCnt
        {
            get { return _DownloadedCnt; }
            set { _DownloadedCnt = value; }
        }


        public void DownloadFile(string DownloadURL_)
        {
            DownloadedCnt = 0;
            foreach (var file_ in FileList)
            {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileAsync(new Uri(DownloadURL_ + file_ + ".rar"), Path.GetTempPath() + "\\" + file_ + ".rar");
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                while (client.IsBusy) { Application.DoEvents(); }
                DownloadedCnt++;
            }
        }

        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            frmLauncher._FormInstance.FileDownloadCompleted();
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            frmLauncher._FormInstance.UpdateProgressBar(int.Parse(Math.Truncate(percentage).ToString()));
            frmLauncher._FormInstance.UpdateState(bytesIn, totalBytes, percentage);
        }
    }
}
