using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ReverseCodeFirst.Models.Mapping
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

            this.Property(t => t.Unidade)
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("TipoDeAssistencia", "AssistenciaSocial");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.id_entidade_social).HasColumnName("id_entidade_social");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.Unidade).HasColumnName("Unidade");

            // Relationships
            this.HasRequired(t => t.EntidadeSocial)
                .WithMany(t => t.TipoDeAssistencias)
                .HasForeignKey(d => d.id_entidade_social);

        }
    }
}
