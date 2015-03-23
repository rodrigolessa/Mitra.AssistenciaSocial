using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mitra.AssistenciaSocial.UI.Web.Models.Mapping
{
    public class AssistenciaPorMeMap : EntityTypeConfiguration<AssistenciaPorMe>
    {
        public AssistenciaPorMeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id_beneficiario, t.id_entidade_social, t.id_tipo_assistencia, t.Data });

            // Properties
            this.Property(t => t.id_beneficiario)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.id_entidade_social)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.id_tipo_assistencia)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Descricao)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("AssistenciaPorMes", "AssistenciaSocial");
            this.Property(t => t.id_beneficiario).HasColumnName("id_beneficiario");
            this.Property(t => t.id_entidade_social).HasColumnName("id_entidade_social");
            this.Property(t => t.id_tipo_assistencia).HasColumnName("id_tipo_assistencia");
            this.Property(t => t.Data).HasColumnName("Data");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.Quantidade).HasColumnName("Quantidade");

            // Relationships
            this.HasRequired(t => t.Beneficiario)
                .WithMany(t => t.AssistenciaPorMes)
                .HasForeignKey(d => d.id_beneficiario);
            this.HasRequired(t => t.EntidadeSocial)
                .WithMany(t => t.AssistenciaPorMes)
                .HasForeignKey(d => d.id_entidade_social);
            this.HasRequired(t => t.TipoDeAssistencia)
                .WithMany(t => t.AssistenciaPorMes)
                .HasForeignKey(d => d.id_tipo_assistencia);

        }
    }
}
