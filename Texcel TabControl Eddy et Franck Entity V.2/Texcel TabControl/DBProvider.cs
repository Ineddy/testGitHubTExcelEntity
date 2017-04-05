using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Texcel_TabControl
{
    class DBProvider
    {

        //Connexion au serveur du cegep
        SqlConnection ctn = new SqlConnection("Server = deptinfo420; Database = BdTexcel_Eddy_Franck; User Id = foned1530057;Password = 19810907;");


        //Config Eddy
        //SqlConnection ctn = new SqlConnection("Server=INFO-324-1A-122\\INSTANCE;Database=BdTexcel;Integrated Security=true");

        //Config Franck
        //SqlConnection ctn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=BdTexcel;Integrated Security=true");

        SqlCommand cmd;
        SqlDataReader lecteur;
        List<string[]> ligne = new List<string[]>();

        public DBProvider()
        {

        }


        public List<string[]> listeDesJeux()
        {
            string requeteListeDesJeux = "select * from tblJeu";

            List<string[]> listeJeux = new List<string[]>();

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteListeDesJeux;

            lecteur = cmd.ExecuteReader();

            while (lecteur.Read())
            {
                string[] jeu = new string[6];

                jeu[0] = lecteur["idJeu"].ToString();
                jeu[1] = lecteur["nomJeu"].ToString();
                jeu[2] = lecteur["devellopeurJeu"].ToString();
                jeu[3] = lecteur["descriptionJeu"].ToString();
                jeu[4] = lecteur["configurationMinimaleJeu"].ToString();
                jeu[5] = lecteur["idProjetTest"].ToString();

                listeJeux.Add(jeu);

                //listeOS.Add(lecteur["codeSE"] + " " + lecteur["nomSE"] + " " + lecteur["editionSE"] + " " + lecteur["versionSE"]);
            }

            lecteur.Close();

            ctn.Close();

            return listeJeux;

        }


        public List<string[]> listeDesOS()
        {
            string requetelisteDesOS = "select * from tblSE";

            List<string[]> listeOS = new List<string[]>();

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requetelisteDesOS;

            lecteur = cmd.ExecuteReader();

            while (lecteur.Read())
            {
                string[] OS = new string[4];

                OS[0] = lecteur["codeSE"].ToString();
                OS[1] = lecteur["nomSE"].ToString();
                OS[2] = lecteur["editionSE"].ToString();
                OS[3] = lecteur["versionSE"].ToString();

                listeOS.Add(OS);

                //listeOS.Add(lecteur["codeSE"] + " " + lecteur["nomSE"] + " " + lecteur["editionSE"] + " " + lecteur["versionSE"]);
            }

            lecteur.Close();

            ctn.Close();

            return listeOS;

        }

        public List<string[]> listeDesPlateformes()
        {
            string requeteListePlateformes = "select * from tblPlateforme";

            List<string[]> listePlateformes = new List<string[]>();

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteListePlateformes;

            lecteur = cmd.ExecuteReader();

            while (lecteur.Read())
            {
                string[] plateforme = new string[5];

                plateforme[0] = lecteur["idPlateforme"].ToString();
                plateforme[1] = lecteur["nomPlateforme"].ToString();
                plateforme[2] = lecteur["configurationPlateforme"].ToString();
                plateforme[3] = lecteur["idTypePlateforme"].ToString();
                plateforme[4] = lecteur["codeSE"].ToString();

                listePlateformes.Add(plateforme);
            }

            lecteur.Close();

            ctn.Close();

            return listePlateformes;
        }

        public List<string[]> listeDesEmployes()
        {
            //Requete de départ 
            //string requeteListeEmploye = "select * from tblEmploye";
            //Requete intermédiaire
            //select idEmploye, nomEmploye, prenomEmploye, dateDeNaissanceEmploye, adresseligne1Employe,codePostalEmploye,telephoneResidenceEmploye from tblEmploye 

            string requeteListeEmploye = "select E.idEmploye, nomEmploye, prenomEmploye, dateDeNaissanceEmploye, adresseligne1Employe,codePostalEmploye,telephoneResidenceEmploye, descriptionCategorieEmploi, nomVille from tblEmploye as E join tblCategorieEmploiEmploye CEE on E.idEmploye = CEE.idEmploye join tblCategorieEmploi as CE on CEE.idCategorieEmploi = CE.idCategorieEmploi join tblVille AS V on E.idVille = V.idVille";

            List<string[]> listeEmploye = new List<string[]>();

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteListeEmploye;

            lecteur = cmd.ExecuteReader();

            while (lecteur.Read())
            {
                string[] employe = new string[9];

                employe[0] = lecteur["idEmploye"].ToString();
                employe[1] = lecteur["nomEmploye"].ToString();
                employe[2] = lecteur["prenomEmploye"].ToString();
                employe[3] = lecteur["dateDeNaissanceEmploye"].ToString();
                employe[4] = lecteur["adresseligne1Employe"].ToString();
                employe[5] = lecteur["codePostalEmploye"].ToString();
                employe[6] = lecteur["telephoneResidenceEmploye"].ToString();
                employe[7] = lecteur["descriptionCategorieEmploi"].ToString();
                employe[8] = lecteur["nomVille"].ToString();

                listeEmploye.Add(employe);
            }

            lecteur.Close();

            ctn.Close();

            return listeEmploye;
        }

        public List<string[]> listeDesPlateformesAvecType()
        {

            string requeteListePlateformes = "SELECT * FROM tblPlateforme pla JOIN tblTypePlateforme tpla ON pla.idTypePlateforme = tpla.idTypePlateforme";

            List<string[]> listePlateformes = new List<string[]>();

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteListePlateformes;

            lecteur = cmd.ExecuteReader();

            while (lecteur.Read())
            {
                string[] plateforme = new string[7];

                plateforme[0] = lecteur["idPlateforme"].ToString();
                plateforme[1] = lecteur["nomPlateforme"].ToString();
                plateforme[2] = lecteur["configurationPlateforme"].ToString();
                plateforme[3] = lecteur["idTypePlateforme"].ToString();
                plateforme[4] = lecteur["codeSE"].ToString();
                plateforme[5] = lecteur["idTypePlateforme"].ToString();
                plateforme[6] = lecteur["nomTypePlateforme"].ToString();

                listePlateformes.Add(plateforme);
            }

            lecteur.Close();

            ctn.Close();

            return listePlateformes;
        }

        public List<string[]> listeDesTypePlateforme()
        {

            string requeteListeTypePlateformes = "SELECT * FROM tblTypePlateforme";

            List<string[]> listeTypePlateformes = new List<string[]>();

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteListeTypePlateformes;

            lecteur = cmd.ExecuteReader();

            while (lecteur.Read())
            {
                string[] typePlateforme = new string[2];

                typePlateforme[0] = lecteur["idTypePlateforme"].ToString();
                typePlateforme[1] = lecteur["nomTypePlateforme"].ToString();


                listeTypePlateformes.Add(typePlateforme);
            }

            lecteur.Close();

            ctn.Close();

            return listeTypePlateformes;

        }

        public void ajouterOS(string nomSE, string editionSE, string versionSE)
        {
            string requeteInsertOS = "insert into tblSE values(@nomSE,@editionSE,@versionSE,CONCAT(@nomSE ,' ',@editionSE ,' ',@versionSE))";

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteInsertOS;

            cmd.Parameters.AddWithValue("@nomSE", nomSE);
            cmd.Parameters.AddWithValue("@editionSE", editionSE);
            cmd.Parameters.AddWithValue("@versionSE", versionSE);

            cmd.ExecuteNonQuery();

            ctn.Close();

        }

        public void ajouterEquipe(string nomEquipe, int chefEquipe, int idDirecteur)
        {
            string requeteInsertEquipe = "insert into tblEquipe values(@nomEquipe,@idChefEquipe,@idDirecteur)";

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteInsertEquipe;

            cmd.Parameters.AddWithValue("@nomEquipe", nomEquipe);
            cmd.Parameters.AddWithValue("@idChefEquipe", chefEquipe);
            cmd.Parameters.AddWithValue("@idDirecteur", idDirecteur);

            cmd.ExecuteNonQuery();

            ctn.Close();

        }

        public void ajouterMembreEquipe(List<int> listeNoMembre, int noNewEquipe)
        {
            foreach(int noMembre in listeNoMembre)
            {
                string requeteInsertMembreEquipe = "insert into tblEquipeEmploye values(@idemploye,@idEquipe)";

                ctn.Open();

                cmd = ctn.CreateCommand();

                cmd.CommandText = requeteInsertMembreEquipe;

                cmd.Parameters.AddWithValue("@idemploye", noMembre);
                cmd.Parameters.AddWithValue("@idEquipe", noNewEquipe); //Ne fonctionnera plus quand on pourra supprimer des listes

                cmd.ExecuteNonQuery();

                ctn.Close();

            }

        }
        /*
        public int idMaxEquipe()
        {

            string idMaxEquipe = "SELECT MAX(idEquipe) AS max_id, idEquipe FROM tblEquipe";
            ctn.Open();
            int max = 0;

            cmd = ctn.CreateCommand();

            cmd.CommandText = idMaxEquipe;

            lecteur = cmd.ExecuteReader();

            while (lecteur.Read())
            {

                max = (Int16)lecteur["idEquipe"];

            }

            lecteur.Close();

            ctn.Close();

            return max;

        }
        */


        public List<string[]> listeDesGerant()
        {

            string requeteListeDesGerants = "SELECT * FROM tblGerant";

            List<string[]> listeGerants = new List<string[]>();

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteListeDesGerants;

            lecteur = cmd.ExecuteReader();

            while (lecteur.Read())
            {
                string[] gerant = new string[4];

                gerant[0] = lecteur["idGerant"].ToString();
                gerant[1] = lecteur["loginGerant"].ToString();
                gerant[2] = lecteur["motDePasseGerant"].ToString();
                gerant[3] = lecteur["roleGerant"].ToString();

                listeGerants.Add(gerant);

            }

            lecteur.Close();

            ctn.Close();

            return listeGerants;
        }

        public string roleGerant(string login, string motDePasse)
        {
            string roleGerant = "";

            string requeteRoleGerant = "select roleGerant from tblGerant where loginGerant = @loginGerant AND motDePasseGerant = @motDePasseGerant";

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteRoleGerant;

            cmd.Parameters.AddWithValue("@loginGerant", login);

            cmd.Parameters.AddWithValue("@motDePasseGerant", motDePasse);

            lecteur = cmd.ExecuteReader();

            while (lecteur.Read())
            {
                roleGerant = lecteur["roleGerant"].ToString();
            }

            lecteur.Close();

            ctn.Close();

            return roleGerant;
        }

        public List<string> listeClassificationJeu(int idJeu)
        {
            /* Requete utilisée
             select J.nomJeu, C.descriptionClassification
                from tblJeu as J
                    join tblClassificationJeu as CJ
                        on J.idJeu = CJ.idJeu
                    join tblClassification AS C
                        on CJ.idClassification = C.idClassification
                    Where J.idJeu = 11 
             */
            string requeteListeClassificationJeu = "select J.nomJeu, C.descriptionClassification from tblJeu as J join tblClassificationJeu as CJ on J.idJeu = CJ.idJeu join tblClassification AS C on CJ.idClassification = C.idClassification Where J.idJeu = " + idJeu;
            List<string> listeClassificationJeu = new List<string>();

            ctn.Open();
            cmd = ctn.CreateCommand();
            cmd.CommandText = requeteListeClassificationJeu;
            lecteur = cmd.ExecuteReader();
            while (lecteur.Read())
            {
                string classification;
                classification = lecteur["descriptionClassification"].ToString();
                listeClassificationJeu.Add(classification);

            }

            lecteur.Close();
            ctn.Close();
            return listeClassificationJeu;

        }

        public List<string> listeThemeJeu(int idJeu)
        {
            /* Requête utilisée
             select J.nomJeu, T.descriptionTheme 
                from tblJeu as J
                    join tblThemeJeu as TJ
                        on J.idJeu = TJ.idJeu
                    join tblTheme AS T
                        on TJ.idTheme = T.idTheme
                    Where J.idJeu = 11 
             */
            string requeteListeThemeJeu = "select J.nomJeu, T.descriptionTheme from tblJeu as J join tblThemeJeu as TJ on J.idJeu = TJ.idJeu join tblTheme AS T on TJ.idTheme = T.idTheme Where J.idJeu = " + idJeu;
            List<string> listeThemeJeu = new List<string>();

            ctn.Open();
            cmd = ctn.CreateCommand();
            cmd.CommandText = requeteListeThemeJeu;
            lecteur = cmd.ExecuteReader();
            while (lecteur.Read())
            {
                string theme;
                theme = lecteur["descriptionTheme"].ToString();
                listeThemeJeu.Add(theme);

            }

            lecteur.Close();
            ctn.Close();
            return listeThemeJeu;
        }

        public List<string> listeGenresJeu(int idJeu)
        {
            /* Requête utilisée
            select J.nomJeu, G.descriptionGenre 
                from tblJeu as J
                    join tblGenreJeu as GJ
                        on J.idJe
                        u = GJ.idJeu
                    join tblGenre AS G
                        on GJ.idGenre = G.idGenre
                    Where J.idJeu = 11 
            */
            string requeteListeGenresJeu = "select J.nomJeu, G.descriptionGenre from tblJeu as J join tblGenreJeu as GJ on J.idJeu = GJ.idJeu join tblGenre AS G on GJ.idGenre = G.idGenre Where J.idJeu = " + idJeu;
            List<string> listeGenresJeu = new List<string>();

            ctn.Open();
            cmd = ctn.CreateCommand();
            cmd.CommandText = requeteListeGenresJeu;
            lecteur = cmd.ExecuteReader();
            while (lecteur.Read())
            {
                string genre;
                genre = lecteur["descriptionGenre"].ToString();
                listeGenresJeu.Add(genre);

            }

            lecteur.Close();
            ctn.Close();
            return listeGenresJeu;
        }
        public List<string[]> listeRechercheSE(string motcle)
        {
            string requeteRecherche = "select * from tblSE where tagSE like '%" + motcle + "%'";
            List<string[]> listeResultatRecherche = new List<string[]>();

            ctn.Open();
            cmd = ctn.CreateCommand();
            cmd.CommandText = requeteRecherche;
            lecteur = cmd.ExecuteReader();
            while (lecteur.Read())
            {
                string codeSE;
                string nomSE;
                string editionSE;
                string versionSE;
                string tagSE;
                string[] infoSE = new string[5];
                //string nomClassification;
                codeSE = lecteur["codeSE"].ToString();
                nomSE = lecteur["nomSE"].ToString();
                editionSE = lecteur["editionSE"].ToString();
                versionSE = lecteur["versionSE"].ToString();
                tagSE = lecteur["tagSE"].ToString();
                //nomClassification = lecteur["descriptionClassification"].ToString();
                infoSE[0] = codeSE;
                infoSE[1] = nomSE;
                infoSE[2] = editionSE;
                infoSE[3] = versionSE;
                infoSE[4] = tagSE;

                listeResultatRecherche.Add(infoSE);

            }

            lecteur.Close();
            ctn.Close();
            return listeResultatRecherche;

        }


        public List<string[]> listeRecherchePlateforme(string motcle)
        {
            string requeteRecherche = "select * from tblPlateforme as P join tblTypePlateforme as TPF on P.idTypePlateforme = TPF.idTypePlateforme WHERE P.tagPlateforme like '%" + motcle + "%'";
            List<string[]> listeResultatRecherche = new List<string[]>();

            ctn.Open();
            cmd = ctn.CreateCommand();
            cmd.CommandText = requeteRecherche;
            lecteur = cmd.ExecuteReader();
            while (lecteur.Read())
            {
                string id;
                string nomPlateforme;
                string configurationPlateforme;
                string nomTypePlateforme;
                string tagPlateforme;
                string[] infoPlateforme = new string[5];
                //string nomClassification;
                id = lecteur["iDPlateforme"].ToString();
                nomPlateforme = lecteur["nomPlateforme"].ToString();
                configurationPlateforme = lecteur["configurationPlateforme"].ToString();
                nomTypePlateforme = lecteur["nomTypePlateforme"].ToString();
                tagPlateforme = lecteur["tagPlateforme"].ToString();
                //nomClassification = lecteur["descriptionClassification"].ToString();
                infoPlateforme[0] = id;
                infoPlateforme[1] = nomPlateforme;
                infoPlateforme[2] = configurationPlateforme;
                infoPlateforme[3] = nomTypePlateforme;
                infoPlateforme[4] = tagPlateforme;
                listeResultatRecherche.Add(infoPlateforme);

            }

            lecteur.Close();
            ctn.Close();
            return listeResultatRecherche;
        }

        public List<string> listeRecherche(string motcle)
        {
            /*
          select * 
              from tblJeu as J
              join tblPlateformeJeu as PJ
                  on J.idJeu = PJ.idJeu
              join tblPlateforme as P
                  on PJ.idPlateforme = P.idPlateforme
              join tblThemeJeu as TJ
                  on J.idJeu = TJ.idJeu
              join tblTheme as T
                  on TJ.idTheme = T.idTheme
              join tblClassificationJeu AS CJ
                  on J.idJeu = CJ.idJeu
              join tblClassification AS Cl
                  on CJ.idClassification = Cl.idClassification
              join tblGenreJeu as GJ
                  on J.idJeu = GJ.idJeu
              join tblGenre as Ge
                  on Ge.idGenre = GJ.idGenre 
                      WHERE P.nomPlateforme like '%Fifa%' OR tag like '%Fifa%'*/

            string requeteRecherche = "select * from tblJeu as J join tblPlateformeJeu as PJ on J.idJeu = PJ.idJeu join tblPlateforme as P on PJ.idPlateforme = P.idPlateforme join tblThemeJeu as TJ on J.idJeu = TJ.idJeu join tblTheme as T on TJ.idTheme = T.idTheme join tblClassificationJeu AS CJ on J.idJeu = CJ.idJeu join tblClassification AS Cl on CJ.idClassification = Cl.idClassification join tblGenreJeu as GJ on J.idJeu = GJ.idJeu join tblGenre as Ge on Ge.idGenre = GJ.idGenre WHERE P.nomPlateforme like '%" + motcle + "%' OR tag like '%" + motcle + "%' or Ge.descriptionGenre like '%" + motcle + "%' or T.descriptionTheme like '%" + motcle + "%' or Cl.descriptionClassification like '%" + motcle + "%'";
            List<string> listeResultatRecherche = new List<string>();

            ctn.Open();
            cmd = ctn.CreateCommand();
            cmd.CommandText = requeteRecherche;
            lecteur = cmd.ExecuteReader();
            while (lecteur.Read())
            {
                string tag;
                string nomPlateforme;
                string nomGenre;
                string nomTheme;
                string nomClassification;
                tag = lecteur["tag"].ToString();
                nomPlateforme = lecteur["nomPlateforme"].ToString();
                nomGenre = lecteur["descriptionGenre"].ToString();
                nomTheme = lecteur["descriptionTheme"].ToString();
                nomClassification = lecteur["descriptionClassification"].ToString();
                listeResultatRecherche.Add(tag + " " + nomPlateforme + " " + nomGenre + " " + nomTheme + " " + nomClassification);

            }

            lecteur.Close();
            ctn.Close();
            return listeResultatRecherche;
        }

        public int idMaxEquipe()
        {
            int max = 0;
            string idMaxEquipe = "SELECT MAX(idEquipe) AS maxId FROM tblEquipe";
            ctn.Open();
           

            cmd = ctn.CreateCommand();

            cmd.CommandText = idMaxEquipe;

            lecteur = cmd.ExecuteReader();

            while (lecteur.Read())
            {

                max = Convert.ToInt32(lecteur["maxId"]);

            }

            lecteur.Close();

            ctn.Close();

            return max;

        }

        public int idMaxJeu()
        {
            int max=0;

            string requeteIdMaxJeu = " select MAX(idJeu) AS 'idMaxJeu' FROM tblJeu ";

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteIdMaxJeu;

            lecteur = cmd.ExecuteReader();

            while (lecteur.Read())
            {
                max = Convert.ToInt32(lecteur["idMaxJeu"]);
            }

            lecteur.Close();

            ctn.Close();

            return max;

        }

        public List<string[]> listeEquipes()
        {
            string requeteListeEquipe = "SELECT * FROM tblEquipe";

            List<string[]> listeEquipe = new List<string[]>();

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteListeEquipe;

            lecteur = cmd.ExecuteReader();

            while (lecteur.Read())
            {
                string[] equipe = new string[4];

                equipe[0] = lecteur["idEquipe"].ToString();
                equipe[1] = lecteur["nomEquipe"].ToString();
                equipe[2] = lecteur["idChefEquipe"].ToString();
                equipe[3] = lecteur["idDirecteur"].ToString();

                listeEquipe.Add(equipe);

            }

            lecteur.Close();

            ctn.Close();

            return listeEquipe;
        }

        //Utilisé pour affiché la liste des employés
        public List<string[]> listeEmployeParEquipe(int idEquipe)
        {
            /* Requête utilisée
            select E.idEmploye, E.nomEmploye, E.prenomEmploye, EP.idEquipe 
                from tblEmploye as E
                    join tblEquipeEmploye as EP
                        on E.idEmploye = EP.idEmploye
                    Where EP.idEquipe = 1 
           */
            string requeteListeEmployeParEquipe = "select E.idEmploye, E.nomEmploye, E.prenomEmploye, EP.idEquipe from tblEmploye as E join tblEquipeEmploye as EP on E.idEmploye = EP.idEmploye Where EP.idEquipe =" + idEquipe;
            List<string[]> listeEmployeParEquipe = new List<string[]>();

            ctn.Open();
            cmd = ctn.CreateCommand();
            cmd.CommandText = requeteListeEmployeParEquipe;
            lecteur = cmd.ExecuteReader();
            while (lecteur.Read())
            {
                string[] employe = new string[3];
                employe[0] = lecteur["idEmploye"].ToString();
                employe[1] = lecteur["nomEmploye"].ToString();
                employe[2] = lecteur["prenomEmploye"].ToString();
                listeEmployeParEquipe.Add(employe);

            }

            lecteur.Close();
            ctn.Close();
            return listeEmployeParEquipe;
        }
        public List<string> listePlateformesJeu(int idJeu)
        {
            /* Requête utilisée
            select J.nomJeu, P.nomPlateforme 
                from tblJeu as J
                    join tblPlateformeJeu as PJ
                        on J.idJeu = PJ.idJeu
                    join tblPlateforme AS P
                        on PJ.idPlateforme = P.idPlateforme
                    Where J.idJeu = 12 
            */
            string requeteListePlateformesJeu = "select J.nomJeu, P.nomPlateforme from tblJeu as J join tblPlateformeJeu as PJ on J.idJeu = PJ.idJeu join tblPlateforme AS P on PJ.idPlateforme = P.idPlateforme Where J.idJeu =" + idJeu;
            List<string> listePlateformesJeu = new List<string>();

            ctn.Open();
            cmd = ctn.CreateCommand();
            cmd.CommandText = requeteListePlateformesJeu;
            lecteur = cmd.ExecuteReader();
            while (lecteur.Read())
            {
                string plateforme;
                plateforme = lecteur["nomPlateforme"].ToString();
                listePlateformesJeu.Add(plateforme);

            }

            lecteur.Close();
            ctn.Close();
            return listePlateformesJeu;
        }

        public void ajouterPlateforme(string nomPlateforme, string configurationPlateforme, int idTypePlateforme, int codeSE)
        {
            string requeteInsertPlateforme = "insert into tblPlateforme values(@nomPlateforme,@configurationPlateforme,@idTypePlateforme, @codeSE, CONCAT(@nomPlateforme,' ',@configurationPlateforme))";

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteInsertPlateforme;

            cmd.Parameters.AddWithValue("@nomPlateforme", nomPlateforme);
            cmd.Parameters.AddWithValue("@configurationPlateforme", configurationPlateforme);
            cmd.Parameters.AddWithValue("@idTypePlateforme", idTypePlateforme);
            cmd.Parameters.AddWithValue("@codeSE", codeSE);

            cmd.ExecuteNonQuery();

            ctn.Close();
        }

        public void ajouterJeu(string nomJeu, string devellopeurJeu, string descriptionJeu, string configurationJeu)
        {
            string requeteInsertJeu = " insert into tblJeu(nomJeu, devellopeurJeu, descriptionJeu, configurationMinimaleJeu,tag,idProjetTest) values(@nomJeu, @devellopeurJeu, @descriptionJeu, @configurationJeu, CONCAT(@nomJeu ,' ',@devellopeurJeu ,' ', @descriptionJeu,' ',@configurationJeu) ,null) ";


            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteInsertJeu;

            cmd.Parameters.AddWithValue("@nomJeu", nomJeu);
            cmd.Parameters.AddWithValue("@devellopeurJeu", devellopeurJeu);
            cmd.Parameters.AddWithValue("@descriptionJeu", descriptionJeu);
            cmd.Parameters.AddWithValue("@configurationJeu", configurationJeu);
           //cmd.Parameters.AddWithValue("@tag", );

            cmd.ExecuteNonQuery();

            ctn.Close();
        }

        public void ajouterPlateformeJeu(int idPlateforme, int idJeu)
        {
            string requeteInsertPlateformeJeu = " insert into tblPlateformeJeu values(@idPlateforme, @idJeu)";

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteInsertPlateformeJeu;

            cmd.Parameters.AddWithValue("@idPlateforme", idPlateforme);
            cmd.Parameters.AddWithValue("@idJeu", idJeu);
          

            cmd.ExecuteNonQuery();

            ctn.Close();
        }

        public void ajouterThemeJeu(int idTheme, int idJeu)
        {
            string requeteInsertThemeJeu = " insert into tblThemeJeu values(@idTheme, @idJeu)";

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteInsertThemeJeu;

            cmd.Parameters.AddWithValue("@idTheme", idTheme);
            cmd.Parameters.AddWithValue("@idJeu", idJeu);


            cmd.ExecuteNonQuery();

            ctn.Close();
        }

        public void ajouterGenreJeu(int idGenre, int idJeu)
        {
            string requeteInsertGenreJeu = " insert into tblGenreJeu values(@idGenre, @idJeu)";

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteInsertGenreJeu;

            cmd.Parameters.AddWithValue("@idGenre", idGenre);
            cmd.Parameters.AddWithValue("@idJeu", idJeu);


            cmd.ExecuteNonQuery();

            ctn.Close();
        }

        public void ajouterClassificationJeu(int idClassification, int idJeu)
        {
            string requeteInsertClassificationJeu = " insert into tblClassificationJeu values(@idClassification, @idJeu)";

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteInsertClassificationJeu;

            cmd.Parameters.AddWithValue("@idClassification", idClassification);
            cmd.Parameters.AddWithValue("@idJeu", idJeu);


            cmd.ExecuteNonQuery();

            ctn.Close();
        }



        public int nombrePlateformeOS(int codeSE)
        {
            int nbrePlateformeOS = 0;

            string requeteNombrePlateformeOS = "SELECT COUNT(*) AS 'nombrePlateforme' from tblPlateforme WHERE codeSE = @codeSE";

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteNombrePlateformeOS;

            cmd.Parameters.AddWithValue("@codeSE", codeSE);

            lecteur = cmd.ExecuteReader();

            while (lecteur.Read())
            {
                nbrePlateformeOS = Convert.ToInt32(lecteur["nombrePlateforme"]);
            }

            lecteur.Close();

            ctn.Close();

            return nbrePlateformeOS;

        }

        public int nombreJeuPlateforme(int idPlateforme)
        {
            int nbreJeuPlateforme = 0;

            string requeteNombreJeuPlateforme = "SELECT COUNT(*) AS 'nombreJeu' from tblPlateformeJeu WHERE idPlateforme = @idPlateforme";

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteNombreJeuPlateforme;

            cmd.Parameters.AddWithValue("@idPlateforme", idPlateforme);

            lecteur = cmd.ExecuteReader();

            while (lecteur.Read())
            {
                nbreJeuPlateforme = Convert.ToInt32(lecteur["nombreJeu"]);
            }

            lecteur.Close();

            ctn.Close();

            return nbreJeuPlateforme;
        }

        public void supprimerPlateforme(int idPlateforme)
        {
            string requeteDeletePlateforme = "delete from tblPlateforme where idPlateforme = @idPlateforme";

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteDeletePlateforme;

            cmd.Parameters.AddWithValue("@idPlateforme", idPlateforme);

            cmd.ExecuteNonQuery();

            ctn.Close();
        }

       

        public int trouveCodeSE(string nomSE, string editionSE, string versionSE)
        {
            int codeSE = 0;

            string requeteCodeSE = "SELECT codeSE from tblSE where nomSE = @nomSE AND editionSE = @editionSE AND versionSE = @versionSE";

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteCodeSE;

            cmd.Parameters.AddWithValue("@nomSE", nomSE);

            cmd.Parameters.AddWithValue("@editionSE", editionSE);

            cmd.Parameters.AddWithValue("@versionSE", versionSE);

            lecteur = cmd.ExecuteReader();

            while (lecteur.Read())
            {
                codeSE = Convert.ToInt32(lecteur["codeSE"]);
            }

            lecteur.Close();

            ctn.Close();

            return codeSE;
        }

        public int trouveIdTypePlateforme(string nomTypePlateforme)
        {

            int idTypePlateforme = 0;

            string requeteIdTypePlateforme = "SELECT idTypePlateforme from tblTypePlateforme where nomTypePlateforme = @nomTypePlateforme ";

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteIdTypePlateforme;

            cmd.Parameters.AddWithValue("@nomTypePlateforme", nomTypePlateforme);

            lecteur = cmd.ExecuteReader();

            while (lecteur.Read())
            {
                idTypePlateforme = Convert.ToInt32(lecteur["idTypePlateforme"]);
            }

            lecteur.Close();

            ctn.Close();

            return idTypePlateforme;

        }

        public string trouveNomTypePlateforme(int idTypePlateforme)
        {
            string nomTypePlateforme = "";

            string requeteNomTypePlateforme = "SELECT nomTypePlateforme from tblTypePlateforme where idTypePlateforme = @idTypePlateforme ";

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteNomTypePlateforme;

            cmd.Parameters.AddWithValue("@idTypePlateforme", idTypePlateforme);

            lecteur = cmd.ExecuteReader();

            while (lecteur.Read())
            {
                nomTypePlateforme = lecteur["nomTypePlateforme"].ToString();
            }

            lecteur.Close();

            ctn.Close();

            return nomTypePlateforme;
        }

        public List<string[]> listeGenre()
        {

            string requeteDesGenres = "SELECT * FROM tblGenre";

            List<string[]> listeGenres = new List<string[]>();

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteDesGenres;

            lecteur = cmd.ExecuteReader();

            while (lecteur.Read())
            {
                string[] genre = new string[2];

                genre[0] = lecteur["idGenre"].ToString();
                genre[1] = lecteur["descriptionGenre"].ToString();

                listeGenres.Add(genre);

            }

            lecteur.Close();

            ctn.Close();

            return listeGenres;

        }

        public List<string[]> listeTheme()
        {
            string requeteDesTheme = "SELECT * FROM tblTheme";

            List<string[]> listeTheme = new List<string[]>();

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteDesTheme;

            lecteur = cmd.ExecuteReader();

            while (lecteur.Read())
            {
                string[] theme = new string[2];

                theme[0] = lecteur["idTheme"].ToString();
                theme[1] = lecteur["descriptionTheme"].ToString();

                listeTheme.Add(theme);

            }

            lecteur.Close();

            ctn.Close();

            return listeTheme;

        }

        public List<string[]> listeClassification()
        {

            string requeteDesClassification = "SELECT * FROM tblClassification";

            List<string[]> listeClassification = new List<string[]>();

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteDesClassification;

            lecteur = cmd.ExecuteReader();

            while (lecteur.Read())
            {
                string[] classification = new string[2];

                classification[0] = lecteur["idClassification"].ToString();
                classification[1] = lecteur["descriptionClassification"].ToString();

                listeClassification.Add(classification);

            }

            lecteur.Close();

            ctn.Close();

            return listeClassification;

        }

        public void supprimerOS(int codeSE)
        {

            string requeteDeleteOS = "delete from tblSE where codeSE = @codeSE";

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteDeleteOS;

            cmd.Parameters.AddWithValue("@codeSE", codeSE);

            cmd.ExecuteNonQuery();

            ctn.Close();
        }

        public void supprimerJeu(int idJeu)
        {
            string requeteDeleteJeu = "delete from tblJeu where idJeu=@idJeu";

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteDeleteJeu;

            cmd.Parameters.AddWithValue("@idJeu", idJeu);

            cmd.ExecuteNonQuery();

            ctn.Close();

        }

        public void supprimerPlateformeJeu(int idJeu)
        {
            string requeteDeletePlateformeJeu = "delete from tblPlateformeJeu where idJeu=@idJeu";

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteDeletePlateformeJeu;

            cmd.Parameters.AddWithValue("@idJeu", idJeu);

            cmd.ExecuteNonQuery();

            ctn.Close();
        }

        public void supprimerGenreJeu(int idJeu)
        {
            string requeteDeletGenreJeu = "delete from tblGenreJeu where idJeu=@idJeu";

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteDeletGenreJeu;

            cmd.Parameters.AddWithValue("@idJeu", idJeu);

            cmd.ExecuteNonQuery();

            ctn.Close();
        }

        public void supprimerThemeJeu(int idJeu)
        {
            string requeteDeleteThemeJeu = "delete from tblThemeJeu where idJeu=@idJeu";

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteDeleteThemeJeu;

            cmd.Parameters.AddWithValue("@idJeu", idJeu);

            cmd.ExecuteNonQuery();

            ctn.Close();
        }

        public void supprimerClassificationJeu(int idJeu)
        {
            string requeteDeleteClassificationJeu = "delete from tblClassificationJeu where idJeu=@idJeu";

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteDeleteClassificationJeu;

            cmd.Parameters.AddWithValue("@idJeu", idJeu);

            cmd.ExecuteNonQuery();

            ctn.Close();
        }

        public void updateSE(int codeSE, string nomSE, string editionSE, string versionSE)
        {
            string requeteUpdateSE = "update tblSE set nomSE = @nomSE, editionSE = @editionSE, versionSE = @versionSE where codeSE = @codeSE";

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteUpdateSE;

            cmd.Parameters.AddWithValue("@codeSE", codeSE);

            cmd.Parameters.AddWithValue("@nomSE", nomSE);

            cmd.Parameters.AddWithValue("@editionSE", editionSE);

            cmd.Parameters.AddWithValue("@versionSE", versionSE);

            cmd.ExecuteNonQuery();

            ctn.Close();

        }

        public void updatePlateforme(int idPlateforme, string nomPlateforme, string configurationPlateforme, int idTypePlateforme, int codeSE)
        {
            string requeteUpdatePlateforme = "update tblPlateforme set nomPlateforme = @nomPlateforme, configurationPlateforme = @configurationPlateforme, idTypePlateforme = @idTypePlateforme, codeSE = @codeSE where idPlateforme = @idPlateforme";

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteUpdatePlateforme;

            cmd.Parameters.AddWithValue("@idPlateforme", idPlateforme);

            cmd.Parameters.AddWithValue("@nomPlateforme", nomPlateforme);

            cmd.Parameters.AddWithValue("@configurationPlateforme", configurationPlateforme);

            cmd.Parameters.AddWithValue("@idTypePlateforme", idTypePlateforme);

            cmd.Parameters.AddWithValue("@codeSE", codeSE);

            cmd.ExecuteNonQuery();

            ctn.Close();

        }

        public string[] infosTypePlateforme(int idTypePlateforme)
        {
            string requeteInfosTypePlateforme = "SELECT * FROM tblTypePlateforme where idTypePlateforme = @idTypePlateforme";

            string[] infosTypePlateforme = new string[2];

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteInfosTypePlateforme;

            cmd.Parameters.AddWithValue("@idTypePlateforme", idTypePlateforme);

            lecteur = cmd.ExecuteReader();

            while (lecteur.Read())
            {
                infosTypePlateforme[0] = lecteur["idTypePLateforme"].ToString();
                infosTypePlateforme[1] = lecteur["nomTypePlateforme"].ToString();
            }

            lecteur.Close();

            ctn.Close();

            return infosTypePlateforme;

        }

        public string[] infosPlateforme(int idPlateforme)
        {
            string requeteInfosPlateforme = "SELECT * FROM tblPlateforme where idPlateforme = @idPlateforme";

            string[] infosPlateforme = new string[5];

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteInfosPlateforme;

            cmd.Parameters.AddWithValue("@idPlateforme", idPlateforme);

            lecteur = cmd.ExecuteReader();

            while (lecteur.Read())
            {
                infosPlateforme[0] = lecteur["idPLateforme"].ToString();
                infosPlateforme[1] = lecteur["nomPlateforme"].ToString();
                infosPlateforme[2] = lecteur["configurationPlateforme"].ToString();
                infosPlateforme[3] = lecteur["idTypePlateforme"].ToString();
                infosPlateforme[4] = lecteur["codeSE"].ToString();
            }

            lecteur.Close();

            ctn.Close();

            return infosPlateforme;

        }



        public string[] infosSE(int codeSE)
        {

            string requeteInfosSE = "SELECT * FROM tblSE where codeSE = @codeSE";

            string[] infosSE = new string[4];

            ctn.Open();

            cmd = ctn.CreateCommand();

            cmd.CommandText = requeteInfosSE;

            cmd.Parameters.AddWithValue("@codeSE", codeSE);

            lecteur = cmd.ExecuteReader();

            while (lecteur.Read())
            {
                infosSE[0] = lecteur["codeSE"].ToString();
                infosSE[1] = lecteur["nomSE"].ToString();
                infosSE[2] = lecteur["editionSE"].ToString();
                infosSE[3] = lecteur["versionSE"].ToString();
            }

            lecteur.Close();

            ctn.Close();

            return infosSE;

        }

    }
}
