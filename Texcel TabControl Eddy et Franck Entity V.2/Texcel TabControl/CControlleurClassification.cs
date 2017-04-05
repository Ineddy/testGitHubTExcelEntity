using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel_TabControl
{
    class CControlleurClassification
    {
        DBProvider dbprovider = new DBProvider();
        public CControlleurClassification()
        {

        }
        public List<CClassification> listeDesClassificationsParJeu(int idJeu)
        {

            List<string> lesClassificationParJeu = dbprovider.listeClassificationJeu(idJeu);
            List<CClassification> listeDesThemesParJeu = new List<CClassification>();

            foreach (string classification in lesClassificationParJeu){
                CClassification newClassification = new CClassification(classification);
                listeDesThemesParJeu.Add(newClassification);
            }
            return listeDesThemesParJeu;
        }

        public List<CClassification> listeDesClassification()
        {
            List<string[]> lesClassification = dbprovider.listeClassification();
            List<CClassification> listeDesClassification = new List<CClassification>();

            foreach (string[] classification in lesClassification)
            {
                CClassification newClassification = new CClassification(Convert.ToInt32(classification[0]), classification[1]);
                listeDesClassification.Add(newClassification);
            }

            return listeDesClassification;

        }
    }
}
