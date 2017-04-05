using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel_TabControl
{
    class CEquipe
    {
        int idEquipe;
        string nom;
        int idChefEquipe;
        int idDirecteur;
        List<CEmploye> listeEmployeParEquipe;
        CControlleurEquipe monControlleurEquipe = new CControlleurEquipe();


        // Test de commentaires pour le test github
        public CEquipe() { }
        public CEquipe(int idEquipe, string nom, int idChefEquipe, int idDirecteur)
        {
            this.idEquipe = idEquipe;
            this.nom = nom;
            this.idChefEquipe = idChefEquipe;
            this.idDirecteur = idDirecteur;
            listeEmployeParEquipe = monControlleurEquipe.listeEmployesParEquipe(idEquipe);
        }

        public string NomEquipe
        {
            get { return nom; }

            set { nom = value; }
        }
        public int IdEquipe
        {
            get { return idEquipe; }

            set { idEquipe = value; }
        }
        public int IdChefEquipe
        {
            get { return idChefEquipe; }

            set { idChefEquipe = value; }
        }
        public int IdDirecteur
        {
            get { return idDirecteur; }

            set { idDirecteur = value; }
        }


    }
}
