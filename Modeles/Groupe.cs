namespace Criterium_16_4
{
    public class Groupe
    {     
        public int IdGroupe { get; set; }
        public string Nom { get; set; }

        public Groupe() { }

        public Groupe(string nom)
        {
            this.Nom = nom;
        }
    }
}
