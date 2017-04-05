/*ProjetTexcel - update tag jeu*/

use BdTexcel_Eddy_Franck;

update tblJeu 
set tag = CONCAT(nomJeu ,' ',devellopeurJeu ,' ', descriptionJeu,' ',configurationMinimaleJeu)

update tblPlateforme
set tagPlateforme = CONCAT(nomPlateforme,' ', configurationPlateforme)

update tblSE
set tagSE = CONCAT(nomSE,' ',editionSE,' ',versionSE)