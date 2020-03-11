/*
 * Crée par SharpDevelop.
 * Utilisateur: CHAUTARD
 * Date: 03/12/2019
 * Heure: 10:58
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Criterium_16_4
{
	/// <summary>
	/// Description of EditionDesPoules.
	/// </summary>
	public partial class EditionDesPoules : Form
	{
		string _sEpreuve;
		DataGridView _dgvPoule;
		
		public EditionDesPoules(string sEpreuve, DataGridView dgvPoule)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// Add constructor code after the InitializeComponent() call.
			//
			this._sEpreuve = sEpreuve;
			
			this._dgvPoule = dgvPoule;

			// Nom de la compétion
			IniFile iniFile = new IniFile(SingletonOutils.FILEINI);

			foreach(string str in new string[] {iniFile.ReadString("TABLE", "une"), iniFile.ReadString("TABLE", "deux"), iniFile.ReadString("TABLE", "trois"), iniFile.ReadString("TABLE", "quatre") })
			{
				cbPoule1.Items.Add(str);
				cbPoule2.Items.Add(str);
				cbPoule3.Items.Add(str);
				cbPoule4.Items.Add(str);
			};

			cbPoule1.SelectedIndex = 0;
			cbPoule2.SelectedIndex = 1;
			cbPoule3.SelectedIndex = 2;
			cbPoule4.SelectedIndex = 3;
			
			cbHeureDebut.SelectedIndex = 9;
			cbDuree.SelectedIndex = 2;
		}
		
		void BtEditionClick(object sender, EventArgs e)
		{
			// Curseur en sablier
			Cursor.Current = Cursors.WaitCursor;

			// Save the document...
			String filename = String.Format("Poules_{0}.pdf", DateTime.Now.ToString("yyyyMMddHHmm") );

			PoulePdf poulePdf = new PoulePdf( filename);
			
			poulePdf.setDataGridView(_dgvPoule);
			
			poulePdf.setNumTable1(cbPoule1.Text);
			poulePdf.setNumTable2(cbPoule2.Text);
			poulePdf.setNumTable3(cbPoule3.Text);
			poulePdf.setNumTable4(cbPoule4.Text);
			
			poulePdf.setHeureDebut(cbHeureDebut.Text);
			poulePdf.setDuree(cbDuree.Text);
			
			poulePdf.editionPoules( _sEpreuve );

			System.Diagnostics.Process.Start(filename);

			// Retour au curseur standard
			Cursor.Current = Cursors.Default;
		}
		
		void BtCancelClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
