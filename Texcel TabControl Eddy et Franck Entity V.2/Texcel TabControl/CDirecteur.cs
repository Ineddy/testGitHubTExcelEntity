using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel_TabControl
{
    class CDirecteur : CGerant
    {
        int idDirecteur;
        public CDirecteur(int idDirecteur) : base(idDirecteur)
        {
            this.idDirecteur = idDirecteur;
        }

        public int IdDirecteur
        {
            get { return idDirecteur; }

            set { idDirecteur = value; }
        }


    }
}
