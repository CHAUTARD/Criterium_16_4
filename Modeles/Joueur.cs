using PetaPoco;
using System;

namespace Criterium_16_4
{
    [TableName("Joueurs")]
    [PrimaryKey("Licence", AutoIncrement = false)]
    public class Joueur
    {
        public int Licence { get; set; }
        public bool IsPresent { get; set; }
        public int Numero { get; set; }
        public string Nom { get; set; }
        public int Dossard { get; set; }
        public int Points { get; set; }
        public DateTime DatNais { get; set; }
        public string NumeroClub { get; set; }
        public char Lettre { get; set; }
        public int Ordre { get; set; }
        public char Poule { get; set; }
        public int NumInPoule { get; set; }
        public int Classement { get; set; }
        public int PartieGagnee { get; set; }
        public int PartiePerdu { get; set; }
        public int NombreArbitrage { get; set; }
        public bool EnCour { get; set; }
        public bool EnArbitrage { get; set; }
        public Joueur() 
        {
            IsPresent = false;
            Points = 500;
            NumInPoule = 1;
            Ordre = 1;
            Dossard = 1;
            Lettre = 'A';
            Poule = 'A';
            Classement = 1;
            PartieGagnee = 0;
            PartiePerdu = 0;
            NombreArbitrage = 0;
            EnCour = false;
            EnArbitrage = false;
        }

        public Joueur GetJoueurByLicence(int iLicence)
        {
            if (iLicence > 0)
            {
                using (var db = new PetaPoco.Database("SqliteConnect"))
                {
                    return db.Single<Joueur>(iLicence);
                }
            }
            return null;
        }


        [Ignore]
        public Club club { get; set; }
    }
}
