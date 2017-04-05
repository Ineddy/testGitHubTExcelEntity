using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel_TabControl
{
    class CAdministrateur : CGerant
    {
        int idAdministrateur;
        public CAdministrateur(int idAdministrateur) : base(idAdministrateur)
        {
            this.idAdministrateur = idAdministrateur;
        }

        public int IdAdministrateur
        {
            get { return idAdministrateur; }

            set { idAdministrateur = value; }
        }


    }
}
