using HealthcareHospitalManagementSystem.Models;
using HealthcareHospitalManagementSystem.Services;
using HealthcareHospitalManagementSystem.Infrastructure;


public class DoctorService : IDoctorService
{
    private List<Doctor> _doctors;
    private FileStream _transactionLogFileStream;
    private bool _disposed = false;
    private readonly Logger _logger;

    public DoctorService(Logger logger)
    {
        _doctors = new List<Doctor>();
        _logger = logger;
    }

    public DoctorService(string logFilePath, Logger logger)
    {
        _doctors = new List<Doctor>();
        _transactionLogFileStream = new FileStream(logFilePath, FileMode.Append, FileAccess.Write);
        _logger = logger;
    }

    public void AddDoctor(Doctor doctor)
    {
        if (_disposed)
            throw new ObjectDisposedException("DoctorService");

        _doctors.Add(doctor);
        string message = $"Doctor {doctor.Name} added";
        LogTransaction(message);
        _logger.Log(message);
    }

    public IEnumerable<Doctor> GetDoctors()
    {
        if (_disposed)
            throw new ObjectDisposedException("DoctorService");

        return _doctors;
    }

    public void LogTransaction(string message)
    {
        if (_disposed)
            throw new ObjectDisposedException("DoctorService");

        if (_transactionLogFileStream == null)
            throw new InvalidOperationException("Log file stream is not initialized.");

        byte[] messageBytes = System.Text.Encoding.UTF8.GetBytes($"DateTime: {DateTime.UtcNow}, Message: {message}\n");
        _transactionLogFileStream.Write(messageBytes, 0, messageBytes.Length);
    }

    public void Dispose()
    {
        if (!_disposed)
        {
            _transactionLogFileStream?.Dispose();
            _disposed = true;
        }
    }
}
