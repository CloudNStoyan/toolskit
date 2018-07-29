namespace ToolsKit
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lengthOfTextBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hideOrShowCheckBox = new System.Windows.Forms.CheckBox();
            this.uploadToImgurBtn = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lengthOfTextBtn
            // 
            this.lengthOfTextBtn.Location = new System.Drawing.Point(12, 38);
            this.lengthOfTextBtn.Name = "lengthOfTextBtn";
            this.lengthOfTextBtn.Size = new System.Drawing.Size(108, 23);
            this.lengthOfTextBtn.TabIndex = 0;
            this.lengthOfTextBtn.Text = "Length Of Text";
            this.lengthOfTextBtn.UseVisualStyleBackColor = true;
            this.lengthOfTextBtn.Click += new System.EventHandler(this.RunLengthOfText);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Settings:";
            // 
            // hideOrShowCheckBox
            // 
            this.hideOrShowCheckBox.AutoSize = true;
            this.hideOrShowCheckBox.Location = new System.Drawing.Point(66, 9);
            this.hideOrShowCheckBox.Name = "hideOrShowCheckBox";
            this.hideOrShowCheckBox.Size = new System.Drawing.Size(109, 17);
            this.hideOrShowCheckBox.TabIndex = 2;
            this.hideOrShowCheckBox.Text = "Hide When Open";
            this.hideOrShowCheckBox.UseVisualStyleBackColor = true;
            // 
            // uploadToImgurBtn
            // 
            this.uploadToImgurBtn.Location = new System.Drawing.Point(126, 38);
            this.uploadToImgurBtn.Name = "uploadToImgurBtn";
            this.uploadToImgurBtn.Size = new System.Drawing.Size(108, 23);
            this.uploadToImgurBtn.TabIndex = 3;
            this.uploadToImgurBtn.Text = "Upload Image";
            this.uploadToImgurBtn.UseVisualStyleBackColor = true;
            this.uploadToImgurBtn.Click += new System.EventHandler(this.RunUploadToImgur);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Kit Tools is running in the background!";
            this.notifyIcon.BalloonTipTitle = "Kit Tools Warning!";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "KitTools";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIconClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "YT Downloader";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.RunYoutubeDownloader);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "YT Audio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.RunYoutubeAudio);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 97);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Remove Passagers";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.RunRemovePassagers);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uploadToImgurBtn);
            this.Controls.Add(this.hideOrShowCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lengthOfTextBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Stoyan\'s Kit Tools";
            this.Resize += new System.EventHandler(this.MinimizeToTray);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lenghtOfTextBtn;
        private System.Windows.Forms.Button lengthOfTextBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox hideOrShowCheckBox;
        private System.Windows.Forms.Button uploadToImgurBtn;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

