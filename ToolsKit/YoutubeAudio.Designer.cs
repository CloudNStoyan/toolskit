namespace ToolsKit
{
    partial class YoutubeAudio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoutubeAudio));
            this.urlBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.controlsGroupBox = new System.Windows.Forms.GroupBox();
            this.playButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.thumbnailBox = new System.Windows.Forms.PictureBox();
            this.infoBox = new System.Windows.Forms.GroupBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.infoTitle = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.infoAuthor = new System.Windows.Forms.Label();
            this.infoDuration = new System.Windows.Forms.Label();
            this.controlsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailBox)).BeginInit();
            this.infoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(53, 12);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(430, 20);
            this.urlBox.TabIndex = 0;
            this.urlBox.TextChanged += new System.EventHandler(this.urlBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL: ";
            // 
            // controlsGroupBox
            // 
            this.controlsGroupBox.Controls.Add(this.pauseButton);
            this.controlsGroupBox.Controls.Add(this.playButton);
            this.controlsGroupBox.Location = new System.Drawing.Point(12, 299);
            this.controlsGroupBox.Name = "controlsGroupBox";
            this.controlsGroupBox.Size = new System.Drawing.Size(471, 75);
            this.controlsGroupBox.TabIndex = 2;
            this.controlsGroupBox.TabStop = false;
            this.controlsGroupBox.Text = "Controls";
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(7, 20);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(88, 20);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 23);
            this.pauseButton.TabIndex = 1;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            // 
            // thumbnailBox
            // 
            this.thumbnailBox.Location = new System.Drawing.Point(12, 43);
            this.thumbnailBox.Name = "thumbnailBox";
            this.thumbnailBox.Size = new System.Drawing.Size(300, 250);
            this.thumbnailBox.TabIndex = 3;
            this.thumbnailBox.TabStop = false;
            // 
            // infoBox
            // 
            this.infoBox.Controls.Add(this.infoDuration);
            this.infoBox.Controls.Add(this.infoAuthor);
            this.infoBox.Controls.Add(this.durationLabel);
            this.infoBox.Controls.Add(this.authorLabel);
            this.infoBox.Controls.Add(this.infoTitle);
            this.infoBox.Controls.Add(this.titleLabel);
            this.infoBox.Location = new System.Drawing.Point(318, 43);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(165, 105);
            this.infoBox.TabIndex = 4;
            this.infoBox.TabStop = false;
            this.infoBox.Text = "Information";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(13, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            // 
            // infoTitle
            // 
            this.infoTitle.AutoSize = true;
            this.infoTitle.Location = new System.Drawing.Point(43, 20);
            this.infoTitle.Name = "infoTitle";
            this.infoTitle.Size = new System.Drawing.Size(0, 13);
            this.infoTitle.TabIndex = 1;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(13, 44);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(41, 13);
            this.authorLabel.TabIndex = 2;
            this.authorLabel.Text = "Author:";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(13, 71);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(50, 13);
            this.durationLabel.TabIndex = 3;
            this.durationLabel.Text = "Duration:";
            // 
            // infoAuthor
            // 
            this.infoAuthor.AutoSize = true;
            this.infoAuthor.Location = new System.Drawing.Point(60, 44);
            this.infoAuthor.Name = "infoAuthor";
            this.infoAuthor.Size = new System.Drawing.Size(0, 13);
            this.infoAuthor.TabIndex = 4;
            // 
            // infoDuration
            // 
            this.infoDuration.AutoSize = true;
            this.infoDuration.Location = new System.Drawing.Point(69, 71);
            this.infoDuration.Name = "infoDuration";
            this.infoDuration.Size = new System.Drawing.Size(0, 13);
            this.infoDuration.TabIndex = 5;
            // 
            // YoutubeAudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 384);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.thumbnailBox);
            this.Controls.Add(this.controlsGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YoutubeAudio";
            this.Text = "Youtube Audio";
            this.controlsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailBox)).EndInit();
            this.infoBox.ResumeLayout(false);
            this.infoBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox controlsGroupBox;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.PictureBox thumbnailBox;
        private System.Windows.Forms.GroupBox infoBox;
        private System.Windows.Forms.Label infoTitle;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label infoAuthor;
        private System.Windows.Forms.Label infoDuration;
    }
}