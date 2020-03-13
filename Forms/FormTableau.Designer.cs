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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTableau));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ordre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tableau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLicence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripValider = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBoxInversion = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonInversion = new System.Windows.Forms.ToolStripButton();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ordre,
            this.Nom,
            this.Club,
            this.Tableau,
            this.ColLicence});
            this.dataGridView1.Location = new System.Drawing.Point(10, 10);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(769, 381);
            this.dataGridView1.TabIndex = 0;
            // 
            // Ordre
            // 
            this.Ordre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ordre.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Club.DefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tableau.DefaultCellStyle = dataGridViewCellStyle5;
            this.Tableau.Frozen = true;
            this.Tableau.HeaderText = "Tableau";
            this.Tableau.MinimumWidth = 15;
            this.Tableau.Name = "Tableau";
            this.Tableau.ReadOnly = true;
            this.Tableau.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Tableau.Width = 91;
            // 
            // ColLicence
            // 
            this.ColLicence.HeaderText = "Licence";
            this.ColLicence.Name = "ColLicence";
            this.ColLicence.ReadOnly = true;
            this.ColLicence.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColLicence.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColLicence.Visible = false;
            // 
            // toolStripValider
            // 
            this.toolStripValider.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStripValider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripValider.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripComboBoxInversion,
            this.toolStripButtonInversion,
            this.toolStripButtonAbandon});
            this.toolStripValider.Location = new System.Drawing.Point(0, 394);
            this.toolStripValider.Name = "toolStripValider";
            this.toolStripValider.Size = new System.Drawing.Size(791, 71);
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
            this.toolStripComboBoxInversion.Margin = new System.Windows.Forms.Padding(200, 0, 1, 0);
            this.toolStripComboBoxInversion.Name = "toolStripComboBoxInversion";
            this.toolStripComboBoxInversion.Size = new System.Drawing.Size(160, 71);
            this.toolStripComboBoxInversion.ToolTipText = "Tirage au sort";
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
            // toolStripButtonAbandon
            // 
            this.toolStripButtonAbandon.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
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
            this.ClientSize = new System.Drawing.Size(791, 465);
            this.Controls.Add(this.toolStripValider);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.ToolStripButton toolStripButtonAbandon;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxInversion;
        private System.Windows.Forms.ToolStripButton toolStripButtonInversion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ordre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Club;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tableau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLicence;
    }
}
