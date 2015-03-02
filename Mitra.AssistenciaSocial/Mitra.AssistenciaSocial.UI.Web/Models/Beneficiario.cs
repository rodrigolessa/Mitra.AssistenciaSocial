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
        [DisplayName("G�nero")]
        public string Sexo { get; set; }
        [DisplayName("Estado Civil")]
        public string EstadoCivil { get; set; }
        public string Naturalidade { get; set; }
        public string Cor { get; set; }
        [DisplayName("Grau de Instru��o")]
        public string GrauDeInstrucao { get; set; }
        [DisplayName("Endere�o")]
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        [DisplayName("Ponto de Refer�ncia")]
        public string PontoDeFerencia { get; set; }
        [DisplayName("Nome do Respons�vel")]
        public string NomeDoResponsavel { get; set; }
        [DisplayName("Telefone do Respons�vel")]
        public string TelefoneDoResponsavel { get; set; }
        [DisplayName("Renda Familiar")]
        public string RendaFamiliar { get; set; }
        [DisplayName("Benef�cio da Entidade")]
        public Nullable<bool> BeneficioDeEntidade { get; set; }
        [DisplayName("Tipo de Benef�cio")]
        public string TipoDeBeneficioDaEntidade { get; set; }
        [DisplayName("Nome da Entidade")]
        public string NomeDaEntidade { get; set; }
        [DisplayName("Tipo de Resid�ncia")]
        public string TipoDeResidencia { get; set; }
        [DisplayName("Especificar Tipo de Resid�ncia")]
        public string EspecificarTipoDeResidencia { get; set; }
        [DisplayName("Tipo de Constru��o")]
        public string TipoDeConstrucao { get; set; }
        [DisplayName("Piso da Constru��o")]
        public string PisoDaConstrucao { get; set; }
        [DisplayName("Cobertura da Constru��o")]
        public string CoberturaDaConstrucao { get; set; }
        [DisplayName("N�mero de C�modos")]
        public Nullable<short> NumeroDeComodosDaConstrucao { get; set; }
        [DisplayName("C�modos da Constru��o")]
        public string ComodosDaConstrucao { get; set; }
        [DisplayName("Esgoto da Constru��o")]
        public string EsgotoDaConstrucao { get; set; }
        [DisplayName("�gua da Constru��o")]
        public string AguaDaConstrucao { get; set; }
        [DisplayName("Banheiro da Constru��o")]
        public string BanheiroDaConstrucao { get; set; }
        [DisplayName("Energia El�trica da Constru��o")]
        public string EnergiaEletricaDaConstrucao { get; set; }
        [DisplayName("Lixo da Constru��o")]
        public string LixoDaConstrucao { get; set; }
        [DisplayName("Possui Outros Im�veis")]
        public Nullable<bool> PossuiOutrosImoveis { get; set; }
        public string TipoDeConstrucaoOutrosImoveis { get; set; }
        [DisplayName("Possui Ve�culo")]
        public Nullable<bool> PossuiVeiculo { get; set; }
        public string UtilizacaoDoVeiculo { get; set; }
        public Nullable<int> AnoDoVeiculo { get; set; }
        public string ModeloDoVeiculo { get; set; }
        public Nullable<bool> PossuiConvenioMedico { get; set; }
        public string NomeDoConvenioMedico { get; set; }
        public string TratamentoMedico { get; set; }
        public string QualTipoDeDoenca { get; set; }
        public string MedicamentoDeUsoContinuo { get; set; }
        public string ComoAdquireMedicamentos { get; set; }
        public string EspecificarComoAdquireMedicamentos { get; set; }
        public string InformacoesAdicionais { get; set; }
        public Nullable<System.DateTime> DataDeCadastro { get; set; }
        public virtual ICollection<Dependente> Dependentes { get; set; }
        public virtual ICollection<Filiacao> Filiacaos { get; set; }
        public virtual EntidadeSocial EntidadeSocial { get; set; }
        public virtual TipoDeAssistencia TipoDeAssistencia { get; set; }
    }
}
