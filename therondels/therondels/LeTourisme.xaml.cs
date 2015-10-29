using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Therondels
{
    public partial class LeTourisme
    {
        private const string Accueil1 = "A Thérondels, on trouve l’hébergement et la restauration sur 2 sites :\n\n • au bourg :  Hôtel*** Restaurant Miquel 3 étoiles\n • sur la Presqu’île de Laussac : dans une résidence hôtelière de plein air avec camping bungalow classé 4 étoiles – Camping La Source";
        private const string Accueil2 = "Des gites sont également disponibles :\n\nLabellisés GÎTES DE FRANCE 3 épis :\n • à Mandilhac, chez M. et Mme SOULENQ Christian\n • à Thérondels, chez M. et Mme MESTRE Paul\n\nLabellisés GÎTES DE FRANCE 2 épis :\n • à Campheyt, chez M. SOULIE Sébastien\n\nClassés Préfecture :\n • à Thérondels, chez Mme Josiane Coret\n •à Frons, chez Mme RISSETTO et chez M. DRI\n\nUne chambre d’hôtes :\n • à Ladinhac, chez M. et Mme COUZI Pierre\n\nBateau chalet sur le Lac de Sarrans :\n • Aveyron Bois Création, M. Gérard SOL\n\nUne table de qualité est ouverte :\n • à Thérondels au Restaurant Miquel\n • à Laussac : au Camping La Source (bar, snack, pizzéria) et au Chalet du Lac  (Bar, snack,  glaces)";
        private const string Campingcar1 = "Une aire de service camping-car est à disposition des camping-caristes de passage à Thérondels ou préférant y séjourner.";
        private const string Campingcar2 = "Vous pourrez y effectuer une vidange et recharger en eau. Ce service est libre et gratuit. La borne se situe à proximité d’un espace vert aménagé avec des petits lacs. le stationnement sans condition de durée est possible dans ce large espace vert naturel ou sur la place du village.Vous découvrirez sur le site un ancien lavoir et la cabane à canards… Vous pourrez vous ballader sur le sentier de l’imaginaire (« Et le paysan créa la prairie ») et découvrir l’architecture du village de Thérondels avec notamment son église romane.";
        private const string Campingcar3 = "Crédit photos : Paul Mestre\n\n Avec un commentaire de camping cariste biterrois\nDe passage dans votre commune le 3 juin 2011, nous avons apprécié votre accueil et la gentillesse des habitants. A ce titre nous remercions Monsieur le Maire ainsi que les élus, pour cette aire de camping car où nous avons bien dormi. Vous avez un trés beau village, propre et bien entretenu.grand merci encore et peut être à bientôt  » (cckiki)";
        private const string Sentier1 = "Dans les six communes du canton du Carladez, les habitants ont animé un beau sentier d’enluminures, de cabanes, de sculptures ou de surprises sur six thèmes différents : l’eau (Brommat), la pierre (Lacroix-Barrez), l’histoire (Mur-de-Barrez), le feu (Murols), le bois (Taussac) et la flore (Thérondels).\nCes sentiers courts, ludiques, évolutifs et faciles à faire en famille séduiront du plus petit au plus grand. Plus d’infos sur le site de l’Office de Tourisme du canton de Mur-de-Barrez.";
        private const string Sentier2 = "Randonnées autour de Thérondels\n\nPour découvrir à pied Thérondels, son plateau et sa vue sur les Monts du Cantal, plusieurs possibilités s’offrent à vous :\n\nLe sentier de l’imaginaire de Thérondels sur le thème de la vache. Durée : 1h30";
        private const string Sentier3 = "Le Topoguide « Le Carladez à pied », en vente à la mairie ou à l’Office de Tourisme vous propose quatre circuits de randonnées autour du village :\n - La Presqu’île de Laussac : Durée : 4h45\n - Le village templier de Nigresserre : Durée : 2h30\n - Le sentier de Jou : Durée : 1h30\n - Le Plateau de Thérondels : Durée : 2h30";
        private const string Presqu1 = "Le site de la presqu’île de Laussac sur la Truyère est d’une incroyable beauté. Sérénité, calme et nature sont les mots qui le caractérisent le mieux. Sur les 35 km de la retenue du barrage de Sarrans, pêche, nautisme, farniente peuvent se pratiquer. Le camping de la Source exploité par Murielle Soulenq et Stéphane Hurier permet de trouver l’hébergement sur place.";
        private const string Presqu2 = "Le bateau sur l’eau de Gérard Sol « Le Lacustra » offre la possibilité de passer une journée, une semaine, un mois sur le lac. Amateurs de pêche ou amoureux en quête de calme, il peut se conduire sans permis particulier.";
        private const string Musee1 = "Musée d’Antoine, tracteurs, chars et matériel agricole ancien à Thérondels\n\nLe musée d’Antoine vous fait revivre le temps du battage à la main jusqu’à sa première mécanisation. Découvrez ces vieux matériels à Thérondels (Aveyron) dans le Carladez, aux frontières du Cantal, où se trouve ce lieu de souvenirs avec ces tracteurs d’époque, vieux chars, batteuses, manèges, lieuses, ustensiles de ferme. Antoine Froment, collectionneur de ces anciens matériels agricoles vous fera vivre sa passion avec 35 tracteurs exposés, tels que le Renault PE de 1927 ou le Deering de 1930.";
        private const string Musee2 = "Infos pratiques:\nMusée d’Antoine\n12600 Thérondels\nAveyron\nwww.therondels.fr\n\nRenseignements:\nOffice de Toursime de Mur de Barrez\nTel: 05 65 66 10 16\nwww.carladez.fr";

        public LeTourisme()
        {
            InitializeComponent();
            this.FillText();
        }

        private void FillText()
        {
            textBoxAccueil1.Text = Accueil1;
            textBoxAccueil2.Text = Accueil2;

            textBoxCampingCar1.Text = Campingcar1;
            textBoxCampingCar2.Text = Campingcar2;
            textBoxCampingCar3.Text = Campingcar3;

            textBoxSentier1.Text = Sentier1;
            textBoxSentier2.Text = Sentier2;
            textBoxSentier3.Text = Sentier3;

            textBoxPresqu1.Text = Presqu1;
            textBoxPresqu2.Text = Presqu2;

            textBoxMusee1.Text = Musee1;
            textBoxMusee2.Text = Musee2;
        }

        private void ClickImage(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var imageUrl = ((BitmapImage)((Image)e.OriginalSource).Source).UriSource;
            var sent = imageUrl.ToString().Replace("/therondels;component/", "").Replace("/", "~");
            NavigationService.Navigate(new Uri("/PicturePage.xaml?selectedItem=" + sent, UriKind.Relative));
        }
    }
}