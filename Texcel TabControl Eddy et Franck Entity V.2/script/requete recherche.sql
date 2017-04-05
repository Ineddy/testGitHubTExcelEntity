use BdTexcel


/*Requete qui r�cup�re les infos dans le tag jeu et le nom de la plateforme*/
/* Il faudrait ajouter les th�mes, classification et genre une fois que le module fonctionne*/

select * 
	from tblJeu as J
	join tblPlateformeJeu as PJ
		on J.idJeu = PJ.idJeu
	join tblPlateforme as P
		on PJ.idPlateforme = P.idPlateforme
			WHERE P.nomPlateforme like '%Fifa%' OR tag like '%Fifa% '
