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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lengthOfTextBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hideOrShowCheckBox = new System.Windows.Forms.CheckBox();
            this.uploadToImgurBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lengthOfTextBtn
            // 
            this.lengthOfTextBtn.Location = new System.Drawing.Point(12, 38);
            this.lengthOfTextBtn.Name = "lengthOfTextBtn";
            this.lengthOfTextBtn.Size = new System.Drawing.Size(89, 23);
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
            this.uploadToImgurBtn.Location = new System.Drawing.Point(107, 38);
            this.uploadToImgurBtn.Name = "uploadToImgurBtn";
            this.uploadToImgurBtn.Size = new System.Drawing.Size(89, 23);
            this.uploadToImgurBtn.TabIndex = 3;
            this.uploadToImgurBtn.Text = "Upload Image";
            this.uploadToImgurBtn.UseVisualStyleBackColor = true;
            this.uploadToImgurBtn.Click += new System.EventHandler(this.RunUploadToImgur);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.uploadToImgurBtn);
            this.Controls.Add(this.hideOrShowCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lengthOfTextBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Stoyan\'s Kit Tools";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lenghtOfTextBtn;
        private System.Windows.Forms.Button lengthOfTextBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox hideOrShowCheckBox;
        private System.Windows.Forms.Button uploadToImgurBtn;
    }
}

