
using Microsoft.AspNetCore.Mvc;
using HealthcareHospitalManagementSystem.Models;

namespace HealthcareHospitalManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientsController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientsController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpGet]
        public IActionResult GetAllPatients()
        {
            var patients = _patientService.GetAllPatients();
            return Ok(patients);
        }

        [HttpGet("{id}")]
        public IActionResult GetPatientById(int id)
        {
            var patient = _patientService.GetPatientById(id);
            if (patient == null)
            {
                return NotFound();
            }
            patient.DisplayInfo(); // Calls the overridden method
            return Ok(patient);
        }

        [HttpPost]
        public IActionResult AddPatient([FromBody] Patient patient)
        {
            _patientService.AddPatient(patient);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePatient(int id, [FromBody] Patient patient)
        {
            _patientService.UpdatePatient(id, patient);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePatient(int id)
        {
            _patientService.DeletePatient(id);
            return Ok();
        }
    }
}
