/*
 * Crée par Patrick.
 * Utilisateur: CHAUTARD
 * Date: 28/02/2020
 */

namespace Criterium_16_4
{
    class ClubDA
    {
        public Club GetClubByName(string nom)
        {
            Club club = new Club();

            // Recherche dans la table des clubs
            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                club = db.FirstOrDefault<Club>("SELECT * FROM Clubs WHERE Nom = @0", nom);
            }
            return club;
        }

        public Club GetClubByNumero(string numeroClubb)
        {
            Club club = new Club();

            // Recherche dans la table des clubs
            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                club = db.FirstOrDefault<Club>("SELECT * FROM Clubs WHERE Numero = @0", numeroClubb);
            }
            return club;
        }

        public string GetNomByNumero(string numeroClub)
        {
            Club club = GetClubByNumero(numeroClub);

            return club.Nom;
        }
    }
}
