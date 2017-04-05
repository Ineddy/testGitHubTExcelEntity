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
    public partial class frmModifierSE : Form
    {

        CControlleurOS controlleurOS = new CControlleurOS();
        Regex regexNomEdition = new Regex(@"^([A-Z]|[a-z]){1,}$");
        Regex regexVersion = new Regex(@"([0-9]|[.])");
        frmTexcel frmTexcel;
        public frmModifierSE(frmTexcel frmTexcel)
        {
            InitializeComponent();
            this.frmTexcel = frmTexcel;


        }

        private void btnModifierSE_Click(object sender, EventArgs e)
        {
            if (verifieSaisie() == true)
            {
               
                if (controlleurOS.existeDansLaBD(txtNomSE.Text, txtEditionSE.Text, txtVersionSE.Text))// si l'os a ajouter existe deja dans la BD
                {
                    MessageBox.Show(" Modification impossible. Ce systeme d'exploitation existe déja dans la base de donnée !!!! ");
                }
                else
                {
                    controlleurOS.updateSE(Convert.ToInt32(this.Tag), txtNomSE.Text, txtEditionSE.Text, txtVersionSE.Text);
                    MessageBox.Show(" Modification effectué avec succès !!!! ");
                    this.Close();
                    frmTexcel.updateToutesLesInformations();
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

        private void modifierSE_Load(object sender, EventArgs e)
        {
            this.txtNomSE.Text = controlleurOS.infosSE(Convert.ToInt32(this.Tag))[1];
            this.txtEditionSE.Text = controlleurOS.infosSE(Convert.ToInt32(this.Tag))[2];
            this.txtVersionSE.Text = controlleurOS.infosSE(Convert.ToInt32(this.Tag))[3];
        }
    }
}
