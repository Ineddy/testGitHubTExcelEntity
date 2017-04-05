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
    public partial class creerSE : Form
    {
        CControlleurOS controlleurOS = new CControlleurOS();
        Regex regexNomEdition = new Regex(@"^([A-Z]|[a-z]){1,}$");
        Regex regexVersion = new Regex(@"([0-9]|[.])");
        frmTexcel frmTexcel;
        public creerSE(frmTexcel frmTexcel)
        {
            InitializeComponent();
            this.frmTexcel = frmTexcel;
        }

        private void brtnAjouterSE_Click(object sender, EventArgs e)
        {
            CSE newOS = new CSE(txtNomSE.Text, txtEditionSE.Text, txtVersionSE.Text);

            if (verifieSaisie() == true)
            {
                if (controlleurOS.existeDansLaBD(txtNomSE.Text, txtEditionSE.Text, txtVersionSE.Text))// si l'os a ajouter existe deja dans la BD
                {
                    MessageBox.Show(" Ajout impossible. Ce systeme d'exploitation existe déja dans la base de donnée !!!! ");
                }
                else
                {
                    controlleurOS.ajouterOS(txtNomSE.Text, txtEditionSE.Text, txtVersionSE.Text);
                    MessageBox.Show(" Ajout effectué avec succès !!!! ");
                    frmTexcel.updateToutesLesInformations();
                    this.Close();
                    //txtNomSE.Text = "";
                    //txtEditionSE.Text = "";
                    //txtVersionSE.Text = "";
                }

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Saisie incorrecte. Verifiez la valeur inscrite dans chacun des champs!!!", "Informations pas correctes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool verifieSaisie()
        {
            bool saisieCorrecte = false;

            if (regexNomEdition.IsMatch(txtEditionSE.Text) && regexNomEdition.IsMatch(txtNomSE.Text) && regexVersion.IsMatch(txtVersionSE.Text))
            {
                saisieCorrecte = true;
            }

            return saisieCorrecte;

        }

    }
}
