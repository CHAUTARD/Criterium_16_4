using PetaPoco;

namespace Criterium_16_4
{
    [TableName("Clubs")]
    [PrimaryKey("Numero", AutoIncrement = false)]
    public class Club
    {
        public string Numero { get; set; }
        public string Nom { get; set; }

        public Club() { }

        public Club(string numero, string nom)
        {
            this.Numero = numero;
            this.Nom = nom;
        }
    }
}
