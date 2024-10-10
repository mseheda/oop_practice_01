using HealthcareHospitalManagementSystem.Models;
using HealthcareHospitalManagementSystem.Services;
using HealthcareHospitalManagementSystem.Infrastructure;

public class DoctorService : IDoctorService
{
    private const int MaxDoctors = 2;

    private List<Doctor> _doctors;
    private readonly Logger _logger;

    public DoctorService(Logger logger)
    {
        _doctors = new List<Doctor>();
        _logger = logger;
    }

   public static int GetMaxDoctors()
    {
        return MaxDoctors;
    }

    public void AddDoctor(Doctor doctor)
    {
        string message;
        if (_doctors.Count >= MaxDoctors)
        {
            message = "Cannot add doctor. Maximum number of doctors reached.";
            _logger.LogError(message);
            throw new InvalidOperationException(message);
        }

        _doctors.Add(doctor);
        message = $"Doctor {doctor.Name} added";
        _logger.Log(message);
    }

    public List<Doctor> GetDoctors()
    {
        return _doctors;
    }
}
