using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mitra.AssistenciaSocial.UI.Web.Models.ListItem
{
    public static class RendaFamiliarListItem
    {
        public static IEnumerable<SelectListItem> Obter()
        {
            var lista = new List<SelectListItem>();
            lista.Add(new SelectListItem() { Value = "1", Text = "Até 1 SM" });
            lista.Add(new SelectListItem() { Value = "2", Text = "de 1 a 2 SM" });
            lista.Add(new SelectListItem() { Value = "3", Text = "de 2 a 3 SM" });
            lista.Add(new SelectListItem() { Value = "4", Text = "de 3 a 4 SM" });
            lista.Add(new SelectListItem() { Value = "5", Text = "mais de 4 SM" });

            return lista;
        }
    }
}