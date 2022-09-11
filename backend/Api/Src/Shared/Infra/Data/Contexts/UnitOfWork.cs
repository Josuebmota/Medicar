using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Threading.Tasks;

namespace Api.Src.Shared.Infra.Data.Contexts
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _applicationContext;
        private IDbContextTransaction _transaction;
        public UnitOfWork(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }
        public async Task BeginTransaction()
        {
            _transaction = await _applicationContext.Database.BeginTransactionAsync();
        }
        public async Task Commit()
        {
            await _transaction.CommitAsync();
        }
        public async Task Rollback()
        {
            await _transaction.RollbackAsync();
        }
        public void Dispose()
        {
            _transaction?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
