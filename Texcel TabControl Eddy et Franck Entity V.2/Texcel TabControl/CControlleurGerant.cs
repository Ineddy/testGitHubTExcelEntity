using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel_TabControl
{
    class CControlleurGerant
    {
        DBProvider dbprovider = new DBProvider();
        public CControlleurGerant()
        {

        }

        public void ajouterGerant()
        {

        }

        public void supprimerGerant()
        {

        }

        public List<CGerant> listeDesGerants()
        {
            List<string[]> lesGerants = dbprovider.listeDesGerant();
            List<CGerant> listeDesGerants = new List<CGerant>();

            foreach (string[] gerant in lesGerants)
            {
                CGerant newGerant = new CGerant(Convert.ToInt32(gerant[0]), gerant[1], gerant[2], gerant[3]);
                listeDesGerants.Add(newGerant);
            }

            return listeDesGerants;
        }

        public bool existeGerantDansLaBd(string login, string motDePasse)
        {
            List<CGerant> listeDesGerants = this.listeDesGerants();
            bool existeDansLaBD = false;

            foreach (CGerant gerant in listeDesGerants)
            {
                if (gerant.Login == login && gerant.MotDePasse == motDePasse)
                {

                    existeDansLaBD = true;

                    break;
                }
            }

            return existeDansLaBD;

        }

        public string roleGerant(string login, string motDePasse)
        {
            string roleGerant = dbprovider.roleGerant(login, motDePasse);

            return roleGerant;
        }

    }


}
