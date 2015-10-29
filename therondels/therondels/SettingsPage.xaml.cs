using System;
using System.IO.IsolatedStorage;
using System.Windows;
using Microsoft.Phone.Tasks;

namespace Therondels
{
    public partial class SettingsPage
    {
        public SettingsPage()
        {
            InitializeComponent();
            Settings = IsolatedStorageSettings.ApplicationSettings;

            // Update localisation toggle following isolated storage
            if (Settings.Contains("localisation"))
            {
                if (Settings["localisation"].Equals(false))
                {
                    toggleSwitchLocalisation.IsChecked = false;
                    toggleSwitchLocalisation.Content = "Désactivé";
                }
            }

            this.Fill();
        }

        public static IsolatedStorageSettings Settings { get; set; }

        private void Fill()
        {
            textBlockPrivacyMicrosoft.Text = "L'application Thérondels ne conserve aucune information concernant votre position. Ces données sont uniquement utilisées pour calculer la distance à laquelle vous vous trouvez de Thérondels.\n\nA chaque fois que l'application Thérondels récupère votre position, Microsoft recueille des informations sur votre emplacement afin de fournir et d'améliorer ses services de localisation. Cette information n'est pas utilisée pour vous identifier ou vous contacter.";
            textBlockLink.TextDecorations = TextDecorations.Underline;
        }


        private void ToggleSwitchLocalisationTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (toggleSwitchLocalisation.IsChecked == true)
            {
                toggleSwitchLocalisation.Content = "Activé";
                if (Settings.Contains("localisation"))
                {
                    Settings.Remove("localisation");
                }

                Settings.Add("localisation", true);
            }
            else
            {
                toggleSwitchLocalisation.Content = "Désactivé";
                if (Settings.Contains("localisation"))
                {
                    Settings.Remove("localisation");
                }

                Settings.Add("localisation", false);
            }
        }

        private void TextBlockLinkTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var wbt = new WebBrowserTask
            {
                Uri = new Uri("http://www.microsoft.com/windowsphone/fr-fr/privacy.aspx", UriKind.Absolute)
            };
            wbt.Show();
        }
    }
}