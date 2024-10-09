using HealthcareHospitalManagementSystem.Models;
using HealthcareHospitalManagementSystem.Services;
using HealthcareHospitalManagementSystem.Infrastructure;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class DoctorsController : ControllerBase
{
    private readonly IDoctorService _doctorService;
    private readonly Logger _logger;

    public DoctorsController(IDoctorService doctorService, Logger logger)
    {
        _doctorService = doctorService;
        _logger = logger;
    }

    [HttpPost]
    public ActionResult AddDoctor(Doctor doctor)
    {
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), $"{DateTime.UtcNow.Ticks}_transaction.log");
        DoctorService service = new DoctorService(filePath, _logger);
        try
        {
            service.AddDoctor(doctor);
            return Ok();
        }
        catch (ObjectDisposedException)
        {
            return StatusCode(500, "Error logging transaction");
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
        finally
        {
            service.Dispose();
        }
    }


    [HttpGet]
    public ActionResult<IEnumerable<Doctor>> GetDoctors()
    {
        try
        {
            var doctors = _doctorService.GetDoctors();
            if (!doctors.Any())
                return NotFound("No doctors found");

            return Ok(doctors);
        }
        catch (ObjectDisposedException)
        {
            return StatusCode(500, "Service is disposed");
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}
