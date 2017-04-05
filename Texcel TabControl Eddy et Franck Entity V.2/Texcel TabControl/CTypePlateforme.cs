using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel_TabControl
{
    class CTypePlateforme
    {

        int idTypePlateforme;
        string nomTypePlateforme;
        public CTypePlateforme(int idTypePlateforme, string nomTypePlateforme)
        {
            this.idTypePlateforme = idTypePlateforme;
            this.nomTypePlateforme = nomTypePlateforme;
        }

        public string NomTypePlateforme
        {
            get { return nomTypePlateforme; }

            set { nomTypePlateforme = value; }
        }

        public int IdTypePlateforme
        {
            get { return idTypePlateforme; }

            set { idTypePlateforme = value; }
        }

    }
}
