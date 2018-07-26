namespace ToolsKit
{
    partial class YoutubeDownloader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoutubeDownloader));
            this.youtubeUrl = new System.Windows.Forms.TextBox();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.formatList = new System.Windows.Forms.ComboBox();
            this.thumbnailBox = new System.Windows.Forms.PictureBox();
            this.currentProcessInformation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailBox)).BeginInit();
            this.SuspendLayout();
            // 
            // youtubeUrl
            // 
            this.youtubeUrl.Location = new System.Drawing.Point(13, 13);
            this.youtubeUrl.Name = "youtubeUrl";
            this.youtubeUrl.Size = new System.Drawing.Size(204, 20);
            this.youtubeUrl.TabIndex = 0;
            this.youtubeUrl.TextChanged += new System.EventHandler(this.youtubeUrl_TextChanged);
            // 
            // downloadBtn
            // 
            this.downloadBtn.Location = new System.Drawing.Point(223, 13);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(121, 23);
            this.downloadBtn.TabIndex = 1;
            this.downloadBtn.Text = "Download";
            this.downloadBtn.UseVisualStyleBackColor = true;
            this.downloadBtn.Click += new System.EventHandler(this.Download);
            // 
            // formatList
            // 
            this.formatList.FormattingEnabled = true;
            this.formatList.Location = new System.Drawing.Point(223, 42);
            this.formatList.Name = "formatList";
            this.formatList.Size = new System.Drawing.Size(121, 21);
            this.formatList.TabIndex = 2;
            // 
            // thumbnailBox
            // 
            this.thumbnailBox.Location = new System.Drawing.Point(13, 39);
            this.thumbnailBox.Name = "thumbnailBox";
            this.thumbnailBox.Size = new System.Drawing.Size(204, 204);
            this.thumbnailBox.TabIndex = 3;
            this.thumbnailBox.TabStop = false;
            // 
            // currentProcessInformation
            // 
            this.currentProcessInformation.AutoSize = true;
            this.currentProcessInformation.Location = new System.Drawing.Point(223, 70);
            this.currentProcessInformation.Name = "currentProcessInformation";
            this.currentProcessInformation.Size = new System.Drawing.Size(0, 13);
            this.currentProcessInformation.TabIndex = 4;
            // 
            // YoutubeDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 276);
            this.Controls.Add(this.currentProcessInformation);
            this.Controls.Add(this.thumbnailBox);
            this.Controls.Add(this.formatList);
            this.Controls.Add(this.downloadBtn);
            this.Controls.Add(this.youtubeUrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YoutubeDownloader";
            this.Text = "YoutubeDownloader";
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox youtubeUrl;
        private System.Windows.Forms.Button downloadBtn;
        private System.Windows.Forms.ComboBox formatList;
        private System.Windows.Forms.PictureBox thumbnailBox;
        private System.Windows.Forms.Label currentProcessInformation;
    }
}