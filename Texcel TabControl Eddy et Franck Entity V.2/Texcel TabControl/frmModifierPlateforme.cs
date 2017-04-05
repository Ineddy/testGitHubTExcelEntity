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
    public partial class frmModifierPlateforme : Form
    {
        CControlleurTypePlateforme controlleurTypePlateforme = new CControlleurTypePlateforme();
        CControlleurOS controlleurSE = new CControlleurOS();
        CControlleurPlateforme controlleurPlateforme = new CControlleurPlateforme();
        Regex regexNomPlateforme = new Regex(@"([A-Z]|[a-z]){1,}");
        Regex regexConfigPlateforme = new Regex(@"([A-Z]|[a-z]){1,}");
        frmTexcel frmTexcel;

        public frmModifierPlateforme(frmTexcel frmTexcel)
        {
            InitializeComponent();
            this.frmTexcel = frmTexcel;
        }

        private void frmModifierPlateforme_Load(object sender, EventArgs e)
        {
            chargerLesTypePlateforme();
            chargerLesSE();

            txtNomPlateforme.Text = controlleurPlateforme.infosPlateforme(Convert.ToInt32(this.Tag))[1];

            rtbConfigPlateforme.Text = controlleurPlateforme.infosPlateforme(Convert.ToInt32(this.Tag))[2];

            cbTypePlateforme.Text = controlleurTypePlateforme.infosTypePlateforme(Convert.ToInt32(controlleurPlateforme.infosPlateforme(Convert.ToInt32(this.Tag))[3]))[1];

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
                dgvOS.Rows.Add(OS.CodeSE, OS.NomSE, OS.EditionSE, OS.VersionSE);
            }
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

        private void btnModifierPLateforme_Click(object sender, EventArgs e)
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
                    MessageBox.Show(" Modification impossible. Plateforme existante. ");
                }
                else
                {
                    controlleurPlateforme.updatePlateforme(Convert.ToInt32(this.Tag), nomPlateforme, configurationPlateforme, idTypePlateforme, codeSE);
                    MessageBox.Show(" Plateforme modifiée!!!! ");
                    this.Close();
                    frmTexcel.updateToutesLesInformations();
                }

            }
            else
            {
                MessageBox.Show(" Données invalides !!!! Verifiez que vous avez bien selectionné les options et saisi les données ");
            }
        }

       
    }
}
