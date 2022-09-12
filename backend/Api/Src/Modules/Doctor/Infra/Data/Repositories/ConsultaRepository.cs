using Api.Src.Modules.Doctor.Domain.Interfaces.Repositories;
using Api.Src.Modules.Doctor.Infra.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Src.Modules.Doctor.Infra.Data.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        public Task<Consulta> Create(Consulta consulta)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(Consulta consulta)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Consulta>> FinById(int consultaId)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Consulta>> FindAll()
        {
            throw new System.NotImplementedException();
        }

        public Task Update(Consulta consulta)
        {
            throw new System.NotImplementedException();
        }
    }
}
