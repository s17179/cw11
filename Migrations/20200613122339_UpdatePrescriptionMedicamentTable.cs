using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cw11.Migrations
{
    public partial class UpdatePrescriptionMedicamentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "PrescriptionMedicaments",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2020, 6, 13, 14, 23, 39, 46, DateTimeKind.Local).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2020, 6, 13, 14, 23, 39, 50, DateTimeKind.Local).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2020, 6, 13, 14, 23, 39, 53, DateTimeKind.Local).AddTicks(1860), new DateTime(2020, 6, 23, 14, 23, 39, 53, DateTimeKind.Local).AddTicks(2564) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 2,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2020, 6, 13, 14, 23, 39, 53, DateTimeKind.Local).AddTicks(4441), new DateTime(2020, 6, 23, 14, 23, 39, 53, DateTimeKind.Local).AddTicks(4478) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 3,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2020, 6, 13, 14, 23, 39, 53, DateTimeKind.Local).AddTicks(4506), new DateTime(2020, 6, 23, 14, 23, 39, 53, DateTimeKind.Local).AddTicks(4510) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "PrescriptionMedicaments",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

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
        }
    }
}
