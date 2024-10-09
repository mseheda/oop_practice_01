using HealthcareHospitalManagementSystem.Models;
using HealthcareHospitalManagementSystem.Services;
using HealthcareHospitalManagementSystem.Infrastructure;


public class DoctorService : IDoctorService
{
    private List<Doctor> _doctors;
    private readonly Logger _logger;

    public DoctorService(Logger logger)
    {
        _doctors = new List<Doctor>();
        _logger = logger;
    }


    public void AddDoctor(Doctor doctor)
    {
        _doctors.Add(doctor);
        string message = $"Doctor {doctor.Name} added";
        _logger.Log(message);
    }

    public IEnumerable<Doctor> GetDoctors()
    {
        return _doctors;
    }
}
