using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Net.NetworkInformation;
using HtmlAgilityPack;

using NetworkInterface = System.Net.NetworkInformation.NetworkInterface;

namespace Therondels
{
    public partial class NewsArticlePage
    {
        private Article article = new Article();
        private bool exception; 

        public NewsArticlePage()
        {
            this.InitializeComponent();
            Settings = IsolatedStorageSettings.ApplicationSettings;
            this.article = new Article()
                               {
                                   Author = "",
                                   Title = "",
                                   Date = DateTime.Now,
                                   Pictures = new List<string>(),
                                   HtmlContent = "",
                                   Url = ""
                               };
        }

        private static IsolatedStorageSettings Settings { get; set; }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string url;
            NavigationContext.QueryString.TryGetValue("selectedItem", out url);
            this.article.Url = url;
            
            foreach (var v in Settings.Where(v => v.Value is Article).Where(v => ((Article)v.Value).Url == this.article.Url))
            {
                this.article.Title = ((Article)v.Value).Title;
                break;
            }

            this.DownloadArticle(this.article.Url);
        }

        private void DownloadArticle(string url)
        {
            WebClient client = new WebClient();
            client.DownloadStringAsync(new Uri(url));
            client.DownloadStringCompleted += Client_DownloadStringCompleted;

            //var hw = new HtmlWeb();
            //hw.LoadAsync(url);
            //hw.LoadCompleted += this.DownloadArticleCompleted;
        }

        private void Client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (e.Result == null)
            {
                if (Settings.Contains("article" + this.article.Title))
                {
                    // Get the article to display from local
                    this.article = (Article)Settings["article" + this.article.Title];
                    this.DisplayArticleData();
                }
                else
                {
                    NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
                }
            }
            else
            {
                var stream = new MemoryStream(Encoding.UTF8.GetBytes(e.Result));
                HtmlDocument doc = new HtmlDocument();
                doc.Load(stream);

                try
                {
                    if (doc.DocumentNode != null)
                    {
                        foreach (var htmlNode in doc.DocumentNode.Descendants().ToList())
                        {
                            // Find the title of the news
                            if (htmlNode.GetAttributeValue("class", "") == "entry-title")
                            {
                                this.article.Title = HttpUtility.HtmlDecode(htmlNode.InnerText);
                            }

                            // Find the published date of the news
                            if (htmlNode.GetAttributeValue("class", "") == "entry-time")
                            {
                                this.article.Date = DateTime.Parse(htmlNode.InnerText, new CultureInfo("fr-FR"));
                            }

                            // Find the author of the news
                            if (htmlNode.GetAttributeValue("class", "") == "entry-author")
                            {
                                this.article.Author = htmlNode.InnerText;
                            }

                            // Find the content of the news
                            if (htmlNode.GetAttributeValue("class", "") == "entry-content")
                            {
                                var divList = htmlNode.Descendants().Where(item => item.Name == "div").ToList();

                                foreach (
                                    var node in
                                        divList.Where(
                                            node =>
                                            node.Attributes["class"] != null
                                            && node.Attributes["class"].Value == "sharedaddy sd-sharing-enabled"))
                                {
                                    node.Remove();
                                }

                                this.article.HtmlContent = htmlNode.InnerHtml;

                                // Find the pictures
                                var y = htmlNode.Descendants().ToList();
                                this.article.Pictures = new List<string>();
                                foreach (var node in y)
                                {
                                    if (node.Attributes.Contains("src"))
                                    {
                                        bool pictureFind = false;
                                        if (node.Attributes.Contains("data-large-file"))
                                        {
                                            if (node.Attributes["data-large-file"].Value.Contains(".jpg")
                                                && node.Attributes["data-large-file"].Value.StartsWith(
                                                    "http://www.therondels.fr/"))
                                            {
                                                this.article.Pictures.Add(node.Attributes["data-large-file"].Value);
                                                pictureFind = true;
                                            }
                                        }
                                        else if (node.ParentNode.Attributes.Contains("href"))
                                        {
                                            if (node.ParentNode.Attributes["href"].Value.Contains(".jpg")
                                                && node.ParentNode.Attributes["href"].Value.StartsWith(
                                                    "http://www.therondels.fr/"))
                                            {
                                                this.article.Pictures.Add(node.ParentNode.Attributes["href"].Value);
                                                pictureFind = true;
                                            }
                                        }

                                        if (node.GetAttributeValue("src", "").StartsWith("http://www.therondels.fr/")
                                            && pictureFind == false)
                                        {
                                            this.article.Pictures.Add(node.GetAttributeValue("src", ""));
                                        }
                                    }
                                }
                            }
                        }
                    }

                    if (Settings.Contains("article" + this.article.Title))
                    {
                        Settings.Remove("article" + this.article.Title);
                    }

                    Settings.Add("article" + this.article.Title, this.article);
                    this.DisplayArticleData();
                }
                catch (Exception)
                {
                    if (this.exception == false)
                    {
                        this.exception = true;
                        NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
                    }
                }

            }
        }

        private void DisplayArticleData()
        {
            if (this.article != null)
            {
                textBlockTitle.Text = this.article.Title;
                this.article.Title = this.article.Title;
                textBlockDate.Text = "Le " + this.article.Date.ToString("D", new CultureInfo("fr-FR"));
                textBlockAuthor.Text = "Par " + this.article.Author;
                if (this.article.HtmlContent != null)
                {
                    var htmlScript = "<script>function getDocHeight() { " +
                                    "return document.getElementById('pageWrapper').offsetHeight;" +
                                    "}" +
                                    "function SendDataToPhoneApp() {" +
                                    "window.external.Notify('' + getDocHeight());" +
                                    "}</script>";

                    var htmlConcat = string.Format("<html><head>{0}</head>" +
                                    "<body " +
                                    "onLoad=\"SendDataToPhoneApp()\">" +
                                    "<div id=\"pageWrapper\">{1}</div></body></html>",
                                    htmlScript,
                                    this.article.HtmlContent);

                    WebBrowser.NavigateToString(htmlConcat);    
                }
                else
                {
                    WebBrowser.NavigateToString("Connectez-vous à internet pour afficher cet article.");
                }
                
                if (this.article.Pictures != null)
                {
                    if (this.article.Pictures.Count > 0)
                    {
                        this.DisplayPictures();
                    }
                }
                else
                {
                    textBlockPhotos.Visibility = Visibility.Visible;
                }
            }
        }

        private void DisplayPictures()
        {
            var i = 1;
            foreach (var picture in this.article.Pictures)
            {
                var uri = !this.article.Pictures[0].Contains("http://")
                          ? new Uri(picture, UriKind.Relative)
                          : new Uri(picture, UriKind.Absolute);

                ImageSource imgSource = new BitmapImage(uri);
                var pictNumber = "picture" + i;
                if (picture1.Name == pictNumber)
                {
                    picture1.Source = imgSource;
                }
                else if (this.article.Pictures.Count < 1)
                {
                    picture1.Visibility = Visibility.Collapsed;
                }

                if (picture2.Name == pictNumber)
                {
                    picture2.Source = imgSource;
                }
                else if (this.article.Pictures.Count < 2)
                {
                    picture2.Visibility = Visibility.Collapsed;
                }

                if (picture3.Name == pictNumber)
                {
                    picture3.Source = imgSource;
                }
                else if (this.article.Pictures.Count < 3)
                {
                    picture3.Visibility = System.Windows.Visibility.Collapsed;
                }

                if (picture4.Name == pictNumber)
                {
                    picture4.Source = imgSource;
                }
                else if (this.article.Pictures.Count < 4)
                {
                    picture4.Visibility = System.Windows.Visibility.Collapsed;
                }

                if (picture5.Name == pictNumber)
                {
                    picture5.Source = imgSource;
                }
                else if (this.article.Pictures.Count < 5)
                {
                    picture5.Visibility = System.Windows.Visibility.Collapsed;
                }

                if (picture6.Name == pictNumber)
                {
                    picture6.Source = imgSource;
                }
                else if (this.article.Pictures.Count < 6)
                {
                    picture6.Visibility = System.Windows.Visibility.Collapsed;
                }

                if (picture7.Name == pictNumber)
                {
                    picture7.Source = imgSource;
                }
                else if (this.article.Pictures.Count < 7)
                {
                    picture7.Visibility = System.Windows.Visibility.Collapsed;
                }

                if (picture8.Name == pictNumber)
                {
                    picture8.Source = imgSource;
                }
                else if (this.article.Pictures.Count < 8)
                {
                    picture8.Visibility = System.Windows.Visibility.Collapsed;
                }

                if (picture9.Name == pictNumber)
                {
                    picture9.Source = imgSource;
                }
                else if (this.article.Pictures.Count < 9)
                {
                    picture9.Visibility = System.Windows.Visibility.Collapsed;
                }

                if (picture10.Name == pictNumber)
                {
                    picture10.Source = imgSource;
                }
                else if (this.article.Pictures.Count < 10)
                {
                    picture10.Visibility = System.Windows.Visibility.Collapsed;
                }

                if (picture11.Name == pictNumber)
                {
                    picture11.Source = imgSource;
                }
                else if (this.article.Pictures.Count < 11)
                {
                    picture11.Visibility = System.Windows.Visibility.Collapsed;
                }

                if (picture12.Name == pictNumber)
                {
                    picture12.Source = imgSource;
                }
                else if (this.article.Pictures.Count < 12)
                {
                    picture12.Visibility = System.Windows.Visibility.Collapsed;
                }

                if (picture13.Name == pictNumber)
                {
                    picture13.Source = imgSource;
                }
                else if (this.article.Pictures.Count < 13)
                {
                    picture13.Visibility = System.Windows.Visibility.Collapsed;
                }

                if (picture14.Name == pictNumber)
                {
                    picture14.Source = imgSource;
                }
                else if (this.article.Pictures.Count < 14)
                {
                    picture14.Visibility = System.Windows.Visibility.Collapsed;
                }

                if (picture15.Name == pictNumber)
                {
                    picture15.Source = imgSource;
                }
                else if (this.article.Pictures.Count < 15)
                {
                    picture15.Visibility = System.Windows.Visibility.Collapsed;
                }

                if (picture16.Name == pictNumber)
                {
                    picture16.Source = imgSource;
                }
                else if (this.article.Pictures.Count < 16)
                {
                    picture16.Visibility = System.Windows.Visibility.Collapsed;
                }

                if (picture17.Name == pictNumber)
                {
                    picture17.Source = imgSource;
                }
                else if (this.article.Pictures.Count < 17)
                {
                    picture17.Visibility = System.Windows.Visibility.Collapsed;
                }

                if (picture18.Name == pictNumber)
                {
                    picture18.Source = imgSource;
                }
                else if (this.article.Pictures.Count < 18)
                {
                    picture18.Visibility = System.Windows.Visibility.Collapsed;
                }

                if (picture19.Name == pictNumber)
                {
                    picture19.Source = imgSource;
                }
                else if (this.article.Pictures.Count < 19)
                {
                    picture19.Visibility = System.Windows.Visibility.Collapsed;
                }

                if (picture20.Name == pictNumber)
                {
                    picture20.Source = imgSource;
                }
                else if (this.article.Pictures.Count < 20)
                {
                    picture20.Visibility = System.Windows.Visibility.Collapsed;
                }

                if (picture21.Name == pictNumber)
                {
                    picture21.Source = imgSource;
                }
                else if (this.article.Pictures.Count < 21)
                {
                    picture21.Visibility = System.Windows.Visibility.Collapsed;
                }

                if (picture22.Name == pictNumber)
                {
                    picture22.Source = imgSource;
                }
                else if (this.article.Pictures.Count < 22)
                {
                    picture22.Visibility = System.Windows.Visibility.Collapsed;
                }

                if (picture23.Name == pictNumber)
                {
                    picture23.Source = imgSource;
                }
                else if (this.article.Pictures.Count < 23)
                {
                    picture23.Visibility = Visibility.Collapsed;
                }

                if (picture24.Name == pictNumber)
                {
                    picture24.Source = imgSource;
                }
                else if (this.article.Pictures.Count < 24)
                {
                    picture24.Visibility = Visibility.Collapsed;
                }

                i++;
            }
        }

        private void Touch(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var position = 0;

            // Find the position of the selected image
            try
            {
                var image = (Image)e.OriginalSource;
                var source = (BitmapImage)image.Source;
                var uriSource = source.UriSource.ToString().StartsWith("http://") ? source.UriSource.OriginalString : source.UriSource.ToString();
                position += ((Article)Settings["article" + this.article.Title]).Pictures.TakeWhile(imageOfArticle => uriSource != imageOfArticle).Count();
            }
            catch (Exception)
            {
            }

            // Navigate to the slideshow page, sending the article title and the position selected
            NavigationService.Navigate(new Uri("/SlideShow.xaml?selectedItem=" + this.article.Title + "~" + position, UriKind.Relative));
        }

        private void WebBrowser_OnScriptNotify(object sender, NotifyEventArgs e)
        {
            this.TransparentGrid.Height = Convert.ToInt32(e.Value);
        }
    }
}