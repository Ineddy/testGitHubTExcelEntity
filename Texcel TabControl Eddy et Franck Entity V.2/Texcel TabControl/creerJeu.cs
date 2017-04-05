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
    public partial class creerJeu : Form
    {
        CControlleurGenre controlleurGenre = new CControlleurGenre();
        CControlleurClassification controlleurClassification = new CControlleurClassification();
        CControlleurTheme controlleurTheme = new CControlleurTheme();
        CControlleurPlateforme controlleurPlateforme = new CControlleurPlateforme();
        CControlleuJeu controlleurJeu = new CControlleuJeu();
        Regex regex = new Regex(@"([A-Z]|[a-z]){1,}");
        frmTexcel frmTexcel;

        public creerJeu(frmTexcel frmTexcel)
        {
            InitializeComponent();
            chargerClassification();
            chargerGenre();
            chargerPlateforme();
            chargerTheme();
            this.frmTexcel = frmTexcel;
        }

        private void chargerClassification()
        {
            dgvClassification.Rows.Clear();
            List<CClassification> listeClassification = controlleurClassification.listeDesClassification();

            foreach (CClassification classification in listeClassification)
            {
                dgvClassification.Rows.Add(classification.IDClassification, classification.DescriptionClassification);
            }
        }

        private void chargerGenre()
        {
            dgvGenre.Rows.Clear();
            List<CGenre> listeGenre = controlleurGenre.listeDesGenres();

            foreach (CGenre genre in listeGenre)
            {
                dgvGenre.Rows.Add(genre.IDGenre, genre.DescriptionGenre);
            }
        }

        private void chargerTheme()
        {
            dgvTheme.Rows.Clear();
            List<CTheme> listeTheme = controlleurTheme.listeDesTheme();

            foreach (CTheme theme in listeTheme)
            {
                dgvTheme.Rows.Add(theme.IDTheme, theme.DescriptionTheme);
            }

        }

        private void chargerPlateforme()
        {
            List<CPlateforme> lesPlateformes = controlleurPlateforme.listeDesPlateformes();

            dgvPlateforme.Rows.Clear();

            foreach (CPlateforme plateforme in lesPlateformes)
            {
                string nomTypePlateforme = controlleurPlateforme.trouveNomTypePlateforme(plateforme.IdTypePlateforme);
                dgvPlateforme.Rows.Add(plateforme.IdPlateforme, plateforme.NomPlateforme, nomTypePlateforme, plateforme.CodeSE);
            }
        }

        private void btnAjouterJeu_Click(object sender, EventArgs e)
        {
            string nomJeu = txtNomJeu.Text;
            string devellopeurJeu = txtDeveloppeurJeu.Text;
            string descriptionJeu = rtbDescriptionJeu.Text;
            string configurationJeu = rtbConfigurationJeu.Text;

            int selectedRowClassification = dgvClassification.Rows.GetRowCount(DataGridViewElementStates.Selected);
            int selectedRowGenre = dgvGenre.Rows.GetRowCount(DataGridViewElementStates.Selected);
            int selectedRowTheme = dgvTheme.Rows.GetRowCount(DataGridViewElementStates.Selected);
            int selectedRowPlateforme = dgvPlateforme.Rows.GetRowCount(DataGridViewElementStates.Selected);
            int idJeu;

            if (saisieValide())
            {
                if(controlleurJeu.existeDansLaBD(nomJeu,devellopeurJeu,descriptionJeu,configurationJeu))
                {
                    MessageBox.Show(" Création impossible. Jeu existant. ");
                }
                else
                {
                    controlleurJeu.ajouterJeu(nomJeu, devellopeurJeu, descriptionJeu, configurationJeu);

                    idJeu = controlleurJeu.idMaxJeu();

                    for (int i = 0; i < selectedRowClassification; i++)
                    {
                        controlleurJeu.ajouterClassificationJeu((Int32)dgvClassification.SelectedRows[i].Cells["dgvNoClassification"].Value,idJeu);
                    }

                    for (int i = 0; i < selectedRowGenre; i++)
                    {
                        controlleurJeu.ajouterGenreJeu((Int32)dgvGenre.SelectedRows[i].Cells["dgvNoGenre"].Value, idJeu);
                    }

                    for (int i = 0; i < selectedRowTheme; i++)
                    {
                        controlleurJeu.ajouterThemeJeu((Int32)dgvTheme.SelectedRows[i].Cells["dgvNoTheme"].Value, idJeu);
                    }

                    for (int i = 0; i < selectedRowPlateforme; i++)
                    {
                        controlleurJeu.ajouterPlateformeJeu((Int32)dgvPlateforme.SelectedRows[i].Cells["dgvNoPlateforme"].Value, idJeu);
                    }

                    MessageBox.Show(" Jeu créee!!!! ");
                    frmTexcel.afficheOngletListeJeux();
                    frmTexcel.afficheLesJeux();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(" Données invalides !!!! Verifiez que vous avez bien selectionné les options et saisi les données ");
            }
        }

        private bool saisieValide()
        {
            bool saisieValide = false;

            int selectedRowClassification = dgvClassification.Rows.GetRowCount(DataGridViewElementStates.Selected);
            int selectedRowGenre = dgvGenre.Rows.GetRowCount(DataGridViewElementStates.Selected);
            int selectedRowTheme = dgvTheme.Rows.GetRowCount(DataGridViewElementStates.Selected);
            int selectedRowPlateforme = dgvPlateforme.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if ( regex.IsMatch(txtNomJeu.Text) && regex.IsMatch(txtDeveloppeurJeu.Text) && regex.IsMatch(rtbConfigurationJeu.Text) && regex.IsMatch(rtbDescriptionJeu.Text) && selectedRowClassification!=0 && selectedRowGenre !=0 && selectedRowTheme!=0 && selectedRowPlateforme!=0)
            {
                saisieValide = true;
            }

            return saisieValide;

        }
    }
}
