
/* 

Script des conraintes
le 27 fevrier 2017

*/

USE BdTexcel_Eddy_Franck;

/*Ajout des foreign key dans la table Jeu*/

ALTER TABLE tblJeu ADD CONSTRAINT fk_JeuProjetTest FOREIGN KEY(idProjetTest) REFERENCES tblProjetTest(idProjetTest);

/*Ajout des foreign key dans la table classificationJeu*/

ALTER TABLE tblClassificationJeu ADD CONSTRAINT fk_Classification FOREIGN KEY(idClassification) REFERENCES tblClassification(idClassification);

ALTER TABLE tblClassificationJeu ADD CONSTRAINT fk_JeuClassification FOREIGN KEY(idJeu) REFERENCES tblJeu(idJeu);

/*Ajout des foreign key dans la table GenreJeu*/

ALTER TABLE tblGenreJeu ADD CONSTRAINT fk_JeuGenre FOREIGN KEY(idJeu) REFERENCES tblJeu(idJeu);

ALTER TABLE tblGenreJeu ADD CONSTRAINT fk_GenreJeu FOREIGN KEY(idGenre) REFERENCES tblGenre(idGenre);

/*Ajout des foreign key dans la table plateforme*/

ALTER TABLE tblPlateforme ADD CONSTRAINT fk_CodeSE FOREIGN KEY(codeSE) REFERENCES tblSE(codeSE);

ALTER TABLE tblPlateforme ADD CONSTRAINT fk_TypePlateforme FOREIGN KEY(idTypePlateforme) REFERENCES tblTypePlateforme(idTypePlateforme);

/*Ajout des foreign key dans la table plateformeJeu*/

ALTER TABLE tblPlateformeJeu ADD CONSTRAINT fk_Plateforme FOREIGN KEY(idPlateforme) REFERENCES tblPlateforme(idPlateforme);

ALTER TABLE tblPlateformeJeu ADD CONSTRAINT fk_JeuPlateforme FOREIGN KEY(idJeu) REFERENCES tblJeu(idJeu);

/*Ajout des foreign key dans la table themeJeu*/


ALTER TABLE tblThemeJeu ADD CONSTRAINT fk_Theme FOREIGN KEY(idTheme) REFERENCES tblTheme(idTheme);

ALTER TABLE tblThemeJeu ADD CONSTRAINT fk_JeuTheme FOREIGN KEY(idJeu) REFERENCES tblJeu(idJeu);

/*Ajout des foreign key dans la table Test*/

ALTER TABLE tblTest ADD CONSTRAINT fk_CategorieTest FOREIGN KEY(idCategorie) REFERENCES tblCategorie(idCategorie);

ALTER TABLE tblTest ADD CONSTRAINT fk_Equipe FOREIGN KEY(idEquipe) REFERENCES tblEquipe(idEquipe);

ALTER TABLE tblTest ADD CONSTRAINT fk_TestProjetTest FOREIGN KEY(idProjetTest) REFERENCES tblProjetTest(idProjetTest);

/*Ajout des foreign key dans la table Equipe*/

ALTER TABLE tblEquipe ADD CONSTRAINT fk_Directeur FOREIGN KEY(idDirecteur) REFERENCES tblDirecteur(idDirecteur);

/*Ajout des foreign key dans la table EquipeEmploye*/

ALTER TABLE tblEquipeEmploye ADD CONSTRAINT fk_EmployeEquipe FOREIGN KEY(idEmploye) REFERENCES tblEmploye(idEmploye);

ALTER TABLE tblEquipeEmploye ADD CONSTRAINT fk_EquipeEmploye FOREIGN KEY(idEquipe) REFERENCES tblEquipe(idEquipe);

/*Ajout des foreign key dans la table Employe*/

ALTER TABLE tblEmploye ADD CONSTRAINT fk_Ville FOREIGN KEY(idVille) REFERENCES tblVille(idVille);

/*Ajout des foreign key dans la table CategorieEmploiEmploye*/

ALTER TABLE tblCategorieEmploiEmploye ADD CONSTRAINT fk_EmployeCategorieEmploi FOREIGN KEY(idEmploye) REFERENCES tblEmploye(idEmploye);

ALTER TABLE tblCategorieEmploiEmploye ADD CONSTRAINT fk_CategorieEmploiEmploye FOREIGN KEY(idCategorieEmploi) REFERENCES tblCategorieEmploi(idCategorieEmploi);

/*Ajout des foreign key dans la table Gerant*/

ALTER TABLE tblGerant ADD CONSTRAINT fk_GerantEmploye FOREIGN KEY(idGerant) REFERENCES tblEmploye(idEmploye);

/*Ajout des foreign key dans la table Administrateur*/

ALTER TABLE tblAdministrateur ADD CONSTRAINT fk_AdministrateurGerant FOREIGN KEY(idAdministrateur) REFERENCES tblGerant(idGerant);

/*Ajout des foreign key dans la table Directeur*/

ALTER TABLE tblDirecteur ADD CONSTRAINT fk_DirecteurGerant FOREIGN KEY(idDirecteur) REFERENCES tblGerant(idGerant);









