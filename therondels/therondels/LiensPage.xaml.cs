using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media;
using Microsoft.Phone.Tasks;

namespace Therondels
{
    public partial class LiensPage
    {
        public readonly List<TextBlock> TextBlocksAll = new List<TextBlock>();

        public LiensPage()
        {
            InitializeComponent();
            this.Urls = new Dictionary<string, string>();
            this.FillDictionnary();
        }

        public Dictionary<string, string> Urls { get; set; }

        private void FillDictionnary()
        {
            this.Urls.Clear();

            this.Urls.Add("Office de Tourisme du Carladez", "http://www.carladez.fr/");
            this.Urls.Add("Station Verte", "http://www.stationverte.com/");
            this.Urls.Add("Midi Pyrénées", "http://www.midipyrenees.fr/");
            this.Urls.Add("Conseil général de l'Aveyron", "http://www.cg12.fr/");
            this.Urls.Add("Cabrettes des Burons de Pailherols", "http://www.cabrette-accordeon.com/");
            this.Urls.Add("Camping La Source", "http://www.camping-la-source.com/");
            this.Urls.Add("Chalet du Lac Presqu'île de Laussac", "http://laussac.over-blog.com/");
            this.Urls.Add("Communauté de Communes du Carladez", "http://www.cc-carladez.fr/index.aspx");
            this.Urls.Add("Dri Laetitia, artiste", "http://dri.laetitia.free.fr/");
            this.Urls.Add("Gîte La Sagne Thérondels", "http://www.gitelasagne.com/");
            this.Urls.Add("Hôtel restaurant Miquel", "http://www.hotel-miquel.com/");
            this.Urls.Add("Mairie de Thérondels", "http://www.mairie-therondels.fr/");
            this.Urls.Add("Tourisme Aveyron", "http://www.tourisme-aveyron.com/");

            this.TextBlocksAll.Add(textBlock1);
            this.TextBlocksAll.Add(textBlock2);
            this.TextBlocksAll.Add(textBlock3);
            this.TextBlocksAll.Add(textBlock4);
            this.TextBlocksAll.Add(textBlock5);
            this.TextBlocksAll.Add(textBlock6);
            this.TextBlocksAll.Add(textBlock7);
            this.TextBlocksAll.Add(textBlock8);
            this.TextBlocksAll.Add(textBlock9);
            this.TextBlocksAll.Add(textBlock10);
            this.TextBlocksAll.Add(textBlock11);
            this.TextBlocksAll.Add(textBlock12);
        }

        private void Link(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var url = "";
            var y = (TextBlock)e.OriginalSource;

            foreach (var t in this.TextBlocksAll)
            {
                if (t.Name == y.Name)
                {
                    t.Foreground = new SolidColorBrush(Colors.Black);
                }
                else
                {
                    t.Foreground = (SolidColorBrush)Resources["PhoneAccentBrush"];
                }
            }

            foreach (var kvp in this.Urls.Where(kvp => kvp.Key == y.Text))
            {
                url = kvp.Value;
            }

            var wbt = new WebBrowserTask
            {
                Uri = new Uri(url)
            };
            wbt.Show();
        }
    }
}