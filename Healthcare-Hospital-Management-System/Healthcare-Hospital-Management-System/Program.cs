using System;
using HealthcareHospitalManagementSystem.Models;
using HealthcareHospitalManagementSystem.Services;

namespace HealthcareHospitalManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create service instances
            DoctorService doctorService = new DoctorService();
            PatientService patientService = new PatientService();
            AppointmentService appointmentService = new AppointmentService();

            // Add a doctor
            Doctor doctor1 = new Doctor { Name = "Dr. Smith", Specialization = "Cardiology", Department = "Cardio" };
            doctorService.AddDoctor(doctor1);

            // Add a patient
            Patient patient1 = new Patient { Name = "John Doe", Age = 30, MedicalHistory = "None" };
            patientService.AddPatient(patient1);

            // Schedule an appointment
            Appointment appointment1 = new Appointment { DoctorId = doctor1.Id, PatientId = patient1.Id, AppointmentDate = DateTime.Now };
            appointmentService.ScheduleAppointment(appointment1);

            // Display doctor info
            doctor1.DisplayInfo();  // Calls overridden method
            doctor1.Work();         // Calls overridden Work method

            // Retrieve and display patient info
            var patient = patientService.GetPatientById(patient1.Id);
            patient.DisplayInfo();   // Calls overridden method
        }
    }
}
