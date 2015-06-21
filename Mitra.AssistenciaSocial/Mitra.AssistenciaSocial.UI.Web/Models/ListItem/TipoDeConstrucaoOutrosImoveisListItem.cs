using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mitra.AssistenciaSocial.UI.Web.Models.ListItem
{
    public static class TipoDeConstrucaoOutrosImoveisListItem
    {
        public static IEnumerable<SelectListItem> Obter()
        {
            var lista = new List<SelectListItem>();
            lista.Add(new SelectListItem() { Value = "A", Text = "Apartamento" });
            lista.Add(new SelectListItem() { Value = "C", Text = "Casa de alvenaria" });
            lista.Add(new SelectListItem() { Value = "M", Text = "Casa de madeira" });
            lista.Add(new SelectListItem() { Value = "O", Text = "Outros" });

            return lista;
        }
    }
}