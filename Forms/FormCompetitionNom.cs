using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Criterium_16_4
{
    public partial class FormCompetitionNom : Form
    {
        MainForm _mainForm;
        List<string> _allTables = new List<string> {
                "1", "2", "3", "4","5", "6", "7", "8", "9", "10",
                "11", "12", "13", "14","15", "16", "17", "18", "19", "20",
                "21", "22", "23", "24"};

        public FormCompetitionNom(MainForm frm)
        {
            InitializeComponent();

            _mainForm = frm;

            try
            {
                using (var db = new PetaPoco.Database("SqliteConnect"))
                {
                    var bindingSource = db.Fetch<Categorie>("SELECT Nom FROM Categories ORDER BY Ord;");
                    cmbCategorie.DataSource = bindingSource;
                    cmbCategorie.DisplayMember = "Nom";

                    var bindingSource2 = db.Fetch<Groupe>("SELECT Nom FROM Groupes;");

                    cmbGroupe.DataSource = bindingSource2;
                    cmbGroupe.DisplayMember = "Nom";

                    var bindingSource3 = db.Fetch<Division>("SELECT NomLong FROM Divisions ORDER BY Ord;");

                    cmbDivision.DataSource = bindingSource3;
                    cmbDivision.DisplayMember = "NomLong";
                }

                cmbTable1.DataSource = _allTables.ToList();
                cmbTable2.DataSource = _allTables.ToList();
                cmbTable3.DataSource = _allTables.ToList();
                cmbTable4.DataSource = _allTables.ToList();

                // Sélection d'un élément dans chaque combobox à partir du nom
                IniFile iniFile = new IniFile(SingletonOutils.FILEINI);

                cmbCategorie.SelectedIndex = cmbCategorie.FindStringExact(iniFile.ReadString("COMPETITION", "categorie"));
                cmbGroupe.SelectedIndex = cmbGroupe.FindStringExact(iniFile.ReadString("COMPETITION", "groupe"));
                cmbDivision.SelectedIndex = cmbDivision.FindStringExact(iniFile.ReadString("COMPETITION", "division"));
                
                cmbTable1.SelectedIndex = cmbTable1.FindStringExact(iniFile.ReadString("TABLE", "une"));
                cmbTable2.SelectedIndex = cmbTable2.FindStringExact(iniFile.ReadString("TABLE", "deux"));
                cmbTable3.SelectedIndex = cmbTable3.FindStringExact(iniFile.ReadString("TABLE", "trois"));
                cmbTable4.SelectedIndex = cmbTable4.FindStringExact(iniFile.ReadString("TABLE", "quatre"));

                EnableBtValider();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_valider_Click(object sender, EventArgs e)
        {
            // Mettre à jour le bt_competion de MainForm
            _mainForm.setTextBtCompetition(cmbDivision.Text, cmbGroupe.Text, cmbCategorie.Text);

            // Mettre à jour le fichier INI
            IniFile iniFile = new IniFile(SingletonOutils.FILEINI);

            iniFile.WriteString("COMPETITION", "division", cmbDivision.Text);
            iniFile.WriteString("COMPETITION", "groupe", cmbGroupe.Text);
            iniFile.WriteString("COMPETITION", "categorie", cmbCategorie.Text);

            iniFile.WriteString("TABLE", "une", cmbTable1.Text);
            iniFile.WriteString("TABLE", "deux", cmbTable2.Text);
            iniFile.WriteString("TABLE", "trois", cmbTable3.Text);
            iniFile.WriteString("TABLE", "quatre", cmbTable4.Text);

            Close();
        }

        private void bt_abandon_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EnableBtValider()
        {
            bt_valider.Enabled = (cmbDivision.SelectedIndex > 0) && (cmbGroupe.SelectedIndex > 0) && (cmbCategorie.SelectedIndex > 0) && (cmbTable1.SelectedIndex > 0);
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
    }
}
