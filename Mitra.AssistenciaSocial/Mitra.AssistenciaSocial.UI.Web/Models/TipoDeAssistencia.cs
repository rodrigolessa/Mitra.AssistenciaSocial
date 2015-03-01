using System;
using System.Collections.Generic;

namespace Mitra.AssistenciaSocial.UI.Web.Models
{
    public partial class TipoDeAssistencia
    {
        public TipoDeAssistencia()
        {
            this.Beneficiarios = new List<Beneficiario>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Beneficiario> Beneficiarios { get; set; }
    }
}
