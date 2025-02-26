Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit
Imports System.Drawing
Imports System.Diagnostics

Namespace SubDocumentIterator

    Friend Class Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Shared Sub Main()
            Using wordProcessor As RichEditDocumentServer = New RichEditDocumentServer()
                wordProcessor.LoadDocument("template.docx")
                Dim document As Document = wordProcessor.Document
                AskAction(document)
                wordProcessor.SaveDocument("Modified.docx", DocumentFormat.OpenXml)
            End Using

            Dim p = New Process()
            p.StartInfo = New ProcessStartInfo("Modified.docx") With {.UseShellExecute = True}
            p.Start()
        End Sub

        Shared Private Sub AskAction(ByVal document As Document)
            Console.WriteLine("Enter a command's index." & Microsoft.VisualBasic.Constants.vbCrLf & "Available commands:" & Microsoft.VisualBasic.Constants.vbCrLf & "1. Update Fields" & Microsoft.VisualBasic.Constants.vbCrLf & "2. Remove Bookmarks" & Microsoft.VisualBasic.Constants.vbCrLf & "3. Replace Text" & Microsoft.VisualBasic.Constants.vbCrLf & "4. Highlight Text")
            Dim answer = Console.ReadLine()
            If answer Is "1" Then
                document.ForEachSubDocument((Sub(subdoc) subdoc.Fields.Update()))
            End If

            If answer Is "2" Then
                document.ForEachSubDocument(Sub(subdoc)
                    For i As Integer = subdoc.Bookmarks.Count - 1 To 0 Step -1
                        subdoc.Bookmarks.Remove(subdoc.Bookmarks(i))
                    Next
                End Sub)
            End If

            If answer Is "3" Then
                document.ForEachSubDocument(Sub(subdoc) subdoc.ReplaceAll("test text", "Hello!!!", SearchOptions.None))
            End If

            If answer Is "4" Then
                document.ForEachSubDocument(Sub(subdoc)
                    Dim ranges As DocumentRange() = subdoc.FindAll("time", SearchOptions.None)
                    For Each range As DocumentRange In ranges
                        Dim cp As CharacterProperties = subdoc.BeginUpdateCharacters(range)
                        cp.ForeColor = Color.Red
                        cp.BackColor = Color.Lavender
                        subdoc.EndUpdateCharacters(cp)
                    Next
                End Sub)
            End If

            Console.WriteLine("Do you want to perform another action? If no, the document is saved and opened in the Word. Y/N")
            Dim answerReply = Console.ReadLine()?.ToLower()
            If answerReply Is "y" Then
                AskAction(document)
            End If
        End Sub
    End Class
End Namespace
