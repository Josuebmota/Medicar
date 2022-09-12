using System;
using System.Collections.Generic;

namespace Api.Src.Modules.Doctor.Infra.Data.Entities
{
    public class Agenda
    {
        public int AgendaId { get; set; }
        public int MedicoId { get; set; }
        public DateTime Day { get; set; }
        public List<string> Schedules { get; set; }
        public virtual Medico Medico { get; set; }
    }
}
