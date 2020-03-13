/*
 * Created by SharpDevelop.
 * User: CHAUTARD
 * Date: 28/11/2019
 * Time: 08:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace Criterium_16_4
{
    /// <summary>
    /// Description of PoulePdf.
    /// </summary>
    public class PoulePdf
    {
        string _filename;

        DataGridView _dgv;

        string _sNumTable1;
        string _sNumTable2;
        string _sNumTable3;
        string _sNumTable4;

        TimeSpan _tHeureDebut = new TimeSpan();
        TimeSpan _tDuree = new TimeSpan();

        // Pour la génération des fichiers PDF
        XPen _pen = new XPen(XColors.Black, 1);

        XStringFormat _format = new XStringFormat();
        XStringFormat _formatLeft = new XStringFormat();

        XFont _font6 = new XFont("Times", 6, XFontStyle.Regular);
        XFont _font8 = new XFont("Times", 8, XFontStyle.Regular);
        XFont _font10 = new XFont("Times", 10, XFontStyle.Regular);
        XFont _font14b = new XFont("Times", 14, XFontStyle.Bold);
        XFont _font18b = new XFont("Times", 18, XFontStyle.Bold);

        PdfDocument _document = new PdfDocument();
        // private readonly XUnit _topPosition;
        // private XUnit _currentPosition;

        XGraphics _gfx;
        XTextFormatter _tf;

        PdfPage _page;

        XRect _rect;

        // Par défaut 4 joueurs par poule
        bool[] _bJoueur4 = { true, true, true, true };
        int _iPouleActive = 1;
        //int _iPartie = 0;

        const int PASGAUCHE = 286;
        const int PASBAS = 394;

        PdfDocument _documentArbitrage;
        PdfPage _pageArbitrage;

        public PoulePdf(string filename)
        {
            _filename = filename;

            // Pour les PDF
            _format.LineAlignment = XLineAlignment.Center;
            _format.Alignment = XStringAlignment.Center;

            // Create a new PDF document
            _document.Info.Title = "Critérium Fédéral Poules";
            _document.Info.Subject = "Gestions des poules du critérium";
            _document.Info.Author = "Patrick CHAUTARD";

            _documentArbitrage = PdfReader.Open(string.Format("{0}{1}PDF{2}ARB-001.pdf", Directory.GetCurrentDirectory(), Path.DirectorySeparatorChar, Path.DirectorySeparatorChar), PdfDocumentOpenMode.Import);
            _pageArbitrage = _documentArbitrage.Pages[0];

            // One page in Portrait...
            CreatePage();
        }

        void CreatePage(PdfPage pdfPage = null)
        {
            if (pdfPage == null)
                _page = _document.AddPage();
            else
                _page = _document.AddPage(pdfPage);

            _page.Size = PdfSharp.PageSize.A4;
            _gfx = XGraphics.FromPdfPage(_page);
            _tf = new XTextFormatter(_gfx);
        }

        /*
         * Passage des information pour la réalisattion du PDF Edition Poule
         */
        public void setDataGridView(DataGridView dgv) { _dgv = dgv; }

        public void setNumTable1(string str) { _sNumTable1 = str; }
        public void setNumTable2(string str) { _sNumTable2 = str; }
        public void setNumTable3(string str) { _sNumTable3 = str; }
        public void setNumTable4(string str) { _sNumTable4 = str; }

        public void setHeureDebut(string sHeureDebut)
        {
            // Découpage de l'heure de début en HH et Minute
            // 15h30
            string[] stringSeparators = new string[] { "h" };
            string[] lines = sHeureDebut.Split(stringSeparators, StringSplitOptions.None);

            _tHeureDebut = new TimeSpan(Int32.Parse(lines[0]), Int32.Parse(lines[1]), 0);
        }

        public void setDuree(string sDuree)
        {
            // Découpage de la durée en minutes
            _tDuree = new TimeSpan(0, Int32.Parse(sDuree), 0);
        }

        public void editionPoules(string sCompetition)
        {
            // Nombre de joueur dans la poule
            if (string.Compare(_dgv[0, 3].Value.ToString(), SingletonOutils.CELLVIDE, StringComparison.Ordinal) == 0)
            {
                Draw313(sCompetition, 1, 0);
                _bJoueur4[0] = false; // Trois joueurs
            }
            else
                Draw413(sCompetition, 1, 0);

            // Ligne séparatrice du milieu de page
            XPen pen2 = new XPen(XColors.Black, 1);
            pen2.DashStyle = XDashStyle.Dot;
            _gfx.DrawLine(pen2, 0, 421, 595, 421);

            if (string.Compare(_dgv[1, 3].Value.ToString(), SingletonOutils.CELLVIDE, StringComparison.Ordinal) == 0)
            {
                Draw313(sCompetition, 2, 421);
                _bJoueur4[1] = false; // Trois joueurs
            }
            else
                Draw413(sCompetition, 2, 421);

            _page = _document.AddPage();
            _gfx = XGraphics.FromPdfPage(_page);

            if (string.Compare(_dgv[2, 3].Value.ToString(), SingletonOutils.CELLVIDE, StringComparison.Ordinal) == 0)
            {
                Draw313(sCompetition, 3, 0);
                _bJoueur4[2] = false; // Trois joueurs
            }
            else
                Draw413(sCompetition, 3, 0);

            // Ligne séparatrice du milieu de page
            _gfx.DrawLine(pen2, 0, 421, 595, 421);

            if (string.Compare(_dgv[3, 3].Value.ToString(), SingletonOutils.CELLVIDE, StringComparison.Ordinal) == 0)
            {
                Draw313(sCompetition, 4, 421);
                _bJoueur4[3] = false; // Trois joueurs
            }
            else
                Draw413(sCompetition, 4, 421);

            /*
			 * Edition des fiches de parti par poule
			 */
            PdfXY pdfXY = new PdfXY();

            int x = 0, y = 0, w = 0, h = 0;

            int iPartieEditer = 0;

            for (_iPouleActive = 1; _iPouleActive <= 4; _iPouleActive++)
            {

                // @TODO prévoir 2 et 1 joueur dans la poule
                if (_bJoueur4[_iPouleActive - 1])
                {
                    foreach (PartieQuiJoue p in SingletonOutils.GetPartie())
                    {
                        if ((iPartieEditer % 4) == 0)
                            CreatePage(_pageArbitrage);

                        // 4 joueurs dans la poule
                        int iNbr = pdfXY.ReadNbr();
                        string[] position;
                        string str2;

                        for (int i = 1; i <= iNbr; i++)
                        {
                            // Lecture du fichier INI
                            position = pdfXY.ReadInit(i);

                            // Ajuste la position en fonction du cartouche à remplir
                            switch (iPartieEditer % 4)
                            {
                                case 0:
                                    x = int.Parse(position[1]);
                                    y = int.Parse(position[2]);
                                    w = int.Parse(position[3]);
                                    h = int.Parse(position[4]);
                                    break;

                                case 1:
                                    x = int.Parse(position[1]) + PASGAUCHE;
                                    y = int.Parse(position[2]);
                                    w = int.Parse(position[3]);
                                    h = int.Parse(position[4]);
                                    break;

                                case 2:
                                    x = int.Parse(position[1]);
                                    y = int.Parse(position[2]) + PASBAS;
                                    w = int.Parse(position[3]);
                                    h = int.Parse(position[4]);
                                    break;

                                case 3:
                                    x = int.Parse(position[1]) + PASGAUCHE;
                                    y = int.Parse(position[2]) + PASBAS;
                                    w = int.Parse(position[3]);
                                    h = int.Parse(position[4]);
                                    break;
                            }
                            // % 3 car 3 partie par poule de 3 joueurs
                            str2 = GetValue(position[0], p.iJoueur1, p.iJoueur2, p.iArbitre, iPartieEditer % 3);

                            if (str2.Contains("\n"))
                            {
                                _rect = new XRect(x + 1, y + 1, w - 1, h - 1);
                                //_gfx.DrawRectangle(_pen, XBrushes.LightGray, _rect);
                                _tf.DrawString(str2, _font8, XBrushes.Black, _rect, XStringFormats.TopLeft);
                            }
                            else
                            {
                                _rect = new XRect(x, y, w, h);
                                //_gfx.DrawRectangle(_pen, XBrushes.LightGray, _rect);
                                _gfx.DrawString(str2, _font8, XBrushes.Black, _rect, _format);
                            }
                        }
                        iPartieEditer++;
                    }
                }
                else
                {
                    // 3 joueurs dans la poule
                    foreach (PartieQuiJoue p in SingletonOutils.GetsPartie31())
                    {
                        if ((iPartieEditer % 4) == 0)
                            CreatePage(_pageArbitrage);

                        // 4 joueurs dans la poule
                        int iNbr = pdfXY.ReadNbr();
                        string[] position;
                        string str2;

                        for (int i = 1; i <= iNbr; i++)
                        {
                            // Lecture du fichier INI
                            position = pdfXY.ReadInit(i);

                            // Ajuste la position en fonction du cartouche à remplir
                            switch (iPartieEditer % 4)
                            {
                                case 0:
                                    x = int.Parse(position[1]);
                                    y = int.Parse(position[2]);
                                    w = int.Parse(position[3]);
                                    h = int.Parse(position[4]);
                                    break;

                                case 1:
                                    x = int.Parse(position[1]) + PASGAUCHE;
                                    y = int.Parse(position[2]);
                                    w = int.Parse(position[3]);
                                    h = int.Parse(position[4]);
                                    break;

                                case 2:
                                    x = int.Parse(position[1]);
                                    y = int.Parse(position[2]) + PASBAS;
                                    w = int.Parse(position[3]);
                                    h = int.Parse(position[4]);
                                    break;

                                case 3:
                                    x = int.Parse(position[1]) + PASGAUCHE;
                                    y = int.Parse(position[2]) + PASBAS;
                                    w = int.Parse(position[3]);
                                    h = int.Parse(position[4]);
                                    break;
                            }
                            // % 6 car 6 partie par poule de 4 joueurs
                            str2 = GetValue(position[0], p.iJoueur1, p.iJoueur2, p.iArbitre, iPartieEditer % 6);

                            if (str2.Contains("\n"))
                            {
                                _rect = new XRect(x + 1, y + 1, w - 1, h - 1);
                                //_gfx.DrawRectangle(_pen, XBrushes.LightGray, _rect);
                                _tf.DrawString(str2, _font8, XBrushes.Black, _rect, XStringFormats.TopLeft);
                            }
                            else
                            {
                                _rect = new XRect(x, y, w, h);
                                //_gfx.DrawRectangle(_pen, XBrushes.LightGray, _rect);
                                _gfx.DrawString(str2, _font8, XBrushes.Black, _rect, _format);
                            }
                        }
                        iPartieEditer++;
                    }
                }
            }

            _document.Save(_filename);
        }

        /*
         * j1 = Joueur 1
         * j2 = Joueur 2
         * j3 = Arbitre
         */
        private string GetValue(string str, int j1, int j2, int j3, int iPartieEditer)
        {
            Joueur joueur;
            IniFile iniFile = new IniFile(SingletonOutils.FILEINI);
            TimeSpan tHeureDebut = new TimeSpan();

            switch (str)
            {
                case "EPREUVE":                 
                    return iniFile.ReadString("COMPETITION", "division");

                case "NIVEAU":
                    return iniFile.ReadString("COMPETITION", "categorie");

                case "POULE":
                    return _iPouleActive.ToString();

                case "PARTIE":
                    return string.Format("{0} - {1} ({2})", j1, j2, j3);

                case "TABLE":
                    switch(_iPouleActive)
                    {
                        case 1:
                            return _sNumTable1;

                        case 2:
                            return _sNumTable2;

                        case 3:
                            return _sNumTable3;

                        //case 4:
                        default:
                            return _sNumTable4;
                    }

                case "ARBITRE":
                    // j3
                    joueur = getJoueurByDgv(_iPouleActive, j3);
                    return joueur.Nom;

                case "HEURE":
                    tHeureDebut = _tHeureDebut;
                    for (int i = 0; i < iPartieEditer; i++)
                        tHeureDebut = tHeureDebut.Add(_tDuree);
                    return tHeureDebut.ToString(@"hh\:mm");


                case "JOUEURCLUB1":
                    // j1
                    joueur = getJoueurByDgv(_iPouleActive, j1);
                    return joueur.Nom  + "\n" + joueur.club.Nom;

                case "JOUEURCLUB2":
                    // j1
                    joueur = getJoueurByDgv(_iPouleActive, j2);
                    return joueur.Nom + "\n" + joueur.club.Nom;

                case "JOUEUR1":
                    // j1
                    joueur = getJoueurByDgv(_iPouleActive, j1);
                    return joueur.Nom;

                case "JOUEUR2":
                    // j1
                    joueur = getJoueurByDgv(_iPouleActive, j2);
                    return joueur.Nom;

                case "CARTONJ1":
                case "CARTONO1":
                case "CARTONR1":
                case "CARTONJ2":
                case "CARTONO2":
                case "CARTONR2":
                    return " ";

                default:
                    return str + "Inconnu !";
            }
        }

        public void Joueurs313()
        {
            string sCompetition = "XXXXXX";
            // @TODO

            Draw313(sCompetition, 1, 0);

            // Ligne séparatrice du milieu de page
            XPen pen2 = new XPen(XColors.Black, 1);
            pen2.DashStyle = XDashStyle.Dot;
            _gfx.DrawLine(pen2, 0, 421, 595, 421);

            Draw313(sCompetition, 2, 421);

            _page = _document.AddPage();
            _gfx = XGraphics.FromPdfPage(_page);

            Draw313(sCompetition, 3, 0);

            // Ligne séparatrice du milieu de page
            _gfx.DrawLine(pen2, 0, 421, 595, 421);

            Draw313(sCompetition, 4, 421);

            _document.Save(_filename);
        }

        // Ajout d'une image dans le PDF à partir des ressources
        void AddLogo(string RessourceName, int xPosition, int yPosition)
        {
            XImage image = XImage.FromFile(@"C:\SharpDevelop\Criterium_16_4\images\logo_fftt.png");

            _gfx.DrawImage(image, xPosition, yPosition, image.PixelHeight / 3, image.PixelWidth / 3);
        }

        void DrawHeaderJoueur(int yOrigin)
        {
            int[] iW = new int[] { 28, 150, 36, 36, 39, 39, 39, 39, 155 };
            String[] sHeader = new string[] { "N°", "NOM Prénom", "Dossard", "N° Lic.", "Catégorie", "Clt", "Points", "N° Club", "Club" };
            int x2 = 17;
            int j = 0;

            foreach (int i in iW)
            {
                _rect = new XRect(x2, 70 + yOrigin, i, 14);
                _gfx.DrawRectangle(_pen, XBrushes.LightGray, _rect);

                _gfx.DrawString(sHeader[j], _font8, XBrushes.Black, _rect, _format);
                j++;

                x2 += i;
            }
        }

        // Recherche du joueur à partir des données de la gridView
        Joueur getJoueurByDgv(int iNumPoule, int iNum)
        {
            // Découpage du nom et du club
            string[] stringSeparators = new string[] { "\r\n" };

            // Recherche des informations sur le joueur à partir du dataGridViewPoule
            string[] lines = _dgv[iNumPoule - 1, iNum - 1].Value.ToString().Split(stringSeparators, StringSplitOptions.None);

            // Recherche de l'objet Joueur
            return SingletonOutils.ListJoueurs.Find(x => x.Nom.Contains(lines[0]));
        }

        // Cartouche des joueurs
        void DrawRowJoueur(int y, int iNumPoule, int iNum)
        {
            // Recherche de l'objet Joueur
            Joueur J = getJoueurByDgv(iNumPoule, iNum);
            ClubDA clubDA = new ClubDA();

            int[] iW = new int[] { 28, 150, 36, 36, 39, 39, 39, 39, 155 };
            int x2 = 17;

            for (int i = 0; i < 9; i++)
            {
                _rect = new XRect(x2, y, iW[i], 16);
                _gfx.DrawRectangle(_pen, _rect);

                // Dans la première cellule ecrire le numéro
                switch (i)
                {
                    case 0: // N°
                        _gfx.DrawString(iNum.ToString(), _font8, XBrushes.Black, _rect, _format);
                        break;

                    case 1: // Nom
                        _gfx.DrawString(J.Nom, _font8, XBrushes.Black, _rect, _format);
                        break;

                    case 2: // Dossard
                        _gfx.DrawString(J.Dossard.ToString(), _font8, XBrushes.Black, _rect, _format);
                        break;

                    case 3: // N° licence
                        _gfx.DrawString(J.Licence.ToString(), _font8, XBrushes.Black, _rect, _format);
                        break;

                    case 4: // Catégorie
                        break;

                    case 5: // Classement
                        _gfx.DrawString((J.Points / 100).ToString(), _font8, XBrushes.Black, _rect, _format);
                        break;

                    case 6: // points
                        _gfx.DrawString(J.Points.ToString(), _font8, XBrushes.Black, _rect, _format);
                        break;

                    case 7: // N° Club
                        _gfx.DrawString(J.NumeroClub, _font8, XBrushes.Black, _rect, _format);
                        break;

                    case 8: // Club
                        _gfx.DrawString(clubDA.GetNomByNumero(J.NumeroClub), _font8, XBrushes.Black, _rect, _format);
                        break;
                }
                x2 += iW[i];
            }
        }

        // Header du tableau pour les parties
        void DrawHeaderPartie(int y, int iNbrJoueur)
        {
            //     Table,Heure,Partie,F/A,Joueur1,contre,joueur2,F/A,Score 1, 2, 3, 4, 5, J1, J2, J3, J4, J5, J6
            //                        0  1   2   3    4   5    6   7   8   9  10  11  12  13  14  15  16  17  18
            int[] iW = new int[] { 26, 26, 56, 17, 125, 16, 125, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17 };
            String[] sHeader = new string[] { "Table", "Heure", "Partie", "F/A", "Joueur 1", "contre", "Joueur 2", "F/A", "1", "2", "3", "4", "5", "J1", "J2", "J3", "J4", "J5", "J6" };
            int x2 = 17;

            // Si 3 joueurs agrandir d'un pixel la dernière case
            if (iNbrJoueur == 3)
            {
                iW[13] = 23;
                iW[14] = 23;
                iW[15] = 23;
            }

            if (iNbrJoueur > 4) // 5 joueurs
            {
                iW[4] -= 9;
                iW[6] -= 9;
            }

            if (iNbrJoueur == 6) // 6 joueurs
            {
                iW[4] -= 9;
                iW[6] -= 9;
            }

            for (int i = 0; i <= (12 + iNbrJoueur); i++)
            {
                switch (i)
                {
                    case 0:
                    // Table
                    case 1:
                    // Heure
                    case 2:
                        // Partie
                        _rect = new XRect(x2, y, iW[i], 28);
                        _gfx.DrawRectangle(_pen, XBrushes.LightGray, _rect);
                        _gfx.DrawString(sHeader[i], _font8, XBrushes.Black, _rect, _format);
                        break;

                    case 4:
                        // Joueur 1
                        _gfx.DrawRectangle(_pen, XBrushes.LightGray, new XRect(x2, y, iW[i] + iW[i + 1] + iW[i + 2], 28));

                        _rect = new XRect(x2, y, iW[i], 28);
                        _gfx.DrawString(sHeader[i], _font8, XBrushes.Black, _rect, _format);
                        break;

                    case 5:
                        // contre
                        _rect = new XRect(x2, y, iW[i], 28);
                        _gfx.DrawString(sHeader[i], _font8, XBrushes.Black, _rect, _format);
                        break;

                    case 6:
                        // Joueur 2
                        _rect = new XRect(x2, y, iW[i], 28);
                        _gfx.DrawString(sHeader[i], _font8, XBrushes.Black, _rect, _format);
                        break;

                    case 3:
                    // F/A
                    case 7:
                        // F/A
                        _gfx.DrawRectangle(_pen, XBrushes.LightGray, new XRect(x2, y, iW[i], 28));

                        _rect = new XRect(x2, y, iW[i], 14);
                        _gfx.DrawString("F/A", _font8, XBrushes.Black, _rect, _format);

                        _rect = new XRect(x2, y + 14, iW[i], 14);
                        _gfx.DrawString("(1)", _font8, XBrushes.Black, _rect, _format);
                        break;

                    case 8:
                        // Scores 1
                        _rect = new XRect(x2, y, 85, 14);
                        _gfx.DrawRectangle(_pen, XBrushes.LightGray, _rect);
                        _gfx.DrawString("Scores", _font8, XBrushes.Black, _rect, _format);

                        // Points parties
                        if (iNbrJoueur == 3)
                            _rect = new XRect(x2 + 85, y, (iW[13] + iW[14] + iW[15]), 14);
                        else
                            _rect = new XRect(x2 + 85, y, (iW[13] + iW[14] + iW[15] + iW[16]), 14);

                        _gfx.DrawRectangle(_pen, XBrushes.LightGray, _rect);
                        _gfx.DrawString("Points partie", _font8, XBrushes.Black, _rect, _format);

                        _rect = new XRect(x2, y + 14, iW[i], 14);
                        _gfx.DrawRectangle(_pen, XBrushes.LightGray, _rect);
                        _gfx.DrawString(sHeader[i], _font8, XBrushes.Black, _rect, _format);

                        break;


                    case 9:
                    // Scores 2
                    case 10:
                    // Scores 3
                    case 11:
                    // Scores 4
                    case 12:
                    // Scores 5
                    case 13:
                    // Points parties 1
                    case 14:
                    // Points parties 2
                    case 15:
                    // Points parties 3
                    case 16:
                    // Points parties 4
                    case 17:
                    // Points parties 5
                    case 18:
                        // Points parties 6
                        _rect = new XRect(x2, y + 14, iW[i], 14);
                        _gfx.DrawRectangle(_pen, XBrushes.LightGray, _rect);
                        _gfx.DrawString(sHeader[i], _font8, XBrushes.Black, _rect, _format);
                        break;
                }

                x2 += iW[i];
            }
        }

        void DrawRowPartie(int iNumPoule, int iNumPartie, int y, string sPartie, int iNbrJoueur)
        {
            //	   Table,Heure,Partie,F/A,Joueur 1,  - ,Joueur 2,F/A,  1,  2,  3,  4,  5 ,J1, J2, J3, J4, J5, J6
            //       0     1     2     3    4        5    6       7    8   9  10  11  12  13  14  15  16  17  18
            int[] iW = new int[] { 26, 26, 56, 17, 125, 16, 125, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17, 17 };
            int x2 = 17;

            // Si 3 joueurs agrandir les dernières cases
            if (iNbrJoueur == 3)
            {
                iW[13] = 23;
                iW[14] = 23;
                iW[15] = 23;
            }

            // Table pour la poule
            string sTable = "1";

            switch (iNumPoule)
            {
                case 1:
                    sTable = _sNumTable1;
                    break;

                case 2:
                    sTable = _sNumTable2;
                    break;

                case 3:
                    sTable = _sNumTable3;
                    break;

                case 4:
                    sTable = _sNumTable4;
                    break;
            }


            for (int i = 0; i <= (12 + iNbrJoueur); i++)
            {
                _rect = new XRect(x2, y, iW[i], 16);

                switch (i)
                {
                    case 0: // Table
                        _gfx.DrawRectangle(_pen, _rect);
                        _gfx.DrawString(sTable, _font10, XBrushes.Black, _rect, _format);
                        break;

                    case 1: // Heure
                        _gfx.DrawRectangle(_pen, _rect);
                        _gfx.DrawString(CalculHeureDebut(iNumPartie), _font8, XBrushes.Black, _rect, _format);
                        break;

                    case 2: // 1 - 4
                        _gfx.DrawRectangle(_pen, _rect);
                        _gfx.DrawString(sPartie, _font10, XBrushes.Black, _rect, _format);
                        break;

                    case 4:
                        // Grand rectangle pour les deux joueurs et le tiret
                        _gfx.DrawRectangle(_pen, new XRect(x2, y, iW[i] + iW[i + 1] + iW[i + 2], 16));
                        DrawJoueurPartie(sPartie, iNumPoule, true);
                        break;

                    case 5:
                        _gfx.DrawString("-", _font10, XBrushes.Black, _rect, _format);
                        break;

                    case 6:
                        DrawJoueurPartie(sPartie, iNumPoule, false);
                        break;

                    case 13:
                        if (sPartie.CompareTo("2 - 3") == 0 || sPartie.CompareTo("2 - 4") == 0 || sPartie.CompareTo("3 - 4") == 0)
                            _gfx.DrawRectangle(_pen, XBrushes.LightGray, _rect);
                        else
                            _gfx.DrawRectangle(_pen, _rect);
                        break;

                    case 14:
                        if (sPartie.CompareTo("1 - 4") == 0 || sPartie.CompareTo("1 - 3") == 0 || sPartie.CompareTo("3 - 4") == 0)
                            _gfx.DrawRectangle(_pen, XBrushes.LightGray, _rect);
                        else
                            _gfx.DrawRectangle(_pen, _rect);
                        break;

                    case 15:
                        if (sPartie.CompareTo("1 - 4") == 0 || sPartie.CompareTo("2 - 4") == 0 || sPartie.CompareTo("1 - 2") == 0)
                            _gfx.DrawRectangle(_pen, XBrushes.LightGray, _rect);
                        else
                            _gfx.DrawRectangle(_pen, _rect);
                        break;

                    case 16:
                        if (sPartie.CompareTo("2 - 3") == 0 || sPartie.CompareTo("1 - 3") == 0 || sPartie.CompareTo("1 - 2") == 0)
                            _gfx.DrawRectangle(_pen, XBrushes.LightGray, _rect);
                        else
                            _gfx.DrawRectangle(_pen, _rect);
                        break;

                    default:
                        _gfx.DrawRectangle(_pen, _rect);
                        break;
                }

                x2 += iW[i];
            }
        }

        /*
		 * Calcul de l'heure de début d'une partie
		 */
        private string CalculHeureDebut(int iPartie)
        {
            TimeSpan hd = new TimeSpan(_tHeureDebut.Hours, _tHeureDebut.Minutes, 0);
            TimeSpan hd2 = new TimeSpan();

            for (int i = 0; i < iPartie; i++)
            {
                hd2 = hd.Add(_tDuree);
                hd = hd2;
            }

            return hd.ToString(@"hh\:mm");
        }

        /*
		 * bool vrai -> Premier joueur
		 * 		faux -> Deuxième joueur
		 */
        private void DrawJoueurPartie(string sPartie, int iNumPoule, bool bFirstJoueur)
        {
            // 1 - 4
            int iNum;

            // Code ascii du 1 = 49
            if (bFirstJoueur)
                iNum = sPartie[0] - 48;
            else
                iNum = sPartie[4] - 48;

            // Recherche de l'objet Joueur
            Joueur joueur = getJoueurByDgv(iNumPoule, iNum);

            _gfx.DrawString(joueur.Nom, _font10, XBrushes.Black, _rect, _format);
        }

        public void Joueurs413()
        {
            string sCompetition = "XXXX";
            // @TODO

            _gfx = XGraphics.FromPdfPage(_page);

            Draw413(sCompetition, 1, 0);

            // Ligne séparatrice du milieu de page
            XPen pen2 = new XPen(XColors.Black, 1);
            pen2.DashStyle = XDashStyle.Dot;
            _gfx.DrawLine(pen2, 0, 421, 595, 421);

            Draw413(sCompetition, 2, 421);

            _page = _document.AddPage();
            _gfx = XGraphics.FromPdfPage(_page);

            Draw413(sCompetition, 3, 0);

            // Ligne séparatrice du milieu de page
            _gfx.DrawLine(pen2, 0, 421, 595, 421);

            Draw413(sCompetition, 4, 421);

            _document.Save(_filename);
        }

        void Draw313(string sCompetition, int iNumPoule, int yOrigin)
        {
            String[] sPartie = new[] { "1 - 3", "2 - 3", "1 - 2" };

            AddLogo("logo_fftt", 30, yOrigin);

            _gfx.DrawString(sCompetition, _font14b, XBrushes.Black, new XRect(80, 5 + yOrigin, 450, 30), _format);
            _gfx.DrawString("POULE N° " + iNumPoule.ToString(), _font18b, XBrushes.Black, new XRect(100, 35 + yOrigin, 450, 30), _format);

            int y = DrawTableauJoueur(yOrigin, 3, iNumPoule);

            //  Espace entre les tableaux
            y += 15;
            DrawHeaderPartie(y, 3);

            // 2 header du tableau = 2 * 14
            y += 28;
            for (int i = 0; i < sPartie.Length; i++)
                DrawRowPartie(iNumPoule, i, y + (16 * i), sPartie[i], 3);

            y += (16 * sPartie.Length) + 3;

            // Ecriture des commentaires
            _rect = new XRect(17, y, 280, 16);
            _gfx.DrawString("(1) A = Abandon ou disqualification en cours de partie", _font6, XBrushes.Black, _rect, _formatLeft);

            _rect = new XRect(26, y + 8, 280, 16);
            _gfx.DrawString("F = Forfait, disqualification en dehors d'une partie ou refus de jouer", _font6, XBrushes.Black, _rect, _formatLeft);

            // Total des points parties
            y -= 3;
            _rect = new XRect(425, y, 85, 16);
            _gfx.DrawRectangle(_pen, XBrushes.LightGray, _rect);
            _gfx.DrawString("Total points parties", _font6, XBrushes.Black, _rect, _format);

            for (int i = 0; i < 3; i++)
            {
                _rect = new XRect(510 + (i * 23), y, 23, 16);
                _gfx.DrawRectangle(_pen, _rect);
            }

            // Classement
            y += 16;
            _rect = new XRect(425, y, 85, 16);
            _gfx.DrawRectangle(_pen, XBrushes.LightGray, _rect);
            _gfx.DrawString("Classement", _font6, XBrushes.Black, _rect, _format);

            for (int i = 0; i < 3; i++)
            {
                _rect = new XRect(510 + (i * 23), y, 23, 16);
                _gfx.DrawRectangle(_pen, _rect);
            }
        }

        void Draw413(string sCompetition, int iNumPoule, int yOrigin)
        {
            String[] sPartie = new[] { "1 - 4", "2 - 3", "1 - 3", "2 - 4", "1 - 2", "3 - 4" };
            /* 	{ "1 - 3", "2 - 3", "1 - 2" }
			 * 	{ "1 - 3", "1 - 2", "2 - 3" }
			 *	{ "1 - 3", "2 - 4", "1 - 2", "3 - 4", "1 - 4", "2 - 3"
			 *	{ "2 - 5", "3 - 4", "1 - 5", "2 - 3", "1 - 4", "3 - 5", "1 - 3", "2 - 4", "1 - 2", "4 - 5"
			 *	{ "2 - 5", "3 - 4", "1 - 4", "3 - 5", "1 - 3", "2 - 4", "1 - 2", "4 - 5", "1 - 5", "2 - 3"
			 *	{ "1 - 6", "2 - 5", "3 - 4", "1 - 5", "4 - 6", "2 - 3", "1 - 4", "3 - 5", "2 - 6", "1 - 3", "2 - 4", "5 - 6", "1 - 2", "3 - 6", "4 - 5"
			 *	{ "1 - 6", "2 - 5", "3 - 4", "1 - 4", "3 - 5", "2 - 6", "1 - 3", "2 - 4", "5 - 6", "1 - 2", "3 - 6", "4 - 5", "1 - 5", "4 - 6", "2 - 3"
			 */

            AddLogo("logo_fftt", 30, yOrigin);

            _gfx.DrawString(sCompetition, _font14b, XBrushes.Black, new XRect(80, 5 + yOrigin, 450, 30), _format);
            _gfx.DrawString("POULE N° " + iNumPoule.ToString(), _font18b, XBrushes.Black, new XRect(100, 35 + yOrigin, 450, 30), _format);

            int y = DrawTableauJoueur(yOrigin, 4, iNumPoule);

            //  Espace entre les tableaux
            y += 15;
            DrawHeaderPartie(y, 4);

            // 2 header du tableau = 2 * 14
            y += 28;
            for (int i = 0; i < sPartie.Length; i++)
                DrawRowPartie(iNumPoule, i, y + (16 * i), sPartie[i], 4);

            y += (16 * sPartie.Length) + 3;

            // Ecriture des commentaires
            _rect = new XRect(17, y, 280, 16);
            _gfx.DrawString("(1) A = Abandon ou disqualification en cours de partie", _font6, XBrushes.Black, _rect, _formatLeft);

            _rect = new XRect(26, y + 8, 280, 16);
            _gfx.DrawString("F = Forfait, disqualification en dehors d'une partie ou refus de jouer", _font6, XBrushes.Black, _rect, _formatLeft);

            // Total des points parties
            y -= 3;
            _rect = new XRect(425, y, 85, 16);
            _gfx.DrawRectangle(_pen, XBrushes.LightGray, _rect);
            _gfx.DrawString("Total points parties", _font6, XBrushes.Black, _rect, _format);

            for (int i = 0; i < 4; i++)
            {
                _rect = new XRect(510 + (i * 17), y, 17, 16);
                _gfx.DrawRectangle(_pen, _rect);
            }

            // Classement
            y += 16;
            _rect = new XRect(425, y, 85, 16);
            _gfx.DrawRectangle(_pen, XBrushes.LightGray, _rect);
            _gfx.DrawString("Classement", _font6, XBrushes.Black, _rect, _format);

            for (int i = 0; i < 4; i++)
            {
                _rect = new XRect(510 + (i * 17), y, 17, 16);
                _gfx.DrawRectangle(_pen, _rect);
            }
        }

        // Affiche le tableau des joueurs pour 3, 4, 5 et 6 joueurs
        int DrawTableauJoueur(int yOrigin, int iNbrJoueur, int iNumPoule)
        {
            int iReturn = 132;

            DrawHeaderJoueur(yOrigin);
            DrawRowJoueur(84 + yOrigin, iNumPoule, 1);
            DrawRowJoueur(100 + yOrigin, iNumPoule, 2);
            DrawRowJoueur(116 + yOrigin, iNumPoule, 3);

            if (iNbrJoueur > 3)
            {
                DrawRowJoueur(132 + yOrigin, iNumPoule, 4);
                iReturn = 164;
            }

            if (iNbrJoueur > 4)
            {
                DrawRowJoueur(148 + yOrigin, iNumPoule, 5);
                iReturn = 148;
            }

            if (iNbrJoueur == 6)
            {
                DrawRowJoueur(164 + yOrigin, iNumPoule, 6);
                iReturn = 180;
            }

            return iReturn + yOrigin;
        }
    }
}
