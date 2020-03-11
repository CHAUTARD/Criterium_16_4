using System;

namespace Criterium_16_4
{
    public class PartieQuiJoue : IEquatable<PartieQuiJoue>
    {
        public int iJoueur1 { get; set; }
        public int iJoueur2 { get; set; }
        public int iArbitre { get; set; }

        public PartieQuiJoue(int joueur1, int joueur2, int arbitre)
        {
            iJoueur1 = joueur1;
            iJoueur2 = joueur2;
            iArbitre = arbitre;
        }

        public string getRencontre()
        {
            return string.Format("{0} - {1}", iJoueur1, iJoueur2);
        }

        public string getRencontreArbitre()
        {
            return string.Format("{0} - {1} ({2})", iJoueur1, iJoueur2, iArbitre);
        }

        public bool Equals(PartieQuiJoue other)
        {
            if (other == null) return false;

            return (iJoueur1.Equals(other.iJoueur1) && iJoueur2.Equals(other.iJoueur2));
        }
    }
}
