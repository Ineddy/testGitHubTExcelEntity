/*ProjetTexcel - Script de création*/



PRINT('Debut du script de création de la bd')
-- -------------------------------------------------------
GO
SET nocount    ON;
SET DATEFORMAT ymd;
USE master
GO

PRINT('Création et sélection de la base de données')
-- -------------------------------------------------------
GO

IF EXISTS (SELECT * FROM sysdatabases WHERE name = 'BdTexcel')
DROP DATABASE BdTexcel

GO

CREATE DATABASE BdTexcel ON PRIMARY
( 
	 NAME='BdTexcel.DATA',
	 FILENAME='C:\BD\BdTexcel.DATA.mdf',
	 SIZE= 20MB,
	 MAXSIZE = 50MB,
	 FILEGROWTH=5MB
 )
 LOG ON
( 
NAME ='BDGestSalles_Log',
FILENAME='C:\BD\BdTexcel_Log.ldf',
SIZE = 5MB ,
MAXSIZE =20MB ,
FILEGROWTH = 2MB

 )

GO

USE BdTexcel

GO

PRINT('Création de la table tblJeu')
-- -------------------------------------------------------
GO

IF OBJECT_ID('BDGestSalles.DBO.tblJeu') IS NOT NULL
DROP TABLE BDGestSalles.DBO.tblJeu;

GO
CREATE TABLE BdTexcel.DBO.tblJeu
(

		idJeu int IDENTITY(1,1) NOT NULL CONSTRAINT PK_Jeu_Id PRIMARY KEY,
		nomJeu varchar(50) NOT NULL,
		devellopeurJeu varchar(50) NOT NULL,
		descriptionJeu varchar(100) NOT NULL,
		configurationMinimaleJeu varchar(50) NOT NULL,
		idProjetTest int NULL,
		tag varchar(400) NULL,
)

GO

PRINT('Création de la table tblClassification')
-- -------------------------------------------------------
GO

IF OBJECT_ID('BDGestSalles.DBO.tblClassification') IS NOT NULL
DROP TABLE BDGestSalles.DBO.tblClassification;

GO
CREATE TABLE BdTexcel.DBO.tblClassification
(

		idClassification int IDENTITY(1,1) NOT NULL CONSTRAINT PK_Classification_Id PRIMARY KEY,
		descriptionClassification varchar(50) NOT NULL,
		
)

GO


PRINT('Création de la table tblClassificationJeu')
-- -------------------------------------------------------
GO

IF OBJECT_ID('BDGestSalles.DBO.tblClassificationJeu') IS NOT NULL
DROP TABLE BDGestSalles.DBO.tblClassificationJeu;

GO
CREATE TABLE BdTexcel.DBO.tblClassificationJeu
(

		idClassification int NOT NULL,
		idJeu int NOT NULL,
		PRIMARY KEY(idClassification,idJeu)

)

GO

PRINT('Création de la table tblGenre')
-- -------------------------------------------------------
GO

IF OBJECT_ID('BDGestSalles.DBO.tblGenre') IS NOT NULL
DROP TABLE BDGestSalles.DBO.tblGenre;

GO
CREATE TABLE BdTexcel.DBO.tblGenre
(

		idGenre int IDENTITY(1,1) NOT NULL CONSTRAINT PK_Genre_Id PRIMARY KEY,         
		descriptionGenre varchar(50) NOT NULL,
)

GO

PRINT('Création de la table tblGenreJeu')
-- -------------------------------------------------------
GO

IF OBJECT_ID('BDGestSalles.DBO.tblGenreJeu') IS NOT NULL
DROP TABLE BDGestSalles.DBO.tblGenreJeu;

GO
CREATE TABLE BdTexcel.DBO.tblGenreJeu
(

		idGenre int NOT NULL,
		idJeu int NOT NULL, 
		PRIMARY KEY(idGenre,idJeu)            
		
)

GO

PRINT('Création de la table tblTheme')
-- -------------------------------------------------------
GO

IF OBJECT_ID('BDGestSalles.DBO.tblTheme') IS NOT NULL
DROP TABLE BDGestSalles.DBO.tblTheme;

GO
CREATE TABLE BdTexcel.DBO.tblTheme
(

		idTheme int IDENTITY(1,1) NOT NULL CONSTRAINT PK_Theme_Id PRIMARY KEY,
		descriptionTheme varchar(50) NOT NULL,             
		
)

GO

PRINT('Création de la table tblThemeJeu')
-- -------------------------------------------------------
GO

IF OBJECT_ID('BDGestSalles.DBO.tblThemeJeu') IS NOT NULL
DROP TABLE BDGestSalles.DBO.tblThemeJeu;

GO
CREATE TABLE BdTexcel.DBO.tblThemeJeu
(

		idTheme int NOT NULL,
		idJeu int NOT NULL,             
		PRIMARY KEY(idTheme,idJeu)
)

GO

PRINT('Création de la table tblPlateforme')
-- -------------------------------------------------------
GO

IF OBJECT_ID('BDGestSalles.DBO.tblPlateforme') IS NOT NULL
DROP TABLE BDGestSalles.DBO.tblPlateforme;

GO
CREATE TABLE BdTexcel.DBO.tblPlateforme
(

		idPlateforme int IDENTITY(1,1) NOT NULL CONSTRAINT PK_Plateforme_Id PRIMARY KEY,
		nomPlateforme varchar(20) NOT NULL,
		configurationPlateforme varchar(50) NOT NULL,
		idTypePlateforme int NOT NULL, --type est un mot reservé
		codeSE int NOT NULL,
		
)

PRINT('Création de la table tblTypePlateforme')
-- -------------------------------------------------------
GO

IF OBJECT_ID('BDGestSalles.DBO.tblTypePlateforme') IS NOT NULL
DROP TABLE BDGestSalles.DBO.tblTypePlateforme;

GO
CREATE TABLE BdTexcel.DBO.tblTypePlateforme
(

		idTypePlateforme int IDENTITY(1,1) NOT NULL CONSTRAINT PK_TypePlateforme_Id PRIMARY KEY,
		nomTypePlateforme varchar(100) NOT NULL, 
		          
		
)

GO

GO

PRINT('Création de la table tblPlateformeJeu')
-- -------------------------------------------------------
GO

IF OBJECT_ID('BDGestSalles.DBO.tblPlateformeJeu') IS NOT NULL
DROP TABLE BDGestSalles.DBO.tblPlateformeJeu;

GO
CREATE TABLE BdTexcel.DBO.tblPlateformeJeu
(

		idPlateforme int NOT NULL,
		idJeu int NOT NULL,
		PRIMARY KEY(idPlateforme, idJeu)
		
)

GO

PRINT('Création de la table tblSE')
-- -------------------------------------------------------
GO

IF OBJECT_ID('BDGestSalles.DBO.tblSE') IS NOT NULL
DROP TABLE BDGestSalles.DBO.tblSE;

GO
CREATE TABLE BdTexcel.DBO.tblSE
(

		codeSE int IDENTITY(1,1) NOT NULL CONSTRAINT PK_SE_Id PRIMARY KEY,
		nomSE varchar(20) NOT NULL,
		editionSE varchar(20) DEFAULT 'standard' NOT NULL,
		versionSE varchar(20) NOT NULL,
		
)

GO



PRINT('Création de la table tblProjetTest')
-- -------------------------------------------------------
GO

IF OBJECT_ID('BDGestSalles.DBO.tblProjetTest') IS NOT NULL
DROP TABLE BDGestSalles.DBO.tblProjetTest;

GO
CREATE TABLE BdTexcel.DBO.tblProjetTest
(

	idProjetTest int IDENTITY(1,1) NOT NULL CONSTRAINT PK_ProjetTest_Id PRIMARY KEY,
	nomProjetTest varchar(50) NOT NULL,
	dateCreationProjetTest date,

	UNIQUE(nomProjetTest)
)

GO

PRINT('Création de la table tblTest')
-- -------------------------------------------------------
GO

IF OBJECT_ID('BDGestSalles.DBO.tblTest') IS NOT NULL
DROP TABLE BDGestSalles.DBO.tblTest;

GO
CREATE TABLE BdTexcel.DBO.tblTest
(

	idTest int IDENTITY(1,1) NOT NULL CONSTRAINT PK_Test_Id PRIMARY KEY,
	descriptionTest varchar(50) NOT NULL,
	idCategorie int NOT NULL,
	idEquipe int NOT NULL,
	idProjetTest int NOT NULL,
		
)

GO

PRINT('Création de la table tblCategorie')
-- -------------------------------------------------------
GO

IF OBJECT_ID('BDGestSalles.DBO.tblCategorie') IS NOT NULL
DROP TABLE BDGestSalles.DBO.tblCategorie;

GO
CREATE TABLE BdTexcel.DBO.tblCategorie
(

		idCategorie int IDENTITY(1,1) NOT NULL CONSTRAINT PK_CategorieTest_Id PRIMARY KEY,
		descriptionCategorie varchar(100) NOT NULL,             
		
)

GO


PRINT('Création de la table tblEquipe')
-- -------------------------------------------------------
GO

IF OBJECT_ID('BDGestSalles.DBO.tblEquipe') IS NOT NULL
DROP TABLE BDGestSalles.DBO.tblEquipe;

GO
CREATE TABLE BdTexcel.DBO.tblEquipe
(

	idEquipe int IDENTITY(1,1) NOT NULL CONSTRAINT PK_Equipe_Id PRIMARY KEY,
	nomEquipe varchar(50) NOT NULL,
	idChefEquipe int NOT NULL,
	idDirecteur int NOT NULL,

	UNIQUE(nomEquipe),
		
)

GO


PRINT('Création de la table tblEquipeEmploye')
-- -------------------------------------------------------
GO

IF OBJECT_ID('BDGestSalles.DBO.tblEquipeEmploye') IS NOT NULL
DROP TABLE BDGestSalles.DBO.tblEquipeEmploye;

GO
CREATE TABLE BdTexcel.DBO.tblEquipeEmploye
(

		idEmploye int NOT NULL,
		idEquipe int NOT NULL,   
		PRIMARY KEY(idEmploye,idEquipe)         
		
)

GO

PRINT('Création de la table tblEmploye')
-- -------------------------------------------------------
GO

IF OBJECT_ID('BDGestSalles.DBO.tblEmploye') IS NOT NULL
DROP TABLE BDGestSalles.DBO.tblEmploye;

GO
CREATE TABLE BdTexcel.DBO.tblEmploye
(

		idEmploye int IDENTITY(1,1) NOT NULL CONSTRAINT PK_Employe_Id PRIMARY KEY,
		nomEmploye varchar(50) NOT NULL,
		prenomEmploye varchar(50) NOT NULL,
		dateDeNaissanceEmploye date NOT NULL,	
		adresseligne1Employe varchar(50) NOT NULL,
		adresseligne2Employe varchar(50) NULL,
		codePostalEmploye char(6) NOT NULL, --Vu avec Aymen, on s'arrete à la zone géographgique du Québec
		telephoneResidenceEmploye varchar(20) NOT NULL,
		posteTelephoniqueEmploye varchar(5) NOT NULL, --Estimation large
		matriculeEmploye varchar(6) NOT NULL, --Aurait pu être l'identifiant mais laissé ainsi pour simplifier le développement du programme, les tests, etc.
		idVille int NOT NULL,

		UNIQUE(telephoneResidenceEmploye),
		UNIQUE(matriculeEmploye),
			
)

GO


PRINT('Création de la table tblGerant')
-- -------------------------------------------------------
GO

IF OBJECT_ID('BDGestSalles.DBO.tblGerant') IS NOT NULL
DROP TABLE BDGestSalles.DBO.tblGerant;

GO
CREATE TABLE BdTexcel.DBO.tblGerant
(

		idGerant int NOT NULL CONSTRAINT PK_Gerant_Id PRIMARY KEY,
		loginGerant varchar(50) NOT NULL,
		motDePasseGerant varchar(50) NOT NULL,
		roleGerant varchar(50) NOT NULL,

		UNIQUE(loginGerant),
		
)

GO


PRINT('Création de la table tblAdministrateur')
-- -------------------------------------------------------
GO

IF OBJECT_ID('BDGestSalles.DBO.tblAdministrateur') IS NOT NULL
DROP TABLE BDGestSalles.DBO.tblAdministrateur;

GO
CREATE TABLE BdTexcel.DBO.tblAdministrateur
(

		idAdministrateur int NOT NULL CONSTRAINT PK_Admistrateur_Id PRIMARY KEY,
		
)

GO

PRINT('Création de la table tblDirecteur')
-- -------------------------------------------------------
GO

IF OBJECT_ID('BDGestSalles.DBO.tblDirecteur') IS NOT NULL
DROP TABLE BDGestSalles.DBO.tblDirecteur;

GO
CREATE TABLE BdTexcel.DBO.tblDirecteur
(

		idDirecteur int NOT NULL CONSTRAINT PK_Directeur_Id PRIMARY KEY,
		
)

GO





PRINT('Création de la table tblVille')
-- -------------------------------------------------------
GO

IF OBJECT_ID('BDGestSalles.DBO.tblVille') IS NOT NULL
DROP TABLE BDGestSalles.DBO.tblVille;

GO
CREATE TABLE BdTexcel.DBO.tblVille
(
		idVille int IDENTITY(1,1) NOT NULL CONSTRAINT PK_Ville_Id PRIMARY KEY,
		nomVille varchar(50) NOT NULL,
)

GO

PRINT('Création de la table tblCategorieEmploi')
-- -------------------------------------------------------
GO

IF OBJECT_ID('BDGestSalles.DBO.tblCategorieEmploi') IS NOT NULL
DROP TABLE BDGestSalles.DBO.tblCategorieEmploi;

GO
CREATE TABLE BdTexcel.DBO.tblCategorieEmploi
(

		idCategorieEmploi int IDENTITY(1,1) NOT NULL CONSTRAINT PK_CategorieEmploi_Id PRIMARY KEY,
		descriptionCategorieEmploi varchar(50) NOT NULL,
		
)

GO

PRINT('Création de la table tblCategorieEmploiEmploye')
-- -------------------------------------------------------
GO

IF OBJECT_ID('BDGestSalles.DBO.tblCategorieEmploiEmploye') IS NOT NULL
DROP TABLE BDGestSalles.DBO.tblCategorieEmploiEmploye;

GO
CREATE TABLE BdTexcel.DBO.tblCategorieEmploiEmploye
(
		idEmploye int NOT NULL,
		idCategorieEmploi int NOT NULL,
		PRIMARY KEY(idEmploye,idCategorieEmploi)
		
)

GO














