using PetaPoco;

namespace Criterium_16_4
{
    [TableName("CompetitionsLicences")]
    [PrimaryKey("IdCompetition,Licence", AutoIncrement = false)]

    class CompetitionLicence
    {
        public int IdCompetition { get; set; }
        public int Licence { get; set; }

        public CompetitionLicence(int idCompetition, int licence)
        {
            IdCompetition = idCompetition;
            Licence = licence;
        }
    }
}