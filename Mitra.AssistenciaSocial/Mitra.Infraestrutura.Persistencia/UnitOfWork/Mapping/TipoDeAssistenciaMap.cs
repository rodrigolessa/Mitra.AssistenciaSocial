using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Mitra.Dominio.Entities;

namespace Mitra.Infraestrutura.Persistencia.UnitOfWork.Mapping
{
    public class TipoDeAssistenciaMap : EntityTypeConfiguration<TipoDeAssistencia>
    {
        public TipoDeAssistenciaMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("TipoDeAssistencia", "AssistenciaSocial");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
        }
    }
}
