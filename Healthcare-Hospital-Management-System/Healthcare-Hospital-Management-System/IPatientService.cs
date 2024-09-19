
using HealthcareHospitalManagementSystem.Models;
using System.Collections.Generic;

namespace HealthcareHospitalManagementSystem.Services
{
    public interface IPatientService
    {
        List<Patient> GetAllPatients();
        Patient GetPatientById(int id);
        void AddPatient(Patient patient);
        void UpdatePatient(int id, Patient patient);
        void DeletePatient(int id);
    }
}
