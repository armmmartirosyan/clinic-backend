namespace Clinic.Models
{
    public class Patients
    {
        [Column("id")]
        public required int Id { get; set; }

        [Column("first_name", TypeName = "VARCHAR(50)")]
        public required string FirstName { get; set; }

        [Column("last_name", TypeName = "VARCHAR(50)")]
        public required string LastName { get; set; }

        [Column("birth_date", TypeName = "DATE")]
        public required DateTime BirthDate {  get; set; }

        [Column("phone", TypeName = "VARCHAR(20)")]
        public required string Phone { get; set; }

        [Column("email", TypeName = "VARCHAR(255)")]
        public required string Email { get; set; }

        [Column("image_url", TypeName = "VARCHAR(255)")]
        public required string ImageUrl { get; set; }

        [Column("password", TypeName = "CHAR(32)")]
        public required string Password { get; set; }

        //procedures(Many to many, relates to Procedures table)
        //registrations(Many to many, relates to Registrations table)

    }
}
