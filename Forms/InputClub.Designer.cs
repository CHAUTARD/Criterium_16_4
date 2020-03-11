/*
 * Created by SharpDevelop.
 * User: CHAUTARD
 * Date: 28/11/2019
 * Time: 16:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Criterium_16_4
{
	partial class InputClub
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btOk;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.TextBox tbNumClub;
		private System.Windows.Forms.TextBox tbNomClub;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputClub));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btOk = new System.Windows.Forms.Button();
			this.btCancel = new System.Windows.Forms.Button();
			this.tbNumClub = new System.Windows.Forms.TextBox();
			this.tbNomClub = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Criterium_16_4.Resource1.MsgBox_question_png;
			this.pictureBox1.InitialImage = global::Criterium_16_4.Resource1.MsgBox_question_png;
			this.pictureBox1.Location = new System.Drawing.Point(12, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(81, 84);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(88, 186);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(8, 8);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(122, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(478, 28);
			this.label2.TabIndex = 2;
			this.label2.Text = "Ajout d\'un nouveau club";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(122, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(149, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "Numéro de club :";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(122, 119);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(134, 21);
			this.label4.TabIndex = 4;
			this.label4.Text = "Nom du club :";
			// 
			// btOk
			// 
			this.btOk.Enabled = false;
			this.btOk.Image = ((System.Drawing.Image)(resources.GetObject("btOk.Image")));
			this.btOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btOk.Location = new System.Drawing.Point(333, 154);
			this.btOk.Name = "btOk";
			this.btOk.Size = new System.Drawing.Size(112, 63);
			this.btOk.TabIndex = 5;
			this.btOk.Text = "OK";
			this.btOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btOk.UseVisualStyleBackColor = true;
			this.btOk.Click += new System.EventHandler(this.BtOkClick);
			// 
			// btCancel
			// 
			this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btCancel.Image = ((System.Drawing.Image)(resources.GetObject("btCancel.Image")));
			this.btCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btCancel.Location = new System.Drawing.Point(487, 154);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size(112, 63);
			this.btCancel.TabIndex = 6;
			this.btCancel.Text = "Cancel";
			this.btCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btCancel.UseVisualStyleBackColor = true;
			// 
			// tbNumClub
			// 
			this.tbNumClub.Location = new System.Drawing.Point(244, 80);
			this.tbNumClub.Name = "tbNumClub";
			this.tbNumClub.Size = new System.Drawing.Size(144, 20);
			this.tbNumClub.TabIndex = 7;
			this.tbNumClub.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbNumClubKeyPress);
			// 
			// tbNomClub
			// 
			this.tbNomClub.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbNomClub.Location = new System.Drawing.Point(243, 118);
			this.tbNomClub.Name = "tbNomClub";
			this.tbNomClub.Size = new System.Drawing.Size(356, 20);
			this.tbNomClub.TabIndex = 8;
			this.tbNomClub.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbNomClubKeyPress);
			// 
			// InputClub
			// 
			this.AcceptButton = this.btOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btCancel;
			this.ClientSize = new System.Drawing.Size(617, 226);
			this.Controls.Add(this.tbNomClub);
			this.Controls.Add(this.tbNumClub);
			this.Controls.Add(this.btCancel);
			this.Controls.Add(this.btOk);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "InputClub";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Ajout d\'un nouveau club";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
