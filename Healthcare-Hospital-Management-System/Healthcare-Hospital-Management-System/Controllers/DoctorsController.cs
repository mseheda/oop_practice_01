
using Microsoft.AspNetCore.Mvc;
using HealthcareHospitalManagementSystem.Models;
using HealthcareHospitalManagementSystem.Services;

namespace HealthcareHospitalManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorsController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        [HttpGet]
        public IActionResult GetDoctors()
        {
            var doctors = _doctorService.GetAllDoctors();
            foreach (var doctor in doctors)
            {
                doctor.DisplayInfo(); // Call overridden method
            }
            return Ok(doctors);
        }

        [HttpPost]
        public IActionResult AddDoctor([FromBody] Doctor doctor)
        {
            doctor.Work(); // Call overridden method
            _doctorService.AddDoctor(doctor);
            return Ok();
        }
    }
}
