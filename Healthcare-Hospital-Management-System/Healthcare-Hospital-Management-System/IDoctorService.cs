
using HealthcareHospitalManagementSystem.Models;
using System.Collections.Generic;

namespace HealthcareHospitalManagementSystem.Services
{
    public interface IDoctorService
    {
        List<Doctor> GetAllDoctors();
        Doctor GetDoctorById(int id);
        void AddDoctor(Doctor doctor);
        void UpdateDoctor(int id, Doctor doctor);
        void DeleteDoctor(int id);
    }
}
