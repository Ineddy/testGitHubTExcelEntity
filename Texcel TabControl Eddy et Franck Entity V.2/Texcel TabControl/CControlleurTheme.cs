using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel_TabControl
{
    class CControlleurTheme
    {
        DBProvider dbprovider = new DBProvider();
        public CControlleurTheme()
        {

        }
        public List<CTheme> listeDesThemesParJeu(int idJeu)
        {

            List<string> lesThemesParJeu = dbprovider.listeThemeJeu(idJeu);
            List<CTheme> listeDesThemesParJeu = new List<CTheme>();

            foreach (string theme in lesThemesParJeu)
            {
                CTheme newTheme = new CTheme(theme);
                listeDesThemesParJeu.Add(newTheme);
            }
            return listeDesThemesParJeu;
        }

        public List<CTheme> listeDesTheme()
        {
            List<string[]> lesThemes = dbprovider.listeTheme();
            List<CTheme> listeDesTheme = new List<CTheme>();

            foreach (string[] theme in lesThemes)
            {
                CTheme newTheme = new CTheme(Convert.ToInt32(theme[0]), theme[1]);
                listeDesTheme.Add(newTheme);
            }

            return listeDesTheme;

        }




    }
}
