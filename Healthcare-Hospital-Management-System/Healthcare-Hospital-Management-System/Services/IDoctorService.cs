
using System.Collections.Generic;
using HealthcareHospitalManagementSystem.Models;

namespace HealthcareHospitalManagementSystem.Services
{
    public interface IDoctorService
    {
        List<Doctor> GetAllDoctors();
        void AddDoctor(Doctor doctor);
    }
}
