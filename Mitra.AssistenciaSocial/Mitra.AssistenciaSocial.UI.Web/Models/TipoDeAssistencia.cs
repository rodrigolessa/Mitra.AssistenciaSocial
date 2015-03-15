using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Mitra.AssistenciaSocial.UI.Web.Models
{
    public partial class TipoDeAssistencia
    {
        public TipoDeAssistencia()
        {
            this.Beneficiarios = new List<Beneficiario>();
        }

        public int Id { get; set; }
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
        public virtual ICollection<Beneficiario> Beneficiarios { get; set; }
    }
}
