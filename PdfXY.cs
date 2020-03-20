using System.Text.RegularExpressions;

namespace Criterium_16_4
{
    class PdfXY
    {
        const string SECTION = "ARB001";
        public string Str { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int W { get; set; }
        public int H { get; set; }

        public int NOMBRE { get; }

        /*
            nombre=11
            zone1=EPREUVE;102;35;157;13
            zone2=NIVEAU;102;53;157;13
            zone3=POULE;128;70;52;13
            zone4=TABLE;234;70;26;13
            zone5=ARBITRE;77;88;103;13
            zone6=HEURE;208;88;52;13
            zone7=PARTIE;112;114;35;13
            zone8=JOUEURCLUB1;25;137;130;50
            zone9=JOUEURCLUB2;25;210;130;50
            zone10=JOUEUR1;25;292;130;30
            ; zone10=CARTONJ1;155;292;26;30
            ; zone11=CARTONO1;181;292;26;30
            ; zone12=CARTONR1;207;292;26;30
            zone11=JOUEUR2;25;323;130;30
            ; zone14=CARTONJ2;155;323;26;30
            ; zone15=CARTONO2;181;323;26;30
            ; zone16=CARTONR2;207;323;26;30
         */
        readonly string[] _value = {
            "EPREUVE;102;35;157;13",
            "NIVEAU;102;53;157;13",
            "POULE;128;70;52;13",
            "TABLE;234;70;26;13",
            "ARBITRE;77;88;103;13",
            "HEURE;208;88;52;13",
            "PARTIE;112;114;35;13",
            "JOUEURCLUB1;25;137;130;50",
            "JOUEURCLUB2;25;210;130;50",
            "JOUEUR1;25;292;130;30",
            "JOUEUR2;25;323;130;30"
        };

        public PdfXY()
        {
            NOMBRE = 11;
        }

        /*
         * Lecture d'ue entrée d    ns le fichier ini
         * et éclatement des paramètres :
         * - Clé
         * - X position verticale
         * - Y position horizontale
         * - W taille verticale
         * - H taille horizontale
         */
        public string[] ReadInit(int iZone)
        {
            Regex myRegex = new Regex(@"^([A-Z]+[1-2]?);([0-9]+);([0-9]+);([0-9]+);([0-9]+)$");

            string str = _value[iZone];

            // Recherche du premier ;
            int first = str.IndexOf(";");

            string chaine = str.Substring(first + 1);

            string[] Splitter = myRegex.Split(chaine);

            return new string[] { Splitter[1], Splitter[2], Splitter[3], Splitter[4], Splitter[5] };
        }
    }
}
