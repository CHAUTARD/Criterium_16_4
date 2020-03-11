namespace Criterium_16_4
{
    partial class FormCompetitionNom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompetitionNom));
            this.bt_valider = new System.Windows.Forms.Button();
            this.bt_abandon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.cmbGroupe = new System.Windows.Forms.ComboBox();
            this.cmbDivision = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelPoule4 = new System.Windows.Forms.Label();
            this.cmbTable4 = new System.Windows.Forms.ComboBox();
            this.labelPoule3 = new System.Windows.Forms.Label();
            this.cmbTable3 = new System.Windows.Forms.ComboBox();
            this.labelPoule2 = new System.Windows.Forms.Label();
            this.cmbTable2 = new System.Windows.Forms.ComboBox();
            this.labelPoule1 = new System.Windows.Forms.Label();
            this.cmbTable1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_valider
            // 
            this.bt_valider.Enabled = false;
            this.bt_valider.Image = global::Criterium_16_4.Resource1.validation;
            this.bt_valider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_valider.Location = new System.Drawing.Point(312, 165);
            this.bt_valider.Name = "bt_valider";
            this.bt_valider.Size = new System.Drawing.Size(126, 42);
            this.bt_valider.TabIndex = 6;
            this.bt_valider.Text = "Valider";
            this.bt_valider.UseVisualStyleBackColor = true;
            this.bt_valider.Click += new System.EventHandler(this.bt_valider_Click);
            // 
            // bt_abandon
            // 
            this.bt_abandon.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_abandon.Image = ((System.Drawing.Image)(resources.GetObject("bt_abandon.Image")));
            this.bt_abandon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_abandon.Location = new System.Drawing.Point(12, 167);
            this.bt_abandon.Name = "bt_abandon";
            this.bt_abandon.Size = new System.Drawing.Size(126, 42);
            this.bt_abandon.TabIndex = 7;
            this.bt_abandon.Text = "Abandon";
            this.bt_abandon.UseVisualStyleBackColor = true;
            this.bt_abandon.Click += new System.EventHandler(this.bt_abandon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCategorie);
            this.groupBox1.Controls.Add(this.cmbGroupe);
            this.groupBox1.Controls.Add(this.cmbDivision);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 145);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compétition";
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Location = new System.Drawing.Point(111, 23);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(300, 21);
            this.cmbCategorie.TabIndex = 11;
            this.cmbCategorie.ValueMember = "Id_tableau";
            this.cmbCategorie.SelectedIndexChanged += new System.EventHandler(this.cmbCategorie_SelectedIndexChanged);
            // 
            // cmbGroupe
            // 
            this.cmbGroupe.DisplayMember = "groupe";
            this.cmbGroupe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroupe.FormattingEnabled = true;
            this.cmbGroupe.Location = new System.Drawing.Point(112, 66);
            this.cmbGroupe.Name = "cmbGroupe";
            this.cmbGroupe.Size = new System.Drawing.Size(300, 21);
            this.cmbGroupe.TabIndex = 10;
            this.cmbGroupe.ValueMember = "Id_groupe";
            this.cmbGroupe.SelectedIndexChanged += new System.EventHandler(this.cmbGroupe_SelectedIndexChanged_1);
            // 
            // cmbDivision
            // 
            this.cmbDivision.DisplayMember = "division_long";
            this.cmbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new System.Drawing.Point(112, 104);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.Size = new System.Drawing.Size(300, 21);
            this.cmbDivision.TabIndex = 9;
            this.cmbDivision.ValueMember = "Id_division";
            this.cmbDivision.SelectedIndexChanged += new System.EventHandler(this.cmbDivision_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Division :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Groupe :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Catégorie :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelPoule4);
            this.groupBox2.Controls.Add(this.cmbTable4);
            this.groupBox2.Controls.Add(this.labelPoule3);
            this.groupBox2.Controls.Add(this.cmbTable3);
            this.groupBox2.Controls.Add(this.labelPoule2);
            this.groupBox2.Controls.Add(this.cmbTable2);
            this.groupBox2.Controls.Add(this.labelPoule1);
            this.groupBox2.Controls.Add(this.cmbTable1);
            this.groupBox2.Location = new System.Drawing.Point(457, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 195);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tables attribuées à la compétition";
            // 
            // labelPoule4
            // 
            this.labelPoule4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoule4.Location = new System.Drawing.Point(19, 141);
            this.labelPoule4.Name = "labelPoule4";
            this.labelPoule4.Size = new System.Drawing.Size(75, 23);
            this.labelPoule4.TabIndex = 15;
            this.labelPoule4.Text = "Table 4 :";
            this.labelPoule4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbTable4
            // 
            this.cmbTable4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTable4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTable4.FormatString = "N0";
            this.cmbTable4.FormattingEnabled = true;
            this.cmbTable4.Location = new System.Drawing.Point(100, 140);
            this.cmbTable4.MaxDropDownItems = 24;
            this.cmbTable4.Name = "cmbTable4";
            this.cmbTable4.Size = new System.Drawing.Size(121, 24);
            this.cmbTable4.TabIndex = 16;
            // 
            // labelPoule3
            // 
            this.labelPoule3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoule3.Location = new System.Drawing.Point(19, 108);
            this.labelPoule3.Name = "labelPoule3";
            this.labelPoule3.Size = new System.Drawing.Size(75, 23);
            this.labelPoule3.TabIndex = 13;
            this.labelPoule3.Text = "Table 3 :";
            this.labelPoule3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbTable3
            // 
            this.cmbTable3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTable3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTable3.FormatString = "N0";
            this.cmbTable3.FormattingEnabled = true;
            this.cmbTable3.Location = new System.Drawing.Point(99, 108);
            this.cmbTable3.MaxDropDownItems = 24;
            this.cmbTable3.Name = "cmbTable3";
            this.cmbTable3.Size = new System.Drawing.Size(121, 24);
            this.cmbTable3.TabIndex = 14;
            // 
            // labelPoule2
            // 
            this.labelPoule2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoule2.Location = new System.Drawing.Point(19, 76);
            this.labelPoule2.Name = "labelPoule2";
            this.labelPoule2.Size = new System.Drawing.Size(75, 23);
            this.labelPoule2.TabIndex = 11;
            this.labelPoule2.Text = "Table 2 :";
            this.labelPoule2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbTable2
            // 
            this.cmbTable2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTable2.FormatString = "N0";
            this.cmbTable2.FormattingEnabled = true;
            this.cmbTable2.Location = new System.Drawing.Point(100, 75);
            this.cmbTable2.MaxDropDownItems = 24;
            this.cmbTable2.Name = "cmbTable2";
            this.cmbTable2.Size = new System.Drawing.Size(121, 24);
            this.cmbTable2.TabIndex = 12;
            // 
            // labelPoule1
            // 
            this.labelPoule1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoule1.Location = new System.Drawing.Point(16, 41);
            this.labelPoule1.Name = "labelPoule1";
            this.labelPoule1.Size = new System.Drawing.Size(78, 23);
            this.labelPoule1.TabIndex = 9;
            this.labelPoule1.Text = "Table 1  :";
            this.labelPoule1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbTable1
            // 
            this.cmbTable1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTable1.FormatString = "N0";
            this.cmbTable1.FormattingEnabled = true;
            this.cmbTable1.Location = new System.Drawing.Point(100, 40);
            this.cmbTable1.MaxDropDownItems = 24;
            this.cmbTable1.Name = "cmbTable1";
            this.cmbTable1.Size = new System.Drawing.Size(121, 24);
            this.cmbTable1.TabIndex = 10;
            this.cmbTable1.SelectedIndexChanged += new System.EventHandler(this.cmbTable1_SelectedIndexChanged);
            // 
            // FormCompetitionNom
            // 
            this.AcceptButton = this.bt_valider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_abandon;
            this.ClientSize = new System.Drawing.Size(718, 219);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_abandon);
            this.Controls.Add(this.bt_valider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCompetitionNom";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Compétition";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_valider;
        private System.Windows.Forms.Button bt_abandon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCategorie;
        private System.Windows.Forms.ComboBox cmbGroupe;
        private System.Windows.Forms.ComboBox cmbDivision;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelPoule4;
        private System.Windows.Forms.ComboBox cmbTable4;
        private System.Windows.Forms.Label labelPoule3;
        private System.Windows.Forms.ComboBox cmbTable3;
        private System.Windows.Forms.Label labelPoule2;
        private System.Windows.Forms.ComboBox cmbTable2;
        private System.Windows.Forms.Label labelPoule1;
        private System.Windows.Forms.ComboBox cmbTable1;
    }
}