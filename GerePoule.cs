/*
 * Crée par SharpDevelop.
 * Utilisateur: CHAUTARD
 * Date: 11/12/2019
 * Heure: 11:58
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Criterium_16_4
{
	/// <summary>
	/// Description of GerrePoule.
	/// </summary>
	public class GerePoule
	{
		DataGridView _dgvScore;
		RichTextBox _txtRapport;
		
		Joueur _joueur1 = new Joueur();
		Joueur _joueur2 = new Joueur();
		Joueur _joueur3 = new Joueur();
		Joueur _joueur4 = new Joueur();
		
		Joueur[] _aJoueur = new Joueur[4];
		PointsJoueur [] _aPointJoueur = new PointsJoueur[4];
		
		int _nbJoueur = 0;
		char _cPoule; // A, B, C, D
		
		public GerePoule( char cPoule, RichTextBox txtBox, DataGridView dgv)
		{
			this._cPoule = cPoule;
			this._txtRapport = txtBox;
			this._dgvScore = dgv;
		}
		
		public void Clear()
		{
			_joueur1 = new Joueur();
			_joueur2 = new Joueur();
			_joueur3 = new Joueur();
			_joueur4 = new Joueur();
		}
		
		public void InitJoueur(Joueur j)
		{
			switch(_nbJoueur)
			{
				case 0:
					_joueur1 = j;
					_nbJoueur++;
					_joueur1.NumInPoule = _nbJoueur;
					break;
					
				case 1:
					_joueur2 = j;
					_nbJoueur++;
					_joueur2.NumInPoule =_nbJoueur;
					break;
					
				case 2:
					_joueur3 = j;
					_nbJoueur++;
					_joueur3.NumInPoule =_nbJoueur;
					break;
					
				case 3:
					_joueur4 = j;
					_nbJoueur++;
					_joueur4.NumInPoule =_nbJoueur;
					break;
					
				default:
					MessageBox.Show("Seulement les poules de 4 joueurs maximum sont gerré actuellement !");
					break;
			}
		}
		
		// Recherche de l'objet Joueur à partir du nom et prénom de la Grid
		public void InitJoueurByname(List<Joueur> lJoueur, string sDgvPoule)
		{
			// Découpage du nom et du club
			string[] stringSeparators = new string[] { "\r\n" };
			string[] lines = sDgvPoule.Split(stringSeparators, StringSplitOptions.None);
			
			// Recherche de l'objet Joueur
			InitJoueur( lJoueur.Find(x => x.Nom.Contains(lines[0])));
		}
		
		// Classsement de 2 à 4 joueurs
		public Joueur[] Classement()
		{
			// 1 seul joueur
			if(_nbJoueur == 1)
			{
				_aJoueur[0] = _joueur1;
				return _aJoueur;
			}
			
			// Seulement 2 joueurs
			if(_nbJoueur == 2)
			{
				// Voir le résultat de la partie entre les deux joueurs
				_dgvScore.Rows[0].Cells[12].Style.BackColor = Color.Gray;
				_dgvScore.Rows[0].Cells[13].Style.BackColor = Color.Gray;
				
				
				if( QuiGagne2( 0, 10, 11, true) )
				{
					AddJoueur( 1, 0 );
					AddJoueur( 2, 1 );
				}
				else
				{
					AddJoueur( 1, 1 );
					AddJoueur( 2, 0 );
				}
				return _aJoueur;
			}
			
			// 3 joueurs
			if(_nbJoueur == 3)
			{
				Classement3Joueur();
				return _aJoueur;
			}
			
			// 4 joueurs
			Classement4Joueur();
			
			return _aJoueur;
		}
		
		/*
		 * QuiGagne entre 2 joueur
		 * 
		 * iRow -> Ligne dans la grille
		 * iJ1 -> Colonne pour le premier joueur J1 ou J2 ou J3 ou J4
		 * iJ2 -> idem							 10    11    12    13
		 */
		bool QuiGagne2(int iRow, int iJ1, int iJ2, bool bRow6 = false)
		{
			// gestion du forfait et abandon
			bool[] bAbandonFofait = { false, false };
			
			bAbandonFofait = GetAbandonForfait(iRow);
			
			/* Gestion des manches
			 * Mise en couleur des manches gagnées
			 */
			int iMancheJ1 = GetMancheJoueur1( iRow, bAbandonFofait);
			
			// Mise en couleur du gagnant
			int iPointJoueur1 = 0;
			int iPointJoueur2 = 0;
			
			if(iMancheJ1 == 3)
			{
				_dgvScore.Rows[iRow].Cells[iJ1].Value = 2;
				iPointJoueur1 += 2;
				
				if( bAbandonFofait[1] )
					_dgvScore.Rows[iRow].Cells[iJ2].Value = 0;
				else
				{
					_dgvScore.Rows[iRow].Cells[iJ2].Value = 1;
					iPointJoueur2++;
				}
			}
			else
			{
				_dgvScore.Rows[iRow].Cells[iJ2].Value = 2;
				iPointJoueur2 +=2;
				
				if( bAbandonFofait[0] )
					_dgvScore.Rows[iRow].Cells[iJ1].Value = 0;
				else
				{
					_dgvScore.Rows[iRow].Cells[iJ1].Value = 1;
					iPointJoueur1++;
				}
			}
			
			// Affichage des totaux points
			if(bRow6)
				_dgvScore.Rows[6].Cells[8].Value = "Total :";
			
			int iTot = iPointJoueur1 + iPointJoueur2;
			
			if(bRow6)
			{
				_dgvScore.Rows[6].Cells[9].Value = iTot;
				
				_dgvScore.Rows[6].Cells[10].Value = iPointJoueur1.ToString();
				_dgvScore.Rows[6].Cells[11].Value = iPointJoueur2.ToString();
			}
			
			// Affichage du contrôle
			setTextRapport( "Total des points parties", true);
			setTextRapport( "2 * 3 = 6 points/partie");
			setTextRapport( "Attributé : " + iTot.ToString() + " points/partie");
			setTextRapport( "Les deux valeurs doivent être égale, moins les partie Abandonnées ou Forfait");
			
			setTextRapport( "Points / Partie : ", true);
			setTextRapport( "+---+---+");
			setTextRapport( "| 1 | " + iPointJoueur1.ToString() + " |");
			setTextRapport( "+---+---+");
			setTextRapport( "| 2 | " + iPointJoueur2.ToString() + " |");
			setTextRapport( "+---+---+");
			
			return (iPointJoueur1 > iPointJoueur2);
		}
		
		// Classsement de 3 joueurs
		void Classement3Joueur()
		{
			string[] sPartie3 = { "1 - 3", "2 - 3", "1 - 2"};
			string[,] sPointsParties3 = { { "0","--","0"}, {"--","0","0"}, { "0","0","--"} };
			
			_dgvScore.Rows[0].Cells[11].Style.BackColor = Color.Gray; // "0","--","0"
			_dgvScore.Rows[1].Cells[10].Style.BackColor = Color.Gray; // "--","0","0"
			_dgvScore.Rows[2].Cells[12].Style.BackColor = Color.Gray; // "0","0","--"
			
			// Gestion du forfait et abandon
			bool[] bAbandonForfait = { false, false};
			int iJ1 = 0, iJ2 = 0;
			int iMancheJ1;
			
			PointsJoueur[] aPointsJoueur = null;
			
			// Pour les 6 parties
			for ( int iRow = 0; iRow < 3; iRow++ )
			{
				// 0 = Total
				aPointsJoueur = new PointsJoueur[4];
				
				// gestion du forfait et abandon
				bAbandonForfait = GetAbandonForfait(iRow);
				
				/* Gestion des manches
				 * Mise en couleur des manches gagnées
				 */
				iMancheJ1 = GetMancheJoueur1( iRow, bAbandonForfait);

				// Correspondance ligne et joueur
				iJ1 = SingletonOutils.GetPartie()[iRow].iJoueur1;
				iJ2 = SingletonOutils.GetPartie()[iRow].iJoueur2;

				// Mise en couleur du gagnant
				if (iMancheJ1 == 3)
				{

					_dgvScore.Rows[iRow].Cells[9+iJ1].Value = 2;
					aPointsJoueur[iJ1].Add(2);
					
					if( bAbandonForfait[1] )
						_dgvScore.Rows[iRow].Cells[9+iJ2].Value = 0;
					else
					{
						_dgvScore.Rows[iRow].Cells[9+iJ2].Value = 1;
						aPointsJoueur[iJ2].Add(1);
					}
				}
				else
				{
					_dgvScore.Rows[iRow].Cells[9+iJ2].Value = 2;
					aPointsJoueur[iJ2].Add(2);
					
					if( bAbandonForfait[0] )
						_dgvScore.Rows[iRow].Cells[9+iJ1].Value = 0;
					else
					{
						_dgvScore.Rows[iRow].Cells[9+iJ1].Value = 1;
						aPointsJoueur[iJ1].Add(1);
					}
				}
			}
			
			// Affichage des totaux points
			_dgvScore.Rows[6].Cells[8].Value = "Total :";
			int iTot = aPointsJoueur[1].GetPoint() + aPointsJoueur[2].GetPoint() + aPointsJoueur[3].GetPoint();
			
			_dgvScore.Rows[6].Cells[9].Value = iTot;
			
			_dgvScore.Rows[6].Cells[10].Value = aPointsJoueur[1].GetPoint();
			_dgvScore.Rows[6].Cells[11].Value = aPointsJoueur[2].GetPoint();
			_dgvScore.Rows[6].Cells[12].Value = aPointsJoueur[3].GetPoint();

			// Affichage du contrôle
			setTextRapport( "Total des points parties", true);
			setTextRapport( "3 * 3 = 9 points/partie");
			setTextRapport( "Attributé : " + iTot.ToString() + " points/partie");
			setTextRapport( "Les deux valeurs doivent être égale, moins les partie Abandonnées ou Forfait");
			
			// PointsPartie pointsPartie = new PointsPartie( _dgvScore );
			
			/* 
			 * Egalité des points partie
			 * 
			 */
			
			// TroisEgal( 1, 2, 3);
		}
		
		/*--------------------------------------------------------------------------
		 * 					Classsement de 4 joueurs
		 *--------------------------------------------------------------------------
		 */
		void Classement4Joueur()
		{
			// Grise les zones non utilisable
			for(int i = 0; i < 6; i++)
			{
				for(int j = 0; j < 4; j++)
				{
					if(SingletonOutils.GetPointsParties4()[i,j] == SingletonOutils.CELLVIDE)
						_dgvScore.Rows[i].Cells[10+j].Style.BackColor = Color.Gray;
				}
			}
			
			// Calcul des points parties entre les 4 joueurs
			PointsPartie pointsPartie = new PointsPartie( _dgvScore );
			
			pointsPartie.CalculePointsPartie();
			
			// Affichage des points des joueurs pour les parties
			_dgvScore.Rows[6].Cells[10].Value = pointsPartie.getPointA();
			_dgvScore.Rows[6].Cells[11].Value = pointsPartie.getPointB();
			_dgvScore.Rows[6].Cells[12].Value = pointsPartie.getPointC();
			_dgvScore.Rows[6].Cells[13].Value = pointsPartie.getPointD();
			
			// 0 = joueur 1
			// 1 = joueur 2
			// 2 = joueur 3
			// 3 = joueur 4
			
			_aPointJoueur[0] = new PointsJoueur( 1, pointsPartie.getPointA() );
			_aPointJoueur[1] = new PointsJoueur( 2, pointsPartie.getPointB() );
			_aPointJoueur[2] = new PointsJoueur( 3, pointsPartie.getPointC() );
			_aPointJoueur[3] = new PointsJoueur( 4, pointsPartie.getPointD() );
			
			DumpPointJoueur( "Points / Partie : ", _aPointJoueur );
			
			// Premierement classement par les points
			Array.Sort(_aPointJoueur);
			
			DumpPointJoueur( "Points / Partie : Aprés trie", _aPointJoueur );
			
			int [] aiEgal = { 0, 0, 0};
			
			// Calcul des manches
			float [] afManche = { 0, 0, 0, 0};
			
			// Calcul des points
			float [] afPoint = { 0, 0, 0, 0};
			
			int iJ1, iJ2, iJ3, iJ4;
			int i1, i2, i3, i4;
			bool bouclePartie = true;
			
			// Quadruple égalitée
			if( _aPointJoueur[ 0 ].GetPoint() == _aPointJoueur[ 1 ].GetPoint() &&
			   _aPointJoueur[ 0 ].GetPoint() == _aPointJoueur[ 2 ].GetPoint() &&
			   _aPointJoueur[ 0 ].GetPoint() == _aPointJoueur[ 3 ].GetPoint() )
			{
				setTextRapport( "Egalité 1° et 2° et 3° et 4°", true);
				
				// Gestion des manches
				Manche	manche = new Manche( _dgvScore, _txtRapport );
				
				manche.CalculeManche4( 0, 1, 2, 3);
				
				// Affichage des résultats
				manche.Dump();
				
				// @TODO
				
				// Affichage des résultat
				bouclePartie = false;
			}
			
			/*
			 *  Est-il possible de ranger des joueurs dans le classement
			 *  24  possibilités d'arrangement des 4 joueurs
			 */
			for( int i = 0; i < 24 && bouclePartie; i++)
			{
				iJ1 = SingletonOutils.GetPossibleClassement( i, 0);
				iJ2 = SingletonOutils.GetPossibleClassement( i, 1);
				iJ3 = SingletonOutils.GetPossibleClassement( i, 2);
				iJ4 = SingletonOutils.GetPossibleClassement( i, 3);
				
				i1 = iJ1 - 1;
				i2 = iJ2 - 1;
				i3 = iJ3 - 1;
				i4 = iJ4 - 1;
				
				// Tous les points sont différant
				if( _aPointJoueur[ i1 ].GetPoint() > _aPointJoueur[ i2 ].GetPoint() &&
				   _aPointJoueur[ i2 ].GetPoint() > _aPointJoueur[ i3 ].GetPoint() &&
				   _aPointJoueur[ i3 ].GetPoint() > _aPointJoueur[ i4 ].GetPoint() )
				{
					AddJoueur( iJ1 );
					AddJoueur( iJ2 );
					AddJoueur( iJ3 );
					AddJoueur( iJ4 );
					
					bouclePartie = false; // Pas d'autre test
					break; // Fin de boucle i
				}
				
				// Double égalité  1 = 2 et 3 = 4
				if( _aPointJoueur[ i1 ].GetPoint() == _aPointJoueur[ i2 ].GetPoint() &&
				   _aPointJoueur[ i3 ].GetPoint() == _aPointJoueur[ i4 ].GetPoint() )
				{
					setTextRapport( "Egalité 1° et 2°", true);
					setTextRapport( "Egalité 3° et 4°", true);
					
					if(_aPointJoueur[ i1 ].GetPoint() > _aPointJoueur[ i2 ].GetPoint())
					{
						AddJoueur( iJ1 );
						AddJoueur( iJ2 );
					}
					else
					{
						AddJoueur( iJ2 );
						AddJoueur( iJ1 );
					}
					
					if(_aPointJoueur[ i3 ].GetPoint() > _aPointJoueur[ i4 ].GetPoint())
					{
						AddJoueur( iJ3 );
						AddJoueur( iJ4 );
					}
					else
					{
						AddJoueur( iJ4 );
						AddJoueur( iJ3 );
					}
					
					bouclePartie = false; // Pas d'autre test
					break; // Fin de boucle i
				}
				
				// Double égalité  1 = 3 et 2 = 4
				if( _aPointJoueur[ i1 ].GetPoint() == _aPointJoueur[ i3 ].GetPoint() &&
				   _aPointJoueur[ i2 ].GetPoint() == _aPointJoueur[ i4 ].GetPoint() )
				{
					setTextRapport( "Egalité 1° et 3°", true);
					setTextRapport( "Egalité 2° et 4°", true);
					
					if(_aPointJoueur[ i1 ].GetPoint() > _aPointJoueur[ i3 ].GetPoint())
					{
						AddJoueur( iJ1 );
						AddJoueur( iJ3 );
					}
					else
					{
						AddJoueur( iJ3 );
						AddJoueur( iJ1 );
					}
					
					if(_aPointJoueur[ i2 ].GetPoint() > _aPointJoueur[ i4 ].GetPoint())
					{
						AddJoueur( iJ2 );
						AddJoueur( iJ4 );
					}
					else
					{
						AddJoueur( iJ4 );
						AddJoueur( iJ2 );
					}
					
					bouclePartie = false; // Pas d'autre test
					break; // Fin de boucle i
				}
				
				// Egalite sur les deux premier
				if( _aPointJoueur[ i1 ].GetPoint() == _aPointJoueur[ i2 ].GetPoint() &&
				   _aPointJoueur[ i2 ].GetPoint() > _aPointJoueur[ i3 ].GetPoint() &&
				   _aPointJoueur[ i3 ].GetPoint() > _aPointJoueur[ i4 ].GetPoint() )
				{
					setTextRapport( "Egalité 1° et 2°", true);
					
					// Recherche du résultat entre les deux
					if( SingletonOutils.ChercheVainqueur( _dgvScore, iJ1, iJ2) )
					{
						AddJoueur( iJ1 );
						AddJoueur( iJ2 );
					}
					else
					{
						AddJoueur( iJ2 );
						AddJoueur( iJ1 );
					}
					
					AddJoueur( iJ3 );
					AddJoueur( iJ4 );
					
					bouclePartie = false; // Pas d'autre test
					break; // Fin de boucle i
				}
				
				// Egalite sur les deux du milieu
				if( _aPointJoueur[ i1 ].GetPoint() > _aPointJoueur[ i2 ].GetPoint() &&
				   _aPointJoueur[ i2 ].GetPoint() == _aPointJoueur[ i3 ].GetPoint() &&
				   _aPointJoueur[ i3 ].GetPoint() > _aPointJoueur[ i4 ].GetPoint() )
				{
					setTextRapport( "Egalité 2° et 3°", true);
					
					AddJoueur( iJ1 );
					
					// Recherche du résultat entre les deux
					if( SingletonOutils.ChercheVainqueur( _dgvScore, iJ2, iJ3) )
					{
						AddJoueur( iJ2 );
						AddJoueur( iJ3 );
					}
					else
					{
						AddJoueur( iJ3 );
						AddJoueur( iJ2 );
					}
					
					AddJoueur( iJ4 );
					
					bouclePartie = false; // Pas d'autre test
					break; // Fin de boucle i
				}
				
				// Egalite sur les deux de la fin
				if( _aPointJoueur[ i1 ].GetPoint() > _aPointJoueur[ i2 ].GetPoint() &&
				   _aPointJoueur[ i2 ].GetPoint() > _aPointJoueur[ i3 ].GetPoint() &&
				   _aPointJoueur[ i3 ].GetPoint() == _aPointJoueur[ i4 ].GetPoint() )
				{
					setTextRapport( "Egalité 3° et 4°", true);
					
					AddJoueur( iJ1 );
					AddJoueur( iJ2 );
					
					// Recherche du résultat entre les deux
					if( SingletonOutils.ChercheVainqueur( _dgvScore, iJ2, iJ3) )
					{
						AddJoueur( iJ3 );
						AddJoueur( iJ4 );
					}
					else
					{
						AddJoueur( iJ4 );
						AddJoueur( iJ3 );
					}
					
					bouclePartie = false; // Pas d'autre test
					break;
				}
			}
			
			/* Gestion des trois égalitées.
			 * 
			 *      1 = 2 = 3
			 * 		1 = 3 = 4
			 * 		1 = 2 = 4
			 * 		2 = 3 = 4
			 */
			
			// 1 = 2 = 3
			if ( bouclePartie && _aPointJoueur[0].GetPoint() == _aPointJoueur[1].GetPoint() && _aPointJoueur[0].GetPoint() == _aPointJoueur[2].GetPoint() )
			{
				showEgalite( 0, 1, 2 );

				// 4 > 1
				if( _aPointJoueur[3].GetPoint() > _aPointJoueur[0].GetPoint() )
					AddJoueur( _aPointJoueur[3].GetNumJoueur() );
				else
					AddJoueur( 4, _aPointJoueur[3].GetNumJoueur() );
				
				/* 
				 * Egalité des points partie
				 * 
				 */
				TroisEgal( 0, 1, 2 );

				
				bouclePartie = false; // Pas d'autre test
			}
			
			// 1 = 3 = 4
			if ( bouclePartie && _aPointJoueur[0].GetPoint() == _aPointJoueur[2].GetPoint() && _aPointJoueur[0].GetPoint() == _aPointJoueur[3].GetPoint() )
			{
				showEgalite( 0, 2, 3 );
				
				// 2 > 1
				if( _aPointJoueur[1].GetPoint() > _aPointJoueur[0].GetPoint() )
					AddJoueur( _aPointJoueur[2].GetNumJoueur() );
				else
					AddJoueur( 4, _aPointJoueur[2].GetNumJoueur() );
				
				/* 
				 * Egalité des points partie
				 * 
				 */
				TroisEgal( 0, 2, 3 );
				
				bouclePartie = false; // Pas d'autre test
			}
			
			// 	1 = 2 = 4
			if ( bouclePartie && _aPointJoueur[0].GetPoint() == _aPointJoueur[1].GetPoint() && _aPointJoueur[0].GetPoint() == _aPointJoueur[3].GetPoint() )
			{
				showEgalite( 0, 1, 3 );
				
				// 3 > 1
				if( _aPointJoueur[2].GetPoint() > _aPointJoueur[0].GetPoint() )
					AddJoueur( _aPointJoueur[3].GetNumJoueur() );
				else
					AddJoueur( 4, _aPointJoueur[3].GetNumJoueur() );
				
				/* 
				 * Egalité des points partie
				 * 
				 */
				TroisEgal( 0, 1, 3 );
				
				bouclePartie = false; // Pas d'autre test
			}
			
			// 2 = 3 = 4
			if ( bouclePartie && _aPointJoueur[1].GetPoint() == _aPointJoueur[2].GetPoint() && _aPointJoueur[1].GetPoint() == _aPointJoueur[3].GetPoint() )
			{
				showEgalite( 1, 2, 3 );
				
				// 1 > 2
				if( _aPointJoueur[0].GetPoint() > _aPointJoueur[1].GetPoint() )
					AddJoueur( _aPointJoueur[0].GetNumJoueur() );
				else
					AddJoueur( 4, _aPointJoueur[0].GetNumJoueur() );
				
				/* 
				 * Egalité des points partie
				 * 
				 */
				TroisEgal( 1, 2, 3 );
			}
			// Fin des égalitées de trois joueurs
			
			// Affichage du classement
			for(int i = 0; i < 4; i++)
			{
				if( _aJoueur[ i ] != null)
					_dgvScore.Rows[7].Cells[ 9 + _aJoueur[ i ].NumInPoule].Value = i+1;
			}
			
			DumpClassement();
		}

		/*
		 * Egalité des points partie entre les trois Joueurs
		 * 
		 * i, j, k = Indice dans le tableau _aPointJoueur ( 0, 1, 2, 3 )
		 * 
		 * Recalculer les points partie entre les trois joueurs.
		 */
		
		void TroisEgal( int i, int j, int k )
		{
			// Recherche des numéro des joueurs, moins 1 pour correspondre aux valeurs du tableau
			int i1 = _aPointJoueur[ i ].GetNumJoueur();
			int i2 = _aPointJoueur[ j ].GetNumJoueur();
			int i3 = _aPointJoueur[ k ].GetNumJoueur();
			
			PointsPartie pointsPartie = new PointsPartie( _dgvScore );
			
			// Calcul des points partie entre les trois joueurs
			pointsPartie.CalculePointsPartie3( i1, i2, i3 );
			
			switch( pointsPartie.Ordonne3( i1, i2, i3) )
			{
				case "===":
					// Si égalité dans les points partie
					// Calcul du quotient Manches gagnées / Manches Perdues
					
					// Gestion des manches
					Manche	manche = new Manche( _dgvScore, _txtRapport );
					
					manche.CalculeManche3( i1, i2, i3 );
					
					// Affichage des résultats
					manche.Dump();
					
					switch( manche.Quotient3( i1, i2, i3 ) )
					{
						case "===":
							// Calcul des points entre les trois joueurs
							ManchesPoints manchePoints = new ManchesPoints( _dgvScore, _txtRapport );
							
							manchePoints.CalculePoints3( i1, i2, i3 );
							
							// Affichage des résultats
							manchePoints.Dump();
							
							switch (manchePoints.Quotient3( i1, i2, i3 ) )
							{
								case "===":
									// Tirage au sort du gagnant
									Random random = new Random();
									
									int r1 = random.Next(0, 1000);
									int r2 = random.Next(0, 1000);
									int r3 = random.Next(0, 1000);
									
									while( r2 == r1)
										r2 = random.Next(0, 1000);

									while( r3 == r1 || r3 == r2 )
										r2 = random.Next(0, 1000);
									
									if( r1 > r2)
									{
										if(r2 > r3)
											caseABC( i1, i2, i3);
										else
											caseACB( i1, i2, i3);
									}									
									else if( r1 > r3)
									{
										if( r2 > r3)
											caseBAC( i1, i2, i3);
										else
											caseCBA( i1, i2, i3);
									}
									else
									{
										if( r2 > r3)
											caseBCA( i1, i2, i3);
										else
											caseCAB( i1, i2, i3);
									}
									break;
									
								case "A==":
									caseApp( i1, i2, i3);
									break;
									
								case "==A":
									caseppA( i1, i2, i3);
									break;
									
								case "B==":
									caseBpp( i1, i2, i3);
									break;
									
								case "==B":
									caseppB( i1, i2, i3);
									break;
									
								case "C==":
									caseCpp( i1, i2, i3);
									break;
									
								case "==C":
									caseppC( i1, i2, i3);
									break;
									
								case "ABC":
									caseABC( i1, i2, i3);
									break;
									
								case "ACB":
									caseACB( i1, i2, i3);
									break;
									
								case "BAC":
									caseBAC( i1, i2, i3);
									break;
									
								case "BCA":
									caseBCA( i1, i2, i3);
									break;
									
								case "CAB":
									caseCAB( i1, i2, i3);
									break;
									
								case "CBA":
									caseCBA( i1, i2, i3);
									break;		
							}
							break;
							
						case "A==":
							caseApp( i1, i2, i3);
							break;
							
						case "==A":
							caseppA( i1, i2, i3);
							break;
							
						case "B==":
							caseBpp( i1, i2, i3);
							break;
							
						case "==B":
							caseppB( i1, i2, i3);
							break;
							
						case "C==":
							caseCpp( i1, i2, i3);
							break;
							
						case "==C":
							caseppC( i1, i2, i3);
							break;
							
						case "ABC":
							caseABC( i1, i2, i3);
							break;
							
						case "ACB":
							caseACB( i1, i2, i3);
							break;
							
						case "BAC":
							caseBAC( i1, i2, i3);
							break;
							
						case "BCA":
							caseBCA( i1, i2, i3);
							break;
							
						case "CAB":
							caseCAB( i1, i2, i3);
							break;
							
						case "CBA":
							caseCBA( i1, i2, i3);
							break;
					}
					
					break;

				case "A==":
					caseApp( i1, i2, i3);
					break;
					
				case "==A":
					caseppA( i1, i2, i3);
					break;
					
				case "B==":
					caseBpp( i1, i2, i3);
					break;
					
				case "==B":
					caseppB( i1, i2, i3);
					break;
					
				case "C==":
					caseCpp( i1, i2, i3);
					break;
					
				case "==C":
					caseppC( i1, i2, i3);
					break;
					
				case "ABC":
					caseABC( i1, i2, i3);
					break;
					
				case "ACB":
					caseACB( i1, i2, i3);
					break;
					
				case "BAC":
					caseBAC( i1, i2, i3);
					break;
					
				case "BCA":
					caseBCA( i1, i2, i3);
					break;
					
				case "CAB":
					caseCAB( i1, i2, i3);
					break;
					
				case "CBA":
					caseCBA( i1, i2, i3);
					break;
			}
		}
		
		/*
		 * Les différantes fonction possible pour classement des joueurs
		 */
		
		void caseApp( int i1, int i2, int i3)
		{
			AddJoueur(i1);
			if( SingletonOutils.ChercheVainqueur( _dgvScore, i2, i3))
			{
				AddJoueur(i2);
				AddJoueur(i3);
			}
			else
			{
				AddJoueur(i3);
				AddJoueur(i2);
			}
		}

		void caseppA( int i1, int i2, int i3)
		{
			if( SingletonOutils.ChercheVainqueur( _dgvScore, i1, i2))
			{
				AddJoueur(i1);
				AddJoueur(i2);
			}
			else
			{
				AddJoueur(i2);
				AddJoueur(i1);
			}
			AddJoueur(i1);
		}

		void caseBpp( int i1, int i2, int i3)
		{
			AddJoueur(i2);

			if( SingletonOutils.ChercheVainqueur( _dgvScore, i1, i3))
			{
				AddJoueur(i1);
				AddJoueur(i3);
			}
			else
			{
				AddJoueur(i3);
				AddJoueur(i1);
			}
		}

		void caseppB( int i1, int i2, int i3)
		{
			if( SingletonOutils.ChercheVainqueur( _dgvScore, i1, i3))
			{
				AddJoueur(i1);
				AddJoueur(i3);
			}
			else
			{
				AddJoueur(i3);
				AddJoueur(i1);
			}
			AddJoueur(i2);
		}

		void caseCpp( int i1, int i2, int i3)
		{
			AddJoueur(i3);

			if( SingletonOutils.ChercheVainqueur( _dgvScore, i1, i2))
			{
				AddJoueur(i1);
				AddJoueur(i2);
			}
			else
			{
				AddJoueur(i2);
				AddJoueur(i1);
			}
		}

		void caseppC( int i1, int i2, int i3)
		{
			if( SingletonOutils.ChercheVainqueur( _dgvScore, i1, i2))
			{
				AddJoueur(i1);
				AddJoueur(i2);
			}
			else
			{
				AddJoueur(i2);
				AddJoueur(i1);
			}
			AddJoueur(i3);
		}

		void caseABC( int i1, int i2, int i3)
		{
			AddJoueur(i1);
			AddJoueur(i2);
			AddJoueur(i3);
		}

		void caseACB( int i1, int i2, int i3)
		{
			AddJoueur(i1);
			AddJoueur(i3);
			AddJoueur(i2);
		}

		void caseBAC( int i1, int i2, int i3)
		{
			AddJoueur(i2);
			AddJoueur(i1);
			AddJoueur(i3);
		}

		void caseCBA( int i1, int i2, int i3)
		{
			AddJoueur(i3);
			AddJoueur(i1);
			AddJoueur(i2);
		}

		void caseBCA( int i1, int i2, int i3)
		{
			AddJoueur(i2);
			AddJoueur(i3);
			AddJoueur(i1);
		}

		void caseCAB( int i1, int i2, int i3)
		{
			AddJoueur(i3);
			AddJoueur(i1);
			AddJoueur(i2);
		}
		
		// Abandon ou Forfait d'un des deux joueurs ou les deux
		bool[] GetAbandonForfait(int iRow)
		{
			// gestion du forfait et abandon
			bool[] bAbandonFofait = { false, false};
			
			if( _dgvScore.Rows[iRow].Cells[1].Value.ToString().CompareTo("A") == 0 ||
			   _dgvScore.Rows[iRow].Cells[1].Value.ToString().CompareTo("F") == 0 )
				bAbandonFofait[0] = true;
			
			if( _dgvScore.Rows[iRow].Cells[4].Value.ToString().CompareTo("A") == 0 ||
			   _dgvScore.Rows[iRow].Cells[4].Value.ToString().CompareTo("F") == 0 )
				bAbandonFofait[1] = true;
			
			return bAbandonFofait;
		}

		/* Gestion des manches
		 * Mise en couleur des manches gagnées
		 * 
		 * retourne le nombre de manche gagné par J1
		 */
		int GetMancheJoueur1(int iRow, bool[] bAbandonFofait)
		{
			int iMancheJ1 = 0;
			int iValue;
			string str;
			
			for( int iCol = 5; iCol < 10 && iMancheJ1 < 3; iCol++)
			{
				str = _dgvScore.Rows[iRow].Cells[iCol].Value.ToString();
				if ( str != null )
				{
					int.TryParse(str, out iValue);
					
					// Mise en couleur des manches gagnées
					if ( iValue >= 0)
					{
						_dgvScore.Rows[iRow].Cells[iCol].Style.BackColor = Color.LightBlue;
						iMancheJ1++;
					}
					else
						_dgvScore.Rows[iRow].Cells[iCol].Style.BackColor = Color.LightCoral;
				}
			}
			
			if(bAbandonFofait[1]) iMancheJ1 = 3;
			
			
			// Mise en couleur du gagnant
			if(iMancheJ1 == 3)
				_dgvScore.Rows[iRow].Cells[2].Style.BackColor = Color.LightBlue;
			else
				_dgvScore.Rows[iRow].Cells[3].Style.BackColor = Color.LightBlue;
			
			return iMancheJ1;
		}

		/* Ajouter un joueur a la position donnée en paramètre
		 * iPos = Position dans le classement ( 1, 2, 3, 4)
		 * i = Numero du joueur dans la poule ( 1, 2, 3, 4 )
		 */
		void AddJoueur( int iPos, int i)
		{
			switch( i )
			{
				case 1:
					_aJoueur[iPos-1] = _joueur1;
					break;
					
				case 2:
					_aJoueur[iPos-1] = _joueur2;
					break;
					
				case 3:
					_aJoueur[iPos-1] = _joueur3;
					break;
					
				case 4:
					_aJoueur[iPos-1] = _joueur4;
					break;
			}
		}

		/* Ajouter un joueur à la première place disponible
		 * i = Numero du joueur dans la poule ( 1, 2, 3, 4 )
		 */
		void AddJoueur( int i )
		{
			
			if(_aJoueur[0] == null)
				AddJoueur( 1, i );
			else if(_aJoueur[1] == null)
				AddJoueur( 2, i );
			else if(_aJoueur[2] == null)
				AddJoueur( 3, i );
			else
				AddJoueur( 4, i );
		}

		/*-----------------------------------------------------------------------------------------------
		 * 			Fonction générique
		 *-----------------------------------------------------------------------------------------------
		 */

		void DumpPointJoueur ( string sTitre,  PointsJoueur[] pj )
		{
			setTextRapport( sTitre, true);
			setTextRapport( "+---+---+");
			
			for(int i = 0; i < pj.GetLength(0); i++)
			{
				setTextRapport( string.Format("| {0} | {1} |", pj[ i ].GetNumJoueur(), pj[ i ].GetPoint() ));
				setTextRapport( "+---+---+");
			}
		}

		void DumpClassement()
		{
			setTextRapport( "Classement", true);
			setTextRapport( "+---+------+----------------------------------------------------+");
			setTextRapport( "|Cls| N°/P |   Nom et Prénom                                    |");
			setTextRapport( "+---+------+----------------------------------------------------+");
			
			for(int i = 0; i < _aJoueur.GetLength(0); i++)
			{
				if( _aJoueur[ i ] != null)
				{
					setTextRapport( string.Format("| {0} |   {1}  | {2} |", i+1, _aJoueur[ i ].NumInPoule, _aJoueur[ i ].Nom.PadRight( 50 ) ));
					setTextRapport( "+---+------+----------------------------------------------------+");
				}
			}
		}

		// Affiche le rapport du traitement
		void setTextRapport( string sText, bool bold = false) { SingletonOutils.setTextRapport( _txtRapport, sText, bold); }
		
		void showEgalite(int i, int j, int k)
		{
			setTextRapport( String.Format("Egalité {0}°, {1}° et {2}°", _aPointJoueur[i].GetNumJoueur(), _aPointJoueur[j].GetNumJoueur(), _aPointJoueur[k].GetNumJoueur() ), true);
		}

	}
}
