using PetaPoco;

namespace Criterium_16_4
{
    [TableName("Categories")]
    [PrimaryKey("IdCategorie", AutoIncrement = true)]
    public class Categorie
    {
        public int IdCategorie { get; set; }
        public string Nom { get; set; }
        public string Commentaire { get; set; }
        public string Parent { get; set; }
        public int Ord { get; set; }

        public Categorie()
        {
        }

        public Categorie(string nom, string commentaire, string parent, int ord)
        {
            Nom = nom;
            Commentaire = commentaire;
            Parent = parent;
            Ord = ord;
        }
    }
}
