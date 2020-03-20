namespace Criterium_16_4
{
    partial class MainForm
    {
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbIdCompetition = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rtCommentaire = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dpDate = new System.Windows.Forms.DateTimePicker();
            this.tbTour = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.dgvCompetition = new System.Windows.Forms.DataGridView();
            this.ColIdCompetition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIdCategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIdDivision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDivision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIdGroupe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGroupe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTable1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTable2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTable3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTable4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCommentaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonValider = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonQuitter = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCreer = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonModifier = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSupprimer = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetition)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbIdCompetition);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rtCommentaire);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dpDate);
            this.groupBox1.Controls.Add(this.tbTour);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbCategorie);
            this.groupBox1.Controls.Add(this.cmbGroupe);
            this.groupBox1.Controls.Add(this.cmbDivision);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 448);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(881, 205);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compétition";
            // 
            // lbIdCompetition
            // 
            this.lbIdCompetition.AutoSize = true;
            this.lbIdCompetition.Location = new System.Drawing.Point(804, 0);
            this.lbIdCompetition.Name = "lbIdCompetition";
            this.lbIdCompetition.Size = new System.Drawing.Size(71, 13);
            this.lbIdCompetition.TabIndex = 18;
            this.lbIdCompetition.Text = "IdCompetition";
            this.lbIdCompetition.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(429, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(271, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Commentaire - (Texte mis dans les en-tête des éditions) :";
            // 
            // rtCommentaire
            // 
            this.rtCommentaire.Location = new System.Drawing.Point(432, 40);
            this.rtCommentaire.Name = "rtCommentaire";
            this.rtCommentaire.Size = new System.Drawing.Size(469, 154);
            this.rtCommentaire.TabIndex = 16;
            this.rtCommentaire.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Date :";
            // 
            // dpDate
            // 
            this.dpDate.Location = new System.Drawing.Point(112, 175);
            this.dpDate.MaxDate = new System.DateTime(2080, 12, 31, 0, 0, 0, 0);
            this.dpDate.MinDate = new System.DateTime(2020, 3, 10, 0, 0, 0, 0);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(299, 20);
            this.dpDate.TabIndex = 14;
            // 
            // tbTour
            // 
            this.tbTour.Location = new System.Drawing.Point(112, 143);
            this.tbTour.Name = "tbTour";
            this.tbTour.Size = new System.Drawing.Size(299, 20);
            this.tbTour.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tour :";
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.DisplayMember = "Id_tableau";
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
            this.groupBox2.Location = new System.Drawing.Point(932, 448);
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
            // dgvCompetition
            // 
            this.dgvCompetition.AllowUserToAddRows = false;
            this.dgvCompetition.AllowUserToDeleteRows = false;
            this.dgvCompetition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompetition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdCompetition,
            this.ColIdCategorie,
            this.ColCategorie,
            this.ColIdDivision,
            this.ColDivision,
            this.ColIdGroupe,
            this.ColGroupe,
            this.ColTour,
            this.ColDate,
            this.ColTable1,
            this.ColTable2,
            this.ColTable3,
            this.ColTable4,
            this.ColCommentaire});
            this.dgvCompetition.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCompetition.Location = new System.Drawing.Point(12, 0);
            this.dgvCompetition.MultiSelect = false;
            this.dgvCompetition.Name = "dgvCompetition";
            this.dgvCompetition.ReadOnly = true;
            this.dgvCompetition.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompetition.Size = new System.Drawing.Size(1168, 429);
            this.dgvCompetition.TabIndex = 10;
            this.dgvCompetition.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // ColIdCompetition
            // 
            this.ColIdCompetition.HeaderText = "IdCompetition";
            this.ColIdCompetition.Name = "ColIdCompetition";
            this.ColIdCompetition.ReadOnly = true;
            this.ColIdCompetition.Visible = false;
            this.ColIdCompetition.Width = 40;
            // 
            // ColIdCategorie
            // 
            this.ColIdCategorie.HeaderText = "IdCategorie";
            this.ColIdCategorie.Name = "ColIdCategorie";
            this.ColIdCategorie.ReadOnly = true;
            this.ColIdCategorie.Visible = false;
            // 
            // ColCategorie
            // 
            this.ColCategorie.HeaderText = "Catégorie";
            this.ColCategorie.Name = "ColCategorie";
            this.ColCategorie.ReadOnly = true;
            this.ColCategorie.Width = 200;
            // 
            // ColIdDivision
            // 
            this.ColIdDivision.HeaderText = "IdDivision";
            this.ColIdDivision.Name = "ColIdDivision";
            this.ColIdDivision.ReadOnly = true;
            this.ColIdDivision.Visible = false;
            // 
            // ColDivision
            // 
            this.ColDivision.HeaderText = "Division";
            this.ColDivision.Name = "ColDivision";
            this.ColDivision.ReadOnly = true;
            this.ColDivision.Width = 150;
            // 
            // ColIdGroupe
            // 
            this.ColIdGroupe.HeaderText = "IdGroupe";
            this.ColIdGroupe.Name = "ColIdGroupe";
            this.ColIdGroupe.ReadOnly = true;
            this.ColIdGroupe.Visible = false;
            // 
            // ColGroupe
            // 
            this.ColGroupe.HeaderText = "Groupe";
            this.ColGroupe.Name = "ColGroupe";
            this.ColGroupe.ReadOnly = true;
            this.ColGroupe.Width = 60;
            // 
            // ColTour
            // 
            this.ColTour.HeaderText = "Tour";
            this.ColTour.Name = "ColTour";
            this.ColTour.ReadOnly = true;
            this.ColTour.Width = 80;
            // 
            // ColDate
            // 
            this.ColDate.HeaderText = "Date";
            this.ColDate.Name = "ColDate";
            this.ColDate.ReadOnly = true;
            this.ColDate.Width = 60;
            // 
            // ColTable1
            // 
            this.ColTable1.HeaderText = "Table1";
            this.ColTable1.Name = "ColTable1";
            this.ColTable1.ReadOnly = true;
            this.ColTable1.Width = 50;
            // 
            // ColTable2
            // 
            this.ColTable2.HeaderText = "Table 2";
            this.ColTable2.Name = "ColTable2";
            this.ColTable2.ReadOnly = true;
            this.ColTable2.Width = 50;
            // 
            // ColTable3
            // 
            this.ColTable3.HeaderText = "Table 3";
            this.ColTable3.Name = "ColTable3";
            this.ColTable3.ReadOnly = true;
            this.ColTable3.Width = 50;
            // 
            // ColTable4
            // 
            this.ColTable4.HeaderText = "Table 4";
            this.ColTable4.Name = "ColTable4";
            this.ColTable4.ReadOnly = true;
            this.ColTable4.Width = 50;
            // 
            // ColCommentaire
            // 
            this.ColCommentaire.HeaderText = "Commentaire";
            this.ColCommentaire.Name = "ColCommentaire";
            this.ColCommentaire.ReadOnly = true;
            this.ColCommentaire.Width = 350;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonValider,
            this.toolStripButtonQuitter,
            this.toolStripButtonCreer,
            this.toolStripButtonModifier,
            this.toolStripButtonSupprimer});
            this.toolStrip1.Location = new System.Drawing.Point(0, 675);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1185, 70);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonValider
            // 
            this.toolStripButtonValider.AutoSize = false;
            this.toolStripButtonValider.Enabled = false;
            this.toolStripButtonValider.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonValider.Image")));
            this.toolStripButtonValider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonValider.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonValider.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonValider.Name = "toolStripButtonValider";
            this.toolStripButtonValider.Size = new System.Drawing.Size(120, 67);
            this.toolStripButtonValider.Text = "Valider";
            this.toolStripButtonValider.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonValider.Click += new System.EventHandler(this.toolStripButtonValider_Click);
            // 
            // toolStripButtonQuitter
            // 
            this.toolStripButtonQuitter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonQuitter.AutoSize = false;
            this.toolStripButtonQuitter.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonQuitter.Image")));
            this.toolStripButtonQuitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonQuitter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonQuitter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonQuitter.Name = "toolStripButtonQuitter";
            this.toolStripButtonQuitter.Size = new System.Drawing.Size(120, 67);
            this.toolStripButtonQuitter.Text = "Quitter";
            this.toolStripButtonQuitter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonQuitter.Click += new System.EventHandler(this.toolStripButtonQuitter_Click);
            // 
            // toolStripButtonCreer
            // 
            this.toolStripButtonCreer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCreer.Image")));
            this.toolStripButtonCreer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonCreer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonCreer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCreer.Margin = new System.Windows.Forms.Padding(270, 1, 0, 2);
            this.toolStripButtonCreer.Name = "toolStripButtonCreer";
            this.toolStripButtonCreer.Size = new System.Drawing.Size(103, 67);
            this.toolStripButtonCreer.Text = "Créer";
            this.toolStripButtonCreer.Click += new System.EventHandler(this.toolStripButtonCreer_Click);
            // 
            // toolStripButtonModifier
            // 
            this.toolStripButtonModifier.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonModifier.Image")));
            this.toolStripButtonModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonModifier.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonModifier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonModifier.Name = "toolStripButtonModifier";
            this.toolStripButtonModifier.Size = new System.Drawing.Size(120, 67);
            this.toolStripButtonModifier.Text = "Modifier";
            this.toolStripButtonModifier.Click += new System.EventHandler(this.toolStripButtonModifier_Click);
            // 
            // toolStripButtonSupprimer
            // 
            this.toolStripButtonSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSupprimer.Image")));
            this.toolStripButtonSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonSupprimer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSupprimer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSupprimer.Margin = new System.Windows.Forms.Padding(30, 1, 0, 2);
            this.toolStripButtonSupprimer.Name = "toolStripButtonSupprimer";
            this.toolStripButtonSupprimer.Size = new System.Drawing.Size(130, 67);
            this.toolStripButtonSupprimer.Text = "Supprimer";
            this.toolStripButtonSupprimer.Click += new System.EventHandler(this.toolStripButtonSupprimer_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 745);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvCompetition);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compétition Tennis de Table : 16 joueurs en 4 poules. ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetition)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dpDate;
        private System.Windows.Forms.TextBox tbTour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvCompetition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtCommentaire;
        private System.Windows.Forms.Label lbIdCompetition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdCompetition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdCategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdDivision;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDivision;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdGroupe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGroupe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTable1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTable2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTable3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTable4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCommentaire;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonValider;
        private System.Windows.Forms.ToolStripButton toolStripButtonQuitter;
        private System.Windows.Forms.ToolStripButton toolStripButtonCreer;
        private System.Windows.Forms.ToolStripButton toolStripButtonModifier;
        private System.Windows.Forms.ToolStripButton toolStripButtonSupprimer;
    }
}