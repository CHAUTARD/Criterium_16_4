/*
 * Created by SharpDevelop.
 * User: CHAUTARD
 * Date: 18/11/2019
 * Time: 08:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Criterium_16_4
{
	/// <summary>
	/// Description of Manche.
	/// </summary>
	public class Manche
	{
		DataGridView _dgv;
		RichTextBox _txtRapport;
		
		private int _iMancheGagneA = 0;
		private int _iManchePerduA = 0;
		private int _iMancheGagneB = 0;
		private int _iManchePerduB = 0;
		private int _iMancheGagneC = 0;
		private int _iManchePerduC = 0;
		private int _iMancheGagneD = 0;
		private int _iManchePerduD = 0;
		
		public Manche( DataGridView dgv, RichTextBox txtRapport)
		{
			_dgv = dgv;
			_txtRapport = txtRapport;
		}
		
		public int getMancheGagneA() { return _iMancheGagneA; }
		public int getMancheGagneB() { return _iMancheGagneB; }
		public int getMancheGagneC() { return _iMancheGagneC; }
		public int getMancheGagneD() { return _iMancheGagneD; }
		
		public int getManchePerduA() { return _iManchePerduA; }
		public int getManchePerduB() { return _iManchePerduB; }
		public int getManchePerduC() { return _iManchePerduC; }
		public int getManchePerduD() { return _iManchePerduD; }
		
		/*
		 * Calcul le quotient victoire sur défaite pour quatres joueurs
		 */
		public void CalculeManche4(int iJ1, int iJ2, int iJ3, int iJ4)
		{
			Clear();
			
			CalculeManche( iJ1, iJ4);
			CalculeManche( iJ2, iJ3);
			CalculeManche( iJ1, iJ3);
			CalculeManche( iJ2, iJ4);
			CalculeManche( iJ1, iJ2);
			CalculeManche( iJ3, iJ4);
		}	

		string GetLettre( int a, int b, int c, int d) { return string.Format("{0}{1}{2}{3}", 65+a, 65+b, 65+c, 65+d); }
		
		/* 
		 * Calcul le quotient victoire sur défaite pour trois joueurs
		 */
		public void CalculeManche3(int iJ1, int iJ2, int iJ3)
		{
			Clear();
			
			CalculeManche( iJ1, iJ2);
			CalculeManche( iJ2, iJ3);
			CalculeManche( iJ1, iJ3);
		}
		
		/*
		 * Quotient entre trois joueurs
		 */
		public string Quotient3(int iA, int iB, int iC)
		{
			float f1 = 0;
			float f2 = 0;
			float f3 = 0;
			
			switch( iA )
			{
				case 1:
					f1 = (float) ( _iMancheGagneA ) / (float) ( _iManchePerduA );
					break;
					
				case 2:
					f1 = (float) ( _iMancheGagneB ) / (float) ( _iManchePerduB );
					break;
					
				case 3:
					f1 =  (float) ( _iMancheGagneC ) / (float) ( _iManchePerduC );
					break;
					
				case 4:
					f1 =  (float) ( _iMancheGagneD ) / (float) ( _iManchePerduD );
					break;
			}
			
			switch( iB )
			{
				case 1:
					f2 = (float) ( _iMancheGagneA ) / (float) ( _iManchePerduA );
					break;
					
				case 2:
					f2 = (float) ( _iMancheGagneB ) / (float) ( _iManchePerduB );
					break;
					
				case 3:
					f2 =  (float) ( _iMancheGagneC ) / (float) ( _iManchePerduC );
					break;
					
				case 4:
					f2 =  (float) ( _iMancheGagneD ) / (float) ( _iManchePerduD );
					break;
			}
						
			switch( iC )
			{
				case 1:
					f3 = (float) ( _iMancheGagneA ) / (float) ( _iManchePerduA );
					break;
					
				case 2:
					f3 = (float) ( _iMancheGagneB ) / (float) ( _iManchePerduB );
					break;
					
				case 3:
					f3 =  (float) ( _iMancheGagneC ) / (float) ( _iManchePerduC );
					break;
					
				case 4:
					f3 =  (float) ( _iMancheGagneD ) / (float) ( _iManchePerduD );
					break;
			}
												
			if( f1 == f2 && f1 == f3 )
				return "===";
			
			if( f1 == f2)
			{
				if(f3 > f2)
					return "==C";
				
				return "C==";
			}
			
			if( f1 > f2)
			{
				if(f2 > f3)
					return "ABC";
				
				return "ACB";
			}
			
			if( f1 == f3)
			{
				if( f2 > f3)
					return "B==";
				
				return "==B";
			}
			
			if( f2 == f3)
			{
				if(f1 > f3)
					return "A==";
				
				return "==A";
			}
			
			if( f1 > f3)
			{
				if( f2 > f3)
					return "BAC";
				
				return "CBA";
			}
			else
			{
				if( f2 > f3)
					return "BCA";
				
				return "CAB";
			}
		}
		
		public void CalculeManche(int iJ1, int iJ2)
		{
			switch(SingletonOutils.GetJoueursQualifie())
			{
				case 31:
					CalculeManche31( iJ1, iJ2);
					break;
					
				case 32:
					CalculeManche32( iJ1, iJ2);
					break;
					
				case 41:
					CalculeManche41( iJ1, iJ2);
					break;
					
				case 42:
					CalculeManche42( iJ1, iJ2);
					break;
					
				default:
					throw new System.ArgumentException("Seul les paramètres 31, 32, 41 et 42 sont acceptés !");
			}
		}
		
		/* Calcul le quotient victoire sur défaite pour deux joueurs dans une poule de trois joueurs, 1 ou 3 qualifiés
		 * 
		 * 	iJ1 < iJ2 ou iJ2 > iJ1
		 */
		public void CalculeManche31(int iJ1, int iJ2)
		{
			int [] aiRet = new int[] { 0, 0};
			
			switch( iJ1 * 10 + iJ2 ) {
				case 13 : // 1 - 3
					aiRet = ScoreManche( 0 );
					_iMancheGagneA += aiRet[0];
					_iManchePerduA += aiRet[1];
					
					_iMancheGagneC += aiRet[1];
					_iManchePerduC += aiRet[0];
					break;
					
				case 23: // 2 - 3
					aiRet = ScoreManche( 1 );
					_iMancheGagneB += aiRet[0];
					_iManchePerduB += aiRet[1];
					
					_iMancheGagneC += aiRet[1];
					_iManchePerduC += aiRet[0];
					break;
					
				case 12 : // 1 - 2
					aiRet = ScoreManche( 2 );
					_iMancheGagneA += aiRet[0];
					_iManchePerduA += aiRet[1];
					
					_iMancheGagneB += aiRet[1];
					_iManchePerduB += aiRet[0];
					break;
			}
		}
		
		/* Calcul le quotient victoire sur défaite pour deux joueurs dans une poule de trois joueurs, 2 qualifiés
		 * 
		 * 	iJ1 < iJ2 ou iJ2 > iJ1
		 */
		public void CalculeManche32(int iJ1, int iJ2)
		{
			int [] aiRet = new int[] { 0, 0};
			
			switch( iJ1 * 10 + iJ2 ) {
				case 13 : // 1 - 3
					aiRet = ScoreManche( 0 );
					_iMancheGagneA += aiRet[0];
					_iManchePerduA += aiRet[1];
					
					_iMancheGagneC += aiRet[1];
					_iManchePerduC += aiRet[0];
					break;
					
				case 12 : // 1 - 2
					aiRet = ScoreManche( 1 );
					_iMancheGagneA += aiRet[0];
					_iManchePerduA += aiRet[1];
					
					_iMancheGagneB += aiRet[1];
					_iManchePerduB += aiRet[0];
					break;
					
				case 23: // 2 - 3
					aiRet = ScoreManche( 2 );
					_iMancheGagneB += aiRet[0];
					_iManchePerduB += aiRet[1];
					
					_iMancheGagneC += aiRet[1];
					_iManchePerduC += aiRet[0];
					break;
			}
		}
		
		/* Calcul le quotient victoire sur défaite pour deux joueurs dans une poule de 4 joueurs avec 1 ou 3 qualifiés
		 * 
		 * 	iJ1 < iJ2 ou iJ2 > iJ1
		 */
		public void CalculeManche41(int iJ1, int iJ2)
		{
			int [] aiRet = new int[] { 0, 0};
			
			switch( iJ1 * 10 + iJ2 ) {
				case 14 : // 1 - 4
				case 41 :
					aiRet = ScoreManche( 0 );
					_iMancheGagneA += aiRet[0];
					_iManchePerduA += aiRet[1];
					
					_iMancheGagneD += aiRet[1];
					_iManchePerduD += aiRet[0];
					break;
										
				case 23 : // 2 - 3
				case 32 :
					aiRet = ScoreManche( 1 );
					_iMancheGagneB += aiRet[0];
					_iManchePerduB += aiRet[1];
					
					_iMancheGagneC += aiRet[1];
					_iManchePerduC += aiRet[0];
					break;
										
				case 13 : // 1 - 3
				case 31 :
					aiRet = ScoreManche( 2 );
					_iMancheGagneA += aiRet[0];
					_iManchePerduA += aiRet[1];
					
					_iMancheGagneC += aiRet[1];
					_iManchePerduC += aiRet[0];
					break;
										
				case 24 : // 2 - 4
				case 42 :
					aiRet = ScoreManche( 3 );
					_iMancheGagneB += aiRet[0];
					_iManchePerduB += aiRet[1];
					
					_iMancheGagneD += aiRet[1];
					_iManchePerduD += aiRet[0];
					break;
										
				case 12 : // 1 - 2
				case 21 :
					aiRet = ScoreManche( 4 );
					_iMancheGagneA += aiRet[0];
					_iManchePerduA += aiRet[1];
					
					_iMancheGagneB += aiRet[1];
					_iManchePerduB += aiRet[0];
					break;
										
				case 34: // 3 - 4
				case 43 :
					aiRet = ScoreManche( 5 );
					_iMancheGagneC += aiRet[0];
					_iManchePerduC += aiRet[1];
					
					_iMancheGagneD += aiRet[1];
					_iManchePerduD += aiRet[0];
					break;
					
				default:
					throw new System.ArgumentException("Erreur dans le paramètre de CalculeManche41 !");
			}
		}
		
		/* Calcul le quotient victoire sur défaite pour deux joueurs dans une poule de 4 joueurs avec 2 qualifiés
		 * 
		 * 	iJ1 < iJ2 ou iJ2 > iJ1
		 */
		public void CalculeManche42(int iJ1, int iJ2)
		{
			int [] aiRet = new int[] { 0, 0};
			
			switch( iJ1 * 10 + iJ2 ) {
				case 13 : // 1 - 3
					aiRet = ScoreManche( 0 );
					_iMancheGagneA += aiRet[0];
					_iManchePerduA += aiRet[1];
					
					_iMancheGagneC += aiRet[1];
					_iManchePerduC += aiRet[0];
					break;

				case 24 : // 2 - 4
					aiRet = ScoreManche( 1 );
					_iMancheGagneB += aiRet[0];
					_iManchePerduB += aiRet[1];
					
					_iMancheGagneD += aiRet[1];
					_iManchePerduD += aiRet[0];
					break;
					
				case 12 : // 1 - 2
					aiRet = ScoreManche( 2 );
					_iMancheGagneA += aiRet[0];
					_iManchePerduA += aiRet[1];
					
					_iMancheGagneB += aiRet[1];
					_iManchePerduB += aiRet[0];
					break;

				case 34: // 3 - 4
					aiRet = ScoreManche( 3 );
					_iMancheGagneC += aiRet[0];
					_iManchePerduC += aiRet[1];
					
					_iMancheGagneD += aiRet[1];
					_iManchePerduD += aiRet[0];
					break;
					
				case 14 : // 1 - 4
					aiRet = ScoreManche( 4 );
					_iMancheGagneA += aiRet[0];
					_iManchePerduA += aiRet[1];
					
					_iMancheGagneD += aiRet[1];
					_iManchePerduD += aiRet[0];
					break;
					
				case 23: // 2 - 3
					aiRet = ScoreManche( 5 );
					_iMancheGagneB += aiRet[0];
					_iManchePerduB += aiRet[1];
					
					_iMancheGagneC += aiRet[1];
					_iManchePerduC += aiRet[0];
					break;
					
				default:
					throw new System.ArgumentException("Erreur dans le paramètre de Calculemanche42 !");
			}
		}

		/*
		 * Remise à sérode tous les compteurs
		 */
		void Clear()
		{
			_iMancheGagneA = 0;
			_iManchePerduA = 0;
			_iMancheGagneB = 0;
			_iManchePerduB = 0;
			_iMancheGagneC = 0;
			_iManchePerduC = 0;
			_iMancheGagneD = 0;
			_iManchePerduD = 0;
		}
		
		// Recherche du nombre de manche de gagné et perdu
		int[] ScoreManche( int iRow )
		{
			int g = 0, p = 0;
			string s;
			
			for(int iCol = 5; iCol < 10; iCol++)
			{
				s = _dgv.Rows[iRow].Cells[iCol].Value.ToString();
				
				// "/" cellule vide
				if( s.CompareTo("/") != 0)
				{
					if ( Int32.Parse(s) >= 0 )
						g++;
					else
						p++;
				}
			}
			return new int[] { g, p };
		}
		
		// Affiche le rapport du traitement
		void setTextRapport( string sText, bool bold = false) { SingletonOutils.setTextRapport( _txtRapport, sText, bold); }
		
		// Affichage des résultats
		public void Dump()
		{
			setTextRapport( "MANCHES", true);
			setTextRapport( "+---+-----+-----+--------+");
			setTextRapport( "|   |Gagné|Perdu|Quotient|");
			setTextRapport( "+---+-----+-----+--------+");
			setTextRapport( "| A | " + string.Format("{0:000} | {1:000} | {2:n4} |", _iMancheGagneA, _iManchePerduA, (float) ( _iMancheGagneA ) / (float) ( _iManchePerduA )) );
			setTextRapport( "+---+-----+-----+--------+");
			setTextRapport( "| B | " + string.Format("{0:000} | {1:000} | {2:n4} |", _iMancheGagneB, _iManchePerduB, (float) ( _iMancheGagneB ) / (float) ( _iManchePerduB )) );
			setTextRapport( "+---+-----+-----+--------+");
			setTextRapport( "| C | " + string.Format("{0:000} | {1:000} | {2:n4} |", _iMancheGagneC, _iManchePerduC, (float) ( _iMancheGagneC ) / (float) ( _iManchePerduC )) );
			setTextRapport( "+---+-----+-----+--------+");
			setTextRapport( "| D | " + string.Format("{0:000} | {1:000} | {2:n4} |", _iMancheGagneC, _iManchePerduC, (float) ( _iMancheGagneC ) / (float) ( _iManchePerduC )) );
			setTextRapport( "+---+-----+-----+--------+");
		}
	}
}
