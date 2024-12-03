namespace Clinic.Models
{
    public enum Status
    {
        Pending = 1,
        Rejected = 2,
        Accepted = 3
    }

    public class Registrations
    {
        [Column("id")]
        public required int Id { get; set; }

        [Column("date", TypeName = "DATE")]
        public required DateTime Date { get; set; }

        [Column("start_time", TypeName = "TIME")]
        public required TimeSpan StartTime { get; set; }

        [Column("end_time", TypeName = "TIME")]
        public required TimeSpan EndTime { get; set; }

        [Column("calling_time", TypeName = "TIME")]
        public required TimeSpan CallingTime { get; set; }

        [Column("notes", TypeName = "VARCHAR(255)")]
        public required string Notes { get; set; }

        [Column("status", TypeName = "TINYINT")]
        public required Status Status { get; set; }

        [Column("dentist")]
        public required Dentists Dentist { get; set; }

        //	patient_id (INT, Foreign Key, relates to Patients.id)
    }
}
