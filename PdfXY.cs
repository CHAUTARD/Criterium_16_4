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

        IniFile _iniFile;

        public PdfXY()
        {
            _iniFile = new IniFile(SingletonOutils.FILEINI);
        }

        public int ReadNbr()
        {
            return int.Parse(_iniFile.ReadString( SECTION, "nombre"));
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

            string chaine = _iniFile.ReadString(SECTION, string.Format("zone{0}", iZone));

            string[] Splitter = myRegex.Split(chaine);

            return new string[] { Splitter[1], Splitter[2], Splitter[3], Splitter[4], Splitter[5] };
        }
    }
}
