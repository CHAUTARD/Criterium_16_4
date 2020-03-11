namespace Criterium_16_4
{
    partial class FormStatistique
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatistique));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perdu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gagnee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arbitrage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pencours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aencours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actualiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.perdu,
            this.gagnee,
            this.arbitrage,
            this.pencours,
            this.aencours});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(743, 418);
            this.dataGridView1.TabIndex = 0;
            // 
            // Nom
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Nom.DefaultCellStyle = dataGridViewCellStyle1;
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Width = 117;
            // 
            // perdu
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.perdu.DefaultCellStyle = dataGridViewCellStyle2;
            this.perdu.HeaderText = "Partie Perdu";
            this.perdu.Name = "perdu";
            this.perdu.ReadOnly = true;
            this.perdu.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.perdu.Width = 116;
            // 
            // gagnee
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.gagnee.DefaultCellStyle = dataGridViewCellStyle3;
            this.gagnee.HeaderText = "Partie Gagnée";
            this.gagnee.Name = "gagnee";
            this.gagnee.ReadOnly = true;
            this.gagnee.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gagnee.Width = 117;
            // 
            // arbitrage
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.arbitrage.DefaultCellStyle = dataGridViewCellStyle4;
            this.arbitrage.HeaderText = "Nbr Arbitrage";
            this.arbitrage.Name = "arbitrage";
            this.arbitrage.ReadOnly = true;
            this.arbitrage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.arbitrage.Width = 117;
            // 
            // pencours
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.pencours.DefaultCellStyle = dataGridViewCellStyle5;
            this.pencours.HeaderText = "Partie en cours";
            this.pencours.Name = "pencours";
            this.pencours.ReadOnly = true;
            this.pencours.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pencours.Width = 116;
            // 
            // aencours
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.aencours.DefaultCellStyle = dataGridViewCellStyle6;
            this.aencours.HeaderText = " Arbitrage en cours";
            this.aencours.Name = "aencours";
            this.aencours.ReadOnly = true;
            this.aencours.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.aencours.Width = 117;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualiserToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(743, 64);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actualiserToolStripMenuItem
            // 
            this.actualiserToolStripMenuItem.AutoSize = false;
            this.actualiserToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.actualiserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("actualiserToolStripMenuItem.Image")));
            this.actualiserToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.actualiserToolStripMenuItem.Name = "actualiserToolStripMenuItem";
            this.actualiserToolStripMenuItem.Size = new System.Drawing.Size(66, 66);
            this.actualiserToolStripMenuItem.Text = "Actualiser";
            this.actualiserToolStripMenuItem.ToolTipText = "Actualiser";
            this.actualiserToolStripMenuItem.Click += new System.EventHandler(this.actualiserToolStripMenuItem_Click);
            // 
            // FormStatistique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 482);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormStatistique";
            this.Text = "Statistiques";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormStatistique_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn perdu;
        private System.Windows.Forms.DataGridViewTextBoxColumn gagnee;
        private System.Windows.Forms.DataGridViewTextBoxColumn arbitrage;
        private System.Windows.Forms.DataGridViewTextBoxColumn pencours;
        private System.Windows.Forms.DataGridViewTextBoxColumn aencours;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actualiserToolStripMenuItem;
    }
}