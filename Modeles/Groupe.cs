using PetaPoco;

namespace Criterium_16_4
{
    [TableName("Groupes")]
    [PrimaryKey("IdGroupe", AutoIncrement = true)]

    public class Groupe
    {     
        public int IdGroupe { get; set; }
        public string Nom { get; set; }

        public Groupe() { }

        public Groupe(string nom)
        {
            Nom = nom;
        }
    }
}
