using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mitra.AssistenciaSocial.UI.WPF.Models.Mapping
{
    public class FiliacaoMap : EntityTypeConfiguration<Filiacao>
    {
        public FiliacaoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Parentesco, t.id_beneficiario });

            // Properties
            this.Property(t => t.Parentesco)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.id_beneficiario)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Nome)
                .HasMaxLength(100);

            this.Property(t => t.EstadoCivil)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.GrauDeInstrucao)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.LocalDeTrabalho)
                .HasMaxLength(100);

            this.Property(t => t.EnderecoDeTrabalho)
                .HasMaxLength(255);

            this.Property(t => t.Telefone)
                .HasMaxLength(15);

            this.Property(t => t.Profissao)
                .HasMaxLength(100);

            this.Property(t => t.FaixaSalarial)
                .HasMaxLength(50);

            this.Property(t => t.HorarioDeTrabalho)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("Filiacao", "AssistenciaSocial");
            this.Property(t => t.Parentesco).HasColumnName("Parentesco");
            this.Property(t => t.id_beneficiario).HasColumnName("id_beneficiario");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.EstadoCivil).HasColumnName("EstadoCivil");
            this.Property(t => t.DataDeNascimento).HasColumnName("DataDeNascimento");
            this.Property(t => t.GrauDeInstrucao).HasColumnName("GrauDeInstrucao");
            this.Property(t => t.LocalDeTrabalho).HasColumnName("LocalDeTrabalho");
            this.Property(t => t.EnderecoDeTrabalho).HasColumnName("EnderecoDeTrabalho");
            this.Property(t => t.Telefone).HasColumnName("Telefone");
            this.Property(t => t.Profissao).HasColumnName("Profissao");
            this.Property(t => t.FaixaSalarial).HasColumnName("FaixaSalarial");
            this.Property(t => t.HorarioDeTrabalho).HasColumnName("HorarioDeTrabalho");

            // Relationships
            this.HasRequired(t => t.Beneficiario)
                .WithMany(t => t.Filiacaos)
                .HasForeignKey(d => d.id_beneficiario);

        }
    }
}
