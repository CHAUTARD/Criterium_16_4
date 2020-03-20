using PetaPoco;

namespace Criterium_16_4
{
    [TableName("Competitions")]
    [PrimaryKey("IdCompetition", AutoIncrement = true)]

    public class Competition
    {
        public int IdCompetition { get; set; }
        public int IdCategorie { get; set; }
        public int IdDivision { get; set; }
        public int IdGroupe { get; set; }
        public string Tour { get; set; }
        public string sDate { get; set; }
        public string Commentaire { get; set; }
        public int Table1 { get; set; }
        public int Table2 { get; set; }
        public int Table3 { get; set; }
        public int Table4 { get; set; }
    }
}