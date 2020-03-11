/*
 * Crée par SharpDevelop.
 * Utilisateur: CHAUTARD
 * Date: 30/11/2019
 * Heure: 08:28
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Criterium_16_4
{
	/// <summary>
	/// Description of AboutForm.
	/// </summary>
	public partial class AboutForm : Form
	{
		public AboutForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// Add constructor code after the InitializeComponent() call.
			//
			label1.BackColor = Color.FromArgb(0, Color.White);
			label2.BackColor = Color.FromArgb(0, Color.White);
			label3.BackColor = Color.FromArgb(0, Color.White);
		}
		
		void BtCloseClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			try
			{
				//Call the Process.Start method to open the default browser
				//with a URL:
				System.Diagnostics.Process.Start("https://gestioncriterium16j.blogspot.com");
			}

			catch
			{
				MessageBox.Show("Impossible de trouver le site demandé.");
			}
		}
	}
}