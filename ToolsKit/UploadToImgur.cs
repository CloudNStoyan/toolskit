using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolsKit
{
    public partial class UploadToImgur : Form
    {
        private string mainFolderPath = @"C:\Users\" + Environment.UserName + @"\Documents\ToolsKit\ImgurImages";
        public UploadToImgur()
        {
            InitializeComponent();

            uploadFromUrlTextBox.Visible = false;
            this.Width = 500;


            if (!Directory.Exists(mainFolderPath))
            {
                Directory.CreateDirectory(mainFolderPath);
            }
        }

        private void UploadFromClipboard(object sender, EventArgs e)
        {
            var image = Clipboard.GetImage();
            Upload(image);
        }

        private void UploadFromFolder(object sender, EventArgs e)
        {
            string imagePath = OpenFileDialog();
            if (imagePath != null)
            {
                PostToImgur(imagePath);
            }
            else
            {
                MessageBox.Show("You didn't choose file!");
            }
        }
        private void UploadFromUrl(object sender, EventArgs e)
        {

            uploadFromUrlTextBox.Visible = true;
            this.Width = 900;
        }

        private void UploadToImgurByUrl(object sender, EventArgs e)
        {
            string url = uploadFromUrlTextBox.Text;

            uploadFromUrlTextBox.Visible = false;
            this.Width = 500;

            using (WebClient client = new WebClient())
            {
                client.DownloadFile(url,"." + url.Split('.')[url.Split('.').Length - 1]);

            }
        }

        private string OpenFileDialog()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.InitialDirectory = @"C:\Users\" + Environment.UserName + @"\Desktop";
            fileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                return fileDialog.FileName;
            }

            return null;
        }

        private void Upload(Image image)
        {
            string imagePath = mainFolderPath + @"\temp.jpeg";
            image.Save(imagePath);
            PostToImgur(imagePath);
            File.Delete(imagePath);
        }

        private void PostToImgur(string imagFilePath)
        {
            string apiKey = "d067ccaa8eb748d";
            string apiSecret = "884c7a3199210fb58d82c96b9513eb6b3d4302bd";
            byte[] imageData;
            FileStream fileStream = File.OpenRead(imagFilePath);
            imageData = new byte[fileStream.Length];
            fileStream.Read(imageData, 0, imageData.Length);
            fileStream.Close();

            const int MAX_URI_LENGTH = 32766;
            string base64img = Convert.ToBase64String(imageData);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < base64img.Length; i += MAX_URI_LENGTH)
            {
                sb.Append(Uri.EscapeDataString(base64img.Substring(i, Math.Min(MAX_URI_LENGTH, base64img.Length - i))));
            }

            string uploadRequestString = "client_id" + apiKey + "client_secret" + apiSecret + "&title=" + "imageTitle" +
                                         "&caption=" + "img" + "&image=" + sb;

            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("https://api.imgur.com/3/upload.xml");

            webRequest.Headers.Add("Authorization", "Client-ID d067ccaa8eb748d");
            webRequest.Method = "POST";
            webRequest.ContentType = "application/x-www-form-urlencoded";
            webRequest.ServicePoint.Expect100Continue = false;

            StreamWriter streamWriter = new StreamWriter(webRequest.GetRequestStream());

            streamWriter.Write(uploadRequestString);
            streamWriter.Close();

            WebResponse response = webRequest.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader responseReader = new StreamReader(responseStream);
            string responseString = responseReader.ReadToEnd();



            Regex regex = new Regex("<link>(.*)</link>");
            urlBox.Text = regex.Match(responseString).Groups[1].ToString();
        }
    }
}
