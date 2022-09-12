using Api.Src.Modules.Doctor.Infra.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Src.Modules.Doctor.Domain.Interfaces.Repositories
{
    public interface IMedicoRepository
    {
        public Task<Medico> Create(Medico medico);
        public Task<List<Medico>> FindAll();
        public Task<Medico> FindById(int medicoId);
        public Task Update(Medico medico);
        public Task Delete(Medico medico);
    }
}
