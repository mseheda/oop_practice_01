using HealthcareHospitalManagementSystem.Abstracts;
using System.Xml.Linq;

namespace HealthcareHospitalManagementSystem.Models
{
    public class Doctor : Person
    {
        public string Specialization { get; set; }
        public string Department { get; set; }

        // Override the abstract method from Person
        public override void DisplayInfo()
        {
            Console.WriteLine($"Doctor {Name}, Specialization: {Specialization}, Department: {Department}");
        }

        // Override the virtual method from Person
        public override void Work()
        {
            Console.WriteLine($"Doctor {Name} is seeing patients.");
        }
    }
}
