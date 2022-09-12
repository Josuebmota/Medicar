using Api.Src.Modules.Doctor.Domain.Dtos;
using Api.Src.Modules.Doctor.Domain.Interfaces.Repositories;
using Api.Src.Modules.Doctor.Infra.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Src.Modules.Doctor.Infra.Data.Repositories
{
    public class AgendaRepository : IAgendaRepository
    {
        public Task<Agenda> Create(Agenda agenda)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(Agenda agenda)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Agenda>> FindAllAppointment()
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Agenda>> FindAppointment(FindAppointmentDto data)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(Agenda agenda)
        {
            throw new System.NotImplementedException();
        }
    }
}
