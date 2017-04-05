using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel_TabControl
{
    class CControlleuJeu
    {

        DBProvider dbprovider = new DBProvider();

        public CControlleuJeu()
        {

        }

        

        public void supprimerJeu()
        {

        }

        public List<CJeu> listeDesJeux()
        {
            List<string[]> lesJeux = dbprovider.listeDesJeux();
            List<CJeu> listeDesJeux = new List<CJeu>();

            foreach (string[] jeu in lesJeux)
            {
                //CJeu newJeu = new CJeu(Convert.ToInt32(jeu[0]), jeu[1], jeu[2], jeu[3], jeu[4],Convert.ToInt32(jeu[5]));
                CJeu newJeu = new CJeu(Convert.ToInt32(jeu[0]), jeu[1], jeu[2], jeu[3], jeu[4]);
                listeDesJeux.Add(newJeu);
            }

                return listeDesJeux;
        }

        public void ajouterClassificationJeu(int idClassification, int idJeu)
        {
            dbprovider.ajouterClassificationJeu(idClassification, idJeu);
        }

        public void ajouterGenreJeu(int idClassification, int idJeu)
        {
            dbprovider.ajouterGenreJeu(idClassification, idJeu);
        }

        public void ajouterThemeJeu(int idClassification, int idJeu)
        {
            dbprovider.ajouterThemeJeu(idClassification, idJeu);
        }
        public void ajouterPlateformeJeu(int idClassification, int idJeu)
        {
            dbprovider.ajouterPlateformeJeu(idClassification, idJeu);
        }

        public bool existeDansLaBD(string nomJeu, string devellopeurJeu, string descriptionJeu,string configMinimaleJeu)
        {
            List<CJeu> listeDesJeux = this.listeDesJeux();
            bool existeDansLaBD = false;

            foreach (CJeu jeu in listeDesJeux)
            {
                if (jeu.NomJeu == nomJeu && jeu.DevellopeurJeu == devellopeurJeu && jeu.DescriptionJeu == descriptionJeu && jeu.ConfigurationMinimaleJeu == configMinimaleJeu)
                {
                    existeDansLaBD = true;

                    break;
                }

            }

            return existeDansLaBD;

        }

        public List<string> rechercheInfoJeu(string motCle)
        {
            List<string> listeResultatsRecherche = dbprovider.listeRecherche(motCle);
            return listeResultatsRecherche;

        }

        public void ajouterJeu(string nomJeu, string devellopeurJeu, string descriptionJeu, string configurationJeu)
        {
            dbprovider.ajouterJeu(nomJeu, devellopeurJeu, descriptionJeu, configurationJeu);
        }

        public int idMaxJeu()
        {
            return dbprovider.idMaxJeu();
        }

        public void supprimerJeu(int idJeu)
        {          
            dbprovider.supprimerPlateformeJeu(idJeu);
            dbprovider.supprimerThemeJeu(idJeu);
            dbprovider.supprimerGenreJeu(idJeu);
            dbprovider.supprimerClassificationJeu(idJeu);
            dbprovider.supprimerJeu(idJeu);
        }

   }
}
