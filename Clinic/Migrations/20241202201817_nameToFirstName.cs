using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinic.Migrations
{
    /// <inheritdoc />
    public partial class nameToFirstName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Patients");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Patients",
                newName: "id");

            migrationBuilder.AddColumn<string>(
                name: "first_name",
                table: "Patients",
                type: "VARCHAR(50)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "first_name",
                table: "Patients");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Patients",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Patients",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
