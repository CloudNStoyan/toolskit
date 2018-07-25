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
using MediaToolkit;
using MediaToolkit.Model;
using VideoLibrary;

namespace ToolsKit
{
    public partial class YoutubeDownloader : Form
    {
        private string mainFolderPath = @"C:\Users\" + Environment.UserName + @"\Documents\ToolsKit\YoutubeDownloader";

        public YoutubeDownloader()
        {
            InitializeComponent();

            if (!Directory.Exists(mainFolderPath))
            {
                Directory.CreateDirectory(mainFolderPath);
            }

            string[] items = {"MP3","MP4",};
            this.formatList.Items.AddRange(items);
            this.formatList.SelectedIndex = 1;
        }

        private void Download(object sender, EventArgs e)
        {
            Uri url = new Uri(youtubeUrl.Text);

            if (url.Host != "www.youtube.com")
            {
                MessageBox.Show("The url must be from www.youtube.com");
                return;
            }
            else if (this.formatList.SelectedIndex == -1)
            {
                MessageBox.Show("You must select file format!");
                return;
            }


            var source = mainFolderPath + @"\";
            var youtube = YouTube.Default;
            var vid = youtube.GetVideo(youtubeUrl.Text);
            string vidName = FilterYoutubeName(vid.FullName);

            File.WriteAllBytes(source + vidName, vid.GetBytes());

            if (this.formatList.SelectedIndex == 0)
            {
                ConvertToMp3(vid,source);
                File.Delete(source + vidName);
            }

        }

        private void ConvertToMp3(YouTubeVideo vid,string source)
        {
            string vidName = FilterYoutubeName(vid.FullName);

            var inputFile = new MediaFile { Filename = source + vidName };
            var outputFile = new MediaFile { Filename = $"{source + vidName}.mp3" };

            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);

                engine.Convert(inputFile, outputFile);
            }
        }

        private string FilterYoutubeName(string name)
        {
            name = name.Replace(" ", "_");

            return name;
        }

        private void youtubeUrl_TextChanged(object sender, EventArgs e)
        {
            if (Uri.IsWellFormedUriString(youtubeUrl.Text,UriKind.Absolute))
            {
                Uri url = new Uri(youtubeUrl.Text);

                if (url.Host == "www.youtube.com")
                {
                    string vidId = this.youtubeUrl.Text.Split('=')[1];

                    this.thumbnailBox.ImageLocation = "http://img.youtube.com/vi/" + vidId + "/hqdefault.jpg";
                    this.thumbnailBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            else
            {

                this.thumbnailBox.Text = "No video found!";
            }
        }
    }
    
       
}
