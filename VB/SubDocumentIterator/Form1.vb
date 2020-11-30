Imports DevExpress.XtraRichEdit.API.Native
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace SubDocumentIterator
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Public Sub New()
			InitializeComponent()
			richEditControl1.LoadDocument("template.docx")
		End Sub

		Private Sub updateFieldsBtn_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles updateFieldsBtn.ItemClick
			richEditControl1.Document.ForEachSubDocument((Sub(subdoc)
				subdoc.Fields.Update()
			End Sub))
		End Sub

		Private Sub removeBookmarksBtn_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles removeBookmarksBtn.ItemClick
			richEditControl1.Document.ForEachSubDocument((Sub(subdoc)
				For i As Integer = subdoc.Bookmarks.Count - 1 To 0 Step -1
					subdoc.Bookmarks.Remove(subdoc.Bookmarks(i))
				Next i
			End Sub))
		End Sub

		Private Sub replaceTextBtn_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles replaceTextBtn.ItemClick
			richEditControl1.Document.ForEachSubDocument((Sub(subdoc)
				subdoc.ReplaceAll("test text", "Hello!!!", SearchOptions.None)
			End Sub))
		End Sub

		Private Sub highlightBtn_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles highlightBtn.ItemClick
			richEditControl1.Document.ForEachSubDocument((Sub(subdoc)
				Dim ranges() As DocumentRange = subdoc.FindAll("time", SearchOptions.None)
				For Each range As DocumentRange In ranges
					Dim cp As CharacterProperties = subdoc.BeginUpdateCharacters(range)
					cp.ForeColor = Color.Red
					cp.BackColor = Color.Lavender
					subdoc.EndUpdateCharacters(cp)
				Next range
			End Sub))
		End Sub
	End Class
End Namespace
