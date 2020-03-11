namespace Criterium_16_4
{
    class ClubLettre : Club
    {
        public char Lettre { get; set; }

        public ClubLettre(string numero, string nom, char lettre = 'A')
        {
            Numero = numero;
            Nom = nom;
            Lettre = lettre;
        }

        public ClubLettre(char lettre = 'A')
        {
            Lettre = lettre;
        }

        public Club GetClubByNom(string nom)
        {
            Club club = new Club();

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                return db.FirstOrDefault<Club>("SELECT * FROM Clubs WHERE Nom = \"@0\"", nom);
            }
        }

        public Club GetClubByNumero(string numero)
        {
            Club club = new Club();

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                return db.FirstOrDefault<Club>("SELECT * FROM Clubs WHERE Numero = @0", numero);
            }
        }
    }
}
