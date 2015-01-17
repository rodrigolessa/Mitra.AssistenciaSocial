using System;
using System.Collections.Generic;

namespace Mitra.Dominio.Entities
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
        public Nullable<int> id_estado { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public Nullable<System.DateTime> DataDeNascimento { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string Naturalidade { get; set; }
        public string Cor { get; set; }
        public string GrauDeInstrucao { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Telefone { get; set; }
        public string PontoDeFerencia { get; set; }
        public string NomeDoResponsavel { get; set; }
        public string TelefoneDoResponsavel { get; set; }
        public string RendaFamiliar { get; set; }
        public Nullable<bool> BeneficioDeEntidade { get; set; }
        public string TipoDeBeneficioDaEntidade { get; set; }
        public string NomeDaEntidade { get; set; }
        public string TipoDeResidencia { get; set; }
        public string EspecificarTipoDeResidencia { get; set; }
        public string TipoDeConstrucao { get; set; }
        public string PisoDaConstrucao { get; set; }
        public string CoberturaDaConstrucao { get; set; }
        public Nullable<short> NumeroDeComodosDaConstrucao { get; set; }
        public string ComodosDaConstrucao { get; set; }
        public string EsgotoDaConstrucao { get; set; }
        public string AguaDaConstrucao { get; set; }
        public string BanheiroDaConstrucao { get; set; }
        public string EnergiaEletricaDaConstrucao { get; set; }
        public string LixoDaConstrucao { get; set; }
        public Nullable<bool> PossuiOutrosImoveis { get; set; }
        public string TipoDeConstrucaoOutrosImoveis { get; set; }
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
