using Api.Src.Modules.Doctor.Domain.Dtos;
using Api.Src.Modules.Doctor.Infra.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Src.Modules.Doctor.Domain.Interfaces.Repositories
{
    public interface IAgendaRepository
    {
        public Task<Agenda> Create(Agenda agenda);
        public Task<List<Agenda>> FindAllAppointment();
        public Task<List<Agenda>> FindAppointment(FindAppointmentDto data);
        public Task Update(Agenda agenda);
        public Task Delete(Agenda agenda);
    }
}
