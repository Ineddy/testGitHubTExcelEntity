using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel_TabControl
{
    class CControlleurGenre
    {

        DBProvider dbprovider = new DBProvider();
        public CControlleurGenre()
        {

        }

       
       

        public void ajouterGenre()
        {

        }

        public void supprimerGenre()
        {

        }
        public List<CGenre> listeDesGenresParJeu(int idJeu)
        {

            List<string> lesGenresParJeu = dbprovider.listeGenresJeu(idJeu);
            List<CGenre> listeDesPFenresParJeu = new List<CGenre>();

            foreach (string genre in lesGenresParJeu)
            {
                CGenre newGenre = new CGenre(genre);
                listeDesPFenresParJeu.Add(newGenre);
            }

            return listeDesPFenresParJeu;

        }

        public List<CGenre> listeDesGenres()
        {
            List<string[]> lesGenres = dbprovider.listeGenre();
            List<CGenre> listeDesGenres = new List<CGenre>();

            foreach (string[] genre in lesGenres)
            {
                CGenre newGenre = new CGenre(Convert.ToInt32(genre[0]), genre[1]);
                listeDesGenres.Add(newGenre);
            }

            return listeDesGenres;

        }
    }
}
