using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;

namespace ToolsKit
{
    public partial class YoutubeAudio : Form
    {
        private const string placeHolder = @"Enter url here...";

        public YoutubeAudio()
        {
            InitializeComponent();
            

            this.urlBox.Text = placeHolder;
            this.urlBox.GotFocus += RemovePlaceHolder;
            this.urlBox.LostFocus += AddPlaceHolder;
        }

        private void RemovePlaceHolder(object sender, EventArgs e)
        {
            if (this.urlBox.Text == placeHolder)
            {
                this.urlBox.Text = String.Empty;
            }
        }

        private void AddPlaceHolder(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.urlBox.Text))
            {
                this.urlBox.Text = placeHolder;
            }
        }

        private void urlBox_TextChanged(object sender, EventArgs e)
        {
            if(Uri.IsWellFormedUriString(urlBox.Text, UriKind.Absolute))
            {
                Uri url = new Uri(urlBox.Text);

                if (url.Host == "www.youtube.com" || url.Host == "youtu.be")
                {
                    string vidId = ExtractVideoIdFromUri(url);


                    this.thumbnailBox.ImageLocation = @"http://img.youtube.com/vi/" + vidId + @"/hqdefault.jpg";
                    this.thumbnailBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    return;
                }


                var youtube = YouTube.Default;
                var video = youtube.GetVideo(urlBox.Text);

            }


        }

        private string ExtractVideoIdFromUri(Uri uri)
        {
            string YoutubeLinkRegex =
                "(?:.+?)?(?:\\/v\\/|watch\\/|\\?v=|\\&v=|youtu\\.be\\/|\\/v=|^youtu\\.be\\/)([a-zA-Z0-9_-]{11})+";
            Regex regexExtractId = new Regex(YoutubeLinkRegex, RegexOptions.Compiled);
            string[] validAuthorities = { "youtube.com", "www.youtube.com", "youtu.be", "www.youtu.be" };


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
