using System;
using System.IO.IsolatedStorage;

namespace Therondels
{
    public class OldArticles
    {
        public static void FillOldArticles()
        {
            AddSettings(new Article() { Title = "Nouveau site de Thérondels", Url = "http://www.therondels.fr/2010/07/nouveau-site-de-therondels/", Date = new DateTime(2010, 07, 08) });
            AddSettings(new Article() { Title = "Camping-caristes : faites une pose à Thérondels (Aveyron)!", Url = "http://www.therondels.fr/2010/07/camping-caristes-faites-une-pose-a-therondels-aveyron/", Date = new DateTime(2010, 07, 20) });
            AddSettings(new Article() { Title = "Des activités en lien avec la nature", Url = "http://www.therondels.fr/2010/07/des-activites-en-lien-avec-la-nature/", Date = new DateTime(2010, 07, 20) });
            AddSettings(new Article() { Title = "Camping de la presqu’île de Laussac, Aveyron", Url = "http://www.therondels.fr/2010/07/camping-de-la-presquile-de-laussac-aveyron/", Date = new DateTime(2010, 07, 21) });
            AddSettings(new Article() { Title = "Fête des sentiers de l’imaginaire 2010 en Carladez (Aveyron)", Url = "http://www.therondels.fr/2010/07/fete-des-sentiers-de-limaginaire-2010-en-carladez-aveyron/", Date = new DateTime(2010, 07, 27) });
            AddSettings(new Article() { Title = "Dernière minute : le groupe « Délinquante » sera en concert samedi 31 juillet 2010 à Thérondels", Url = "http://www.therondels.fr/2010/07/derniere-minute-le-groupe-delinquante-sera-en-concert-samedi-31-juillet-2010-a-therondels/", Date = new DateTime(2010, 07, 27) });
            AddSettings(new Article() { Title = "Fête du 15 août 2010 à Thérondels (Nord-Aveyron)", Url = "http://www.therondels.fr/2010/08/fete-du-15-aout-2010-a-therondels-nord-aveyron/", Date = new DateTime(2010, 08, 09) });
            AddSettings(new Article() { Title = "Pailherols (Cantal): Stage et gala de Cabrettes", Url = "http://www.therondels.fr/2010/09/pailherols-cantal-stage-et-gala-de-cabrettes/", Date = new DateTime(2010, 09, 27) });
            AddSettings(new Article() { Title = "Samedi 23 Octobre : Foire aux ânes à Thérondels (Nord-Aveyron)", Url = "http://www.therondels.fr/2010/10/samedi-23-octobre-foire-aux-anes-a-therondels-nord-aveyron/", Date = new DateTime(2010, 10, 19) });
            AddSettings(new Article() { Title = "Journée d’automne au pays des sentiers de l’imaginaire", Url = "http://www.therondels.fr/2010/10/journee-dautomne-au-pays-des-sentiers-de-limaginaire/", Date = new DateTime(2010, 10, 28) });
            AddSettings(new Article() { Title = "« Les escapades de Petitrenaud » en Carladez (Aveyron)", Url = "http://www.therondels.fr/2010/11/les-escapades-de-petitrenaud-en-carladez-aveyron/", Date = new DateTime(2010, 11, 10) });
            AddSettings(new Article() { Title = "Anciens combattants honorés", Url = "http://www.therondels.fr/2010/11/anciens-combattants-honores/", Date = new DateTime(2010, 11, 12) });
            AddSettings(new Article() { Title = "NEIGE", Url = "http://www.therondels.fr/2010/11/neige/", Date = new DateTime(2010, 11, 28) });
            AddSettings(new Article() { Title = "Club “LES TILLEULS”", Url = "http://www.therondels.fr/2010/12/club-les-tilleuls/", Date = new DateTime(2010, 12, 06) });
            AddSettings(new Article() { Title = "Bonne et Heureuse Année", Url = "http://www.therondels.fr/2011/01/bonne-et-heureuse-annee/", Date = new DateTime(2011, 01, 02) });
            AddSettings(new Article() { Title = "Bulletin de Thérondels Janvier 2011", Url = "http://www.therondels.fr/2011/01/bulletin-municipal-janvier-2011/", Date = new DateTime(2011, 01, 26) });
            AddSettings(new Article() { Title = "célébration du 19 mars", Url = "http://www.therondels.fr/2011/03/celebration-du-19-mars/", Date = new DateTime(2011, 03, 19) });
            AddSettings(new Article() { Title = "Daniel TARRISSE est élu", Url = "http://www.therondels.fr/2011/03/daniel-tarrisse-est-elu/", Date = new DateTime(2011, 03, 29) });
            AddSettings(new Article() { Title = "Printemps, autour de l’arbre", Url = "http://www.therondels.fr/2011/03/printempsautour-de-larbre/", Date = new DateTime(2011, 03, 29) });
            AddSettings(new Article() { Title = "Printemps, avec le moto club,…", Url = "http://www.therondels.fr/2011/04/printemps-avec-le-moto-club/", Date = new DateTime(2011, 04, 02) });
            AddSettings(new Article() { Title = "Printemps, avec les greffeurs……", Url = "http://www.therondels.fr/2011/04/printemps-avec-les-greffeurs/", Date = new DateTime(2011, 04, 05) });
            AddSettings(new Article() { Title = "20107….c’est le chiffre des visiteurs", Url = "http://www.therondels.fr/2011/05/20107-cest-le-chiffre-des-visiteurs/", Date = new DateTime(2011, 05, 01) });
            AddSettings(new Article() { Title = "La Grande Foire de Printemps se prépare…", Url = "http://www.therondels.fr/2011/05/la-grande-foire-de-printemps-se-prepare/", Date = new DateTime(2011, 05, 02) });
            AddSettings(new Article() { Title = "Samedi 07 Mai : Assemblée générale du Comité des fêtes", Url = "http://www.therondels.fr/2011/05/samedi-07-mai-assemblee-generale-du-comite-des-fetes/", Date = new DateTime(2011, 05, 06) });
            AddSettings(new Article() { Title = "J-7 pour la Grande Foire de Printemps à Thérondels (Nord-Aveyron)", Url = "http://www.therondels.fr/2011/05/j-7-pour-la-grande-foire-de-printemps-a-therondels-nord-aveyron/", Date = new DateTime(2011, 05, 13) });
            AddSettings(new Article() { Title = "Jean-Philippe SOL, champion de France de Volley-Ball avec Poitiers", Url = "http://www.therondels.fr/2011/05/jean-philippe-sol-champion-de-france-volley-ball/", Date = new DateTime(2011, 05, 15) });
            AddSettings(new Article() { Title = "Chasse. Assemblée générale.", Url = "http://www.therondels.fr/2011/05/chasse-assemblee-generale/", Date = new DateTime(2011, 05, 29) });
            AddSettings(new Article() { Title = "Laussac 2011", Url = "http://www.therondels.fr/2011/07/laussac-2011/", Date = new DateTime(2011, 07, 05) });
            AddSettings(new Article() { Title = "Couleurs d’un soir…", Url = "http://www.therondels.fr/2011/07/couleurs-dun-soir/", Date = new DateTime(2011, 07, 06) });
            AddSettings(new Article() { Title = "Ecole Jean CARBONEL", Url = "http://www.therondels.fr/2011/07/lecole-de-therondels-devient-ecole-jean-carbonel/", Date = new DateTime(2011, 07, 08) });
            AddSettings(new Article() { Title = "Photos 2011", Url = "http://www.therondels.fr/2011/07/photos-2011/", Date = new DateTime(2011, 07, 08) });
            AddSettings(new Article() { Title = "Les Monts du Cantal", Url = "http://www.therondels.fr/2011/07/les-monts-du-cantal/", Date = new DateTime(2011, 07, 13) });
            AddSettings(new Article() { Title = "Fête des sentiers de l’imaginaire 2011 en Carladez (Aveyron)", Url = "http://www.therondels.fr/2011/07/fete-des-sentiers-de-l%E2%80%99imaginaire-2011-en-carladez-aveyron/", Date = new DateTime(2011, 07, 26) });
            AddSettings(new Article() { Title = "J-10 avant la fête du 15 août à Thérondels", Url = "http://www.therondels.fr/2011/08/j-10-avant-la-fete-du-15-aout-a-therondels/", Date = new DateTime(2011, 08, 04) });
            AddSettings(new Article() { Title = "Fête du 15 août à THERONDELS (Nord-Aveyron) : le programme.", Url = "http://www.therondels.fr/2011/08/fete-du-15-aout-a-therondels-nord-aveyron-le-programme/", Date = new DateTime(2011, 08, 09) });
            AddSettings(new Article() { Title = "UNE SEMAINE EN MUSIQUE…", Url = "http://www.therondels.fr/2011/08/une-semaine-en-musique/", Date = new DateTime(2011, 08, 09) });
            AddSettings(new Article() { Title = "Les « Delinquante »: concert gratuit le 15 aout à Thérondels", Url = "http://www.therondels.fr/2011/08/les-delinquante-concert-gratuit-le-15-aout-a-therondels/", Date = new DateTime(2011, 08, 12) });
            AddSettings(new Article() { Title = "Spectacle « Le petit chaperon rouge » à Thérondels", Url = "http://www.therondels.fr/2011/09/spectacle-le-petit-chaperon-rouge-a-therondels/", Date = new DateTime(2011, 09, 30) });
            AddSettings(new Article() { Title = "Samedi 22 octobre : Foire aux ânes à Thérondels (Nord Aveyron)", Url = "http://www.therondels.fr/2011/10/samedi-22-octobre-foire-aux-anes-a-therondels-nord-aveyron/", Date = new DateTime(2011, 10, 21) });
            AddSettings(new Article() { Title = "La foire des ânes 2011, un succès !", Url = "http://www.therondels.fr/2011/10/la-foire-des-anes-2011-un-succes/", Date = new DateTime(2011, 10, 22) });
            AddSettings(new Article() { Title = "Mobilité du personnel au secretariat de mairie", Url = "http://www.therondels.fr/2011/10/mobilite-du-personnel-au-secretariat-de-mairie/", Date = new DateTime(2011, 10, 28) });
            AddSettings(new Article() { Title = "Médaille d’honneur à Didier Bernié…", Url = "http://www.therondels.fr/2011/10/medaille-dhonneur-a-didier-bernie/", Date = new DateTime(2011, 10, 29) });
            AddSettings(new Article() { Title = "Ballade au soleil de Toussaint", Url = "http://www.therondels.fr/2011/11/ballade-au-soleil-de-toussaint/", Date = new DateTime(2011, 11, 11) });
            AddSettings(new Article() { Title = "11 NOVEMBRE", Url = "http://www.therondels.fr/2011/11/11-novembre/", Date = new DateTime(2011, 11, 13) });
            AddSettings(new Article() { Title = "Un Grand Bravo ….25056…!!!!!", Url = "http://www.therondels.fr/2011/11/un-grand-bravo-25056/", Date = new DateTime(2011, 11, 15) });
            AddSettings(new Article() { Title = "Sentier et moto…", Url = "http://www.therondels.fr/2011/11/sentier-et-moto/", Date = new DateTime(2011, 11, 20) });
            AddSettings(new Article() { Title = "NOEL et JOUR de l’AN", Url = "http://www.therondels.fr/2012/01/noel-et-jour-de-lan/", Date = new DateTime(2012, 01, 01) });
            AddSettings(new Article() { Title = "BONNE ANNEE 2012", Url = "http://www.therondels.fr/2012/01/bonne-annee-2012/", Date = new DateTime(2012, 01, 01) });
            AddSettings(new Article() { Title = "Sentier de l’imaginaire, pierres plantées,…", Url = "http://www.therondels.fr/2012/01/sentier-de-limaginaire-pierres-plantees/", Date = new DateTime(2012, 01, 18) });
            AddSettings(new Article() { Title = "Le THERONDELS", Url = "http://www.therondels.fr/2012/02/le-therondels/", Date = new DateTime(2012, 02, 20) });
            AddSettings(new Article() { Title = "Pâques,…", Url = "http://www.therondels.fr/2012/04/paques/", Date = new DateTime(2012, 04, 19) });
            AddSettings(new Article() { Title = "ELECTIONS PRESIDENTIELLES…", Url = "http://www.therondels.fr/2012/04/elections-presidentielles/", Date = new DateTime(2012, 04, 22) });
            AddSettings(new Article() { Title = "FOIRE de PRINTEMPS le 20 mai", Url = "http://www.therondels.fr/2012/05/foire-de-printemps-le-20-mai/", Date = new DateTime(2012, 05, 01) });
            AddSettings(new Article() { Title = "GRANDE FOIRE DU 20 MAI", Url = "http://www.therondels.fr/2012/05/grande-foire-du-20-mai/", Date = new DateTime(2012, 05, 06) });
            AddSettings(new Article() { Title = "CYCLISME EN CARLADEZ et tourisme…", Url = "http://www.therondels.fr/2012/06/cyclisme-en-carladez-et-tourisme/", Date = new DateTime(2012, 06, 09) });
            AddSettings(new Article() { Title = "LEGISLATIVES", Url = "http://www.therondels.fr/2012/06/legislatives/", Date = new DateTime(2012, 06, 17) });
            AddSettings(new Article() { Title = "Rencontre « STATION VERTE »", Url = "http://www.therondels.fr/2012/06/rencontre-stationverte/", Date = new DateTime(2012, 06, 22) });
            AddSettings(new Article() { Title = "SUIVI de fréquentation du site www.therondels.fr", Url = "http://www.therondels.fr/2012/07/suivi-de-frequentation-du-site-www-therondels-fr/", Date = new DateTime(2012, 07, 09) });
            AddSettings(new Article() { Title = "RAID AVENTURE organisation", Url = "http://www.therondels.fr/2012/07/raid-aventure-organisation/", Date = new DateTime(2012, 07, 16) });
            AddSettings(new Article() { Title = "Doux-Albats", Url = "http://www.therondels.fr/2012/07/doux-albats/", Date = new DateTime(2012, 07, 16) });
            AddSettings(new Article() { Title = "Presse régionale…voir Thérondels…", Url = "http://www.therondels.fr/2012/07/presse-regionale-voir-therondels/", Date = new DateTime(2012, 07, 19) });
            AddSettings(new Article() { Title = "Pot d’Accueil", Url = "http://www.therondels.fr/2012/07/pot-daccueil/", Date = new DateTime(2012, 07, 23) });
            AddSettings(new Article() { Title = "CANTAL PATRIMOINE nous rend visite…", Url = "http://www.therondels.fr/2012/07/cantal-patrimoine-nous-rend-visite/", Date = new DateTime(2012, 07, 29) });
            AddSettings(new Article() { Title = "Le « 15 AOUT » à Thérondels…", Url = "http://www.therondels.fr/2012/08/le-15-aout-a-therondels/", Date = new DateTime(2012, 08, 07) });
            AddSettings(new Article() { Title = "Mélodie en Barrez, …", Url = "http://www.therondels.fr/2012/08/melodie-en-barrez/", Date = new DateTime(2012, 08, 13) });
            AddSettings(new Article() { Title = "FETE PATRONALE….et mardis des sentiers", Url = "http://www.therondels.fr/2012/08/fete-patronale-et-mardis-des-sentiers/", Date = new DateTime(2012, 08, 17) });
            AddSettings(new Article() { Title = "ULM…variations sur Thérondels", Url = "http://www.therondels.fr/2012/08/ulm-variations-sur-therondels/", Date = new DateTime(2012, 08, 18) });
            AddSettings(new Article() { Title = "Le THERONDELS", Url = "http://www.therondels.fr/2012/09/le-therondels-2/", Date = new DateTime(2012, 09, 22) });
            AddSettings(new Article() { Title = "20 OCTOBRE – Foire des ânes…", Url = "http://www.therondels.fr/2012/10/20-octobre-foire-des-anes/", Date = new DateTime(2012, 10, 11) });
            AddSettings(new Article() { Title = "THERONDELS INFO 2013", Url = "http://www.therondels.fr/2013/01/therondels-info-2013/", Date = new DateTime(2013, 01, 10) });
            AddSettings(new Article() { Title = "THERONDELS et alentours au 25 janvier", Url = "http://www.therondels.fr/2013/01/therondels-et-alentours-au-25-janvier/", Date = new DateTime(2013, 01, 26) });
            AddSettings(new Article() { Title = "chute de neige", Url = "http://www.therondels.fr/2013/02/chute-de-neige/", Date = new DateTime(2013, 02, 06) });
            AddSettings(new Article() { Title = "Tradition  » chanter la passion »", Url = "http://www.therondels.fr/2013/03/tradition-chanter-la-passion/", Date = new DateTime(2013, 03, 24) });
            AddSettings(new Article() { Title = "GRANDE FOIRE DE PRINTEMPS, 20 MAI", Url = "http://www.therondels.fr/2013/05/grande-foire-de-printemps/", Date = new DateTime(2013, 05, 11) });
            AddSettings(new Article() { Title = "AFFLUENCE,SOLEIL ET ECLAIRCIES …", Url = "http://www.therondels.fr/2013/05/affluencesoleil-et-eclaircies/", Date = new DateTime(2013, 05, 20) });
            AddSettings(new Article() { Title = "« VIVRE AU PAYS »…à THERONDELS..!!!", Url = "http://www.therondels.fr/2013/05/vivre-au-pays-a-therondels/", Date = new DateTime(2013, 05, 20) });
            AddSettings(new Article() { Title = "PRINTEMPS ou pas Printemps…", Url = "http://www.therondels.fr/2013/05/printemps-ou-pas-printemps/", Date = new DateTime(2013, 05, 23) });
            AddSettings(new Article() { Title = "JUMELAGE PERET THERONDELS…", Url = "http://www.therondels.fr/2013/06/jumelage-peret-therondels/", Date = new DateTime(2013, 06, 19) });
            AddSettings(new Article() { Title = "animation sur le « sentier de l’imaginaire  » dernière minute…", Url = "http://www.therondels.fr/2013/07/animation-sur-le-sentier-de-limaginaire-derniere-minute/", Date = new DateTime(2013, 07, 03) });
            AddSettings(new Article() { Title = "14 juillet… ULM", Url = "http://www.therondels.fr/2013/07/14-juillet-ulm/", Date = new DateTime(2013, 07, 14) });
            AddSettings(new Article() { Title = "la fête des voisins….", Url = "http://www.therondels.fr/2013/07/la-fete-des-voisins/", Date = new DateTime(2013, 07, 14) });
            AddSettings(new Article() { Title = "CINEMA à LAUSSAC….en juillet, Aôut,…", Url = "http://www.therondels.fr/2013/07/cinema-a-laussac-en-juillet-aout/", Date = new DateTime(2013, 07, 18) });
            AddSettings(new Article() { Title = "CABRETTES ET ACCORDEONS….à Douzalbats ou Doux-Albats", Url = "http://www.therondels.fr/2013/07/cabrettes-et-accordeons-a-douzalbats-ou-doux-albats/", Date = new DateTime(2013, 07, 25) });
            AddSettings(new Article() { Title = "ACCUEIL ET ANIMATION TOURISTIQUE", Url = "http://www.therondels.fr/2013/08/accueil-et-animation-touristique/", Date = new DateTime(2013, 08, 02) });
            AddSettings(new Article() { Title = "Ville Vélo Touristique", Url = "http://www.therondels.fr/2013/08/ville-velo-touristique/", Date = new DateTime(2013, 08, 02) });
            AddSettings(new Article() { Title = "suite au concert de cabrette et accordéon de Doux Albats", Url = "http://www.therondels.fr/2013/08/suite-au-concert-de-cabrette-et-accordeon-de-doux-albats/", Date = new DateTime(2013, 08, 10) });
            AddSettings(new Article() { Title = "LA RANDO avec « CANTAL PEDESTRE »,dernière minute,et photo", Url = "http://www.therondels.fr/2013/08/la-rando-avec-cantal-pedestre/", Date = new DateTime(2013, 08, 11) });
            AddSettings(new Article() { Title = "les FETES DU 15 AOUT….un sacré millésime !!!", Url = "http://www.therondels.fr/2013/08/les-fetes-du-15-aout/", Date = new DateTime(2013, 08, 16) });
            AddSettings(new Article() { Title = "Laetitia DRI …..dans VIVRE AU PAYS", Url = "http://www.therondels.fr/2013/08/laetitia-dri-dans-vivreaupays/", Date = new DateTime(2013, 08, 20) });
            AddSettings(new Article() { Title = "OCCITAN à THERONDELS 23 NOVEMBRE à 14 heures 30", Url = "http://www.therondels.fr/2013/11/occitan-a-therondels-23-novembre-a-14-heures-30/", Date = new DateTime(2013, 11, 15) });
            AddSettings(new Article() { Title = "la place du village ce 21 novembre.", Url = "http://www.therondels.fr/2013/11/la-place-du-village-ce-21-novembre/", Date = new DateTime(2013, 11, 23) });
            AddSettings(new Article() { Title = "Liste électorale……….", Url = "http://www.therondels.fr/2013/12/liste-electorale/", Date = new DateTime(2013, 12, 19) });
            AddSettings(new Article() { Title = "ECOLE, séance des enfants et père Noël….", Url = "http://www.therondels.fr/2013/12/ecole-seance-des-enfants-et-pere-noel/", Date = new DateTime(2013, 12, 25) });
            AddSettings(new Article() { Title = "Le dossier du « Nouvel Observateur » du 2 janvier 2014", Url = "http://www.therondels.fr/2014/01/le-dossier-du-nouvel-observateur-du-2-janvier/", Date = new DateTime(2014, 01, 03) });
            AddSettings(new Article() { Title = "Cérémonie des voeux 2014", Url = "http://www.therondels.fr/2014/01/ceremonie-des-voeux-2014/", Date = new DateTime(2014, 01, 07) });
            AddSettings(new Article() { Title = "THERONDELS infos 2014", Url = "http://www.therondels.fr/2014/01/therondels-infos-2014/", Date = new DateTime(2014, 01, 09) });
            AddSettings(new Article() { Title = "Mérite Agricole", Url = "http://www.therondels.fr/2014/01/merite-agricole/", Date = new DateTime(2014, 01, 12) });
            AddSettings(new Article() { Title = "Vidange du lac de Sarrans 02", Url = "http://www.therondels.fr/2014/01/vidange-du-lac-de-sarrans-02/", Date = new DateTime(2014, 01, 17) });
            AddSettings(new Article() { Title = "THERONDELS (en Aubrac?)", Url = "http://www.therondels.fr/2014/02/therondels-en-aubrac/", Date = new DateTime(2014, 02, 03) });
            AddSettings(new Article() { Title = "« BAYSSOU » au salon de l’agriculture", Url = "http://www.therondels.fr/2014/02/bayssou-au-salon-de-lagriculture/", Date = new DateTime(2014, 02, 19) });
            AddSettings(new Article() { Title = "THERONDELS INFOS….", Url = "http://www.therondels.fr/2014/02/therondels-infos/", Date = new DateTime(2014, 02, 22) });
            AddSettings(new Article() { Title = "Nouveau Conseil Municipal", Url = "http://www.therondels.fr/2014/03/nouveau-conseil-municipal/", Date = new DateTime(2014, 03, 29) });
            AddSettings(new Article() { Title = "En vélo à THERONDELS…", Url = "http://www.therondels.fr/2014/04/en-velo-a-therondels/", Date = new DateTime(2014, 04, 15) });
            AddSettings(new Article() { Title = "Crédit Agricole NMP", Url = "http://www.therondels.fr/2014/04/credit-agricole-nmp-2/", Date = new DateTime(2014, 04, 21) });
            AddSettings(new Article() { Title = "Route de Laussac", Url = "http://www.therondels.fr/2014/04/route-de-laussac/", Date = new DateTime(2014, 04, 22) });
            AddSettings(new Article() { Title = "Barrage et lac de Sarrans au 30 avril", Url = "http://www.therondels.fr/2014/04/barrage-et-lac-de-sarrans-au-30-avril/", Date = new DateTime(2014, 04, 30) });
            AddSettings(new Article() { Title = "THERONDELS, un nouveau lien", Url = "http://www.therondels.fr/2014/04/therondels-un-nouveau-lien/", Date = new DateTime(2014, 04, 30) });
            AddSettings(new Article() { Title = "FOIRE DE PRINTEMPS", Url = "http://www.therondels.fr/2014/05/foire-de-printemps/", Date = new DateTime(2014, 05, 01) });
            AddSettings(new Article() { Title = "La foire de Printemps", Url = "http://www.therondels.fr/2014/05/la-foire-de-printemps/", Date = new DateTime(2014, 05, 21) });
            AddSettings(new Article() { Title = "Assemblée générale de la Coopérative", Url = "http://www.therondels.fr/2014/05/assemblee-generale-de-la-cooperative/", Date = new DateTime(2014, 05, 31) });
            AddSettings(new Article() { Title = "camping caristes en visite à Laussac", Url = "http://www.therondels.fr/2014/06/camping-caristes-en-visite-a-laussac/", Date = new DateTime(2014, 06, 18) });
            AddSettings(new Article() { Title = "THEATRE  » CAMINO »", Url = "http://www.therondels.fr/2014/07/theatre-camino-2/", Date = new DateTime(2014, 07, 06) });
            AddSettings(new Article() { Title = "Un chemin,une école", Url = "http://www.therondels.fr/2014/07/un-cheminune-ecole/", Date = new DateTime(2014, 07, 08) });
            AddSettings(new Article() { Title = "LAUSSAC dans la presse,", Url = "http://www.therondels.fr/2014/07/laussac-dans-la-presse/", Date = new DateTime(2014, 07, 22) });
            AddSettings(new Article() { Title = "du ciné à LAUSSAC tous LES MERCREDIS", Url = "http://www.therondels.fr/2014/07/du-cine-a-laussac/", Date = new DateTime(2014, 07, 23) });
            AddSettings(new Article() { Title = "DOUX-ALBATS, en musique", Url = "http://www.therondels.fr/2014/07/doux-albats-en-musique/", Date = new DateTime(2014, 07, 29) });
            AddSettings(new Article() { Title = "Championnat National de QUILLES de HUIT", Url = "http://www.therondels.fr/2014/08/8eme-de-finale-de-quille-de-huit/", Date = new DateTime(2014, 08, 01) });
            AddSettings(new Article() { Title = "Mardi des Sentiers", Url = "http://www.therondels.fr/2014/08/mardi-des-sentiers/", Date = new DateTime(2014, 08, 18) });
            AddSettings(new Article() { Title = "le cirque  » IDEAL CIRCUS »", Url = "http://www.therondels.fr/2014/08/le-cirque-ideal-circus/", Date = new DateTime(2014, 08, 21) });
            AddSettings(new Article() { Title = "FESTIVAL CHORAL", Url = "http://www.therondels.fr/2014/09/festival-choral/", Date = new DateTime(2014, 09, 14) });
            AddSettings(new Article() { Title = "équipe de foot.", Url = "http://www.therondels.fr/2014/10/equipe-de-foot/", Date = new DateTime(2014, 10, 11) });
            AddSettings(new Article() { Title = "FOIRE DES ANES. (suite)", Url = "http://www.therondels.fr/2014/10/foire-des-anes-grand-bal-avec-laurent-mallet/", Date = new DateTime(2014, 10, 19) });
            AddSettings(new Article() { Title = "La POSTE avec  » Vidange de SARRANS 2014 « ", Url = "http://www.therondels.fr/2014/10/19-aout-la-poste-avec-vidange-de-sarrans-2014/", Date = new DateTime(2014, 10, 22) });
            AddSettings(new Article() { Title = "le pont de LAUSSAC…", Url = "http://www.therondels.fr/2014/10/le-pont-de-laussac/", Date = new DateTime(2014, 10, 29) });
            AddSettings(new Article() { Title = "CONCOURS de la race AUBRAC.", Url = "http://www.therondels.fr/2014/11/concours-de-la-race-aubrac-aubrac/", Date = new DateTime(2014, 11, 02) });
            AddSettings(new Article() { Title = "LE THERONDELS….", Url = "http://www.therondels.fr/2014/11/le-therondels-3/", Date = new DateTime(2014, 11, 04) });
            AddSettings(new Article() { Title = "JUS de pomme ou cidre….", Url = "http://www.therondels.fr/2014/11/jus-de-pomme-ou-cidre/", Date = new DateTime(2014, 11, 15) });
            AddSettings(new Article() { Title = "Madame VAZELLE", Url = "http://www.therondels.fr/2014/11/madame-vazelle/", Date = new DateTime(2014, 11, 23) });
            AddSettings(new Article() { Title = "VISITEZ… les actualités ou mise à jour,", Url = "http://www.therondels.fr/2014/12/visitez-les-actualites-ou-mise-a-jour/", Date = new DateTime(2014, 12, 07) });
            AddSettings(new Article() { Title = "ECO-CITOYENS…", Url = "http://www.therondels.fr/2014/12/eco-citoyens/", Date = new DateTime(2014, 12, 13) });
            AddSettings(new Article() { Title = "5 Contes Musicaux", Url = "http://www.therondels.fr/2014/12/5-contes-musicaux/", Date = new DateTime(2014, 12, 19) });
            AddSettings(new Article() { Title = "les aînés du club des tilleuls", Url = "http://www.therondels.fr/2015/01/les-aines-du-club-des-tilleuls/", Date = new DateTime(2015, 01, 08) });
            AddSettings(new Article() { Title = "LES VOEUX 2015", Url = "http://www.therondels.fr/2015/01/les-voeux-2015/", Date = new DateTime(2015, 01, 09) });
            AddSettings(new Article() { Title = "THERONDELS infos 2015", Url = "http://www.therondels.fr/2015/01/therondels-infos-2015/", Date = new DateTime(2015, 01, 10) });
            AddSettings(new Article() { Title = "11 Janvier 2015", Url = "http://www.therondels.fr/2015/01/11-janvier-2015/", Date = new DateTime(2015, 01, 11) });
            AddSettings(new Article() { Title = "INFOS du Club des Tilleuls.", Url = "http://www.therondels.fr/2015/01/infos-du-club-des-tilleuls/", Date = new DateTime(2015, 01, 17) });
        }

        private static void AddSettings(Article article)
        {
            var settings = IsolatedStorageSettings.ApplicationSettings;
            if (!settings.Contains("article" + article.Title))
            {
                settings.Add("article" + article.Title, article);
            }
        }
    }
}