using Api.Src.Modules.Doctor.Domain.Interfaces.Repositories;
using Api.Src.Modules.Doctor.Infra.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Src.Modules.Doctor.Infra.Data.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        public Task<Medico> Create(Medico medico)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(Medico medico)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Medico>> FindAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<Medico> FindById(int medicoId)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(Medico medico)
        {
            throw new System.NotImplementedException();
        }
    }
}
