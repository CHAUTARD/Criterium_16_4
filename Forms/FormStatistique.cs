using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Criterium_16_4
{
    public partial class FormStatistique : Form
    {
        public FormStatistique()
        {
            InitializeComponent();
        }

        private void FormStatistique_Load(object sender, System.EventArgs e)
        {
            ChargeStatistiques();
        }

        public void ChargeStatistiques()
        {
            // Vidage des information du grid
            dataGridView1.Rows.Clear();

            //do looping for doing some tasks here and update textbox every time
            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                // On récupére toutes les arbitrages
                // var set = context.Set<Joueur>();
                var joueurs = db.Query<Joueur>("SELECT * FROM Joueurs ORDER BY NombreArbitrage DESC").ToList();
                int r = 0;

                foreach(Joueur joueur in joueurs)
                {
                    dataGridView1.Rows.Add(
                        joueur.Nom,
                        joueur.PartiePerdu,
                        joueur.PartieGagnee,
                        joueur.NombreArbitrage,
                        joueur.EnCour ? "Oui": "Non",
                        joueur.EnArbitrage ? "Oui" : "Non"
                    );

                    dataGridView1.Rows[r].DefaultCellStyle.BackColor = (joueur.EnCour || joueur.EnArbitrage) ? Color.LightCoral : Color.White;
                    r++;
                }
                
            }
        }

        private void actualiserToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ChargeStatistiques();
        }
    }
}
