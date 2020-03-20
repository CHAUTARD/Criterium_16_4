using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Criterium_16_4
{
    public partial class MainForm : Form
    {
        List<string> _allTables = new List<string> {
                "1", "2", "3", "4","5", "6", "7", "8", "9", "10",
                "11", "12", "13", "14","15", "16", "17", "18", "19", "20",
                "21", "22", "23", "24"};

        public MainForm()
        {
            InitializeComponent();

            // Titre de la fenétre
            Text = "Compétition Tennis de Table : 16 joueurs en 4 poules. - Version : " + System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString();

            try
            {
                using (var db = new PetaPoco.Database("SqliteConnect"))
                {
                    var bindingSource = db.Fetch<Categorie>("SELECT IdCategorie, Nom FROM Categories ORDER BY Ord;");
                    cmbCategorie.DataSource = bindingSource;
                    cmbCategorie.DisplayMember = "Nom";
                    cmbCategorie.ValueMember = "IdCategorie";

                    var bindingSource2 = db.Fetch<Groupe>("SELECT IdGroupe, Nom FROM Groupes;");

                    cmbGroupe.DataSource = bindingSource2;
                    cmbGroupe.DisplayMember = "Nom";
                    cmbGroupe.ValueMember = "IdGroupe";

                    var bindingSource3 = db.Fetch<Division>("SELECT IdDivision, NomLong FROM Divisions ORDER BY Ord;");

                    cmbDivision.DataSource = bindingSource3;
                    cmbDivision.DisplayMember = "NomLong";
                    cmbDivision.ValueMember = "IdDivision";
                }

                cmbTable1.DataSource = _allTables.ToList();
                cmbTable2.DataSource = _allTables.ToList();
                cmbTable3.DataSource = _allTables.ToList();
                cmbTable4.DataSource = _allTables.ToList();

                RemplirGrid();

                EnableBtValider();
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message, "MainForm");
            }
        }

        private void RemplirGrid()
        {
            // Vidage des informations
            dgvCompetition.Rows.Clear();

            Categorie categorie;
            Division division;
            Groupe groupe;
            DateTime dt;

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                var Competitions = db.Query<Competition>("SELECT * FROM Competitions ORDER BY sDate");
                foreach (Competition cmp in Competitions)
                {
                    categorie = db.SingleOrDefault<Categorie>(cmp.IdCategorie);
                    division = db.SingleOrDefault<Division>(cmp.IdDivision);
                    groupe = db.SingleOrDefault<Groupe>(cmp.IdGroupe);

                    dt = Convert.ToDateTime(cmp.sDate + " 09:00:00");

                    dgvCompetition.Rows.Add(cmp.IdCompetition, categorie.IdCategorie, categorie.Nom,
                        division.IdDivision, division.NomLong,
                        groupe.IdGroupe, groupe.Nom,
                        cmp.Tour, dt.ToString("dd/MM/yyyy"),
                        cmp.Table1, cmp.Table2, cmp.Table3, cmp.Table4,
                        cmp.Commentaire);
                }
            }
        }

        private void bt_abandon_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EnableBtValider()
        {
            toolStripButtonValider.Enabled = (cmbDivision.SelectedIndex > 0) && (cmbGroupe.SelectedIndex > 0) && (cmbCategorie.SelectedIndex > 0) && (cmbTable1.SelectedIndex > 0);
        }

        private void cmbTable1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTable2.Text == "" && cmbTable3.Text == "" && cmbTable4.Text == "" )
            {
                cmbTable2.SelectedItem = cmbTable1.Items.IndexOf(cmbTable1.Text) + 2;
                cmbTable3.SelectedItem = cmbTable1.Items.IndexOf(cmbTable1.Text) + 3;
                cmbTable4.SelectedItem = cmbTable1.Items.IndexOf(cmbTable1.Text) + 4;
            }

            EnableBtValider();
        }

        private void cmbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableBtValider();
        }

        private void cmbGroupe_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            EnableBtValider();
        }

        private void cmbDivision_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            EnableBtValider();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCompetition.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                int iRow = dgvCompetition.SelectedRows[0].Index;

                // Transfert des informations vers le formulaire
                lbIdCompetition.Text = dgvCompetition.Rows[iRow].Cells["ColIdCompetition"].Value.ToString();
                cmbCategorie.SelectedIndex = cmbCategorie.FindStringExact(dgvCompetition.Rows[iRow].Cells["ColCategorie"].Value.ToString());
                cmbDivision.SelectedIndex = cmbDivision.FindStringExact(dgvCompetition.Rows[iRow].Cells["ColDivision"].Value.ToString());
                cmbGroupe.SelectedIndex = cmbGroupe.FindStringExact(dgvCompetition.Rows[iRow].Cells["ColGroupe"].Value.ToString());
                tbTour.Text = dgvCompetition.Rows[iRow].Cells["ColTour"].Value.ToString();
                dpDate.Value = DateTime.ParseExact(dgvCompetition.Rows[iRow].Cells["ColDate"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                if (dgvCompetition.Rows[iRow].Cells["ColCommentaire"].Value is null)
                    rtCommentaire.Text = "";
                else
                    rtCommentaire.Text = dgvCompetition.Rows[iRow].Cells["ColCommentaire"].Value.ToString();

                cmbTable1.SelectedItem = dgvCompetition.Rows[iRow].Cells["ColTable1"].Value.ToString();
                cmbTable2.SelectedItem = dgvCompetition.Rows[iRow].Cells["ColTable2"].Value.ToString();
                cmbTable3.SelectedItem = dgvCompetition.Rows[iRow].Cells["ColTable3"].Value.ToString();
                cmbTable4.SelectedItem = dgvCompetition.Rows[iRow].Cells["ColTable4"].Value.ToString();

                // Activer les bouttons Valider, update et Delete
                toolStripButtonValider.Enabled = true;
            }
        }

        private void toolStripButtonValider_Click(object sender, EventArgs e)
        {
            // Mettre à jour le fichier INI
            IniFile iniFile = new IniFile(SingletonOutils.FILEINI);

            int index = dgvCompetition.SelectedRows[0].Index;

            iniFile.WriteString("COMPETITION", "item", index.ToString() );

            // sauvegarde de la compéttion
            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                SingletonOutils.competition = db.SingleOrDefault<Competition>(int.Parse(dgvCompetition.Rows[index].Cells["ColIdCompetition"].Value.ToString()));
            }

            FormJoueur formJoueur = new FormJoueur(this);
            formJoueur.Show();

            Hide();
        }

        private void toolStripButtonCreer_Click(object sender, EventArgs e)
        {
            // Modification de l'enregistrement courant
            Competition cmp = new Competition();

            cmp.IdCategorie = int.Parse(cmbCategorie.SelectedValue.ToString());
            cmp.IdDivision = int.Parse(cmbDivision.SelectedValue.ToString());
            cmp.IdGroupe = int.Parse(cmbGroupe.SelectedValue.ToString());
            cmp.Tour = tbTour.Text;
            DateTime DateValue = Convert.ToDateTime(dpDate.Value);
            cmp.sDate = DateValue.ToString("yyyy-MM-dd");
            cmp.Commentaire = rtCommentaire.Text;

            cmp.Table1 = int.Parse(cmbTable1.Text);
            cmp.Table2 = int.Parse(cmbTable2.Text);
            cmp.Table3 = int.Parse(cmbTable3.Text);
            cmp.Table4 = int.Parse(cmbTable4.Text);

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Insert("Competitions", "IdCompetition", cmp);
            }

            RemplirGrid();
        }

        private void toolStripButtonModifier_Click(object sender, EventArgs e)
        {
            // Modification de l'enregistrement courant
            Competition cmp = new Competition();

            cmp.IdCompetition = Int32.Parse(lbIdCompetition.Text);
            cmp.IdCategorie = Int32.Parse(cmbCategorie.SelectedValue.ToString());
            cmp.IdDivision = Int32.Parse(cmbDivision.SelectedValue.ToString());
            cmp.IdGroupe = Int32.Parse(cmbGroupe.SelectedValue.ToString());
            cmp.Tour = tbTour.Text;
            DateTime DateValue = Convert.ToDateTime(dpDate.Value);
            cmp.sDate = DateValue.ToString("yyyy-MM-dd");
            cmp.Commentaire = rtCommentaire.Text;

            cmp.Table1 = Int32.Parse(cmbTable1.Text);
            cmp.Table2 = Int32.Parse(cmbTable2.Text);
            cmp.Table3 = Int32.Parse(cmbTable3.Text);
            cmp.Table4 = Int32.Parse(cmbTable4.Text);

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                var existing = db.SingleOrDefault<Competition>("SELECT * FROM Competitions WHERE IdCompetition=@0 ", cmp.IdCompetition);
                if (existing != null)
                    db.Update("Competitions", "IdCompetition", cmp);
                else
                    db.Insert("Competitions", "IdCompetition", cmp);
            }

            RemplirGrid();
        }

        private void toolStripButtonSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirmez-vous la suppression", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                //code for Yes
                using (var db = new PetaPoco.Database("SqliteConnect"))
                {
                    // Suppression dans la table compétition
                    db.Delete<Competition>(Int32.Parse(lbIdCompetition.Text));

                    // Suppression dans la table CompetitionJoueur
                    db.Delete<CompetitionLicence>("WHERE [IdCompetition] = " + lbIdCompetition.Text );
                }
            }
        }

        private void toolStripButtonQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Sélection d'un élément dans chaque combobox à partir du nom
            IniFile iniFile = new IniFile(SingletonOutils.FILEINI);

            int index = int.Parse(iniFile.ReadString("COMPETITION", "item"));
            dgvCompetition.Rows[index].Selected = true;
        }
    }
}