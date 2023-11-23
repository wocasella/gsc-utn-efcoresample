using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreSample.Console.Migrations
{
    /// <inheritdoc />
    public partial class RenameAddressToAddressLine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Student",
                newName: "AddressLine");

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTimestamp",
                value: new DateTime(2023, 11, 23, 2, 30, 57, 410, DateTimeKind.Utc).AddTicks(2301));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AddressLine",
                table: "Student",
                newName: "Address");

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTimestamp",
                value: new DateTime(2023, 11, 23, 1, 59, 32, 600, DateTimeKind.Utc).AddTicks(8433));
        }
    }
}
