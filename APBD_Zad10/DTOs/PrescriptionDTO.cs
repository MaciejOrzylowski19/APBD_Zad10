namespace APBD_Zad10.DTOs;

public class PrescriptionDTO
{

    public int IdPrescription { get; set; }
    
    public DateTime Date { get; set; }
    public DateTime DueDate { get; set; }
    
    public List<MedicamentDTO> Medicaments { get; set; } = new List<MedicamentDTO>();
    
    public DoctorDTO Doctor { get; set; }
    
}