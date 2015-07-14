using NUnrar.Archive;
using NUnrar.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace CSLauncher
{
    public static class RarUtility
    {
        // TODO :: Fix here.
        public static void Extract(string RarPath_)
        {
            bool flag_ = false;
            FileInfo f2 = new FileInfo(RarPath_);
            long s2 = f2.Length;
            if (s2 > 0)
            {
                RarArchive archive = RarArchive.Open(RarPath_);
                foreach (RarArchiveEntry entry in archive.Entries)
                {
                    try
                    {
                        string fileName = Path.GetFileName(entry.FilePath);
                        string rootToFile = Path.GetFullPath(entry.FilePath).Replace(fileName, "");
                        if (!Directory.Exists(rootToFile))
                        {
                            Directory.CreateDirectory(rootToFile);
                        }
                        entry.WriteToFile(rootToFile + fileName, ExtractOptions.ExtractFullPath | ExtractOptions.Overwrite);
                    }
                    catch (Exception ex)
                    {
                        //handle your exception here..
                    }
                }
            }
        }

    }
}
