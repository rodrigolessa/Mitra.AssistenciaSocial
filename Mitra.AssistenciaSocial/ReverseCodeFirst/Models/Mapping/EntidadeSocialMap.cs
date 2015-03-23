using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ReverseCodeFirst.Models.Mapping
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

            this.Property(t => t.EntidadePrincipal)
                .HasMaxLength(255);

            this.Property(t => t.Coordenador)
                .HasMaxLength(100);

            this.Property(t => t.TelefoneCoordenador)
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("EntidadeSocial", "AssistenciaSocial");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Endereco).HasColumnName("Endereco");
            this.Property(t => t.Telefone).HasColumnName("Telefone");
            this.Property(t => t.CNPJ).HasColumnName("CNPJ");
            this.Property(t => t.EntidadePrincipal).HasColumnName("EntidadePrincipal");
            this.Property(t => t.Coordenador).HasColumnName("Coordenador");
            this.Property(t => t.TelefoneCoordenador).HasColumnName("TelefoneCoordenador");
            this.Property(t => t.QuantidadeDeMembros).HasColumnName("QuantidadeDeMembros");
        }
    }
}
