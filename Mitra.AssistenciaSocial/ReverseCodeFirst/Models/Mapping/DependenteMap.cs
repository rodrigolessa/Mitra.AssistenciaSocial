using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ReverseCodeFirst.Models.Mapping
{
    public class DependenteMap : EntityTypeConfiguration<Dependente>
    {
        public DependenteMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Nome)
                .HasMaxLength(100);

            this.Property(t => t.Parentesco)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.EstadoCivil)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.GrauDeInstrucao)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Profissao)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Dependente", "AssistenciaSocial");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.id_beneficiario).HasColumnName("id_beneficiario");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.DataDeNascimento).HasColumnName("DataDeNascimento");
            this.Property(t => t.Parentesco).HasColumnName("Parentesco");
            this.Property(t => t.EstadoCivil).HasColumnName("EstadoCivil");
            this.Property(t => t.GrauDeInstrucao).HasColumnName("GrauDeInstrucao");
            this.Property(t => t.Profissao).HasColumnName("Profissao");

            // Relationships
            this.HasOptional(t => t.Beneficiario)
                .WithMany(t => t.Dependentes)
                .HasForeignKey(d => d.id_beneficiario);

        }
    }
}
