/*ProjetTexcel - update tag jeu*/

use BdTexcel;

update tblJeu 
set tag = CONCAT(nomJeu ,' ',devellopeurJeu ,' ', descriptionJeu,' ',configurationMinimaleJeu)