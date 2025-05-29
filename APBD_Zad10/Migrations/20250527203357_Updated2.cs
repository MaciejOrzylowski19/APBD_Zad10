using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APBD_Zad10.Migrations
{
    /// <inheritdoc />
    public partial class Updated2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Medicament",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Lek przeciwbólowy", "Aspiryna", "Tabletki" },
                    { 2, "Lek przeciwzapalny", "Ibuprofen", "Czopki" },
                    { 3, "Lek przeciwgorączkowy", "Paracetamol", "Syrop" }
                });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "IdPatient", "BirthDate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2005, 5, 27, 22, 29, 45, 155, DateTimeKind.Local).AddTicks(1494), "Jan", "Kowalski" },
                    { 2, new DateTime(1995, 5, 27, 22, 29, 45, 157, DateTimeKind.Local).AddTicks(6742), "Anna", "Nowak" },
                    { 3, new DateTime(2000, 5, 27, 22, 29, 45, 157, DateTimeKind.Local).AddTicks(6793), "Piotr", "Zielinski" }
                });

            migrationBuilder.InsertData(
                table: "Prescription",
                columns: new[] { "IdPrescription", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 27, 22, 29, 45, 158, DateTimeKind.Local).AddTicks(231), new DateTime(2025, 6, 3, 22, 29, 45, 158, DateTimeKind.Local).AddTicks(531), 1, 1 },
                    { 2, new DateTime(2025, 5, 27, 22, 29, 45, 158, DateTimeKind.Local).AddTicks(1262), new DateTime(2025, 6, 6, 22, 29, 45, 158, DateTimeKind.Local).AddTicks(1273), 2, 2 },
                    { 3, new DateTime(2025, 5, 27, 22, 29, 45, 158, DateTimeKind.Local).AddTicks(1276), new DateTime(2025, 6, 1, 22, 29, 45, 158, DateTimeKind.Local).AddTicks(1278), 1, 3 },
                    { 4, new DateTime(2025, 5, 27, 22, 29, 45, 158, DateTimeKind.Local).AddTicks(1281), new DateTime(2025, 5, 30, 22, 29, 45, 158, DateTimeKind.Local).AddTicks(1283), 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Prescription_Medicament",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[,]
                {
                    { 1, 1, "2 razy dziennie", null },
                    { 1, 3, "1 raz dziennie", null },
                    { 2, 1, "1 raz dziennie", 3 },
                    { 2, 4, "2 razy dziennie", null },
                    { 3, 2, "3 razy dziennie", 12 }
                });
        }
    }
}
