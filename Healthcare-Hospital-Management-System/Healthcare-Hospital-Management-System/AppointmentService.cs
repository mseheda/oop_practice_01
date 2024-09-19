
using HealthcareHospitalManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace HealthcareHospitalManagementSystem.Services
{
    public class AppointmentService : IAppointmentService
    {
        private List<Appointment> appointments = new List<Appointment>();

        public List<Appointment> GetAllAppointments()
        {
            return appointments;
        }

        public Appointment GetAppointmentById(int id)
        {
            return appointments.FirstOrDefault(a => a.Id == id);
        }

        public void ScheduleAppointment(Appointment appointment)
        {
            appointments.Add(appointment);
        }

        public void UpdateAppointment(int id, Appointment appointment)
        {
            var existingAppointment = GetAppointmentById(id);
            if (existingAppointment != null)
            {
                existingAppointment.AppointmentDate = appointment.AppointmentDate;
                existingAppointment.DoctorId = appointment.DoctorId;
                existingAppointment.PatientId = appointment.PatientId;
            }
        }

        public void CancelAppointment(int id)
        {
            var appointment = GetAppointmentById(id);
            if (appointment != null)
            {
                appointments.Remove(appointment);
            }
        }
    }
}
