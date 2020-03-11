/*
 * Crée par SharpDevelop.
 * Utilisateur: CHAUTARD
 * Date: 02/02/2020
 * Heure: 19:02
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Criterium_16_4
{
	/// <summary>
	/// Description of FormTableau.
	/// </summary>
	public partial class FormTableau : Form
	{
		bool[] _bInverse = { false, false, false, false, false, false, false };
		
		public FormTableau( Joueur[] aJoueur1, Joueur[] aJoueur2, Joueur[] aJoueur3, Joueur[] aJoueur4)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			ClubDA clubDA = new ClubDA();
					
			/*
			 * Par défaut :
			 * 
			 * Tableau de 16 joueurs issus de 4 poules de 4 joueurs
			 * avec placxement prédéterminé.
			 * 
			 * +------------+----+----+----+----+
			 * | Classement |  A |  B |  C |  D |
			 * +------------+----+----+----+----+
			 * |     1er    |  1 | 16 |  9 |  8 |
			 * +------------+----+----+----+----+
			 * |     2eme   | 13 |  4 |  5 | 12 |
			 * +------------+----+----+----+----+
			 * |     3eme   | 11 |  6 |  3 | 14 |
			 * +------------+----+----+----+----+
			 * |     4eme   |  7 | 10 | 15 |  2 |
			 * +------------+----+----+----+----+
			 */
			this.dataGridView1.Rows.Add( "1P1", aJoueur1[0].Nom, clubDA.GetNomByNumero(aJoueur1[0].NumeroClub) , "01");
			this.dataGridView1.Rows.Add( "1P2", aJoueur2[0].Nom, clubDA.GetNomByNumero(aJoueur2[0].NumeroClub) , "16");
			this.dataGridView1.Rows.Add( "1P3", aJoueur3[0].Nom, clubDA.GetNomByNumero(aJoueur3[0].NumeroClub) , "09");
			this.dataGridView1.Rows.Add( "1P4", aJoueur4[0].Nom, clubDA.GetNomByNumero(aJoueur4[0].NumeroClub) , "08");
			
			this.dataGridView1.Rows.Add( "2P1", aJoueur1[1].Nom, clubDA.GetNomByNumero(aJoueur1[1].NumeroClub) , "13");
			this.dataGridView1.Rows.Add( "2P2", aJoueur2[1].Nom, clubDA.GetNomByNumero(aJoueur2[1].NumeroClub) , "04");
			this.dataGridView1.Rows.Add( "2P3", aJoueur3[1].Nom, clubDA.GetNomByNumero(aJoueur3[1].NumeroClub) , "05");
			this.dataGridView1.Rows.Add( "2P4", aJoueur4[1].Nom, clubDA.GetNomByNumero(aJoueur4[1].NumeroClub) , "12");
			
			this.dataGridView1.Rows.Add( "3P1", aJoueur1[2].Nom, clubDA.GetNomByNumero(aJoueur1[2].NumeroClub) , "11");
			this.dataGridView1.Rows.Add( "3P2", aJoueur2[2].Nom, clubDA.GetNomByNumero(aJoueur2[2].NumeroClub) , "06");
			this.dataGridView1.Rows.Add( "3P3", aJoueur3[2].Nom, clubDA.GetNomByNumero(aJoueur3[2].NumeroClub) , "03");
			this.dataGridView1.Rows.Add( "3P4", aJoueur4[2].Nom, clubDA.GetNomByNumero(aJoueur4[2].NumeroClub) , "14");
			
			this.dataGridView1.Rows.Add( "4P1", aJoueur1[3].Nom, clubDA.GetNomByNumero(aJoueur1[3].NumeroClub) , "07");
			this.dataGridView1.Rows.Add( "4P2", aJoueur2[3].Nom, clubDA.GetNomByNumero(aJoueur2[3].NumeroClub) , "10");
			this.dataGridView1.Rows.Add( "4P3", aJoueur3[3].Nom, clubDA.GetNomByNumero(aJoueur3[3].NumeroClub) , "15");
			this.dataGridView1.Rows.Add( "4P4", aJoueur4[3].Nom, clubDA.GetNomByNumero(aJoueur4[3].NumeroClub) , "02");
						
			// Mise en couleur des cases
			BackColorCell( 0, 0, Color.LightYellow);
			BackColorCell( 1, 0, Color.LightYellow);
			
			BackColorCell( 2, 0, Color.LightCyan);
			BackColorCell( 3, 0, Color.LightCyan);
			
			BackColorCell( 4, 0, Color.LightGreen);
			BackColorCell( 5, 0, Color.LightGreen);
			BackColorCell( 6, 0, Color.LightGreen);
			BackColorCell( 7, 0, Color.LightGreen);
			
			for(int i=8; i < 16; i++)
				this.dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.LightCoral;
		}
				
		// Met en couleur la cellule concernée
		void BackColorCell(int iRow, int iCol, Color color) { this.dataGridView1.Rows[iRow].Cells[iCol].Style.BackColor = color; }
						
		// Inverse les valeurs de deux cellulles
		void inverseValeur(int iv)
		{			
			string[,] iCase = { {"08","09" },{"02","15" },{"03","14" },{"04","13"},{"05","12" },{"06","11" },{"07","10" } };
					
			_bInverse[iv] = !_bInverse[iv];

			for (int i = 0; i < 16; i++)
			{
				if (string.Compare(dataGridView1.Rows[i].Cells[3].Value.ToString(), iCase[iv, 0]) == 0)
					dataGridView1.Rows[i].Cells[3].Value = iCase[iv, 1];
				else
					if (string.Compare(dataGridView1.Rows[i].Cells[3].Value.ToString(), iCase[iv, 1]) == 0)
						dataGridView1.Rows[i].Cells[3].Value = iCase[iv, 0];
			}

			// @TODO vérifier si des joueurs du même club s'affronte
		}
		
		void ToolStripButton1Click(object sender, EventArgs e)
		{
			// Affichage du tableau
			FormTableauSaisie frmTableauSaisie = new FormTableauSaisie(dataGridView1);
			frmTableauSaisie.ShowDialog();
			
			Close();
	
		}
		
		void ToolStripButtonAbandonClick(object sender, EventArgs e)
		{
			Close();
		}

		private void toolStripButtonInversion_Click(object sender, EventArgs e)
		{
			switch(toolStripComboBoxInversion.SelectedItem)
			{
				case "8 et 9":
					inverseValeur(0);
					break;

				case "2 et 15":
					inverseValeur(1);
					break;

				case "3 et 14":
					inverseValeur(2);
					break;

				case "4 et 13":
					inverseValeur(3);
					break;

				case "5 et 12":
					inverseValeur(4);
					break;

				case "6 et 11":
					inverseValeur(5);
					break;

				case "7 et 10":
					inverseValeur(6);
					break;
			}			
		}
	}
}
