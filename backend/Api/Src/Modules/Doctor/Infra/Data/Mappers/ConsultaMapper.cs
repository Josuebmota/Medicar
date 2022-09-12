using Api.Src.Modules.Doctor.Infra.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Src.Modules.Doctor.Infra.Data.Mappers
{
    public class ConsultaMapper : IEntityTypeConfiguration<Consulta>
    {
        public void Configure(EntityTypeBuilder<Consulta> builder)
        {
            builder.ToTable("CONSULTA");

            builder.HasKey(e => e.ConsultaId);

            builder.HasOne(e => e.Medico)
                .WithMany(e => e.Consultas)
                .HasForeignKey(e => e.MedicoId);

            builder.Property(e => e.ConsultaId)
                .HasColumnName("ID");

            builder.Property(e => e.MedicoId)
                .HasColumnName("MEDICO_ID");

            builder.Property(e => e.Day)
                .HasColumnName("DIA");

            builder.Property(e => e.Schedule)
                .HasColumnName("HORARIO");

            builder.Property(e => e.AppointmentDate)
                .HasColumnName("DATA_AGENDAMENTO");
        }
    }
}
