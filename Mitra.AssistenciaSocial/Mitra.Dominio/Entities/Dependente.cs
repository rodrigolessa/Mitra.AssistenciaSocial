using System;
using System.Collections.Generic;

namespace Mitra.Dominio.Entities
{
    public partial class Dependente
    {
        public int Id { get; set; }
        public Nullable<int> id_beneficiario { get; set; }
        public string Nome { get; set; }
        public Nullable<System.DateTime> DataDeNascimento { get; set; }
        public string Parentesco { get; set; }
        public string EstadoCivil { get; set; }
        public string GrauDeInstrucao { get; set; }
        public string Profissao { get; set; }
        public virtual Beneficiario Beneficiario { get; set; }
    }
}
