using System;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Net;
using System.Windows;
using System.Xml.Linq;
using Microsoft.Phone.Scheduler;
using Microsoft.Phone.Shell;

namespace ScheduledTaskAgent1
{
    public class ScheduledAgent : ScheduledTaskAgent
    {
        // private string RssUrl = "http://dl.dropbox.com/u/45561962/therondels/xmlTherondels.xml";
        private const string RssUrl = "http://www.therondels.fr/feed/";
        private volatile bool classInitialized;
        private DateTime isolatedDate;

        public ScheduledAgent()
        {
            this.Settings = IsolatedStorageSettings.ApplicationSettings;
            if (!this.classInitialized)
            {
                this.classInitialized = true;
                Deployment.Current.Dispatcher.BeginInvoke(delegate
                {
                    Application.Current.UnhandledException += this.ScheduledAgent_UnhandledException;
                });
            }
        }

        private IsolatedStorageSettings Settings { get; set; }

        protected override void OnInvoke(ScheduledTask task)
        {

            if (this.Settings.Contains("mostRecentDate"))
            {
                this.isolatedDate = (DateTime)this.Settings["mostRecentDate"];
            }

            this.RequestXmlData();
        }

        private void ScheduledAgent_UnhandledException(object sender, ApplicationUnhandledExceptionEventArgs e)
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                // An unhandled exception has occurred; break into the debugger
                System.Diagnostics.Debugger.Break();
            }
        }

        private void RequestXmlData()
        {
            var request = (HttpWebRequest)WebRequest.Create(RssUrl);
            request.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.0)";
            request.ContentType = "application/x-www-form-urlencoded";
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.BeginGetResponse(this.ResponseCallback, request);
        }

        private void ResponseCallback(IAsyncResult result)
        {
            var request = (HttpWebRequest)result.AsyncState;
            try
            {
                XDocument xmlDoc;
                var response = request.EndGetResponse(result);
                using (var stream = response.GetResponseStream())
                {
                    xmlDoc = XDocument.Load(stream);
                }

                var allItems = from cat in xmlDoc.Descendants("item")
                               select new Champs()
                               {
                                   Title = HttpUtility.HtmlDecode((string)cat.Element("title")) ?? "",
                                   Description = HttpUtility.HtmlDecode((string)cat.Element("description")) ?? "",
                                   Link = HttpUtility.HtmlDecode((string)cat.Element("link")) ?? "",
                                   PubDate = HttpUtility.HtmlDecode((string)cat.Element("pubDate")) ?? "",
                               };

                var entries = allItems.ToList();
                var compareDate = DateTime.Parse(entries[0].PubDate);

                if (compareDate > this.isolatedDate || true)
                {
                    Deployment.Current.Dispatcher.BeginInvoke(
                        () =>
                        {
                            ShellTile app = ShellTile.ActiveTiles.First();
                            ShellTileData newApp = new StandardTileData()
                                                       {
                                                           Count = 1,
                                                           Title = ""
                                                       };
                            app.Update(newApp);
                            NotifyComplete();
                        });
                }
            }
            catch
            { }
        }
    }
}