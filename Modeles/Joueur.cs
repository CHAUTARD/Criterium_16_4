using PetaPoco;
using System;

namespace Criterium_16_4
{
    [TableName("Joueurs")]
    [PrimaryKey("Licence", AutoIncrement = false)]
    [ExplicitColumns]
    public class Joueur
    {
        
        [Column] public int Licence { get; set; }
        [Column] public bool IsPresent { get; set; }
        [Column] public int Numero { get; set; }
        [Column] public string Nom { get; set; }
        [Column] public int Dossard { get; set; }
        [Column] public int Points { get; set; }
        [Column] public DateTime DatNais { get; set; }
        [Column] public string NumeroClub { get; set; }
        [Column] public char Lettre { get; set; }
        [Column] public int Ordre { get; set; }
        [Column] public char Poule { get; set; } // A, B, C, D
        [Column] public int NumInPoule { get; set; } // 1, 2, 3, 4
        [Column] public string Tableau { get; set; }    // 
        [Column] public int Classement { get; set; } // 1 .. 16

        public Joueur() 
        {
            IsPresent = false;
            Points = 500;
            
            Ordre = 1;
            Dossard = 1;
            Lettre = 'A';
            Poule = 'A';
            NumInPoule = 1;
            Classement = 16;
            Tableau = "";
        }

        [Ignore]
        [ResultColumn]
        public Club club { get; set; }
    }
}
