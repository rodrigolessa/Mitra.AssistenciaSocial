using System;
using System.Collections.Generic;

namespace ReverseCodeFirst.Models
{
    public partial class EntidadeSocial
    {
        public EntidadeSocial()
        {
            this.AssistenciaPorMes = new List<AssistenciaPorMe>();
            this.TipoDeAssistencias = new List<TipoDeAssistencia>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string CNPJ { get; set; }
        public string EntidadePrincipal { get; set; }
        public string Coordenador { get; set; }
        public string TelefoneCoordenador { get; set; }
        public Nullable<int> QuantidadeDeMembros { get; set; }
        public virtual ICollection<AssistenciaPorMe> AssistenciaPorMes { get; set; }
        public virtual ICollection<TipoDeAssistencia> TipoDeAssistencias { get; set; }
    }
}
