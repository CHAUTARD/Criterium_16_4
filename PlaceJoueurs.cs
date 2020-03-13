/*
 * Crée par SharpDevelop.
 * Utilisateur: CHAUTARD
 * Date: 01/12/2019
 * Heure: 10:31
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Criterium_16_4
{
	/// <summary>
	/// Description of PlaceJoueurs.
	/// </summary>
	public class PlaceJoueurs
	{
		// Création d'un tableau pour positionnement des joueurs
		private	Joueur[] _arJoueur = new Joueur[ SingletonOutils.NBRJOUEUR ];
		
		// Classe main
		FormJoueur _ParentForm;
		
		// Tableau de joueur
		private List<Joueur> _localJoueurs = new List<Joueur>();
		
		bool _bOrdonnePoule;
		
		// Tous les cass de Ligne 2 pour 4 joueurs
		//----------------------------------------
		private int[,] _iCas2 = new int[,] {
			{ 3, 2, 1, 0 }, // 4 - 3, 5 - 2, 6 - 1, 7 - 0
			{ 3, 2, 0, 1 }, // 4 - 3, 5 - 2, 6 - 0, 7 - 1
			
			{ 3, 1, 2, 0 }, // 4 - 3, 5 - 1, 6 - 2, 7 - 0
			{ 3, 1, 0, 2 }, // 4 - 3, 5 - 1, 6 - 0, 7 - 2
			
			{ 3, 0, 1, 2 }, // 4 - 3, 5 - 0, 6 - 1, 7 - 2
			{ 3, 0, 2, 1 }, // 4 - 3, 5 - 0, 6 - 2, 7 - 1

			{ 2, 3, 1, 0 }, // 4 - 2, 5 - 3, 6 - 1, 7 - 0
			{ 2, 3, 0, 1 }, // 4 - 2, 5 - 3, 6 - 0, 7 - 1

			{ 2, 1, 3, 0 }, // 4 - 2, 5 - 1, 6 - 3, 7 - 0
			{ 2, 1, 0, 3 }, // 4 - 2, 5 - 1, 6 - 0, 7 - 3

			{ 2, 0, 3, 1 }, // 4 - 2, 5 - 0, 6 - 3, 7 - 1
			{ 2, 0, 1, 3 }, // 4 - 2, 5 - 0, 6 - 1, 7 - 3
			
			{ 1, 3, 2, 0 }, // 4 - 1, 5 - 3, 6 - 2, 7 - 0
			{ 1, 3, 0, 2 }, // 4 - 1, 5 - 3, 6 - 0, 7 - 2

			{ 1, 2, 3, 0 }, // 4 - 1, 5 - 2, 6 - 3, 7 - 0
			{ 1, 2, 0, 3 }, // 4 - 1, 5 - 2, 6 - 0, 7 - 3

			{ 1, 0, 3, 2 }, // 4 - 1, 5 - 0, 6 - 3, 7 - 2
			{ 1, 0, 2, 3 }, // 4 - 1, 5 - 0, 6 - 2, 7 - 3

			{ 0, 3, 2, 1 }, // 4 - 0, 5 - 3, 6 - 2, 7 - 1
			{ 0, 3, 1, 2 }, // 4 - 0, 5 - 3, 6 - 1, 7 - 2

			{ 0, 2, 3, 1 }, // 4 - 0, 5 - 2, 6 - 3, 7 - 1
			{ 0, 2, 1, 3 }, // 4 - 0, 5 - 2, 6 - 1, 7 - 3

			{ 0, 1, 3, 2 }, // 4 - 0, 5 - 1, 6 - 3, 7 - 2
			{ 0, 1, 2, 3 }  // 4 - 0, 5 - 1, 6 - 2, 7 - 3
		};

		// Ligne 3
		private int[,] _iCas3 = new int[,] {
			{ 4, 5, 6, 7 }, // 11 - 4, 10 - 5, 9 - 6, 8 - 7
			{ 4, 5, 7, 6 }, // 11 - 4, 10 - 5, 9 - 7, 8 - 6

			{ 4, 6, 5, 7 }, // 11 - 4, 10 - 6, 9 - 5, 8 - 7
			{ 4, 6, 7, 5 }, // 11 - 4, 10 - 6, 9 - 7, 8 - 5

			{ 4, 7, 6, 5 }, // 11 - 4, 10 - 7, 9 - 6, 8 - 5
			{ 4, 7, 5, 6 }, // 11 - 4, 10 - 7, 9 - 5, 8 - 6

			{ 5, 4, 6, 7 }, // 11 - 5, 10 - 4, 9 - 6, 8 - 7
			{ 5, 4, 7, 6 }, // 11 - 5, 10 - 4, 9 - 7, 8 - 6

			{ 5, 6, 4, 7 }, // 11 - 5, 10 - 6, 9 - 4, 8 - 7
			{ 5, 6, 7, 4 }, // 11 - 5, 10 - 6, 9 - 7, 8 - 4

			{ 5, 7, 4, 6 }, // 11 - 5, 10 - 7, 9 - 4, 8 - 6
			{ 5, 7, 6, 4 }, // 11 - 5, 10 - 7, 9 - 6, 8 - 4

			{ 6, 4, 5, 7 }, // 11 - 6, 10 - 4, 9 - 5, 8 - 7
			{ 6, 4, 7, 5 }, // 11 - 6, 10 - 4, 9 - 7, 8 - 5

			{ 6, 5, 4, 7 }, // 11 - 6, 10 - 5, 9 - 4, 8 - 7
			{ 6, 5, 7, 4 }, // 11 - 6, 10 - 5, 9 - 7, 8 - 4

			{ 6, 7, 4, 5 }, // 11 - 6, 10 - 7, 9 - 5, 8 - 4
			{ 6, 7, 5, 4 }, // 11 - 6, 10 - 7, 9 - 4, 8 - 5

			{ 7, 4, 5, 6 }, // 11 - 7, 10 - 4, 9 - 5, 8 - 6
			{ 7, 4, 6, 5 }, // 11 - 7, 10 - 4, 9 - 6, 8 - 5

			{ 7, 5, 4, 6 }, // 11 - 7, 10 - 5, 9 - 4, 8 - 6
			{ 7, 5, 6, 4 }, // 11 - 7, 10 - 5, 9 - 6, 8 - 4

			{ 7, 6, 4, 5 }, // 11 - 7, 10 - 6, 9 - 4, 8 - 5
			{ 7, 6, 5, 4 }  // 11 - 7, 10 - 6, 9 - 5, 8 - 4
		};

		// Ligne 4
		private	int[,] _iCas4 = new int[,] {
			{ 11, 10, 9, 8 }, // 12 - 11, 13 - 10, 14 - 9, 15 - 8   ( 0)
			{ 11, 10, 8, 9 }, // 12 - 11, 13 - 10, 14 - 8, 15 - 9

			{ 11, 9, 10, 8 }, // 12 - 11, 13 - 9, 14 - 10, 15 - 8
			{ 11, 9, 8, 10 }, // 12 - 11, 13 - 9, 14 - 8, 15 - 10

			{ 11, 8, 9, 10 }, // 12 - 11, 13 - 8, 14 - 9, 15 - 10
			{ 11, 8, 10, 9 }, // 12 - 11, 13 - 8, 14 - 10, 15 - 9

			{ 10, 11, 9, 8 }, // 12 - 10, 13 - 11, 14 - 9, 15 - 8   ( 6)
			{ 10, 11, 8, 9 }, // 12 - 10, 13 - 11, 14 - 8, 15 - 9

			{ 10, 9, 11, 8 }, // 12 - 10, 13 - 9, 14 - 11, 15 - 8
			{ 10, 9, 8, 11 }, // 12 - 10, 13 - 9, 14 - 8, 15 - 11

			{ 10, 8, 11, 9 }, // 12 - 10, 13 - 8, 14 - 11, 15 - 9
			{ 10, 8, 9, 11 }, // 12 - 10, 13 - 8, 14 - 9, 15 - 11   (11)

			{ 9, 11, 10, 8 }, // 12 - 9, 13 - 11, 14 - 10, 15 - 8   (12)
			{ 9, 11, 8, 10 }, // 12 - 9, 13 - 11, 14 - 8, 15 - 10

			{ 9, 10, 11, 8 }, // 12 - 9, 13 - 10, 14 - 11, 15 - 8
			{ 9, 10, 8, 11 }, // 12 - 9, 13 - 10, 14 - 8, 15 - 11

			{ 9, 8, 11, 10 }, // 12 - 9, 13 - 8, 14 - 11, 15 - 10
			{ 9, 8, 10, 11 }, // 12 - 9, 13 - 8, 14 - 10, 15 - 11

			{ 8, 11, 10, 9 }, // 12 - 8, 13 - 11, 14 - 10, 15 - 9
			{ 8, 11, 9, 10 }, // 12 - 8, 13 - 11, 14 - 9, 15 - 10

			{ 8, 10, 11, 9 }, // 12 - 8, 13 - 10, 14 - 11, 15 - 9
			{ 8, 10, 9, 11 }, // 12 - 8, 13 - 10, 14 - 9, 15 - 11

			{ 8, 9, 11, 10 }, // 12 - 8, 13 - 9, 14 - 11, 15 - 10
			{ 8, 9, 10, 11 }  // 12 - 8, 13 - 9, 14 - 10, 15 - 11
		};
		
		public PlaceJoueurs( FormJoueur formJoueur, bool bOrdonnePoule)
		{
			//* Classe MainForm
			this._ParentForm = formJoueur;
			
			// Copie locale de la liste des présent seulement
			foreach( Joueur j in SingletonOutils.ListJoueurs)
				if ( j.IsPresent )
					_localJoueurs.Add( j );
			
			// Besoin de modifier l'ordre dans les colonnes
			this._bOrdonnePoule = bOrdonnePoule;
			
			// Les 4 premiers ne change pas
			_arJoueur[0] = _localJoueurs[0];
			_arJoueur[1] = _localJoueurs[1];
			_arJoueur[2] = _localJoueurs[2];
			_arJoueur[3] = _localJoueurs[3];
		}
		
		// Placement des joueurs
		public Joueur[] Go()
		{
			if ( PlaceLigne2() )
				if ( PlaceLigne3() )
					PlaceLigne4();
			
			if(this._bOrdonnePoule)
				OrdonnePoule();
			
			return _arJoueur;
		}
		
		/*---------------------------------------------------------------------------------------------------------
		 * 					Ligne 2
		 *---------------------------------------------------------------------------------------------------------
		 */
		// placement des joueurs sur la deuxième ligne
		private bool PlaceLigne2()
		{
			// Recherche du nombre de joueur dans la ligne
			if(_localJoueurs.Count > 7)
			{
				Place24();
				return true;
			}

			if(_localJoueurs.Count > 6)
			{
				Place23();
				return false;
			}
			
			if(_localJoueurs.Count > 5)
			{
				Place22();
				return false;
			}

			if(_localJoueurs.Count > 4)
				_arJoueur[4] = _localJoueurs[4];
			
			return false;
		}
		
		// Placement des 2 joueurs, si 2 joueurs dans la ligne 2
		private void Place22()
		{
			bool boucle = true;
			int t = 0;
			
			while( boucle && t < this._iCas2.Length )
			{
				if (( _localJoueurs[4].Numero != _localJoueurs[ this._iCas2[ t, 0 ] ].Numero ) &&
				    ( _localJoueurs[5].Numero != _localJoueurs[ this._iCas2[ t, 1 ] ].Numero ) )
				{
					
					_arJoueur[ fConv(this._iCas2[t,0]) ] = _localJoueurs[ 4 ];
					_arJoueur[ fConv(this._iCas2[t,1]) ] = _localJoueurs[ 5 ];
					
					boucle = false;
				}
				t++;
			}
			
			// Si impossible, cas par defaut
			if( boucle )
			{
				this._ParentForm.setTextRapport( "Problème pour le placement des 2 joueurs sur la ligne 2.", true);
				
				_arJoueur[4] = _localJoueurs[ 4 ];
				_arJoueur[5] = _localJoueurs[ 5 ];
			}
		}
		
		// Placement des 3 joueurs, si 3 joueurs dans la ligne 2
		private void Place23()
		{
			bool boucle = true;
			int t = 0;
			
			while( boucle && t < this._iCas2.Length )
			{
				if (( _localJoueurs[4].Numero != _localJoueurs[ this._iCas2[ t, 0 ] ].Numero ) &&
				    ( _localJoueurs[5].Numero != _localJoueurs[ this._iCas2[ t, 1 ] ].Numero ) &&
				    ( _localJoueurs[6].Numero != _localJoueurs[ this._iCas2[ t, 2 ] ].Numero ) )
				{
					
					_arJoueur[ fConv(this._iCas2[t,0]) ] = _localJoueurs[ 4 ];
					_arJoueur[ fConv(this._iCas2[t,1]) ] = _localJoueurs[ 5 ];
					_arJoueur[ fConv(this._iCas2[t,2]) ] = _localJoueurs[ 6 ];
					
					boucle = false;
				}
				t++;
			}
			
			// Si impossible, cas par defaut
			if( boucle )
			{
				this._ParentForm.setTextRapport( "Problème pour le placement des 3 joueurs sur la ligne 2.", true);
				_arJoueur[4] = _localJoueurs[ 4 ];
				_arJoueur[5] = _localJoueurs[ 5 ];
				_arJoueur[6] = _localJoueurs[ 6 ];
			}
		}

		// Placement des 4 joueurs, si 4 joueurs dans la ligne 2
		private void Place24()
		{
			bool boucle = true;
			int t = 0;
			
			while( boucle && t < this._iCas2.Length )
			{
				if (( _localJoueurs[4].Numero != _localJoueurs[ this._iCas2[ t, 0 ] ].Numero ) &&
				    ( _localJoueurs[5].Numero != _localJoueurs[ this._iCas2[ t, 1 ] ].Numero ) &&
				    ( _localJoueurs[6].Numero != _localJoueurs[ this._iCas2[ t, 2 ] ].Numero ) &&
				    ( _localJoueurs[7].Numero != _localJoueurs[ this._iCas2[ t, 3 ] ].Numero ) )
				{
					
					_arJoueur[ fConv(this._iCas2[t,0]) ] = _localJoueurs[ 4 ];
					_arJoueur[ fConv(this._iCas2[t,1]) ] = _localJoueurs[ 5 ];
					_arJoueur[ fConv(this._iCas2[t,2]) ] = _localJoueurs[ 6 ];
					_arJoueur[ fConv(this._iCas2[t,3]) ] = _localJoueurs[ 7 ];
					
					boucle = false;
				}
				t++;
			}
			
			// Si impossible, cas par defaut
			if( boucle )
			{
				this._ParentForm.setTextRapport( "Problème pour le placement des 4 joueurs sur la ligne 2.", true);
				
				_arJoueur[4] = _localJoueurs[ 4 ];
				_arJoueur[5] = _localJoueurs[ 5 ];
				_arJoueur[6] = _localJoueurs[ 6 ];
				_arJoueur[7] = _localJoueurs[ 7 ];
			}
		}
		
		/*---------------------------------------------------------------------------------------------------------
		 * 					Ligne 3
		 *---------------------------------------------------------------------------------------------------------
		 */
		private bool PlaceLigne3()
		{
			// Recherche du nombre de joueur dans la ligne
			if(_localJoueurs.Count > 11)
			{
				Place34();
				return true;
			}

			if(_localJoueurs.Count > 10)
			{
				Place33();
				return false;
			}
			
			if(_localJoueurs.Count > 9)
			{
				Place32();
				return false;
			}

			if(_localJoueurs.Count > 8)
				_arJoueur[8] = _localJoueurs[8];
			
			return false;
		}
		
		private void Place32()
		{
			bool boucle = true;
			int t = 0;

			while( boucle && t < 24 )
			{
				if (( _localJoueurs[9].Numero != _arJoueur[ this._iCas2[ t, 2 ] ].Numero ) &&
				    ( _localJoueurs[8].Numero != _arJoueur[ this._iCas2[ t, 3 ] ].Numero ) &&
				    ( _localJoueurs[9].Numero != _arJoueur[ this._iCas3[ t, 2 ] ].Numero ) &&
				    ( _localJoueurs[8].Numero != _arJoueur[ this._iCas3[ t, 3 ] ].Numero ) )
				{
					_arJoueur[fConv(this._iCas3[t,3])] = _localJoueurs[ 8 ];
					_arJoueur[fConv(this._iCas3[t,2])] = _localJoueurs[ 9 ];
					
					boucle = false;
				}
				t++;
			}

			// Si impossible, cas par defaut
			if( boucle )
			{
				this._ParentForm.setTextRapport( "Problème pour le placement des 3 joueurs sur la ligne 3.", true);

				_arJoueur[8] = _localJoueurs[ 8 ];
				_arJoueur[9] = _localJoueurs[ 9 ];
			}
		}
		
		private void Place33()
		{
			bool boucle = true;
			int t = 0;

			while( boucle && t < 24 )
			{
				if (( _localJoueurs[10].Numero != _arJoueur[ this._iCas2[ t, 1 ] ].Numero ) &&
				    ( _localJoueurs[9].Numero != _arJoueur[ this._iCas2[ t, 2 ] ].Numero ) &&
				    ( _localJoueurs[8].Numero != _arJoueur[ this._iCas2[ t, 3 ] ].Numero ) &&
				    ( _localJoueurs[10].Numero != _arJoueur[ this._iCas3[ t, 1 ] ].Numero ) &&
				    ( _localJoueurs[9].Numero != _arJoueur[ this._iCas3[ t, 2 ] ].Numero ) &&
				    ( _localJoueurs[8].Numero != _arJoueur[ this._iCas3[ t, 3 ] ].Numero ) )
				{
					_arJoueur[fConv(this._iCas3[t,3])] = _localJoueurs[ 8 ];
					_arJoueur[fConv(this._iCas3[t,2])] = _localJoueurs[ 9 ];
					_arJoueur[fConv(this._iCas3[t,1])] = _localJoueurs[ 10 ];
					
					boucle = false;
				}
				t++;
			}

			// Si impossible, cas par defaut
			if( boucle ) {
				this._ParentForm.setTextRapport( "Problème pour le placement des 3 joueurs sur la ligne 3.", true);

				_arJoueur[8] = _localJoueurs[ 8 ];
				_arJoueur[9] = _localJoueurs[ 9 ];
				_arJoueur[10] = _localJoueurs[ 10 ];
			}
		}
		
		private void Place34()
		{
			bool boucle = true;
			int t = 0;

			while( boucle && t < 24 )
			{
				if (( _localJoueurs[11].Numero != _arJoueur[ this._iCas2[ t, 0 ] ].Numero ) &&
				    ( _localJoueurs[10].Numero != _arJoueur[ this._iCas2[ t, 1 ] ].Numero ) &&
				    ( _localJoueurs[9].Numero != _arJoueur[ this._iCas2[ t, 2 ] ].Numero ) &&
				    ( _localJoueurs[8].Numero != _arJoueur[ this._iCas2[ t, 3 ] ].Numero ) &&
				    ( _localJoueurs[11].Numero != _arJoueur[ this._iCas3[ t, 0 ] ].Numero ) &&
				    ( _localJoueurs[10].Numero != _arJoueur[ this._iCas3[ t, 1 ] ].Numero ) &&
				    ( _localJoueurs[9].Numero != _arJoueur[ this._iCas3[ t, 2 ] ].Numero ) &&
				    ( _localJoueurs[8].Numero != _arJoueur[ this._iCas3[ t, 3 ] ].Numero ) )
				{
					_arJoueur[fConv(this._iCas3[t,3])] = _localJoueurs[ 8 ];
					_arJoueur[fConv(this._iCas3[t,2])] = _localJoueurs[ 9 ];
					_arJoueur[fConv(this._iCas3[t,1])] = _localJoueurs[ 10 ];
					_arJoueur[fConv(this._iCas3[t,0])] = _localJoueurs[ 11 ];

					boucle = false;
				}
				t++;
			}

			// Si impossible, cas par defaut
			if( boucle )
			{
				this._ParentForm.setTextRapport( "Problème pour le placement des 4 joueurs sur la ligne 3.", true);

				_arJoueur[8] = _localJoueurs[ 8 ];
				_arJoueur[9] = _localJoueurs[ 9 ];
				_arJoueur[10] = _localJoueurs[ 10 ];
				_arJoueur[11] = _localJoueurs[ 11 ];
			}
		}

		/*---------------------------------------------------------------------------------------------------------
		 * 					Ligne 4
		 *---------------------------------------------------------------------------------------------------------
		 */
		private bool PlaceLigne4()
		{
			// Recherche du nombre de joueur dans la ligne
			if(_localJoueurs.Count > 15)
			{
				Place44();
				return true;
			}

			if(_localJoueurs.Count > 14)
			{
				Place43();
				return false;
			}
			
			if(_localJoueurs.Count > 13)
			{
				Place42();
				return false;
			}

			if(_localJoueurs.Count > 12)
				_arJoueur[12] = _localJoueurs[12];
			
			return false;
		}
		
		private void Place42()
		{
			bool boucle = true;
			int t = 0;

			while( boucle && t < 24 )
			{
				if (( _localJoueurs[12].Numero != _arJoueur[ this._iCas2[ t, 0 ] ].Numero ) &&
				    ( _localJoueurs[13].Numero != _arJoueur[ this._iCas2[ t, 1 ] ].Numero ) &&
				    ( _localJoueurs[12].Numero != _arJoueur[ this._iCas3[ t, 0 ] ].Numero ) &&
				    ( _localJoueurs[13].Numero != _arJoueur[ this._iCas3[ t, 1 ] ].Numero ) &&
				    ( _localJoueurs[12].Numero != _arJoueur[ this._iCas4[ t, 0 ] ].Numero ) &&
				    ( _localJoueurs[13].Numero != _arJoueur[ this._iCas4[ t, 1 ] ].Numero ) )
				{
					_arJoueur[fConv(this._iCas4[ t, 0])] = _localJoueurs[ 12 ];
					_arJoueur[fConv(this._iCas4[ t, 1])] = _localJoueurs[ 13 ];

					boucle = false;
				}
				t++;
			}

			// Si impossible, cas par defaut
			if( boucle )
			{
				this._ParentForm.setTextRapport( "Problème pour le placement des 3 joueurs sur la ligne 4.", true);

				_arJoueur[12] = _localJoueurs[ 12 ];
				_arJoueur[13] = _localJoueurs[ 13 ];
			}
		}
		
		private void Place43()
		{
			bool boucle = true;
			int t = 0;

			while( boucle && t < 24 )
			{
				if (( _localJoueurs[12].Numero != _arJoueur[ this._iCas2[ t, 0 ] ].Numero ) &&
				    ( _localJoueurs[13].Numero != _arJoueur[ this._iCas2[ t, 1 ] ].Numero ) &&
				    ( _localJoueurs[14].Numero != _arJoueur[ this._iCas2[ t, 2 ] ].Numero ) &&
				    ( _localJoueurs[12].Numero != _arJoueur[ this._iCas3[ t, 0 ] ].Numero ) &&
				    ( _localJoueurs[13].Numero != _arJoueur[ this._iCas3[ t, 1 ] ].Numero ) &&
				    ( _localJoueurs[14].Numero != _arJoueur[ this._iCas3[ t, 2 ] ].Numero ) &&
				    ( _localJoueurs[12].Numero != _arJoueur[ this._iCas4[ t, 0 ] ].Numero ) &&
				    ( _localJoueurs[13].Numero != _arJoueur[ this._iCas4[ t, 1 ] ].Numero ) &&
				    ( _localJoueurs[14].Numero != _arJoueur[ this._iCas4[ t, 2 ] ].Numero ) )
				{
					_arJoueur[fConv(this._iCas4[ t, 0])] = _localJoueurs[ 12 ];
					_arJoueur[fConv(this._iCas4[ t, 1])] = _localJoueurs[ 13 ];
					_arJoueur[fConv(this._iCas4[ t, 2])] = _localJoueurs[ 14 ];

					boucle = false;
				}
				t++;
			}

			// Si impossible, cas par defaut
			if( boucle )
			{
				this._ParentForm.setTextRapport( "Problème pour le placement des 3 joueurs sur la ligne 4.", true);

				_arJoueur[12] = _localJoueurs[ 12 ];
				_arJoueur[13] = _localJoueurs[ 13 ];
				_arJoueur[14] = _localJoueurs[ 14 ];
			}
		}
		
		private void Place44()
		{
			bool boucle = true;
			int t = 0;

			while( boucle && t < 24 )
			{
				if (( _localJoueurs[12].Numero != _arJoueur[ this._iCas2[ t, 0 ] ].Numero ) &&
				    ( _localJoueurs[13].Numero != _arJoueur[ this._iCas2[ t, 1 ] ].Numero ) &&
				    ( _localJoueurs[14].Numero != _arJoueur[ this._iCas2[ t, 2 ] ].Numero ) &&
				    ( _localJoueurs[15].Numero != _arJoueur[ this._iCas2[ t, 3 ] ].Numero ) &&
				    ( _localJoueurs[12].Numero != _arJoueur[ this._iCas3[ t, 0 ] ].Numero ) &&
				    ( _localJoueurs[13].Numero != _arJoueur[ this._iCas3[ t, 1 ] ].Numero ) &&
				    ( _localJoueurs[14].Numero != _arJoueur[ this._iCas3[ t, 2 ] ].Numero ) &&
				    ( _localJoueurs[15].Numero != _arJoueur[ this._iCas3[ t, 3 ] ].Numero ) &&
				    ( _localJoueurs[12].Numero != _arJoueur[ this._iCas4[ t, 0 ] ].Numero ) &&
				    ( _localJoueurs[13].Numero != _arJoueur[ this._iCas4[ t, 1 ] ].Numero ) &&
				    ( _localJoueurs[14].Numero != _arJoueur[ this._iCas4[ t, 2 ] ].Numero ) &&
				    ( _localJoueurs[15].Numero != _arJoueur[ this._iCas4[ t, 3 ] ].Numero ) )
				{
					_arJoueur[fConv(this._iCas4[ t, 0])] = _localJoueurs[ 12 ];
					_arJoueur[fConv(this._iCas4[ t, 1])] = _localJoueurs[ 13 ];
					_arJoueur[fConv(this._iCas4[ t, 2])] = _localJoueurs[ 14 ];
					_arJoueur[fConv(this._iCas4[ t, 3])] = _localJoueurs[ 15 ];

					boucle = false;
				}
				t++;
			}

			// Si impossible, cas par defaut
			if( boucle )
			{
				this._ParentForm.setTextRapport( "Problème pour le placement des 4 joueurs sur la ligne 4.", true);

				_arJoueur[12] = _localJoueurs[ 12 ];
				_arJoueur[13] = _localJoueurs[ 13 ];
				_arJoueur[14] = _localJoueurs[ 14 ];
				_arJoueur[15] = _localJoueurs[ 15 ];
			}
		}

		// Inversion de 2 valeurs dans le tableau
		void swap(int x, int y)
		{
			// swap index x and y
			Joueur buffer = _arJoueur[x];
			
			_arJoueur[x] = _arJoueur[y];
			_arJoueur[y] = buffer;
		}
		
		void OrdonnePoule()
		{		
			// Si doublon dans les poules
			this._ParentForm.setTextRapport( "Plusieurs joueurs du même club dans les poules.", true);
			
			// Recherche de la ou des poules concernées
			if( this._localJoueurs.Count == 16 )
			{
				/* +----+----+----+----+
				 * |  0 |  1 |  2 |  3 |
				 * +----+----+----+----+
				 * |  7 |  6 |  5 |  4 |
				 * +----+----+----+----+
				 * |  8 |  9 | 10 | 11 |
				 * +----+----+----+----+
				 * | 15 | 14 | 13 | 12 |
				 * +----+----+----+----+
				 */
				
				// Premier et huitiéme joueur même club
				if (( _arJoueur[0].Numero ==  _arJoueur[7].Numero ) &&
				    ( _arJoueur[0].Numero !=  _arJoueur[8].Numero) &&
				    ( _arJoueur[0].Numero !=  _arJoueur[15].Numero) )
				{
					swap( 7, 15);

				}
				//  Premier et neuviéme joueur même club
				else if (( _arJoueur[0].Numero ==  _arJoueur[8].Numero ) &&
				         ( _arJoueur[0].Numero !=  _arJoueur[7].Numero) &&
				         ( _arJoueur[0].Numero !=  _arJoueur[15].Numero) )
				{
					swap( 8, 15);

				}
				// Huitiéme et seiziéme joueurs même club
				else if (( _arJoueur[7].Numero ==  _arJoueur[15].Numero ) &&
				         ( _arJoueur[7].Numero !=  _arJoueur[0].Numero) &&
				         ( _arJoueur[7].Numero !=  _arJoueur[8].Numero) )
				{
					swap( 8, 15);

				}
				else if (( _arJoueur[8].Numero ==  _arJoueur[15].Numero ) &&
				         ( _arJoueur[8].Numero !=  _arJoueur[0].Numero) &&
				         ( _arJoueur[8].Numero !=  _arJoueur[7].Numero) )
				{
					swap( 7, 8);
					swap( 8, 15);
				}
			}
			
			if( this._localJoueurs.Count >= 15 )
			{
				/* +----+----+----+----+
				 * |  0 |  1 |  2 |  3 |
				 * +----+----+----+----+
				 * |  7 |  6 |  5 |  4 |
				 * +----+----+----+----+
				 * |  8 |  9 | 10 | 11 |
				 * +----+----+----+----+
				 * |  x | 14 | 13 | 12 |
				 * +----+----+----+----+
				 */
				if (( _arJoueur[1].Numero ==  _arJoueur[6].Numero ) &&
				    ( _arJoueur[1].Numero !=  _arJoueur[9].Numero) &&
				    ( _arJoueur[1].Numero !=  _arJoueur[14].Numero) )
				{
					swap( 6, 14);
				}
				
				else if (( _arJoueur[1].Numero ==  _arJoueur[9].Numero ) &&
				         ( _arJoueur[1].Numero !=  _arJoueur[6].Numero) &&
				         ( _arJoueur[1].Numero !=  _arJoueur[14].Numero) )
				{
					swap( 9, 14);
				}

				else if (( _arJoueur[6].Numero ==  _arJoueur[14].Numero ) &&
				         ( _arJoueur[6].Numero !=  _arJoueur[1].Numero) &&
				         ( _arJoueur[6].Numero !=  _arJoueur[9].Numero) )
				{
					swap( 9, 14);
				}

				else if (( _arJoueur[9].Numero ==  _arJoueur[14].Numero ) &&
				         ( _arJoueur[9].Numero !=  _arJoueur[1].Numero) &&
				         ( _arJoueur[9].Numero !=  _arJoueur[6].Numero) )
				{
					swap( 6, 9);
					swap( 9, 14);
				}
			}
			
			if( this._localJoueurs.Count >= 14 )
			{
				/* +----+----+----+----+
				 * |  0 |  1 |  2 |  3 |
				 * +----+----+----+----+
				 * |  7 |  6 |  5 |  4 |
				 * +----+----+----+----+
				 * |  8 |  9 | 10 | 11 |
				 * +----+----+----+----+
				 * |  x |  x | 13 | 12 |
				 * +----+----+----+----+
				 */
				if (( _arJoueur[2].Numero ==  _arJoueur[5].Numero ) &&
				    ( _arJoueur[2].Numero !=  _arJoueur[10].Numero) &&
				    ( _arJoueur[2].Numero !=  _arJoueur[13].Numero) )
				{
					swap( 5, 13);
				}
				
				if (( _arJoueur[2].Numero ==  _arJoueur[10].Numero ) &&
				    ( _arJoueur[2].Numero !=  _arJoueur[5].Numero) &&
				    ( _arJoueur[2].Numero !=  _arJoueur[13].Numero) )
				{
					swap( 10,13);
				}

				if (( _arJoueur[5].Numero ==  _arJoueur[13].Numero ) &&
				    ( _arJoueur[5].Numero !=  _arJoueur[2].Numero) &&
				    ( _arJoueur[5].Numero !=  _arJoueur[10].Numero) )
				{
					swap( 10, 13);
				}

				if (( _arJoueur[10].Numero ==  _arJoueur[13].Numero ) &&
				    ( _arJoueur[10].Numero !=  _arJoueur[2].Numero) &&
				    ( _arJoueur[10].Numero !=  _arJoueur[5].Numero) )
				{
					swap( 5, 10 );
					swap( 10, 13 );
				}
			}
			
			if( this._localJoueurs.Count >= 13 )
			{
				/* +----+----+----+----+
				 * |  0 |  1 |  2 |  A |
				 * +----+----+----+----+
				 * |  7 |  6 |  5 |  B |
				 * +----+----+----+----+
				 * |  8 |  9 | 10 |  C |
				 * +----+----+----+----+
				 * |  x |  x |  x |  D |
				 * +----+----+----+----+
				 * 
				 * Ordre des matchs 1 - 4, 2 - 3, 1 - 3, 2 - 4, 1 - 2, 3 - 4
				 * A = D -> rien a faire
				 * B = C -> rien a faire
				 * A = B -> Inverse B et D
				 * A = C -> Inverse C et D
				 * B = D -> Inverse C et D
				 * C = D -> Inverse B et C, C et D
				 * 
				 */
				if (( _arJoueur[3].Numero ==  _arJoueur[4].Numero ) &&
				    ( _arJoueur[3].Numero !=  _arJoueur[11].Numero) &&
				    ( _arJoueur[3].Numero !=  _arJoueur[12].Numero) )
				{
					swap( 4,12);
				}
				
				if (( _arJoueur[3].Numero ==  _arJoueur[11].Numero ) &&
				    ( _arJoueur[3].Numero !=  _arJoueur[4].Numero) &&
				    ( _arJoueur[3].Numero !=  _arJoueur[12].Numero) )
				{
					swap( 11,12);
				}

				if (( _arJoueur[4].Numero ==  _arJoueur[12].Numero ) &&
				    ( _arJoueur[4].Numero !=  _arJoueur[3].Numero) &&
				    ( _arJoueur[4].Numero !=  _arJoueur[11].Numero) )
				{
					swap( 11,12);
				}

				if (( _arJoueur[11].Numero ==  _arJoueur[12].Numero ) &&
				    ( _arJoueur[11].Numero !=  _arJoueur[3].Numero) &&
				    ( _arJoueur[11].Numero !=  _arJoueur[4].Numero) )
				{
					swap( 4, 11);
					swap( 11, 12);
				}
			}
			
			if( this._localJoueurs.Count == 12 )
			{
				/* +----+----+----+----+
				 * |  0 |  1 |  2 |  3 |
				 * +----+----+----+----+
				 * |  7 |  6 |  5 |  4 |
				 * +----+----+----+----+
				 * |  8 |  9 | 10 | 11 |
				 * +----+----+----+----+
				 */
				if (( _arJoueur[3].Numero ==  _arJoueur[11].Numero ) &&
				    ( _arJoueur[3].Numero !=  _arJoueur[4].Numero) )
				{
					swap( 4, 11);
				}
			}
			
			if( this._localJoueurs.Count == 11 || this._localJoueurs.Count == 12 )
			{
				/* +----+----+----+----+
				 * |  0 |  1 |  2 |  3 |
				 * +----+----+----+----+
				 * |  7 |  6 |  5 |  4 |
				 * +----+----+----+----+
				 * |  8 |  9 | 10 |  x |
				 * +----+----+----+----+
				 */
				if (( _arJoueur[2].Numero ==  _arJoueur[10].Numero ) &&
				    ( _arJoueur[2].Numero !=  _arJoueur[5].Numero) )
				{
					swap( 5, 10);
				}
			}
			
			if( this._localJoueurs.Count >= 10 && this._localJoueurs.Count <= 12 )
			{
				/* +---+---+---+---+
				 * | 0 | 1 | 2 | 3 |
				 * +---+---+---+---+
				 * | 7 | 6 | 5 | 4 |
				 * +---+---+---+---+
				 * | 8 | 9 | x | x |
				 * +---+---+---+---+
				 */
				if (( _arJoueur[1].Numero ==  _arJoueur[9].Numero ) &&
				    ( _arJoueur[1].Numero !=  _arJoueur[6].Numero) )
				{
					swap( 6,9);
				}
			}
			
			if( this._localJoueurs.Count >= 9 && this._localJoueurs.Count <= 12 )
			{
				/* +---+---+---+---+
				 * | A | 1 | 2 | 3 |
				 * +---+---+---+---+
				 * | B | 6 | 5 | 4 |
				 * +---+---+---+---+
				 * | C | x | x | x |
				 * +---+---+---+---+
				 * 
				 * Ordre des matchs 1 - 3, 2 - 3, 1 - 2
				 * A = C -> rien a faire
				 * B = C -> rien a faire
				 * A = B -> Inverse B et C
				 * 
				 */
				if (( _arJoueur[0].Numero ==  _arJoueur[8].Numero ) &&
				    ( _arJoueur[0].Numero !=  _arJoueur[7].Numero) )
				{
					swap( 7, 8);
				}
			}
		}

		// Ligne 2 et 3
		private int fConv(int x)
		{
			//							0  1  2  3   4   5  6  7   8   9  10  11
			int[] iReturn = new int[] { 7, 6, 5, 4, 11, 10, 9, 8, 15, 14, 13, 12};
			
			if( x <0 || x > 11)
				return -1;
			
			return iReturn[x];
		}
		
	} // Class
} // Namespace