Imports System
Imports System.Windows.Forms
Imports DevExpress.UserSkins

Namespace SubDocumentIterator

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call BonusSkins.Register()
            Call Application.Run(New Form1())
        End Sub
    End Module
End Namespace
