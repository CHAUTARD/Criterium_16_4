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
using System.Linq;
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
		
		public EditionDesPoules(DataGridView dgvPoule)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// Add constructor code after the InitializeComponent() call.
			//
			this._sEpreuve = SingletonOutils.competition.Commentaire ;
			
			this._dgvPoule = dgvPoule;

			// Tables de la compétion
			cbPoule1.Items.Add(SingletonOutils.competition.Table1);
			cbPoule1.Items.Add(SingletonOutils.competition.Table2);
			cbPoule1.Items.Add(SingletonOutils.competition.Table3);
			cbPoule1.Items.Add(SingletonOutils.competition.Table4);

			foreach (Object item in cbPoule1.Items)
			{
				cbPoule2.Items.Add(item);
				cbPoule3.Items.Add(item);
				cbPoule4.Items.Add(item);
			}

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
