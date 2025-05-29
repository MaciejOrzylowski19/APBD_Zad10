namespace APBD_Zad10.DTOs;

public class NamedMedicamentPrescriptionDTO
{
    public int IdPrescription { get; set; }
    
    public DateTime Date { get; set; }
    public DateTime DueDate { get; set; }
    
    public List<NamedMedicamentDTO> Medicaments { get; set; } = new List<NamedMedicamentDTO>();
    
    public DoctorDTO Doctor { get; set; }
}