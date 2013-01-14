using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Diagnostics;
namespace MarkdownViewer
{
    class Util
    {
        public static string GetExePath()
        {
            return System.Windows.Forms.Application.StartupPath;
        }
        public static string GetExeFile()
        {
            return System.Windows.Forms.Application.ExecutablePath;
        }
        //run new program as Administrator
        public static void RunAsAdmin(string strExe, string strParam)
        {
            ProcessStartInfo info = new ProcessStartInfo(strExe, strParam);
            info.UseShellExecute = true;
            info.WorkingDirectory = GetExePath();
            info.Verb = "runas";
            Process.Start(info);
        }
    }
}
