using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cw11.Migrations
{
    public partial class UpdatePrescriptionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                table: "Prescriptions",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Prescriptions",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "IdPrescription", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 13, 14, 6, 54, 629, DateTimeKind.Local).AddTicks(4930), new DateTime(2020, 6, 23, 14, 6, 54, 629, DateTimeKind.Local).AddTicks(5673), 1, 1 },
                    { 2, new DateTime(2020, 6, 13, 14, 6, 54, 629, DateTimeKind.Local).AddTicks(7622), new DateTime(2020, 6, 23, 14, 6, 54, 629, DateTimeKind.Local).AddTicks(7655), 2, 1 },
                    { 3, new DateTime(2020, 6, 13, 14, 6, 54, 629, DateTimeKind.Local).AddTicks(7682), new DateTime(2020, 6, 23, 14, 6, 54, 629, DateTimeKind.Local).AddTicks(7686), 2, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                table: "Prescriptions",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Prescriptions",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2020, 6, 13, 13, 56, 1, 687, DateTimeKind.Local).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2020, 6, 13, 13, 56, 1, 691, DateTimeKind.Local).AddTicks(2415));
        }
    }
}
