/*
 * Created by SharpDevelop.
 * User: CHAUTARD
 * Date: 04/11/2019
 * Time: 12:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Criterium_16_4
{
    partial class FormJoueur
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.RichTextBox txtRapport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewPoule;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvListeJoueurs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traitementToolStripMenuItem;
        private System.Windows.Forms.Label label_ligue;
        private System.Windows.Forms.ToolStripMenuItem editionDesPoulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnClubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionDesQuatrePoulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionsDesPoulesvideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joueursAvec1Ou3QualifiésToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem joueursAvec2QualifiésToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem joueursAvec1Ou3QualifiésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joueursAvec2QualifiésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joueursAvec1QualifiéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joueursAvec2QualifiéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joueursAvec1QualifiéToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem joueursAvec2QualifiésToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesbarragesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem départageDesÉgalitésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointsToolStripMenuItem;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJoueur));
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewPoule = new System.Windows.Forms.DataGridView();
            this.ColPoule1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPoule2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPoule3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPoule4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbCompetition = new System.Windows.Forms.Label();
            this.dgvListeJoueurs = new System.Windows.Forms.DataGridView();
            this.ColPresent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLicence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDatNais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColClub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importationDesDonnéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catégoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesClubsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnClubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.traitementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionDesPoulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionDesQuatrePoulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionsDesPoulesvideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joueursAvec1Ou3QualifiésToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.joueursAvec2QualifiésToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.joueursAvec1Ou3QualifiésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joueursAvec2QualifiésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joueursAvec1QualifiéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joueursAvec2QualifiéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joueursAvec1QualifiéToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.joueursAvec2QualifiésToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.départageDesÉgalitésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesbarragesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtRapport = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_ligue = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoule)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeJoueurs)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(19, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rapport :";
            // 
            // dataGridViewPoule
            // 
            this.dataGridViewPoule.AllowUserToAddRows = false;
            this.dataGridViewPoule.AllowUserToDeleteRows = false;
            this.dataGridViewPoule.AllowUserToResizeColumns = false;
            this.dataGridViewPoule.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewPoule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPoule.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPoule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPoule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPoule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColPoule1,
            this.ColPoule2,
            this.ColPoule3,
            this.ColPoule4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPoule.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPoule.Location = new System.Drawing.Point(845, 91);
            this.dataGridViewPoule.MultiSelect = false;
            this.dataGridViewPoule.Name = "dataGridViewPoule";
            this.dataGridViewPoule.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewPoule.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewPoule.Size = new System.Drawing.Size(816, 317);
            this.dataGridViewPoule.TabIndex = 8;
            this.dataGridViewPoule.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewPouleCellMouseDown);
            this.dataGridViewPoule.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewPouleColumnHeaderMouseDoubleClick);
            this.dataGridViewPoule.DragDrop += new System.Windows.Forms.DragEventHandler(this.DataGridViewPouleDragDrop);
            this.dataGridViewPoule.DragEnter += new System.Windows.Forms.DragEventHandler(this.DataGridViewPouleDragEnter);
            // 
            // ColPoule1
            // 
            this.ColPoule1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColPoule1.HeaderText = "Poule 1";
            this.ColPoule1.Name = "ColPoule1";
            this.ColPoule1.ReadOnly = true;
            this.ColPoule1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColPoule1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColPoule2
            // 
            this.ColPoule2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColPoule2.HeaderText = "Poule 2";
            this.ColPoule2.Name = "ColPoule2";
            this.ColPoule2.ReadOnly = true;
            this.ColPoule2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColPoule3
            // 
            this.ColPoule3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColPoule3.HeaderText = "Poule 3";
            this.ColPoule3.Name = "ColPoule3";
            this.ColPoule3.ReadOnly = true;
            this.ColPoule3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColPoule4
            // 
            this.ColPoule4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColPoule4.HeaderText = "Poule 4";
            this.ColPoule4.Name = "ColPoule4";
            this.ColPoule4.ReadOnly = true;
            this.ColPoule4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbCompetition);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(845, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(816, 58);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Compétition";
            // 
            // lbCompetition
            // 
            this.lbCompetition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCompetition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompetition.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbCompetition.Location = new System.Drawing.Point(3, 17);
            this.lbCompetition.Name = "lbCompetition";
            this.lbCompetition.Size = new System.Drawing.Size(810, 38);
            this.lbCompetition.TabIndex = 0;
            // 
            // dgvListeJoueurs
            // 
            this.dgvListeJoueurs.AllowUserToAddRows = false;
            this.dgvListeJoueurs.AllowUserToDeleteRows = false;
            this.dgvListeJoueurs.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListeJoueurs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListeJoueurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeJoueurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColPresent,
            this.ColNumero,
            this.ColLicence,
            this.ColNom,
            this.ColDatNais,
            this.ColClub,
            this.ColPoint});
            this.dgvListeJoueurs.Location = new System.Drawing.Point(22, 27);
            this.dgvListeJoueurs.MultiSelect = false;
            this.dgvListeJoueurs.Name = "dgvListeJoueurs";
            this.dgvListeJoueurs.ReadOnly = true;
            this.dgvListeJoueurs.RowHeadersVisible = false;
            this.dgvListeJoueurs.Size = new System.Drawing.Size(817, 381);
            this.dgvListeJoueurs.TabIndex = 13;
            this.dgvListeJoueurs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListeJoueursCellContentClick);
            this.dgvListeJoueurs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvListeJoueursKeyDown);
            // 
            // ColPresent
            // 
            this.ColPresent.FalseValue = "0";
            this.ColPresent.HeaderText = "Présent";
            this.ColPresent.Name = "ColPresent";
            this.ColPresent.ReadOnly = true;
            this.ColPresent.TrueValue = "1";
            this.ColPresent.Width = 60;
            // 
            // ColNumero
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColNumero.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColNumero.HeaderText = "Numéro";
            this.ColNumero.Name = "ColNumero";
            this.ColNumero.ReadOnly = true;
            this.ColNumero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColNumero.Width = 60;
            // 
            // ColLicence
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColLicence.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColLicence.HeaderText = "Licence";
            this.ColLicence.Name = "ColLicence";
            this.ColLicence.ReadOnly = true;
            this.ColLicence.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColLicence.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColLicence.Width = 80;
            // 
            // ColNom
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ColNom.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColNom.HeaderText = "Nom et prénom";
            this.ColNom.Name = "ColNom";
            this.ColNom.ReadOnly = true;
            this.ColNom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColNom.Width = 250;
            // 
            // ColDatNais
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColDatNais.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColDatNais.HeaderText = "Date Naiss.";
            this.ColDatNais.Name = "ColDatNais";
            this.ColDatNais.ReadOnly = true;
            this.ColDatNais.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColDatNais.Width = 80;
            // 
            // ColClub
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColClub.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColClub.HeaderText = "Club";
            this.ColClub.Name = "ColClub";
            this.ColClub.ReadOnly = true;
            this.ColClub.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColClub.Width = 200;
            // 
            // ColPoint
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColPoint.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColPoint.HeaderText = "Points";
            this.ColPoint.Name = "ColPoint";
            this.ColPoint.ReadOnly = true;
            this.ColPoint.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColPoint.Width = 80;
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importationDesDonnéesToolStripMenuItem,
            this.ajouterUnClubToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // importationDesDonnéesToolStripMenuItem
            // 
            this.importationDesDonnéesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catégoriesToolStripMenuItem,
            this.divisionsToolStripMenuItem,
            this.groupesToolStripMenuItem,
            this.lesClubsToolStripMenuItem});
            this.importationDesDonnéesToolStripMenuItem.Name = "importationDesDonnéesToolStripMenuItem";
            this.importationDesDonnéesToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.importationDesDonnéesToolStripMenuItem.Text = "&Importation des données";
            // 
            // catégoriesToolStripMenuItem
            // 
            this.catégoriesToolStripMenuItem.Name = "catégoriesToolStripMenuItem";
            this.catégoriesToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.catégoriesToolStripMenuItem.Text = "&Catégories";
            this.catégoriesToolStripMenuItem.Click += new System.EventHandler(this.catégoriesToolStripMenuItem_Click);
            // 
            // divisionsToolStripMenuItem
            // 
            this.divisionsToolStripMenuItem.Name = "divisionsToolStripMenuItem";
            this.divisionsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.divisionsToolStripMenuItem.Text = "&Divisions";
            this.divisionsToolStripMenuItem.Click += new System.EventHandler(this.divisionsToolStripMenuItem_Click);
            // 
            // groupesToolStripMenuItem
            // 
            this.groupesToolStripMenuItem.Name = "groupesToolStripMenuItem";
            this.groupesToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.groupesToolStripMenuItem.Text = "&Groupes";
            this.groupesToolStripMenuItem.Click += new System.EventHandler(this.groupesToolStripMenuItem_Click);
            // 
            // lesClubsToolStripMenuItem
            // 
            this.lesClubsToolStripMenuItem.Name = "lesClubsToolStripMenuItem";
            this.lesClubsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.lesClubsToolStripMenuItem.Text = "&Les clubs";
            this.lesClubsToolStripMenuItem.Click += new System.EventHandler(this.lesClubsToolStripMenuItem_Click);
            // 
            // ajouterUnClubToolStripMenuItem
            // 
            this.ajouterUnClubToolStripMenuItem.Name = "ajouterUnClubToolStripMenuItem";
            this.ajouterUnClubToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.ajouterUnClubToolStripMenuItem.Text = "&Ajouter un club";
            this.ajouterUnClubToolStripMenuItem.Click += new System.EventHandler(this.AjouterUnClubToolStripMenuItemClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.traitementToolStripMenuItem,
            this.editionDesPoulesToolStripMenuItem,
            this.aProposDeToolStripMenuItem,
            this.gestionDesbarragesToolStripMenuItem,
            this.parametresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1676, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // traitementToolStripMenuItem
            // 
            this.traitementToolStripMenuItem.Enabled = false;
            this.traitementToolStripMenuItem.Name = "traitementToolStripMenuItem";
            this.traitementToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.traitementToolStripMenuItem.Text = "&Mise en poule";
            this.traitementToolStripMenuItem.Click += new System.EventHandler(this.TraitementToolStripMenuItemClick);
            // 
            // editionDesPoulesToolStripMenuItem
            // 
            this.editionDesPoulesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editionDesQuatrePoulesToolStripMenuItem,
            this.editionsDesPoulesvideToolStripMenuItem,
            this.départageDesÉgalitésToolStripMenuItem});
            this.editionDesPoulesToolStripMenuItem.Name = "editionDesPoulesToolStripMenuItem";
            this.editionDesPoulesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.editionDesPoulesToolStripMenuItem.Text = "Editions";
            // 
            // editionDesQuatrePoulesToolStripMenuItem
            // 
            this.editionDesQuatrePoulesToolStripMenuItem.Enabled = false;
            this.editionDesQuatrePoulesToolStripMenuItem.Name = "editionDesQuatrePoulesToolStripMenuItem";
            this.editionDesQuatrePoulesToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.editionDesQuatrePoulesToolStripMenuItem.Text = "&Edition des quatre poules";
            this.editionDesQuatrePoulesToolStripMenuItem.Click += new System.EventHandler(this.EditionDesQuatrePoulesToolStripMenuItemClick);
            // 
            // editionsDesPoulesvideToolStripMenuItem
            // 
            this.editionsDesPoulesvideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.joueursAvec1Ou3QualifiésToolStripMenuItem1,
            this.joueursAvec2QualifiésToolStripMenuItem2,
            this.joueursAvec1Ou3QualifiésToolStripMenuItem,
            this.joueursAvec2QualifiésToolStripMenuItem,
            this.joueursAvec1QualifiéToolStripMenuItem,
            this.joueursAvec2QualifiéToolStripMenuItem,
            this.joueursAvec1QualifiéToolStripMenuItem1,
            this.joueursAvec2QualifiésToolStripMenuItem1});
            this.editionsDesPoulesvideToolStripMenuItem.Name = "editionsDesPoulesvideToolStripMenuItem";
            this.editionsDesPoulesvideToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.editionsDesPoulesvideToolStripMenuItem.Text = "Editions des poules &vide";
            // 
            // joueursAvec1Ou3QualifiésToolStripMenuItem1
            // 
            this.joueursAvec1Ou3QualifiésToolStripMenuItem1.Name = "joueursAvec1Ou3QualifiésToolStripMenuItem1";
            this.joueursAvec1Ou3QualifiésToolStripMenuItem1.Size = new System.Drawing.Size(232, 22);
            this.joueursAvec1Ou3QualifiésToolStripMenuItem1.Text = "3 joueurs avec 1 ou 3 qualifiés";
            this.joueursAvec1Ou3QualifiésToolStripMenuItem1.Click += new System.EventHandler(this.POU315ToolStripMenuItem1Click);
            // 
            // joueursAvec2QualifiésToolStripMenuItem2
            // 
            this.joueursAvec2QualifiésToolStripMenuItem2.Name = "joueursAvec2QualifiésToolStripMenuItem2";
            this.joueursAvec2QualifiésToolStripMenuItem2.Size = new System.Drawing.Size(232, 22);
            this.joueursAvec2QualifiésToolStripMenuItem2.Text = "3 joueurs avec 2 qualifiés";
            this.joueursAvec2QualifiésToolStripMenuItem2.Click += new System.EventHandler(this.POU325ToolStripMenuItem2Click);
            // 
            // joueursAvec1Ou3QualifiésToolStripMenuItem
            // 
            this.joueursAvec1Ou3QualifiésToolStripMenuItem.Name = "joueursAvec1Ou3QualifiésToolStripMenuItem";
            this.joueursAvec1Ou3QualifiésToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.joueursAvec1Ou3QualifiésToolStripMenuItem.Text = "4 Joueurs avec 1 ou 3 qualifiés";
            this.joueursAvec1Ou3QualifiésToolStripMenuItem.Click += new System.EventHandler(this.POU415ToolStripMenuItemClick);
            // 
            // joueursAvec2QualifiésToolStripMenuItem
            // 
            this.joueursAvec2QualifiésToolStripMenuItem.Name = "joueursAvec2QualifiésToolStripMenuItem";
            this.joueursAvec2QualifiésToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.joueursAvec2QualifiésToolStripMenuItem.Text = "4 Joueurs avec 2 qualifiés";
            this.joueursAvec2QualifiésToolStripMenuItem.Click += new System.EventHandler(this.POU425ToolStripMenuItemClick);
            // 
            // joueursAvec1QualifiéToolStripMenuItem
            // 
            this.joueursAvec1QualifiéToolStripMenuItem.Name = "joueursAvec1QualifiéToolStripMenuItem";
            this.joueursAvec1QualifiéToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.joueursAvec1QualifiéToolStripMenuItem.Text = "5 joueurs avec 1 qualifié";
            this.joueursAvec1QualifiéToolStripMenuItem.Click += new System.EventHandler(this.joueursAvec1QualifiéToolStripMenuItem_Click);
            // 
            // joueursAvec2QualifiéToolStripMenuItem
            // 
            this.joueursAvec2QualifiéToolStripMenuItem.Name = "joueursAvec2QualifiéToolStripMenuItem";
            this.joueursAvec2QualifiéToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.joueursAvec2QualifiéToolStripMenuItem.Text = "5 joueurs avec 2 qualifiés";
            this.joueursAvec2QualifiéToolStripMenuItem.Click += new System.EventHandler(this.joueursAvec2QualifiéToolStripMenuItem_Click);
            // 
            // joueursAvec1QualifiéToolStripMenuItem1
            // 
            this.joueursAvec1QualifiéToolStripMenuItem1.Name = "joueursAvec1QualifiéToolStripMenuItem1";
            this.joueursAvec1QualifiéToolStripMenuItem1.Size = new System.Drawing.Size(232, 22);
            this.joueursAvec1QualifiéToolStripMenuItem1.Text = "6 joueurs avec 1 qualifié";
            this.joueursAvec1QualifiéToolStripMenuItem1.Click += new System.EventHandler(this.joueursAvec1QualifiéToolStripMenuItem1_Click);
            // 
            // joueursAvec2QualifiésToolStripMenuItem1
            // 
            this.joueursAvec2QualifiésToolStripMenuItem1.Name = "joueursAvec2QualifiésToolStripMenuItem1";
            this.joueursAvec2QualifiésToolStripMenuItem1.Size = new System.Drawing.Size(232, 22);
            this.joueursAvec2QualifiésToolStripMenuItem1.Text = "6 joueurs avec 2 qualifiés";
            this.joueursAvec2QualifiésToolStripMenuItem1.Click += new System.EventHandler(this.joueursAvec2QualifiésToolStripMenuItem1_Click);
            // 
            // départageDesÉgalitésToolStripMenuItem
            // 
            this.départageDesÉgalitésToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partiesToolStripMenuItem,
            this.pointsToolStripMenuItem});
            this.départageDesÉgalitésToolStripMenuItem.Name = "départageDesÉgalitésToolStripMenuItem";
            this.départageDesÉgalitésToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.départageDesÉgalitésToolStripMenuItem.Text = "Départage des égalités";
            // 
            // partiesToolStripMenuItem
            // 
            this.partiesToolStripMenuItem.Name = "partiesToolStripMenuItem";
            this.partiesToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.partiesToolStripMenuItem.Text = "Parties / Manches";
            this.partiesToolStripMenuItem.Click += new System.EventHandler(this.PartiesToolStripMenuItemClick);
            // 
            // pointsToolStripMenuItem
            // 
            this.pointsToolStripMenuItem.Name = "pointsToolStripMenuItem";
            this.pointsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.pointsToolStripMenuItem.Text = "Points";
            this.pointsToolStripMenuItem.Click += new System.EventHandler(this.PointsToolStripMenuItemClick);
            // 
            // aProposDeToolStripMenuItem
            // 
            this.aProposDeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aProposDeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aProposDeToolStripMenuItem.Image")));
            this.aProposDeToolStripMenuItem.Name = "aProposDeToolStripMenuItem";
            this.aProposDeToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.aProposDeToolStripMenuItem.Text = "A propos de...";
            this.aProposDeToolStripMenuItem.Click += new System.EventHandler(this.AProposDeToolStripMenuItemClick);
            // 
            // gestionDesbarragesToolStripMenuItem
            // 
            this.gestionDesbarragesToolStripMenuItem.Enabled = false;
            this.gestionDesbarragesToolStripMenuItem.Name = "gestionDesbarragesToolStripMenuItem";
            this.gestionDesbarragesToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.gestionDesbarragesToolStripMenuItem.Text = "Gestion des barrages";
            this.gestionDesbarragesToolStripMenuItem.Click += new System.EventHandler(this.GestionDesBarragesToolStripMenuItemClick);
            // 
            // parametresToolStripMenuItem
            // 
            this.parametresToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.parametresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("parametresToolStripMenuItem.Image")));
            this.parametresToolStripMenuItem.Name = "parametresToolStripMenuItem";
            this.parametresToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.parametresToolStripMenuItem.Text = "&Paramètres";
            this.parametresToolStripMenuItem.Click += new System.EventHandler(this.parametresToolStripMenuItem_Click);
            // 
            // txtRapport
            // 
            this.txtRapport.ContextMenuStrip = this.contextMenuStrip1;
            this.txtRapport.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRapport.Location = new System.Drawing.Point(22, 442);
            this.txtRapport.Name = "txtRapport";
            this.txtRapport.Size = new System.Drawing.Size(1633, 173);
            this.txtRapport.TabIndex = 15;
            this.txtRapport.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(124, 26);
            // 
            // imprimerToolStripMenuItem
            // 
            this.imprimerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimerToolStripMenuItem.Image")));
            this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
            this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.imprimerToolStripMenuItem.Text = "Imprimer";
            this.imprimerToolStripMenuItem.Click += new System.EventHandler(this.imprimerToolStripMenuItem_Click);
            // 
            // label_ligue
            // 
            this.label_ligue.Enabled = false;
            this.label_ligue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ligue.Location = new System.Drawing.Point(226, 166);
            this.label_ligue.Name = "label_ligue";
            this.label_ligue.Size = new System.Drawing.Size(358, 65);
            this.label_ligue.TabIndex = 16;
            this.label_ligue.Text = "Coller dans le tableau les données issus du site de la ligue.";
            this.label_ligue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // FormJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1676, 627);
            this.Controls.Add(this.label_ligue);
            this.Controls.Add(this.txtRapport);
            this.Controls.Add(this.dgvListeJoueurs);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridViewPoule);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormJoueur";
            this.Text = "Mise en poule des joueurs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormJoueur_FormClosed);
            this.Shown += new System.EventHandler(this.FormJoueur_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoule)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeJoueurs)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.ToolStripMenuItem importationDesDonnéesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catégoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesClubsToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametresToolStripMenuItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColPresent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLicence;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDatNais;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColClub;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPoule1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPoule2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPoule3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPoule4;
        private System.Windows.Forms.Label lbCompetition;
    }
}
