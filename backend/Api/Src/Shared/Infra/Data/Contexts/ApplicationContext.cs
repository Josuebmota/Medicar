using Api.Src.Modules.Doctor.Infra.Data.Entities;
using Api.Src.Modules.Doctor.Infra.Data.Mappers;
using Microsoft.EntityFrameworkCore;

namespace Api.Src.Shared.Infra.Data.Contexts
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Agenda> Agenda { get; set; }
        public DbSet<Consulta> Consulta { get; set; }
        public DbSet<Medico> Medico { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options){}
        private static void ApplyMappers(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AgendaMapper());
            modelBuilder.ApplyConfiguration(new ConsultaMapper());
            modelBuilder.ApplyConfiguration(new MedicoMapper());
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ApplyMappers(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
    }
}
