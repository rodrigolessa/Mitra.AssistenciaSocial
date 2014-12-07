using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mitra.AssistenciaSocial.UI.WPF.Models.Mapping
{
    public class BeneficiarioMap : EntityTypeConfiguration<Beneficiario>
    {
        public BeneficiarioMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Nome)
                .HasMaxLength(100);

            this.Property(t => t.CPF)
                .HasMaxLength(15);

            this.Property(t => t.RG)
                .HasMaxLength(20);

            this.Property(t => t.Sexo)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.EstadoCivil)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Naturalidade)
                .HasMaxLength(50);

            this.Property(t => t.Cor)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.GrauDeInstrucao)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Endereco)
                .HasMaxLength(255);

            this.Property(t => t.Bairro)
                .HasMaxLength(50);

            this.Property(t => t.Cidade)
                .HasMaxLength(100);

            this.Property(t => t.Telefone)
                .HasMaxLength(15);

            this.Property(t => t.NomeDoResponsavel)
                .HasMaxLength(100);

            this.Property(t => t.TelefoneDoResponsavel)
                .HasMaxLength(15);

            this.Property(t => t.RendaFamiliar)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.NomeDaEntidade)
                .HasMaxLength(255);

            this.Property(t => t.TipoDeResidencia)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.TipoDeConstrucao)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.PisoDaConstrucao)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.CoberturaDaConstrucao)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.EsgotoDaConstrucao)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.AguaDaConstrucao)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.BanheiroDaConstrucao)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.EnergiaEletricaDaConstrucao)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.LixoDaConstrucao)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.TipoDeConstrucaoOutrosImoveis)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.UtilizacaoDoVeiculo)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ModeloDoVeiculo)
                .HasMaxLength(50);

            this.Property(t => t.NomeDoConvenioMedico)
                .HasMaxLength(50);

            this.Property(t => t.QualTipoDeDoenca)
                .HasMaxLength(100);

            this.Property(t => t.MedicamentoDeUsoContinuo)
                .HasMaxLength(255);

            this.Property(t => t.ComoAdquireMedicamentos)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("Beneficiario", "AssistenciaSocial");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.id_tipo_assistencia).HasColumnName("id_tipo_assistencia");
            this.Property(t => t.id_entidade_social).HasColumnName("id_entidade_social");
            this.Property(t => t.id_estado).HasColumnName("id_estado");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.CPF).HasColumnName("CPF");
            this.Property(t => t.RG).HasColumnName("RG");
            this.Property(t => t.DataDeNascimento).HasColumnName("DataDeNascimento");
            this.Property(t => t.Sexo).HasColumnName("Sexo");
            this.Property(t => t.EstadoCivil).HasColumnName("EstadoCivil");
            this.Property(t => t.Naturalidade).HasColumnName("Naturalidade");
            this.Property(t => t.Cor).HasColumnName("Cor");
            this.Property(t => t.GrauDeInstrucao).HasColumnName("GrauDeInstrucao");
            this.Property(t => t.Endereco).HasColumnName("Endereco");
            this.Property(t => t.Bairro).HasColumnName("Bairro");
            this.Property(t => t.Cidade).HasColumnName("Cidade");
            this.Property(t => t.Telefone).HasColumnName("Telefone");
            this.Property(t => t.PontoDeFerencia).HasColumnName("PontoDeFerencia");
            this.Property(t => t.NomeDoResponsavel).HasColumnName("NomeDoResponsavel");
            this.Property(t => t.TelefoneDoResponsavel).HasColumnName("TelefoneDoResponsavel");
            this.Property(t => t.RendaFamiliar).HasColumnName("RendaFamiliar");
            this.Property(t => t.BeneficioDeEntidade).HasColumnName("BeneficioDeEntidade");
            this.Property(t => t.TipoDeBeneficioDaEntidade).HasColumnName("TipoDeBeneficioDaEntidade");
            this.Property(t => t.NomeDaEntidade).HasColumnName("NomeDaEntidade");
            this.Property(t => t.TipoDeResidencia).HasColumnName("TipoDeResidencia");
            this.Property(t => t.EspecificarTipoDeResidencia).HasColumnName("EspecificarTipoDeResidencia");
            this.Property(t => t.TipoDeConstrucao).HasColumnName("TipoDeConstrucao");
            this.Property(t => t.PisoDaConstrucao).HasColumnName("PisoDaConstrucao");
            this.Property(t => t.CoberturaDaConstrucao).HasColumnName("CoberturaDaConstrucao");
            this.Property(t => t.NumeroDeComodosDaConstrucao).HasColumnName("NumeroDeComodosDaConstrucao");
            this.Property(t => t.ComodosDaConstrucao).HasColumnName("ComodosDaConstrucao");
            this.Property(t => t.EsgotoDaConstrucao).HasColumnName("EsgotoDaConstrucao");
            this.Property(t => t.AguaDaConstrucao).HasColumnName("AguaDaConstrucao");
            this.Property(t => t.BanheiroDaConstrucao).HasColumnName("BanheiroDaConstrucao");
            this.Property(t => t.EnergiaEletricaDaConstrucao).HasColumnName("EnergiaEletricaDaConstrucao");
            this.Property(t => t.LixoDaConstrucao).HasColumnName("LixoDaConstrucao");
            this.Property(t => t.PossuiOutrosImoveis).HasColumnName("PossuiOutrosImoveis");
            this.Property(t => t.TipoDeConstrucaoOutrosImoveis).HasColumnName("TipoDeConstrucaoOutrosImoveis");
            this.Property(t => t.PossuiVeiculo).HasColumnName("PossuiVeiculo");
            this.Property(t => t.UtilizacaoDoVeiculo).HasColumnName("UtilizacaoDoVeiculo");
            this.Property(t => t.AnoDoVeiculo).HasColumnName("AnoDoVeiculo");
            this.Property(t => t.ModeloDoVeiculo).HasColumnName("ModeloDoVeiculo");
            this.Property(t => t.PossuiConvenioMedico).HasColumnName("PossuiConvenioMedico");
            this.Property(t => t.NomeDoConvenioMedico).HasColumnName("NomeDoConvenioMedico");
            this.Property(t => t.TratamentoMedico).HasColumnName("TratamentoMedico");
            this.Property(t => t.QualTipoDeDoenca).HasColumnName("QualTipoDeDoenca");
            this.Property(t => t.MedicamentoDeUsoContinuo).HasColumnName("MedicamentoDeUsoContinuo");
            this.Property(t => t.ComoAdquireMedicamentos).HasColumnName("ComoAdquireMedicamentos");
            this.Property(t => t.EspecificarComoAdquireMedicamentos).HasColumnName("EspecificarComoAdquireMedicamentos");
            this.Property(t => t.InformacoesAdicionais).HasColumnName("InformacoesAdicionais");
            this.Property(t => t.DataDeCadastro).HasColumnName("DataDeCadastro");

            // Relationships
            this.HasOptional(t => t.EntidadeSocial)
                .WithMany(t => t.Beneficiarios)
                .HasForeignKey(d => d.id_entidade_social);
            this.HasOptional(t => t.TipoDeAssistencia)
                .WithMany(t => t.Beneficiarios)
                .HasForeignKey(d => d.id_tipo_assistencia);

        }
    }
}
