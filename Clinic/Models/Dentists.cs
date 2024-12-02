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

        //specialization(ENUM: Specialty of the dentist, e.g., orthodontist, endodontist)
        //week_day_schedule(One to many, relates to Week Day Schedule table)
        //not_working_days(One to many, relates to Not Working Days table)
        //registrations(Many to many, relates to Registrations table)
        //procedures(Many to many, relates to Procedures table)
    }
}
