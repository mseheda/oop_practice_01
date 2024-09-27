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
            return Ok();
        }
    }
}