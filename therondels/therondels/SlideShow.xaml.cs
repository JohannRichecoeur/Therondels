using System;
using System.IO.IsolatedStorage;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;

namespace Therondels
{
    public partial class SlideShow
    {
        public SlideShow()
        {
            InitializeComponent();
            Settings = IsolatedStorageSettings.ApplicationSettings;
        }

        public static IsolatedStorageSettings Settings { get; set; }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string selectedTitle = "";
            NavigationContext.QueryString.TryGetValue("selectedItem", out selectedTitle);

            string title = selectedTitle.Split('~')[0];
            string index = selectedTitle.Split('~')[1];

            if (Settings.Contains("article" + title))
            {
                int i = 1;
                pivot.Items.Clear();
                if (((Article)Settings["article" + title]).Pictures != null)
                {
                    foreach (string picture in ((Article)Settings["article" + title]).Pictures)
                    {
                        var pivotItem = new PivotItem() { Name = "photo" + i };
                        var newGrid = new Grid();
                        if (picture.StartsWith("http://"))
                        {
                            var img = new Image() { Source = new BitmapImage(new Uri(picture)) };
                            newGrid.Children.Add(img);
                        }
                        else
                        {
                            var img = new Image() { Source = new BitmapImage(new Uri(picture, UriKind.Relative)) };
                            newGrid.Children.Add(img);
                        }

                        pivotItem.Content = newGrid;
                        pivot.Items.Add(pivotItem);
                        i++;
                    }

                    int position;
                    try
                    {
                        position = int.Parse(index);
                    }
                    catch (Exception)
                    {
                        position = 0;
                    }

                    pivot.SelectedIndex = position;
                }
            }
        }
    }
}