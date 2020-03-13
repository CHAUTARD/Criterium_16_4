using PetaPoco;

namespace Criterium_16_4
{
    [TableName("CompetitionsLicences")]
    [PrimaryKey("IdCompetitionLicence", AutoIncrement = true)]

    class CompetitionLicence
    {
        public int IdCompetitionLicence { get; set; }
        public int IdCompetition { get; set; }
        public int Licence { get; set; }

        public CompetitionLicence(int idCompetition, int licence)
        {
            IdCompetition = idCompetition;
            Licence = licence;
        }
    }
}