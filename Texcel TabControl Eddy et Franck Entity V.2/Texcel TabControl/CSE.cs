using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texcel_TabControl
{
    //Test comentaire dans ma branche
    class CSE
    {
        int codeSE;
        string nomSE, editionSE, versionSE, tag;
        public CSE(int codeSE, string nomSE, string editionSE, string versionSE)
        {
            this.codeSE = codeSE;
            this.nomSE = nomSE;
            this.editionSE = editionSE;
            this.versionSE = versionSE;
            this.tag = null;
        }

        public CSE(string nomSE, string editionSE, string versionSE)
        {
            this.nomSE = nomSE;
            this.editionSE = editionSE;
            this.versionSE = versionSE;
            this.tag = null;
        }
        //Utilisé pour le module de recherche SE
        public CSE(int codeSE, string nomSE, string editionSE, string versionSE, string tag)
        {
            this.codeSE = codeSE;
            this.nomSE = nomSE;
            this.editionSE = editionSE;
            this.versionSE = versionSE;
            this.tag = tag;
        }

        public int CodeSE
        {
            get { return codeSE; }

            set { codeSE = value; }
        }

        public string NomSE
        {
            get { return nomSE; }

            set { nomSE = value; }
        }

        public string EditionSE
        {
            get { return editionSE; }

            set { editionSE = value; }
        }

        public string VersionSE
        {
            get { return versionSE; }

            set { versionSE = value; }
        }


    }

}
