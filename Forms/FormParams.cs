using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Criterium_16_4
{
    public partial class FormParams : Form
    {
        List<Parametre> _lParametre = new List<Parametre>();

        public FormParams()
        {
            InitializeComponent();

            // Remplir la liste des paramètres
            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                var ret = db.Query<Parametre>("SELECT * FROM Parametres ORDER BY IdParametre;");

                foreach (var r in ret)
                {
                    _lParametre.Add(r);
                }
            }

            // Remplir la liste des paramètre et les informations sur le premier
            bool bFirst = true;

            foreach (Parametre param in _lParametre)
            {
                listBox1.Items.Add(param.Titre);

                if (bFirst)
                {
                    lbIdParametre.Text = param.IdParametre.ToString();
                    richTextBox1.Text = param.Commentaire;
                    textBox1.Text = param.Init;

                    bFirst = false;
                }
            }
        }

        private void bt_abandon_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btValid_Click(object sender, System.EventArgs e)
        {
            if ( string.IsNullOrEmpty(textBox1.Text.Trim()) )
            {
                MessageBox.Show("Un paramètre doit être renseigné !","Important");
            }
            else
            {
                using (var db = new PetaPoco.Database("SqliteConnect"))
                {
                    db.Update(" set Init=@0 where IdParametre=@1", textBox1.Text.Trim(), lbIdParametre.Text);
                }
                _lParametre[Int32.Parse(lbIdParametre.Text)].Init = textBox1.Text.Trim();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                var param = db.FirstOrDefault<Parametre>("SELECT * FROM Parametres WHERE Titre == @0", listBox1.SelectedItem);

                lbIdParametre.Text = param.IdParametre.ToString();
                richTextBox1.Text = param.Commentaire;
                textBox1.Text = param.Init;
            }
        }
    }
}
