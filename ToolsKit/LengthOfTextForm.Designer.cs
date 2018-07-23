namespace ToolsKit
{
    partial class LengthOfTextForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LengthOfTextForm));
            this.textLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.textLenghtLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(13, 13);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(31, 13);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "Text:";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(13, 42);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(43, 13);
            this.lengthLabel.TabIndex = 1;
            this.lengthLabel.Text = "Length:";
            // 
            // mainTextBox
            // 
            this.mainTextBox.Location = new System.Drawing.Point(51, 13);
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(239, 20);
            this.mainTextBox.TabIndex = 2;
            this.mainTextBox.TextChanged += new System.EventHandler(this.mainTextBox_TextChanged);
            // 
            // textLenghtLabel
            // 
            this.textLenghtLabel.AutoSize = true;
            this.textLenghtLabel.Location = new System.Drawing.Point(62, 42);
            this.textLenghtLabel.Name = "textLenghtLabel";
            this.textLenghtLabel.Size = new System.Drawing.Size(13, 13);
            this.textLenghtLabel.TabIndex = 3;
            this.textLenghtLabel.Text = "0";
            // 
            // LengthOfTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 86);
            this.Controls.Add(this.textLenghtLabel);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.textLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LengthOfTextForm";
            this.Text = "Text Length";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.TextBox mainTextBox;
        private System.Windows.Forms.Label textLenghtLabel;
    }
}