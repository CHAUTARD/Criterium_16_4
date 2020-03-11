namespace Criterium_16_4
{
    using System;
    using System.Collections.Generic;
    
    public partial class Joueur
    {
        public Joueur()
        {
        }
    
        public int IdJoueur { get; set; }
        public bool IsPresent { get; set; }
        public int Numero { get; set; }
        public string Nom { get; set; }
        public string Dossard { get; set; }
        public string Licence { get; set; }
        public int IdCategory { get; set; }
        public int Points { get; set; }
        public System.DateTime DatNais { get; set; }
        public int IdClub { get; set; }
        public char Lettre { get; set; }
        public int Ordre { get; set; }
        public char Poule { get; set; }
        public int NumInPoule { get; set; }
        public int Classement { get; set; }
    
        public virtual Categorie Categorie { get; set; }
        public virtual Club Club { get; set; }
    }
}
