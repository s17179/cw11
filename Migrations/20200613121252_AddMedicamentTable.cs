using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cw11.Migrations
{
    public partial class AddMedicamentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medicaments",
                columns: table => new
                {
                    IdMedicament = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false),
                    Type = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicaments", x => x.IdMedicament);
                });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2020, 6, 13, 14, 12, 51, 571, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2020, 6, 13, 14, 12, 51, 578, DateTimeKind.Local).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2020, 6, 13, 14, 12, 51, 580, DateTimeKind.Local).AddTicks(5678), new DateTime(2020, 6, 23, 14, 12, 51, 580, DateTimeKind.Local).AddTicks(6423) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 2,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2020, 6, 13, 14, 12, 51, 580, DateTimeKind.Local).AddTicks(8493), new DateTime(2020, 6, 23, 14, 12, 51, 580, DateTimeKind.Local).AddTicks(8531) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 3,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2020, 6, 13, 14, 12, 51, 580, DateTimeKind.Local).AddTicks(8564), new DateTime(2020, 6, 23, 14, 12, 51, 580, DateTimeKind.Local).AddTicks(8568) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medicaments");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2020, 6, 13, 14, 6, 54, 623, DateTimeKind.Local).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2020, 6, 13, 14, 6, 54, 627, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2020, 6, 13, 14, 6, 54, 629, DateTimeKind.Local).AddTicks(4930), new DateTime(2020, 6, 23, 14, 6, 54, 629, DateTimeKind.Local).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 2,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2020, 6, 13, 14, 6, 54, 629, DateTimeKind.Local).AddTicks(7622), new DateTime(2020, 6, 23, 14, 6, 54, 629, DateTimeKind.Local).AddTicks(7655) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 3,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2020, 6, 13, 14, 6, 54, 629, DateTimeKind.Local).AddTicks(7682), new DateTime(2020, 6, 23, 14, 6, 54, 629, DateTimeKind.Local).AddTicks(7686) });
        }
    }
}
