/*
 * Created by SharpDevelop.
 * User: CHAUTARD
 * Date: 28/11/2019
 * Time: 16:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Criterium_16_4
{
	/// <summary>
	/// Description of InputClub.
	/// </summary>
	public partial class InputClub : Form
	{
		public InputClub()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
		}
		
		void TbNumClubKeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsControl(e.KeyChar) || !Char.IsNumber(e.KeyChar))
			{
				e.Handled = true; // Set l'evenement comme etant completement fini
				return;
			}
			
			EnableButtonOk();
		}
			
		void TbNomClubKeyPress(object sender, KeyPressEventArgs e) { EnableButtonOk(); }
		
		void EnableButtonOk() { btOk.Enabled = (tbNumClub.Text.Length > 0) & (tbNomClub.Text.Length  > 0); }

		public string getTbNomClub() { return tbNomClub.Text; }
		public string getTbnumClub() { return tbNumClub.Text; }
		
		void BtOkClick(object sender, EventArgs e)
		{
		    this.DialogResult = DialogResult.OK;
		    this.Close();
		}
	}
}
