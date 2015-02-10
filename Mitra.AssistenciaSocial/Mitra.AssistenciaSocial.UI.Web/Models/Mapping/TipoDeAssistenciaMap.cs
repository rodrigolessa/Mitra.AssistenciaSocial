using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mitra.AssistenciaSocial.UI.Web.Models.Mapping
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
