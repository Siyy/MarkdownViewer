using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MarkdownViewer
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string file = null;
            if (args.Length > 0)
                file = args[0];
            if (!checkDefaultProgram(file))
                return;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(file));
        }
        private static bool checkDefaultProgram(string param)
        {
            const string STR_PARAM = "/setreg";
            if (!RegDoc.IsDefaultProgram())
            {
                if (param == STR_PARAM)
                {
                    try
                    {
                        RegDoc.RegMe(Util.GetExeFile());
                    }
                    catch (Exception)
                    {
                    }
                    return false;
                }
                else
                {
                    DialogResult dr = MessageBox.Show("MarkdownViewer isn't default editor for markdown files, do you set it?", "MarkdownViewer", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        Util.RunAsAdmin(Util.GetExeFile(), STR_PARAM);
                    }
                }
            }
            return true;
        }
    }
}
