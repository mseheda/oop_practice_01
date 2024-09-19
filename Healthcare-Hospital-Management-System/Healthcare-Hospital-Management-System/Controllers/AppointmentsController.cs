
using Microsoft.AspNetCore.Mvc;
using HealthcareHospitalManagementSystem.Models;

namespace HealthcareHospitalManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentsController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentsController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        [HttpGet]
        public IActionResult GetAllAppointments()
        {
            var appointments = _appointmentService.GetAllAppointments();
            return Ok(appointments);
        }

        [HttpGet("{id}")]
        public IActionResult GetAppointmentById(int id)
        {
            var appointment = _appointmentService.GetAppointmentById(id);
            if (appointment == null)
            {
                return NotFound();
            }
            return Ok(appointment);
        }

        [HttpPost]
        public IActionResult ScheduleAppointment([FromBody] Appointment appointment)
        {
            _appointmentService.ScheduleAppointment(appointment);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAppointment(int id, [FromBody] Appointment appointment)
        {
            _appointmentService.UpdateAppointment(id, appointment);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult CancelAppointment(int id)
        {
            _appointmentService.CancelAppointment(id);
            return Ok();
        }
    }
}
