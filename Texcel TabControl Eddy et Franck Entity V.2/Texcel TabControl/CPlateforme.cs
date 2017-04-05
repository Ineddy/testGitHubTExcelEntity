using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel_TabControl
{
    class CPlateforme
    {
        int idPlateforme, idTypePlateforme, codeSE;
        string nomPlateforme, configurationPlateforme;
        string nomTypePlateforme, tagPlateforme; //(Utilisé pour la recherche de plateforme)

        public CPlateforme(int idPlateforme, string nomPlateforme, string configurationPlateforme, int idTypePlateforme, int codeSE)
        {
            this.idPlateforme = idPlateforme;
            this.nomPlateforme = nomPlateforme;
            this.configurationPlateforme = configurationPlateforme;
            this.idTypePlateforme = idTypePlateforme;
            this.codeSE = codeSE;
            this.tagPlateforme = null;
        }

        //Constructeur utilisé pour la recherche de plateformne
        public CPlateforme(int idPlateforme, string nomPlateforme, string configurationPlateforme, string nomTypePlateforme, string tagPlateforme)
        {
            this.idPlateforme = idPlateforme;
            this.nomPlateforme = nomPlateforme;
            this.configurationPlateforme = configurationPlateforme;
            this.nomTypePlateforme = nomTypePlateforme;
            this.tagPlateforme = tagPlateforme;

        }

        public CPlateforme(string nomPlateforme)
        {
            this.nomPlateforme = nomPlateforme;
        }

        public int IdPlateforme
        {
            get { return idPlateforme; }

            set { idPlateforme = value; }
        }

        public int IdTypePlateforme
        {
            get { return idTypePlateforme; }

            set { idTypePlateforme = value; }
        }

        public int CodeSE
        {
            get { return codeSE; }

            set { codeSE = value; }
        }

        public string NomPlateforme
        {
            get { return nomPlateforme; }

            set { nomPlateforme = value; }
        }

        public string ConfigurationPlateforme
        {
            get { return configurationPlateforme; }

            set { configurationPlateforme = value; }
        }

        public string NomTypePlateforme
        {
            get { return nomTypePlateforme; }

            set { nomTypePlateforme = value; }
        }


    }
}
