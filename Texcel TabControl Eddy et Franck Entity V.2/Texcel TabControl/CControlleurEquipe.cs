using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel_TabControl
{
    class CControlleurEquipe
    {
        DBProvider dbprovider = new DBProvider();
        public CControlleurEquipe() { }

        public List<CEquipe> listeDesEquipes()
        {
            
            List<string[]> lesEquipes = dbprovider.listeEquipes();
            List<CEquipe> listeDesEquipes = new List<CEquipe>();
            
            foreach (string[] equipe in lesEquipes)
            {
                CEquipe newEquipe = new CEquipe(Convert.ToInt16(equipe[0]), equipe[1], Convert.ToInt16(equipe[2]), Convert.ToInt16(equipe[3]));
                listeDesEquipes.Add(newEquipe);
            }
            return listeDesEquipes;
        }

        public List<CEmploye> listeEmployesParEquipe(int idEquipe)
        {
            List<string[]> listeEmployeParEquipe = dbprovider.listeEmployeParEquipe(idEquipe);
            List<CEmploye> listeDesEquipes = new List<CEmploye>();

            foreach (string[] employe in listeEmployeParEquipe)
            {
                CEmploye newEquipe = new CEmploye(Convert.ToInt32(employe[0]), employe[1], employe[2]);
                listeDesEquipes.Add(newEquipe);
            }
            return listeDesEquipes;
        }
        public int idMaxEquipe()
        {
            int noNewEquipe = dbprovider.idMaxEquipe();
            return noNewEquipe;
        }

        public void ajouterEquipe(string nomEquipe, int idChefEquipe, int idDirecteur)
        {
            dbprovider.ajouterEquipe(nomEquipe, idChefEquipe, idDirecteur);
        }
        public void ajouterMembreEquipe(List<int> listeNoMembre, int noNewEquipe)
        {
            dbprovider.ajouterMembreEquipe(listeNoMembre, noNewEquipe);
        }
    }
}
