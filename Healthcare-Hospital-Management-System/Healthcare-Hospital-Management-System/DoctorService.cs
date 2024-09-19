
using HealthcareHospitalManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace HealthcareHospitalManagementSystem.Services
{
    public class DoctorService : IDoctorService
    {
        private List<Doctor> doctors = new List<Doctor>();

        public List<Doctor> GetAllDoctors()
        {
            return doctors;
        }

        public Doctor GetDoctorById(int id)
        {
            return doctors.FirstOrDefault(d => d.Id == id);
        }

        public void AddDoctor(Doctor doctor)
        {
            doctors.Add(doctor);
        }

        public void UpdateDoctor(int id, Doctor doctor)
        {
            var existingDoctor = GetDoctorById(id);
            if (existingDoctor != null)
            {
                existingDoctor.Name = doctor.Name;
                existingDoctor.Specialization = doctor.Specialization;
                existingDoctor.Department = doctor.Department;
            }
        }

        public void DeleteDoctor(int id)
        {
            var doctor = GetDoctorById(id);
            if (doctor != null)
            {
                doctors.Remove(doctor);
            }
        }
    }
}
