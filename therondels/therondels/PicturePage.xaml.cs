using System;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace Therondels
{
    public partial class PicturePage
    {
        public PicturePage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string url = "";
            NavigationContext.QueryString.TryGetValue("selectedItem", out url);

            var imageUrl = url.Replace("~", "/");
            var bi = new BitmapImage
                         {
                             UriSource = new Uri(imageUrl, UriKind.Relative)
                         };
            image1.Source = bi;
        }
    }
}