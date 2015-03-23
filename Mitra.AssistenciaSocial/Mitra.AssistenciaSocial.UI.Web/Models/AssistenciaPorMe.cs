using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Mitra.AssistenciaSocial.UI.Web.Models
{
    public partial class AssistenciaPorMe
    {
        public int id_beneficiario { get; set; }
        public int id_entidade_social { get; set; }
        public int id_tipo_assistencia { get; set; }
        public System.DateTime Data { get; set; }
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
        public Nullable<decimal> Quantidade { get; set; }
        [DisplayName("Beneficiário")]
        public virtual Beneficiario Beneficiario { get; set; }
        [DisplayName("Entidade Social")]
        public virtual EntidadeSocial EntidadeSocial { get; set; }
        [DisplayName("Tipo de Assistência")]
        public virtual TipoDeAssistencia TipoDeAssistencia { get; set; }
    }
}
