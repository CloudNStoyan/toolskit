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
        private ContextMenu menu = new ContextMenu();

        public MainForm()
        {
            InitializeComponent();
            if (!Directory.Exists(mainFolderPath))
            {
                Directory.CreateDirectory(mainFolderPath);
            }

            menu.MenuItems.Add("Exit");
            menu.MenuItems[0].Click += MenuItemMethods.Exit;
            notifyIcon.ContextMenu = menu;
        }

        private void MinimizeToTray(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(3000);
                this.ShowInTaskbar = false;
            }
        }

        private void NotifyIconClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon.Visible = false;
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

        private void RunYoutubeDownloader(object sender, EventArgs e)
        {
            BeforeRunning();

            YoutubeDownloader form = new YoutubeDownloader();
            form.Show();
        }
    }
}
