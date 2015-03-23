using System;
using System.Collections.Generic;

namespace ReverseCodeFirst.Models
{
    public partial class AssistenciaPorMe
    {
        public int id_beneficiario { get; set; }
        public int id_entidade_social { get; set; }
        public int id_tipo_assistencia { get; set; }
        public System.DateTime Data { get; set; }
        public string Descricao { get; set; }
        public Nullable<decimal> Quantidade { get; set; }
        public virtual Beneficiario Beneficiario { get; set; }
        public virtual EntidadeSocial EntidadeSocial { get; set; }
        public virtual TipoDeAssistencia TipoDeAssistencia { get; set; }
    }
}
