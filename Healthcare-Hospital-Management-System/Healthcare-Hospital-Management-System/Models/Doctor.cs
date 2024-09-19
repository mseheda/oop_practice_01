
namespace HealthcareHospitalManagementSystem.Models
{
    public class Doctor : Person
    {
        public string Specialization { get; set; }
        public string Department { get; set; }

        // Override the abstract method from Person
        public override void DisplayInfo()
        {
            System.Console.WriteLine($"Doctor {Name}, Age: {Age}, Specialization: {Specialization}, Department: {Department}");
        }

        // Override the virtual method from Person
        public override void Work()
        {
            System.Console.WriteLine($"Doctor {Name} is working with patients.");
        }
    }
}
