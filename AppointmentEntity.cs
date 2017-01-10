using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallgatoFelvetel
{
    public class AppointmentEntity
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentCourse { get; set; }
        public DateTime Appointment { get; set; }
    }
}
