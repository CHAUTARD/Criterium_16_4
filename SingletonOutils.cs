/*
 * Crée par SharpDevelop.
 * Utilisateur: CHAUTARD
 * Date: 13/12/2019
 * Heure: 08:01
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
	/// Description of SingletonOutils.
	/// </summary>
	public sealed class SingletonOutils
	{
		static SingletonOutils instance = null;
		static readonly object padlock = new object();

		// Nombre maximum de joueur
		public const int NBRJOUEUR = 16;

		// Cellule DataGridView vide
		public const string CELLVIDE = "--";

		// score non renseigné
		public const int SCORENULL = 9999;

		// Nom du fichier INI
		public const string FILEINI = "config.ini";

		// Liste des joueurs prévus
		public static List<Joueur> ListJoueurs = new List<Joueur>();

		// compétition en cour
		public static Competition competition = new Competition();

		public static readonly List<PartieQuiJoue> _lPartie31 = new List<PartieQuiJoue>()
		{
			new PartieQuiJoue( 1, 3, 2 ),
			new PartieQuiJoue( 2, 3, 1 ),
			new PartieQuiJoue( 1, 2, 3)
		};

		public static readonly List<PartieQuiJoue> _lPartie32 = new List<PartieQuiJoue>()
		{
			new PartieQuiJoue( 1, 3, 2),
			new PartieQuiJoue( 1, 2, 3),
			new PartieQuiJoue( 2, 3, 1)
		};

		public static readonly List<PartieQuiJoue> _lPartie41 = new List<PartieQuiJoue>()
		{
			new PartieQuiJoue( 1, 4, 3),
			new PartieQuiJoue( 2, 3, 4),
			new PartieQuiJoue( 1, 3, 2),
			new PartieQuiJoue( 2, 4, 1),
			new PartieQuiJoue( 1, 2, 4),
			new PartieQuiJoue( 3, 4, 2)
		};

		public static readonly List<PartieQuiJoue> _lPartie42 = new List<PartieQuiJoue>()
		{
			new PartieQuiJoue( 1, 3, 2),
			new PartieQuiJoue( 2, 4, 3),
			new PartieQuiJoue( 1, 2, 4),
			new PartieQuiJoue( 3, 4, 1),
			new PartieQuiJoue( 1, 4, 2),
			new PartieQuiJoue( 2, 3, 4)
		};

		static readonly string[,] _sPointsParties3 = { { "0","--","0"}, {"--","0","0"}, { "0","0","--"} };
		static readonly string[,] _sPointsParties4 = { { "0","--","--","0"}, {"--","0","0","--"}, { "0","--","0","--"}, {"--","0","--","0"}, {"0","0","--","--"}, {"--","--","0","0"} };
		
		// Tous les classement possible des quatres joueurs
		static public readonly int[,] _iPossibleClassement = {
			{1,2,3,4},{1,2,4,3},{1,3,2,4},{1,3,4,2},{1,4,2,3},{1,4,3,2},
			{2,1,3,4},{2,1,4,3},{2,3,1,4},{2,3,4,1},{2,4,1,3},{2,4,3,1},
			{3,1,2,4},{3,1,4,2},{3,2,1,4},{3,2,4,1},{3,4,1,2},{3,4,2,1},
			{4,1,2,3},{4,1,3,2},{4,2,1,3},{4,2,3,1},{4,3,1,2},{4,3,2,1}
		};
		
		// 41 => 4 joueurs, 1 ou 3 qualifiés
		static int _iJoueursQualifie = 41;

		public static SingletonOutils GetInstance()
		{
			if (instance == null)
			{
				lock (padlock)
				{
					if (instance == null)
					{
						instance = new SingletonOutils();
					}
				}
			}
			return instance;
		}
		
		private SingletonOutils() {}

		public static string[,] GetPointsParties3() { return _sPointsParties3; }
		public static string[,] GetPointsParties4() { return _sPointsParties4; }
		
		public static int[,] GetPossibleClassement() { return _iPossibleClassement; }
		public static int GetPossibleClassement(int iSerie, int iRang) { return _iPossibleClassement[ iSerie, iRang]; }
		
		/* Vainqueur sur une partie entre deux joueurs
		 * int a, b : Numero du joueur dans la poule.
		 * 
		 * retour :
		 * 		true  -> a vainqueur
		 * 		false -> b vainqueur
		 */
		public static bool ChercheVainqueur(DataGridView dgv, int a, int b)
		{
			int iRow = 0;
			List<PartieQuiJoue> lPartie;
			
			switch( _iJoueursQualifie )
			{
				case 31:
					lPartie = _lPartie31;
					break;
					
				case 32:
					lPartie = _lPartie32;
					break;
					
				case 42:
					lPartie = _lPartie42;
					break;
					
					// case 41:
				case 41:
					lPartie = _lPartie41;
					break;
					
				default:
					throw new System.ArgumentException("Erreur dans le paramètre de ChercheVainqueur !");
			}

			if(a > b)
			{
				int c = b;
				b = a;
				a = c;
			}

			iRow = 1;
			foreach (PartieQuiJoue p in lPartie)
			{
				if (a == p.iJoueur1 && b == p.iJoueur2)
				{
					return (dgv.Rows[iRow].Cells[2].Style.BackColor != Color.LightBlue);
				}
				iRow++;
			}
			return false;

		}

		public static List<PartieQuiJoue>  GetsPartie31() { return _lPartie31; }

		public static List<PartieQuiJoue> GetPartie()
		{	
			switch(_iJoueursQualifie)
			{
				case 31:
					return _lPartie31;
					
				case 32:
					return _lPartie32;

				case 41:
					return _lPartie41;

				case 42:
					return _lPartie42;
							
				default:
					throw new System.ArgumentException("Seul les paramètres 31, 32, 41 et 42 sont acceptés (GetPartie) !");
			}
		}

		// 1 - 4 => { 1, 4}
		public static PartieQuiJoue GetJoueursPartie(int i) 
		{
			return GetPartie()[i];
		}
		
		public static int GetJoueursQualifie() { return _iJoueursQualifie; }
		
		public static void SetJoueursQualifie(int i)
		{
			switch(i)
			{
				case 31:
				case 32:
				case 41:
				case 42:
					_iJoueursQualifie = i;
					break;
					
				default:
					throw new System.ArgumentException("Seul les paramètres 31, 32, 41 et 42 sont acceptés (SetJoueursQualifie) !");
			}
		}
		
		public static void setTextRapport( RichTextBox txtRapport, string sText, bool bold = false)
		{
			System.Drawing.Font currentFont = txtRapport.SelectionFont;
			
			if(bold)
			{
				txtRapport.AppendText( Environment.NewLine );
				txtRapport.SelectionFont = new Font(
					currentFont.FontFamily,
					14,
					FontStyle.Bold
				);
			}
			
			txtRapport.AppendText( sText + Environment.NewLine );
			
			if(bold)
				txtRapport.SelectionFont = new Font(
					currentFont.FontFamily,
					11,
					FontStyle.Regular
				);
		}

		public static void setTextRapport( RichTextBox txtRapport, string sText, Color color, bool AddNewLine = false)
		{
			if (AddNewLine)
				sText += Environment.NewLine;

			txtRapport.SelectionStart = txtRapport.TextLength;
			txtRapport.SelectionLength = 0;

			txtRapport.SelectionColor = color;
			txtRapport.AppendText(sText);
			txtRapport.SelectionColor = txtRapport.ForeColor;
		}

		public static void TRUNCATE(string sTableName)
		{
			using (var db = new PetaPoco.Database("SqliteConnect"))
			{
				db.Execute( string.Format("DELETE FROM {0};", sTableName));
				db.Execute( string.Format("DELETE FROM sqlite_sequence WHERE name = '{0}'", sTableName));
			}
		}

		public static Joueur GetJoueurByLicence(int iLicence)
		{
			if (iLicence > 0)
			{
				using (var db = new PetaPoco.Database("SqliteConnect"))
				{
					return db.Single<Joueur>(iLicence);
				}
			}
			return null;
		}
	}
}
