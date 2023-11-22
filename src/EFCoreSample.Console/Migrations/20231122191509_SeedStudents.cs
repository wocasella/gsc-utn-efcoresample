using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreSample.Console.Migrations
{
    /// <inheritdoc />
    public partial class SeedStudents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "Address", "CreatedTimestamp", "DateOfBirth", "Email", "FirstName", "LastName", "RegistryNumber", "ZipCode" },
                values: new object[] { 1, "asdf", new DateTime(2023, 11, 22, 19, 15, 8, 678, DateTimeKind.Utc).AddTicks(6938), new DateOnly(1999, 10, 3), "asdf", "JJ", "Simone", 1111, "2134" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
