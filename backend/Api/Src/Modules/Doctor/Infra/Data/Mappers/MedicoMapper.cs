using Api.Src.Modules.Doctor.Infra.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Src.Modules.Doctor.Infra.Data.Mappers
{
    public class MedicoMapper : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.ToTable("MEDICO");

            builder.HasKey(e => e.MedicoId);

            builder.HasMany(e => e.Consultas)
                .WithOne(e => e.Medico)
                .HasForeignKey(e => e.MedicoId);

            builder.HasMany(e => e.Agendas)
                .WithOne(e => e.Medico)
                .HasForeignKey(e => e.MedicoId);

            builder.Property(e => e.MedicoId)
                .HasColumnName("ID");

            builder.Property(e => e.Crm)
                .HasColumnName("CRM");

            builder.Property(e => e.Name)
                .HasColumnName("NOME");

            builder.Property(e => e.Email)
                .HasColumnName("EMAIL");
        }
    }
}
