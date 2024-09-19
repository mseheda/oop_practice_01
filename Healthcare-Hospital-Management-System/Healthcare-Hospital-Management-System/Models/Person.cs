
namespace HealthcareHospitalManagementSystem.Models
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Abstract method
        public abstract void DisplayInfo();

        // Virtual method with an implementation
        public virtual void Work()
        {
            System.Console.WriteLine($"{Name} is working.");
        }
    }
}
