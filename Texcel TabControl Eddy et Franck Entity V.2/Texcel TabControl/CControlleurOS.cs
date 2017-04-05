using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Texcel_TabControl
{
    class CControlleurOS
    {
        DBProvider dbprovider = new DBProvider();
        public CControlleurOS()
        {

        }


        public void ajouterOS(string nomSE, string editionSE, string versionSE)
        {
            dbprovider.ajouterOS(nomSE, editionSE, versionSE);
        }


        public void supprimerOS(int codeSE)
        {
            dbprovider.supprimerOS(codeSE);
        }

        public int trouveCodeSE(string nomSE, string editionSE, string versionSE)
        {
            return dbprovider.trouveCodeSE(nomSE, editionSE, versionSE);
        }

        public int nombrePlateformeOS(int codeSE)
        {
            return dbprovider.nombrePlateformeOS(codeSE);
        }

        public List<CSE> listeDesOS()
        {

            List<string[]> lesOS = dbprovider.listeDesOS();
            List<CSE> listeDesOS = new List<CSE>();

            foreach (string[] OS in lesOS)
            {
                CSE newOS = new CSE(Convert.ToInt32(OS[0]), OS[1], OS[2], OS[3]);
                listeDesOS.Add(newOS);
            }

            return listeDesOS;

        }

        public bool existeDansLaBD(string nomSE, string editionSE, string versionSE)
        {
            List<CSE> listeDesOS = this.listeDesOS();
            bool existeDansLaBD = false;

            foreach (CSE os in listeDesOS)
            {
                if (os.NomSE == nomSE && os.EditionSE == editionSE && os.VersionSE == versionSE)
                {
                    existeDansLaBD = true;

                    break;
                }

            }

            return existeDansLaBD;

        }

        public List<CSE> rechercheInfoSE(string motCle)
        {
            List<string[]> listeSERecherche = dbprovider.listeRechercheSE(motCle);
            List<CSE> listeSE = new List<CSE>();
            foreach (string[] stringPlateforme in listeSERecherche)
            {
                CSE plateformeTrouvée = new CSE(Convert.ToInt32(stringPlateforme[0]), stringPlateforme[1].ToString(), stringPlateforme[2].ToString(), stringPlateforme[3].ToString(), stringPlateforme[4].ToString());
                listeSE.Add(plateformeTrouvée);
            }
            return listeSE;

        }

        public void updateSE(int codeSE, string nomSE, string editionSE, string versionSE)
        {
            dbprovider.updateSE(codeSE, nomSE, editionSE, versionSE);
        }

        public string[] infosSE(int codeSE)
        {
            return dbprovider.infosSE(codeSE);
        }


    }
}
