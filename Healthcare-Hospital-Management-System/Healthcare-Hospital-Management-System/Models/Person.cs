namespace HealthcareHospitalManagementSystem.Models
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        
        public abstract string DisplayInfo();
        
        public virtual string Work()
        {
            return $"{Name} is working.";
        }
    }
}
