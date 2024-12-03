using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinic.Migrations
{
    /// <inheritdoc />
    public partial class dentistsRel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DentistId",
                table: "week_day_schedule",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DentistId",
                table: "Registrations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DentistId",
                table: "Procedures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DentistId",
                table: "not_wordking_days",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_week_day_schedule_DentistId",
                table: "week_day_schedule",
                column: "DentistId");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_DentistId",
                table: "Registrations",
                column: "DentistId");

            migrationBuilder.CreateIndex(
                name: "IX_Procedures_DentistId",
                table: "Procedures",
                column: "DentistId");

            migrationBuilder.CreateIndex(
                name: "IX_not_wordking_days_DentistId",
                table: "not_wordking_days",
                column: "DentistId");

            migrationBuilder.AddForeignKey(
                name: "FK_not_wordking_days_Dentists_DentistId",
                table: "not_wordking_days",
                column: "DentistId",
                principalTable: "Dentists",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Procedures_Dentists_DentistId",
                table: "Procedures",
                column: "DentistId",
                principalTable: "Dentists",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Dentists_DentistId",
                table: "Registrations",
                column: "DentistId",
                principalTable: "Dentists",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_week_day_schedule_Dentists_DentistId",
                table: "week_day_schedule",
                column: "DentistId",
                principalTable: "Dentists",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_not_wordking_days_Dentists_DentistId",
                table: "not_wordking_days");

            migrationBuilder.DropForeignKey(
                name: "FK_Procedures_Dentists_DentistId",
                table: "Procedures");

            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Dentists_DentistId",
                table: "Registrations");

            migrationBuilder.DropForeignKey(
                name: "FK_week_day_schedule_Dentists_DentistId",
                table: "week_day_schedule");

            migrationBuilder.DropIndex(
                name: "IX_week_day_schedule_DentistId",
                table: "week_day_schedule");

            migrationBuilder.DropIndex(
                name: "IX_Registrations_DentistId",
                table: "Registrations");

            migrationBuilder.DropIndex(
                name: "IX_Procedures_DentistId",
                table: "Procedures");

            migrationBuilder.DropIndex(
                name: "IX_not_wordking_days_DentistId",
                table: "not_wordking_days");

            migrationBuilder.DropColumn(
                name: "DentistId",
                table: "week_day_schedule");

            migrationBuilder.DropColumn(
                name: "DentistId",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "DentistId",
                table: "Procedures");

            migrationBuilder.DropColumn(
                name: "DentistId",
                table: "not_wordking_days");
        }
    }
}
