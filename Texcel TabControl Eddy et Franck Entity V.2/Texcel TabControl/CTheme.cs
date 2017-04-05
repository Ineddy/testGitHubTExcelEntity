using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel_TabControl
{
    class CTheme
    {
        int idTheme;
        string descriptionTheme;
        public CTheme(int idTheme, string descriptionTheme)
        {
            this.idTheme = idTheme;
            this.descriptionTheme = descriptionTheme;
        }
        //Utilisé pour l'affichage des listes de genres par jeu
        public CTheme(string descriptionTheme)
        {
            this.descriptionTheme = descriptionTheme;
        }

        public int IDTheme
        {
            get { return idTheme; }
            set { idTheme = value; }
        }
        public string DescriptionTheme
        {
            get { return descriptionTheme; }
            set { descriptionTheme = value; }
        }
    }
}
