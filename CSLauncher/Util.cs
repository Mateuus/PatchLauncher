using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace CSLauncher
{
    static class Util
    {
        public static string Between2Finer(string line, string delimiterFirst, string delimiterLast)
        {
            string[] splitterFirst = new string[] { delimiterFirst };
            string[] splitterLast = new string[] { delimiterLast };
            string[] splitRes;
            string buildBuffer;
            splitRes = line.Split(splitterFirst, 100000, System.StringSplitOptions.RemoveEmptyEntries);
            buildBuffer = splitRes[1];
            splitRes = buildBuffer.Split(splitterLast, 100000, System.StringSplitOptions.RemoveEmptyEntries);
            return splitRes[0];
        }

        public static string GetStringFromXToEnd(string line, string delimiterFirst)
        {
            return line.Substring(line.IndexOf(delimiterFirst));
        }


    }
}
