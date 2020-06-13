using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cw11.Migrations
{
    public partial class AddPrescriptionMedicamentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PrescriptionMedicaments",
                columns: table => new
                {
                    IdMedicament = table.Column<int>(nullable: false),
                    IdPrescription = table.Column<int>(nullable: false),
                    Dose = table.Column<int>(nullable: true),
                    Details = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrescriptionMedicaments", x => new { x.IdMedicament, x.IdPrescription });
                    table.ForeignKey(
                        name: "FK_PrescriptionMedicaments_Medicaments_IdMedicament",
                        column: x => x.IdMedicament,
                        principalTable: "Medicaments",
                        principalColumn: "IdMedicament",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PrescriptionMedicaments_Prescriptions_IdPrescription",
                        column: x => x.IdPrescription,
                        principalTable: "Prescriptions",
                        principalColumn: "IdPrescription",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2020, 6, 13, 14, 20, 38, 48, DateTimeKind.Local).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2020, 6, 13, 14, 20, 38, 52, DateTimeKind.Local).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2020, 6, 13, 14, 20, 38, 55, DateTimeKind.Local).AddTicks(999), new DateTime(2020, 6, 23, 14, 20, 38, 55, DateTimeKind.Local).AddTicks(1907) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 2,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2020, 6, 13, 14, 20, 38, 55, DateTimeKind.Local).AddTicks(4037), new DateTime(2020, 6, 23, 14, 20, 38, 55, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 3,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2020, 6, 13, 14, 20, 38, 55, DateTimeKind.Local).AddTicks(4108), new DateTime(2020, 6, 23, 14, 20, 38, 55, DateTimeKind.Local).AddTicks(4112) });

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionMedicaments_IdPrescription",
                table: "PrescriptionMedicaments",
                column: "IdPrescription");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrescriptionMedicaments");

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
    }
}
