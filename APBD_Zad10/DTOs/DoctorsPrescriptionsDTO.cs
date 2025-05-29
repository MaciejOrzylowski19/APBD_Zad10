namespace APBD_Zad10.DTOs;

public class DoctorsPrescriptionsDTO
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<PatientDTO> Patient { get; set; }
    
}