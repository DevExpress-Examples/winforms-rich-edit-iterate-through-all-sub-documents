using DevExpress.XtraRichEdit.API.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SubDocumentIterator
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            richEditControl1.LoadDocument("template.docx");
        }

        private void updateFieldsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            richEditControl1.Document.ForEachSubDocument((subdoc => { subdoc.Fields.Update(); }));
        }

        private void removeBookmarksBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            richEditControl1.Document.ForEachSubDocument((subdoc => 
            {
                for (int i = subdoc.Bookmarks.Count - 1; i >= 0; i--)
                    subdoc.Bookmarks.Remove(subdoc.Bookmarks[i]);
            }));
        }

        private void replaceTextBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            richEditControl1.Document.ForEachSubDocument((subdoc => { subdoc.ReplaceAll("test text", "Hello!!!", SearchOptions.None); }));
        }

        private void highlightBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            richEditControl1.Document.ForEachSubDocument((subdoc =>
            {
                DocumentRange[] ranges = subdoc.FindAll("time", SearchOptions.None);
                foreach(DocumentRange range in ranges)
                {
                    CharacterProperties cp = subdoc.BeginUpdateCharacters(range);
                    cp.ForeColor = Color.Red;
                    cp.BackColor = Color.Lavender;
                    subdoc.EndUpdateCharacters(cp);
                }
            }));
        }
    }
}
