
using System.Collections.Generic;
using HealthcareHospitalManagementSystem.Models;

namespace HealthcareHospitalManagementSystem.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly List<Doctor> _doctors = new List<Doctor>();

        public List<Doctor> GetAllDoctors()
        {
            return _doctors;
        }

        public void AddDoctor(Doctor doctor)
        {
            _doctors.Add(doctor);
        }
    }
}
