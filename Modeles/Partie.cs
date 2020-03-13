using PetaPoco;

namespace Criterium_16_4
{
    [TableName("Parties")]
    [PrimaryKey("IdPartie", AutoIncrement = true)]
    public class Partie
    {
        public int IdPartie { get; set; }

        public string sPartie { get; set; }

        private int licence1;
        private Joueur joueur1;

        public int GetLicence1()
        {
            return licence1;
        }

        public void SetLicence1(int value)
        {
            licence1 = value;
            joueur1 = SingletonOutils.GetJoueurByLicence(licence1);
        }

        private int licence2;
        private Joueur joueur2;

        public int GetLicence2()
        {
            return licence2;
        }

        public void SetLicence2(int value)
        {
            licence2 = value;
            joueur2 = SingletonOutils.GetJoueurByLicence(licence2);
        }

        private int licenceArbitre;
        private Joueur joueurArbitre; // Arbitre

        public int GetLicenceArbitre()
        {
            return licenceArbitre;
        }

        public void SetLicenceArbitre(int value)
        {
            licenceArbitre = value;
            joueurArbitre = SingletonOutils.GetJoueurByLicence(licenceArbitre);
        }

        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public int Score3 { get; set; }
        public int Score4 { get; set; }
        public int Score5 { get; set; }

        public bool Abandon1 { get; set; }
        public bool Abandon2 { get; set; }

        public bool Forfait1 { get; set; }
        public bool Forfait2 { get; set; }

        // Carton Jaune
        public bool CartonJ1 { get; set; }
        public bool CartonJ2 { get; set; }

        // Carton J + R 1
        public bool CartonO1 { get; set; }
        public bool CartonO2 { get; set; }

        // Carton J + R 2
        public bool CartonR1 { get; set; }
        public bool CartonR2 { get; set; }

        public Partie(string spartie, int licence1 = 0, int licence2 = 0, int licenceArbitre = 0)
        {
            sPartie = spartie;
            SetLicence1(licence1);
            SetLicence2(licence2);
            SetLicenceArbitre(licenceArbitre);
        }

        public Partie(int idPartie, string spartie, int licence1, int licence2, int licenceArbitre, 
            int score1, int score2, int score3, int score4, int score5, 
            bool abandon1, bool abandon2, bool forfait1, bool forfait2, 
            bool cartonJ1, bool cartonJ2, bool cartonO1, bool cartonO2, bool cartonR1, bool cartonR2)
        {
            IdPartie = idPartie;
            sPartie = spartie;
            SetLicence1(licence1);
            SetLicence2(licence2);
            SetLicenceArbitre(licenceArbitre);
            Score1 = score1;
            Score2 = score2;
            Score3 = score3;
            Score4 = score4;
            Score5 = score5;
            Abandon1 = abandon1;
            Abandon2 = abandon2;
            Forfait1 = forfait1;
            Forfait2 = forfait2;
            CartonJ1 = cartonJ1;
            CartonJ2 = cartonJ2;
            CartonO1 = cartonO1;
            CartonO2 = cartonO2;
            CartonR1 = cartonR1;
            CartonR2 = cartonR2;
        }

        public Partie()
        {
        }

        public Joueur GetJoueur1()
        {
            return joueur1;
        }

        public void SetJoueur1(Joueur value)
        {
            joueur1 = value;
            SetLicence1(value.Licence);
        }

        public Joueur GetJoueur2()
        {
            return joueur2;
        }

        public void SetJoueur2(Joueur value)
        {
            joueur2 = value;
            SetLicence2(value.Licence);
        }

        public Joueur GetJoueurArbitre()
        {
            return joueurArbitre;
        }

        public void SetJoueurArbitre(Joueur value)
        {
            joueurArbitre = value;
            SetLicenceArbitre(value.Licence);
        }
    }
}
