using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel_TabControl
{
    class CControlleurPlateforme
    {

        DBProvider dbprovider = new DBProvider();
        public CControlleurPlateforme()
        {

        }

        public void ajouterPlateforme(string nomPlateforme, string configurationPlateforme, int idTypePlateforme, int codeSE)
        {
            dbprovider.ajouterPlateforme(nomPlateforme, configurationPlateforme, idTypePlateforme, codeSE);
        }

        public void supprimerPlateforme()
        {

        }

        public List<CPlateforme> listeDesPlateformes()
        {

            List<string[]> lesPlateformes = dbprovider.listeDesPlateformes();
            List<CPlateforme> listeDesPlateformes = new List<CPlateforme>();

            foreach (string[] plateforme in lesPlateformes)
            {
                CPlateforme newPlateforme = new CPlateforme(Convert.ToInt32(plateforme[0]), plateforme[1], plateforme[2], Convert.ToInt32(plateforme[3]), Convert.ToInt32(plateforme[4]));
                listeDesPlateformes.Add(newPlateforme);
            }

            return listeDesPlateformes;

        }

        public List<CPlateforme> listeDesPlateformesParJeu(int idJeu)
        {

            List<string> lesPlateformesParJeu = dbprovider.listePlateformesJeu(idJeu);
            List<CPlateforme> listeDesPlateformesParJeu = new List<CPlateforme>();

            foreach (string plateforme in lesPlateformesParJeu)
            {
                CPlateforme newPlateforme = new CPlateforme(plateforme);
                listeDesPlateformesParJeu.Add(newPlateforme);
            }

            return listeDesPlateformesParJeu;

        }

        public bool existeDansLaBD(string nomPlateforme, string configurationPlateforme, int idTypePlateforme, int codeSE)
        {
            List<CPlateforme> listeDesPlateformes = this.listeDesPlateformes();
            bool existeDansLaBD = false;

            foreach (CPlateforme plateforme in listeDesPlateformes)
            {
                if (plateforme.NomPlateforme == nomPlateforme && plateforme.ConfigurationPlateforme == configurationPlateforme && plateforme.IdTypePlateforme == idTypePlateforme && plateforme.CodeSE == codeSE)
                {
                    existeDansLaBD = true;

                    break;
                }

            }

            return existeDansLaBD;

        }

        public string trouveNomTypePlateforme(int idTypePlateforme)
        {
            return dbprovider.trouveNomTypePlateforme(idTypePlateforme);
        }

        public int nombreJeuPlateforme(int idPlateforme)
        {
            return dbprovider.nombreJeuPlateforme(idPlateforme);
        }

        public void supprimerPlateforme(int idPlateforme)
        {
            dbprovider.supprimerPlateforme(idPlateforme);
        }

        public List<CPlateforme> rechercheInfoPlateforme(string motCle)
        {
            List<string[]> listePlateformesRecherche = dbprovider.listeRecherchePlateforme(motCle);
            List<CPlateforme> listePlateformes = new List<CPlateforme>();
            foreach(string[] stringPlateforme in listePlateformesRecherche)
            {
                CPlateforme plateformeTrouvée = new CPlateforme(Convert.ToInt32(stringPlateforme[0]), stringPlateforme[1].ToString(), stringPlateforme[2].ToString(), stringPlateforme[3].ToString(), stringPlateforme[4].ToString());
                listePlateformes.Add(plateformeTrouvée);
            }
            return listePlateformes;

        }

        public string[] infosPlateforme(int idPlateforme)
        {
            return dbprovider.infosPlateforme(idPlateforme);
        }

        public void updatePlateforme(int idPlateforme, string nomPlateforme, string configurationPlateforme, int idTypePlateforme, int codeSE)
        {
            dbprovider.updatePlateforme(idPlateforme, nomPlateforme, configurationPlateforme, idTypePlateforme, codeSE);
        }


        /*plateforme[0] = lecteur["idPlateforme"].ToString();
        plateforme[1] = lecteur["nomPlateforme"].ToString();
        plateforme[2] = lecteur["configurationPlateforme"].ToString();
        plateforme[3] = lecteur["idTypePlateforme"].ToString();
        plateforme[4] = lecteur["codeSE"].ToString();*/

    }


}
