using APBD_Zad10.DTOs;
using APBD_Zad10.Models;
using APBD_Zad10.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Extensions;

namespace APBD_Zad10.Controllers;

[ApiController]
[Route("api")]
public class PerceptionController : ControllerBase
{
    
    private readonly IPerceptionService _perceptionService;
    public PerceptionController(IPerceptionService perceptionService)
    {
        _perceptionService = perceptionService;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetDoctors()
    {
        return Ok(await _perceptionService.GetDoctorsAsync());
    }

    [HttpGet]
    [Route("doctor/{doctorId}")]
    public async Task<IActionResult> GetDoctorsPrescriptions([FromRoute] int doctorId)
    {
        Console.WriteLine("Getting prescriptions for doctor with ID: " + doctorId);
        var response = await _perceptionService.GetDoctorsPrescriptionsAsync(doctorId);
        
        if (response == null)
        
        {
            return NotFound();
        }
        return Ok(response);
    }
    
    [HttpPost]
    public async Task<ActionResult> AddPerception([FromBody] NewPrescriptionDTO prescription)
    {
        var result = await _perceptionService.AddPrescription(prescription);
        
        Console.WriteLine("Adding perception for patient: " + prescription.Patient.FirstName + " " + prescription.Patient.LastName);
        Console.WriteLine(result.GetDisplayName());
        //TODO Handle the result properly
        return Ok(result);
    }
    
    [HttpGet]
    [Route("{idPatient}")]
    public async Task<IActionResult> GetPatientsPrescriptions([FromRoute] int idPatient)
    {
        var response = await _perceptionService.GetPatientsPrescriptionsAsync(idPatient);
        
        if (response == null)
        {
            return NotFound();
        }
        
        return Ok(response);
    }

}