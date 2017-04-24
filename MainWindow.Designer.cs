namespace QR_Workshop
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButtonQRGenerate = new DevExpress.XtraEditors.SimpleButton();
            this.textEditQRHeight = new DevExpress.XtraEditors.TextEdit();
            this.textEditQRWidth = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.memoEditQRContent = new DevExpress.XtraEditors.MemoEdit();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.memoEditDecodeResult = new DevExpress.XtraEditors.MemoEdit();
            this.simpleButtonSelectImageDecode = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonDecode = new DevExpress.XtraEditors.SimpleButton();
            this.textEditQRFileLocationDecode = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditQRHeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditQRWidth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditQRContent.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditDecodeResult.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditQRFileLocationDecode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(386, 256);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.simpleButtonQRGenerate);
            this.xtraTabPage1.Controls.Add(this.textEditQRHeight);
            this.xtraTabPage1.Controls.Add(this.textEditQRWidth);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.memoEditQRContent);
            this.xtraTabPage1.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.Image")));
            this.xtraTabPage1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(380, 225);
            this.xtraTabPage1.Text = "QR Code Generator";
            // 
            // simpleButtonQRGenerate
            // 
            this.simpleButtonQRGenerate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.simpleButtonQRGenerate.Appearance.Options.UseTextOptions = true;
            this.simpleButtonQRGenerate.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.simpleButtonQRGenerate.Image = global::QR_Workshop.Properties.Resources.start_here;
            this.simpleButtonQRGenerate.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButtonQRGenerate.Location = new System.Drawing.Point(143, 187);
            this.simpleButtonQRGenerate.Name = "simpleButtonQRGenerate";
            this.simpleButtonQRGenerate.Size = new System.Drawing.Size(94, 28);
            this.simpleButtonQRGenerate.TabIndex = 6;
            this.simpleButtonQRGenerate.Text = "Generate";
            this.simpleButtonQRGenerate.Click += new System.EventHandler(this.simpleButtonQRGenerate_Click);
            // 
            // textEditQRHeight
            // 
            this.textEditQRHeight.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textEditQRHeight.EditValue = "200";
            this.textEditQRHeight.Location = new System.Drawing.Point(198, 150);
            this.textEditQRHeight.Name = "textEditQRHeight";
            this.textEditQRHeight.Properties.Mask.EditMask = "[0-9]+";
            this.textEditQRHeight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditQRHeight.Properties.Mask.ShowPlaceHolders = false;
            this.textEditQRHeight.Size = new System.Drawing.Size(75, 20);
            this.textEditQRHeight.TabIndex = 5;
            // 
            // textEditQRWidth
            // 
            this.textEditQRWidth.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textEditQRWidth.EditValue = "200";
            this.textEditQRWidth.Location = new System.Drawing.Point(108, 150);
            this.textEditQRWidth.Name = "textEditQRWidth";
            this.textEditQRWidth.Properties.EditFormat.FormatString = "\\d+";
            this.textEditQRWidth.Properties.Mask.EditMask = "[0-9]+";
            this.textEditQRWidth.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditQRWidth.Properties.Mask.ShowPlaceHolders = false;
            this.textEditQRWidth.Size = new System.Drawing.Size(75, 20);
            this.textEditQRWidth.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(198, 134);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 13);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Height:";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(108, 134);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Width:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(11, 9);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Content:";
            // 
            // memoEditQRContent
            // 
            this.memoEditQRContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memoEditQRContent.Location = new System.Drawing.Point(9, 25);
            this.memoEditQRContent.Name = "memoEditQRContent";
            this.memoEditQRContent.Size = new System.Drawing.Size(362, 101);
            this.memoEditQRContent.TabIndex = 2;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.memoEditDecodeResult);
            this.xtraTabPage2.Controls.Add(this.simpleButtonSelectImageDecode);
            this.xtraTabPage2.Controls.Add(this.labelControl2);
            this.xtraTabPage2.Controls.Add(this.labelControl1);
            this.xtraTabPage2.Controls.Add(this.simpleButtonDecode);
            this.xtraTabPage2.Controls.Add(this.textEditQRFileLocationDecode);
            this.xtraTabPage2.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(380, 225);
            this.xtraTabPage2.Text = "QR Code Reader";
            // 
            // memoEditDecodeResult
            // 
            this.memoEditDecodeResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memoEditDecodeResult.Location = new System.Drawing.Point(9, 90);
            this.memoEditDecodeResult.Name = "memoEditDecodeResult";
            this.memoEditDecodeResult.Size = new System.Drawing.Size(362, 78);
            this.memoEditDecodeResult.TabIndex = 2;
            // 
            // simpleButtonSelectImageDecode
            // 
            this.simpleButtonSelectImageDecode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonSelectImageDecode.Location = new System.Drawing.Point(347, 30);
            this.simpleButtonSelectImageDecode.Name = "simpleButtonSelectImageDecode";
            this.simpleButtonSelectImageDecode.Size = new System.Drawing.Size(27, 20);
            this.simpleButtonSelectImageDecode.TabIndex = 1;
            this.simpleButtonSelectImageDecode.Text = "...";
            this.simpleButtonSelectImageDecode.Click += new System.EventHandler(this.simpleButtonSelectImageDecode_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(9, 74);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Result:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(9, 14);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Image Location:";
            // 
            // simpleButtonDecode
            // 
            this.simpleButtonDecode.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.simpleButtonDecode.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonDecode.Image")));
            this.simpleButtonDecode.Location = new System.Drawing.Point(143, 186);
            this.simpleButtonDecode.Name = "simpleButtonDecode";
            this.simpleButtonDecode.Size = new System.Drawing.Size(94, 28);
            this.simpleButtonDecode.TabIndex = 3;
            this.simpleButtonDecode.Text = "Decode";
            this.simpleButtonDecode.Click += new System.EventHandler(this.simpleButtonDecode_Click);
            // 
            // textEditQRFileLocationDecode
            // 
            this.textEditQRFileLocationDecode.AllowDrop = true;
            this.textEditQRFileLocationDecode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditQRFileLocationDecode.Location = new System.Drawing.Point(9, 30);
            this.textEditQRFileLocationDecode.Name = "textEditQRFileLocationDecode";
            this.textEditQRFileLocationDecode.Size = new System.Drawing.Size(334, 20);
            this.textEditQRFileLocationDecode.TabIndex = 0;
            this.textEditQRFileLocationDecode.DragDrop += new System.Windows.Forms.DragEventHandler(this.textEditQRFileLocationDecode_DragDrop);
            this.textEditQRFileLocationDecode.DragEnter += new System.Windows.Forms.DragEventHandler(this.textEditQRFileLocationDecode_DragEnter);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 256);
            this.Controls.Add(this.xtraTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "FB-Office2010Silver";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(200, 250);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Workshop";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditQRHeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditQRWidth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditQRContent.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditDecodeResult.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditQRFileLocationDecode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDecode;
        private DevExpress.XtraEditors.TextEdit textEditQRFileLocationDecode;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSelectImageDecode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit memoEditDecodeResult;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonQRGenerate;
        private DevExpress.XtraEditors.TextEdit textEditQRHeight;
        private DevExpress.XtraEditors.TextEdit textEditQRWidth;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit memoEditQRContent;
    }
}

