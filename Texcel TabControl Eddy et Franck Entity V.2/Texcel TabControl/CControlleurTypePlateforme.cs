using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel_TabControl
{
    class CControlleurTypePlateforme
    {

        DBProvider dbprovider = new DBProvider();

        public CControlleurTypePlateforme()
        {

        }

        public void ajouterTypePlateforme()
        {

        }

        public void supprimerTypePlateforme()
        {

        }

        public List<CTypePlateforme> listeDesTypePlateformes()
        {

            List<string[]> lesTypePlateformes = dbprovider.listeDesTypePlateforme();
            List<CTypePlateforme> listeDesTypePlateformes = new List<CTypePlateforme>();

            foreach (string[] typePlateforme in lesTypePlateformes)
            {
                CTypePlateforme newTypePlateforme = new CTypePlateforme(Convert.ToInt32(typePlateforme[0]), typePlateforme[1]);
                listeDesTypePlateformes.Add(newTypePlateforme);
            }

            return listeDesTypePlateformes;
        }

        public int trouveIdTypePlateforme(string nomTypePlateforme)
        {
            return dbprovider.trouveIdTypePlateforme(nomTypePlateforme);
        }

       

        public string[] infosTypePlateforme(int idTypePlateforme)
        {
            return dbprovider.infosTypePlateforme(idTypePlateforme);
        }

    }
}
