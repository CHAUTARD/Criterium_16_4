/*
 * Created by SharpDevelop.
 * User: CHAUTARD
 * Date: 14/11/2019
 * Time: 07:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Criterium_16_4
{
	/// <summary>
	/// Description of PointJoueur.
	/// </summary>
	public class PointsJoueur: IComparable
	{   
		// Numéro du joueur dans la poule
		private int _iNumJoueur = 0; // 0, 1, 2, 3
		private int _iPoint = 0;
		
		public PointsJoueur( int iNumJ)
		{
			_iNumJoueur = iNumJ;
			_iPoint = 0;
		}
		
		public PointsJoueur( int iNumJ, int iPoint)
		{
			_iNumJoueur = iNumJ;
			_iPoint = iPoint;
		}
		
		// Implement IComparable CompareTo to provide default sort order.
      int IComparable.CompareTo(object obj)
      {
        PointsJoueur pj = (PointsJoueur) obj;
                 
		if ( this._iPoint > pj.GetPoint())
			return -1;
		
		if ( this._iPoint < pj.GetPoint())
			return 1;
		
		// Garder le plus possible l'ordre des joueurs
		if( this._iNumJoueur > pj.GetNumJoueur())
			return 1;
				
		if( this._iNumJoueur < pj.GetNumJoueur())
			return -1;
		
		return 0;
      }
		
		public void SetNumJoueur(int n) { this._iNumJoueur = n; }
		public int GetNumJoueur() { return this._iNumJoueur; }
		
		public void SetPoint(int p) { this._iPoint = p; }
		public int GetPoint() { return this._iPoint; }
		
		public int Add(int n) { this._iPoint += n; return this._iPoint; }
    } 
}
