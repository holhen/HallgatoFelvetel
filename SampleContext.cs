using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HallgatoFelvetel
{
    public class SampleContext: DbContext, ISampleContext
    {
        public SampleContext(): this("Vizsga") { }
        public SampleContext(string connectionString): base("Vizsga") { }
        public IDbSet<StudentEntity> StudentEntities { get; set; }
        public IDbSet<AppointmentEntity> AppointmentEntities { get; set; }
    }
}
