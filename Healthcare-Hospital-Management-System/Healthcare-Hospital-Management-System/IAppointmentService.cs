
using HealthcareHospitalManagementSystem.Models;
using System.Collections.Generic;

namespace HealthcareHospitalManagementSystem.Services
{
    public interface IAppointmentService
    {
        List<Appointment> GetAllAppointments();
        Appointment GetAppointmentById(int id);
        void ScheduleAppointment(Appointment appointment);
        void UpdateAppointment(int id, Appointment appointment);
        void CancelAppointment(int id);
    }
}
