namespace Clinic.Models
{
    [Table("not_wordking_days")]
    public class NotWorkingDays
    {
        [Column("id")]
        public required int Id { get; set; }

        [Column("date", TypeName = "DATE")]
        public required DateTime Date { get; set; }

        [Column("dentist")]
        public required Dentists Dentist { get; set; }
    }
}
