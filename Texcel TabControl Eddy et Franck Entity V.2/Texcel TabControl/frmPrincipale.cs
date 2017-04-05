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
    public partial class frmTexcel : Form
    {
        //DBProvider dbprovider = new DBProvider();  // Est amené à disparaitre ?????? SI on a le temps...

        CControlleuJeu controlleurJeu = new CControlleuJeu();
        CControlleurPlateforme controlleurPlateforme = new CControlleurPlateforme();
        CControlleurOS controlleurOS = new CControlleurOS();
        CControlleurTypePlateforme controlleurTypePlateforme = new CControlleurTypePlateforme();
        CControlleurGerant controlleurGerant = new CControlleurGerant();
        CControlleurEquipe monControleurEquipe = new CControlleurEquipe();
        CControlleurEmploye monControleurEmploye = new CControlleurEmploye();

        Regex regexLoginMotDePasse = new Regex(@"^([A-Z]|[a-z]|[0-9]){1,}$");
        public frmTexcel()
        {
            InitializeComponent();

            afficheLesJeux();
            afficheLesOS();
            afficheLesPlateformes();
            afficheEmploye();
            afficheOngletListeJeux();
            affichelisteEquipe();

        }

        private void btnAdminTemp_Click(object sender, EventArgs e)
        {
            interfaceAdmin();


        }

        private void btnDirecteurTemp_Click(object sender, EventArgs e)
        {
            interfaceDirecteur();

        }

        private void interfaceAdmin()
        {
            tabControlFonctionnalites.Enabled = true;
            tabControlFonctionnalites.Visible = true;
            lblBienvenue.Text = "Bienvenue Administrateur";

            //il peut creer un jeu, une plateforme, un OS
            btnCreerJeu.Enabled = true;
            btnCreerJeu.Visible = true;
            btnCreerPlateforme.Enabled = true;
            btnCreerPlateforme.Visible = true;
            btnCreerSE.Enabled = true;
            btnCreerSE.Visible = true;
            btnCreerEmploye.Enabled = true;
            btnCreerEmploye.Visible = true;
            btnAjouterOngletSE.Enabled = true;
            btnAjouterOngletSE.Visible = true;
            btnSupprimerSEOngletSE.Enabled = true;
            btnSupprimerSEOngletSE.Visible = true;
            btnSEModifier.Enabled = true;
            btnSEModifier.Visible = true;
            btnAjouterPlateforme2.Enabled = true;
            btnAjouterPlateforme2.Visible = true;
            btnSupprimerPlateformeOngletPlateforme.Enabled = true;
            btnSupprimerPlateformeOngletPlateforme.Visible = true;
            btnModifierOngletPlateformes.Enabled = true;
            btnModifierOngletPlateformes.Visible = true;
            btnSupprimerJeuOngletJeu.Enabled = true;
            btnSupprimerJeuOngletJeu.Visible = true;
            btnCreerJeuOngletJeu.Enabled = true;
            btnCreerJeuOngletJeu.Visible = true;


            //un administrateur ne peut pas former d'équipe
            btnFormerEquipe.Enabled = false;
            btnFormerEquipe.Visible = false;

            btnSupprimerJeu.Enabled = true;
            btnSupprimerJeu.Visible = true;
            btnSupprimerPlateforme.Enabled = true;
            btnSupprimerPlateforme.Visible = true;
            btnSupprimerSO.Enabled = true;
            btnSupprimerSO.Visible = true;
        }
        private void interfaceDirecteur()
        {
            tabControlFonctionnalites.Enabled = true;
            tabControlFonctionnalites.Visible = true;
            lblBienvenue.Text = "Bienvenue M. le directeur";
            
            //un directeur ne peut pas cree un jeu, un OS ou une plateforme
            btnCreerJeu.Enabled = false;
            btnCreerJeu.Visible = false;
            btnCreerPlateforme.Enabled = false;
            btnCreerPlateforme.Visible = false;
            btnCreerSE.Enabled = false;
            btnCreerSE.Visible = false;
            btnCreerEmploye.Enabled = false;
            btnCreerEmploye.Visible = false;

            btnAjouterOngletSE.Enabled = false;
            btnAjouterOngletSE.Visible = false;
            btnSupprimerSEOngletSE.Enabled = false;
            btnSupprimerSEOngletSE.Visible = false;
            btnSEModifier.Enabled = false;
            btnSEModifier.Visible = false;

            btnAjouterPlateforme2.Enabled = false;
            btnAjouterPlateforme2.Visible = false;
            btnSupprimerPlateformeOngletPlateforme.Enabled = false;
            btnSupprimerPlateformeOngletPlateforme.Visible = false;
            btnModifierOngletPlateformes.Enabled = false;
            btnModifierOngletPlateformes.Visible = false;

            btnSupprimerJeuOngletJeu.Enabled = false;
            btnSupprimerJeuOngletJeu.Visible = false;
            btnCreerJeuOngletJeu.Enabled = false;
            btnCreerJeuOngletJeu.Visible = false;


            //il peut former une equipe
            btnFormerEquipe.Enabled = true;
            btnFormerEquipe.Visible = true;
            btnSupprimerJeu.Enabled = false;
            btnSupprimerJeu.Visible = false;
            btnSupprimerPlateforme.Enabled = false;
            btnSupprimerPlateforme.Visible = false;
            btnSupprimerSO.Enabled = false;
            btnSupprimerSO.Visible = false;

        }

        private void btnSeDeconnecter_Click(object sender, EventArgs e)
        {
            tabControlFonctionnalites.Enabled = false;
            tabControlFonctionnalites.Visible = false;
            
        }

        private void btnCreerSE_Click(object sender, EventArgs e)
        {
            creerSE FrmCreerSE = new creerSE(this);
            FrmCreerSE.StartPosition=FormStartPosition.CenterScreen;
            //FrmCreerSE.PointToScreen(new Point(200,200));
            FrmCreerSE.Show();
        }

        private void btnCreerPlateforme_Click(object sender, EventArgs e)
        {
            creerPlateforme FrmCreerPlateforne = new creerPlateforme(this);
            FrmCreerPlateforne.StartPosition = FormStartPosition.CenterScreen;
            FrmCreerPlateforne.Show();
        }

        private void btnCreerJeu_Click(object sender, EventArgs e)
        {
            creerJeu FrmJeu = new creerJeu(this);
            FrmJeu.StartPosition = FormStartPosition.CenterScreen;
            FrmJeu.Show();
        }


        //Affichage des jeux dans l'onglet Tableaux de bord

        public void afficheLesJeux()
        {
            List<CJeu> lesJeux = controlleurJeu.listeDesJeux();
            dgvListeJeux.Rows.Clear();
            dgvListeOngletJeux.Rows.Clear();

            foreach (CJeu jeu in lesJeux)
            {
                dgvListeJeux.Rows.Add(jeu.IdJeu,jeu.NomJeu, jeu.DevellopeurJeu);
                dgvListeOngletJeux.Rows.Add(jeu.IdJeu, jeu.NomJeu, jeu.DevellopeurJeu);
            }

        }

        //Affichage des jeux dans l'onglet Tableaux de bord
        public void afficheOngletListeJeux()
        {
            dgvListeOngletJeux.Rows.Clear();
            List<CJeu> listeJeux = controlleurJeu.listeDesJeux();

            foreach (CJeu jeu in listeJeux)
            {
                dgvListeOngletJeux.Rows.Add(jeu.IdJeu,jeu.NomJeu, jeu.DevellopeurJeu);
            }

        }

        public void affichelisteEquipe()
        {
            dgvEquipes.Rows.Clear();
            //List<string[]> listeEquipe = dbprovider.listeEquipes();
            CControlleurEquipe monControleurEquipe = new CControlleurEquipe();  //SI on utilise pas il faudra supprimer cette méthode
            string listeEmploye="";
            List<CEquipe> listeEquipe = monControleurEquipe.listeDesEquipes();
            foreach (CEquipe equipe in listeEquipe)
            {

                //Déterminer et concaténer la liste des équipiers par équipe
                List<CEmploye> listeEmployeParEquipe = monControleurEquipe.listeEmployesParEquipe(equipe.IdEquipe);
                foreach (CEmploye employe in listeEmployeParEquipe)
               {
                    listeEmploye = listeEmploye + employe.NomEmploye + " " + employe.PrenomEmploye + " (" + employe.IdEmploye + ") - ";
                }
                listeEmploye = listeEmploye + ".";

               //lblPlateformeJeu.Text = listePlateformes;
               

                dgvEquipes.Rows.Add(equipe.IdEquipe, equipe.NomEquipe, listeEmploye);
                //Afficher la liste des équipiers dans la 3eme colonne
                listeEmploye = "";
               
            }
        }

        public void afficheLesOS()
        {
            List<CSE> lesOS = controlleurOS.listeDesOS();

            dgvSE1.Rows.Clear();
            dgvSE2.Rows.Clear();

            foreach (CSE OS in lesOS)
            {
                dgvSE1.Rows.Add(OS.CodeSE, OS.NomSE, OS.EditionSE, OS.VersionSE);
                dgvSE2.Rows.Add(OS.CodeSE, OS.NomSE, OS.EditionSE, OS.VersionSE);
            }

        }
        //public void afficheLesPlateformes()
        //{
        //    List<CTypePlateforme> lesTypePlateforme = controlleurTypePlateforme.listeDesTypePlateformes();
        //    List<CPlateforme> lesPlateformes = controlleurPlateforme.listeDesPlateformes();
        //    dgvPlateformes.Rows.Clear();
        //    foreach (CPlateforme plateforme in lesPlateformes)
        //    {
        //        foreach (CTypePlateforme typePlateforme in lesTypePlateforme)
        //        {
        //            if (plateforme.IdTypePlateforme == typePlateforme.IdTypePlateforme)
        //            {
        //                dgvPlateformes.Rows.Add(plateforme.IdPlateforme, plateforme.NomPlateforme, typePlateforme.NomTypePlateforme);
        //                break;
        //            }
        //        }
        //    }
        //}

        public void afficheLesPlateformes()
        {      
            List<CPlateforme> lesPlateformes = controlleurPlateforme.listeDesPlateformes();
            dgvPlateforme1.Rows.Clear();
            dgvPlateforme2.Rows.Clear();

            foreach (CPlateforme plateforme in lesPlateformes)
            {
                string nomTypePlateforme = controlleurPlateforme.trouveNomTypePlateforme(plateforme.IdTypePlateforme);
                dgvPlateforme1.Rows.Add(plateforme.IdPlateforme, plateforme.NomPlateforme, nomTypePlateforme, plateforme.CodeSE);
                dgvPlateforme2.Rows.Add(plateforme.IdPlateforme, plateforme.NomPlateforme, plateforme.ConfigurationPlateforme, nomTypePlateforme);
            }
        }

        public void afficheEmploye()
        {
            //List<string[]> listeEmployes = dbprovider.listeDesEmployes();
            //Remplacer la liste ci-dessus par une liste d'objet
            CControlleurEmploye monControleurEmploye = new CControlleurEmploye();
            List<CEmploye> listeEmployes = monControleurEmploye.listeDesEmployes();
            dgvEmployes.Rows.Clear();

            foreach (CEmploye employe in listeEmployes)
            {
                dgvEmployes.Rows.Add(employe.IdEmploye, employe.NomEmploye, employe.PrenomEmploye);
            }
        }


        private void frmTexcel_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bdTexcelDataSet.tblSE'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.tblSETableAdapter.Fill(this.bdTexcelDataSet.tblSE);
        }

        private void dgvEmployes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Pour utiliser une liste de CEpmploye il faut d'abord modifier son constructeur et la requete qui récupère par exemple le nom de la ville et 
            //non l'id de la ville alors qu'il nous faut cet id pour générer une liste d'employé valide.
            //La liste d'objet actuel est utilisé dans le dgv car on y affice pas les villes qui sont erronées.
           
        }

        private void dgvEmployes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            //lblNom.Text = "TessttCellule";
            //e.RowIndex
            int index = e.RowIndex;
            MessageBox.Show(index.ToString());
            */
        }

        private void btnFormerEquipe_Click(object sender, EventArgs e)
        {
            //List<string[]> listeEmployes = dbprovider.listeDesEmployes();
            CControlleurEmploye monControleurEmploye = new CControlleurEmploye();
            List<CEmploye> listeEmployes = monControleurEmploye.listeDesEmployes();
            List<int> listeNoMembre = new List<int>();
            Int32 selectedRowCount = dgvEmployes.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                String nomEmploye;
                String prenomEmploye;
                int noNewEquipe;

                for (int i = 0; i < selectedRowCount; i++)
                {

                    sb.Append("Employé: ");
                    //sb.Append(dgvEmployes.SelectedRows[i].Index.ToString());


                    foreach (CEmploye employe in listeEmployes)
                    {
                        int noEmploye = (Int32)dgvEmployes.SelectedRows[i].Cells["dgvNoEmploye"].Value;
                        if (employe.IdEmploye == noEmploye)
                        {
                            //lblNomEmploye.Text = employe.NomEmploye;
                            nomEmploye = employe.NomEmploye;
                            prenomEmploye = employe.PrenomEmploye; ;
                            sb.Append(noEmploye + " " + nomEmploye + " " + prenomEmploye);
                            listeNoMembre.Add(noEmploye);
                        }
                    }


                    sb.Append(Environment.NewLine);
                }

                sb.Append(selectedRowCount.ToString() + " membres dans l'équipe créée");
                MessageBox.Show(sb.ToString(), "Formation d'un nouvequ groupe terminée");

                //noNewEquipe = dbprovider.idMaxEquipe();
                noNewEquipe = monControleurEquipe.idMaxEquipe();

                noNewEquipe = noNewEquipe + 1;        //Fonctionnait avant de remettre la bd à zéro... Retiré depuis

                //Insertion dans la bd
                //Création de l'équipe
                monControleurEquipe.ajouterEquipe("Equipe " + noNewEquipe, 1, 8); //Pour l'instant l'employé 1 sera dans toutes les équipes et chef d'équipe et le directeur créateur sera 8 par défaut. En attendant de pouvoir préciser le nom de l'équipe il prendra la valeur datetime



                //Mis à jours de la table d'intersection
                monControleurEquipe.ajouterMembreEquipe(listeNoMembre, noNewEquipe);
                //Actualise l'affichage
                updateToutesLesInformations();

            }
            else
            {
                MessageBox.Show("Veuillez sélectionner des employés");
            }
        }

        private void dgvListeOngletJeux_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Veuillez selectionner une ligne et non une cellule !");

        }

        private void dgvListeOngletJeux_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            //Trop long à charger à chaque clic, doit trouver une solution pour ne pas charger à chaque fois...
            // Comment peut-on passer cette liste de jeux en paramètre ou l'utiliser en paramètre gobale  ?
            //this.dgvListeOngletJeux.Enabled = false;  //Ne fonctionne pas
            

        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            if (regexLoginMotDePasse.IsMatch(txtLogin.Text) && regexLoginMotDePasse.IsMatch(txtPsw.Text))
            {
                if(controlleurGerant.existeGerantDansLaBd(txtLogin.Text, txtPsw.Text))
                {
                    //MessageBox.Show(" Utilisateur valide ");

                    if(controlleurGerant.roleGerant(txtLogin.Text, txtPsw.Text) == "directeur")
                    {
                        MessageBox.Show("Ouverture de session en mode directeur");
                        interfaceDirecteur();
                    }
                    else
                    {
                        MessageBox.Show("Ouverture de session en mode administrateur");
                        interfaceAdmin();
                    }

                }
                else
                {
                    MessageBox.Show(" Données invalide");
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Saisie incorrecte. Verifiez la valeur inscrite dans chacun des champs!!!", "Informations pas correctes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            dgvRecheche.Rows.Clear();
            //Essayer de placer le traitement de la recherche ici.
            //MessageBox.Show("Test");
            String motCle = txtRecherche.Text;
            List<string> listeResultatsRecherche = controlleurJeu.rechercheInfoJeu(motCle);

            foreach (string resultat in listeResultatsRecherche)
            {
                dgvRecheche.Rows.Add(resultat);
            }
        }

        public void updateToutesLesInformations()
        {
            //Peut être lancer les updates en fonctions des actions, et non tous les updates en même temps...
            //Passage de paramètre pour updater l'affichage souhaité aussi possible
            afficheLesJeux();
            afficheLesOS();
            afficheLesPlateformes();
            afficheEmploye();
            afficheOngletListeJeux();
            affichelisteEquipe();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimerSO_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dgvSE1.Rows.GetRowCount(DataGridViewElementStates.Selected);

            int selectedCellCount = dgvSE1.GetCellCount(DataGridViewElementStates.Selected);


            if (selectedCellCount > 0 || selectedRowCount > 0)
            {

                int codeSE;

                if (selectedCellCount > 0)
                {
                    int indexClique = Convert.ToInt32(dgvSE1.SelectedCells[0].RowIndex);

                    codeSE = Convert.ToInt32(dgvSE1.Rows[indexClique].Cells["dgvNoSE"].Value);
                }
                else
                {
                    codeSE = Convert.ToInt32(dgvSE1.CurrentRow.Cells["dgvNoSE"].Value);
                }

                DialogResult dialogResult = MessageBox.Show("Voulez-vous supprimer cet OS?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    if (controlleurOS.nombrePlateformeOS(codeSE) == 0)
                    {
                        controlleurOS.supprimerOS(codeSE);
                        MessageBox.Show(" Suppression éffectuée avec succès ");
                        afficheLesOS();
                    }
                    else
                    {
                        MessageBox.Show(" Impossible de supprimer cet OS car il est lié à une ou plusieurs plateformes ");
                    }
                }

            }
            else
            {
                MessageBox.Show(" Aucune cellule ou ligne n'est selectionnée n'a été selectionnée!!! ");
            }

           

        }

        private void lblClassificationJeu_Click(object sender, EventArgs e)
        {

        }

        private void lblGenreJeu_Click(object sender, EventArgs e)
        {

        }

        private void lblGenre_Click(object sender, EventArgs e)
        {

        }

        private void lblClassification_Click(object sender, EventArgs e)
        {

        }

        private void txtRecherche_Enter(object sender, EventArgs e)
        {
            dgvRecheche.Visible = true;
        }

        private void btnCreerEmploye_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fonctioonnalité en cours de développement. Bientôt disonible !");
        }

        private void dgvListeOngletJeux_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dgvListeOngletJeux_SelectionChanged(object sender, EventArgs e)
        {
            List<CJeu> listeJeux = controlleurJeu.listeDesJeux();
            //int index = e.RowIndex;
            //lblNomEmploye.Text = index.ToString();
            int noJeu;
            int selectedRowCount = dgvListeOngletJeux.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount != 0)
            {

                foreach (CJeu jeu in listeJeux)
                {
                    noJeu = (Int32)dgvListeOngletJeux.SelectedRows[0].Cells["dgvNoJeu"].Value;

                    string listePlateformes = "";
                    string listeGenres = "";
                    string listeThemes = "";
                    string listeclassification = "";

                    if (jeu.IdJeu == noJeu)
                    {
                        lblOngletJeuNomJeu.Text = jeu.NomJeu;
                        lblDeveloppeurJeu.Text = jeu.DevellopeurJeu;
                        //Récupère les plateforme du jeu selectionné

                        foreach (CPlateforme plateforme in jeu.PlateformesJeu)
                        {
                            listePlateformes = listePlateformes + plateforme.NomPlateforme + " ";
                        }
                        listePlateformes = listePlateformes + ".";

                        lblPlateformeJeu.Text = listePlateformes;

                        //Récupère les genres du jeu selectionné

                        foreach (CGenre genre in jeu.GenresJeu)
                        {
                            listeGenres = listeGenres + genre.DescriptionGenre + " ";
                        }
                        listeGenres = listeGenres + ".";

                        lblGenreJeu.Text = listeGenres;

                        //Récupère les thèmes du jeu selectionné

                        foreach (CTheme theme in jeu.ThemesJeu)
                        {
                            listeThemes = listeThemes + theme.DescriptionTheme + " ";
                        }
                        listeThemes = listeThemes + ".";

                        lblThemeJeu.Text = listeThemes;

                        //Récupère les classifications du jeu selectionné

                        foreach (CClassification classe in jeu.ClassificationJeu)
                        {
                            listeclassification = listeclassification + classe.DescriptionClassification + " ";
                        }
                        listeclassification = listeclassification + ".";

                        lblClassificationJeu.Text = listeclassification;

                        lblDescriptionJeu.Text = jeu.DescriptionJeu;
                        lblConfigJeu.Text = jeu.ConfigurationMinimaleJeu;
                    }
                }
                //this.dgvListeOngletJeux.Enabled = true;

            }
        }

        private void dgvEmployes_SelectionChanged(object sender, EventArgs e)
        {
            List<string[]> listeEmployes = monControleurEmploye.listeDesEmployesString();
            int selectedRowCount = dgvEmployes.Rows.GetRowCount(DataGridViewElementStates.Selected);
            int noEmploye;
            //int index = e.RowIndex;
            //lblNomEmploye.Text = index.ToString();

            if (selectedRowCount != 0)
            {
                foreach (string[] employe in listeEmployes)
                {
                    noEmploye = (Int32)dgvEmployes.SelectedRows[0].Cells["dgvNoEmploye"].Value;
                    if (employe[0] == noEmploye.ToString())
                    {
                        lblNomEmploye.Text = employe[1];
                        lblPrenomEmploye.Text = employe[2];
                        lblDdnEmploye.Text = employe[3];
                        lblAdresseLigne1.Text = employe[4];
                        lblAdresseCP.Text = employe[5];
                        lblAdresseVille.Text = employe[8];
                        lblTelEmploye.Text = employe[6];
                        lblServiceEmploye.Text = employe[7];
                    }
                }
            }
            
        }

        private void btnSupprimerJeu_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dgvListeJeux.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0)
            {
                int idJeu = Convert.ToInt32(dgvListeJeux.CurrentRow.Cells["dgvNumeroJeu"].Value);

                DialogResult dialogResult = MessageBox.Show("Voulez-vous supprimer ce jeu?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    controlleurJeu.supprimerJeu(idJeu);
                    MessageBox.Show(" Suppression éffectuée avec succès ");
                    afficheLesJeux();
                }
            }
            else
            {
                MessageBox.Show(" Aucun jeu n'a été selectionnée!!! ");
               
            }

        }

        private void btnSupprimerPlateforme_Click(object sender, EventArgs e)
        {

            int selectedRowCount = dgvPlateforme1.Rows.GetRowCount(DataGridViewElementStates.Selected);

            int selectedCellCount = dgvPlateforme1.GetCellCount(DataGridViewElementStates.Selected);


            if (selectedCellCount > 0 || selectedRowCount > 0)
            {

                int idPlateforme;

                if (selectedCellCount > 0)
                {
                    int indexClique = Convert.ToInt32(dgvPlateforme1.SelectedCells[0].RowIndex);

                    idPlateforme = Convert.ToInt32(dgvPlateforme1.Rows[indexClique].Cells["dgvNoPlateforme"].Value);
                }
                else
                {
                    idPlateforme = Convert.ToInt32(dgvPlateforme1.CurrentRow.Cells["dgvNoPlateforme"].Value);
                }

                DialogResult dialogResult = MessageBox.Show("Voulez-vous supprimer cette plateforme?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    if (controlleurPlateforme.nombreJeuPlateforme(idPlateforme) == 0)
                    {
                        controlleurPlateforme.supprimerPlateforme(idPlateforme);
                        MessageBox.Show(" Suppression éffectuée avec succès ");
                        afficheLesPlateformes();
                    }
                    else
                    {
                        MessageBox.Show(" Impossible de supprimer cette plateforme car elle est liée à un ou plusieurs jeux ");
                    }
                }

            }
            else
            {
                MessageBox.Show(" Aucune cellule ou ligne n'est selectionnée n'a été selectionnée!!! ");
            }
            
        }

        private void btnAjouterOngletSE_Click(object sender, EventArgs e)
        {
            creerSE FrmCreerSE = new creerSE(this);
            FrmCreerSE.StartPosition = FormStartPosition.CenterScreen;
            //FrmCreerSE.PointToScreen(new Point(200,200));
            FrmCreerSE.Show();
        }

        private void btnSupprimerSEOngletSE_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dgvSE2.Rows.GetRowCount(DataGridViewElementStates.Selected);

            int selectedCellCount = dgvSE2.GetCellCount(DataGridViewElementStates.Selected);

            
            if(selectedCellCount > 0 || selectedRowCount > 0)
            {

                int codeSE;

                if (selectedCellCount > 0)
                {
                    int indexClique = Convert.ToInt32(dgvSE2.SelectedCells[0].RowIndex);

                     codeSE = Convert.ToInt32(dgvSE2.Rows[indexClique].Cells["dgvCodeSE"].Value);
                }
                else
                {
                     codeSE = Convert.ToInt32(dgvSE2.CurrentRow.Cells["dgvCodeSE"].Value);
                }

                DialogResult dialogResult = MessageBox.Show("Voulez-vous supprimer cet OS?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    if (controlleurOS.nombrePlateformeOS(codeSE) == 0)
                    {
                        controlleurOS.supprimerOS(codeSE);
                        MessageBox.Show(" Suppression éffectuée avec succès ");
                        afficheLesOS();
                    }
                    else
                    {
                        MessageBox.Show(" Impossible de supprimer cet OS car il est lié à une ou plusieurs plateformes ");
                    }
                }

            }
            else
            {
                MessageBox.Show(" Aucune cellule ou ligne n'est selectionnée n'a été selectionnée!!! ");
            }

            
        }

        private void btnSupprimerPlateformeOngletPlateforme_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dgvPlateforme2.Rows.GetRowCount(DataGridViewElementStates.Selected);

            int selectedCellCount = dgvPlateforme2.GetCellCount(DataGridViewElementStates.Selected);


            if (selectedCellCount > 0 || selectedRowCount > 0)
            {

                int idPlateforme;

                if (selectedCellCount > 0)
                {
                    int indexClique = Convert.ToInt32(dgvPlateforme2.SelectedCells[0].RowIndex);

                    idPlateforme = Convert.ToInt32(dgvPlateforme2.Rows[indexClique].Cells["dgvIdPlateforme"].Value);
                }
                else
                {
                    idPlateforme = Convert.ToInt32(dgvPlateforme2.CurrentRow.Cells["dgvIdPlateforme"].Value);
                }

                DialogResult dialogResult = MessageBox.Show("Voulez-vous supprimer cette plateforme?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    if (controlleurPlateforme.nombreJeuPlateforme(idPlateforme) == 0)
                    {
                        controlleurPlateforme.supprimerPlateforme(idPlateforme);
                        MessageBox.Show(" Suppression éffectuée avec succès ");
                        afficheLesPlateformes();
                    }
                    else
                    {
                        MessageBox.Show(" Impossible de supprimer cette plateforme car elle est liée à un ou plusieurs jeux ");
                    }
                }

            }
            else
            {
                MessageBox.Show(" Aucune cellule ou ligne n'est selectionnée n'a été selectionnée!!! ");
            }

        }

        private void btnAjouterPlateforme2_Click(object sender, EventArgs e)
        {
            creerPlateforme FrmCreerPlateforne = new creerPlateforme(this);
            FrmCreerPlateforne.StartPosition = FormStartPosition.CenterScreen;
            FrmCreerPlateforne.Show();
        }


        //textBoxRechechrePlateforme
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dgvPlateforme2.Rows.Clear();

            String motCle = textBoxRechechrePlateforme.Text;
            List<CPlateforme> listeResultatsRecherche = controlleurPlateforme.rechercheInfoPlateforme(motCle);

            foreach (CPlateforme resultat in listeResultatsRecherche)
            {
                dgvPlateforme2.Rows.Add(resultat.IdPlateforme, resultat.NomPlateforme, resultat.ConfigurationPlateforme, resultat.NomTypePlateforme);
            }
        }

        //textBoxRechercheSE
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvSE2.Rows.Clear();

            String motCle = textBoxRechercheSE.Text;
            List<CSE> listeResultatsRecherche = controlleurOS.rechercheInfoSE(motCle);

            foreach (CSE resultat in listeResultatsRecherche)
            {
                dgvSE2.Rows.Add(resultat.CodeSE, resultat.NomSE, resultat.EditionSE, resultat.VersionSE);
            }
        }

        private void dgvPlateforme2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Test " + e.ColumnIndex);
        }

        private void dgvListeOngletJeux_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnCreerJeuOngletJeu_Click(object sender, EventArgs e)
        {
            creerJeu FrmJeu = new creerJeu(this);
            FrmJeu.StartPosition = FormStartPosition.CenterScreen;
            FrmJeu.Show();
        }

        private void btnSupprimerJeuOngletJeu_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dgvListeJeux.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0)
            {
                int idJeu = Convert.ToInt32(dgvListeJeux.CurrentRow.Cells["dgvNumeroJeu"].Value);

                DialogResult dialogResult = MessageBox.Show("Voulez-vous supprimer ce jeu?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    controlleurJeu.supprimerJeu(idJeu);
                    MessageBox.Show(" Suppression éffectuée avec succès ");
                    afficheLesJeux();
                    
                }
            }
            else
            {
                MessageBox.Show(" Aucun jeu n'a été selectionnée!!! ");

            }

        }

        private void btnUpdateSE_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dgvSE1.Rows.GetRowCount(DataGridViewElementStates.Selected);

            int selectedCellCount = dgvSE1.GetCellCount(DataGridViewElementStates.Selected);

            if (selectedCellCount > 0 || selectedRowCount > 0)
            {

                int codeSE;

                if (selectedCellCount > 0)
                {
                    int indexClique = Convert.ToInt32(dgvSE1.SelectedCells[0].RowIndex);

                    codeSE = Convert.ToInt32(dgvSE1.Rows[indexClique].Cells["dgvNoSE"].Value);
                }
                else
                {
                    codeSE = Convert.ToInt32(dgvSE1.CurrentRow.Cells["dgvNoSE"].Value);
                }

                DialogResult dialogResult = MessageBox.Show("Voulez-vous modifier cet OS?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    /*if (controlleurOS.nombrePlateformeOS(codeSE) == 0)
                    {
                        controlleurOS.supprimerOS(codeSE);
                        MessageBox.Show(" Suppression éffectuée avec succès ");
                        afficheLesOS();
                    }
                    else
                    {
                        MessageBox.Show(" Impossible de modifier cet OS car il est lié à une ou plusieurs plateformes ");
                    }*/

                    frmModifierSE frmModifierSE = new frmModifierSE(this);
                    frmModifierSE.StartPosition = FormStartPosition.CenterScreen;
                    frmModifierSE.Tag = codeSE;
                    /*frmModifierSE.txtNomSE.Text = controlleurOS.infosSE(codeSE)[1];
                    frmModifierSE.txtEditionSE.Text = controlleurOS.infosSE(codeSE)[2];
                    frmModifierSE.txtVersionSE.Text = controlleurOS.infosSE(codeSE)[3];*/

                    frmModifierSE.Show();


                }

            }
            else
            {
                MessageBox.Show(" Aucune cellule ou ligne n'est selectionnée !!! ");
            }


        }

        private void btnUpdatePlateforme_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dgvPlateforme1.Rows.GetRowCount(DataGridViewElementStates.Selected);

            int selectedCellCount = dgvPlateforme1.GetCellCount(DataGridViewElementStates.Selected);

            if (selectedCellCount > 0 || selectedRowCount > 0)
            {

                int idPlateforme;

                if (selectedCellCount > 0)
                {
                    int indexClique = Convert.ToInt32(dgvPlateforme1.SelectedCells[0].RowIndex);

                    idPlateforme = Convert.ToInt32(dgvPlateforme1.Rows[indexClique].Cells["dgvNoPlateforme"].Value);
                }
                else
                {
                    idPlateforme = Convert.ToInt32(dgvPlateforme1.CurrentRow.Cells["dgvNoPlateforme"].Value);
                }

                DialogResult dialogResult = MessageBox.Show("Voulez-vous modifier cette plateforme?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    frmModifierPlateforme frmModifierPlateforme = new frmModifierPlateforme(this);
                    frmModifierPlateforme.StartPosition = FormStartPosition.CenterScreen;
                    frmModifierPlateforme.Tag = idPlateforme;
                    frmModifierPlateforme.Show();

                }

            }
            else
            {
                MessageBox.Show(" Aucune cellule ou ligne n'est selectionnée !!! ");
            }
        }

        private void btnSEModifier_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dgvSE2.Rows.GetRowCount(DataGridViewElementStates.Selected);

            int selectedCellCount = dgvSE2.GetCellCount(DataGridViewElementStates.Selected);

            if (selectedCellCount > 0 || selectedRowCount > 0)
            {

                int codeSE;

                if (selectedCellCount > 0)
                {
                    int indexClique = Convert.ToInt32(dgvSE2.SelectedCells[0].RowIndex);

                    codeSE = Convert.ToInt32(dgvSE2.Rows[indexClique].Cells["dgvCodeSE"].Value);
                }
                else
                {
                    codeSE = Convert.ToInt32(dgvSE2.CurrentRow.Cells["dgvCodeSE"].Value);
                }

                DialogResult dialogResult = MessageBox.Show("Voulez-vous modifier cet OS?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    /*if (controlleurOS.nombrePlateformeOS(codeSE) == 0)
                    {
                        controlleurOS.supprimerOS(codeSE);
                        MessageBox.Show(" Suppression éffectuée avec succès ");
                        afficheLesOS();
                    }
                    else
                    {
                        MessageBox.Show(" Impossible de modifier cet OS car il est lié à une ou plusieurs plateformes ");
                    }*/

                    frmModifierSE frmModifierSE = new frmModifierSE(this);
                    frmModifierSE.StartPosition = FormStartPosition.CenterScreen;
                    frmModifierSE.Tag = codeSE;
                    /*frmModifierSE.txtNomSE.Text = controlleurOS.infosSE(codeSE)[1];
                    frmModifierSE.txtEditionSE.Text = controlleurOS.infosSE(codeSE)[2];
                    frmModifierSE.txtVersionSE.Text = controlleurOS.infosSE(codeSE)[3];*/

                    frmModifierSE.Show();


                }

            }
            else
            {
                MessageBox.Show(" Aucune cellule ou ligne n'est selectionnée !!! ");
            }
        }

        private void btnModifierOngletPlateformes_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dgvPlateforme2.Rows.GetRowCount(DataGridViewElementStates.Selected);

            int selectedCellCount = dgvPlateforme2.GetCellCount(DataGridViewElementStates.Selected);

            if (selectedCellCount > 0 || selectedRowCount > 0)
            {

                int idPlateforme;

                if (selectedCellCount > 0)
                {
                    int indexClique = Convert.ToInt32(dgvPlateforme2.SelectedCells[0].RowIndex);

                    idPlateforme = Convert.ToInt32(dgvPlateforme2.Rows[indexClique].Cells["dgvIdPlateforme"].Value);
                }
                else
                {
                    idPlateforme = Convert.ToInt32(dgvPlateforme2.CurrentRow.Cells["dgvIdPlateforme"].Value);
                }

                DialogResult dialogResult = MessageBox.Show("Voulez-vous modifier cette plateforme?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    frmModifierPlateforme frmModifierPlateforme = new frmModifierPlateforme(this);
                    frmModifierPlateforme.StartPosition = FormStartPosition.CenterScreen;
                    frmModifierPlateforme.Tag = idPlateforme;
                    frmModifierPlateforme.Show();

                }

            }
            else
            {
                MessageBox.Show(" Aucune cellule ou ligne n'est selectionnée !!! ");
            }
        }
    }
}
