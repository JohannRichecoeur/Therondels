using System;
using System.Collections.Generic;
using System.Device.Location;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Xml.Linq;
using Microsoft.Phone.Info;
using Microsoft.Phone.Scheduler;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;
using Therondels.ViewModels;

namespace Therondels
{
    public partial class MainPage
    {
        // public string RssUrl = "http://dl.dropbox.com/u/45561962/therondels/xmlTherondels.xml";
        private const string RssUrl = "http://www.therondels.fr/feed/";
        private const string VideoUrl = "http://dl.dropbox.com/u/45561962/therondels/therondels.flv";
        private readonly GeoCoordinateWatcher watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.High);

        public MainPage()
        {
            InitializeComponent();
            this.Settings = IsolatedStorageSettings.ApplicationSettings;
            this.Entries = new List<Champs>();

            this.SetDistance();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
            Loaded += this.MainPageLoaded;

            this.RequestXmlData();
            this.StartBackgroundAgent();
            OldArticles.FillOldArticles();
            textBlockMairie.Text = "Mairie de Thérondels\nLe Bourg\n12600 Thérondels\nTEL: 05 65 66 02 62";
            ApplicationBar.IsVisible = true;
        }

        private List<Champs> Entries { get; set; }

        private IsolatedStorageSettings Settings { get; set; }

        private void MainPageLoaded(object sender, RoutedEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }

            // Reset opacity on navigation button Item2
            ImageLeVillage.Opacity = 1;
            ImageLaVieAuVillage.Opacity = 1;
            ImageLeTourisme.Opacity = 1;
            ImageLesProfessionnels.Opacity = 1;
        }

        private void SetDistance()
        {
            if (!this.Settings.Contains("localisation"))
            {
                this.Settings.Add("localisation", true);
            }

            if (this.Settings["localisation"].Equals(true))
            {
                this.DisplayDistance();
            }
            else
            {
                textBlockTherondelsDistance.Text = "";
            }
        }

        private void RequestXmlData()
        {
            actuTitle.Opacity = .4;
            progressBarActus.Foreground = (SolidColorBrush)Resources["PhoneAccentBrush"];
            progressBarActus.Visibility = Visibility.Visible;

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
                                   PubDate = (string)cat.Element("pubDate") ?? "",
                               };

                int entriesCount = allItems.Count();

                this.Entries.Clear();
                foreach (var element in allItems)
                {
                    this.Entries.Add(element);
                }

                if (this.Settings.Contains("actus"))
                {
                    this.Settings.Remove("actus");
                }

                this.Settings.Add("actus", this.Entries);


                // Set the published date of the first actu, it will be used for the background agent
                if (this.Settings.Contains("mostRecentDate"))
                {
                    this.Settings.Remove("mostRecentDate");
                }

                this.Settings.Add("mostRecentDate", DateTime.Parse(this.Entries[0].PubDate));

                if (entriesCount != 0)
                {
                    Dispatcher.BeginInvoke(
                        () =>
                        {
                            DataContext = App.ViewModel;
                            App.ViewModel.LoadData();
                            progressBarActus.Visibility = Visibility.Collapsed;
                            actuTitle.Opacity = 1;
                        });
                }
            }
            catch
            {
                Dispatcher.BeginInvoke(
                        () =>
                        {
                            progressBarActus.Visibility = Visibility.Collapsed;
                            actuTitle.Opacity = 1;
                            MessageBox.Show("Pas de connexion réseau", "Thérondels", MessageBoxButton.OK);
                        });
            }
        }

        private void DisplayDistance()
        {
            this.watcher.MovementThreshold = 10;
            this.watcher.Start();
            this.watcher.StatusChanged += this.GeoStatusChanged;
        }

        private void GeoStatusChanged(object sender, GeoPositionStatusChangedEventArgs e)
        {
            if (e.Status == GeoPositionStatus.Ready)
            {
                var userCoordonnees = new GeoCoordinate(this.watcher.Position.Location.Latitude, this.watcher.Position.Location.Longitude);
                var therondelsCoordonnes = new GeoCoordinate(44.895419, 2.757676);

                var meters = userCoordonnees.GetDistanceTo(therondelsCoordonnes);
                var km = Convert.ToInt32(Math.Round(meters / 1000));
                if (km >= 0 && km < 2)
                {
                    textBlockTherondelsDistance.Text = "Vous êtes à Thérondels !!";
                }
                else
                {
                    textBlockTherondelsDistance.Text = "Vous êtes à " + km + " kms de Thérondels.";
                }

                this.watcher.Stop();
            }
        }

        private void GoToTherondelsButtonClick(object sender, RoutedEventArgs e)
        {
            var direction = new BingMapsDirectionsTask
                {
                    End = new LabeledMapLocation( "Therondels, 12600", new GeoCoordinate(44.895419, 2.757676))
                };
            direction.Show();
        }

        private void PlayVideoButtonClick(object sender, RoutedEventArgs e)
        {
            var video = new MediaPlayerLauncher
                {
                    Controls = MediaPlaybackControls.All,
                    Orientation = MediaPlayerOrientation.Landscape,
                    Media = new Uri(VideoUrl, UriKind.Absolute),
                    Location = MediaLocationType.Install
                };
            video.Show();
        }

        private void SelectionArticleChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                var selectedLink = ((ItemViewModel)e.AddedItems[0]).Link;
                NavigationService.Navigate(new Uri("/NewsArticlePage.xaml?selectedItem=" + selectedLink, UriKind.Relative));
                listBoxActus.SelectedIndex = -1;
            }
        }

        private void TextBlockLiensSelected(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/LiensPage.xaml", UriKind.Relative));
        }

        private void StartBackgroundAgent()
        {
            // Reset current counter to "0"
            var app = ShellTile.ActiveTiles.First();
            ShellTileData newApp = new StandardTileData()
            {
                Count = 0,
                Title = "",
            };
            app.Update(newApp);

            // Start the background agent
            var periodicTask = new PeriodicTask("UpdateCounter");

            if (ScheduledActionService.Find("UpdateCounter") != null)
            {
                ScheduledActionService.Remove("UpdateCounter");
            }

            periodicTask.Description = "Recherche d'actualités";

            // Need to add try and Catch in case the user has disable the background tack of this application
            try
            {
                ScheduledActionService.Add(periodicTask);

                // For testing
                ScheduledActionService.LaunchForTest("UpdateCounter", new TimeSpan(0, 0, 0, 10));
            }
            catch (Exception)
            {
                periodicTask.ExpirationTime = new DateTime(2010, 1, 1);
            }


        }

        private void SelectedLeVillage(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ImageLaVieAuVillage.Opacity = 0.4;
            ImageLeTourisme.Opacity = 0.4;
            ImageLesProfessionnels.Opacity = 0.4;
            NavigationService.Navigate(new Uri("/LeVillage.xaml", UriKind.Relative));
        }

        private void SelectedLaVieAuVillage(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ImageLeVillage.Opacity = 0.4;
            ImageLeTourisme.Opacity = 0.4;
            ImageLesProfessionnels.Opacity = 0.4;
            NavigationService.Navigate(new Uri("/LaVieAuVillage.xaml", UriKind.Relative));
        }

        private void SelectedLeTourisme(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ImageLeVillage.Opacity = 0.4;
            ImageLaVieAuVillage.Opacity = 0.4;
            ImageLesProfessionnels.Opacity = 0.4;
            NavigationService.Navigate(new Uri("/LeTourisme.xaml", UriKind.Relative));
        }

        private void SelectedLesProfessionnels(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ImageLeVillage.Opacity = 0.4;
            ImageLaVieAuVillage.Opacity = 0.4;
            ImageLeTourisme.Opacity = 0.4;
            NavigationService.Navigate(new Uri("/LesProfessionnels.xaml", UriKind.Relative));
        }

        private void SendMail(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var email = new EmailComposeTask
                {
                    To = "contact@therondels.fr"
                };
            email.Show();
        }

        private void MenuItemParametresClick(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/SettingsPage.xaml", UriKind.Relative));
        }

        private void MenuItemAProposClick(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/AproposPage.xaml", UriKind.Relative));
        }

        private void MenuItemActualiser_OnClick(object sender, EventArgs e)
        {
            this.RequestXmlData();
        }
    }
}