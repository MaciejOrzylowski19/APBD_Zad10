namespace APBD_Zad10.DTOs;

public class NewPrescriptionDTO
{
    
    public PatientDTO Patient { get; set; }
    public int IdDoctor { get; set; }
    
    public required List<MedicamentDTO> Medicaments { get; set; }
    
    public DateTime Date { get; set; }
    public DateTime DueDate { get; set; }
}
