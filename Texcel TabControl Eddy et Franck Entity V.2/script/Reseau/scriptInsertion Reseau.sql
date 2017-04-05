/*

Script d'insertion des données 
le 27 fevrier 2017

*/

USE BdTexcel_Eddy_Franck;

/*Insertion dans la table tblCategorieEmploiEmploye*/
INSERT INTO tblCategorieEmploiEmploye VALUES
(1,6),
(2,13),
(3,13),
(4,1),
(5,18),
(6,2),
(7,4),
(8,4),
(9,9),
(10,6),
(11,14),
(12,3),
(13,8),
(14,13),
(15,16),
(16,11),
(17,12),
(18,11),
(19,15),
(20,1),
(21,13),
(22,8),
(23,11),
(24,1),
(25,10),
(26,7),
(27,3),
(28,3),
(29,17),
(30,15),
(31,8),
(32,5),
(33,3),
(34,5),
(35,7),
(36,13),
(37,18),
(38,4),
(39,16),
(40,15),
(41,4),
(42,1),
(43,8),
(44,18),
(45,6),
(46,11),
(47,13),
(48,18),
(49,4),
(50,11);


/*Insertion dans la table Ville*/

INSERT INTO tblVille VALUES

('Les Îles-de-la-Madeleine'),
('Grosse-Île'),
('Percé'),
('Sainte-Thérèse-de-Gaspé'),
('Grande-Rivière'),
('Chandler'),
('Port-Daniel--Gascons'),
('Mont-Alexandre'),
('Gaspé'),
('Cloridorme'),
('Petite-Vallée'),
('Grande-Vallée'),
('Murdochville'),
('Rivière-Saint-Jean'),
('Collines-du-Basque'),
('Sainte-Madeleine-de-la-Rivière-Madeleine'),
('Saint-Maxime-du-Mont-Louis'),
('Mont-Saint-Pierre'),
('Rivière-à-Claude'),
('Québec'),
('L''Ancienne-Lorette'),
('Saint-Augustin-de-Desmaures'),
('Wendake'),
('Lévis'),
('Frampton'),
('Saints-Anges'),
('Vallée-Jonction'),
('Saint-Elzéar'),
('Sainte-Marie'),
('Sainte-Marguerite'),
('Sainte-Hénédine'),
('Scott'),
('Saint-Bernard'),
('Saint-Isidore'),
('Saint-Lambert-de-Lauzon'),
('Saint-Victor'),
('Saint-Alfred'),
('Beauceville'),
('Saint-Odilon-de-Cranbourne'),
('Saint-Joseph-de-Beauce'),
('Saint-Joseph-des-Érables'),
('Saint-Jules'),
('Tring-Jonction'),
('Saint-Frédéric'),
('Saint-Séverin'),
('Saint-Zacharie'),
('Sainte-Aurélie'),
('Saint-Prosper'),
('Saint-Benjamin'),
('Sainte-Rose-de-Watford'),
('Saint-Louis-de-Gonzague'),
('Saint-Cyprien'),
('Sainte-Justine'),
('Lac-Etchemin'),
('Saint-Luc-de-Bellechasse'),
('Sainte-Sabine'),
('Saint-Camille-de-Lellis'),
('Saint-Magloire'),
('Saint-Théophile'),
('Saint-Gédéon-de-Beauce'),
('Saint-Hilaire-de-Dorset'),
('Saint-Évariste-de-Forsyth'),
('La Guadeloupe'),
('Saint-Honoré-de-Shenley'),
('Saint-Martin'),
('Saint-René'),
('Saint-Côme--Linière'),
('Saint-Philibert'),
('Saint-Georges'),
('Lac-Poulin'),
('Saint-Benoît-Labre'),
('Saint-Éphrem-de-Beauce'),
('Notre-Dame-des-Pins'),
('Saint-Simon-les-Mines'),
('Saint-Augustin-de-Woburn'),
('Notre-Dame-des-Bois'),
('Val-Racine'),
('Piopolis'),
('Frontenac'),
('Lac-Mégantic'),
('Marston'),
('Milan'),
('Nantes'),
('Sainte-Cécile-de-Whitton'),
('Audet'),
('Saint-Robert-Bellarmin'),
('Saint-Ludger'),
('Lac-Drolet'),
('Saint-Sébastien'),
('Courcelles'),
('Lambton');

GO

/*Insertion dans la table tblCategorieEmploi*/


INSERT INTO tblCategorieEmploi VALUES
 ('Administration'),
('Communication'),
('Conception & Création'),
('Événementiel'),
('Formation'),
('Gestion de produits & services'),
('Marketing'),
('Media'),
('Médias sociaux'),
('Moteur de recherche'),
('Production'),
('Programmation Intégration'),
('Recherche'),
('Rédaction et traduction'),
('Relations publiques'),
('Ressources humaines'),
('Stratégie'),
('Technologie de l''information'),
('Ventes et développement des affaires');

/*Insertion dans la table tblEmploye*/


INSERT INTO tblEmploye(nomEmploye,prenomEmploye,dateDeNaissanceEmploye,adresseligne1Employe,adresseligne2Employe,codePostalEmploye,telephoneResidenceEmploye,posteTelephoniqueEmploye,matriculeEmploye,idVille) VALUES
('tremblay',	'thomas','	05/10/1996',	'1214 rue pelletier',	null,	'J0Y1C0',	'546-123-8754',	'10',	'wa1yta',23),
('gagnon',	'william','	05/10/1996',	'1215 rue pelletier',	null,	'J0Y1Z0',	'546-123-8755',	'20',	'wa2yta',70),
('roy',	'jacob','	05/10/1996',	'1216 rue hotte',	null,	'J0Y2H0',	'546-123-8756',	'30',	'wa3yta',	90),
('côté',	'liam','	05/10/1996',	'1217 rue hotte',	null,	'J0Y2M0',	'546-123-8757',	'40',	'wa4yta',	10),
('bouchard',	'felix','	05/10/1996',	'1218 rue hotte',	null,	'J0Y2M0',	'546-123-8758',	'50',	'wa5yta',	19),
('gauthier',	'nathan','	05/10/1996',	'1219 rue hotte',	null,	'J0Y2M0',	'546-123-8759',	'60',	'wa6yta',	26),
('morin',	'samuel','	05/10/1996',	'1220 rue pelletier',	null,	'J0Y3M0',	'546-123-8760',	'70',	'wa7yta',	25),
('lavoie',	'logan','	05/10/1996',	'1221 rue pelletier',	null,	'J9P0J1',	'546-123-8761',	'80',	'wa8yta',	17),
('fortin',	'alexis','	05/10/1996',	'1222 rue pelletier',	null,	'J9P0J7',	'546-123-8762',	'90',	'wa9yta',	23),
('gagné',	'noah','	05/10/1996',	'1223 rue pelletier',	null,	'J9P1L8',	'546-123-8763',	'100',	'sp1yta',	62),
('ouellet',	'olivier','	05/10/1996',	'1224 rue pelletier',	null,	'J9P1M8',	'546-123-8764',	'110',	'sp2yta',	14),
('pelletier',	'raphael','	05/10/1996',	'2356 rue DeLaBretagne',	null,	'J9P1N8',	'546-123-8765',	'120',	'sp3yta',	88),
('bélanger',	'gabriel','	05/10/1996',	'2357 rue DeLaBretagne',	null,	'J9P1Z9',	'546-123-8766',	'130',	'sp4yta',	20),
('lévesque',	'emile','	05/10/1996',	'2358 rue DeLaBretagne',	null,	'J9P2Z9',	'546-123-8767',	'140',	'sp5yta',	28),
('bergeron',	'leo','	05/10/1996',	'3523 rue saint-thomas',	null,	'J9P3Z9',	'546-123-8768',	'150',	'sp6yta',	72),
('leblanc',	'charles','	05/10/1996',	'3524 rue saint-thomas',	null,	'J9P4G3',	'546-123-8769',	'160',	'sp7yta',	84),
('paquette',	'antoine','	05/10/1996',	'3525 rue saint-thomas',	null,	'J9P4H9',	'546-123-8770',	'170',	'sp8yta',	28),
('girard',	'benjamin','	05/10/1996',	'3133 boulevard montmorency ouest',	null,	'J9P4J9',	'546-123-8771',	'210',	'sp9yta',	88),
('simard',	'adam','	05/10/1996',	'3134 boulevard montmorency ouest',	null,	'J9P4N2',	'546-123-8772',	'230',	'sp1pta',	38),
('boucher',	'edouard','	05/10/1996',	'3528 rue saint-thomas',	null,	'J9P4N7',	'546-123-8773',	'250',	'sp2pta',	12),
('caron',	'xavier','	05/10/1996',	'4534 rue bovin',	null,	'J9P4P6',	'546-123-8774',	'270',	'sp3pta',	55),
('beaulieu',	'victor','	05/10/1996',	'4535 rue bovin',	null,	'J9P4S9',	'546-123-8775',	'290',	'sp4pta',	37),
('cloutier',	'zack','	05/10/1996',	'4536 rue bovin',	null,	'J9P4X8',	'546-123-8776',	'310',	'sp5pta',	88),
('dubé',	'mathis','	05/10/1996',	'1520 boulevard talbot',	null,	'J9P4Z9',	'546-123-8777',	'330',	'sp6pta',	90),
('poirier',	'jayden','	05/10/1996',	'1521 boulevard talbot',	null,	'J9P5C2',	'546-123-8778',	'350',	'sp7pta',	90),
('fournier',	'theo','	05/10/1996',	'1522 boulevard talbot',	null,	'J9P5K8',	'546-123-8779',	'370',	'sp8pta',	12),
('lapointe',	'elliot','	05/10/1996',	'1523 boulevard talbot',	null,	'J9P5R4',	'546-123-8780',	'390',	'sp9pta',	30),
('leclerc',	'zachary','	05/10/1996',	'2359 rue DeLaBretagne',	null,	'J9P5Y6',	'546-123-8781',	'410',	'sp1uta',	13),
('lefebvre',	'louis','	05/10/1996',	'2360 rue DeLaBretagne',	null,	'J9P5Z9',	'547-234-5050',	'430',	'sp2uta',	87),
('poulin',	'james','	05/10/1996',	'2361 rue DeLaBretagne',	null,	'J9P6G8',	'547-234-5051',	'450',	'sp3uta',	39),
('thibault',	'anthony','	05/10/1996',	'2040 rue sainte-dominique',	null,	'J9P6K9',	'547-234-5052',	'470',	'sp4uta',	71),
('st-pierre',	'alexandre','	05/10/1996',	'2041 rue sainte-dominique',	null,	'J9P6L8',	'547-234-5053',	'490',	'sp5uta',	73),
('nadeau',	'lucas','	05/10/1996',	'2042 rue sainte-dominique',	null,	'J9P6M8',	'547-234-5054',	'510',	'sp6uta',	51),
('martin',	'justin','	05/10/1996',	'5030 avenue Sainte-Rose',	null,	'J9P6N7',	'547-234-5055',	'530',	'sp7uta',	42),
('landry',	'arthur','	05/10/1996',	'5031 avenue Sainte-Rose',	null,	'J9P6P9',	'547-234-5056',	'550',	'sp8uta',	65),
('martel',	'tristan','	05/10/1996',	'5032 avenue Sainte-Rose',	null,	'J9P6R7',	'547-234-5057',	'570',	'sp9uta',	30),
('bédard',	'loic','	05/10/1996',	'5033 avenue Sainte-Rose',	null,	'J9P6S8',	'547-234-5058',	'590',	'up1uta',	73),
('grenier',	'ethan','	05/10/1996',	'8650 avenue laurentides',	null,	'J9P6Z8',	'547-234-5059',	'610',	'up2uta',	5),
('lessard',	'henri','	05/10/1996',	'8651 avenue laurentides',	null,	'J9P7C4',	'547-234-5060',	'630',	'up3uta',	21),
('bernier',	'nolan','05/10/1996',	'8652 avenue laurentides',	null,	'J9P7C5',	'547-234-5061',	'650',	'up4uta',	85),
('richard',	'nicolas','05/10/1996',	'8653 avenue laurentides',	null,	'J9P7H8',	'547-234-5062',	'670',	'up5uta',	7),
('michaud',	'arnaud','05/10/1996',	'3132 boulevard montmorency ouest',	null,	'J9P5R8',	'547-234-5063',	'690',	'up6uta',	18),
('hébert',	'jeremy','05/10/1996',	'2043 rue sainte-dominique',	null,	'J9P5Z1',	'547-234-5064',	'710',	'up7uta',	75),
('desjardins',	'hugo','05/10/1996',	'2044 rue sainte-dominique',	null,	'J9P6A3',	'547-234-5065',	'730',	'up8uta',	58),
('couture',	'dylan','05/10/1996',	'2045 rue sainte-dominique',	null,	'J9P6H1',	'547-234-5066',	'750',	'up9uta',	12),
('turcotte',	'laurent','05/10/1996',	'2046 rue sainte-dominique',	null,	'J9P6L2',	'547-234-5067',	'770',	'rp1uta',	59),
('lachance',	'eli','05/10/1996',	'3040 rue DesBoitiers',	null,	'J9P6M2',	'547-234-5068',	'790',	'rp2uta',	81),
('parent',	'vincent','05/10/1996',	'4537 rue bovin',	null,	'J9P6N1',	'547-234-5069',	'810',	'rp3uta',	28),
('blais',	'isaac','05/10/1996',	'4538 rue bovin',	null,	'J9P6P3',	'547-234-5070',	'830',	'rp4uta',	74),
('gosselin',	'etienne','	05/10/1996',	'4539 rue bovin',	null,	'J9P6R2',	'547-234-5071',	'850',	'rp5uta',	60);


/*Insertion dans la table tblGerant*/

INSERT INTO tblGerant VALUES
(1,'Jean1','motDePasse','administrateur'),
(2,'Jean2','motDePasse','administrateur'),
(3,'Jean3','motDePasse','administrateur'),
(4,'Jean4','motDePasse','administrateur'),
(5,'Jean5','motDePasse','administrateur'),
(6,'Jean6','motDePasse','administrateur'),
(7,'Jean7','motDePasse','administrateur'),
(8,'Jean8','motDePasse','directeur'),
(9,'Jean9','motDePasse','directeur'),
(10,'Jean10','motDePasse','directeur'),
(11,'Jean11','motDePasse','directeur'),
(12,'Jean12','motDePasse','directeur'),
(13,'Jean13','motDePasse','directeur');

/*Insertion dans la table tblAdministrateur*/

INSERT INTO tblAdministrateur VALUES
(1),
(2),
(3),
(4),
(5),
(6),
(7);

/*Insertion dans la table tblDirecteur*/

INSERT INTO tblDirecteur VALUES
(8),
(9),
(10),
(11),
(12),
(13);

/*Insertion dans la table tblSE*/

INSERT INTO tblSE VALUES
('Windows','professionnel','10',null),
('Mac OS','standard','X',null),
('Linux','standard','5',null),
('Debian','standard','4',null),
('Ubuntu','standard','4',null),
('Android','standard','4',null),
('IOS','standard','4',null),
('Windows','famille','8',null),
('Windows','famille','7',null),
('Playstation','standard','4',null),
('Playstation','standard','3',null),
('Windows','entreprise','10',null);

/*('Windows','professionnel','10'),
('Mac OS',null,'X'),
('Linux',null,'5'),
('Debian',null,'4'),
('Ubuntu',null,'4'),
('Android',null,'4'),
('IOS',null,'4'),
('Windows','famille','8'),
('Windows','famille','7'),
('Playstation',null,'4'),
('Playstation',null,'3'),
('Windows','entreprise','10');*/

/*Insertion dans la table tblTypePlateforme*/
INSERT INTO tblTypePlateforme VALUES
('Ordinateur'),
('Console'),
('Telephone'),
('Tablette'),
('Montre'),
('Lunette'),
('Television');


/*Insertion dans la table tblPlateforme*/

INSERT INTO tblPlateforme VALUES
('PS4',	'16Go mémoire',2,10,null),
('PS3',	'20Go mémoire',2,11,null),
('RazerBlade',	'Carte graphique Geforce',1,12,null),
('XboxOne',	'20Go mémoire',2,8,null),--une Xbox tourne avec windows
('HP Spectre','SSD, 16 Go Ram',1,12,null),
('Dell latitude','HDD, 8 Go Ram',1,12,null);


/*Insertion dans la table tblPlateformeJeu*/

INSERT INTO tblPlateformeJeu VALUES
(1,1),
(1,2),
(3,3),
(1,4),
(1,5),
(5,6),
(4,7),
(6,7),
(5,8),
(6,9),
(5,10),
(5,11),
(4,12),
(1,12),
(2,12),
(2,13),
(1,14),
(2,15),
(1,15);

/*Insertion dans la table tblGenre*/

INSERT INTO tblGenre VALUES
('Combat'),
('Programmation'),
('Aventure'),
('Course'),
('Survie'),
('Strategie'),
('Guerre'),
('Sport'),
('Action');

--INSERT INTO tblGenreJeu VALUES
INSERT INTO tblGenreJeu VALUES
(4,1),
(2,2),
(3,3),
(1,4),
(7,5),
(5,6),
(9,7),
(9,8),
(9,9),
(8,10),
(8,11),
(9,11),
(6,12),
(7,13),
(7,14),
(2,14),
(3,15);

/*Insertion dans la table tblClassification*/


INSERT INTO tblClassification VALUES
('Classification1'),
('Classification2'),
('Classification3'),
('Classification4'),
('Classification5');

INSERT INTO tblClassificationJeu VALUES
(1,1),
(3,2),
(4,3),
(5,4),
(2,5),
(3,6),
(1,7),
(3,8),
(3,9),
(3,10),
(3,11),
(4,11),
(2,12),
(2,13),
(1,14),
(5,14),
(3,15);

/*Insertion dans la table tblTheme*/

INSERT INTO tblTheme VALUES
('Sorcellerie'),
('Magie'),
('Justice'),
('Tresor'),
('Football'),
('Espionnage'),
('Hockey');

--INSERT INTO tblThemeJeu VALUES

/*Insertion dans la table tblThemeJeu*/

INSERT INTO tblThemeJeu VALUES
(1,1),
(3,2),
(4,3),
(5,4),
(6,5),
(6,6),
(6,7),
(6,8),
(7,9),
(7,10),
(2,11),
(3,11),
(3,12),
(2,12),
(3,13),
(3,14),
(5,15);

/*Insertion dans la table tblJeu*/

INSERT INTO tblJeu VALUES
('CivilWar',	'GamaPlay',	'Parcourir pluieurs villes dans le but de conquerir des térritoires','2Go Ram, processeur dual core',1,null),
('NHL08',	'EASport',	'Jouez des matchs de hockey avec vos amis','2Go Ram, processeur dual core',2,null),
('NHL09',	'EASport',	'Jouez des matchs de hockey avec vos amis','2Go Ram, processeur dual core',3,null),
('Battle Field',	'MacroIndustrie',	'Vous etes un millitaire. Servez votre patrie.','2Go Ram, processeur dual core',4,null),
('ForHonor',	'Ubisoft',	'Combat à l''épée au 19 siecle.','2Go Ram, processeur dual core',5,null),
('Fifa17',	'EASport',	'Jouez au soccer avec vos amis.','2Go Ram, processeur dual core',6,null),
('Hitman',	'BluePlay',	'Vous etes un espion. Remplissez des missions secretes.',	'2Go Ram, processeur dual core',7,null),
('Fifa16',	'EASport',	'Jouez au soccer avec vos amis.','2Go Ram, processeur dual core',8,null),
('Fifa15',	'EASport',	'Jouez au soccer avec vos amis.','2Go Ram, processeur dual core',9,null),
('Fifa14',	'EASport',	'Jouez au soccer avec vos amis.','2Go Ram, processeur dual core',10,null),
('Fifa13',	'EASport',	'Jouez au soccer avec vos amis.','2Go Ram, processeur dual core',11,null),
('NHL10',	'EASport',	'Jouez des matchs de hockey avec vos amis','2Go Ram, processeur dual core',12,null),
('NHL11',	'EASport',	'Jouez des matchs de hockey avec vos amis','2Go Ram, processeur dual core',13,null),
('NHL12',	'EASport',	'Jouez des matchs de hockey avec vos amis','2Go Ram, processeur dual core',14,null),
('NHL13',	'EASport',	'Jouez des matchs de hockey avec vos amis','2Go Ram, processeur dual core',15,null);

/*Insertion dans la table tblProjetTest*/



INSERT INTO tblProjetTest VALUES
('Projet1',GETDATE()),
('Projet2',GETDATE()),
('Projet3',GETDATE()),
('Projet4',GETDATE()),
('Projet5',GETDATE()),
('Projet6',GETDATE()),
('Projet7',GETDATE()),
('Projet8',GETDATE()),
('Projet9',GETDATE()),
('Projet10',GETDATE()),
('Projet11',GETDATE()),
('Projet12',GETDATE()),
('Projet13',GETDATE()),
('Projet14',GETDATE()),
('Projet15',GETDATE());


/*Insertion dans la table tblCategorie*/

INSERT INTO tblCategorie VALUES
('Graphisme'),
('Jouabilité'),
('Intelligence artificielle'),
('Actions');

INSERT INTO tblEquipe VALUES
('Equipe1',20,8),
('Equipe2',24,10),
('Equipe3',28,12),
('Equipe4',30,11),
('Equipe5',32,9),
('Equipe6',35,13),
('Equipe7',45,10),
('Equipe8',41,12);

INSERT INTO tblTest VALUES
('Test sur le deplacement des personnages',1,1,1),
('Test le plan de jeu, les paysages',1,7,1),
('Test le plan de jeu, les paysages',2,8,2),
('Test le plan de jeu, les paysages',1,8,2),
('Test le plan de jeu, les paysages',3,2,3),
('Test le plan de jeu, les paysages',1,7,3),
('Test sur le deplacement des personnages',4,5,4),
('Test le plan de jeu, les paysages',3,5,4),
('Test sur le deplacement des personnages',4,3,5),
('Test le plan de jeu, les paysages',2,2,5),
('Test le plan de jeu, les paysages',4,4,6),
('Test le plan de jeu, les paysages',4,5,6),
('Test le plan de jeu, les paysages',4,6,7),
('Test le plan de jeu, les paysages',2,6,7),
('Test sur le deplacement des personnages',3,8,8),
('Test sur le deplacement des personnages',4,7,8),
('Test sur le deplacement des personnages',1,7,8),
('Test sur le deplacement des personnages',2,2,9),
('Test sur le deplacement des personnages',1,5,10),
('Test sur le deplacement des personnages',2,4,10),
('Test sur le deplacement des personnages',1,2,11),
('Test sur le deplacement des personnages',4,7,11),
('Test sur le deplacement des personnages',2,5,12),
('Test sur le deplacement des personnages',2,6,13),
('Test sur le deplacement des personnages',3,7,14),
('Test sur le deplacement des personnages',4,7,15);

INSERT INTO tblEquipeEmploye VALUES
(20,1),
(21,1),
(22,1),
(23,1),
(24,2),
(25,2),
(26,2),
(27,2),
(28,3),
(29,3),
(30,4),
(31,4),
(32,5),
(34,5),
(32,6),
(35,6),
(40,7),
(45,7),
(41,8);