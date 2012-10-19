using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MarkdownViewer
{
    class MdBrowser : System.Windows.Forms.WebBrowser
    {
        private MarkdownSharp.Markdown _md = new MarkdownSharp.Markdown();
        private string _mdText;
        public string MdText
        {
            get
            {
                return _mdText;
            }
            set
            {
                _mdText = value;
                resetView(_mdText);
            }
        }
        public string CssText { get; set; }

        public void SetUrl(string url)
        {
            this.Navigate(url);
        }
        protected override void OnNavigating(System.Windows.Forms.WebBrowserNavigatingEventArgs e)
        {
            base.OnNavigating(e);
        }
        public string Md2Html(string md)
        {
            string html = _md.Transform(md);
            html = string.Format(HTML_TMPL, CssText, html);
            return html;
        }


        private const string HTML_TMPL = "<html><head><style type=\"text/css\">{0}</style></head><body>{1}</body></html>";
        private void resetView(string content)
        {
            this.DocumentText = Md2Html(content);
        }


    }
}
