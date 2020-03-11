/*
 * Crée par SharpDevelop.
 * Utilisateur: CHAUTARD
 * Date: 03/12/2019
 * Heure: 10:58
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
namespace Criterium_16_4
{
	partial class EditionDesPoules
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox cbDuree;
		private System.Windows.Forms.ComboBox cbHeureDebut;
		private System.Windows.Forms.Button btEdition;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbPoule1;
		private System.Windows.Forms.Label labelPoule1;
		private System.Windows.Forms.Label labelPoule2;
		private System.Windows.Forms.ComboBox cbPoule2;
		private System.Windows.Forms.Label labelPoule3;
		private System.Windows.Forms.ComboBox cbPoule3;
		private System.Windows.Forms.Label labelPoule4;
		private System.Windows.Forms.ComboBox cbPoule4;
		
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditionDesPoules));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDuree = new System.Windows.Forms.ComboBox();
            this.cbHeureDebut = new System.Windows.Forms.ComboBox();
            this.btEdition = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.cbPoule1 = new System.Windows.Forms.ComboBox();
            this.labelPoule1 = new System.Windows.Forms.Label();
            this.labelPoule2 = new System.Windows.Forms.Label();
            this.cbPoule2 = new System.Windows.Forms.ComboBox();
            this.labelPoule3 = new System.Windows.Forms.Label();
            this.cbPoule3 = new System.Windows.Forms.ComboBox();
            this.labelPoule4 = new System.Windows.Forms.Label();
            this.cbPoule4 = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbDuree);
            this.groupBox2.Controls.Add(this.cbHeureDebut);
            this.groupBox2.Location = new System.Drawing.Point(29, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 52);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Heure de début";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(220, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Durée en minutes";
            // 
            // cbDuree
            // 
            this.cbDuree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDuree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDuree.FormattingEnabled = true;
            this.cbDuree.Items.AddRange(new object[] {
            "20",
            "25",
            "30",
            "35",
            "40"});
            this.cbDuree.Location = new System.Drawing.Point(220, 19);
            this.cbDuree.Name = "cbDuree";
            this.cbDuree.Size = new System.Drawing.Size(115, 24);
            this.cbDuree.TabIndex = 12;
            // 
            // cbHeureDebut
            // 
            this.cbHeureDebut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHeureDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHeureDebut.FormattingEnabled = true;
            this.cbHeureDebut.Items.AddRange(new object[] {
            "08h30",
            "08h40",
            "08h50",
            "09h00",
            "09h10",
            "09h20",
            "09h30",
            "09h40",
            "09h50",
            "10h00",
            "10h10",
            "10h20",
            "10h30",
            "10h40",
            "10h50",
            "11h00",
            "11h10",
            "11h20",
            "11h30",
            "11h40",
            "11h50",
            "12h00",
            "12h10",
            "12h20",
            "12h30",
            "12h40",
            "12h50",
            "13h00",
            "13h10",
            "13h20",
            "13h30",
            "13h40",
            "13h50",
            "14h00",
            "14h10",
            "14h20",
            "14h30",
            "14h40",
            "14h50",
            "15h00",
            "15h10",
            "15h20",
            "15h30",
            "15h40",
            "15h50",
            "16h00",
            "16h10",
            "16h20",
            "16h30",
            "16h40",
            "16h50",
            "17h00",
            "17h10",
            "17h20",
            "17h30",
            "17h40",
            "17h50",
            "18h00"});
            this.cbHeureDebut.Location = new System.Drawing.Point(6, 19);
            this.cbHeureDebut.Name = "cbHeureDebut";
            this.cbHeureDebut.Size = new System.Drawing.Size(115, 24);
            this.cbHeureDebut.TabIndex = 10;
            // 
            // btEdition
            // 
            this.btEdition.Image = global::Criterium_16_4.Resource1.imprimante_16;
            this.btEdition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEdition.Location = new System.Drawing.Point(313, 12);
            this.btEdition.Name = "btEdition";
            this.btEdition.Size = new System.Drawing.Size(127, 43);
            this.btEdition.TabIndex = 13;
            this.btEdition.Text = "Edition";
            this.btEdition.UseVisualStyleBackColor = true;
            this.btEdition.Click += new System.EventHandler(this.BtEditionClick);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Image = global::Criterium_16_4.Resource1.annuler_16;
            this.btCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancel.Location = new System.Drawing.Point(313, 79);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(127, 43);
            this.btCancel.TabIndex = 14;
            this.btCancel.Text = "Abandon";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.BtCancelClick);
            // 
            // cbPoule1
            // 
            this.cbPoule1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPoule1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPoule1.Location = new System.Drawing.Point(152, 20);
            this.cbPoule1.Name = "cbPoule1";
            this.cbPoule1.Size = new System.Drawing.Size(121, 24);
            this.cbPoule1.TabIndex = 2;
            // 
            // labelPoule1
            // 
            this.labelPoule1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoule1.Location = new System.Drawing.Point(13, 21);
            this.labelPoule1.Name = "labelPoule1";
            this.labelPoule1.Size = new System.Drawing.Size(133, 23);
            this.labelPoule1.TabIndex = 1;
            this.labelPoule1.Text = "Poule 1 / Table :";
            this.labelPoule1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPoule2
            // 
            this.labelPoule2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoule2.Location = new System.Drawing.Point(13, 56);
            this.labelPoule2.Name = "labelPoule2";
            this.labelPoule2.Size = new System.Drawing.Size(133, 23);
            this.labelPoule2.TabIndex = 3;
            this.labelPoule2.Text = "Poule 2 / Table :";
            this.labelPoule2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbPoule2
            // 
            this.cbPoule2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPoule2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPoule2.Location = new System.Drawing.Point(152, 55);
            this.cbPoule2.Name = "cbPoule2";
            this.cbPoule2.Size = new System.Drawing.Size(121, 24);
            this.cbPoule2.TabIndex = 4;
            // 
            // labelPoule3
            // 
            this.labelPoule3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoule3.Location = new System.Drawing.Point(12, 89);
            this.labelPoule3.Name = "labelPoule3";
            this.labelPoule3.Size = new System.Drawing.Size(133, 23);
            this.labelPoule3.TabIndex = 5;
            this.labelPoule3.Text = "Poule 3 / Table :";
            this.labelPoule3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbPoule3
            // 
            this.cbPoule3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPoule3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPoule3.Location = new System.Drawing.Point(151, 88);
            this.cbPoule3.Name = "cbPoule3";
            this.cbPoule3.Size = new System.Drawing.Size(121, 24);
            this.cbPoule3.TabIndex = 6;
            // 
            // labelPoule4
            // 
            this.labelPoule4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoule4.Location = new System.Drawing.Point(13, 121);
            this.labelPoule4.Name = "labelPoule4";
            this.labelPoule4.Size = new System.Drawing.Size(133, 23);
            this.labelPoule4.TabIndex = 7;
            this.labelPoule4.Text = "Poule 4 / Table :";
            this.labelPoule4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbPoule4
            // 
            this.cbPoule4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPoule4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPoule4.Location = new System.Drawing.Point(152, 120);
            this.cbPoule4.Name = "cbPoule4";
            this.cbPoule4.Size = new System.Drawing.Size(121, 24);
            this.cbPoule4.TabIndex = 8;
            // 
            // EditionDesPoules
            // 
            this.AcceptButton = this.btEdition;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(460, 217);
            this.Controls.Add(this.labelPoule4);
            this.Controls.Add(this.cbPoule4);
            this.Controls.Add(this.labelPoule3);
            this.Controls.Add(this.cbPoule3);
            this.Controls.Add(this.labelPoule2);
            this.Controls.Add(this.cbPoule2);
            this.Controls.Add(this.labelPoule1);
            this.Controls.Add(this.cbPoule1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btEdition);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditionDesPoules";
            this.ShowInTaskbar = false;
            this.Text = "Edition des poules";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
	}
}
