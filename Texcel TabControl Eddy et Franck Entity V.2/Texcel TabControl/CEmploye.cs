using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel_TabControl
{
    class CEmploye
    {
        int idEmploye, idVille;
        string nomEmploye, prenomEmploye, adresseEmploye1, adresseEmploye2, codePostalEmploye, telephoneResidenceEmploye, posteTelephoniqueEmploye, matriculeEmploye;
        DateTime dateNaissanceEmploye;
        public CEmploye(int idEmploye, string nomEmploye, string prenomEmploye, DateTime dateNaissanceEmploye, string adresseEmploye1, string adresseEmploye2, string codePostalEmploye, string telephoneResidenceEmploye, string posteTelephoniqueEmploye, string matriculeEmploye, int idVille)
        {
            this.idEmploye = idEmploye;
            this.nomEmploye = nomEmploye;
            this.prenomEmploye = prenomEmploye;
            this.dateNaissanceEmploye = dateNaissanceEmploye;
            this.adresseEmploye1 = adresseEmploye1;
            this.adresseEmploye2 = adresseEmploye2;
            this.codePostalEmploye = codePostalEmploye;
            this.telephoneResidenceEmploye = telephoneResidenceEmploye;
            this.posteTelephoniqueEmploye = posteTelephoniqueEmploye;
            this.matriculeEmploye = matriculeEmploye;
            this.idVille = idVille;
        }

        /*
            Classe employe
            Classe employe2    
        */

        //Constructeur utilisé pour généré une liste des employés d'une équipe
        public CEmploye(int idEmploye, string nomEmploye, string prenomEmploye)
        {
            this.idEmploye = idEmploye;
            this.nomEmploye = nomEmploye;
            this.prenomEmploye = prenomEmploye;
        }

        public int IdEmploye
        {
            get { return idEmploye; }

            set { idEmploye = value; }
        }

        public int IdVille
        {
            get { return idVille; }

            set { idVille = value; }
        }

        public string NomEmploye
        {
            get { return nomEmploye; }

            set { nomEmploye = value; }
        }

        public string PrenomEmploye
        {
            get { return prenomEmploye; }

            set { prenomEmploye = value; }
        }

        public string AdresseEmploye1
        {
            get { return adresseEmploye1; }

            set { adresseEmploye1 = value; }
        }

        public string AdresseEmploye2
        {
            get { return adresseEmploye2; }

            set { adresseEmploye2 = value; }
        }

        public string CodePostalEmploye
        {
            get { return codePostalEmploye; }

            set { codePostalEmploye = value; }
        }

        public string TelephoneResidenceEmploye
        {
            get { return telephoneResidenceEmploye; }

            set { telephoneResidenceEmploye = value; }
        }

        public string PosteTelephoniqueEmploye
        {
            get { return posteTelephoniqueEmploye; }

            set { posteTelephoniqueEmploye = value; }
        }

        public string MatriculeEmploye
        {
            get { return matriculeEmploye; }

            set { matriculeEmploye = value; }
        }




    }
}
