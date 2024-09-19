
using HealthcareHospitalManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace HealthcareHospitalManagementSystem.Services
{
    public class PatientService : IPatientService
    {
        private List<Patient> patients = new List<Patient>();

        public List<Patient> GetAllPatients()
        {
            return patients;
        }

        public Patient GetPatientById(int id)
        {
            return patients.FirstOrDefault(p => p.Id == id);
        }

        public void AddPatient(Patient patient)
        {
            patients.Add(patient);
        }

        public void UpdatePatient(int id, Patient patient)
        {
            var existingPatient = GetPatientById(id);
            if (existingPatient != null)
            {
                existingPatient.Name = patient.Name;
                existingPatient.Age = patient.Age;
                existingPatient.MedicalHistory = patient.MedicalHistory;
            }
        }

        public void DeletePatient(int id)
        {
            var patient = GetPatientById(id);
            if (patient != null)
            {
                patients.Remove(patient);
            }
        }
    }
}
