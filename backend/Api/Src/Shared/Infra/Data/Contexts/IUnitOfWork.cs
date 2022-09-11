using System;
using System.Threading.Tasks;

namespace Api.Src.Shared.Infra.Data.Contexts
{
    public interface IUnitOfWork: IDisposable
    {
        public Task BeginTransaction();
        public Task Commit();
        public Task Rollback();
    }
}
