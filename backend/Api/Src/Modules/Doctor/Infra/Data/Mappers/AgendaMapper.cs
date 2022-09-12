using Api.Src.Modules.Doctor.Infra.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Src.Modules.Doctor.Infra.Data.Mappers
{
    public class AgendaMapper : IEntityTypeConfiguration<Agenda>
    {
        public void Configure(EntityTypeBuilder<Agenda> builder)
        {
            builder.ToTable("AGENDA");

            builder.HasKey(e => e.AgendaId);

            builder.HasOne(e => e.Medico)
                .WithMany(e => e.Agendas)
                .HasForeignKey(e => e.MedicoId);

            builder.Property(e => e.AgendaId)
                .HasColumnName("ID");

            builder.Property(e => e.MedicoId)
                .HasColumnName("MEDICO_ID");

            builder.Property(e => e.Day)
                .HasColumnName("DIA");

            builder.Property(e => e.Schedules)
                .HasColumnName("HORARIOS");
        }
    }
}
