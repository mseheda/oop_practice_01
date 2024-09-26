using System;
using HealthcareHospitalManagementSystem.Models;
using HealthcareHospitalManagementSystem.Services;

namespace HealthcareHospitalManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Doctor doctor = new Doctor
            {
                Name = "Dr. John Doe",
                Age = 45,
                Specialization = "Cardiology",
                Department = "Cardiology"
            };
            
            doctor.DisplayInfo();
            
            doctor.Work();
            
            IDoctorService doctorService = new DoctorService();
            doctorService.AddDoctor(doctor);

            Console.WriteLine("\nList of Doctors:");
            foreach (var doc in doctorService.GetAllDoctors())
            {
                doc.DisplayInfo();
            }
            
            Console.ReadLine();
        }
    }
}
