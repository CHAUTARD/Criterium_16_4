//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Criterium_16_4
{
    using System;
    using System.Collections.Generic;
    
    public partial class Arbitrage
    {
        public int IdArbitrage { get; set; }
        public Nullable<int> IdJoueur { get; set; }
        public int PartieGagnee { get; set; }
        public int PartiePerdu { get; set; }
        public int NbrArbitrage { get; set; }
        public bool EnCour { get; set; }
        public bool EnArbitrage { get; set; }
    
        public virtual Joueur Joueur { get; set; }
    }
}
