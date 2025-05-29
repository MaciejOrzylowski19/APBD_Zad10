using System.Collections.ObjectModel;
using APBD_Zad10.DTOs;
using APBD_Zad10.Models;

namespace APBD_Zad10.Services;

public interface IPerceptionService {

    //Test Services - learning purposes only
    public Task<List<DoctorDTO>> GetDoctorsAsync();
    public Task<DoctorsPrescriptionsDTO> GetDoctorsPrescriptionsAsync(int idDoctor);
    public Task<PerceptionService.AddPerciptionResult> AddPrescription(NewPrescriptionDTO prescriptionDto);
    
    public Task<PatientPrescrioptionsDTO> GetPatientsPrescriptionsAsync(int idPatient);
}