using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinic.Migrations
{
    /// <inheritdoc />
    public partial class patientsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "birth_date",
                table: "Patients",
                type: "DATE",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "country_code",
                table: "Patients",
                type: "VARCHAR(50)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Patients",
                type: "VARCHAR(255)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "image_url",
                table: "Patients",
                type: "VARCHAR(255)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "last_name",
                table: "Patients",
                type: "VARCHAR(50)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "Patients",
                type: "CHAR(32)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "phone_number",
                table: "Patients",
                type: "VARCHAR(15)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "birth_date",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "country_code",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "image_url",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "last_name",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "password",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "phone_number",
                table: "Patients");
        }
    }
}
