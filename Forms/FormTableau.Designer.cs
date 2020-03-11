/*
 * Crée par SharpDevelop.
 * Utilisateur: CHAUTARD
 * Date: 02/02/2020
 * Heure: 19:02
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
namespace Criterium_16_4
{
	partial class FormTableau
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridView1;
		
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTableau));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ordre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tableau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripValider = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBoxInversion = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonInversion = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAbandon = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStripValider.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ordre,
            this.Nom,
            this.Club,
            this.Tableau});
            this.dataGridView1.Location = new System.Drawing.Point(7, 70);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(826, 409);
            this.dataGridView1.TabIndex = 0;
            // 
            // Ordre
            // 
            this.Ordre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ordre.DefaultCellStyle = dataGridViewCellStyle12;
            this.Ordre.Frozen = true;
            this.Ordre.HeaderText = "Ordre";
            this.Ordre.MinimumWidth = 30;
            this.Ordre.Name = "Ordre";
            this.Ordre.ReadOnly = true;
            this.Ordre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Ordre.Width = 80;
            // 
            // Nom
            // 
            this.Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom.DefaultCellStyle = dataGridViewCellStyle13;
            this.Nom.Frozen = true;
            this.Nom.HeaderText = "Nom et Prénom";
            this.Nom.MinimumWidth = 150;
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Width = 300;
            // 
            // Club
            // 
            this.Club.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Club.DefaultCellStyle = dataGridViewCellStyle14;
            this.Club.Frozen = true;
            this.Club.HeaderText = "Club";
            this.Club.MinimumWidth = 150;
            this.Club.Name = "Club";
            this.Club.ReadOnly = true;
            this.Club.Width = 250;
            // 
            // Tableau
            // 
            this.Tableau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tableau.DefaultCellStyle = dataGridViewCellStyle15;
            this.Tableau.Frozen = true;
            this.Tableau.HeaderText = "Tableau";
            this.Tableau.MinimumWidth = 15;
            this.Tableau.Name = "Tableau";
            this.Tableau.ReadOnly = true;
            this.Tableau.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Tableau.Width = 91;
            // 
            // toolStripValider
            // 
            this.toolStripValider.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripComboBoxInversion,
            this.toolStripSeparator2,
            this.toolStripButtonInversion,
            this.toolStripSeparator3,
            this.toolStripButtonAbandon});
            this.toolStripValider.Location = new System.Drawing.Point(0, 0);
            this.toolStripValider.Name = "toolStripValider";
            this.toolStripValider.Size = new System.Drawing.Size(841, 71);
            this.toolStripValider.TabIndex = 1;
            this.toolStripValider.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(68, 68);
            this.toolStripButton1.Text = "Valider";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 71);
            // 
            // toolStripComboBoxInversion
            // 
            this.toolStripComboBoxInversion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxInversion.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripComboBoxInversion.Items.AddRange(new object[] {
            "8 et 9",
            "2 et 15",
            "3 et 14",
            "4 et 13",
            "5 et 12",
            "6 et 11",
            "7 et 10"});
            this.toolStripComboBoxInversion.Name = "toolStripComboBoxInversion";
            this.toolStripComboBoxInversion.Size = new System.Drawing.Size(160, 71);
            this.toolStripComboBoxInversion.ToolTipText = "Tirage au sort";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 71);
            // 
            // toolStripButtonInversion
            // 
            this.toolStripButtonInversion.AutoSize = false;
            this.toolStripButtonInversion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonInversion.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInversion.Image")));
            this.toolStripButtonInversion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonInversion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInversion.Name = "toolStripButtonInversion";
            this.toolStripButtonInversion.Size = new System.Drawing.Size(72, 68);
            this.toolStripButtonInversion.Text = "Inversion";
            this.toolStripButtonInversion.Click += new System.EventHandler(this.toolStripButtonInversion_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 71);
            // 
            // toolStripButtonAbandon
            // 
            this.toolStripButtonAbandon.AutoSize = false;
            this.toolStripButtonAbandon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripButtonAbandon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAbandon.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbandon.Image")));
            this.toolStripButtonAbandon.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonAbandon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbandon.Name = "toolStripButtonAbandon";
            this.toolStripButtonAbandon.Size = new System.Drawing.Size(68, 68);
            this.toolStripButtonAbandon.Text = "Abandon";
            this.toolStripButtonAbandon.ToolTipText = "Abandon";
            this.toolStripButtonAbandon.Click += new System.EventHandler(this.ToolStripButtonAbandonClick);
            // 
            // FormTableau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 491);
            this.Controls.Add(this.toolStripValider);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTableau";
            this.Text = "Placement dans un tableau final de 16 prédéterminé ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStripValider.ResumeLayout(false);
            this.toolStripValider.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        private System.Windows.Forms.ToolStrip toolStripValider;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbandon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ordre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Club;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tableau;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxInversion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonInversion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}
