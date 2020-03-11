/*
 * Crée par SharpDevelop.
 * Utilisateur: CHAUTARD
 * Date: 04/02/2020
 * Heure: 08:44
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Criterium_16_4
{
    /// <summary>
    /// Description of FormTableauSaisie.
    /// </summary>
    public partial class FormTableauSaisie : Form
    {
        const bool _Debug = true;

        int _iFinale = 8;

        Image _image;
        Graphics _graphics;

        Font _font = new Font("Times", 10);

        String[] _sName = new String[16];
        int[] _iName = new int[16];

        // Pas de 130                    0    1    2    3    4     5     6     7      8
        static readonly int[] _xPos = { 45, 280, 510, 740, 995, 1225, 1470, 1700, 1930 };

        // Position en Y                 0    1    2    3    4    5    6    7    8    9   10   11
        static readonly int[] _yPos = { 75, 124, 139, 169, 203, 220, 236, 265, 299, 316, 364, 407,
            460, 508, 524, 555, 587, //    12    13    14    15    16
			603, 619, 650, 677,     //    17    18    19    20
			695, 747,				//    21    22 
			821, 853,				//    23    24
			885, 917,				//    25    26   
			1029, 1061,				//    27    28
			1093, 1107,				//    29    30 
			1125, 1156, 1189, 1207, // 31   32    33    34
			1304, 1333, 1365, 1396  // 35   36    37   38
		};

        static readonly int[,] _aCas = {
            { 5, 0},		// 1P1
			{ 3, 0},
            { 4, 2},
            { 4, 4},
            { 4, 6},
            { 4, 8},
            { 3, 10},
            { 5, 10},
            { 5, 12},
            { 3, 12},
            { 4, 14},
            { 4, 16},
            { 4, 18},
            { 4, 20},
            { 3, 22},
            { 5, 22},		// 1P2

			{ 5, 3},
            { 5, 7},
            { 5, 15},
            { 5, 19},		// 20

			{ 6, 1},
            { 6, 9},
            { 6, 13},
            { 6, 21},

            { 6, 27},
            { 6, 29},
            { 6, 31},
            { 6, 33},		// 28

			{ 7, 5},
            { 7, 17},
            { 7, 23},
            { 7, 25},
            { 7, 28},
            { 7, 32},
            { 7, 35},
            { 7, 37},		// 36

			{ 8, 11},
            { 8, 19},
            { 8, 24},
            { 8, 26},
            { 8, 30},
            { 8, 34},
            { 8, 36},
            { 8, 38},		// 44

			{ 3, 3},
            { 3, 7},
            { 3, 15},
            { 3, 19},		// 48

			{ 2, 1},
            { 2, 9},
            { 2, 13},
            { 2, 21},
            { 2, 27},
            { 2, 29},
            { 2, 31},
            { 2, 33},		// 56

			{ 1, 5},
            { 1, 17},
            { 1, 23},
            { 1, 25},
            { 1, 28},
            { 1, 32},
            { 1, 35},
            { 1, 37},		// 64

			{ 0, 11},
            { 0, 19},
            { 0, 24},
            { 0, 26},
            { 0, 30},
            { 0, 34},
            { 0, 36},
            { 0, 38}		// 72
	};

        public FormTableauSaisie(DataGridView dgv)
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            for (int i = 0; i < 16; i++)
            {
                _sName[i] = dgv.Rows[i].Cells[1].Value.ToString();
                _iName[i] = Int32.Parse(dgv.Rows[i].Cells[3].Value.ToString()) - 1;
            }

            _image = new Bitmap(pictureBox1.Image);
            _graphics = Graphics.FromImage(this._image);

            // Position initiale des 16 joueurs
            for (int i = 0; i < 72; i++)
            {
                if (i < 16)
                    WriteonImage(_aCas[i, 0], _aCas[i, 1], _iName[i]);
                else
                    WriteonImage(_aCas[i, 0], _aCas[i, 1], String.Format("Cas : {0}", i + 1));
            }

            this.pictureBox1.Image = _image;
        }

        private void WriteonImage(int xPos, int yPos, int iName)
        {
            WriteonImage(xPos, yPos, _sName[iName]);
        }

        private void WriteonImage(int xPos, int yPos, string str)
        {
            _graphics.DrawString(str, _font, Brushes.Black, new Point(_xPos[xPos], _yPos[yPos]));
        }

        void CallSaisieScore(int iPartie)
        {
            string[] aPartie = { "3 Contre 4", "5 contre 6", "11 contre 12", "13 contre 14",
                "1 contre 4", "5 contre 8", "9 contre 12", "13 contre 19",
                "1 contre 8", "9 contre 16", "1 contre 16", "8 contre 9",
                "4 contre 5", "12 contre 13", "5 contre 12", "4 contre 13",
                "2 contre 3", "6 contre 7", "10 contre 11", "14 contre 15",
                "3 contre 6", "11 contre 14", "3 contre 14",
                "2 contre 7", "10 contre 15", "7 contre 10", "2 contre 15"
            };

            // Appel de la Form
            FormSaisieScore frm = new FormSaisieScore();

            /*
            frm.SetPartie(dgvScore[0, _iRowactive].Value.ToString());
            frm.SetForfaitJoueur1(String.Compare(dgvScore[1, _iRowactive].Value.ToString(), "F") == 0);
            frm.SetAbandonJoueur1(String.Compare(dgvScore[1, _iRowactive].Value.ToString(), "A") == 0);
            frm.SetJoueur1(dgvScore[2, _iRowactive].Value.ToString());
            frm.SetJoueur2(dgvScore[3, _iRowactive].Value.ToString());
            frm.SetForfaitJoueur2(String.Compare(dgvScore[4, _iRowactive].Value.ToString(), "F") == 0);
            frm.SetAbandonJoueur2(String.Compare(dgvScore[4, _iRowactive].Value.ToString(), "A") == 0);
            frm.SetScore1(dgvScore[5, _iRowactive].Value.ToString());
            frm.SetScore2(dgvScore[6, _iRowactive].Value.ToString());
            frm.SetScore3(dgvScore[7, _iRowactive].Value.ToString());
            frm.SetScore4(dgvScore[8, _iRowactive].Value.ToString());
            frm.SetScore5(dgvScore[9, _iRowactive].Value.ToString());
            */

            if (frm.ShowDialog() == DialogResult.OK)
            {
                /*
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
                */
            }
        }


        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;

            // Create solid brush.
            SolidBrush brush = new SolidBrush(Color.FromArgb(128, 0, 0, 200));

            switch (_iFinale)
            {
                case 8: // 1/8 de Finale
                    Rectangle rec = new Rectangle(955, 136, 258, 82);
                    _graphics.FillRectangle(brush, rec);

                    if (rec.Contains(coordinates))
                    {
                        MessageBox.Show("1/8 de Finale : 3 contre 4");
                    }
                    else
                    {
                        rec = new Rectangle(955, 232, 258, 82);
                        _graphics.FillRectangle(brush, rec);
                        if (rec.Contains(coordinates))
                        {
                            MessageBox.Show("1/8 de Finale : 5 contre 6");
                        }
                        else
                        {
                            rec = new Rectangle(955, 520, 258, 82);
                            _graphics.FillRectangle(brush, rec);
                            if (rec.Contains(coordinates))
                            {
                                MessageBox.Show("1/8 de Finale : 11 contre 12");
                            }
                            else
                            {
                                rec = new Rectangle(955, 618, 258, 82);
                                _graphics.FillRectangle(brush, rec);
                                if (rec.Contains(coordinates))
                                {
                                    MessageBox.Show("1/8 de Finale : 3 contre 4");
                                }
                                else
                                {
                                    MessageBox.Show(String.Format("1/8 (Y) - Mouse : {0}; {1}", coordinates.X, coordinates.Y));
                                }
                            }
                        }
                    }
                    pictureBox1.Refresh();
                    break;

                default:
                    MessageBox.Show(String.Format("Mouse : {0}; {1}", coordinates.X, coordinates.Y));
                    break;
            }
        }
    }
}
