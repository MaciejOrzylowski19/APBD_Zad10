namespace APBD_Zad10.DTOs;

public class PatientPrescrioptionsDTO
{
    public int IdPatient { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    
    public List<NamedMedicamentPrescriptionDTO> Prescriptions { get; set; }
    
}