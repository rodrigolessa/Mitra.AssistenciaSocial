using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mitra.AssistenciaSocial.UI.Web.Models.Mapping
{
    public class EntidadeSocialMap : EntityTypeConfiguration<EntidadeSocial>
    {
        public EntidadeSocialMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Nome)
                .HasMaxLength(255);

            this.Property(t => t.Endereco)
                .HasMaxLength(255);

            this.Property(t => t.Telefone)
                .HasMaxLength(15);

            this.Property(t => t.CNPJ)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EntidadeSocial", "AssistenciaSocial");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Endereco).HasColumnName("Endereco");
            this.Property(t => t.Telefone).HasColumnName("Telefone");
            this.Property(t => t.CNPJ).HasColumnName("CNPJ");
        }
    }
}
