using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HallgatoFelvetel
{
    public interface ISampleContext
    {
        IDbSet<StudentEntity> StudentEntities { get; set; }
        IDbSet<AppointmentEntity> AppointmentEntities { get; set; }
        int SaveChanges();
    }
}
