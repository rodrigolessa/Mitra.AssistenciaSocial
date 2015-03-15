using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Mitra.AssistenciaSocial.UI.Web.Models
{
    public partial class Filiacao
    {
        public string Parentesco { get; set; }
        public int id_beneficiario { get; set; }
        public string Nome { get; set; }
        [DisplayName("Estado Civil")]
        public string EstadoCivil { get; set; }
        [DisplayName("Data De Nascimento")]
        public Nullable<System.DateTime> DataDeNascimento { get; set; }
        [DisplayName("Grau de Instrução")]
        public string GrauDeInstrucao { get; set; }
        [DisplayName("Local de Trabalho")]
        public string LocalDeTrabalho { get; set; }
        [DisplayName("Endereço de Trabalho")]
        public string EnderecoDeTrabalho { get; set; }
        public string Telefone { get; set; }
        [DisplayName("Profissão")]
        public string Profissao { get; set; }
        [DisplayName("Faixa Salarial")]
        public string FaixaSalarial { get; set; }
        [DisplayName("Horário de Trabalho")]
        public string HorarioDeTrabalho { get; set; }
        public virtual Beneficiario Beneficiario { get; set; }
    }
}
