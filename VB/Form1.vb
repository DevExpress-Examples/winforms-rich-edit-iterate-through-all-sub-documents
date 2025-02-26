Imports DevExpress.XtraRichEdit.API.Native
Imports System.ComponentModel
Imports System.Drawing

Namespace SubDocumentIterator

    Public Partial Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
            richEditControl1.LoadDocument("template.docx")
        End Sub

        Private Sub updateFieldsBtn_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            richEditControl1.Document.ForEachSubDocument((Sub(subdoc) subdoc.Fields.Update()))
        End Sub

        Private Sub removeBookmarksBtn_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            richEditControl1.Document.ForEachSubDocument(Sub(subdoc)
                For i As Integer = subdoc.Bookmarks.Count - 1 To 0 Step -1
                    subdoc.Bookmarks.Remove(subdoc.Bookmarks(i))
                Next
            End Sub)
        End Sub

        Private Sub replaceTextBtn_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            richEditControl1.Document.ForEachSubDocument(Sub(subdoc) subdoc.ReplaceAll("test text", "Hello!!!", SearchOptions.None))
        End Sub

        Private Sub highlightBtn_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            richEditControl1.Document.ForEachSubDocument((Sub(subdoc)
                Dim ranges As DocumentRange() = subdoc.FindAll("time", SearchOptions.None)
                For Each range As DocumentRange In ranges
                    Dim cp As CharacterProperties = subdoc.BeginUpdateCharacters(range)
                    cp.ForeColor = Color.Red
                    cp.BackColor = Color.Lavender
                    subdoc.EndUpdateCharacters(cp)
                Next
            End Sub))
        End Sub
    End Class
End Namespace
