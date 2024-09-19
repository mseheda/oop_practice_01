using HealthcareHospitalManagementSystem.Abstracts;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace HealthcareHospitalManagementSystem.Models
{
    public class Patient : Person
    {
        public string MedicalHistory { get; set; }

        // Override the abstract method from Person
        public override void DisplayInfo()
        {
            Console.WriteLine($"Patient {Name}, Age: {Age}, Medical History: {MedicalHistory}");
        }
    }
}
