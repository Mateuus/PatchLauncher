using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Net;

namespace CSLauncher.Updater
{
    public class VersionConfig : IVersion
    {
        #region Properties

        private static VersionConfig _Instance;

        private string _StartFile;

        public string StartFile
        {
            get { return _StartFile; }
            set { _StartFile = value; }
        }

        private string _BrowserURL;

        public string BrowserURL
        {
            get { return _BrowserURL; }
            set { _BrowserURL = value; }
        }

        private string _RemoteConfigUrl;
        public string RemoteConfigUrl
        {
            get { return _RemoteConfigUrl; }
            set { _RemoteConfigUrl = value; }
        }

        private string _DownloadUrl;
        public string DownloadUrl
        {
            get { return _DownloadUrl; }
            set { _DownloadUrl = value; }
        }

        private int _RemoteVersion;
        public int RemoteVersion
        {
            get { return _RemoteVersion; }
            set { _RemoteVersion = value; }
        }

        private int _LocalVersion;
        public int LocalVersion
        {
            get { return _LocalVersion; }
            set { _LocalVersion = value; }
        }

        private List<int> _NewVersions;

        public List<int> NewVersions
        {
            get { return _NewVersions; }
            set { _NewVersions = value; }
        }

        private bool _IsDownloadJustLast;

        public bool IsDownloadJustLast
        {
            get { return _IsDownloadJustLast; }
            set { _IsDownloadJustLast = value; }
        }

        private string _Title;

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        private string _IPAddress;

        public string IPAddress
        {
            get { return _IPAddress; }
            set { _IPAddress = value; }
        }

        private string _Port;

        public string Port
        {
            get { return _Port; }
            set { _Port = value; }
        }


        private string[] _RemoveFileList;

        public string[] RemoveFileList
        {
            get { return _RemoveFileList; }
            set { _RemoveFileList = value; }
        }

        private string _RemoveFileUrl;

        public string RemoveFileUrl
        {
            get { return _RemoveFileUrl; }
            set { _RemoveFileUrl = value; }
        }


        #endregion

        public static VersionConfig GetConfigs()
        {
            if (_Instance == null)
            {
                _Instance = new VersionConfig();
            }
            return _Instance;
        }

        protected VersionConfig()
        {

        }

        #region Interface Members

        public void LoadRemoteConfig()
        {
            var webClient = new WebClient();
            _Instance.RemoteVersion = Convert.ToInt32(webClient.DownloadString(_Instance.RemoteConfigUrl));
            string tmp_ = webClient.DownloadString(_Instance.RemoveFileUrl);
            File.WriteAllText(Path.GetTempPath() + "csremotedelete.txt", tmp_);
            if (File.Exists(Path.GetTempPath() + "csremotedelete.txt"))
                _Instance.RemoveFileList = File.ReadAllLines(Path.GetTempPath() + "csremotedelete.txt");
        }

        public void LoadLocalConfig()
        {
            try
            {
                string[] ConfigsList_ = Regex.Split(SecureStringManager.Decrypt(File.ReadAllText("config.dat"), "28755"), "\r\n");
                _Instance.DownloadUrl = ConfigsList_[0];
                _Instance.RemoteConfigUrl = ConfigsList_[1];
                _Instance.StartFile = ConfigsList_[2];
                _Instance.BrowserURL = ConfigsList_[3];
                _Instance.IsDownloadJustLast = Convert.ToBoolean(ConfigsList_[4]);
                _Instance.Title = ConfigsList_[5];
                _Instance.IPAddress = ConfigsList_[6];
                _Instance.Port = ConfigsList_[7];
                _Instance.RemoveFileUrl = ConfigsList_[8];
                _Instance.LocalVersion = Convert.ToInt32(File.ReadAllText("Version.txt", Encoding.UTF8).Trim());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<int> GetVersionList()
        {
            _Instance.NewVersions = new List<int>();
            if (_Instance.IsDownloadJustLast)
            {
                if (_Instance.LocalVersion < _Instance.RemoteVersion)
                    _Instance.NewVersions.Add(_Instance.RemoteVersion);
            }
            else
            {
                if (_Instance.LocalVersion < _Instance.RemoteVersion)
                    for (int i = _Instance.LocalVersion + 1; i <= _Instance.RemoteVersion; i++)
                    {
                        _Instance.NewVersions.Add(i);
                    }
            }
            return _Instance.NewVersions;
        }


        #endregion

    }
}
