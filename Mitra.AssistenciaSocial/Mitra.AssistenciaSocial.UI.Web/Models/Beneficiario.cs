using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Mitra.AssistenciaSocial.UI.Web.Models
{
    public partial class Beneficiario
    {
        public Beneficiario()
        {
            this.Dependentes = new List<Dependente>();
            this.Filiacaos = new List<Filiacao>();
        }

        public int Id { get; set; }
        public Nullable<int> id_tipo_assistencia { get; set; }
        public Nullable<int> id_entidade_social { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public Nullable<System.DateTime> DataDeNascimento { get; set; }
        [DisplayName("Gênero")]
        public string Sexo { get; set; }
        [DisplayName("Estado Civil")]
        public string EstadoCivil { get; set; }
        public string Naturalidade { get; set; }
        public string Cor { get; set; }
        [DisplayName("Grau de Instrução")]
        public string GrauDeInstrucao { get; set; }
        [DisplayName("Endereço")]
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        [DisplayName("Ponto de Referência")]
        public string PontoDeFerencia { get; set; }
        [DisplayName("Nome do Responsável")]
        public string NomeDoResponsavel { get; set; }
        [DisplayName("Telefone do Responsável")]
        public string TelefoneDoResponsavel { get; set; }
        [DisplayName("Renda Familiar")]
        public string RendaFamiliar { get; set; }
        [DisplayName("Benefício da Entidade")]
        public Nullable<bool> BeneficioDeEntidade { get; set; }
        [DisplayName("Tipo de Benefício")]
        public string TipoDeBeneficioDaEntidade { get; set; }
        [DisplayName("Nome da Entidade")]
        public string NomeDaEntidade { get; set; }
        [DisplayName("Tipo de Residência")]
        public string TipoDeResidencia { get; set; }
        [DisplayName("Especificar Tipo de Residência")]
        public string EspecificarTipoDeResidencia { get; set; }
        [DisplayName("Tipo de Construção")]
        public string TipoDeConstrucao { get; set; }
        [DisplayName("Piso da Construção")]
        public string PisoDaConstrucao { get; set; }
        [DisplayName("Cobertura da Construção")]
        public string CoberturaDaConstrucao { get; set; }
        [DisplayName("Número de Cômodos")]
        public Nullable<short> NumeroDeComodosDaConstrucao { get; set; }
        [DisplayName("Cômodos da Construção")]
        public string ComodosDaConstrucao { get; set; }
        [DisplayName("Esgoto da Construção")]
        public string EsgotoDaConstrucao { get; set; }
        [DisplayName("Água da Construção")]
        public string AguaDaConstrucao { get; set; }
        [DisplayName("Banheiro da Construção")]
        public string BanheiroDaConstrucao { get; set; }
        [DisplayName("Energia Elétrica da Construção")]
        public string EnergiaEletricaDaConstrucao { get; set; }
        [DisplayName("Lixo da Construção")]
        public string LixoDaConstrucao { get; set; }
        [DisplayName("Possui Outros Imóveis")]
        public Nullable<bool> PossuiOutrosImoveis { get; set; }
        public string TipoDeConstrucaoOutrosImoveis { get; set; }
        [DisplayName("Possui Veículo")]
        public Nullable<bool> PossuiVeiculo { get; set; }
        [DisplayName("Utilização do Veículo")]
        public string UtilizacaoDoVeiculo { get; set; }
        [DisplayName("Ano do Veículo")]
        public Nullable<int> AnoDoVeiculo { get; set; }
        [DisplayName("Modulo do Veículo")]
        public string ModeloDoVeiculo { get; set; }
        [DisplayName("Possui Convênio Médico")]
        public Nullable<bool> PossuiConvenioMedico { get; set; }
        [DisplayName("Nome do Convênio Médico")]
        public string NomeDoConvenioMedico { get; set; }
        [DisplayName("Tratamento Médico")]
        public string TratamentoMedico { get; set; }
        [DisplayName("Qual Tipo de Doença")]
        public string QualTipoDeDoenca { get; set; }
        [DisplayName("Medicmaneto de Uso Contínuo")]
        public string MedicamentoDeUsoContinuo { get; set; }
        [DisplayName("Como Adquire Medicamentos")]
        public string ComoAdquireMedicamentos { get; set; }
        [DisplayName("Especificar Como Adquire Medicamentos")]
        public string EspecificarComoAdquireMedicamentos { get; set; }
        [DisplayName("Informações Adicionais")]
        public string InformacoesAdicionais { get; set; }
        [DisplayName("Data De Cadastro")]
        public Nullable<System.DateTime> DataDeCadastro { get; set; }
        public virtual ICollection<Dependente> Dependentes { get; set; }
        [DisplayName("Filiações")]
        public virtual ICollection<Filiacao> Filiacaos { get; set; }
        [DisplayName("Entidade Social")]
        public virtual EntidadeSocial EntidadeSocial { get; set; }
        [DisplayName("Tipo de Assistência")]
        public virtual TipoDeAssistencia TipoDeAssistencia { get; set; }
    }
}
