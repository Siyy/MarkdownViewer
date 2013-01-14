using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
//register .md .mkd .markdown files
namespace MarkdownViewer
{
    class RegDoc
    {
        private const string REG_PATH = "MarkdownViewer.File";
        public static bool IsDefaultProgram()
        {
            string val = (string)Registry.GetValue("HKEY_CLASSES_ROOT\\.md", "", null);
            if (val != REG_PATH)
                return false;
            return true ;
        }
        public static void RegMe(string strFile)
        {
            Registry.SetValue("HKEY_CLASSES_ROOT\\.md", "", REG_PATH);
            Registry.SetValue("HKEY_CLASSES_ROOT\\.mkd", "", REG_PATH);
            Registry.SetValue("HKEY_CLASSES_ROOT\\.markdown", "", REG_PATH);
            Registry.SetValue("HKEY_CLASSES_ROOT\\MarkdownViewer.File\\shell\\open\\command", "", "\"" + strFile + "\" %1");
            Registry.SetValue("HKEY_CLASSES_ROOT\\MarkdownViewer.File\\DefaultIcon", "", strFile + ",1");
        }
    }
}
