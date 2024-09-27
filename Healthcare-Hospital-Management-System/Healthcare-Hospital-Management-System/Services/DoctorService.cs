using System.Collections.Generic;
using HealthcareHospitalManagementSystem.Models;

namespace HealthcareHospitalManagementSystem.Services
{
    public class DoctorService : IDisposable, IDoctorService
    {
        private readonly List<Doctor> _doctors = new List<Doctor>();
        private readonly FileStream _transactionLogFileStream;
        private bool _disposed = false;

        public DoctorService()
        {
            
        }
        
        public DoctorService(string filePath)
        {
            _transactionLogFileStream = new FileStream(filePath, FileMode.OpenOrCreate);
        }

        public void LogTransaction(string message)
        {
            if (_disposed)
                throw new ObjectDisposedException("DoctorService");
            
            byte[] messageBytes = System.Text.Encoding.UTF8.GetBytes($"DateTime: {DateTime.UtcNow}, Message: {message}\n");
            _transactionLogFileStream.Write(messageBytes, 0, messageBytes.Length);
        }
        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
                {
                    _transactionLogFileStream.Dispose();
                }
            _disposed = true;
        }
        
        ~DoctorService()
        {
            Dispose(false);
        }
            
        public List<Doctor> GetAllDoctors()
        {
            return _doctors;
        }

        public void AddDoctor(Doctor doctor)
        {
            _doctors.Add(doctor);
        }
    }
}