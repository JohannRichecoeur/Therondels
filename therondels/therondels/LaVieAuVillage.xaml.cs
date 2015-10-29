using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO.IsolatedStorage;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Microsoft.Phone.Tasks;

namespace Therondels
{
    public partial class LaVieAuVillage
    {
        private const string Agenda1 = "Voici les principales manifestations ayant lieu à Thérondels :";
        private const string Agenda2 = " • Grande foire de printemps : le 20 Mai ou le samedi qui suit,";
        private const string Agenda3 = " • Marché de terroir à Nigresserre : tous les dimanches matin en Juillet-Août";
        private const string Agenda4 = " • Marché tous les samedis matins du 20 mai au 20 Octobre";
        private const string Agenda5 = " • Un week end échange avec le comité de jumelage de Thérondels/ Péret, les 5 et 6 Juillet";
        private const string Agenda6 = " • Marché de NOEL le 21 décembre après-midi, tél:06.38.72.00.30";
        private const string Agenda7 = " • Soirée Théâtre";
        private const string Agenda8 = " • Ciné Laussac";
        private const string Agenda9 = " • Démonstration de Quilles de 8 (8ème de finale de la coupe de France), le jeudi 31 Juillet";
        private const string Agenda10 = " • Fête des sentiers de l’imaginaire";
        private const string Agenda11 = " • Fête de fauchaison : 2ème dimanche d’août à Nigresserre";
        private const string Agenda12 = " • Grande Fête patronale : 13, 14 et 15 août";
        private const string Agenda13 = " • Rallye Touristique";
        private const string Agenda14 = " • Foire aux ânes : en principe le 20 octobre ou le samedi précédent .se renseigner au 0680411105.";
        private const string Agenda15 = "Retrouvez toutes les manifestations du Carladez sur le site Internet de l’Office de Tourisme.";

        private const string Salledesfetes1 = "La Commune de Therondels est dotée d’une salle des fêtes qui, suite à l’extension réalisée en 2005, offre une capacité d’accueil importante (200 personnes).\n";
        private const string Salledesfetes2 = "Son aménagement est adapté à :\n - l’organisation de repas de mariage : espace traiteur, espace vaisselle,  bar séparé avec accés salle des frigos, salle de réception de 271 m². Tables et chaises sont mises à disposition.\n - l’organisation de réunions et séminaires : sonorisation pour micro, écran électrique pour vidéoprojecteur .\n - l’organisation de festivités : la salle des fêtes est mise à disposition des associations de la Commune  à titre gratuit pour accueillir les manifestations proposées.\n\nLe prix de la location de la salle est de 100 €/24h. Il n’y a pas de tarif préférentiel.\nPour plus de renseignements, contacter la Mairie au 05.65.66.02.62\n";
        private const string Bulletin = "Le Bulletin d’information de Thérondels parait une fois par an en début d’année…\n";

        public LaVieAuVillage()
        {
            this.InitializeComponent();
            Settings = IsolatedStorageSettings.ApplicationSettings;
            this.FillText();
            this.RetrieveArticleList();
        }

        private static IsolatedStorageSettings Settings { get; set; }

        private void FillText()
        {
            textBoxAgenda.Text = Agenda1 + "\n\n" + Agenda2 + "\n" + Agenda3 + "\n" + Agenda4 + "\n" + Agenda5 + "\n" + Agenda6 + "\n" + Agenda7 + "\n" + Agenda8 + "\n" + Agenda9 + "\n" + Agenda10 + "\n" + Agenda11 + "\n" + Agenda12 + "\n" + Agenda13 + "\n" + Agenda14 + "\n\n" + Agenda15;
            textBoxSalleDesFêtes1.Text = Salledesfetes1;
            textBoxSalleDesFêtes2.Text = Salledesfetes2;
            textBoxBulletins.Text = Bulletin;

            bulletinsListbox.Items.Add(" • Bulletin de Thérondels 2015");
            bulletinsListbox.Items.Add(" • Bulletin de Thérondels 2014");
            bulletinsListbox.Items.Add(" • Bulletin de Thérondels 2013");
            bulletinsListbox.Items.Add(" • Bulletin de Thérondels 2012");
            bulletinsListbox.Items.Add(" • Bulletin de Thérondels 2011");
            bulletinsListbox.Items.Add(" • Bulletin de Thérondels 2010");
            bulletinsListbox.Items.Add(" • Bulletin de Thérondels 2009");
            bulletinsListbox.Items.Add(" • Bulletin de Thérondels 2008");
            bulletinsListbox.Items.Add(" • Bulletin de Thérondels 2007");
            bulletinsListbox.Items.Add(" • Bulletin de Thérondels 2006");
            bulletinsListbox.Items.Add(" • Bulletin de Thérondels 2005");
            bulletinsListbox.Items.Add(" • Bulletin de Thérondels 2004");
            bulletinsListbox.Items.Add(" • Bulletin de Thérondels 2003");
            bulletinsListbox.Items.Add(" • Bulletin de Thérondels 2002");
        }

        private void ClickImage(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var imageUrl = ((BitmapImage)((Image)e.OriginalSource).Source).UriSource;
            var sent = imageUrl.ToString().Replace("/therondels;component/", "");
            sent = sent.Replace("/", "~");
            NavigationService.Navigate(new Uri("/PicturePage.xaml?selectedItem=" + sent, UriKind.Relative));
        }

        private void RetrieveArticleList()
        {
            var articleList = new List<Article>();

            // For each Article in the isolated storage, add it to the articleList
            foreach (var s in Settings.Values)
            {
                try
                {
                    var art = (Article)s;

                    if (art != null)
                    {
                        articleList.Add(art);
                    }
                }
                catch
                { }
            }

            // Sort the list of article and add each Article to the article listbox
            articleList.Sort((y, x) => DateTime.Compare(x.Date, y.Date));
            articlesListbox.Items.Clear();
            foreach (Article a in articleList)
            {
                articlesListbox.Items.Add(a.Date.ToString("d", new CultureInfo("fr-FR")) + " ⸗ " + a.Title);
            }
        }

        private void ArticlesListboxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                var title = e.AddedItems[0].ToString().Remove(0, 13);
                var url = ((Article)Settings["article" + title]).Url;

                NavigationService.Navigate(new Uri("/NewsArticlePage.xaml?selectedItem=" + url, UriKind.Relative));

                articlesListbox.SelectedIndex = -1;
            }
        }

        private void BulletinsListboxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                var bulletinYear = e.AddedItems[0].ToString().Replace(" • Bulletin de Thérondels ", "");

                var webbrowser = new WebBrowserTask { Uri = new Uri("http://dl.dropbox.com/u/45561962/therondels/bulletin-" + bulletinYear + ".pdf") };
                webbrowser.Show();
            }

            bulletinsListbox.SelectedIndex = -1;
        }
    }
}