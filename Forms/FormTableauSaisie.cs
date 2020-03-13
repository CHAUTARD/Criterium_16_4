using System;
using System.Drawing;
using System.Windows.Forms;

namespace Criterium_16_4
{
    public partial class FormTableauSaisie : Form
    {
        public FormTableauSaisie(DataGridView dgv)
        {
            InitializeComponent();

            /*
             * Parties avec arbitre, calculé pour que les premier de poule arbitre 1 fois de moins que les autres.
             * 
             * j1;j2:jA
             * 
                3;4;2
                5;6;7
                11;12;10
                13;14;15

                1;4;3
                5;8;6
                9;12;11
                13;16;14

                2;3;1		
                6;7;4
                10;11;5
                14;15;8

                1;8;2
                9;16;7
                4;5;10
                12;13;15

                3;6;9
                11;14;12
                2;7;13
                10;15;16

                1;16;3
                8;9;6
                5;12;11
                4;13;14

                3;14;12
                6;11;4
                7;10;5
                2;15;13

                // 1 seul arbitrage
                1;8;9;16
            */

            // 0  
            dgvParties.Rows.Add("1/8 de Finale", "3-4",   "", "", "", "", "", "/", "/", "/", "/", "/", "0", "0", "0");
            dgvParties.Rows.Add("1/8 de Finale", "5-6",   "", "", "", "", "", "/", "/", "/", "/", "/", "0", "0", "0");
            dgvParties.Rows.Add("1/8 de Finale", "11-12", "", "", "", "", "", "/", "/", "/", "/", "/", "0", "0", "0");
            dgvParties.Rows.Add("1/8 de Finale", "13-14", "", "", "", "", "", "/", "/", "/", "/", "/", "0", "0", "0");

            // 4
            dgvParties.Rows.Add("1/4 de Finale", "1-4",   "", "", "", "", "", "/", "/", "/", "/", "/", "0", "0", "0");
            dgvParties.Rows.Add("1/4 de Finale", "5-8",   "", "", "", "", "", "/", "/", "/", "/", "/", "0", "0", "0");
            dgvParties.Rows.Add("1/4 de Finale", "9-12",  "", "", "", "", "", "/", "/", "/", "/", "/", "0", "0", "0");
            dgvParties.Rows.Add("1/4 de Finale", "13-16", "", "", "", "", "", "/", "/", "/", "/", "/", "0", "0", "0");

            // 8
            dgvParties.Rows.Add("Places 9 à 16", "2-3",   "", "", "", "", "", "/", "/", "/", "/", "/", "0", "0", "0");
            dgvParties.Rows.Add("Places 9 à 16", "6-7",   "", "", "", "", "", "/", "/", "/", "/", "/", "0", "0", "0");
            dgvParties.Rows.Add("Places 9 à 16", "10-11", "", "", "", "", "", "/", "/", "/", "/", "/", "0", "0", "0");
            dgvParties.Rows.Add("Places 9 à 16", "14-15", "", "", "", "", "", "/", "/", "/", "/", "/", "0", "0", "0");

            // 12
            dgvParties.Rows.Add("1/2 de Finale", "1-8",   "", "", "", "", "", "/", "/", "/", "/", "/", "0", "0", "0");
            dgvParties.Rows.Add("1/2 de Finale", "9-16",  "", "", "", "", "", "/", "/", "/", "/", "/", "0", "0", "0");

            dgvParties.Rows.Add("Places 5 à 8", "4-5",    "", "", "", "", "", "/", "/", "/", "/", "/", "0", "0", "0");
            dgvParties.Rows.Add("Places 5 à 8", "12-13",  "", "", "", "", "", "/", "/", "/", "/", "/", "0", "0", "0");

            // 16 
            dgvParties.Rows.Add("Places 9 à 12", "3-6",   "", "", "", "", "", "/", "/", "/", "/", "/", "0", "0", "0");
            dgvParties.Rows.Add("Places 9 à 12", "11-14", "", "", "", "", "", "/", "/", "/", "/", "/", "0", "0", "0");

            dgvParties.Rows.Add("Places 13 à 16", "2-7",   "", "", "", "", "", "/", "/", "/", "/", "/", "0", "0", "0");
            dgvParties.Rows.Add("Places 13 à 16", "10-15", "", "", "", "", "", "/", "/", "/", "/", "/", "0", "0", "0");

            // 20
            dgvParties.Rows.Add("Finale", "1-16", "", "", "", "", "", "/", "/", "/", "/", "/", "0", "0", "0");

            dgvParties.Rows.Add("Places 3 à 4", "8-9",  "", "", "", "", "", "/", "/", "/", "/", "/", "0", "0", "0");
            dgvParties.Rows.Add("Places 5 à 6", "5-12", "", "", "", "", "", "/", "/", "/", "/", "/", "0", "0", "0");
            dgvParties.Rows.Add("Places 7 à 8", "4-13", "", "", "", "", "", "/", "/", "/", "/", "/", "0", "0", "0");

            // 24
            dgvParties.Rows.Add("Places 9 à 10", "3-14",  "", "", "", "", "", "/", "/", "/", "/", "/", "0", "0", "0");
            dgvParties.Rows.Add("Places 11 à 12", "6-11", "", "", "", "", "", "/", "/", "/", "/", "/", "0", "0", "0");
            dgvParties.Rows.Add("Places 13 à 14", "7-10", "", "", "", "", "", "/", "/", "/", "/", "/", "0", "0", "0");
            dgvParties.Rows.Add("Places 15 à 16", "2-15", "", "", "", "", "", "/", "/", "/", "/", "/", "0", "0", "0");

            // dgv "1P1", aJoueur1[0].Nom, clubDA.GetNomByNumero(aJoueur1[0].NumeroClub), "01", aJoueur1[0].Licence.ToString());
            // Positionnement des joueurs dans le tableau
            string sJoueur;
            string sLicence;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                sJoueur = row.Cells[1].Value.ToString();
                sLicence = row.Cells[4].Value.ToString();

                switch(row.Cells[3].Value.ToString())
                {
                    case "01":
                        dgvParties.Rows[4].Cells["ColJoueur1"].Style.BackColor = Color.LightYellow;
                        dgvParties.Rows[4].Cells["ColJoueur1"].Value = sJoueur;
                        dgvParties.Rows[4].Cells["ColLicence1"].Value = sLicence;

                        // Arbitrage
                        dgvParties.Rows[8].Cells["ColJoueurA"].Value = sJoueur;
                        dgvParties.Rows[8].Cells["ColLicenceA"].Value = sLicence;
                        break;

                    case "02":
                        dgvParties.Rows[8].Cells["ColJoueur1"].Style.BackColor = Color.LightCoral;
                        dgvParties.Rows[8].Cells["ColJoueur1"].Value = sJoueur;
                        dgvParties.Rows[8].Cells["ColLicence1"].Value = sLicence;

                        // Arbitrages
                        dgvParties.Rows[0].Cells["ColJoueurA"].Value = sJoueur;
                        dgvParties.Rows[0].Cells["ColLicenceA"].Value = sLicence;
                        dgvParties.Rows[12].Cells["ColJoueurA"].Value = sJoueur;
                        dgvParties.Rows[12].Cells["ColLicenceA"].Value = sLicence;
                        break;

                    case "03":
                        dgvParties.Rows[0].Cells["ColJoueur1"].Style.BackColor = Color.LightCoral;
                        dgvParties.Rows[0].Cells["ColJoueur1"].Value = sJoueur;
                        dgvParties.Rows[0].Cells["ColLicence1"].Value = sLicence;

                        // Arbitrages
                        dgvParties.Rows[4].Cells["ColJoueurA"].Value = sJoueur;
                        dgvParties.Rows[4].Cells["ColLicenceA"].Value = sLicence;
                        dgvParties.Rows[20].Cells["ColJoueurA"].Value = sJoueur;
                        dgvParties.Rows[20].Cells["ColLicenceA"].Value = sLicence;
                        break;

                    case "04":
                        dgvParties.Rows[0].Cells["ColJoueur2"].Style.BackColor = Color.LightGreen;
                        dgvParties.Rows[0].Cells["ColJoueur2"].Value = sJoueur;
                        dgvParties.Rows[0].Cells["ColLicence2"].Value = sLicence;

                        // Arbitrages
                        dgvParties.Rows[9].Cells["ColJoueurA"].Value = sJoueur;
                        dgvParties.Rows[9].Cells["ColLicenceA"].Value = sLicence;
                        dgvParties.Rows[25].Cells["ColJoueurA"].Value = sJoueur;
                        dgvParties.Rows[25].Cells["ColLicenceA"].Value = sLicence;
                        break;

                    case "05":
                        dgvParties.Rows[1].Cells["ColJoueur1"].Style.BackColor = Color.LightGreen;
                        dgvParties.Rows[1].Cells["ColJoueur1"].Value = sJoueur;
                        dgvParties.Rows[1].Cells["ColLicence1"].Value = sLicence;

                        // Arbitrages
                        dgvParties.Rows[10].Cells["ColJoueurA"].Value = sJoueur;
                        dgvParties.Rows[10].Cells["ColLicenceA"].Value = sLicence;
                        dgvParties.Rows[26].Cells["ColJoueurA"].Value = sJoueur;
                        dgvParties.Rows[26].Cells["ColLicenceA"].Value = sLicence;
                        break;

                    case "06":
                        dgvParties.Rows[1].Cells["ColJoueur2"].Style.BackColor = Color.LightCoral;
                        dgvParties.Rows[1].Cells["ColJoueur2"].Value = sJoueur;
                        dgvParties.Rows[1].Cells["ColLicence2"].Value = sLicence;

                        // Arbitrages
                        dgvParties.Rows[5].Cells["ColJoueurA"].Value = sJoueur;
                        dgvParties.Rows[5].Cells["ColLicenceA"].Value = sLicence;
                        dgvParties.Rows[21].Cells["ColJoueurA"].Value = sJoueur;
                        dgvParties.Rows[21].Cells["ColLicenceA"].Value = sLicence;
                        break;

                    case "07":
                        dgvParties.Rows[9].Cells["ColJoueur2"].Style.BackColor = Color.LightCoral;
                        dgvParties.Rows[9].Cells["ColJoueur2"].Value = sJoueur;
                        dgvParties.Rows[9].Cells["ColLicence2"].Value = sLicence;

                        // Arbitrages
                        dgvParties.Rows[1].Cells["ColJoueurA"].Value = sJoueur;
                        dgvParties.Rows[1].Cells["ColLicenceA"].Value = sLicence;
                        dgvParties.Rows[13].Cells["ColJoueurA"].Value = sJoueur;
                        dgvParties.Rows[13].Cells["ColLicenceA"].Value = sLicence;
                        break;

                    case "08":
                        dgvParties.Rows[5].Cells["ColJoueur2"].Style.BackColor = Color.LightBlue;
                        dgvParties.Rows[5].Cells["ColJoueur2"].Value = sJoueur;
                        dgvParties.Rows[5].Cells["ColLicence2"].Value = sLicence;

                        // Arbitrage
                        dgvParties.Rows[11].Cells["ColJoueurA"].Value = sJoueur;
                        dgvParties.Rows[11].Cells["ColLicenceA"].Value = sLicence;
                        break;

                    case "09":
                        dgvParties.Rows[6].Cells["ColJoueur1"].Style.BackColor = Color.LightBlue;
                        dgvParties.Rows[6].Cells["ColJoueur1"].Value = sJoueur;
                        dgvParties.Rows[6].Cells["ColLicence1"].Value = sLicence;

                        // Arbitrage
                        dgvParties.Rows[16].Cells["ColJoueurA"].Value = sJoueur;
                        dgvParties.Rows[16].Cells["ColLicenceA"].Value = sLicence;
                        break;

                    case "10":
                        dgvParties.Rows[10].Cells["ColJoueur1"].Style.BackColor = Color.LightCoral;
                        dgvParties.Rows[10].Cells["ColJoueur1"].Value = sJoueur;
                        dgvParties.Rows[10].Cells["ColLicence1"].Value = sLicence;

                        // Arbitrages
                        dgvParties.Rows[2].Cells["ColJoueurA"].Value = sJoueur;
                        dgvParties.Rows[2].Cells["ColLicenceA"].Value = sLicence;
                        dgvParties.Rows[14].Cells["ColJoueurA"].Value = sJoueur;
                        dgvParties.Rows[14].Cells["ColLicenceA"].Value = sLicence;
                        break;

                    case "11":
                        dgvParties.Rows[2].Cells["ColJoueur1"].Style.BackColor = Color.LightCoral;
                        dgvParties.Rows[2].Cells["ColJoueur1"].Value = sJoueur;
                        dgvParties.Rows[2].Cells["ColLicence1"].Value = sLicence;

                        // Arbitrages
                        dgvParties.Rows[6].Cells["ColJoueurA"].Value = sJoueur;
                        dgvParties.Rows[6].Cells["ColLicenceA"].Value = sLicence;
                        dgvParties.Rows[22].Cells["ColJoueurA"].Value = sJoueur;
                        dgvParties.Rows[22].Cells["ColLicenceA"].Value = sLicence;
                        break;

                    case "12":
                        dgvParties.Rows[2].Cells["ColJoueur2"].Style.BackColor = Color.LightGreen;
                        dgvParties.Rows[2].Cells["ColJoueur2"].Value = sJoueur;
                        dgvParties.Rows[2].Cells["ColLicence2"].Value = sLicence;

                        // Arbitrages
                        dgvParties.Rows[17].Cells["ColJoueurA"].Value = sJoueur;
                        dgvParties.Rows[17].Cells["ColLicenceA"].Value = sLicence;
                        dgvParties.Rows[24].Cells["ColJoueurA"].Value = sJoueur;
                        dgvParties.Rows[24].Cells["ColLicenceA"].Value = sLicence;
                        break;

                    case "13":
                        dgvParties.Rows[3].Cells["ColJoueur1"].Style.BackColor = Color.LightGreen;
                        dgvParties.Rows[3].Cells["ColJoueur1"].Value = sJoueur;
                        dgvParties.Rows[3].Cells["ColLicence1"].Value = sLicence;

                        // Arbitrages
                        dgvParties.Rows[18].Cells["ColJoueurA"].Value = sJoueur;
                        dgvParties.Rows[18].Cells["ColLicenceA"].Value = sLicence;
                        dgvParties.Rows[27].Cells["ColJoueurA"].Value = sJoueur;
                        dgvParties.Rows[27].Cells["ColLicenceA"].Value = sLicence;
                        break;

                    case "14":
                        dgvParties.Rows[3].Cells["ColJoueur2"].Style.BackColor = Color.LightCoral;
                        dgvParties.Rows[3].Cells["ColJoueur2"].Value = sJoueur;
                        dgvParties.Rows[3].Cells["ColLicence2"].Value = sLicence;

                        // Arbitrages
                        dgvParties.Rows[7].Cells["ColJoueurA"].Value = sJoueur;
                        dgvParties.Rows[7].Cells["ColLicenceA"].Value = sLicence;
                        dgvParties.Rows[23].Cells["ColJoueurA"].Value = sJoueur;
                        dgvParties.Rows[23].Cells["ColLicenceA"].Value = sLicence;
                        break;

                    case "15":
                        dgvParties.Rows[11].Cells["ColJoueur2"].Style.BackColor = Color.LightCoral;
                        dgvParties.Rows[11].Cells["ColJoueur2"].Value = sJoueur;
                        dgvParties.Rows[11].Cells["ColLicence2"].Value = sLicence;

                        // Arbitrages
                        dgvParties.Rows[3].Cells["ColJoueurA"].Value = sJoueur;
                        dgvParties.Rows[3].Cells["ColLicenceA"].Value = sLicence;
                        dgvParties.Rows[15].Cells["ColJoueurA"].Value = sJoueur;
                        dgvParties.Rows[15].Cells["ColLicenceA"].Value = sLicence;
                        break;

                    case "16":
                        dgvParties.Rows[7].Cells["ColJoueur2"].Style.BackColor = Color.LightYellow;
                        dgvParties.Rows[7].Cells["ColJoueur2"].Value = sJoueur;
                        dgvParties.Rows[7].Cells["ColLicence2"].Value = sLicence;

                        // Arbitrage
                        dgvParties.Rows[19].Cells["ColJoueurA"].Value = sJoueur;
                        dgvParties.Rows[19].Cells["ColLicenceA"].Value = sLicence;
                        break;
                }
            }
        }

        private int GetRow(string str)
        {
            string[] Parties = {
                "3-4", "5-6", "11-12", "13-14",
                "1-4", "5-8",  "9-12", "13-16",
                "2-3", "6-7", "10-11", "14-15",
                "1-8", "9-16",  "4-5", "12-13",
                "3-6", "11-14", "2-7", "10-15",
                "1-16",  "8-9", "5-12", "4-13",
                "3-14", "6-11", "7-10", "2-15"
            };

            for (int i =0; i < Parties.Length; i++)
            {
                if (str.Equals(Parties[i]))
                    return i;

            }
            return -1;
        }

        private void DispatchResultat(int iRow, bool bAGagne)
        {
            string[] Gagne = {
                 "1-4",  "5-8",  "9-12",  "13-16",
                 "1-8",  "8-9",  "9-16",  "9-16",
                 "3-6",  "3-6",  "11-14",  "11-14",
                 "1-16",  "1-16",  "5-12",  "5-12",
                 "3-14",  "3-14",  "7-10",  "7-10"
            };

            string[] Perdu = {
                "2-3", "6-7", "10-12", "14-15",
                "4-5", "4-5", "12-13", "12-13",
                "2-7", "2-7",  "10-15", "10-15",
                "8-9",  "8-9", "4-13", "4-13",
                "6-11",  "6-11", "2-15",  "2-15"
            };

            // Numero de la ligne dans le tableau = "3-4"
            string sRencontre = dgvParties.Rows[iRow].Cells["ColRencontre"].Value.ToString();

            // sJ[0] = "3";
            // sJ[1] = "4";
            string[] sJ = sRencontre.Split('-');

            // 1-4
            string sGagne = Gagne[iRow];

            // 2-3
            string sPerdu = Perdu[iRow];

            // Rangée pour gagné et perdu
            int iRowGagne = GetRow(sGagne);
            int iRowPerdu = GetRow(sPerdu);

            // Position du joueur dans la nouvelle partie

            // Nom des joueurs A et B
            string sJoueurA = dgvParties.Rows[iRow].Cells["ColJoueur1"].Value.ToString();
            string sJoueurB = dgvParties.Rows[iRow].Cells["ColJoueur2"].Value.ToString();

            // A gagne, B perdu
            if (bAGagne)
            {
                if (sGagne.StartsWith(sJ[0] + "-"))
                    dgvParties.Rows[iRowGagne].Cells["ColJoueur1"].Value = sJoueurA;
                else
                    dgvParties.Rows[iRowGagne].Cells["ColJoueur2"].Value = sJoueurA;

                if (sPerdu.StartsWith(sJ[1] + "-"))
                    dgvParties.Rows[iRowPerdu].Cells["ColJoueur1"].Value = sJoueurB;
                else
                    dgvParties.Rows[iRowPerdu].Cells["ColJoueur2"].Value = sJoueurB;
            }
            else
            // A perdu, B gagne
            {
                if (sGagne.StartsWith(sJ[1] + "-"))
                    dgvParties.Rows[iRowGagne].Cells["ColJoueur1"].Value = sJoueurB;
                else
                    dgvParties.Rows[iRowGagne].Cells["ColJoueur2"].Value = sJoueurB;

                if (sPerdu.StartsWith(sJ[0] + "-"))
                    dgvParties.Rows[iRowPerdu].Cells["ColJoueur1"].Value = sJoueurA;
                else
                    dgvParties.Rows[iRowPerdu].Cells["ColJoueur2"].Value = sJoueurA;
            }
        }

        private void dgvParties_SelectionChanged(object sender, EventArgs e)
        {
            // Regarder si les deux joueurs sont inscript dans la liste
            if (dgvParties.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                int iRow = dgvParties.SelectedRows[0].Index;

                if (dgvParties.Rows[iRow].Cells["ColJoueur1"].Value.ToString() == "" || dgvParties.Rows[iRow].Cells["ColJoueur2"].Value.ToString() == "")
                {
                    dgvParties.ClearSelection();
                }
                else
                {
                    // Saisir la partie
                    CallSaisieScore(iRow);
                }
            }
        }

        void CallSaisieScore(int iRow)
        {
            // Vérification si la ligne et bien une ligne de partie
            if (dgvParties.Rows[iRow].Cells["ColJoueur1"].Value.ToString() == "")
                return;

            if (dgvParties.Rows[iRow].Cells["ColJoueur2"].Value.ToString() == "")
                return;

            // Appel de la Form
            Partie partie = new Partie();

            partie.sPartie = dgvParties.Rows[iRow].Cells["ColRencontre"].Value.ToString();
            partie.Forfait1 = "F".Equals(dgvParties.Rows[iRow].Cells["ColFA1"].Value.ToString());
            partie.Abandon1 = "A".Equals(dgvParties.Rows[iRow].Cells["ColFA1"].Value.ToString());

            partie.SetLicence1(int.Parse(dgvParties.Rows[iRow].Cells["ColLicence1"].Value.ToString()));
            partie.SetLicence2(int.Parse(dgvParties.Rows[iRow].Cells["ColLicence2"].Value.ToString()));
            partie.SetLicenceArbitre(int.Parse(dgvParties.Rows[iRow].Cells["ColLicenceA"].Value.ToString()));

            partie.Forfait2 = "F".Equals(dgvParties.Rows[iRow].Cells["ColFA2"].Value.ToString());
            partie.Abandon2 = "A".Equals(dgvParties.Rows[iRow].Cells["ColFA2"].Value.ToString());

            partie.Score1 = GetDgvScore("ColScore1", iRow);
            partie.Score2 = GetDgvScore("ColScore2", iRow);
            partie.Score3 = GetDgvScore("ColScore3", iRow);
            partie.Score4 = GetDgvScore("ColScore4", iRow);
            partie.Score5 = GetDgvScore("ColScore5", iRow);

            FormSaisieScore frm = new FormSaisieScore(partie);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                // Transfert des scores vers la dataGridView
                string str;

                dgvParties.Rows[iRow].Cells["ColScore1"].Value = frm.GetScore1();
                dgvParties.Rows[iRow].Cells["ColScore2"].Value = frm.GetScore2();
                dgvParties.Rows[iRow].Cells["ColScore3"].Value = frm.GetScore3();

                str = frm.GetScore4();
                if (str.Length == 0)
                    str = "/";
                dgvParties.Rows[iRow].Cells["ColScore4"].Value = str;

                str = frm.GetScore5();
                if (str.Length == 0)
                    str = "/";
                dgvParties.Rows[iRow].Cells["ColScore5"].Value = str;

                // Forfait  joueur1 ou les deux
                if (frm.GetForfait1())
                    dgvParties.Rows[iRow].Cells["ColFA1"].Value = "F";

                if (frm.GetForfait2())
                    dgvParties.Rows[iRow].Cells["ColFA2"].Value = "F";

                if (frm.GetForfait())
                {
                    dgvParties.Rows[iRow].Cells["ColFA1"].Value = "F";
                    dgvParties.Rows[iRow].Cells["ColFA2"].Value = "F";
                }

                // Abandon
                if (frm.GetAbandon1())
                    dgvParties.Rows[iRow].Cells["ColFA1"].Value = "A";

                if (frm.GetAbandon2())
                    dgvParties.Rows[iRow].Cells["ColFA2"].Value = "A";

                if (frm.GetAbandon())
                {
                    dgvParties.Rows[iRow].Cells["ColFA1"].Value = "A";
                    dgvParties.Rows[iRow].Cells["ColFA2"].Value = "A";
                }

                // Grise toute la ligne
                for(int c =0; c < dgvParties.Rows[iRow].Cells.Count; c++)
                    dgvParties.Rows[iRow].Cells[c].Style.BackColor = Color.LightGray;

                // Joueur2 gagne mettre a jour
                if (frm.GetMancheNegative() == 3)
                {
                    DispatchResultat( iRow, false);
                }
                else
                {
                    DispatchResultat( iRow, true);
                }
            }
        }

        int GetDgvScore( string sCol, int iRow)
        {
            if (dgvParties.Rows[iRow].Cells[sCol].Value.ToString() == "/")
                return SingletonOutils.SCORENULL;

            return int.Parse(dgvParties.Rows[iRow].Cells[sCol].Value.ToString());
        }
    }
}
