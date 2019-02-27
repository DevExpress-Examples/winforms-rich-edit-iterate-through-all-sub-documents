namespace SubDocumentIterator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.updateFieldsBtn = new DevExpress.XtraBars.BarButtonItem();
            this.removeBookmarksBtn = new DevExpress.XtraBars.BarButtonItem();
            this.replaceTextBtn = new DevExpress.XtraBars.BarButtonItem();
            this.highlightBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // richEditControl1
            // 
            this.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl1.Location = new System.Drawing.Point(0, 141);
            this.richEditControl1.MenuManager = this.ribbonControl1;
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Options.Bookmarks.Visibility = DevExpress.XtraRichEdit.RichEditBookmarkVisibility.Visible;
            this.richEditControl1.Size = new System.Drawing.Size(1048, 436);
            this.richEditControl1.TabIndex = 0;
            this.richEditControl1.Text = "richEditControl1";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.updateFieldsBtn,
            this.removeBookmarksBtn,
            this.replaceTextBtn,
            this.highlightBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1048, 141);
            // 
            // updateFieldsBtn
            // 
            this.updateFieldsBtn.Caption = "Update fields";
            this.updateFieldsBtn.Id = 1;
            this.updateFieldsBtn.Name = "updateFieldsBtn";
            this.updateFieldsBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.updateFieldsBtn_ItemClick);
            // 
            // removeBookmarksBtn
            // 
            this.removeBookmarksBtn.Caption = "Remove bookmarks";
            this.removeBookmarksBtn.Id = 2;
            this.removeBookmarksBtn.Name = "removeBookmarksBtn";
            this.removeBookmarksBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.removeBookmarksBtn_ItemClick);
            // 
            // replaceTextBtn
            // 
            this.replaceTextBtn.Caption = "Replace text";
            this.replaceTextBtn.Id = 3;
            this.replaceTextBtn.Name = "replaceTextBtn";
            this.replaceTextBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.replaceTextBtn_ItemClick);
            // 
            // highlightBtn
            // 
            this.highlightBtn.Caption = "Highlight text";
            this.highlightBtn.Id = 4;
            this.highlightBtn.Name = "highlightBtn";
            this.highlightBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.highlightBtn_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Actions";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.updateFieldsBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.removeBookmarksBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.replaceTextBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.highlightBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 577);
            this.Controls.Add(this.richEditControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem updateFieldsBtn;
        private DevExpress.XtraBars.BarButtonItem removeBookmarksBtn;
        private DevExpress.XtraBars.BarButtonItem replaceTextBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem highlightBtn;
    }
}

