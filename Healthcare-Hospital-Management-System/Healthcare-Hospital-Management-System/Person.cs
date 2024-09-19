namespace HealthcareHospitalManagementSystem.Abstracts
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Abstract method
        public abstract void DisplayInfo();

        // Virtual method (will be overridden)
        public virtual void Work()
        {
            Console.WriteLine($"{Name} is working.");
        }
    }
}
