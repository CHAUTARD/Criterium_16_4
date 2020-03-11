/*
 * Created by SharpDevelop.
 * User: CHAUTARD
 * Date: 11/11/2019
 * Time: 17:00
 */
using System;
using System.Windows.Forms;

namespace Criterium_16_4
{
	/// <summary>
	/// Description of FormSaisieScore.
	/// </summary>
	public partial class FormSaisieScore : Form
	{
		public Partie partie { get; set; }

		public FormSaisieScore()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			//
			// Add constructor code after the InitializeComponent() call.
			//
			partie = new Partie();
		}

		public void SetPartie(string str) { lbPartie.Text = str; }
		public void SetJoueur1(string str) { lbJoueur1.Text = str; }
		public void SetJoueur2(string str) { lbJoueur2.Text = str; }

		public void SetForfaitNeant(bool b = true) { rbForfaitNeant.Checked = b; }
		public void SetForfaitJoueur1(bool b = true) { rbForfaitJoueur1.Checked = b; }
		public void SetForfaitJoueur2(bool b = true) {
			if (rbForfaitJoueur1.Checked && b)
				rbForfaitLes2.Checked = b;
			else
				rbForfaitJoueur2.Checked = b;
		}

		public void SetAbandonNeant(bool b = true) { rbAbandonNeant.Checked = b; }

		public void SetAbandonJoueur1(bool b = true) { rbAbandonJoueur1.Checked = b; }

		public void SetAbandonJoueur2(bool b = true) {
			if (rbAbandonJoueur1.Checked && b)
				rbAbandonLes2.Checked = b;
			else
				rbAbandonJoueur2.Checked = b;
		}

		public void SetScore1(string str)
		{
			if (str.CompareTo("/") == 0) str = "";
			tbScore1.Text = str;
		}
		public void SetScore2(string str)
		{
			if (str.CompareTo("/") == 0) str = "";
			tbScore2.Text = str;
		}
		public void SetScore3(string str)
		{
			if (str.CompareTo("/") == 0) str = "";
			tbScore3.Text = str;
		}
		public void SetScore4(string str)
		{
			if (str.CompareTo("/") == 0) str = "";
			tbScore4.Text = str;
		}
		public void SetScore5(string str)
		{
			if (str.CompareTo("/") == 0) str = "";
			tbScore5.Text = str;
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

			if (tbScore1.Text.Length > 0 && Int32.Parse(tbScore1.Text) < 0) iN++;
			if (tbScore2.Text.Length > 0 && Int32.Parse(tbScore2.Text) < 0) iN++;
			try
			{
				if (tbScore3.Text.Length > 0 && Int32.Parse(tbScore3.Text) < 0) iN++;
				if (tbScore4.Text.Length > 0 && Int32.Parse(tbScore4.Text) < 0) iN++;
				if (tbScore5.Text.Length > 0 && Int32.Parse(tbScore5.Text) < 0) iN++;
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
			if (str.Length == 0)
				return "00";

			return String.Format("{0:00}", Int32.Parse(str));
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
			tbScore1.Text = "";
			tbScore2.Text = "";
			tbScore3.Text = "";
			tbScore4.Text = "";
			tbScore5.Text = "";
		}

		void BtValiderClick(object sender, EventArgs e) {
			CompleteScore();
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
