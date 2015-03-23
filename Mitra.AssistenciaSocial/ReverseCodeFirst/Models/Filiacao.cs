using System;
using System.Collections.Generic;

namespace ReverseCodeFirst.Models
{
    public partial class Filiacao
    {
        public string Parentesco { get; set; }
        public int id_beneficiario { get; set; }
        public string Nome { get; set; }
        public string EstadoCivil { get; set; }
        public Nullable<System.DateTime> DataDeNascimento { get; set; }
        public string GrauDeInstrucao { get; set; }
        public string LocalDeTrabalho { get; set; }
        public string EnderecoDeTrabalho { get; set; }
        public string Telefone { get; set; }
        public string Profissao { get; set; }
        public string FaixaSalarial { get; set; }
        public string HorarioDeTrabalho { get; set; }
        public virtual Beneficiario Beneficiario { get; set; }
    }
}
