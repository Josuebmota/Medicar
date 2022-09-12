using System.Collections.Generic;

namespace Api.Src.Modules.Doctor.Infra.Data.Entities
{
    public class Medico
    {
        public int MedicoId { get; set; }
        public int Crm { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public virtual List<Consulta> Consultas { get; set; }
        public virtual List<Agenda> Agendas { get; set; }
    }
}
