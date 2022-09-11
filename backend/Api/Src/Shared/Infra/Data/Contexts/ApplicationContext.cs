using Microsoft.EntityFrameworkCore;

namespace Api.Src.Shared.Infra.Data.Contexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options){}
        private static void ApplyMappers(ModelBuilder modelBuilder)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ApplyMappers(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
    }
}
