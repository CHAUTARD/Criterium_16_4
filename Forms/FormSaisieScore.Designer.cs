/*
 * Created by SharpDevelop.
 * User: CHAUTARD
 * Date: 11/11/2019
 * Time: 17:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Criterium_16_4
{
	partial class FormSaisieScore
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbPartie;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbJoueur1;
		private System.Windows.Forms.Label lbJoueur2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbForfaitLes2;
		private System.Windows.Forms.RadioButton rbForfaitJoueur2;
		private System.Windows.Forms.RadioButton rbForfaitJoueur1;
		private System.Windows.Forms.RadioButton rbForfaitNeant;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rbAbandonLes2;
		private System.Windows.Forms.RadioButton rbAbandonJoueur2;
		private System.Windows.Forms.RadioButton rbAbandonJoueur1;
		private System.Windows.Forms.RadioButton rbAbandonNeant;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbScore5;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbScore4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbScore3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbScore2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbScore1;
		private System.Windows.Forms.Button btClear;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.Button btValider;
		private System.Windows.Forms.Label label7;
		
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSaisieScore));
            this.lbPartie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbJoueur1 = new System.Windows.Forms.Label();
            this.lbJoueur2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbForfaitLes2 = new System.Windows.Forms.RadioButton();
            this.rbForfaitJoueur2 = new System.Windows.Forms.RadioButton();
            this.rbForfaitJoueur1 = new System.Windows.Forms.RadioButton();
            this.rbForfaitNeant = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbAbandonLes2 = new System.Windows.Forms.RadioButton();
            this.rbAbandonJoueur2 = new System.Windows.Forms.RadioButton();
            this.rbAbandonJoueur1 = new System.Windows.Forms.RadioButton();
            this.rbAbandonNeant = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbScore5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbScore4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbScore3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbScore2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbScore1 = new System.Windows.Forms.TextBox();
            this.btClear = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btValider = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPartie
            // 
            this.lbPartie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPartie.Location = new System.Drawing.Point(12, 9);
            this.lbPartie.Name = "lbPartie";
            this.lbPartie.Size = new System.Drawing.Size(606, 23);
            this.lbPartie.TabIndex = 0;
            this.lbPartie.Text = "Partie : 1 - 4";
            this.lbPartie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contre";
            // 
            // lbJoueur1
            // 
            this.lbJoueur1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJoueur1.Location = new System.Drawing.Point(13, 43);
            this.lbJoueur1.Name = "lbJoueur1";
            this.lbJoueur1.Size = new System.Drawing.Size(259, 23);
            this.lbJoueur1.TabIndex = 2;
            this.lbJoueur1.Text = "Nom joueur 1";
            // 
            // lbJoueur2
            // 
            this.lbJoueur2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJoueur2.Location = new System.Drawing.Point(341, 43);
            this.lbJoueur2.Name = "lbJoueur2";
            this.lbJoueur2.Size = new System.Drawing.Size(278, 23);
            this.lbJoueur2.TabIndex = 3;
            this.lbJoueur2.Text = "Nom joueur 2";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.rbForfaitLes2);
            this.groupBox1.Controls.Add(this.rbForfaitJoueur2);
            this.groupBox1.Controls.Add(this.rbForfaitJoueur1);
            this.groupBox1.Controls.Add(this.rbForfaitNeant);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 49);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forfait";
            // 
            // rbForfaitLes2
            // 
            this.rbForfaitLes2.Location = new System.Drawing.Point(457, 19);
            this.rbForfaitLes2.Name = "rbForfaitLes2";
            this.rbForfaitLes2.Size = new System.Drawing.Size(140, 24);
            this.rbForfaitLes2.TabIndex = 3;
            this.rbForfaitLes2.Text = "les deux";
            this.rbForfaitLes2.UseVisualStyleBackColor = true;
            // 
            // rbForfaitJoueur2
            // 
            this.rbForfaitJoueur2.Location = new System.Drawing.Point(301, 19);
            this.rbForfaitJoueur2.Name = "rbForfaitJoueur2";
            this.rbForfaitJoueur2.Size = new System.Drawing.Size(140, 24);
            this.rbForfaitJoueur2.TabIndex = 2;
            this.rbForfaitJoueur2.Text = "Joueur 2";
            this.rbForfaitJoueur2.UseVisualStyleBackColor = true;
            // 
            // rbForfaitJoueur1
            // 
            this.rbForfaitJoueur1.Location = new System.Drawing.Point(155, 19);
            this.rbForfaitJoueur1.Name = "rbForfaitJoueur1";
            this.rbForfaitJoueur1.Size = new System.Drawing.Size(140, 24);
            this.rbForfaitJoueur1.TabIndex = 1;
            this.rbForfaitJoueur1.Text = "Joueur 1";
            this.rbForfaitJoueur1.UseVisualStyleBackColor = true;
            // 
            // rbForfaitNeant
            // 
            this.rbForfaitNeant.Checked = true;
            this.rbForfaitNeant.Location = new System.Drawing.Point(7, 19);
            this.rbForfaitNeant.Name = "rbForfaitNeant";
            this.rbForfaitNeant.Size = new System.Drawing.Size(140, 24);
            this.rbForfaitNeant.TabIndex = 0;
            this.rbForfaitNeant.TabStop = true;
            this.rbForfaitNeant.Text = "néant";
            this.rbForfaitNeant.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.rbAbandonLes2);
            this.groupBox2.Controls.Add(this.rbAbandonJoueur2);
            this.groupBox2.Controls.Add(this.rbAbandonJoueur1);
            this.groupBox2.Controls.Add(this.rbAbandonNeant);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(606, 49);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Abandon";
            // 
            // rbAbandonLes2
            // 
            this.rbAbandonLes2.Location = new System.Drawing.Point(457, 19);
            this.rbAbandonLes2.Name = "rbAbandonLes2";
            this.rbAbandonLes2.Size = new System.Drawing.Size(140, 24);
            this.rbAbandonLes2.TabIndex = 3;
            this.rbAbandonLes2.Text = "les deux";
            this.rbAbandonLes2.UseVisualStyleBackColor = true;
            // 
            // rbAbandonJoueur2
            // 
            this.rbAbandonJoueur2.Location = new System.Drawing.Point(301, 19);
            this.rbAbandonJoueur2.Name = "rbAbandonJoueur2";
            this.rbAbandonJoueur2.Size = new System.Drawing.Size(140, 24);
            this.rbAbandonJoueur2.TabIndex = 2;
            this.rbAbandonJoueur2.Text = "Joueur 2";
            this.rbAbandonJoueur2.UseVisualStyleBackColor = true;
            // 
            // rbAbandonJoueur1
            // 
            this.rbAbandonJoueur1.Location = new System.Drawing.Point(155, 19);
            this.rbAbandonJoueur1.Name = "rbAbandonJoueur1";
            this.rbAbandonJoueur1.Size = new System.Drawing.Size(140, 24);
            this.rbAbandonJoueur1.TabIndex = 1;
            this.rbAbandonJoueur1.Text = "Joueur 1";
            this.rbAbandonJoueur1.UseVisualStyleBackColor = true;
            // 
            // rbAbandonNeant
            // 
            this.rbAbandonNeant.Checked = true;
            this.rbAbandonNeant.Location = new System.Drawing.Point(7, 19);
            this.rbAbandonNeant.Name = "rbAbandonNeant";
            this.rbAbandonNeant.Size = new System.Drawing.Size(140, 24);
            this.rbAbandonNeant.TabIndex = 0;
            this.rbAbandonNeant.TabStop = true;
            this.rbAbandonNeant.Text = "néant";
            this.rbAbandonNeant.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbScore5);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbScore4);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbScore3);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbScore2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tbScore1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(605, 127);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Saisie des scores";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(15, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(554, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Saisisser un nombre ( 8 où -8 par exemple)  et valider par la touche [Tab]";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(412, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "5";
            // 
            // tbScore5
            // 
            this.tbScore5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbScore5.Location = new System.Drawing.Point(397, 51);
            this.tbScore5.Name = "tbScore5";
            this.tbScore5.Size = new System.Drawing.Size(48, 24);
            this.tbScore5.TabIndex = 4;
            this.tbScore5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbScore5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbScore5KeyPress);
            this.tbScore5.Leave += new System.EventHandler(this.TbScore5Leave);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(349, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "4";
            // 
            // tbScore4
            // 
            this.tbScore4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbScore4.Location = new System.Drawing.Point(331, 51);
            this.tbScore4.Name = "tbScore4";
            this.tbScore4.Size = new System.Drawing.Size(48, 24);
            this.tbScore4.TabIndex = 3;
            this.tbScore4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbScore4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbScore4KeyPress);
            this.tbScore4.Leave += new System.EventHandler(this.TbScore4Leave);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(273, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "3";
            // 
            // tbScore3
            // 
            this.tbScore3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbScore3.Location = new System.Drawing.Point(258, 51);
            this.tbScore3.Name = "tbScore3";
            this.tbScore3.Size = new System.Drawing.Size(48, 24);
            this.tbScore3.TabIndex = 2;
            this.tbScore3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbScore3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbScore3KeyPress);
            this.tbScore3.Leave += new System.EventHandler(this.TbScore3Leave);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(198, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "2";
            // 
            // tbScore2
            // 
            this.tbScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbScore2.Location = new System.Drawing.Point(183, 51);
            this.tbScore2.Name = "tbScore2";
            this.tbScore2.Size = new System.Drawing.Size(48, 24);
            this.tbScore2.TabIndex = 1;
            this.tbScore2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbScore2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbScore2KeyPress);
            this.tbScore2.Leave += new System.EventHandler(this.TbScore2Leave);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(118, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "1";
            // 
            // tbScore1
            // 
            this.tbScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbScore1.Location = new System.Drawing.Point(103, 51);
            this.tbScore1.Name = "tbScore1";
            this.tbScore1.Size = new System.Drawing.Size(48, 24);
            this.tbScore1.TabIndex = 0;
            this.tbScore1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbScore1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbScore1KeyPress);
            this.tbScore1.Leave += new System.EventHandler(this.TbScore1Leave);
            // 
            // btClear
            // 
            this.btClear.CausesValidation = false;
            this.btClear.Image = global::Criterium_16_4.Resource1.gomme;
            this.btClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClear.Location = new System.Drawing.Point(250, 354);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(142, 45);
            this.btClear.TabIndex = 9;
            this.btClear.Text = "Scores";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.BtClearClick);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Image = global::Criterium_16_4.Resource1.abandon;
            this.btCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancel.Location = new System.Drawing.Point(13, 350);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(142, 45);
            this.btCancel.TabIndex = 10;
            this.btCancel.Text = "Abandon";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.BtCancelClick);
            // 
            // btValider
            // 
            this.btValider.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btValider.Image = global::Criterium_16_4.Resource1.validation;
            this.btValider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btValider.Location = new System.Drawing.Point(468, 354);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(142, 45);
            this.btValider.TabIndex = 11;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.BtValiderClick);
            // 
            // FormSaisieScore
            // 
            this.AcceptButton = this.btValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(631, 411);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbJoueur2);
            this.Controls.Add(this.lbJoueur1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPartie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSaisieScore";
            this.Text = "Saisie des scores de la partie";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

		}
	}
}
