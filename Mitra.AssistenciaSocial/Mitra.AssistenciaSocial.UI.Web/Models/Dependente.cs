using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Mitra.AssistenciaSocial.UI.Web.Models
{
    public partial class Dependente
    {
        public int Id { get; set; }
        public Nullable<int> id_beneficiario { get; set; }
        public string Nome { get; set; }
        [DisplayName("Data De Nascimento")]
        public Nullable<System.DateTime> DataDeNascimento { get; set; }
        [DisplayName("Grau de Parentesco")]
        public string Parentesco { get; set; }
        [DisplayName("Estado Civil")]
        public string EstadoCivil { get; set; }
        [DisplayName("Grau de Instrução")]
        public string GrauDeInstrucao { get; set; }
        [DisplayName("Profissão")]
        public string Profissao { get; set; }
        public virtual Beneficiario Beneficiario { get; set; }
    }
}
