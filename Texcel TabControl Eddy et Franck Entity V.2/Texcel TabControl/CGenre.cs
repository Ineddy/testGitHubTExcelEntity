using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel_TabControl
{
    class CGenre
    {
        int idGenre;
        string descriptionGenre;
        public CGenre(int idGenre, string descriptionGenre)
        {
            this.idGenre = idGenre;
            this.descriptionGenre = descriptionGenre;
        }
        //Utilisé pour l'affichage des listes de genres par jeu
        public CGenre(string descriptionGenre)
        {
            this.descriptionGenre = descriptionGenre;
        }

        public int IDGenre
        {
            get { return idGenre; }
            set { idGenre = value; }
        }
        public string DescriptionGenre
        {
            get { return descriptionGenre; }
            set { descriptionGenre = value; }
        }
    }
}
