using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel_TabControl
{
    class CControlleurEmploye
    {
        DBProvider dbprovider = new DBProvider();

        public CControlleurEmploye()
        {

        }

        public List<CEmploye> listeDesEmployes()
        {

            List<string[]> lesEmployes = dbprovider.listeDesEmployes();
            List<CEmploye> listeDesEmployes = new List<CEmploye>();

            foreach (string[] employe in lesEmployes)
            {
                //Attention les villes ne sont pas correcte mais on ne les utilises pas pour l'instant
                CEmploye newEmploye = new CEmploye(Convert.ToInt16(employe[0]), employe[1], employe[2], Convert.ToDateTime(employe[3]),employe[4],"",employe[5],employe[6],employe[7],"",1); //Attention les villes ne sont pas correcte mais on ne les utilises pas pour l'instant
                listeDesEmployes.Add(newEmploye);
            }
            return listeDesEmployes;
        }
        public List<string[]> listeDesEmployesString()
        {
            List<string[]> listeDesEmployes = dbprovider.listeDesEmployes();
            return listeDesEmployes;
        }

    }
}
