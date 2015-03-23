using System;
using System.Collections.Generic;

namespace ReverseCodeFirst.Models
{
    public partial class TipoDeAssistencia
    {
        public TipoDeAssistencia()
        {
            this.AssistenciaPorMes = new List<AssistenciaPorMe>();
        }

        public int Id { get; set; }
        public int id_entidade_social { get; set; }
        public string Descricao { get; set; }
        public string Unidade { get; set; }
        public virtual ICollection<AssistenciaPorMe> AssistenciaPorMes { get; set; }
        public virtual EntidadeSocial EntidadeSocial { get; set; }
    }
}
