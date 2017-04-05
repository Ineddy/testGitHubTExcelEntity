using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel_TabControl
{
    class CClassification
    {
        int idClassification;
        string descriptionClassification;
        public CClassification(int idTClassification, string descriptionClassification)
        {
            this.idClassification = idTClassification;
            this.descriptionClassification = descriptionClassification;
        }
        //Utilisé pour l'affichage des listes de genres par jeu
        public CClassification(string descriptionClassification)
        {
            this.descriptionClassification = descriptionClassification;
        }

        public int IDClassification
        {
            get { return idClassification; }
            set { idClassification = value; }
        }
        public string DescriptionClassification
        {
            get { return descriptionClassification; }
            set { descriptionClassification = value; }
        }
    }
}
