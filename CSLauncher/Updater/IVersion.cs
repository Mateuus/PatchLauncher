using System;
using System.Collections.Generic;
using System.Text;

namespace CSLauncher.Updater
{
    public interface IVersion
    {
        void LoadRemoteConfig();
        void LoadLocalConfig();
        List<int> GetVersionList();
    }
}
