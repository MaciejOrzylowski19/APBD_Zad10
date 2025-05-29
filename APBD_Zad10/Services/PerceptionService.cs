using System.Collections.ObjectModel;
using APBD_Zad10.Database;
using APBD_Zad10.DTOs;
using APBD_Zad10.Models;
using Microsoft.EntityFrameworkCore;

namespace APBD_Zad10.Services;

public class PerceptionService : IPerceptionService
{
    
    
    private readonly DatabaseContext context;

    public PerceptionService(DatabaseContext context)
    {
        this.context = context;
    }
    
    
    
    
    /// Learning purposes only
    public async Task<List<DoctorDTO>> GetDoctorsAsync()
    {
        var response = await context.Doctors
            .Select(e => new DoctorDTO {Id = e.IdDoctor, FirstName = e.FirstName, LastName = e.LastName}).ToListAsync();

        return response;
    }
    
    ///Learning purposes only
    public async Task<DoctorsPrescriptionsDTO> GetDoctorsPrescriptionsAsync(int idDoctor)
    {
        var doctor = context.Doctors.Where(e => e.IdDoctor == idDoctor).Include(e => e.Prescriptions).ThenInclude(e => e.Patient).First();

        DoctorsPrescriptionsDTO response = new DoctorsPrescriptionsDTO
        {
            FirstName = doctor.FirstName,
            LastName = doctor.LastName,
            Patient = doctor.Prescriptions.Select(e => e.Patient).Select( e=>
                    new PatientDTO()
                    {
                        IdPatient = e.IdPatient,
                        FirstName = e.FirstName,
                        LastName = e.LastName,
                        BirthDate = e.BirthDate
                    }
                ).ToList()
        };

        return response;
    }

    public async Task<PatientPrescrioptionsDTO> GetPatientsPrescriptionsAsync(int idPatient)
    {
        Patient? patient = context.Patients.Where(e => e.IdPatient == idPatient).First();
        
        if (patient == null)
        {
            return null;
        }
        
        var result = new PatientPrescrioptionsDTO()
        {
            IdPatient = idPatient,
            FirstName = patient.FirstName,
            LastName = patient.LastName,
            BirthDate = patient.BirthDate,
            Prescriptions = new List<NamedMedicamentPrescriptionDTO>()
        };
        var prescriptions = await context.Prescriptions.Where(e => e.IdPatient == idPatient)
            .Include(e => e.Doctor).ToListAsync();


        foreach (var pre in prescriptions)
        {
            var prescriptionMedicament = new NamedMedicamentPrescriptionDTO()
            {
                IdPrescription = pre.IdPrescription,
                Date = pre.Date,
                DueDate = pre.DueDate,
                Doctor = new DTOs.DoctorDTO()
                {
                    IdDoctor = pre.IdDoctor,
                    FirstName = pre.Doctor.FirstName
                },
                Medicaments = new List<NamedMedicamentDTO>()
            };
            
            var medicaments = await context.PrescriptionMedicaments.Where(e => e.IdPrescription == pre.IdPrescription)
                .Include(e => e.Medicament).ToListAsync();
            var listOfMedicaments = new List<NamedMedicamentDTO>();
            
            foreach (var med in medicaments)
            {
                listOfMedicaments.Add(new NamedMedicamentDTO()
                {
                    IdMedicament = med.IdMedicament,
                    Name = med.Medicament.Name,
                    Dose = med.Dose,
                    Description = med.Details
                });
            }
            
            prescriptionMedicament.Medicaments = listOfMedicaments;
            result.Prescriptions.Add(prescriptionMedicament);
            
        }
        return result;
}
    
    public async Task<AddPerciptionResult> AddPrescription(NewPrescriptionDTO prescriptionDto)
    {
        try {
        if (!context.Doctors.Select(e => e.IdDoctor).Contains(prescriptionDto.IdDoctor))
        {
            return AddPerciptionResult.DoctorNotFound;
        }

        if (prescriptionDto.Medicaments.Count <= 0 || prescriptionDto.Medicaments.Count > 10)
        {
            return AddPerciptionResult.MedicamentsCountExceeded;
        }

        foreach (var i in prescriptionDto.Medicaments.Select(e => e.IdMedicament))
        {
            if (!context.Medicaments.Select(e => e.IdMedicament).Contains(i))
            {
                return AddPerciptionResult.MedicamentNotFound;
            }
        }

        if (! (prescriptionDto.DueDate >= prescriptionDto.Date) )
        {
            return AddPerciptionResult.DateError;
        }

        context.UpdateRange();

        if (!context.Patients.Select(e => e.IdPatient).Contains(prescriptionDto.Patient.IdPatient))

        {
            context.Patients.Add(new Patient()
                {
                    IdPatient = prescriptionDto.Patient.IdPatient,
                    FirstName = prescriptionDto.Patient.FirstName,
                    LastName = prescriptionDto.Patient.LastName,
                    BirthDate = prescriptionDto.Patient.BirthDate
                }
            );
        }

        context.Prescriptions.Add(new Prescription()
        {
            IdDoctor = prescriptionDto.IdDoctor,
            IdPatient = prescriptionDto.Patient.IdPatient,
            Date = prescriptionDto.Date,
            DueDate = prescriptionDto.DueDate
        });

        int prescriptionId = context.Prescriptions
            .Select(e => e.IdPrescription).Max();

        foreach (var medicament in prescriptionDto.Medicaments)
        {
            context.PrescriptionMedicaments.Add(new PrescriptionMedicament()
            {
                IdPrescription = prescriptionId,
                IdMedicament = medicament.IdMedicament,
                Dose = medicament.Dose,
                Details = medicament.Description
            });
        }

        await context.SaveChangesAsync();
        return AddPerciptionResult.Success;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return AddPerciptionResult.DateError;
        }
    }

    public enum AddPerciptionResult
    {
        Success,
        InvalidData,
        DoctorNotFound,
        MedicamentNotFound,
        MedicamentsCountExceeded,
        DateError
    }
}