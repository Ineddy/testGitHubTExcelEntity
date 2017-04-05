using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Texcel_TabControl
{
    public partial class creerPlateforme : Form
    {
        CControlleurTypePlateforme controlleurTypePlateforme = new CControlleurTypePlateforme();
        CControlleurOS controlleurSE = new CControlleurOS();
        CControlleurPlateforme controlleurPlateforme = new CControlleurPlateforme();
        frmTexcel frmTexcel;

        Regex regexNomPlateforme = new Regex(@"([A-Z]|[a-z]){1,}");
        Regex regexConfigPlateforme = new Regex(@"([A-Z]|[a-z]){1,}");
        public creerPlateforme(frmTexcel frmTexcel)
        {
            InitializeComponent();
            this.frmTexcel = frmTexcel;
        }

        private void creerPlateforme_Load(object sender, EventArgs e)
        {

            chargerLesTypePlateforme();
            chargerLesSE();

        }

        private void chargerLesTypePlateforme()
        {
            List<CTypePlateforme> listeDesTypePlateformes = controlleurTypePlateforme.listeDesTypePlateformes();

            foreach (CTypePlateforme typePlateforme in listeDesTypePlateformes)
            {
                cbTypePlateforme.Items.Add(typePlateforme.NomTypePlateforme);
            }

        }

        private void chargerLesSE()
        {

            List<CSE> lesOS = controlleurSE.listeDesOS();

            dgvOS.Rows.Clear();

            foreach (CSE OS in lesOS)
            {
                dgvOS.Rows.Add(OS.CodeSE,OS.NomSE, OS.EditionSE, OS.VersionSE);
            }

        }

        private void btnAjouterSE_Click(object sender, EventArgs e)
        {

        }

        private bool saisieValide()
        {
            bool saisieValide = false;

            int selectedRowCount = dgvOS.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (regexNomPlateforme.IsMatch(txtNomPlateforme.Text) && regexConfigPlateforme.IsMatch(rtbConfigPlateforme.Text) && cbTypePlateforme.Text != "" && selectedRowCount != 0)
            {
                saisieValide = true;
            }

            return saisieValide;

        }

        private void btnAjouterPLateforme_Click(object sender, EventArgs e)
        {
            if (saisieValide())
            {
                string nomPlateforme = txtNomPlateforme.Text;
                string nomTypePlateforme = cbTypePlateforme.Text;
                string configurationPlateforme = rtbConfigPlateforme.Text;
                //string nomSE = dgvOS.CurrentRow.Cells["dgvNomOS"].Value.ToString();
                //string editionSE = dgvOS.CurrentRow.Cells["dgvEditionOS"].Value.ToString();
                //string versionSE = dgvOS.CurrentRow.Cells["dgvVersionOS"].Value.ToString();
                int codeSE = (int)dgvOS.CurrentRow.Cells["dgvNoSE"].Value;
                int idTypePlateforme = controlleurTypePlateforme.trouveIdTypePlateforme(nomTypePlateforme);


                if (controlleurPlateforme.existeDansLaBD(nomPlateforme, configurationPlateforme, idTypePlateforme, codeSE))
                {
                    MessageBox.Show(" Création impossible. Plateforme existante. ");
                }
                else
                {
                    controlleurPlateforme.ajouterPlateforme(nomPlateforme, configurationPlateforme, idTypePlateforme, codeSE);
                    MessageBox.Show(" Plateforme créee!!!! ");
                    frmTexcel.updateToutesLesInformations();
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show(" Données invalides !!!! Verifiez que vous avez bien selectionné les options et saisi les données ");
            }
        }

      
    }
}
