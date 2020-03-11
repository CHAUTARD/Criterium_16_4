using PetaPoco;
using System.Collections;

namespace Criterium_16_4
{
    [TableName("Parametres")]
    [PrimaryKey("IdParametre", AutoIncrement = true)]
    class Parametre : IEnumerable
    {
        public Parametre() {}

        public Parametre(int idParametre, string titre, string commentaire, string init)
        {
            IdParametre = idParametre;
            Titre = titre;
            Commentaire = commentaire;
            Init = init;
        }

        public int IdParametre { get; set; }
        public string Titre { get; set; }
        public string Commentaire { get; set; }
        public string Init { get; set; }

        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}
