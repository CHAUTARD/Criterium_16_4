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
        public char Poule { get; set; } // A, B, C, D
        public int NumInPoule { get; set; } // 1, 2, 3, 4
        public string Tableau { get; set; }    // 
        public int Classement { get; set; } // 1 .. 16
        public Joueur() 
        {
            IsPresent = false;
            Points = 500;
            NumInPoule = 1;
            Ordre = 1;
            Dossard = 1;
            Lettre = 'A';
            Poule = 'A';
            Classement = 16;
            Tableau = "";
        }

        [Ignore]
        public Club club { get; set; }
    }
}
