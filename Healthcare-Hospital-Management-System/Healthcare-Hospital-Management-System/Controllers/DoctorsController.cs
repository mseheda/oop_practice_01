
using Microsoft.AspNetCore.Mvc;
using HealthcareHospitalManagementSystem.Models;

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
        public IActionResult GetAllDoctors()
        {
            var doctors = _doctorService.GetAllDoctors();
            return Ok(doctors);
        }

        [HttpGet("{id}")]
        public IActionResult GetDoctorById(int id)
        {
            var doctor = _doctorService.GetDoctorById(id);
            if (doctor == null)
            {
                return NotFound();
            }
            doctor.DisplayInfo(); // Calls the overridden method
            return Ok(doctor);
        }

        [HttpPost]
        public IActionResult AddDoctor([FromBody] Doctor doctor)
        {
            _doctorService.AddDoctor(doctor);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDoctor(int id, [FromBody] Doctor doctor)
        {
            _doctorService.UpdateDoctor(id, doctor);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDoctor(int id)
        {
            _doctorService.DeleteDoctor(id);
            return Ok();
        }
    }
}
