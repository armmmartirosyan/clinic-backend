namespace Clinic.Models
{
    public class Procedures
    {
        [Column("id")]
        public required int Id { get; set; }

        [Column("notes", TypeName = "VARCHAR(255)")]
        public required string Notes { get; set; }

        [Column("date", TypeName = "DATE")]
        public required DateTime Date { get; set; }

        [Column("start_time", TypeName = "TIME")]
        public required TimeSpan StartTime { get; set; }

        [Column("end_time", TypeName = "TIME")]
        public required TimeSpan EndTime { get; set; }

        [Column("price", TypeName = "Decimal(10,2)")]
        public required Decimal Price { get; set; }

        //name (VARCHAR(50))
        //patient_id(INT, Foreign Key, relates to Patients.id)
        //dentist_id(INT, Foreign Key, relates to Dentists.id)
        //images(One to many, relates to Procedure Images table)
        //medicines taken
    }
}
