/*
 * Created by SharpDevelop.
 * User: CHAUTARD
 * Date: 18/11/2019
 * Time: 14:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Criterium_16_4
{
	/// <summary>
	/// Description of PointsPartie.
	/// </summary>
	public class PointsPartie
	{
		DataGridView _dgv = null;
		
		int _iPointA = 0;
		int _iPointB = 0;
		int _iPointC = 0;
		int _iPointD = 0;
		
		public PointsPartie( DataGridView dgv)
		{
			this._dgv = dgv;
		}
		
		public int getPointA() { return _iPointA; }
		public int getPointB() { return _iPointB; }
		public int getPointC() { return _iPointC; }
		public int getPointD() { return _iPointD; }
		
		// remise à zéro des points des quatres joueurs
		public void InitPoints()
		{
			_iPointA = 0;
			_iPointB = 0;
			_iPointC = 0;
			_iPointD = 0;
		}
		
		
		public int Agagne()
		{
			if(_iPointA > _iPointB)
				return 1;
			
			if(_iPointA < _iPointB)
				return -1;
			
			return 0;
		}
		
		/*
		 * Recherche de la ligne correspondante dans la gridview
		 */
		public int [] CalculePoints(int iJ1, int iJ2)
		{
			switch(SingletonOutils.GetJoueursQualifie())
			{
				case 31:
					return  CalculePoints31( iJ1, iJ2);
					
				case 32:
					return  CalculePoints32( iJ1, iJ2);
					
				case 41:
					return  CalculePoints41( iJ1, iJ2);
					
				case 42:
					return  CalculePoints42( iJ1, iJ2);
					
				default:
					throw new System.ArgumentException("Seul les paramètres 31, 32, 41 et 42 sont acceptés !");
			}
		}
		
		// Valable pour 3 joueurs 1 ou 3 Qualifiés
		int [] CalculePoints31(int iJ1, int iJ2)
		{
			int [] iRet = { 0, 0};
			
			switch( iJ1 * 10 + iJ2 ) {
				case 13 : // 1 - 3
				case 31:
					iRet[0] = ScoreValue( 0, 10);
					iRet[1] = ScoreValue( 0, 12);
					break;
					
				case 23: // 2 - 3
				case 32:
					iRet[0] = ScoreValue( 1, 11);
					iRet[1] = ScoreValue( 1, 12);
					break;

				case 12 : // 1 - 2
				case 21:
					iRet[0] = ScoreValue( 2, 10);
					iRet[1] = ScoreValue( 2, 11);
					break;
			}
			return iRet;
		}
		
		// Valable pour 3 joueurs 2 Qualifiés
		int [] CalculePoints32(int iJ1, int iJ2)
		{
			int [] iRet = { 0, 0};
			
			switch( iJ1 * 10 + iJ2 ) {
				case 13 : // 1 - 3
				case 31:
					iRet[0] = ScoreValue( 0, 10);
					iRet[1] = ScoreValue( 0, 12);
					break;
					
				case 12 : // 1 - 2
				case 21:
					iRet[0] = ScoreValue( 1, 10);
					iRet[1] = ScoreValue( 1, 11);
					break;
					
				case 23: // 2 - 3
				case 32:
					iRet[0] = ScoreValue( 2, 11);
					iRet[1] = ScoreValue( 2, 12);
					break;
			}
			return iRet;
		}
		
		// Valable pour 4 joueurs 1 ou 3 Qualifiés
		int [] CalculePoints41(int iJ1, int iJ2)
		{
			int [] iRet = { 0, 0};
			
			switch( iJ1 * 10 + iJ2 ) {
				case 14 : // 1 - 4
				case 41 : // 4 - 1
					iRet[0] = ScoreValue(  0, 10);
					iRet[1] = ScoreValue(  0, 13);
					break;
					
				case 23: // 2 - 3
				case 32: // 3 - 2
					iRet[0] = ScoreValue( 1, 11);
					iRet[1] = ScoreValue( 1, 12);
					break;
					
				case 13 : // 1 - 3
				case 31 : // 3 - 1
					iRet[0] = ScoreValue( 2, 10);
					iRet[1] = ScoreValue( 2, 12);
					break;
					
				case 24 : // 2 - 4
				case 42 : // 4 - 2
					iRet[0] = ScoreValue( 3, 11);
					iRet[1] = ScoreValue( 3, 13);
					break;
					
				case 12 : // 1 - 2
				case 21 : // 2 - 1
					iRet[0] = ScoreValue( 4, 10);
					iRet[1] = ScoreValue( 4, 11);
					break;
					
				case 34: // 3 - 4
				case 43 : // 4 - 3
					iRet[0] = ScoreValue( 5, 12);
					iRet[1] = ScoreValue( 5, 13);
					break;
					
				default:
					throw new System.ArgumentException("Erreur Dans le paramètre de Calculepoints41 !");
			}
			return iRet;
		}
		
		// Valable pour 4 joueurs 2 Qualifiés
		int [] CalculePoints42(int iJ1, int iJ2)
		{
			int [] iRet = { 0, 0};
			
			switch( iJ1 * 10 + iJ2 ) {
				case 13 : // 1 - 3
				case 31: // 3 - 1
					iRet[0] = ScoreValue( 0, 10);
					iRet[1] = ScoreValue( 0, 12);
					break;
					
				case 24 : // 2 - 4
				case 42: // 4 - 2
					iRet[0] = ScoreValue( 1, 11);
					iRet[1] = ScoreValue( 1, 13);
					break;
					
				case 12 : // 1 - 2
				case 21: // 2 - 1
					iRet[0] = ScoreValue( 2, 10);
					iRet[1] = ScoreValue( 2, 11);
					break;;
					
				case 34: // 3 - 4
				case 43: // 4 - 3
					iRet[0] = ScoreValue( 3, 12);
					iRet[1] = ScoreValue( 3, 13);
					break;

				case 14 : // 1 - 4
				case 41: // 4 - 1
					iRet[0] = ScoreValue(  4, 10);
					iRet[1] = ScoreValue(  4, 13);
					break;
					
				case 23: // 2 - 3
				case 32: // 3 - 2
					iRet[0] = ScoreValue( 5, 11);
					iRet[1] = ScoreValue( 5, 12);
					break;
					
				default:
					throw new System.ArgumentException("Erreur dans le paramètre de CalculePoints42 !");
			}
			return iRet;
		}
		
		/* Calcule les points partie entre trois joueurs
		 * iA, iB, iC = ( 1, 2, 3, 4)
		 */
		public int[] CalculePointsPartie3(int iA, int iB, int iC)
		{
			int [] a = { 0, 0};
			int [,] aPartie = { {iA, iB}, {iA, iC}, {iB, iC}};
			
			// Remise à zéro des points pour les joueurs
			InitPoints();
			
			for(int i = 0; i < 3; i++)
			{
				a = CalculePoints( aPartie[i,0], aPartie[i,1]);
				
				CalculePoint2Joueur( aPartie[i,0], a[0] );
				CalculePoint2Joueur( aPartie[i,1], a[1] );
			}
			
			return new int[] { _iPointA, _iPointB, _iPointC, _iPointD };
		}
		
		void CalculePoint2Joueur(int i, int j)
		{
			switch( i )
			{
				case 1:
					_iPointA +=j;
					break;
					
				case 2:
					_iPointB += j;
					break;
					
				case 3:
					_iPointC += j;
					break;
					
				case 4:
					_iPointD += j;
					break;
			}
		}
		
		// 4 joueurs
		public void CalculePointsPartie() {
			int [] a = { 0, 0};
			
			// Remise à zéro des points pour les joueurs
			InitPoints();
			
			foreach(PartieQuiJoue p in SingletonOutils.GetPartie())
			{
				// Tableau avec les numéros des joueurs de la partie	
				a = CalculePoints( p.iJoueur1, p.iJoueur2);
				
				switch( p.iJoueur1 )
				{
					case 1:
						_iPointA += a[0];
						break;
						
					case 2:
						_iPointB += a[0];
						break;
						
					case 3:
						_iPointC += a[0]						;
						break;
						
					case 4:
						_iPointD += a[0];
						break;
				}
				
				switch( p.iJoueur2 )
				{
					case 1:
						_iPointA += a[1];
						break;
						
					case 2:
						_iPointB += a[1];
						break;
						
					case 3:
						_iPointC += a[1]						;
						break;
						
					case 4:
						_iPointD += a[1];
						break;
				}
			}
		}
		
		/* Retourne une chaine en fonction de l'ordre des joueurs
		 * 
		 * 				ABC, ACB, BAC, CBA, BCA, CAB
		 * 				A==, ==A, B==, ==B, C==, ==C => Egalité pour les deux autres
		 * 				=== => Egalité pour les trois
		 */
		
		public string Ordonne3( int iA, int iB, int iC )
		{
			int iPoint1 = 0;
			int iPoint2 = 0;
			int iPoint3 = 0;
			
			iPoint1 = GetPointJoueur( iA );
			iPoint2 = GetPointJoueur( iB );
			iPoint3 = GetPointJoueur( iC );
			
			if( iPoint1 == iPoint2 && iPoint1 == iPoint3 )
				return "===";
			
			if( iPoint1 == iPoint2)
			{
				if(iPoint3 > iPoint2)
					return "==C";
				
				return "C==";
			}
			
			if( iPoint1 > iPoint2)
			{
				if(iPoint2 > iPoint3)
					return "ABC";
				
				return "ACB";
			}
			
			if( iPoint1 == iPoint3)
			{
				if( iPoint2 > iPoint3)
					return "B==";
				
				return "==B";
			}
			
			if( iPoint2 == iPoint3)
			{
				if(iPoint1 > iPoint3)
					return "A==";
				
				return "==A";
			}
			
			if( iPoint1 > iPoint3)
			{
				if( iPoint2 > iPoint3)
					return "BAC";
				
				return "CBA";
			}
			else
			{
				if( iPoint2 > iPoint3)
					return "BCA";
				
				return "CAB";
			}
		}
		
		int GetPointJoueur(int i)
		{
			switch( i )
			{
				case 1:
					return _iPointA;
					
				case 2:
					return _iPointB;
					
				case 3:
					return _iPointC;
					
				case 4:
					return _iPointD;
					
				default:
					throw new System.ArgumentException("Erreur dans le paramètre de GetPointJoueur ( 1 - 4 ) !");
			}
		}
		
		/*
		 * Rercherche des points inscript dan le grid pour la ligne et la colonne donnée
		 * 
		 * Convertion d'un objet de la dataGridView en entier
		 * returne 0, 1 ou 2
		 * 
		 */
		private int ScoreValue( int iRow, int iCol) { return Int16.Parse( _dgv.Rows[iRow].Cells[iCol].Value.ToString() ); }
	}
}
