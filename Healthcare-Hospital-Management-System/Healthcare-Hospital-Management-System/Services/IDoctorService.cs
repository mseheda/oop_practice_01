using System.Collections.Generic;
using HealthcareHospitalManagementSystem.Services;
using HealthcareHospitalManagementSystem.Models;

namespace HealthcareHospitalManagementSystem.Services
{
    public interface IDoctorService
    {
        void AddDoctor(Doctor doctor);
        List<Doctor> GetDoctors();
    }
}