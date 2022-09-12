using System;

namespace Api.Src.Modules.Doctor.Infra.Data.Entities
{
    public class Consulta
    {
        public int ConsultaId { get; set; }
        public int MedicoId { get; set; }
        public DateTime Day { get; set; }
        public string Schedule { get; set; }
        public DateTime AppointmentDate { get; set; }
        public virtual Medico Medico { get; set; }
    }
}
