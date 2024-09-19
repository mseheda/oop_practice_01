using System;
using HealthcareHospitalManagementSystem.Models;
using HealthcareHospitalManagementSystem.Services;

namespace HealthcareHospitalManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Testing the inheritance and method overrides

            // Create a Doctor instance (inherits from Person)
            Doctor doctor = new Doctor
            {
                Name = "Dr. John Doe",
                Age = 45,
                Specialization = "Cardiology",
                Department = "Cardiology"
            };

            // Call the overridden abstract method
            doctor.DisplayInfo();

            // Call the overridden virtual method
            doctor.Work();

            // Simulate service usage (without database, just in-memory data)
            IDoctorService doctorService = new DoctorService();
            doctorService.AddDoctor(doctor);

            Console.WriteLine("\nList of Doctors:");
            foreach (var doc in doctorService.GetAllDoctors())
            {
                doc.DisplayInfo(); // Show the doctor info again from the service
            }

            // This keeps the console window open
            Console.ReadLine(); // Press Enter to close
        }
    }
}
