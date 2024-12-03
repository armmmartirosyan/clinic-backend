namespace Clinic.Models
{
    [Table("procedure_names")]
    public class ProcedureNames
    {
        [Column("id")]
        public required int Id { get; set; }

        [Column("name", TypeName = "VARCHAR(50)")]
        public required string Name { get; set; }
    }
}
