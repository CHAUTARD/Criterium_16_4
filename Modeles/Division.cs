namespace Criterium_16_4
{   
    public class Division
    {
        public int IdDivision { get; set; }
        public string Nom { get; set; }
        public string NomLong { get; set; }
        public string Niveau { get; set; }
        public int Ord { get; set; }

        public Division() { }

        public Division(string nom, string nomLong, string niveau, int ord)
        {
            Nom = nom;
            NomLong = nomLong;
            Niveau = niveau;
            Ord = ord;
        }
    }
}
