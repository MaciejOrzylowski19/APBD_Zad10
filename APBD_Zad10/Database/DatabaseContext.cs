using APBD_Zad10.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

namespace APBD_Zad10.Database;

public class DatabaseContext : DbContext    
{
    public DbSet<Models.Doctor> Doctors { get; set; }
    public DbSet<Models.Medicament> Medicaments { get; set; }
    public DbSet<Models.Prescription> Prescriptions { get; set; }
    public DbSet<Models.PrescriptionMedicament> PrescriptionMedicaments { get; set; }
    public DbSet<Models.Patient> Patients { get; set; }
    
    public DatabaseContext()
    {
        
    }
    
    public DatabaseContext(DbContextOptions options) : base(options)
    {
        
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Models.Doctor>().HasData(new List<Models.Doctor>()
        {
            new Doctor() {IdDoctor = 1, FirstName = "Jan", LastName = "Kowalski", Email = "123@o2.pl"},
            new Doctor() {IdDoctor = 2, FirstName = "Anna", LastName = "Nowak", Email = "test@wp.pl"}
        });
        
        // modelBuilder.Entity<Models.Patient>().HasData(new List<Models.Patient>()
        // {
        //     new Patient() {IdPatient = 1,FirstName = "Jan", LastName = "Kowalski", BirthDate = new DateTime(2024, 12,3).AddYears(-20)},
        //     new Patient() {IdPatient = 2, FirstName = "Anna", LastName = "Nowak", BirthDate = new DateTime(2024, 12,3).AddYears(-30)},
        //     new Patient() {IdPatient = 3, FirstName = "Piotr", LastName = "Zielinski", BirthDate = new DateTime(2024, 12,3).AddYears(-25)}
        // });
        //
        // modelBuilder.Entity<Models.Medicament>().HasData(new List<Models.Medicament>()
        // {
        //     new Medicament() {IdMedicament = 1, Name = "Aspiryna", Description = "Lek przeciwbólowy", Type = "Tabletki"},
        //     new Medicament() {IdMedicament = 2, Name = "Ibuprofen", Description = "Lek przeciwzapalny", Type = "Czopki"},
        //     new Medicament() {IdMedicament = 3, Name = "Paracetamol", Description = "Lek przeciwgorączkowy", Type = "Syrop"}
        // });
        //
        // modelBuilder.Entity<Models.Prescription>().HasData(new List<Models.Prescription>()
        // {
        //     new Prescription() {IdPrescription = 1, Date = DateTime.Now, DueDate = new DateTime(2024, 12,3).AddDays(7), IdDoctor = 1, IdPatient = 1},
        //     new Prescription() {IdPrescription = 2, Date = DateTime.Now, DueDate = new DateTime(2024, 12,3).AddDays(10), IdDoctor = 2, IdPatient = 2},
        //     new Prescription() {IdPrescription = 3, Date = DateTime.Now, DueDate = new DateTime(2024, 12,3).AddDays(5), IdDoctor = 1, IdPatient = 3},
        //     new Prescription() {IdPrescription = 4, Date = DateTime.Now, DueDate = new DateTime(2024, 12,3).AddDays(3), IdDoctor = 2, IdPatient = 1}
        // });
        //
        // modelBuilder.Entity<Models.PrescriptionMedicament>().HasData(new List<Models.PrescriptionMedicament>()
        // {
        //     new PrescriptionMedicament() { IdPrescription = 1, IdMedicament = 1, Details = "2 razy dziennie" },
        //     new PrescriptionMedicament() { IdPrescription = 1, IdMedicament = 2, Details = "1 raz dziennie", Dose = 3},
        //     new PrescriptionMedicament() { IdPrescription = 2, IdMedicament = 3, Details = "3 razy dziennie" , Dose = 12},
        //     new PrescriptionMedicament() { IdPrescription = 3, IdMedicament = 1, Details = "1 raz dziennie" },
        //     new PrescriptionMedicament() { IdPrescription = 4, IdMedicament = 2, Details = "2 razy dziennie" }
        // });
        
    }
    
    
}