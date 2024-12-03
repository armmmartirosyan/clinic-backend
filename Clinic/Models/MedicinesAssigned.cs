namespace Clinic.Models
{
    [Table("medicines_assigned")]
    public class MedicinesAssigned
    {
        [Column("id")]
        public required int Id { get; set; }

        [Column("name", TypeName = "VARCHAR(50)")]
        public required string Name { get; set; }

        [Column("dose", TypeName = "VARCHAR(10)")]
        public required string Dose { get; set; }

        [Column("notes", TypeName = "VARCHAR(255)")]
        public required string Notes { get; set; }

        [Column("start_date", TypeName = "DATE")]
        public required DateTime StartDate { get; set; }

        [Column("quantity", TypeName = "TINYINT")]
        public required int Quantity { get; set; }

        [Column("day_count", TypeName = "TINYINT")]
        public required int DayCount { get; set; }

        //procedureId(Many to many, relates to Procedures table)
        //patient_id(INT, Foreign Key, relates to Patients.id)
        //dentist_id(INT, Foreign Key, relates to Dentists.id)

    }
}
