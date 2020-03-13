/*
 * User: CHAUTARD
 * Date: 11/11/2019
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Criterium_16_4
{
	/// <summary>
	/// Description of FormSaisieScore.
	/// </summary>
	public partial class FormSaisieScore : Form
	{
		Partie _partie = new Partie();

		public FormSaisieScore(Partie partie)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			//
			// Add constructor code after the InitializeComponent() call.
			//
			_partie = partie;

			lbPartie.Text = partie.sPartie;

			// Affichage des joueurs et de l'arbitre
			SingletonOutils.setTextRapport(lbJoueurs, partie.GetJoueur1().Nom, Color.Blue);
			SingletonOutils.setTextRapport(lbJoueurs, " contre ", Color.Black);
			SingletonOutils.setTextRapport(lbJoueurs, partie.GetJoueur2().Nom, Color.Blue);

			// Centrer le texte
			lbJoueurs.SelectAll();
			lbJoueurs.SelectionAlignment = HorizontalAlignment.Center;

			rbForfaitNeant.Checked = true;

			if (partie.Forfait1 && partie.Forfait2)
				rbForfaitLes2.Checked = true;
			else
			{
				if (partie.Forfait1)
					rbForfaitJoueur1.Checked = true;

				if (partie.Forfait2)
					rbForfaitJoueur2.Checked = true;
			}

			rbAbandonNeant.Checked = true;
			if (partie.Abandon1 && partie.Abandon2)
				rbAbandonLes2.Checked = true;
			else
			{
				if (partie.Abandon1)
					rbAbandonJoueur1.Checked = true;

				if (partie.Forfait2)
					rbAbandonJoueur2.Checked = true;
			}

			// Initialisation des scores
			ClearScore();
		}

		void TbScore1KeyPress(object sender, KeyPressEventArgs e) { e.Handled = GoodChar(tbScore1.Text, e); }
		void TbScore2KeyPress(object sender, KeyPressEventArgs e) { e.Handled = GoodChar(tbScore2.Text, e); }
		void TbScore3KeyPress(object sender, KeyPressEventArgs e) { e.Handled = GoodChar(tbScore3.Text, e); }
		void TbScore4KeyPress(object sender, KeyPressEventArgs e) { e.Handled = GoodChar(tbScore4.Text, e); }
		void TbScore5KeyPress(object sender, KeyPressEventArgs e) { e.Handled = GoodChar(tbScore5.Text, e); }

		void TbScore1Leave(object sender, EventArgs e) {
			tbScore1.Text = FormatScore(tbScore1.Text);

			tbScore2.Enabled = true;
			tbScore2.Focus();
		}

		void TbScore2Leave(object sender, EventArgs e) {
			tbScore2.Text = FormatScore(tbScore2.Text);

			tbScore3.Enabled = true;
			tbScore3.Focus();
		}

		void TbScore3Leave(object sender, EventArgs e) {
			tbScore3.Text = FormatScore(tbScore3.Text);

			// Si les trois sont positif alors fin de saisie
			switch (GetMancheNegative())
			{
				case 0:
				case 3:
					CompleteScore();

					DialogResult = DialogResult.OK;
					Close();

					break;

				default:
					tbScore4.Enabled = true;
					tbScore4.Focus();
					break;
			}
		}

		void TbScore4Leave(object sender, EventArgs e) {
			tbScore4.Text = FormatScore(tbScore4.Text);

			switch (GetMancheNegative())
			{
				case 0:
				case 1:
				case 3:
					CompleteScore();

					DialogResult = DialogResult.OK;
					Close();

					break;

				default:
					tbScore4.Enabled = true;
					tbScore4.Focus();
					break;
			}
		}

		void TbScore5Leave(object sender, EventArgs e) {
			tbScore5.Text = FormatScore(tbScore5.Text);

			CompleteScore();

			DialogResult = DialogResult.OK;

			Close();
		}

		// Compte le nombre de manche négative, perdu
		public int GetMancheNegative()
		{
			// Nombre de valeur négative
			int iN = 0;

			if (tbScore1.Text.Length > 0 && int.Parse(tbScore1.Text) < 0) iN++;
			if (tbScore2.Text.Length > 0 && int.Parse(tbScore2.Text) < 0) iN++;
			try
			{
				if (tbScore3.Text.Length > 0 && int.Parse(tbScore3.Text) < 0) iN++;
				if (tbScore4.Text.Length > 0 && int.Parse(tbScore4.Text) < 0) iN++;
				if (tbScore5.Text.Length > 0 && int.Parse(tbScore5.Text) < 0) iN++;
			}
			catch
			{ }

			return iN;
		}

		/* Le moins en première position
		 * 
		 * retourne false si le caractère est authorisé.
		 */
		bool GoodChar(string str, KeyPressEventArgs e) {
			if (str.Length == 0 && e.KeyChar == '-')
				return false;

			return !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		// Mise en forme du résultat sur deux caractères
		string FormatScore(string str) {
			int s;

			if (str.Length == 0)
				return "00";

			// Un score supérieur à 31 est trés rare !
			s = int.Parse(str);
			if (s > 31 || s < -31)
				MessageBox.Show("Le score me semble élevé !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning );

			return String.Format("{0:00}", s);
		}

		void CompleteScore()
		{
			// Compléter le score si Forfait ou Abandon
			if (rbForfaitJoueur1.Checked || rbAbandonJoueur1.Checked)
			{
				switch (GetMancheNegative())
				{
					case 0:
						if (tbScore1.Text.Length == 0) tbScore1.Text = "-0";
						if (tbScore2.Text.Length == 0) tbScore2.Text = "-0";
						if (tbScore3.Text.Length == 0) tbScore3.Text = "-0";
						break;

					case 1:
						if (tbScore1.Text.Length == 0) tbScore1.Text = "-0";
						if (tbScore2.Text.Length == 0) tbScore2.Text = "-0";
						if (tbScore3.Text.Length == 0) tbScore3.Text = "-0";
						if (tbScore4.Text.Length == 0) tbScore4.Text = "-0";
						break;

					case 2:
						if (tbScore1.Text.Length == 0) tbScore1.Text = "-0";
						if (tbScore2.Text.Length == 0) tbScore2.Text = "-0";
						if (tbScore3.Text.Length == 0) tbScore3.Text = "-0";
						if (tbScore4.Text.Length == 0) tbScore4.Text = "-0";
						if (tbScore5.Text.Length == 0) tbScore5.Text = "-0";
						break;
				}
			}

			if (rbForfaitJoueur2.Checked || rbAbandonJoueur2.Checked)
			{
				switch (GetMancheNegative())
				{
					case 0:
						if (tbScore1.Text.Length == 0) tbScore1.Text = "00";
						if (tbScore2.Text.Length == 0) tbScore2.Text = "00";
						if (tbScore3.Text.Length == 0) tbScore3.Text = "00";
						break;

					case 1:
						if (tbScore1.Text.Length == 0) tbScore1.Text = "00";
						if (tbScore2.Text.Length == 0) tbScore2.Text = "00";
						if (tbScore3.Text.Length == 0) tbScore3.Text = "00";
						if (tbScore4.Text.Length == 0) tbScore4.Text = "00";
						break;

					case 2:
						if (tbScore1.Text.Length == 0) tbScore1.Text = "00";
						if (tbScore2.Text.Length == 0) tbScore2.Text = "00";
						if (tbScore3.Text.Length == 0) tbScore3.Text = "00";
						if (tbScore4.Text.Length == 0) tbScore4.Text = "00";
						if (tbScore5.Text.Length == 0) tbScore5.Text = "00";
						break;
				}
			}
		}

		void BtClearClick(object sender, EventArgs e)
		{
			ClearScore();
		}

		// Initialisation des scores
		void ClearScore()
		{
			tbScore1.Text = _partie.Score1 == SingletonOutils.SCORENULL ? "" : string.Format("{0:00;-00", _partie.Score1);
			tbScore2.Text = _partie.Score2 == SingletonOutils.SCORENULL ? "" : string.Format("{0:00;-00", _partie.Score2);
			tbScore3.Text = _partie.Score3 == SingletonOutils.SCORENULL ? "" : string.Format("{0:00;-00", _partie.Score3);
			tbScore4.Text = _partie.Score4 == SingletonOutils.SCORENULL ? "" : string.Format("{0:00;-00", _partie.Score4);
			tbScore5.Text = _partie.Score5 == SingletonOutils.SCORENULL ? "" : string.Format("{0:00;-00", _partie.Score5);

			tbScore2.Enabled = false;
			tbScore3.Enabled = false;
			tbScore4.Enabled = false;
			tbScore5.Enabled = false;
		}

		void BtValiderClick(object sender, EventArgs e) {

			CompleteScore();

			// Remplir les colonnes dans joueur pour la partie
			// Modification de la table arbitrage
			using (var db = new PetaPoco.Database("SqliteConnect"))
			{
				db.BeginTransaction();

				db.Execute("UPDATE Joueurs SET EnCour = 0 WHERE Licence = @0", _partie.GetJoueur1().Licence);
				db.Execute("UPDATE Joueurs SET EnCour = 0 WHERE Licence = @0", _partie.GetJoueur2().Licence);
				db.Execute("UPDATE Joueurs SET EnArbitrage = 0 WHERE Licence = @0", _partie.GetJoueurArbitre().Licence);

				db.CompleteTransaction();
			}
			Close();
		}

		void BtCancelClick(object sender, EventArgs e) { Close(); }

		public string GetScore1() { return tbScore1.Text; }
		public string GetScore2() { return tbScore2.Text; }
		public string GetScore3() { return tbScore3.Text; }
		public string GetScore4() { return tbScore4.Text; }
		public string GetScore5() { return tbScore5.Text; }

		public bool GetForfait() { return rbForfaitLes2.Checked; }
		public bool GetForfait1() { return rbForfaitJoueur1.Checked; }
		public bool GetForfait2() { return rbForfaitJoueur2.Checked; }

		public bool GetAbandon() { return rbAbandonLes2.Checked; }
		public bool GetAbandon1() { return rbAbandonJoueur1.Checked; }
		public bool GetAbandon2() { return rbAbandonJoueur2.Checked; }
	}
}