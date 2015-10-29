using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Therondels
{
    public partial class LeVillage
    {
        private const string Therondels1 = "Thérondels est un village épatant sur plusieurs points et notre désir est de vous faire découvrir un village qui vit. Vous allez rencontrer des artisans, des commerçants, des agriculteurs, des expatriés fidèles à leurs origines … Vous allez également connaître l’histoire de Thérondels et de sa région : Le Carladez ainsi que les activités touristiques qui existent. Que vous vouliez passer quelques jours dans notre village ou vous y installer, nous espérons que ce site répondra à vos attentes.";
        private const string Therondels2 = "Sa géographie est surprenante : c’est le village le plus au nord de l’Aveyron. Situé dans la petite région du Carladez, autrefois fief des princes de Monaco, et dans le canton de Mur-de-Barrez, il est à la frontière du Cantal et de l’Aveyron, de l’Auvergne et de l’Occitanie. Rien ici, ne laisse supposer que l’on est en Midi-Pyrénées. Tout évoque plutôt l’Auvergne, qu’il s’agisse de l’architecture, de la culture ou encore du patois local.";
        private const string Therondels3 = "Sa vie associative est effervescente : club de football, association de chasse, club du 3° âge (les tilleuls), association de villages (Laussac, Ladinhac, Nigresserre), association « des ânes aux quatre roues », Comité des Fêtes…";
        private const string Therondels4 = "Sa vie festive est éreintante : Quand ce n’est pas la grande fête patronale du 15 août, c’est la “foire aux ânes“ d’octobre, ou les animations de Noël de décembre, sans parler du gala d’accordéon du mois de mai.";
        private const string Therondels5 = "Ses rapports avec les Parisiens sont permanents. Bien des Thérondelois vivent à Paris depuis trois générations mais leurs cœurs continuent de battre pour le village de leurs ancêtres. Et nombre d’entre eux travaillent dans les bistrots de la Capitale. Et dans leurs troquets, une seule commande les fait vraiment frémir : un thé rondelles !";

        private const string Histoire1 = "Texte rédigé par l’équipe du Comité des Fêtes à l’occasion du millénaire de l’église de Thérondels:";
        private const string Histoire2 = "D’après l’abbé ROQUIER, curé de Thérondels de 1725 à 1772 et qui a laissé un manuscrit toujours en possession de la paroisse, le bourg de Thérondels fut construit autour d’une Abbaye de femmes fondée vers l’an 900 par Mme Ermengarde, comtesse d’Auvergne, originaire de Blesle, aujourd’hui en Haute-Loire.";
        private const string Histoire3 = "Or, il est permis de douter de cette origine. En effet d’après G. SEGRET, l’abbé BOSC et plusieurs autres historiens, le monastère de femmes qui donna naissance au village fut fondé en l’an 1000 par Gilbert vicomte de Carlat, avec une dotation augmentée au cours du XII°s. par Adhémar, évêque de Rodez, Guillaume archidiacre et Guillaume, prévôt de l’église Cathédrale de Rodez.";
        private const string Histoire4 = "Le monastère de Thérondels fut réuni à l’Abbaye de Blesle placée sous le vocable de St Pierre et sous la protection directe du Pape. en 1185 (Bulle du pape Luclus II du 4 avril 1185 qui énumère les dépendances de Blesle), Abbaye qui fut fondée par …Mme Emingarde vers l’an 880.";
        private const string Histoire5 = "On peut donc penser que l’abbé Roquier a confondu les deux fondations respectives. Le monastère de Thérondels dépendra de l’abbaye de Blesle à partir de 1185. En 1284, le jeudi après Pâques intervient un accord entre l’abbesse de Blesle et Henri, comte de Rodez et vicomte de Carlat, acte qui fut renouvelé sans doute en 1293 au sujet de la justice à Thérondels.";
        private const string Histoire6 = "L’acte accordait au comte le droit de commun de paix sur tous les animaux, autres que pourceaux, exemptant de ce droit les villages de Mandilhac, de Brugueyra et Blanquels, de Doux Albats et celui de Bernard de Veyra.";
        private const string Histoire7 = "Quant à la justice, il était stipulé que l’abbesse aurait à Thérondels et dans les villages qui en dépendaient le droit de connaître « des causes réelles et personnelles, ban et correction de ban, connaissance, punition, examen et exécution de tous crimes du ressort du mixte-impère seulement »; Et le comte « la connaissance de ce qui appartient au mère impère, pour mutilation de membre et condamnation à mort et au dernier supplice. »";
        private const string Histoire8 = "De plus, l’acte stipulait que « les amendes seraient partagées, que la punition des criminels aurait lieu sur les terres de ladite abbesse et non ailleurs, que le comte ne pourrait dresser les fourches patibulaires en vue de l’église de Thérondels mais bien en tout autre endroit de la juridiction. Qu’enfin la connaissance d’un larcin n’excédant pas dix sous rodanois commis entre mari et femme ou domestique lui serait interdite ».";
        private const string Histoire9 = "Les religieuses y suivaient la règle de St Benoît, leurs biens étaient administrés par des fermiers régisseurs, on trouve les noms de Blaize de Montheil en 1500,Claude de Baud’huin en 1648, Gaspard du Bousquet (qui avait entrepris la construction d’un château au Cayrol), Jérôme Verdier, Verdier de Peyrebesse, Raymond Bertrand…";
        private const string Histoire10 = "La nomination du curé de Thérondels était laissée aux abbesses. En 1630, l’abbesse de Blesle nomme comme curé, un certain Bathélémy Pages, originaire également de Blesle, docteur en théologie et théologal à la cathédrale de St Flour, ce qui ne le faisait que rarement résider à Thérondels, cela provoqua le fort mécontentement des prêtres de la communauté.";
        private const string Histoire11 = "En 1353,le pape Innocent IV ordonne par une bulle, la réunion au couvent de Blesle des différents prieurés dont celui de Thérondels, toutes les religieuses sont réunies à Blesle car la règle bénédictine n est pas fidèlement observée et « il arrive trop souvent que les prieures doivent pour leurs affaires de leurs monastères fréquenter la cour des princes et des seigneurs et y contractent de fort mauvaises habitudes ».";
        private const string Histoire12 = "Les religieuses partent donc de Thérondels mais leurs biens seront conservés et administrés jusqu’à la révolution par leurs fermiers. On ne sait si elles sont revenues vivre en communauté à Thérondels car l’abbé Roquier écrit qu’au XVI° s., Henry II ordonne aux religieuses vivant dans des monastères non fortifiés (comme Thérondels) de les quitter pour des villes possédant des fortifications afin de pourvoir à leur sécurité en ces temps difficiles.";
        private const string Histoire13 = "Les Dames étaient elles revenues entre temps ? ? ? Cela étant, avec la suppression des prieurés en 1353 et la réunion des dames au Monastère de Blesle, un accord est établi entre l’abbesse et les religieuses au sujet du partage des biens et revenus.";
        private const string Histoire14 = "L’accord de 1354, renouvelé en 1355 attribue aux dames religieuses les revenus de Thérondels, « avec réserve au profit de l’abbesse de la justice, juridiction, droits de vestir et d’investir et des émoluments y attachés. »";
        private const string Histoire15 = "L’abbesse perçoit toutefois une rente foncière de cent livres à Thérondels appelée La Rendotte. 42 abbesses se succèderont à Blesle jusqu’à la Révolution qui mettra fin au monastère et à ses dépendances. Il existe encore de nos jours deux présences du monastère des dames : le Pré des Dames près de l’église ainsi que le Moulin des Dames.";
        private const string Histoire16 = "Pour en savoir plus sur Thérondels, on pourra lire également les deux ouvrages d’Adrienne Villaret : L’histoire de Thérondels (1998) Deux personnages historiques de Thérondels : Saint Gausebert, fondateur du monastère de Laussac et le père Robert, fondateur de l’hôpital psychiatrique de la Devèze. Livres en vente chez Adrienne Villaret, 12600 Thérondels.";

        private const string Eglise1A = "Historique de l’église abbatiale de Thérondels:";
        private const string Eglise1B = "Dans sa partie la plus ancienne, selon l’abbé Roquier, l’église de Thérondels remonterait à l’an 1000. «On le prouve par ces lettres ADM qui veulent dire Anno Domini Millésimo qui sont gravées sur la fenêtre de la chapelle St Blaise». De fait, l’église est en grande partie de style roman XIe et XIIe siècle avec nef et chœur, remanié au XVe s.et XVIIe s. avec les chapelles latérales et le clocher.";
        private const string Eglise2A = "Description des éléments:";
        private const string Eglise2B = "Le retable (et les statues de St Joseph et St Roch) date des années 1690 et 1691 . Ils sont la conséquence de la visite le 15 janvier 1669 de Mgr Voyer de Paulmy, évêque de Rodez, qui ordonna que l’église en soit pourvue. Le tout fut fait aux dépens des Dames de Blesle. La Vierge Noire de Thérondels, dérivée de la majesté d’or de Clermont Ferrand a disparu en 1892 à la suite d’une exposition à Rodez … Les culots de l’église sont assez bien conservés : Suisse jouant de la flûte et du tambourin, buveur de chopine, mangeur de fouace, paresseux … La remarquable pierre à droite de l’autel symbolise la Trinité. On peut peut-être y voir la réminiscence d’un dieu gaélique.. Les chapelles du Rosaire (à droite de l’autel) et de St Antoine (à gauche) appartenaient à la puissante maison de Montheil.";
        private const string Eglise3A = "Le clocher a été construit en 1610 par Tardieu, maître maçon des Faux en Gévaudan. Le précédent clocher avait été détruit durant les guerres de religion par les calvinistes… où les partisans de la réforme tinrent la région dans la peur. A preuve, le 30 janvier 1575, Messire Pierre BOYER prêtre de Doux Albats dicte son testament : « lequel voyant le temps de troubles et guerres auquel nous sommes et le danger d être tué pour raison de ceux de la nouvelle religion qui tous les jours sont en un village ou autre de la paroisse…» En 1711, la grande cloche qui était fendue et qui pesait 14 quintaux, fut fondue. On en tira une petite qui est aujourd’hui à l’emplacement de l’ancien clocher";
        private const string Eglise3B = "La Fraternité des Prêtres:";
        private const string Eglise3C = "Au début du XVIe siècle, il existait à Thérondels une Fraternité de prêtres comme dans un quart des paroisses du Rouergue. D’après le livre de Camille Belmon commentant une visite pastorale de François d’Estaing, (1460 1529) évêque de Rodez, on compte : 40 prêtres fraternisant à Lagilole, 46 à St Amans-des-Côts, 52 à Entraygues et 50 à Thérondels… Ces prêtres du bas-clergé issus de la région vivaient des arts mécaniques, des travaux des champs et assuraient l’exécution des pieuses fondations (messes quotidiennes, offices des morts) Ils étaient peu instruits, la Fraternité leur permettait de créer un lien entre eux et de réglementer leur existence. En 1626, ils sont encore 16 prêtres fraternisant à Thérondels La coutume orale cite la maison A.Tarrisse (devant la mairie) comme lieu de résidence d’une communauté de prêtres";

        private const string Carladez1 = "Situé à l’extrême nord de l’Aveyron, Thérondels fait partie du Carladez. Un pays à l’identité unique qui s’enfonce comme un coin dans le Cantal. Le nom Carladez provient de la dynastie des Carlat devenus, vicomte de Carladez.";
        private const string Carladez2 = "Le château des Carlat détruit sur ordre d’Henri IV, la vicomté passa entre les mains des Princes de Monaco, les fameux Grimaldi. Voilà pourquoi on peut aujourd’hui admirer la Tour de Monaco à Mur-de-Barrez, longtemps siège de leur pouvoir.";
        private const string Carladez3 = "Pas un canton qui n’ait un château, une église remarquable, des croix sculptées. Au fil des promenades, on n’oubliera pas de visiter les églises de Brommes, Albinhac, Brommat, merveilles de l’architecture religieuse de ce pays.";
        private const string Carladez4 = "Voila un pays marqué d’une personnalité forte et d’une identité unique ! La richesse de son patrimoine architectural et historique réjouit tous les amoureux des vieilles pierres et d’Histoire. Un de ces rares endroits protégé des lotissements et des hangars de béton et des publicités agressives sur les routes.";
        private const string Carladez5 = "Et puis, il y a aussi cette eau pure, omniprésente depuis la construction du barrage de Sarrans avec la presqu’île de Laussac";

        private const string Ecole1 = "Plus de quarante enfants courent, crient, chahutent dans la cour de récré de l’école de Thérondels. A côté de la solitude et de l’abandon de bien des villages du Massif Central, c’est tout simplement le signe de la vitalité démographique et économique de Thérondels, de la volonté de leurs parents trentenaires, agriculteurs souvent, artisans parfois, fonctionnaires revenus de Paris, de bâtir leur destin au village.";
        private const string Ecole2 = "A la différence du beau documentaire « Etre et Avoir » qui décrit le quotidien d’une classe unique en Auvergne, du fait de cette nombreuse marmaille, l’école thérondeloise a deux classes. Les tout petits sont dans la classe de droite. Les plus grands dans la classe de gauche.";
        private const string Ecole3 = "Mais tout n’a pas été si rose qu’aujourd’hui. Durant les années 80, où il n’y avait plus que sept élèves dans les murs. Le futur était alors sombre. D’abord, l’école Sainte Agnès, dans laquelle était passé un Thérondelois sur deux, dût fermer en 1997. Les derniers élèves sont rentrés à l’école publique. En d’autres temps, on aurait proclamé sa victoire…";
        private const string Ecole4 = "Aujourd’hui, les enjeux, sont ailleurs. A preuve, lorsque l’école de Thérondels a fêté ses 100 ans en juillet 2002, tous, anciens du privé et du public, étaient présents simplement pour témoigner l’importance qu’ils attachaient à l’école au pays. La vague de naissance de ces dernières années –près d’une dizaine en l’an 2000- a poussé la municipalité à investir 241 000 euros pour créer une extension à l’école (nouvelle classe, salle de gym, d’informatique) et une cantine.";
        private const string Ecole5 = "Et le 17 juin 2011 l’école communale est devenue   » ECOLE JEAN CARBONEL »";

        private const string Expat1 = "Ils sont nés, ont vécu leur enfance, leur jeunesse ou une tranche de vie sur la commune de Thérondels; se sentent-ils « expatriés » , forment-ils une diaspora ? Le rédacteur ne tranche pas et attend leur avis,votre avis.  L’objectif de cette rubrique, se connaître, se faire connaître, créer un lien entre les Thérondélois du Monde , à notre modeste échelle. Ecrivez nous en quelques lignes que nous serons peut être amenés à réduire, envoyez-nous 3 photos ( famille, profession, loisir par exemple), directement au mail du rédacteur actuel (paul.mestre@therondels.fr).";
        private const string Expat2A = "Famille Jean Louis BELARD à Washington.";
        private const string Expat2B = "Bélard Jean Louis, Né à Thérondels en 1946, petit-fils de François Bélard de Faliès, fils d’Antoine, a fait médecine à Lyon. Marié en 1971 avec Geneviève Dupuy, ils ont un fils Arnaud en 1972. Après avoir quitté l’Armée comme Médecin Colonel, part en 1991 aux USA comme Professeur Associé de Médecine et est depuis Directeur Scientifique à la Fondation Henry Jackson. Nous habitons à Rockville, près de Washingtondepuis 1998.";
        private const string Expat2C = "Les photos　: Geneviève et moi (nous fêterons le 24 Juillet 2011, nos 40 ans de mariage!) avec notre petit berger australien Sydney Notre fils Arnaud et sa femme Régina (qui nous a donné en Mars 2011 un superbe petit-fils Alexander) entourant Geneviève Et pour finir, ton cousin donnant une conférence à l’université de Séoul en Corée il y a 3 mois.";

        public LeVillage()
        {
            InitializeComponent();
            this.FillText();
        }

        private void FillText()
        {
            textBoxTherondels.Text = Therondels1 + "\n\n" + Therondels2 + "\n\n" + Therondels3 + "\n\n" + Therondels4 + "\n\n" + Therondels5;
            textBoxHistoire1.Text = Histoire1 + "\n\n" + Histoire2 + "\n\n" + Histoire3 + "\n\n" + Histoire4 + "\n\n" +
                                    Histoire5 + "\n\n" + Histoire6 + "\n\n" + Histoire7 +
                                    "\n\n" + Histoire8 + "\n\n";
            textBoxHistoire2.Text = Histoire9 + "\n\n" + Histoire10 + "\n\n" + Histoire11 + "\n\n" + Histoire12 + "\n\n" + Histoire13 +
                       "\n\n" + Histoire14 + "\n\n" + Histoire15 + "\n\n" + Histoire16;
            textBoxEglise1.Text = Eglise1A + "\n\n" + Eglise1B;
            textBoxEglise2.Text = Eglise2A + "\n\n" + Eglise2B;
            textBoxEglise3.Text = Eglise3A + "\n\n" + Eglise3B + "\n\n" + Eglise3C;

            textBoxCarladez.Text = Carladez1 + "\n\n" + Carladez2 + "\n\n" + Carladez3 + "\n\n" + Carladez4 + "\n\n" + Carladez5;

            textBoxEcole1.Text = "École\n\nJean CARBONEL";
            textBoxEcole2.Text = Ecole1 + "\n\n" + Ecole2 + "\n\n" + Ecole3 + "\n\n" + Ecole4 + "\n\n" + Ecole5;

            textBoxExpat1.Text = Expat1;
            textBoxExpat2.Text = Expat2A + "\n\n" + Expat2B + "\n\n" + Expat2C;
        }

        private void ClickImage(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var imageUrl = ((BitmapImage)((Image)e.OriginalSource).Source).UriSource;
            var sent = imageUrl.ToString().Replace("/therondels;component/", "").Replace("/", "~");
            NavigationService.Navigate(new Uri("/PicturePage.xaml?selectedItem=" + sent, UriKind.Relative));
        }
    }
}