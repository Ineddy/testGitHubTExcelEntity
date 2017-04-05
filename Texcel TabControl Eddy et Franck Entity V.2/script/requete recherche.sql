use BdTexcel


/*Requete qui récupère les infos dans le tag jeu et le nom de la plateforme*/
/* Il faudrait ajouter les thèmes, classification et genre une fois que le module fonctionne*/

select * 
	from tblJeu as J
	join tblPlateformeJeu as PJ
		on J.idJeu = PJ.idJeu
	join tblPlateforme as P
		on PJ.idPlateforme = P.idPlateforme
			WHERE P.nomPlateforme like '%Fifa%' OR tag like '%Fifa% '
