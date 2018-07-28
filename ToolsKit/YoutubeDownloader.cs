using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaToolkit;
using MediaToolkit.Model;
using VideoLibrary;

namespace ToolsKit
{
    public partial class YoutubeDownloader : Form
    {
        private readonly string mainFolderPath = @"C:\Users\" + Environment.UserName + @"\Documents\ToolsKit\YoutubeDownloader";

        public YoutubeDownloader()
        {
            InitializeComponent();

            if (!Directory.Exists(mainFolderPath))
            {
                Directory.CreateDirectory(mainFolderPath);
            }

            object[] items = {"MP3", "MP4",};
            this.formatList.Items.AddRange(items);
            this.formatList.SelectedIndex = 1;
        }

        private void Download(object sender, EventArgs e)
        {
            Uri url = new Uri(youtubeUrl.Text);

            if (url.Host != "www.youtube.com" && url.Host != "youtu.be")
            {
                MessageBox.Show(@"The url must be from www.youtube.com");
                return;
            }

            if (this.formatList.SelectedIndex == -1)
            {
                MessageBox.Show(@"You must select file format!");
                return;
            }

            currentProcessInformation.Text = @"Loading...";

            var source = mainFolderPath + @"\";
            var youtube = YouTube.Default;
            var vid = youtube.GetVideo(youtubeUrl.Text);
            string vidName = FilterYoutubeName(vid.FullName);

            File.WriteAllBytes(source + vidName, vid.GetBytes());

            if (this.formatList.SelectedIndex == 0)
            {
                ConvertToMp3(vid, source);
                File.Delete(source + vidName);
            }

            currentProcessInformation.Text = @"Downloaded!";
        }

        private void ConvertToMp3(YouTubeVideo vid, string source)
        {
            string vidName = FilterYoutubeName(vid.FullName);

            var inputFile = new MediaFile {Filename = source + vidName};
            var outputFile = new MediaFile {Filename = $"{source + vidName}.mp3"};

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
            if (Uri.IsWellFormedUriString(youtubeUrl.Text, UriKind.Absolute))
            {
                Uri url = new Uri(youtubeUrl.Text);

                if (url.Host == "www.youtube.com" || url.Host == "youtu.be")
                {
                    string vidId = ExtractVideoIdFromUri(url);


                    this.thumbnailBox.ImageLocation = @"http://img.youtube.com/vi/" + vidId + @"/hqdefault.jpg";
                    this.thumbnailBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    MessageBox.Show(url.Host);
                }
            }
            else
            {

                this.thumbnailBox.Text = @"No video found!";
            }
        }

        private string ExtractVideoIdFromUri(Uri uri)
        {
            string YoutubeLinkRegex =
                "(?:.+?)?(?:\\/v\\/|watch\\/|\\?v=|\\&v=|youtu\\.be\\/|\\/v=|^youtu\\.be\\/)([a-zA-Z0-9_-]{11})+";
            Regex regexExtractId = new Regex(YoutubeLinkRegex, RegexOptions.Compiled);
            string[] validAuthorities = {"youtube.com", "www.youtube.com", "youtu.be", "www.youtu.be"};


            string authority = new UriBuilder(uri).Uri.Authority.ToLower();

            //check if the url is a youtube url
            if (validAuthorities.Contains(authority))
            {
                //and extract the id
                var regRes = regexExtractId.Match(uri.ToString());
                if (regRes.Success)
                {
                    return regRes.Groups[1].Value;
                }
            }


            return null;
        }
    }
}
