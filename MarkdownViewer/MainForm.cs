﻿using System;
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
        private string _currFile = null;
        private bool _changed = false;
        private MarkdownSharp.Markdown _md = new MarkdownSharp.Markdown();
        public const string TITLE = "MarkdownViewer";

        public MainForm(string file)
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 600;
            this.CenterToScreen();
            if(file != null)
                openFile(file);
        }

        private bool _loading = false;
        private void openFile(string file)
        {
            _currFile = file;
            string content = File.ReadAllText(file);
            
            _loading = true;
            resetAll(content);
            _loading = false;

            _changed = false;
            refreshTitle();
        }
        private void setChanged()
        {
            _changed = true;
            refreshTitle();
        }
        private void refreshTitle()
        {
            string title = TITLE + " - " + _currFile;
            if (_changed)
                title += "*";
            this.Text = title;
        }

        private void resetEdit(string content)
        {
            _edit.Text = content;
        }

        private const string HTML_TMPL = "<html><head><style type=\"text/css\">{0}</style></head><body>{1}</body></html>";
        private void resetView(string content)
        {
            string html = _md.Transform(content);
            html = string.Format(HTML_TMPL, getCss(), html);
            _view.Stop();

            _view.Document.OpenNew(false).Write(html);

            //_view.Document.Write(html);
        }
        private void resetAll(string content)
        {
            resetEdit(content);
            resetView(content);
        }

        private string _strCss = null;
        private string getCss()
        {
            if (null == _strCss)
            {
                _strCss = File.ReadAllText(getExePath() + "\\default.css");
            }
            return _strCss;
        }

        private string getExePath()
        {
            return System.Windows.Forms.Application.StartupPath;
        }

        private void saveFile(string file, string content)
        {
            File.WriteAllText(file, content);
            _changed = false;
            if (_currFile != file)
            {
                _currFile = file;
                this.refreshTitle();
            }
        }
        private const string EXT_FILTER = "Markdown files|*.md;*.mkd;*.markdown";



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
        private void fileSaveMenuItem_Click(object sender, EventArgs e)
        {
            string file = _currFile;
            if (!File.Exists(_currFile))
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.AddExtension = true;
                dlg.Filter = EXT_FILTER;
                if (dlg.ShowDialog() != DialogResult.OK)
                    return;
                file = dlg.FileName;
            }
            saveFile(file, _edit.Text);
        }

        private void _edit_TextChanged(object sender, EventArgs e)
        {
            if (_loading)
                return;
            resetView(_edit.Text);
            setChanged();
        }


    }
}