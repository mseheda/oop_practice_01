using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HealthcareHospitalManagementSystem.Models;
using HealthcareHospitalManagementSystem.Services;

namespace HealthcareHospitalManagementSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorsController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        [HttpGet]
        public ActionResult<List<Doctor>> GetAllDoctors()
        {
            return _doctorService.GetAllDoctors();
        }

        [HttpPost]
        public ActionResult AddDoctor(Doctor doctor)
        {
            _doctorService.AddDoctor(doctor);
            
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), $"{DateTime.UtcNow.Ticks}_transaction.log");
            DoctorService service = new DoctorService(filePath);

            try
            {
                service.LogTransaction($"Doctor {doctor.Name} added");
            }
            catch (ObjectDisposedException)
            {
                return StatusCode(500, "Error logging transaction");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                service.Dispose();
            }
            return Ok();
        }
    }
}