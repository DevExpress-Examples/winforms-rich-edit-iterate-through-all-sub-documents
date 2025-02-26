Namespace SubDocumentIterator

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.updateFieldsBtn = New DevExpress.XtraBars.BarButtonItem()
            Me.removeBookmarksBtn = New DevExpress.XtraBars.BarButtonItem()
            Me.replaceTextBtn = New DevExpress.XtraBars.BarButtonItem()
            Me.highlightBtn = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' richEditControl1
            ' 
            Me.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl1.Location = New System.Drawing.Point(0, 141)
            Me.richEditControl1.MenuManager = Me.ribbonControl1
            Me.richEditControl1.Name = "richEditControl1"
            Me.richEditControl1.Options.Bookmarks.Visibility = DevExpress.XtraRichEdit.RichEditBookmarkVisibility.Visible
            Me.richEditControl1.Size = New System.Drawing.Size(1048, 436)
            Me.richEditControl1.TabIndex = 0
            Me.richEditControl1.Text = "richEditControl1"
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.updateFieldsBtn, Me.removeBookmarksBtn, Me.replaceTextBtn, Me.highlightBtn})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 5
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
            Me.ribbonControl1.Size = New System.Drawing.Size(1048, 141)
            ' 
            ' updateFieldsBtn
            ' 
            Me.updateFieldsBtn.Caption = "Update fields"
            Me.updateFieldsBtn.Id = 1
            Me.updateFieldsBtn.Name = "updateFieldsBtn"
            AddHandler Me.updateFieldsBtn.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.updateFieldsBtn_ItemClick)
            ' 
            ' removeBookmarksBtn
            ' 
            Me.removeBookmarksBtn.Caption = "Remove bookmarks"
            Me.removeBookmarksBtn.Id = 2
            Me.removeBookmarksBtn.Name = "removeBookmarksBtn"
            AddHandler Me.removeBookmarksBtn.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.removeBookmarksBtn_ItemClick)
            ' 
            ' replaceTextBtn
            ' 
            Me.replaceTextBtn.Caption = "Replace text"
            Me.replaceTextBtn.Id = 3
            Me.replaceTextBtn.Name = "replaceTextBtn"
            AddHandler Me.replaceTextBtn.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.replaceTextBtn_ItemClick)
            ' 
            ' highlightBtn
            ' 
            Me.highlightBtn.Caption = "Highlight text"
            Me.highlightBtn.Id = 4
            Me.highlightBtn.Name = "highlightBtn"
            AddHandler Me.highlightBtn.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.highlightBtn_ItemClick)
            ' 
            ' ribbonPage1
            ' 
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "Actions"
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.ItemLinks.Add(Me.updateFieldsBtn)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.removeBookmarksBtn)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.replaceTextBtn)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.highlightBtn)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "ribbonPageGroup1"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1048, 577)
            Me.Controls.Add(Me.richEditControl1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

'#End Region
        Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl

        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl

        Private updateFieldsBtn As DevExpress.XtraBars.BarButtonItem

        Private removeBookmarksBtn As DevExpress.XtraBars.BarButtonItem

        Private replaceTextBtn As DevExpress.XtraBars.BarButtonItem

        Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage

        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private highlightBtn As DevExpress.XtraBars.BarButtonItem
    End Class
End Namespace
