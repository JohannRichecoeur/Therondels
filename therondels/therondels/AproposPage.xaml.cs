using Microsoft.Phone.Tasks;

namespace Therondels
{
    public partial class AproposPage
    {
        public AproposPage()
        {
            this.InitializeComponent();
        }
        
        private void SendMail(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var email = new EmailComposeTask
            {
                To = "jean-eric.hourchon@live.fr",
                Subject = "Thérondels - Windows Phone Application"
            };
            email.Show();
        }

        private void TextBlockNoterTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var rate = new MarketplaceReviewTask();
            rate.Show();
        }
    }
}