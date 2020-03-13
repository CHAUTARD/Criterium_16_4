/*
 * Crée par SharpDevelop.
 * Utilisateur: CHAUTARD
 * Date: 06/12/2019
 * Heure: 08:17
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Criterium_16_4
{
    /// <summary>
    /// Description of FormPartieBarrage.
    /// </summary>
    public partial class FormPartieBarrage : Form
    {
        int[] iNombreJoueurPoule = { 4, 4, 4, 4 };

        DataGridView _dgvMainPoule;
        int _iRowactive = 0;

        int[] _aiEgal = { 0, 0, 0 };

        // Calcul des manches
        float[] _afManche = { 0, 0, 0, 0, 0 };

        // Calcul des points
        float[] _afPoint = { 0, 0, 0, 0 };

         // 4 poules avec 6 partie par poule
        private Partie[] _partie = new Partie[24];

        public FormPartieBarrage(DataGridView dgvPoule)
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // Add constructor code after the InitializeComponent() call.
            //

            _dgvMainPoule = dgvPoule;

            Joueur joueur1, joueur2, joueur3;

            int i;

            int indexPartie = 0;

            // Parcours des poules à la recherche du nombre de joueur
            for (int iNumPoule = 0; iNumPoule < 4; iNumPoule++)
            {
                if (dgvPoule[iNumPoule, 2].Value.ToString().CompareTo("---") == 0)
                {
                    iNombreJoueurPoule[iNumPoule] = 1;
                    if (dgvPoule[iNumPoule, 3].Value.ToString().CompareTo("---") == 0)
                    {
                        iNombreJoueurPoule[iNumPoule] = 2;
                        if (dgvPoule[iNumPoule, 4].Value.ToString().CompareTo("---") == 0)
                        {
                            iNombreJoueurPoule[iNumPoule] = 3;
                        }
                    }
                }

                // Par défaut 6 partie par poule
                indexPartie = iNumPoule * 6;

                // Nombre de joueur par poule
                switch (iNombreJoueurPoule[iNumPoule])
                {
                    case 1:
                        // Extraction du numero des joueurs
                        joueur1 = GetJoueurBydgv(iNumPoule, 0);

                        _partie[indexPartie].SetJoueur1(joueur1);

                        // Création des ligne dans la grid
                        switch (iNumPoule)
                        {
                            case 0:
                                dataGridViewScore1.Rows.Add(
                                    "1 - -", " ", joueur1.Nom, "", " ",
                                    "/", "/", "/", "/", "/",
                                    "2", "", "", "", 
                                    joueur1.Licence.ToString(),
                                    SingletonOutils.CELLVIDE,
                                    SingletonOutils.CELLVIDE);

                                // Grise les cellules de points parties non utilisées
                                GrisePointPartie1(dataGridViewScore1);
                                break;

                            case 1:
                                dataGridViewScore2.Rows.Add(
                                    "1 - -", " ", joueur1.Nom, "", " ",
                                    "/", "/", "/", "/", "/",
                                    "2", "", "", "", 
                                    joueur1.Licence.ToString(),
                                    SingletonOutils.CELLVIDE,
                                    SingletonOutils.CELLVIDE);

                                // Grise les cellules de points parties non utilisées
                                GrisePointPartie1(dataGridViewScore2);
                                break;

                            case 2:
                                dataGridViewScore3.Rows.Add(
                                    "1 - -", " ", joueur1.Nom, "", " ",
                                    "/", "/", "/", "/", "/",
                                    "2", "", "", "",
                                    joueur1.Licence.ToString(),
                                    SingletonOutils.CELLVIDE,
                                    SingletonOutils.CELLVIDE);

                                // Grise les cellules de points parties non utilisées
                                GrisePointPartie1(dataGridViewScore3);
                                break;

                            case 3:
                                dataGridViewScore3.Rows.Add(
                                    "1 - -", " ", joueur1.Nom, "", " ",
                                    "/", "/", "/", "/", "/",
                                    "2", "", "", "",
                                    joueur1.Licence.ToString(),
                                    SingletonOutils.CELLVIDE,
                                    SingletonOutils.CELLVIDE);

                                // Grise les cellules de points parties non utilisées
                                GrisePointPartie1(dataGridViewScore4);
                                break;
                        }
                        break;

                    case 2:
                        // 2 Joueurs

                        // Extraction du numero des joueurs
                        joueur1 = GetJoueurBydgv(iNumPoule, 0);
                        joueur2 = GetJoueurBydgv(iNumPoule, 1);

                        // Création des ligne dans la grid
                        switch (iNumPoule)
                        {
                            case 0:
                                dataGridViewScore1.Rows.Add(
                                    "1 - 2", " ", joueur1.Nom, joueur2.Nom, " ",
                                    "/", "/", "/", "/", "/",
                                    "0", "0", "", "", 
                                    joueur1.Licence.ToString(),
                                    joueur2.Licence.ToString(),
                                    SingletonOutils.CELLVIDE
                                );
                                // Grise les cellules de points parties non utilisées
                                dataGridViewScore1.Rows[0].Cells[12].Style.BackColor = Color.Gray; // "0","0",SingletonOutils.CELLVIDE
                                break;

                            case 1:

                                dataGridViewScore2.Rows.Add(
                                    "1 - 2", " ", joueur1.Nom, joueur2.Nom, " ",
                                    "/", "/", "/", "/", "/",
                                    "0", "0", "", "",
                                    joueur1.Licence.ToString(),
                                    joueur2.Licence.ToString(),
                                    SingletonOutils.CELLVIDE
                                );
                                // Grise les cellules de points parties non utilisées
                                dataGridViewScore2.Rows[0].Cells[12].Style.BackColor = Color.Gray; // "0","0","--"
                                break;

                            case 2:

                                dataGridViewScore3.Rows.Add(
                                    "1 - 2", " ", joueur1.Nom, joueur2.Nom, " ",
                                    "/", "/", "/", "/", "/",
                                    "0", "0", "", "",
                                    joueur1.Licence.ToString(),
                                    joueur2.Licence.ToString(),
                                    SingletonOutils.CELLVIDE
                                );
                                // Grise les cellules de points parties non utilisées
                                dataGridViewScore3.Rows[0].Cells[12].Style.BackColor = Color.Gray; // "0","0","--"
                                break;

                            case 3:

                                dataGridViewScore3.Rows.Add(
                                    "1 - 2", " ", joueur1.Nom, joueur2.Nom, " ",
                                    "/", "/", "/", "/", "/",
                                    "0", "0", "", "",
                                    joueur1.Licence.ToString(),
                                    joueur2.Licence.ToString(),
                                    SingletonOutils.CELLVIDE
                                );
                                // Grise les cellules de points parties non utilisées
                                dataGridViewScore4.Rows[0].Cells[12].Style.BackColor = Color.Gray; // "0","0","--"
                                break;
                        }
                        break;

                    case 3:
                        // 3 Joueurs
                        i = 0;

                        foreach (PartieQuiJoue p in SingletonOutils.GetPartie())
                        {
                            // Extraction du numero des joueurs
                            joueur1 = GetJoueurBydgv(iNumPoule, p.iJoueur1);
                            joueur2 = GetJoueurBydgv(iNumPoule, p.iJoueur2);
                            joueur3 = GetJoueurBydgv(iNumPoule, p.iArbitre);

                            switch (iNumPoule)
                            {
                                case 0:
                                    // Création des ligne dans la grid
                                    dataGridViewScore1.Rows.Add(
                                        p.getRencontreArbitre(), " ", joueur1.Nom, joueur2.Nom, " ",
                                        "/", "/", "/", "/", "/",
                                        SingletonOutils.GetPointsParties3()[i,0], SingletonOutils.GetPointsParties3()[i, 1], SingletonOutils.GetPointsParties3()[i, 2], "/",
                                        joueur1.Licence.ToString(),
                                        joueur2.Licence.ToString(),
                                        joueur3.Licence.ToString()
                                    );
                                    break;

                                case 1:
                                    dataGridViewScore2.Rows.Add(
                                         p.getRencontreArbitre(), " ", joueur1.Nom, joueur2.Nom, " ",
                                        "/", "/", "/", "/", "/",
                                        SingletonOutils.GetPointsParties3()[i, 0], SingletonOutils.GetPointsParties3()[i, 1], SingletonOutils.GetPointsParties3()[i, 2], "/",
                                        joueur1.Licence.ToString(),
                                        joueur2.Licence.ToString(),
                                        joueur3.Licence.ToString()
                                    );
                                    break;

                                case 2:
                                    dataGridViewScore3.Rows.Add(
                                         p.getRencontreArbitre(), " ", joueur1.Nom, joueur2.Nom, " ",
                                        "/", "/", "/", "/", "/",
                                        SingletonOutils.GetPointsParties3()[i, 0], SingletonOutils.GetPointsParties3()[i, 1], SingletonOutils.GetPointsParties3()[i, 2], "/",
                                        joueur1.Licence.ToString(),
                                        joueur2.Licence.ToString(),
                                        joueur3.Licence.ToString()
                                    );
                                    break;

                                case 3:
                                    dataGridViewScore3.Rows.Add(
                                         p.getRencontreArbitre(), " ", joueur1.Nom, joueur2.Nom, " ",
                                        "/", "/", "/", "/", "/",
                                        SingletonOutils.GetPointsParties3()[i, 0], SingletonOutils.GetPointsParties3()[i, 1], SingletonOutils.GetPointsParties3()[i, 2], "/",
                                        joueur1.Licence.ToString(),
                                        joueur2.Licence.ToString(),
                                        joueur3.Licence.ToString()
                                    );
                                    break;
                            }
                            i++;
                        }

                        // Grise les cellules de points parties non utilisées
                        switch (iNumPoule)
                        {
                            case 0:
                                GrisePointPartie3(dataGridViewScore1);
                                break;

                            case 1:
                                GrisePointPartie3(dataGridViewScore2);
                                break;

                            case 2:
                                GrisePointPartie3(dataGridViewScore3);
                                break;

                            case 3:
                                GrisePointPartie3(dataGridViewScore4);
                                break;
                        }
                        break;

                    case 4:
                        // 4 Joueurs
                        i = 0;

                        foreach (PartieQuiJoue p in SingletonOutils.GetPartie())
                        {
                            // Extraction du numero des joueurs
                            joueur1 = GetJoueurBydgv(iNumPoule, p.iJoueur1);
                            joueur2 = GetJoueurBydgv(iNumPoule, p.iJoueur2);
                            joueur3 = GetJoueurBydgv(iNumPoule, p.iArbitre);

                            switch (iNumPoule)
                            {
                                case 0:
                                    // Création des ligne dans la grid
                                    dataGridViewScore1.Rows.Add(
                                        p.getRencontreArbitre(), " ", joueur1.Nom, joueur2.Nom, " ",
                                        "/", "/", "/", "/", "/",
                                        SingletonOutils.GetPointsParties4()[i, 0], SingletonOutils.GetPointsParties4()[i, 1], SingletonOutils.GetPointsParties4()[i, 2], SingletonOutils.GetPointsParties4()[i, 3],
                                        joueur1.Licence.ToString(),
                                        joueur2.Licence.ToString(),
                                        joueur3.Licence.ToString()
                                    ); 
                                    break;

                                case 1:
                                    dataGridViewScore2.Rows.Add(
                                        p.getRencontreArbitre(), " ", joueur1.Nom, joueur2.Nom, " ",
                                        "/", "/", "/", "/", "/",
                                        SingletonOutils.GetPointsParties4()[i, 0], SingletonOutils.GetPointsParties4()[i, 1], SingletonOutils.GetPointsParties4()[i, 2], SingletonOutils.GetPointsParties4()[i, 3],
                                        joueur1.Licence.ToString(),
                                        joueur2.Licence.ToString(),
                                        joueur3.Licence.ToString()
                                    );
                                    break;

                                case 2:
                                    dataGridViewScore3.Rows.Add(
                                        p.getRencontreArbitre(), " ", joueur1.Nom, joueur2.Nom, " ",
                                        "/", "/", "/", "/", "/",
                                        SingletonOutils.GetPointsParties4()[i, 0], SingletonOutils.GetPointsParties4()[i, 1], SingletonOutils.GetPointsParties4()[i, 2], SingletonOutils.GetPointsParties4()[i, 3],
                                        joueur1.Licence.ToString(),
                                        joueur2.Licence.ToString(),
                                        joueur3.Licence.ToString()
                                    );
                                    break;

                                case 3:
                                    dataGridViewScore4.Rows.Add(
                                        p.getRencontreArbitre(), " ", joueur1.Nom, joueur2.Nom, " ",
                                        "/", "/", "/", "/", "/",
                                        SingletonOutils.GetPointsParties4()[i, 0], SingletonOutils.GetPointsParties4()[i, 1], SingletonOutils.GetPointsParties4()[i, 2], SingletonOutils.GetPointsParties4()[i, 3],
                                        joueur1.Licence.ToString(),
                                        joueur2.Licence.ToString(),
                                        joueur3.Licence.ToString()
                                    );
                                    break;
                            }
                            i++;
                        }

                        // Grise les cellules de points parties non utilisées
                        switch (iNumPoule)
                        {
                            case 0:
                                GrisePointPartie4(dataGridViewScore1);
                                break;

                            case 1:
                                GrisePointPartie4(dataGridViewScore2);
                                break;

                            case 2:
                                GrisePointPartie4(dataGridViewScore3);
                                break;

                            case 3:
                                GrisePointPartie4(dataGridViewScore4);
                                break;
                        }

                        break;
                }
            }

            // Total points parties
            dataGridViewScore1.Rows.Add("", "", "", "", "", "", "", "", "", "Tot", "", "", "", "", "", "", "");
            dataGridViewScore2.Rows.Add("", "", "", "", "", "", "", "", "", "Tot", "", "", "", "", "", "", "");
            dataGridViewScore3.Rows.Add("", "", "", "", "", "", "", "", "", "Tot", "", "", "", "", "", "", "");
            dataGridViewScore4.Rows.Add("", "", "", "", "", "", "", "", "", "Tot", "", "", "", "", "", "", "");

            // Classement
            dataGridViewScore1.Rows.Add("", "", "", "", "", "", "", "", "", "Cls", "", "", "", "", "", "", "");
            dataGridViewScore2.Rows.Add("", "", "", "", "", "", "", "", "", "Cls", "", "", "", "", "", "", "");
            dataGridViewScore3.Rows.Add("", "", "", "", "", "", "", "", "", "Cls", "", "", "", "", "", "", "");
            dataGridViewScore4.Rows.Add("", "", "", "", "", "", "", "", "", "Cls", "", "", "", "", "", "", "");
        }

        // Mise en couleur du header des tab
        void TCPouleDrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage page = tCPoule.TabPages[e.Index];
            e.Graphics.FillRectangle(new SolidBrush(page.BackColor), e.Bounds);

            Rectangle paddedBounds = e.Bounds;
            int yOffset = (e.State == DrawItemState.Selected) ? -2 : 1;
            paddedBounds.Offset(1, yOffset);
            TextRenderer.DrawText(e.Graphics, page.Text, Font, paddedBounds, page.ForeColor);
        }

        #region Grise Cell
        // Grise les cellules points parties non utilisées
        void GrisePointPartie1(DataGridView dgv)
        {
            dgv.Rows[0].Cells[11].Style.BackColor = Color.Gray;
            dgv.Rows[0].Cells[12].Style.BackColor = Color.Gray;
            dgv.Rows[0].Cells[13].Style.BackColor = Color.Gray;
        }

        void GrisePointPartie3(DataGridView dgv)
        {
            dgv.Rows[0].Cells[11].Style.BackColor = Color.Gray; // "0","--","0"
            dgv.Rows[1].Cells[10].Style.BackColor = Color.Gray; // "--","0","0"
            dgv.Rows[2].Cells[12].Style.BackColor = Color.Gray; // "0","0","--"
        }

        void GrisePointPartie4(DataGridView dgv)
        {
            dgv.Rows[0].Cells[11].Style.BackColor = Color.Gray; // "0","--","--","0"
            dgv.Rows[0].Cells[12].Style.BackColor = Color.Gray;

            dgv.Rows[1].Cells[10].Style.BackColor = Color.Gray; // "--","0","0","--"
            dgv.Rows[1].Cells[13].Style.BackColor = Color.Gray;

            dgv.Rows[2].Cells[11].Style.BackColor = Color.Gray; // "0","--","0","--"
            dgv.Rows[2].Cells[13].Style.BackColor = Color.Gray;

            dgv.Rows[3].Cells[10].Style.BackColor = Color.Gray; // "--","0","--","0"
            dgv.Rows[3].Cells[12].Style.BackColor = Color.Gray;

            dgv.Rows[4].Cells[12].Style.BackColor = Color.Gray; // "0","0","--","--"
            dgv.Rows[4].Cells[13].Style.BackColor = Color.Gray;

            dgv.Rows[5].Cells[10].Style.BackColor = Color.Gray; //  "--","--","0","0"
            dgv.Rows[5].Cells[11].Style.BackColor = Color.Gray;
        }
        #endregion

        /* Recherche de l'objet Joueur à partir du nom et prénom de la Grid
		 * 
		 * iNumPoule = ( 0, 1, 2, 3 )
		 */
        Joueur GetJoueurBydgv(int iNumPoule, int iNum)
        {
            // Découpage du nom et du club
            string[] stringSeparators = new string[] { "\r\n" };
            string[] lines = _dgvMainPoule[iNumPoule, iNum - 1].Value.ToString().Split(stringSeparators, StringSplitOptions.None);

            // Recherche de l'objet Joueur
            return SingletonOutils.ListJoueurs.Find(x => x.Nom.Contains(lines[0]));
        }

        void CallSaisieScore(DataGridView dgvScore)
        {
            _iRowactive = dgvScore.CurrentRow.Index;

            // Vérification si la ligne et bien une ligne de partie
            if (dgvScore.Rows[_iRowactive].Cells[2].Value.ToString() == "")
                return;

            // Appel de la Form
            Partie partie = new Partie();

            partie.sPartie = dgvScore[0, _iRowactive].Value.ToString();
            partie.Forfait1 = String.Compare(dgvScore[1, _iRowactive].Value.ToString(), "F") != 0;
            partie.Abandon1 = String.Compare(dgvScore[1, _iRowactive].Value.ToString(), "A") != 0;

            partie.SetLicence1(Int32.Parse(dgvScore[14, _iRowactive].Value.ToString()));
            partie.SetLicence2(Int32.Parse(dgvScore[15, _iRowactive].Value.ToString()));
            partie.SetLicenceArbitre(Int32.Parse(dgvScore[16, _iRowactive].Value.ToString()));

            partie.Forfait2 = String.Compare(dgvScore[4, _iRowactive].Value.ToString(), "F") != 0;
            partie.Abandon2 = String.Compare(dgvScore[4, _iRowactive].Value.ToString(), "A") != 0;

            partie.Score1 = GetDgvScore(dgvScore, 5, _iRowactive);
            partie.Score2 = GetDgvScore(dgvScore, 6, _iRowactive);
            partie.Score3 = GetDgvScore(dgvScore, 7, _iRowactive);
            partie.Score4 = GetDgvScore(dgvScore, 8, _iRowactive);
            partie.Score5 = GetDgvScore(dgvScore, 9, _iRowactive);

            FormSaisieScore frm = new FormSaisieScore(partie);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                // Transfert des scores vers la dataGridView
                bool bJoueur1Forfait = false;
                bool bJoueur2Forfait = false;

                bool bJoueur1Abandon = false;
                bool bJoueur2Abandon = false;
                string str;

                dgvScore[5, _iRowactive].Value = frm.GetScore1();
                dgvScore[6, _iRowactive].Value = frm.GetScore2();
                dgvScore[7, _iRowactive].Value = frm.GetScore3();

                str = frm.GetScore4();
                if (str.Length == 0)
                    str = "/";
                dgvScore[8, _iRowactive].Value = str;

                str = frm.GetScore5();
                if (str.Length == 0)
                    str = "/";
                dgvScore[9, _iRowactive].Value = str;

                // Forfait  joueur1 ou les deux
                if (frm.GetForfait1())
                {
                    dgvScore[1, _iRowactive].Value = "F";
                    bJoueur1Forfait = true;
                }

                if (frm.GetForfait2())
                {
                    dgvScore[4, _iRowactive].Value = "F";
                    bJoueur2Forfait = true;
                }

                if (frm.GetForfait())
                {
                    dgvScore[1, _iRowactive].Value = "F";
                    dgvScore[4, _iRowactive].Value = "F";
                    bJoueur1Forfait = true;
                    bJoueur2Forfait = true;
                }

                // Abandon
                if (frm.GetAbandon1())
                {
                    dgvScore[1, _iRowactive].Value = "A";
                    bJoueur1Abandon = true;
                }

                if (frm.GetAbandon2())
                {
                    dgvScore[4, _iRowactive].Value = "A";
                    bJoueur2Abandon = true;
                }

                if (frm.GetAbandon())
                {
                    dgvScore[1, _iRowactive].Value = "A";
                    dgvScore[4, _iRowactive].Value = "A";
                    bJoueur1Abandon = true;
                    bJoueur2Abandon = true;
                }

                bool bB = true;
                int icc = 10;

                // Joueur2 gagne mettre a jour 10 à 13
                if (frm.GetMancheNegative() == 3)
                {
                    // Premier = 0 ou 1
                    while (icc <= 13)
                    {
                        if (dgvScore.Rows[_iRowactive].Cells[icc].Style.BackColor != Color.Gray)
                        {
                            if (bB)
                            {
                                if (bJoueur1Forfait || bJoueur1Abandon)
                                    dgvScore.Rows[_iRowactive].Cells[icc].Value = "0";
                                else
                                    dgvScore.Rows[_iRowactive].Cells[icc].Value = "1";
                                bB = false;
                            }
                            else
                            {
                                if (bJoueur2Forfait || bJoueur2Abandon)
                                    dgvScore.Rows[_iRowactive].Cells[icc].Value = "0";
                                else
                                    dgvScore.Rows[_iRowactive].Cells[icc].Value = "2";
                                icc = 99;
                            }
                        }
                        icc++;
                    }
                }
                else
                {
                    // Deuxieme 0 ou 1
                    while (icc <= 13)
                    {
                        if (dgvScore.Rows[_iRowactive].Cells[icc].Style.BackColor != Color.Gray)
                        {
                            if (bB)
                            {
                                if (bJoueur1Forfait || bJoueur1Abandon)
                                    dgvScore.Rows[_iRowactive].Cells[icc].Value = "0";
                                else
                                    dgvScore.Rows[_iRowactive].Cells[icc].Value = "2";
                                bB = false;
                            }
                            else
                            {
                                if (bJoueur2Forfait || bJoueur2Abandon)
                                    dgvScore.Rows[_iRowactive].Cells[icc].Value = "0";
                                else
                                    dgvScore.Rows[_iRowactive].Cells[icc].Value = "1";
                                icc = 99;
                            }
                        }
                        icc++;
                    }
                }
            }
        }

        int GetDgvScore(DataGridView dgvScore, int iCol, int iRow)
        {
            if (dgvScore[iCol, iRow].Value.ToString() == "/")
                return SingletonOutils.SCORENULL;

            return Int32.Parse(dgvScore[iCol, iRow].Value.ToString());
        }

        private void ButtonRemplir_Click(object sender, EventArgs e)
        {
            string str;
            int iManchePerdu;
            int[,] arScore = {
                { 12,-07, 03, 08, 99},
                { 05, 03,-02,-10, 02},
                { 07, 10, 12, 99, 99},
                {-13,-04, 13, 12, 07},
                { 08,-13, 07, 07, 99},
                {-03, 05, 07,-03, 00},

                {-03, 07,-03,-07, 99},
                { 03,-07,-08, 05, 03},
                { 06,-14, 12, 13, 99},
                { 10, 08,-10,-07, 08},
                {-03,-02,-07, 99, 99},
                { 07,-08, 09, 10, 99},

                { 03, 12, 04, 99, 99},
                {-10,-07, 07,-03, 99},
                {-09, 04, 10, 10, 99},
                { 07, 05,-08,-12, 13},
                { 07,-06,-07,-08, 99},
                { 02, 07,-10, 08, 99},

                { 02, 07,-09, 10, 99},
                { 13, 16, 08, 99, 99},
                { 02,-05,-07,-09, 99},
                {-08,-07,-05, 99, 99},
                { 03, 04, 09, 99, 99},
                { 04,-09, 07,-13, 13}
            };

            // Cellule à remplir dans le gridView pour les parties
            int[,] ariPointsCol = { { 10, 13 }, { 11, 12 }, { 10, 12 }, { 11, 13 }, { 10, 11 }, { 12, 13 } };

            // Boucle sur le tableau des scores
            for (int iPartie = 0; iPartie < 24; iPartie++)
            {
                // Points parties en fonction du nombre de manche gagné ou Perdu
                iManchePerdu = 0;

                // Boucle sur les manches
                for (int iManche = 0; iManche < 5; iManche++)
                {
                    if (arScore[iPartie, iManche] == 99)
                        str = "/";
                    else
                        str = arScore[iPartie, iManche].ToString();

                    // Remplissage du grid des points partie
                    switch (iPartie)
                    {
                        case 0:
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                            dataGridViewScore1[iManche + 5, iPartie].Value = str;
                            break;

                        case 6:
                        case 7:
                        case 8:
                        case 9:
                        case 10:
                        case 11:
                            dataGridViewScore2[iManche + 5, iPartie - 6].Value = str;
                            break;

                        case 12:
                        case 13:
                        case 14:
                        case 15:
                        case 16:
                        case 17:
                            dataGridViewScore3[iManche + 5, iPartie - 12].Value = str;
                            break;

                        case 18:
                        case 19:
                        case 20:
                        case 21:
                        case 22:
                        case 23:
                            dataGridViewScore4[iManche + 5, iPartie - 18].Value = str;
                            break;
                    }

                    // Si valeur négative maznche pedu
                    if (arScore[iPartie, iManche] < 0) iManchePerdu++;
                }

                switch (iPartie)
                {
                    case 0: // 5 première partie
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        if (iManchePerdu == 3)
                        {
                            dataGridViewScore1[ariPointsCol[iPartie, 0], iPartie].Value = "1";
                            dataGridViewScore1[ariPointsCol[iPartie, 1], iPartie].Value = "2";
                            dataGridViewScore1[ariPointsCol[iPartie, 1], iPartie].Style.BackColor = Color.LightGreen;
                            dataGridViewScore1[3, iPartie].Style.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            dataGridViewScore1[ariPointsCol[iPartie, 0], iPartie].Value = "2";
                            dataGridViewScore1[ariPointsCol[iPartie, 1], iPartie].Value = "1";
                            dataGridViewScore1[ariPointsCol[iPartie, 0], iPartie].Style.BackColor = Color.LightGreen;
                            dataGridViewScore1[2, iPartie].Style.BackColor = Color.LightGreen;
                        }
                        break;

                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                    case 11:
                        if (iManchePerdu == 3)
                        {
                            dataGridViewScore2[ariPointsCol[iPartie - 6, 0], iPartie - 6].Value = "1";
                            dataGridViewScore2[ariPointsCol[iPartie - 6, 1], iPartie - 6].Value = "2";
                            dataGridViewScore2[ariPointsCol[iPartie - 6, 1], iPartie - 6].Style.BackColor = Color.LightGreen;
                            dataGridViewScore2[3, iPartie - 6].Style.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            dataGridViewScore2[ariPointsCol[iPartie - 6, 0], iPartie - 6].Value = "2";
                            dataGridViewScore2[ariPointsCol[iPartie - 6, 1], iPartie - 6].Value = "1";
                            dataGridViewScore2[ariPointsCol[iPartie - 6, 0], iPartie - 6].Style.BackColor = Color.LightGreen;
                            dataGridViewScore2[2, iPartie - 6].Style.BackColor = Color.LightGreen;
                        }
                        break;

                    case 12:
                    case 13:
                    case 14:
                    case 15:
                    case 16:
                    case 17:
                        if (iManchePerdu == 3)
                        {
                            dataGridViewScore3[ariPointsCol[iPartie - 12, 0], iPartie - 12].Value = "1";
                            dataGridViewScore3[ariPointsCol[iPartie - 12, 1], iPartie - 12].Value = "2";
                            dataGridViewScore3[ariPointsCol[iPartie - 12, 1], iPartie - 12].Style.BackColor = Color.LightGreen;
                            dataGridViewScore3[3, iPartie - 12].Style.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            dataGridViewScore3[ariPointsCol[iPartie - 12, 0], iPartie - 12].Value = "2";
                            dataGridViewScore3[ariPointsCol[iPartie - 12, 1], iPartie - 12].Value = "1";
                            dataGridViewScore3[ariPointsCol[iPartie - 12, 0], iPartie - 12].Style.BackColor = Color.LightGreen;
                            dataGridViewScore3[2, iPartie - 12].Style.BackColor = Color.LightGreen;
                        }
                        break;

                    case 18:
                    case 19:
                    case 20:
                    case 21:
                    case 22:
                    case 23:
                        if (iManchePerdu == 3)
                        {
                            dataGridViewScore4[ariPointsCol[iPartie - 18, 0], iPartie - 18].Value = "1";
                            dataGridViewScore4[ariPointsCol[iPartie - 18, 1], iPartie - 18].Value = "2";
                            dataGridViewScore4[ariPointsCol[iPartie - 18, 1], iPartie - 18].Style.BackColor = Color.LightGreen;
                            dataGridViewScore4[3, iPartie - 18].Style.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            dataGridViewScore4[ariPointsCol[iPartie - 18, 0], iPartie - 18].Value = "2";
                            dataGridViewScore4[ariPointsCol[iPartie - 18, 1], iPartie - 18].Value = "1";
                            dataGridViewScore4[ariPointsCol[iPartie - 18, 0], iPartie - 18].Style.BackColor = Color.LightGreen;
                            dataGridViewScore4[2, iPartie - 18].Style.BackColor = Color.LightGreen;
                        }
                        break;
                }
                BoutonClassement.Enabled = true;
            }
        }

        private void BoutonClassement_Click(object sender, EventArgs e)
        {
            // Initialisation des poules
            GerePoule gerePoule1 = new GerePoule('A', txtRapport1, dataGridViewScore1);
            GerePoule gerePoule2 = new GerePoule('B', txtRapport2, dataGridViewScore2);
            GerePoule gerePoule3 = new GerePoule('C', txtRapport3, dataGridViewScore3);
            GerePoule gerePoule4 = new GerePoule('D', txtRapport4, dataGridViewScore4);

            // Remplissage avec les joueurs
            for (int iJ = 0; iJ < 4; iJ++)
            {
                gerePoule1.InitJoueurByname(SingletonOutils.ListJoueurs, _dgvMainPoule[0, iJ].Value.ToString());
                gerePoule2.InitJoueurByname(SingletonOutils.ListJoueurs, _dgvMainPoule[1, iJ].Value.ToString());
                gerePoule3.InitJoueurByname(SingletonOutils.ListJoueurs, _dgvMainPoule[2, iJ].Value.ToString());
                gerePoule4.InitJoueurByname(SingletonOutils.ListJoueurs, _dgvMainPoule[3, iJ].Value.ToString());
            }

            Joueur[] aJoueur = null;
            Joueur[] aJoueur1 = null;
            Joueur[] aJoueur2 = null;
            Joueur[] aJoueur3 = null;
            Joueur[] aJoueur4 = null;

            aJoueur1 = gerePoule1.Classement();
            aJoueur2 = gerePoule2.Classement();
            aJoueur3 = gerePoule3.Classement();
            aJoueur4 = gerePoule4.Classement();

            /* 
			 * Mise à jour de la liste des joueurs avec leurs poules et leurs classements dans la poule
			 * 
			 */

            // Affichage de la formTableau
            FormTableau frmT = new FormTableau(aJoueur1, aJoueur2, aJoueur3, aJoueur4);
            frmT.ShowDialog();

            // Tirage au sort pour le premier de poule 3 : si true = 8 sinon 9
            bool bPremierPouletrois = true;

            // Tirage au sort pour le deuxième de la poule 1 : si True 12 sinon 13
            bool bDeuxiemePouleUn = true;

            // Tirage au sort pour le deuxième de la poule 2 : si True 4 sinon 5
            bool bDeuxiemePouleDeux = true;

            // Tirage au sort pour le troisième de la poule 1 : si True 11 sinon 14
            bool bTroisiemePouleUn = true;

            // Tirage au sort pour le troisième de la poule 2 : si True 3 sinon 6
            bool bTroisiemePouleDeux = true;

            // Tirage au sort pour le quatrième de la poule 1 : si True 2 sinon 7
            bool bQuatriemePouleUn = true;

            // Tirage au sort pour le quatrième de la poule 2 : si True 10 sinon 15
            bool bQuatriemePouleDeux = true;

            // Boucle sur les poules
            for (int k = 0; k < 4; k++)
            {
                switch (k)
                {
                    case 0:
                        aJoueur = aJoueur1;
                        break;

                    case 1:
                        aJoueur = aJoueur2;
                        break;

                    case 2:
                        aJoueur = aJoueur3;
                        break;

                    case 3:
                        aJoueur = aJoueur4;
                        break;
                }

                for (int j = 0; j < 4; j++)
                {
                    for (int i = 0; i < SingletonOutils.ListJoueurs.Count; i++)
                    {
                        // Recherche du joueur dans la liste
                        if (SingletonOutils.ListJoueurs[i].Numero == aJoueur[j].Numero)
                        {
                            // et mise à jour du classement
                            SingletonOutils.ListJoueurs[i].Poule = aJoueur[j].Poule;
                            SingletonOutils.ListJoueurs[i].NumInPoule = j + 1;

                            // Classement dans le tableau
                            switch (aJoueur[j].Poule)
                            {
                                case 'A': // Poule 1 : P1
                                    switch (j)
                                    {
                                        case 1:
                                            SingletonOutils.ListJoueurs[i].Classement = 1;
                                            break;

                                        case 2:
                                            if (bDeuxiemePouleUn)
                                                SingletonOutils.ListJoueurs[i].Classement = 12;
                                            else
                                                SingletonOutils.ListJoueurs[i].Classement = 13;
                                            break;

                                        case 3:
                                            if (bTroisiemePouleUn)
                                                SingletonOutils.ListJoueurs[i].Classement =11;
                                            else
                                                SingletonOutils.ListJoueurs[i].Classement =14;
                                            break;

                                        case 4:
                                            if (bQuatriemePouleUn)
                                                SingletonOutils.ListJoueurs[i].Classement =2;
                                            else
                                                SingletonOutils.ListJoueurs[i].Classement =7;
                                            break;
                                    }
                                    break;

                                case 'B': // poule deux P2
                                    switch (j)
                                    {
                                        case 1:
                                            SingletonOutils.ListJoueurs[i].Classement =16;
                                            break;

                                        case 2:
                                            if (bDeuxiemePouleDeux)
                                                SingletonOutils.ListJoueurs[i].Classement =4;
                                            else
                                                SingletonOutils.ListJoueurs[i].Classement =5;
                                            break;

                                        case 3:
                                            if (bTroisiemePouleDeux)
                                                SingletonOutils.ListJoueurs[i].Classement =3;
                                            else
                                                SingletonOutils.ListJoueurs[i].Classement =6;
                                            break;

                                        case 4:
                                            if (bQuatriemePouleDeux)
                                                SingletonOutils.ListJoueurs[i].Classement =10;
                                            else
                                                SingletonOutils.ListJoueurs[i].Classement =15;
                                            break;

                                    }
                                    break;

                                case 'C': // Poule 3 P3
                                    switch (j)
                                    {
                                        case 1:
                                            // Tirage au sort entre 8 et 9
                                            if (bPremierPouletrois)
                                                SingletonOutils.ListJoueurs[i].Classement =8;
                                            else
                                                SingletonOutils.ListJoueurs[i].Classement =9;
                                            break;

                                        case 2:
                                            if (bDeuxiemePouleDeux)
                                                SingletonOutils.ListJoueurs[i].Classement =5;
                                            else
                                                SingletonOutils.ListJoueurs[i].Classement =4;
                                            break;

                                        case 3:
                                            if (bTroisiemePouleDeux)
                                                SingletonOutils.ListJoueurs[i].Classement =6;
                                            else
                                                SingletonOutils.ListJoueurs[i].Classement =3;
                                            break;

                                        case 4:
                                            if (bQuatriemePouleDeux)
                                                SingletonOutils.ListJoueurs[i].Classement =15;
                                            else
                                                SingletonOutils.ListJoueurs[i].Classement =10;
                                            break;
                                    }
                                    break;

                                case 'D': // Poule 4 P4
                                    switch (j)
                                    {
                                        case 1:
                                            if (bPremierPouletrois)
                                                SingletonOutils.ListJoueurs[i].Classement =9;
                                            else
                                                SingletonOutils.ListJoueurs[i].Classement =8;
                                            break;

                                        case 2:
                                            if (bDeuxiemePouleUn)
                                                SingletonOutils.ListJoueurs[i].Classement =13;
                                            else
                                                SingletonOutils.ListJoueurs[i].Classement =12;
                                            break;

                                        case 3:
                                            if (bTroisiemePouleUn)
                                                SingletonOutils.ListJoueurs[i].Classement =14;
                                            else
                                                SingletonOutils.ListJoueurs[i].Classement =11;
                                            break;

                                        case 4:
                                            if (bQuatriemePouleUn)
                                                SingletonOutils.ListJoueurs[i].Classement =7;
                                            else
                                                SingletonOutils.ListJoueurs[i].Classement =2;
                                            break;

                                    }
                                    break;
                            } // switch( aJoueur[j].Poule )
                        } // if( SingletonOutils.ListJoueurs[i].Numero == aJoueur[j].Numero )
                    } // for int i
                } // for int j
            } // for k
        }

        /*------------------------------------------------
		 *	 Fonction générique au quatre onglets
		 *------------------------------------------------
		 */

        // Calcul le quotient victoire sur défaite pour trois joueurs
        private float[] CalculManche3(DataGridView dgv, RichTextBox txtRapport, int a, int b, int c)
        {
            Manche macheAB = new Manche(dgv, txtRapport);
            Manche macheAC = new Manche(dgv, txtRapport);
            Manche macheBC = new Manche(dgv, txtRapport);

            macheAB.CalculeManche(a, b);
            macheAC.CalculeManche(a, c);
            macheBC.CalculeManche(b, c);

            //							 null,j1,J2,J3,J4
            float[] fRet = new float[] { 0, 0, 0, 0, 0 };

            fRet[1] = (float)(macheAB.getMancheGagneA() + macheAC.getMancheGagneA()) / (float)(macheAB.getManchePerduA() + macheAC.getManchePerduA());
            fRet[2] = (float)(macheAB.getMancheGagneB() + macheAC.getMancheGagneA()) / (float)(macheAB.getManchePerduB() + macheAC.getManchePerduA());
            fRet[3] = (float)(macheAC.getMancheGagneB() + macheBC.getMancheGagneB()) / (float)(macheAC.getManchePerduB() + macheBC.getManchePerduB());

            setTextRapport(txtRapport, "CALCUL DES MANCHES (3)", true);
            setTextRapport(txtRapport, "+--------------+----+----+----+");
            setTextRapport(txtRapport, "| Joueur       |  " + string.Format("{0:#} |  {1:#} |  {2:#} |", a, b, c));
            setTextRapport(txtRapport, "+--------------+----+----+----+");
            setTextRapport(txtRapport, "| Gagné        |  " + string.Format("{0:###} |  {1:###} |  {2:###} |",
                                                                             macheAB.getMancheGagneA() + macheAB.getMancheGagneA(),
                                                                             macheAB.getMancheGagneB() + macheAC.getMancheGagneA(),
                                                                             macheAC.getMancheGagneB() + macheAC.getMancheGagneB()));
            setTextRapport(txtRapport, "+--------------+----+----+----+");
            setTextRapport(txtRapport, "| Perdu        |  " + string.Format("{0:###} |  {1:###} |  {2:###} |",
                                                                             macheAB.getManchePerduA(),
                                                                             macheAB.getManchePerduB(),
                                                                             macheAC.getManchePerduB()));
            setTextRapport(txtRapport, "+--------------+----+----+----+");
            setTextRapport(txtRapport, "| Verification |" + string.Format("    {0:###} |   {1:###} |",
                                                                           macheAB.getMancheGagneA() + macheAB.getMancheGagneB() + macheAC.getMancheGagneB(),
                                                                           macheAB.getManchePerduA() + macheAB.getManchePerduB() + macheAC.getManchePerduB()));
            setTextRapport(txtRapport, "+--------------+------+------+");
            setTextRapport(txtRapport, "| Quotient     |" + string.Format(" {0:#.###}|{1:0.###}|{2:0.###}|", fRet[a], fRet[b], fRet[c]));
            setTextRapport(txtRapport, "+--------------+------+------+");

            return fRet;
        }


        // Affiche le rapport du traitement
        void setTextRapport(RichTextBox txtRapport, string sText, bool bold = false) { SingletonOutils.setTextRapport(txtRapport, sText, bold); }

        /*------------------------------------------------
		 *		  Fonctions de contôle
		 *------------------------------------------------
		 */
        void DumpPointJoueur(RichTextBox txtRapport, string sTitre, PointsJoueur[] pj)
        {
            setTextRapport(txtRapport, sTitre, true);
            setTextRapport(txtRapport, "+---+---+");
            setTextRapport(txtRapport, "| " + pj[0].GetNumJoueur() + " | " + pj[0].GetPoint() + " |");
            setTextRapport(txtRapport, "+---+---+");
            setTextRapport(txtRapport, "| " + pj[1].GetNumJoueur() + " | " + pj[1].GetPoint() + " |");
            setTextRapport(txtRapport, "+---+---+");
            setTextRapport(txtRapport, "| " + pj[2].GetNumJoueur() + " | " + pj[2].GetPoint() + " |");
            setTextRapport(txtRapport, "+---+---+");
            setTextRapport(txtRapport, "| " + pj[3].GetNumJoueur() + " | " + pj[3].GetPoint() + " |");
            setTextRapport(txtRapport, "+---+---+");
            setTextRapport(txtRapport, "| " + pj[4].GetNumJoueur() + " | " + pj[4].GetPoint() + " |");
            setTextRapport(txtRapport, "+---+---+");
        }

        void DumpEgal(RichTextBox txtRapport)
        {
            setTextRapport(txtRapport, "EGALITE", true);
            setTextRapport(txtRapport, "+---+---+---+");
            setTextRapport(txtRapport, "| " + _aiEgal[0] + " | " + _aiEgal[1] + " | " + +_aiEgal[2] + " | " + " |");
            setTextRapport(txtRapport, "+---+---+---+");
        }

        #region DataGridViewMousseDown
        private void dataGridViewScore1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (e.Button == MouseButtons.Right)
            {
                // Marquer le partie comme en cours 
                dataGridViewScore1.ClearSelection();
                dataGridViewScore1.Rows[e.RowIndex].Selected = true;

                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Partie en cour", MenuItemEnCour1_Click));
                m.MenuItems.Add(new MenuItem("Effacer en cour", MenuItemEnCour1Clear_Click));

                m.Show(dataGridViewScore1, new Point(e.X, e.Y));
            }
            else
            {
                CallSaisieScore(dataGridViewScore1);
            }
        }

        // La sélection de la row change
        private void dataGridViewScore2_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (e.Button == MouseButtons.Right)
            {
                // Marquer le partie comme en cours 
                dataGridViewScore2.ClearSelection();
                dataGridViewScore2.Rows[e.RowIndex].Selected = true;

                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Partie en cour", MenuItemEnCour2_Click));
                m.MenuItems.Add(new MenuItem("Effacer en cour", MenuItemEnCour2Clear_Click));

                m.Show(dataGridViewScore2, new Point(e.X, e.Y));
            }
            else
            {
                CallSaisieScore(dataGridViewScore2);
            }
        }

        private void dataGridViewScore3_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (e.Button == MouseButtons.Right)
            {
                // Marquer le partie comme en cours 
                dataGridViewScore3.ClearSelection();
                dataGridViewScore3.Rows[e.RowIndex].Selected = true;

                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Partie en cour", MenuItemEnCour3_Click));
                m.MenuItems.Add(new MenuItem("Effacer en cour", MenuItemEnCour3Clear_Click));

                m.Show(dataGridViewScore3, new Point(e.X, e.Y));
            }
            else
            {
                CallSaisieScore(dataGridViewScore3);
            }
        }

        private void dataGridViewScore4_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (e.Button == MouseButtons.Right)
            {
                // Marquer le partie comme en cours 
                dataGridViewScore4.ClearSelection();
                dataGridViewScore4.Rows[e.RowIndex].Selected = true;

                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Partie en cour", MenuItemEnCour4_Click));
                m.MenuItems.Add(new MenuItem("Effacer en cour", MenuItemEnCour4Clear_Click));

                m.Show(dataGridViewScore4, new Point(e.X, e.Y));  
            }
            else
            {
                CallSaisieScore(dataGridViewScore4);
            }
        }

        #region MenuItemAction
        private void MenuItemEnCour1_Click(Object sender, System.EventArgs e)
        {
            CallPartieEnCour(dataGridViewScore1);
        }

        private void MenuItemEnCour1Clear_Click(Object sender, System.EventArgs e)
        {
            CallClearPartieEnCour(dataGridViewScore1);
        }

        private void MenuItemEnCour2_Click(Object sender, System.EventArgs e)
        {
            CallPartieEnCour(dataGridViewScore2);
        }

        private void MenuItemEnCour2Clear_Click(Object sender, System.EventArgs e)
        {
            CallClearPartieEnCour(dataGridViewScore2);
        }

        private void MenuItemEnCour3_Click(Object sender, System.EventArgs e)
        {
            CallPartieEnCour(dataGridViewScore3);
        }

        private void MenuItemEnCour3Clear_Click(Object sender, System.EventArgs e)
        {
            CallClearPartieEnCour(dataGridViewScore3);
        }

        private void MenuItemEnCour4_Click(Object sender, System.EventArgs e)
        {
            CallPartieEnCour(dataGridViewScore4);
        }

        private void MenuItemEnCour4Clear_Click(Object sender, System.EventArgs e)
        {
            CallClearPartieEnCour(dataGridViewScore4);
        }

        void CallPartieEnCour(DataGridView dgvScore, int iEtat = 1)
        {
            int iRowactive = dgvScore.CurrentRow.Index;

            // Vérification si la ligne et bien une ligne de partie
            if (dgvScore.Rows[iRowactive].Cells[2].Value == null || dgvScore.Rows[iRowactive].Cells[2].Value.ToString() == "")
                return;

            // Modification de la table arbitrage
            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.BeginTransaction();

                if (dgvScore.Rows[iRowactive].Cells[14].Value.ToString().CompareTo(SingletonOutils.CELLVIDE) != 0)
                    db.Execute("UPDATE Joueurs SET EnCour = @0 WHERE Licence = @1", iEtat, dgvScore.Rows[iRowactive].Cells[14].Value.ToString());
                if (dgvScore.Rows[iRowactive].Cells[15].Value.ToString().CompareTo(SingletonOutils.CELLVIDE) != 0)
                    db.Execute("UPDATE Joueurs SET EnCour = @0 WHERE Licence = @1", iEtat, dgvScore.Rows[iRowactive].Cells[15].Value.ToString());
                if (dgvScore.Rows[iRowactive].Cells[16].Value.ToString().CompareTo(SingletonOutils.CELLVIDE) != 0)
                    db.Execute("UPDATE Joueurs SET EnArbitrage = @0 WHERE Licence = @1", iEtat, dgvScore.Rows[iRowactive].Cells[16].Value.ToString());

                db.CompleteTransaction();
            }
        }

        void CallClearPartieEnCour(DataGridView dgvScore)
        {
            CallPartieEnCour(dgvScore, 0);
        }

        #endregion

        #endregion
    }
}
