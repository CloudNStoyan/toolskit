namespace ToolsKit
{
    partial class UploadToImgur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadToImgur));
            this.uploadFromClipboardBtn = new System.Windows.Forms.Button();
            this.uploadFromFolderBtn = new System.Windows.Forms.Button();
            this.uploadFromUrlBtn = new System.Windows.Forms.Button();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.uploadFromUrlTextBox = new System.Windows.Forms.TextBox();
            this.uploadFromUrlSecondBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uploadFromClipboardBtn
            // 
            this.uploadFromClipboardBtn.Location = new System.Drawing.Point(12, 12);
            this.uploadFromClipboardBtn.Name = "uploadFromClipboardBtn";
            this.uploadFromClipboardBtn.Size = new System.Drawing.Size(150, 23);
            this.uploadFromClipboardBtn.TabIndex = 0;
            this.uploadFromClipboardBtn.Text = "Upload From Clipboard";
            this.uploadFromClipboardBtn.UseVisualStyleBackColor = true;
            this.uploadFromClipboardBtn.Click += new System.EventHandler(this.UploadFromClipboard);
            // 
            // uploadFromFolderBtn
            // 
            this.uploadFromFolderBtn.Location = new System.Drawing.Point(168, 12);
            this.uploadFromFolderBtn.Name = "uploadFromFolderBtn";
            this.uploadFromFolderBtn.Size = new System.Drawing.Size(150, 23);
            this.uploadFromFolderBtn.TabIndex = 1;
            this.uploadFromFolderBtn.Text = "Upload From Folder";
            this.uploadFromFolderBtn.UseVisualStyleBackColor = true;
            this.uploadFromFolderBtn.Click += new System.EventHandler(this.UploadFromFolder);
            // 
            // uploadFromUrlBtn
            // 
            this.uploadFromUrlBtn.Location = new System.Drawing.Point(324, 12);
            this.uploadFromUrlBtn.Name = "uploadFromUrlBtn";
            this.uploadFromUrlBtn.Size = new System.Drawing.Size(150, 23);
            this.uploadFromUrlBtn.TabIndex = 2;
            this.uploadFromUrlBtn.Text = "Upload From Url";
            this.uploadFromUrlBtn.UseVisualStyleBackColor = true;
            this.uploadFromUrlBtn.Click += new System.EventHandler(this.UploadFromUrl);
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(13, 43);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(311, 20);
            this.urlBox.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(325, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // uploadFromUrlTextBox
            // 
            this.uploadFromUrlTextBox.Location = new System.Drawing.Point(481, 14);
            this.uploadFromUrlTextBox.Name = "uploadFromUrlTextBox";
            this.uploadFromUrlTextBox.Size = new System.Drawing.Size(308, 20);
            this.uploadFromUrlTextBox.TabIndex = 5;
            // 
            // uploadFromUrlSecondBtn
            // 
            this.uploadFromUrlSecondBtn.Location = new System.Drawing.Point(796, 13);
            this.uploadFromUrlSecondBtn.Name = "uploadFromUrlSecondBtn";
            this.uploadFromUrlSecondBtn.Size = new System.Drawing.Size(75, 23);
            this.uploadFromUrlSecondBtn.TabIndex = 6;
            this.uploadFromUrlSecondBtn.Text = "Upload";
            this.uploadFromUrlSecondBtn.UseVisualStyleBackColor = true;
            this.uploadFromUrlSecondBtn.Click += new System.EventHandler(this.UploadToImgurByUrl);
            // 
            // UploadToImgur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 75);
            this.Controls.Add(this.uploadFromUrlSecondBtn);
            this.Controls.Add(this.uploadFromUrlTextBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.uploadFromUrlBtn);
            this.Controls.Add(this.uploadFromFolderBtn);
            this.Controls.Add(this.uploadFromClipboardBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UploadToImgur";
            this.Text = "Imgur Uploader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadFromClipboardBtn;
        private System.Windows.Forms.Button uploadFromFolderBtn;
        private System.Windows.Forms.Button uploadFromUrlBtn;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox uploadFromUrlTextBox;
        private System.Windows.Forms.Button uploadFromUrlSecondBtn;
    }
}