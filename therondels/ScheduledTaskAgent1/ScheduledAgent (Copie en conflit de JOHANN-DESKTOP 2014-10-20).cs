using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Threading;
using Microsoft.Phone.Scheduler;
using Microsoft.Phone.Shell;
using System.Xml.Linq;

namespace ScheduledTaskAgent1
{
    public class ScheduledAgent : ScheduledTaskAgent
    {
        private volatile bool _classInitialized;

        /// <remarks>
        /// ScheduledAgent constructor, initializes the UnhandledException handler
        /// </remarks>
        public ScheduledAgent()
        {
            if (!_classInitialized)
            {
                _classInitialized = true;
                // Subscribe to the managed exception handler
                Deployment.Current.Dispatcher.BeginInvoke(delegate
                {
                    Application.Current.UnhandledException += ScheduledAgent_UnhandledException;
                });
            }
        }

        /// Code to execute on Unhandled Exceptions
        private void ScheduledAgent_UnhandledException(object sender, ApplicationUnhandledExceptionEventArgs e)
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                // An unhandled exception has occurred; break into the debugger
                System.Diagnostics.Debugger.Break();
            }
        }

        /// <summary>
        /// Agent that runs a scheduled task
        /// </summary>
        /// <param name="task">
        /// The invoked task
        /// </param>
        /// <remarks>
        /// This method is called when a periodic or resource intensive task is invoked
        /// </remarks>
        public IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;
        //public string RssUrl = "http://dl.dropbox.com/u/45561962/therondels/xmlTherondels.xml";
        public string RssUrl = "http://www.therondels.fr/feed/rss/";
        private DateTime isolatedDate;
        private DateTime compareDate;

        protected override void OnInvoke(ScheduledTask task)
        {

            if (settings.Contains("mostRecentDate"))
            {
                isolatedDate = (DateTime)settings["mostRecentDate"];
            }
            RequestXMLData();
        }

        public void RequestXMLData()
        {
            var request = (HttpWebRequest)WebRequest.Create(RssUrl);
            request.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.0)";
            request.ContentType = "application/x-www-form-urlencoded";
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.BeginGetResponse(ResponseCallback, request);
        }
        

        private void ResponseCallback(IAsyncResult result)
        {
            var request = (HttpWebRequest)result.AsyncState;
            try
            {
                XDocument xmlDoc = new XDocument();
                var response = request.EndGetResponse(result);
                using (var stream = response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    xmlDoc = XDocument.Load(stream);
                }

                var allItems = from cat in xmlDoc.Descendants("item")
                               select new champs()
                               {
                                   title = HttpUtility.HtmlDecode((string)cat.Element("title")) ?? String.Empty,
                                   description = HttpUtility.HtmlDecode((string)cat.Element("description")) ?? String.Empty,
                                   link = HttpUtility.HtmlDecode((string)cat.Element("link")) ?? String.Empty,
                                   pubDate = HttpUtility.HtmlDecode((string)cat.Element("pubDate")) ?? String.Empty,
                               };

                List<champs> Entries = new List<champs>();
                foreach (var element in allItems)
                {
                    Entries.Add(element);
                }
                compareDate = DateTime.Parse(Entries[0].pubDate);


                if (compareDate != null)
                {
                    if (compareDate > isolatedDate)
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
                            }
                          );
                    }
                    
                }
            }
            catch
            {

            }
        }
    }

    public class champs
    {
        public string title { get; set; }
        public string description { get; set; }
        public string link { get; set; }
        public string pubDate { get; set; }
    }
}