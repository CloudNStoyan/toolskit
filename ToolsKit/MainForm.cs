using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolsKit
{
    public partial class MainForm : Form
    {
        string mainFolderPath = @"C:\Users\"+ Environment.UserName + @"\Documents\ToolsKit";
        public MainForm()
        {
            InitializeComponent();
            if (!Directory.Exists(mainFolderPath))
            {
                Directory.CreateDirectory(mainFolderPath);
            }
        }

        private void BeforeRunning()
        {
            if (hideOrShowCheckBox.Checked)
            {
                this.Hide();
            }
        }

        private void RunLengthOfText(object sender, EventArgs e)
        {
            BeforeRunning();

            LengthOfTextForm form = new LengthOfTextForm();
            form.Show();
        }

        private void RunUploadToImgur(object sender, EventArgs e)
        {
            BeforeRunning();

            UploadToImgur form = new UploadToImgur();
            form.Show();
        }
    }
}
