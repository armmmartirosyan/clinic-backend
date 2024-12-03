namespace Clinic.Models
{
    public class Dentists
    {
        [Column("id")]
        public required int Id { get; set; }

        [Column("first_name", TypeName = "VARCHAR(50)")]
        public required string FirstName { get; set; }

        [Column("last_name", TypeName = "VARCHAR(50)")]
        public required string LastName { get; set; }

        [Column("phone", TypeName = "VARCHAR(20)")]
        public required string Phone { get; set; }

        [Column("email", TypeName = "VARCHAR(255)")]
        public required string Email { get; set; }

        [Column("image_url", TypeName = "VARCHAR(255)")]
        public required string ImageUrl { get; set; }

        [Column("password", TypeName = "CHAR(32)")]
        public required string Password { get; set; }

        [Column("week_day_schedule")]
        public required ICollection<WeekDaySchedule> WeekDaySchedule { get; set; }

        [Column("not_working_days")]
        public required ICollection<NotWorkingDays> NotWorkingDays { get; set; }

        [Column("registrations")]
        public required ICollection<Registrations> Registrations { get; set; }

        [Column("procedures")]
        public required ICollection<Procedures> Procedures { get; set; }

        [Column("specialization")]
        public required Specializations Specialization { get; set; }
    }
}
