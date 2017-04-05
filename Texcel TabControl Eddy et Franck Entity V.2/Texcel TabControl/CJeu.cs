using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel_TabControl
{
    class CJeu
    {
        int idJeu, idProjetTest;
        string nomJeu, devellopeurJeu, descriptionJeu, configurationMinimaleJeu;
        CControlleurPlateforme monControlleurPlateforme = new CControlleurPlateforme();
        CControlleurGenre monControlleurGenre = new CControlleurGenre();
        CControlleurTheme monControlleurTheme = new CControlleurTheme();
        CControlleurClassification monControlleurClassification = new CControlleurClassification();
        List<CPlateforme> plateformesJeu;
        List<CGenre> genresJeu;
        List<CTheme> themesJeu;
        List<CClassification> classificationJeu;


        public CJeu(int idJeu, string nomJeu, string devellopeurJeu, string descriptionJeu, string configurationMinimaleJeu, int idProjetTest)
        {
            this.idJeu = idJeu;
            this.nomJeu = nomJeu;
            this.devellopeurJeu = devellopeurJeu;
            this.descriptionJeu = descriptionJeu;
            this.configurationMinimaleJeu = configurationMinimaleJeu;
            this.idProjetTest = idProjetTest;
            plateformesJeu = monControlleurPlateforme.listeDesPlateformesParJeu(idJeu);
            genresJeu = monControlleurGenre.listeDesGenresParJeu(idJeu);
            themesJeu = monControlleurTheme.listeDesThemesParJeu(idJeu);
            classificationJeu = monControlleurClassification.listeDesClassificationsParJeu(idJeu);
        }

        public CJeu(int idJeu, string nomJeu, string devellopeurJeu, string descriptionJeu, string configurationMinimaleJeu)
        {
            this.idJeu = idJeu;
            this.nomJeu = nomJeu;
            this.devellopeurJeu = devellopeurJeu;
            this.descriptionJeu = descriptionJeu;
            this.configurationMinimaleJeu = configurationMinimaleJeu;
            plateformesJeu = monControlleurPlateforme.listeDesPlateformesParJeu(idJeu);
            genresJeu = monControlleurGenre.listeDesGenresParJeu(idJeu);
            themesJeu = monControlleurTheme.listeDesThemesParJeu(idJeu);
            classificationJeu = monControlleurClassification.listeDesClassificationsParJeu(idJeu);
        }

        public string NomJeu
        {
            get { return nomJeu; }

            set { nomJeu = value; }
        }

        public string DevellopeurJeu
        {
            get { return devellopeurJeu; }

            set { devellopeurJeu = value; }
        }


        public string DescriptionJeu
        {
            get { return descriptionJeu; }

            set { descriptionJeu = value; }
        }

        public string ConfigurationMinimaleJeu
        {
            get { return configurationMinimaleJeu; }

            set { configurationMinimaleJeu = value; }
        }

        public int IdJeu
        {
            get { return idJeu; }

            set { idJeu = value; }
        }
        public int IdProjetTest
        {
            get { return idProjetTest; }

            set { idProjetTest = value; }
        }

        public List<CPlateforme> PlateformesJeu
        {
            get { return plateformesJeu; }

            set { plateformesJeu = value; }
        }
        public List<CGenre> GenresJeu
        {
            get { return genresJeu; }

            set { genresJeu = value; }
        }
        public List<CTheme> ThemesJeu
        {
            get { return themesJeu; }

            set { themesJeu = value; }
        }
        public List<CClassification> ClassificationJeu
        {
            get { return classificationJeu; }

            set { classificationJeu = value; }
        }

    }
}
