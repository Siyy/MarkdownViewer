using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MarkdownViewer
{
    public partial class MainForm : Form
    {
        private string _file = null;
        private bool _changed = false;
        public const string TITLE = "MarkdownViewer";

        public MainForm(string file)
        {
            InitializeComponent();
            initTabLen();
            if (file != null)
                openFile(file);
        }
        private void initTabLen()
        {
            //init tab len
            int w = 26;
            int[] tabs = new int[10];
            for (int i = 0; i < tabs.Length; i++)
                tabs[i] = w * (i + 1);
            _edit.SelectionTabs = tabs;
        }
        private void newFile()
        {
            if (!checkCanCloseFile())
            {
                return;
            }
            _file = null;
            _edit.Text = "";
            resetView("");
            setChanged(false);
        }

        private bool _loading = false;
        private void openFile(string file)
        {
            if (!checkCanCloseFile())
                return;
            _file = file;
            string content = File.ReadAllText(file);
            
            _loading = true;
            resetAll(content);
            _loading = false;

            setChanged(false);
        }
        private void setChanged(bool changed = true)
        {
            _changed = changed;
            refreshTitle();
        }
        private void refreshTitle()
        {
            string title = TITLE + " - " + _file;
            if (_changed)
                title += "*";
            this.Text = title;
        }

        private void resetEdit(string content)
        {
            _edit.Text = content;
        }

        private string _strCss = null;
        private void resetView(string content)
        {
            if (null == _strCss)
            {
                _strCss = File.ReadAllText(getExePath() + "\\default.css");
                _view.CssText = _strCss;
            }

            _view.MdText = content;
        }
        private void resetAll(string content)
        {
            resetEdit(content);
            resetView(content);
        }

        private string getExePath()
        {
            return System.Windows.Forms.Application.StartupPath;
        }

        private void saveFile(string file, string content)
        {
            File.WriteAllText(file, content);
            if (_file != file)
            {
                _file = file;
            }
            setChanged(false);
        }

        //check changed file
        private bool checkCanCloseFile()
        {
            if (_changed)
            {
                DialogResult dr = MessageBox.Show("File changed,do you save it?", "Save File", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    saveCurrFile();
                }
                else if (dr == DialogResult.Cancel)
                {
                    return false;
                }
            }
            return true;
        }

        private const string EXT_FILTER = "Markdown files|*.md";
        private void fileOpenMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog() ;
            dlg.CheckFileExists = true;
            dlg.Filter = EXT_FILTER;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                String file = dlg.FileName;
                openFile(file);
            }
        }
        private void saveCurrFile()
        {
            string file = _file;
            if (!File.Exists(_file))
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.AddExtension = true;
                dlg.Filter = EXT_FILTER;
                if (dlg.ShowDialog() != DialogResult.OK)
                    return;
                file = dlg.FileName;
            }
            string content = _edit.Text.Replace("\n", "\r\n");
            saveFile(file, content);
        }
        private void fileSaveMenuItem_Click(object sender, EventArgs e)
        {
            saveCurrFile();
        }

        private bool _firstChanged = true; //system invoke
        private void _edit_TextChanged(object sender, EventArgs e)
        {
            if (_firstChanged)
            {
                _firstChanged = false;
                return;
            }
            if (_loading)
                return;
            resetView(_edit.Text);
            setChanged();
        }

        private void showOrHideEdit()
        {
            _splitContainer.Panel1Collapsed = !_splitContainer.Panel1Collapsed;
        }

        private void viewEditMenuItem_Click(object sender, EventArgs e)
        {
            showOrHideEdit();
        }
        private string STR_ABOUT = "#MarkdownViewer v0.2\nProject:<https://github.com/jijinggang/MarkdownViewer>\n##Author\njijinggang@gmail.com\n##Copyright\nFree For All";
        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            resetView(STR_ABOUT);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!checkCanCloseFile())
            {
                e.Cancel = true;
                return;
            }
        }

        private void _view_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            //  this.Text = e.Url.ToString();
        }

        private void fileNewMenuItem_Click(object sender, EventArgs e)
        {
            newFile();
        }
    }
}
