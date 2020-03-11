/*
 * Created by SharpDevelop.
 * User: CHAUTARD
 * Date: 04/11/2019
 * Time: 12:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Criterium_16_4
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        // Colonne pour les move
        int iColMove = -1;

        // Declare a string to hold the entire document contents.
        private string documentContents;

        private string stringToPrint;

        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // Add constructor code after the InitializeComponent() call.
            //

            // Nom de la compétion
            IniFile iniFile = new IniFile(SingletonOutils.FILEINI);

            setTextBtCompetition(iniFile.ReadString("COMPETITION", "division"), iniFile.ReadString("COMPETITION", "groupe"), iniFile.ReadString("COMPETITION", "categorie"));

            // Création des ligne dans la grid
            for (int i = 0; i < 4; i++)
                dataGridViewPoule.Rows.Add(SingletonOutils.CELLVIDE, SingletonOutils.CELLVIDE, SingletonOutils.CELLVIDE, SingletonOutils.CELLVIDE);  
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            // Existe t'il des enregistrements dans la Table Joueurs
            int iNbr = 0;
            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                iNbr = db.ExecuteScalar<int>("SELECT COUNT(*) FROM Joueurs");
            }

            // Oui
            if (iNbr > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Des données ont été sauvegardées lors d'une utilisation précédante. Voulez vous les utiliser ?", "Restauration des joueurs", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ClubDA clubDA = new ClubDA();

                    using (var db = new PetaPoco.Database("SqliteConnect"))
                    {
                        var joueurs = db.Query<Joueur>("SELECT * FROM Joueurs ORDER BY Numero;");
                        int r = 0;
                        int iT = 0;

                        foreach (Joueur j in joueurs)
                        {
                            // Recherche du nom du club
                            j.club = new Club( j.NumeroClub, clubDA.GetNomByNumero(j.NumeroClub) );
                            SingletonOutils.ListJoueurs.Add(j);

                            dgvListeJoueurs.Rows.Add(
                                j.IsPresent,
                                j.Numero,
                                j.Licence,
                                j.Nom,
                                j.DatNais.ToString("dd/MM/yyyy"),
                                clubDA.GetNomByNumero(j.NumeroClub),
                                j.Points
                            );

                            // Mettre en couleur la ligne si le joueur est présent
                            for (int i = 0; i < dgvListeJoueurs.ColumnCount; i++)
                            {
                                dgvListeJoueurs.Rows[r].Cells[i].Style.BackColor = (j.IsPresent ? Color.LightBlue : Color.White);

                                if(j.IsPresent) iT++;
                            }

                            r++;
                        }

                        if (iT > 3)
                            traitementToolStripMenuItem.Enabled = true;
                    }

                    // Cacher le label "Coller ..."
                    label_ligue.Visible = false;
                }
                else
                {
                    SingletonOutils.TRUNCATE("Joueurs");
                }
            }
        }

        public void setTextBtCompetition(string sDivision, string sGroupe, string sCategory)
        {
            bt_Competition.Text = String.Format("Division: {0} - Groupe : {1} - Catégorie : {2}", sDivision, sGroupe, sCategory);

            // Titre de la fenétre
            Text = "Mise en poule - " + bt_Competition.Text + " - Version : " + Assembly.GetEntryAssembly().GetName().Version.ToString();
        }

        // Affichage des joueurs dans le tableau
        void ShowJoueurs(string msg, Joueur[] aJ)
        {
            /* Cellulle du DataGridView correspondant au serpent
			 * 
			 * +---+---+---+---+---+
			 * |row| 0 | 1 | 2 | 3 | -> Col
			 * +---+---+---+---+---+
			 * | 0 | 0 | 1 | 2 | 3 |
			 * +---+---+---+---+---+
			 * | 1 | 7 | 6 | 5 | 4 |
			 * +---+---+---+---+---+
			 * | 2 | 8 | 9 | 10| 11|
			 * +---+---+---+---+---+
			 * | 3 | 15| 14| 13| 12|
			 * +---+---+---+---+---+
			 */
            int[,] aPos = new int[,] {
                {0,0}, {1,0}, {2,0}, {3,0},
                {3,1}, {2,1}, {1,1}, {0,1},
                {0,2}, {1,2}, {2,2}, {3,2},
                {3,3}, {2,3}, {1,3}, {0,3} };

            // Positionnement dans le tableau d'aprés le serpent
            int col, row;
            int iPos = 0;

            // Vidage des information du tableau
            for (col = 0; col < 4; col++)
                for (row = 0; row < 4; row++)
                    dataGridViewPoule[col, row].Value = SingletonOutils.CELLVIDE;


            setTextRapport(msg, true);

            setTextRapport("+----+----+----+----+");

            for (int i = 0; i <= 15; i++)
            {
                // Joueur absent
                if (aJ[i] != null && aJ[i].IsPresent)
                {
                    col = aPos[iPos, 0];
                    row = aPos[iPos, 1];

                    dataGridViewPoule[col, row].Value = aJ[i].Nom + Environment.NewLine + aJ[i].club.Nom;

                    switch (iPos)
                    {
                        case 3:
                            setRapport4(aJ, 0, 1, 2, 3);
                            break;

                        case 7:
                            setRapport4(aJ, 7, 6, 5, 4);
                            break;

                        case 11:
                            setRapport4(aJ, 8, 9, 10, 11);
                            break;

                        case 15:
                            setRapport4(aJ, 15, 14, 13, 12);
                            break;
                    }

                    iPos++;
                }
            }

            setTextRapport("+----+--------------------------------+--------------------------------+");
            for (int i = 0; i <= 15; i++)
            {
                // Joueur absent
                if (aJ[i] != null && aJ[i].IsPresent)
                {
                    setTextRapport( string.Format("| {0}{1} | {2,-30} | {3,-30} |" , aJ[i].Lettre, aJ[i].Ordre.ToString(), aJ[i].Nom, aJ[i].club.Nom ));
                    setTextRapport("+----+--------------------------------+--------------------------------+");
                }
                else
                {
                    if (aJ[i] != null)
                    {
                        setTextRapport(string.Format("| {0}{1} | {2,-30} | {3,-30} |", aJ[i].Lettre, aJ[i].Ordre.ToString(), "ABSENT !", " "));
                        setTextRapport("+----+--------------------------------+--------------------------------+");
                    }
                }
            }
        }

        void setRapport4(Joueur[] aJ, int i1, int i2, int i3, int i4)
        {
            string s1, s2, s3, s4;

            if (aJ[i1] == null) s1 = "  "; else s1 = aJ[i1].Lettre + aJ[i1].Ordre.ToString();
            if (aJ[i2] == null) s2 = "  "; else s2 = aJ[i2].Lettre + aJ[i2].Ordre.ToString();
            if (aJ[i3] == null) s3 = "  "; else s3 = aJ[i3].Lettre + aJ[i3].Ordre.ToString();
            if (aJ[i4] == null) s4 = "  "; else s4 = aJ[i4].Lettre + aJ[i4].Ordre.ToString();

            setTextRapport(String.Format("| {0} | {1} | {2} | {3} |", s1, s2, s3, s4));
            setTextRapport("+----+----+----+----+");
        }


        // Coller des informations issues du site de la ligue / Compétition
        void DgvListeJoueursKeyDown(object sender, KeyEventArgs e)
        {
            // Look for Ctrl+V.
            if (e.Control && (e.KeyCode == Keys.V))
            {
                // Paste.

                // Eclatrer par ligne, puis par élément dans la ligne
                String Cl = Clipboard.GetText();
                String[] strs = Cl.Split('\n');

                // Contrôle des données par une expression régulière
                Regex myRegex = new Regex(@"^([\w]+)@([\w]+)\.([\w]+)$");

                if (myRegex.IsMatch(strs[0]))
                {
                    MessageBox.Show("Format des données en entrée incorrect !");
                    return;
                }

                Cursor.Current = Cursors.WaitCursor;

                // Cacher le label
                label_ligue.Visible = false;

                int iNumero;
                string sLicence;
                string sNom;
                string sDatnaiss;
                string sClub;
                int iDossard = 1;
                int iPoints;
                int position;
                Random rnd = new Random();

                // Liste des clubs pour les joueurs engagés
                List<Club> listClub = new List<Club>();
                Club club = new Club();
                ClubDA clubDA = new ClubDA();

                // ^[\d]{1,2} [\d]+ [A-Z a-zÀ-ÿ\-]+ [\d/]{10} [\w. ]+ [\d.]{5,6} [//\w ]+
                string[] thisArray;

                int iC;
                bool boucle;

                // Vidage de la table joueur
                SingletonOutils.TRUNCATE("Joueurs;");


                foreach (string lgn in strs)
                {
                    thisArray = lgn.Split(' ');

                    if (thisArray.Length < 10)
                    {
                        MessageBox.Show("Format des données en entrée incorrect !");
                        Cursor.Current = Cursors.Default;
                        return;
                    }

                    iNumero = Int32.Parse(thisArray[0]);

                    sLicence = thisArray[1];
                    sNom = thisArray[2];

                    boucle = true;
                    iC = 3;
                    while (boucle)
                    {
                        try
                        {
                            // Date de naissance ?
                            int m = Int32.Parse(thisArray[iC].Substring(0, 2));
                            boucle = false;
                        }
                        catch
                        {
                            sNom += " " + thisArray[iC];
                            iC++;
                        }
                    }

                    sDatnaiss = thisArray[iC];
                    iC++;

                    sClub = thisArray[iC];
                    boucle = true;
                    iC++;
                    while (boucle)
                    {
                        try
                        {
                            // Trois premier caractère du nombre de point 667.0
                            position = thisArray[iC].IndexOf(".");

                            // Pas de numérique
                            if (position == -1)
                            {
                                sClub += " " + thisArray[iC];
                                iC++;
                            }
                            else
                            {
                                int m = Int32.Parse(thisArray[iC].Substring(0, position));

                                if (m < 100)
                                {
                                    sClub += " " + thisArray[iC];
                                    iC++;
                                }
                                else
                                    boucle = false;
                            }
                        }
                        catch
                        {
                            sClub += " " + thisArray[iC];
                            iC++;
                        }
                    }

                    // 667.0, 1879.0, suppression du .0 final
                    position = thisArray[iC].IndexOf(".");
                    iPoints = Int32.Parse(thisArray[iC].Substring(0, position));

                    // Recherche dans la table des clubs
                    club = clubDA.GetClubByName(sClub);

                    if (club == null)
                    {
                        MessageBox.Show("Le club " + sClub.Trim() + " n'existe pas dans la table !");

                        using (var db = new PetaPoco.Database("SqliteConnect"))
                        {
                            // Numero de club aleatoire
                            club = new Club(String.Format("0898{0:0000}", rnd.Next(1, 9999)), sClub.Trim());
                            db.Insert("Clubs", "Numero", club);
                        }
                    }
                    listClub.Add(club);

                    Joueur joueur = new Joueur();

                    joueur.Licence = Int32.Parse(sLicence.Trim());
                    joueur.Numero = iNumero;
                    joueur.Nom = sNom.Trim();
                    try
                    {
                        joueur.DatNais = DateTime.Parse(sDatnaiss.Trim());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Unable to parse the specified date");
                    }
                    joueur.NumeroClub = club.Numero;
                    joueur.club = club;

                    joueur.Points = iPoints;
                    joueur.Ordre = iDossard;
                    joueur.Dossard = iDossard++;;

                    using (var db = new PetaPoco.Database("SqliteConnect"))
                    {
                        db.Insert("Joueurs", "Licence", joueur);
                    }

                    // Sauvegarde du joueur dans la liste
                    SingletonOutils.ListJoueurs.Add(joueur);

                    dgvListeJoueurs.Rows.Add(
                        joueur.IsPresent,
                        joueur.Numero,
                        joueur.Licence,
                        joueur.Nom,
                        joueur.DatNais.ToString("dd/MM/yyyy"),
                        club.Nom,
                        joueur.Points
                    );
                }

                Cursor.Current = Cursors.Default;
            }
        }

        // Présence ou non d'un joueur
        void DgvListeJoueursCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //set your checkbox column index instead of 0
            if (e.ColumnIndex == 0)
            {
                // Click sur le header Présent
                if (e.RowIndex == -1 && dgvListeJoueurs.RowCount > 0)
                {
                    // Sélectionne ou déselectionne toute les lignes présentes
                    bool b = Convert.ToBoolean(dgvListeJoueurs[0, 0].Value);

                    for (int r = 0; r < dgvListeJoueurs.RowCount; r++)
                        SetRowColor(r, b);

                }
                else
                    SetRowColor(e.RowIndex, Convert.ToBoolean(dgvListeJoueurs.Rows[e.RowIndex].Cells[0].Value));
            }
        }

        // Mise a blanc ou en couleur en fonction de la présence d'un joueur
        void SetRowColor(int r, bool b)
        {
            // Mise a blanc de la ligne
            // Mise en couleur de la ligne
            dgvListeJoueurs[0, r].Value = !b;

            for (int i = 0; i < dgvListeJoueurs.ColumnCount; i++)
                dgvListeJoueurs.Rows[r].Cells[i].Style.BackColor = (b ? Color.White : Color.LightBlue);

            SingletonOutils.ListJoueurs[r].IsPresent = !b;

            // Si aucun présent
            traitementToolStripMenuItem.Enabled = false;
            gestionDesbarragesToolStripMenuItem.Enabled = false;

            int iT = 0;
            for (int f = 0; f < dgvListeJoueurs.RowCount; f++)
            {
                if (Convert.ToBoolean(dgvListeJoueurs.Rows[f].Cells[0].Value.ToString()))
                    iT++;
            }

            if (iT > 3)
                traitementToolStripMenuItem.Enabled = true;
        }

        // Ajouter un club dans la table Sqlite
        void AjouterUnClubToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (InputClub xForm = new InputClub())
            {
                if (xForm.ShowDialog(this) == DialogResult.OK)
                {

                    // Création d'un nouveau enregistrement
                    Club club = new Club();

                    using (var db = new PetaPoco.Database("SqliteConnect"))
                    {
                        club.Numero = xForm.getTbnumClub();
                        club.Nom = xForm.getTbNomClub();
                        db.Save("Clubs", "IdClub", club);
                    }

                    MessageBox.Show("Club ajouter.");

                    xForm.Close();
                }
            }
        }

        // Affiche le rapport du traitement
        public void setTextRapport(string sText, bool bold = false)
        {
            SingletonOutils.setTextRapport(txtRapport, sText, bold);

            txtRapport.ScrollToCaret();
        }

        /*
		 *	  Mise en poule
		 * 
		 */
        void TraitementToolStripMenuItemClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            // Effacer le rapport
            txtRapport.Clear();

            List<ClubLettre> lClubLettre = new List<ClubLettre>();
            ClubLettre clubLettre = new ClubLettre();

            char iLettre = 'A'; // A = 65
            int count;

            bool bOrdonnePoule = false;


            for (int iJoueur = 0; iJoueur < SingletonOutils.ListJoueurs.Count; iJoueur++)
            {
                // Calcul pour les Joueurs présent
                if (SingletonOutils.ListJoueurs[iJoueur].IsPresent)
                {
                    // La liste est vide
                    if (lClubLettre.Count == 0)
                    {
                        Club club = new Club();

                        club = clubLettre.GetClubByNumero(SingletonOutils.ListJoueurs[iJoueur].NumeroClub);

                        lClubLettre.Add( new ClubLettre(club.Numero, club.Nom, iLettre));

                        SingletonOutils.ListJoueurs[iJoueur].Lettre = iLettre;
                        SingletonOutils.ListJoueurs[iJoueur].Ordre = 1;

                        iLettre++; // B
                    }
                    else
                    {
                        // Recherche du numero de club dans la liste
                        count = 0;
                        foreach (ClubLettre aClub in lClubLettre)
                        {
                            // Le club est déjà dans la liste
                            if (aClub.Numero.Equals(SingletonOutils.ListJoueurs[iJoueur].NumeroClub))
                            {
                                // Sauvegarde des informations sur le club
                                clubLettre = aClub;

                                // Combien de joueur de ce club déjà positionné
                                for (int i = 0; i < iJoueur; i++)
                                    if (SingletonOutils.ListJoueurs[i].NumeroClub.CompareTo(SingletonOutils.ListJoueurs[iJoueur].NumeroClub) == 0 )
                                        count++;
                            }
                        }

                        // Le club n'existe pas dans la liste
                        if (count == 0)
                        {
                            Club club = new Club();
                            club = clubLettre.GetClubByNumero(SingletonOutils.ListJoueurs[iJoueur].NumeroClub);

                            lClubLettre.Add( new ClubLettre(club.Numero, club.Nom, iLettre));

                            SingletonOutils.ListJoueurs[iJoueur].Lettre = iLettre;
                            SingletonOutils.ListJoueurs[iJoueur].Ordre = 1;
                            iLettre++;
                        }
                        else
                        {
                            SingletonOutils.ListJoueurs[iJoueur].Lettre = clubLettre.Lettre;
                            SingletonOutils.ListJoueurs[iJoueur].Ordre = count + 1;

                            switch (count)
                            {
                                case 0:
                                case 1:
                                case 2:
                                    break;

                                case 3:
                                    setTextRapport("Attention 4 joueurs du club " + clubLettre.Nom + ", donc un par poule.", true);
                                    break;

                                default:
                                    bOrdonnePoule = true;
                                    setTextRapport("Attention plus " + (count + 1).ToString() + " joueurs du club " + clubLettre.Nom + ", les faire jouer le plus rapidement possible !", true);
                                    break;
                            }
                        }
                    }
                }
                // Sauvegarde des présents dans la table
                using (var db = new PetaPoco.Database("SqliteConnect"))
                {
                    db.Save("Joueurs", "Licence", SingletonOutils.ListJoueurs[iJoueur]);
                }
            }

            PlaceJoueurs placeJouers = new PlaceJoueurs(this, bOrdonnePoule);

            // Création d'un tableau pour positionnement des joueurs
            // Tableau de joueur présent
            Joueur[] arJoueur = placeJouers.Go();

            // Affichage
            ShowJoueurs("MODIFIEE", arJoueur);

            //  Authoriser les modifications de la Grid
            dataGridViewPoule.ReadOnly = false;

            editionDesPoulesToolStripMenuItem.Enabled = true;
            dataGridViewPoule.AllowDrop = true;

            gestionDesbarragesToolStripMenuItem.Enabled = true;

            Cursor.Current = Cursors.Default;
        }

        //  Edition des poules en PDF ( 3 joueurs avec 1 ou 3 sélectionnés)
        void Joueurs313ToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Save the document...
            const string filename = "Poules_313.pdf";

            PoulePdf poulePdf = new PoulePdf(filename);

            poulePdf.Joueurs313(bt_Competition.Text);

            System.Diagnostics.Process.Start(filename);
        }

        //  Edition des poules en PDF ( 4 joueurs avec 1 ou 3 sélectionnés)
        void Joueurs413ToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Save the document...
            const string filename = "Poules_413.pdf";

            PoulePdf poulePdf = new PoulePdf(filename);

            poulePdf.Joueurs413(bt_Competition.Text);

            System.Diagnostics.Process.Start(filename);
        }


        /*-------------------------------------------------------------------------------------
		 * 
		 * 		Gestion du drag en drop dans le DataGridView Poule
		 * 
		 *-------------------------------------------------------------------------------------
		 */
        void DataGridViewPouleDragDrop(object sender, DragEventArgs e)
        {
            var p = dataGridViewPoule.PointToClient(new Point(e.X, e.Y));
            DataGridView.HitTestInfo hInfo = dataGridViewPoule.HitTest(p.X, p.Y);

            if (hInfo.ColumnIndex != -1 &&
                hInfo.RowIndex != -1 &&
                hInfo != null &&
                hInfo.Type == DataGridViewHitTestType.Cell &&
                hInfo.ColumnIndex == iColMove)
            {
                DataGridViewCell cellSource = (DataGridViewTextBoxCell)e.Data.GetData(typeof(DataGridViewTextBoxCell));

                DataGridViewCell cellDestination = dataGridViewPoule[hInfo.ColumnIndex, hInfo.RowIndex];

                if (cellDestination.Value.ToString().CompareTo(SingletonOutils.CELLVIDE) != 0)
                {
                    object cellTmp = cellSource.Value;
                    cellSource.Value = cellDestination.Value;
                    cellDestination.Value = cellTmp;
                }
                iColMove = -1;
            }
        }

        // Déplacement d'un joueur dans la poule
        void DataGridViewPouleCellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            // on ne déplace pas le heder, ni les quatres premier joueurs
            if (e.RowIndex < 1 || e.ColumnIndex == -1)
                return;

            // Dé^placement seulement dans la même colonne
            this.iColMove = e.ColumnIndex;

            // dataGridViewPoule.DoDragDrop(dataGridViewPoule[e.ColumnIndex,e.RowIndex].FormattedValue, DragDropEffects.All);
            DoDragDrop(dataGridViewPoule[e.ColumnIndex, e.RowIndex], DragDropEffects.Move);
        }

        // Déplacement en mode move
        void DataGridViewPouleDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        void AProposDeToolStripMenuItemClick(object sender, EventArgs e)
        {
            AboutForm frm = new AboutForm();
            frm.ShowDialog();
        }

        // Edition des quatres poules
        void EditionDesQuatrePoulesToolStripMenuItemClick(object sender, EventArgs e)
        {
            EditionDesPoules frm = new EditionDesPoules(bt_Competition.Text, dataGridViewPoule);
            frm.ShowDialog();
        }

        /*-------------------------------------------------------------------------------------------------------------
		 * Début de la saise des score des poules
		 *-------------------------------------------------------------------------------------------------------------
		 */
        // Double click sur le header de la poule
        void DataGridViewPouleColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //			System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            //			messageBoxCS.AppendFormat("{0} = {1}", "ColumnIndex", e.ColumnIndex );
            //			messageBoxCS.AppendLine();
            //			messageBoxCS.AppendFormat("{0} = {1}", "RowIndex", e.RowIndex );
            //			messageBoxCS.AppendLine();
            //			MessageBox.Show(messageBoxCS.ToString(), "ColumnHeaderMouseDoubleClick Event" );

            // Plus de modification de la GridPoule possssible
            dataGridViewPoule.ReadOnly = true;

            FormPartieBarrage frm = new FormPartieBarrage(dataGridViewPoule);
            frm.ShowDialog();
        }

        void GestionDesBarragesToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Sauvegarde de la mise en poule

            FormPartieBarrage frm = new FormPartieBarrage(dataGridViewPoule);
            frm.ShowDialog();
        }
 
        /*-----------------------------------------------------------*/

        void KIToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Save the document...
            const string filename = "16KI.pdf";

            ClassementPdf classementPdf = new ClassementPdf(filename);

            classementPdf.KI16();

            System.Diagnostics.Process.Start(filename);
        }

        private void bt_Competition_Click(object sender, EventArgs e)
        {
            // Saisie du nom de la compétition
            FormCompetitionNom frmCompetition = new FormCompetitionNom(this);
            frmCompetition.ShowDialog();
        }

        private void catégoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Gestion de la table Catégories avec initialisation des premières valeurs
            SingletonOutils.TRUNCATE("Categories");

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Save("Categories", "IdCategorie", new Categorie("Vétéran 5", "nés en 1939 et avant", "VÉTÉRANS", 10));
                db.Save("Categories", "IdCategorie", new Categorie("Vétéran 4", "du 1er Janvier 1940 au 31 décembre 1949", "VÉTÉRANS", 20));
                db.Save("Categories", "IdCategorie", new Categorie("Vétéran 3", "du 1er Janvier 1920 au 31 Décembre 1959", "VÉTÉRANS", 30));
                db.Save("Categories", "IdCategorie", new Categorie("Vétéran 2", "du 1er Janvier 1960 au 31 Décembre 1969", "VÉTÉRANS", 40));
                db.Save("Categories", "IdCategorie", new Categorie("Vétéran 1", "du 1er Janvier 1970 au 31 Décembre 1979", "VÉTÉRANS", 50));

                db.Save("Categories", "IdCategorie", new Categorie("Sénior", "du 1er Janvier 1980 au 31 Décembre 2001", "SÉNIORS", 60));

                db.Save("Categories", "IdCategorie", new Categorie("Junior 3 (« -de 18 ans »)", "nés en 2002", "JUNIORS", 70));
                db.Save("Categories", "IdCategorie", new Categorie("Junior 2 (« -de 17 ans »)", "nés en 2003", "JUNIORS", 80));
                db.Save("Categories", "IdCategorie", new Categorie("Junior 1 (« -de 16 ans »)", "nés en 2004", "JUNIORS", 90));

                db.Save("Categories", "IdCategorie", new Categorie("Cadet 2 (« -de 15 ans »)", "nés en 2005", "CADETS", 100));
                db.Save("Categories", "IdCategorie", new Categorie("Cadet 1 (« -de 14 ans »)", "nés en 2006", "CADETS", 110));

                db.Save("Categories", "IdCategorie", new Categorie("Minime 2 (« -de 13 ans »)", "nés en 2007", "MINIMES", 120));
                db.Save("Categories", "IdCategorie", new Categorie("Minime 1 (« -de 12 ans »)", "nés en 2008", "MINIMES", 130));

                db.Save("Categories", "IdCategorie", new Categorie("Benjamin 2 (« -de 11 ans »)", "nés en 2009", "BENJAMINS", 140));
                db.Save("Categories", "IdCategorie", new Categorie("Benjamin 1 (« -de 10 ans »)", "nés en 2010", "BENJAMINS", 150));

                db.Save("Categories", "IdCategorie", new Categorie("Poussin (« -de 9 ans »)", "Nés en 2011 et après", "POUSSINS", 160));
            }
        }

        private void divisionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Gestion de la table Divisions avec initialisation des premières valeurs
            SingletonOutils.TRUNCATE("Divisions;");

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Save("Divisions", "IdDivision", new Division("PRO A", "PRO A", "NATIONAL", 10));
                db.Save("Divisions", "IdDivision", new Division("PRO B", "PRO B", "NATIONAL", 20));
                db.Save("Divisions", "IdDivision", new Division("N1", "Nationale une", "NATIONAL", 30));
                db.Save("Divisions", "IdDivision", new Division("N2", "Nationale deux", "NATIONAL", 40));
                db.Save("Divisions", "IdDivision", new Division("N3", "Nationale trois", "NATIONAL", 50));
                db.Save("Divisions", "IdDivision", new Division("PN", "Pré-nationale", "REGIONAL", 60));
                db.Save("Divisions", "IdDivision", new Division("R1", "Régionale une", "REGIONAL", 70));
                db.Save("Divisions", "IdDivision", new Division("R2", "Régionale deux", "REGIONAL", 80));
                db.Save("Divisions", "IdDivision", new Division("R3", "Régionale trois", "REGIONAL", 90));
                db.Save("Divisions", "IdDivision", new Division("PR", "Pré-Régionale", "DEPARTEMENTAL", 100));
                db.Save("Divisions", "IdDivision", new Division("D1", "Départemental un", "DEPARTEMENTAL", 110));
                db.Save("Divisions", "IdDivision", new Division("D2", "Départemental deux", "DEPARTEMENTAL", 120));
            }
        }

        private void groupesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SingletonOutils.TRUNCATE("Groupes");

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Save("Groupes", "IdGroupe", new Groupe("Un"));
                db.Save("Groupes", "IdGroupe", new Groupe("Deux"));
                db.Save("Groupes", "IdGroupe", new Groupe("Trois"));
                db.Save("Groupes", "IdGroupe", new Groupe("Quatre"));
                db.Save("Groupes", "IdGroupe", new Groupe("Cinq"));
                db.Save("Groupes", "IdGroupe", new Groupe("Six"));
                db.Save("Groupes", "IdGroupe", new Groupe("Sept"));
                db.Save("Groupes", "IdGroupe", new Groupe("Huit"));
                db.Save("Groupes", "IdGroupe", new Groupe("Neuf"));
            }
        }

        private void lesClubsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Gestion de la table Clubs avec initialisation des premières valeurs
            SingletonOutils.TRUNCATE("Clubs");

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                //Read the contents of the file into a stream
                string line;
                Club club = new Club();
                String[] strList;

                Cursor.Current = Cursors.WaitCursor;

                using (var tr = db.GetTransaction())
                {
                    using (StreamReader reader = new StreamReader("liste_des_clubs.txt"))
                    {
                        while ((line = reader.ReadLine()) != null)
                        {
                            strList = line.Split(';');

                            club.Numero = strList[0];
                            club.Nom = strList[1];

                            db.Insert("Clubs", club);
                        }

                        reader.Close();
                    }
                    tr.Complete();
                }

                // Set cursor as hourglass
                Cursor.Current = Cursors.Default;
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int charactersOnPage = 0;
            int linesPerPage = 0;

            // Sets the value of charactersOnPage to the number of characters 
            // of stringToPrint that will fit within the bounds of the page.
            e.Graphics.MeasureString(stringToPrint, this.Font,
                e.MarginBounds.Size, StringFormat.GenericTypographic,
                out charactersOnPage, out linesPerPage);

            // Draws the string within the bounds of the page.
            e.Graphics.DrawString(stringToPrint, this.Font, Brushes.Black,
            e.MarginBounds, StringFormat.GenericTypographic);

            // Remove the portion of the string that has been printed.
            stringToPrint = stringToPrint.Substring(charactersOnPage);

            // Check to see if more pages are to be printed.
            e.HasMorePages = (stringToPrint.Length > 0);

            // If there are no more pages, reset the string to be printed.
            if (!e.HasMorePages)
                stringToPrint = documentContents;
        }

        private void imprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stringToPrint = documentContents = txtRapport.Text;
            printPreviewDialog1.ShowDialog();
        }

        private void parametresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormParams frm = new FormParams();
            frm.ShowDialog();
        }

        /*-----------------------------------------------------------
         * Edition des tableaux vides
         *-----------------------------------------------------------
         */

        void POU01ToolStripMenuItemClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(string.Format("{0}{1}PDF{2}POU-01.pdf", Directory.GetCurrentDirectory(), Path.DirectorySeparatorChar, Path.DirectorySeparatorChar));
        }

        void POU02ToolStripMenuItemClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(string.Format("{0}{1}PDF{2}POU-02.pdf", Directory.GetCurrentDirectory(), Path.DirectorySeparatorChar, Path.DirectorySeparatorChar));
        }

        void ARB001ToolStripMenuItemClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(string.Format("{0}{1}PDF{2}ARB-001.pdf", Directory.GetCurrentDirectory(), Path.DirectorySeparatorChar, Path.DirectorySeparatorChar));
        }

        void POU315ToolStripMenuItem1Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(string.Format("{0}{1}PDF{2}POU-315.pdf", Directory.GetCurrentDirectory(), Path.DirectorySeparatorChar, Path.DirectorySeparatorChar));
        }

        void POU325ToolStripMenuItem2Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(string.Format("{0}{1}PDF{2}POU-325.pdf", Directory.GetCurrentDirectory(), Path.DirectorySeparatorChar, Path.DirectorySeparatorChar));
        }

        void POU415ToolStripMenuItemClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(string.Format("{0}{1}PDF{2}POU-415.pdf", Directory.GetCurrentDirectory(), Path.DirectorySeparatorChar, Path.DirectorySeparatorChar));
        }

        void POU425ToolStripMenuItemClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(string.Format("{0}{1}PDF{2}POU-425.pdf", Directory.GetCurrentDirectory(), Path.DirectorySeparatorChar, Path.DirectorySeparatorChar));
        }

        void KI16ToolStripMenuItemClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(string.Format("{0}{1}PDF{2}16KI.pdf", Directory.GetCurrentDirectory(), Path.DirectorySeparatorChar, Path.DirectorySeparatorChar));
        }


        /*
         * Départage des égalités Parties / Manches et égalités Points
         */

        // Départage des égalités Parties / Manches
        void PartiesToolStripMenuItemClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(string.Format("{0}{1}PDF{2}POU-01.pdf", Directory.GetCurrentDirectory(), Path.DirectorySeparatorChar, Path.DirectorySeparatorChar));
        }

        // Départage des égalités Points
        void PointsToolStripMenuItemClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(string.Format("{0}{1}PDF{2}POU-02.pdf", Directory.GetCurrentDirectory(), Path.DirectorySeparatorChar, Path.DirectorySeparatorChar));
        }
    }
}

