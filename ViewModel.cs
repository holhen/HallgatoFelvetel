using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallgatoFelvetel
{
    public class ViewModel
    {
        private ISampleContext _context;
        public ViewModel(ISampleContext context)
        {
            _context = context;
        }

        public bool ValidateDateTime(DateTime dateTime) {
            if (dateTime.Hour < 8 ||
               dateTime.Hour > 16 ||
               dateTime <= DateTime.Now ||
               _context.AppointmentEntities.Where(entry => entry.Appointment == dateTime).Count() > 0)
                return false;
            else return true;
        }

        public bool CheckStudent(string StudentName)
        {
            if (_context.AppointmentEntities.Where(entry => entry.StudentName == StudentName).Count() > 0)
                return true;
            else return false;
        }

        public AppointmentEntity CreateAppointment(string StudentName, DateTime dateTime)
        {
            AppointmentEntity appointment = new AppointmentEntity();
            appointment.StudentName = StudentName;
            appointment.StudentId = _context.StudentEntities.Where(entry => entry.Name == StudentName).Select(entry => entry.Id).FirstOrDefault();
            appointment.StudentCourse = _context.StudentEntities.Where(entry => entry.Name == StudentName).Select(entry => entry.Course).FirstOrDefault();
            appointment.Appointment = dateTime;
            _context.AppointmentEntities.Add(appointment);
            _context.SaveChanges();
            return appointment;
        }

        public List<StudentEntity> GetStudents()
        {
            return _context.StudentEntities.ToList();
        }

        public List<AppointmentEntity> GetAppointments()
        {
            return _context.AppointmentEntities.Where(e => e.Appointment > DateTime.Now).ToList();
        }
    }
}
