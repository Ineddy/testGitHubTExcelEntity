using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel_TabControl
{
    class CGerant
    {
        protected int idGerant;
        protected string login, motDePasse, role;

        public CGerant(int idGerant, string login, string motDePasse, string role)
        {
            this.idGerant = idGerant;
            this.login = login;
            this.motDePasse = motDePasse;
            this.role = role;
        }

        public CGerant(int idGerant)
        {
            this.idGerant = idGerant;
        }

        public int IdGerant
        {
            get { return idGerant; }

            set { idGerant = value; }
        }

        public string Login
        {
            get { return login; }

            set { login = value; }
        }

        public string MotDePasse
        {
            get { return motDePasse; }

            set { motDePasse = value; }
        }

        public string Role
        {
            get { return role; }

            set { role = value; }
        }

    }
}
