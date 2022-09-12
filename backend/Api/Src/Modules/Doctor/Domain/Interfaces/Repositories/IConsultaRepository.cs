using Api.Src.Modules.Doctor.Infra.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Src.Modules.Doctor.Domain.Interfaces.Repositories
{
    public interface IConsultaRepository
    {
        public Task<Consulta> Create(Consulta consulta);
        public Task<List<Consulta>> FindAll();
        public Task<List<Consulta>> FinById(int consultaId);
        public Task Update(Consulta consulta);
        public Task Delete(Consulta consulta);
    }
}
