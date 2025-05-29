using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APBD_Zad10.Migrations
{
    /// <inheritdoc />
    public partial class Updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2005, 5, 27, 22, 29, 45, 155, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(1995, 5, 27, 22, 29, 45, 157, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2000, 5, 27, 22, 29, 45, 157, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2025, 5, 27, 22, 29, 45, 158, DateTimeKind.Local).AddTicks(231), new DateTime(2025, 6, 3, 22, 29, 45, 158, DateTimeKind.Local).AddTicks(531) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 2,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2025, 5, 27, 22, 29, 45, 158, DateTimeKind.Local).AddTicks(1262), new DateTime(2025, 6, 6, 22, 29, 45, 158, DateTimeKind.Local).AddTicks(1273) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 3,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2025, 5, 27, 22, 29, 45, 158, DateTimeKind.Local).AddTicks(1276), new DateTime(2025, 6, 1, 22, 29, 45, 158, DateTimeKind.Local).AddTicks(1278) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 4,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2025, 5, 27, 22, 29, 45, 158, DateTimeKind.Local).AddTicks(1281), new DateTime(2025, 5, 30, 22, 29, 45, 158, DateTimeKind.Local).AddTicks(1283) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2005, 5, 27, 18, 57, 31, 661, DateTimeKind.Local).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(1995, 5, 27, 18, 57, 31, 663, DateTimeKind.Local).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2000, 5, 27, 18, 57, 31, 663, DateTimeKind.Local).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2025, 5, 27, 18, 57, 31, 664, DateTimeKind.Local).AddTicks(2703), new DateTime(2025, 6, 3, 18, 57, 31, 664, DateTimeKind.Local).AddTicks(2938) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 2,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2025, 5, 27, 18, 57, 31, 664, DateTimeKind.Local).AddTicks(3515), new DateTime(2025, 6, 6, 18, 57, 31, 664, DateTimeKind.Local).AddTicks(3522) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 3,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2025, 5, 27, 18, 57, 31, 664, DateTimeKind.Local).AddTicks(3525), new DateTime(2025, 6, 1, 18, 57, 31, 664, DateTimeKind.Local).AddTicks(3527) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 4,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2025, 5, 27, 18, 57, 31, 664, DateTimeKind.Local).AddTicks(3529), new DateTime(2025, 5, 30, 18, 57, 31, 664, DateTimeKind.Local).AddTicks(3531) });
        }
    }
}
