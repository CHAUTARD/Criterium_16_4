namespace Criterium_16_4
{
    partial class FormTableauSaisie
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvParties = new System.Windows.Forms.DataGridView();
            this.ColBarrage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRencontre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColJoueur1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColJoueur2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColJoueurA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFA2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColScore1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColScore2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColScore3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColScore4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColScore5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLicence1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLicence2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLicenceA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParties
            // 
            this.dgvParties.AllowUserToAddRows = false;
            this.dgvParties.AllowUserToDeleteRows = false;
            this.dgvParties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParties.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColBarrage,
            this.ColRencontre,
            this.ColFA1,
            this.ColJoueur1,
            this.ColJoueur2,
            this.ColJoueurA,
            this.ColFA2,
            this.ColScore1,
            this.ColScore2,
            this.ColScore3,
            this.ColScore4,
            this.ColScore5,
            this.ColLicence1,
            this.ColLicence2,
            this.ColLicenceA});
            this.dgvParties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvParties.Location = new System.Drawing.Point(0, 0);
            this.dgvParties.MultiSelect = false;
            this.dgvParties.Name = "dgvParties";
            this.dgvParties.ReadOnly = true;
            this.dgvParties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParties.Size = new System.Drawing.Size(949, 723);
            this.dgvParties.TabIndex = 0;
            this.dgvParties.SelectionChanged += new System.EventHandler(this.dgvParties_SelectionChanged);
            // 
            // ColBarrage
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColBarrage.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColBarrage.Frozen = true;
            this.ColBarrage.HeaderText = "Barrage";
            this.ColBarrage.Name = "ColBarrage";
            this.ColBarrage.ReadOnly = true;
            this.ColBarrage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColRencontre
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColRencontre.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColRencontre.Frozen = true;
            this.ColRencontre.HeaderText = "Rencontre";
            this.ColRencontre.Name = "ColRencontre";
            this.ColRencontre.ReadOnly = true;
            this.ColRencontre.Width = 80;
            // 
            // ColFA1
            // 
            this.ColFA1.Frozen = true;
            this.ColFA1.HeaderText = "F/A";
            this.ColFA1.Name = "ColFA1";
            this.ColFA1.ReadOnly = true;
            this.ColFA1.Width = 27;
            // 
            // ColJoueur1
            // 
            this.ColJoueur1.Frozen = true;
            this.ColJoueur1.HeaderText = "Joueur 1";
            this.ColJoueur1.Name = "ColJoueur1";
            this.ColJoueur1.ReadOnly = true;
            // 
            // ColJoueur2
            // 
            this.ColJoueur2.Frozen = true;
            this.ColJoueur2.HeaderText = "Joueur 2";
            this.ColJoueur2.Name = "ColJoueur2";
            this.ColJoueur2.ReadOnly = true;
            // 
            // ColJoueurA
            // 
            this.ColJoueurA.Frozen = true;
            this.ColJoueurA.HeaderText = "Joueur Arbitre";
            this.ColJoueurA.Name = "ColJoueurA";
            this.ColJoueurA.ReadOnly = true;
            this.ColJoueurA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColJoueurA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColFA2
            // 
            this.ColFA2.Frozen = true;
            this.ColFA2.HeaderText = "F/A";
            this.ColFA2.Name = "ColFA2";
            this.ColFA2.ReadOnly = true;
            this.ColFA2.Width = 27;
            // 
            // ColScore1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColScore1.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColScore1.Frozen = true;
            this.ColScore1.HeaderText = "Score 1";
            this.ColScore1.Name = "ColScore1";
            this.ColScore1.ReadOnly = true;
            this.ColScore1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColScore1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColScore1.Width = 50;
            // 
            // ColScore2
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColScore2.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColScore2.Frozen = true;
            this.ColScore2.HeaderText = "Score 2";
            this.ColScore2.Name = "ColScore2";
            this.ColScore2.ReadOnly = true;
            this.ColScore2.Width = 50;
            // 
            // ColScore3
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColScore3.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColScore3.Frozen = true;
            this.ColScore3.HeaderText = "Score 3";
            this.ColScore3.Name = "ColScore3";
            this.ColScore3.ReadOnly = true;
            this.ColScore3.Width = 50;
            // 
            // ColScore4
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColScore4.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColScore4.Frozen = true;
            this.ColScore4.HeaderText = "Score 4";
            this.ColScore4.Name = "ColScore4";
            this.ColScore4.ReadOnly = true;
            this.ColScore4.Width = 50;
            // 
            // ColScore5
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColScore5.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColScore5.Frozen = true;
            this.ColScore5.HeaderText = "Score 5";
            this.ColScore5.Name = "ColScore5";
            this.ColScore5.ReadOnly = true;
            this.ColScore5.Width = 50;
            // 
            // ColLicence1
            // 
            this.ColLicence1.Frozen = true;
            this.ColLicence1.HeaderText = "Licence1";
            this.ColLicence1.Name = "ColLicence1";
            this.ColLicence1.ReadOnly = true;
            this.ColLicence1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColLicence1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColLicence1.Width = 40;
            // 
            // ColLicence2
            // 
            this.ColLicence2.Frozen = true;
            this.ColLicence2.HeaderText = "Licence2";
            this.ColLicence2.Name = "ColLicence2";
            this.ColLicence2.ReadOnly = true;
            this.ColLicence2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColLicence2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColLicence2.Width = 40;
            // 
            // ColLicenceA
            // 
            this.ColLicenceA.Frozen = true;
            this.ColLicenceA.HeaderText = "LicenceA";
            this.ColLicenceA.Name = "ColLicenceA";
            this.ColLicenceA.ReadOnly = true;
            this.ColLicenceA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColLicenceA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColLicenceA.Width = 40;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Location = new System.Drawing.Point(0, 698);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(949, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FormTableauSaisie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 723);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvParties);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormTableauSaisie";
            this.Text = "FormTableauSaisie";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParties;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBarrage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRencontre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColJoueur1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColJoueur2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColJoueurA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFA2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColScore1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColScore2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColScore3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColScore4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColScore5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLicence1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLicence2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLicenceA;
    }
}