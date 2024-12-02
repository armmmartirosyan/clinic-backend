namespace Clinic.Models
{
    public class ProcedureImages
    {
        [Column("id")]
        public required int Id { get; set; }

        [Column("url", TypeName = "VARCHAR(255)")]
        public required string Url { get; set; }

        //procedure_id (INT, Foreign Key, relates to Procedures.id)
    }
}
