namespace HealthcareHospitalManagementSystem.Models
{
    public class Doctor : Person
    {
        public string Specialization { get; set; }
        public string Department { get; set; }
        
        public override string DisplayInfo()
        {
            return $"Doctor {Name}, Age: {Age}, Specialization: {Specialization}, Department: {Department}";
        }
        
        public override string Work()
        {
            return $"Doctor {Name} is working with patients.";
        }
    }
}