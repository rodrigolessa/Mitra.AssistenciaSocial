using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Mitra.AssistenciaSocial.UI.Web.Models
{
    public partial class EntidadeSocial
    {
        public EntidadeSocial()
        {
            this.Beneficiarios = new List<Beneficiario>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        [DisplayName("Endereço")]
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string CNPJ { get; set; }
        public virtual ICollection<Beneficiario> Beneficiarios { get; set; }
    }
}
