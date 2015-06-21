using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mitra.AssistenciaSocial.UI.Web.Models.ListItem
{
    public static class CorListItem
    {
        public static IEnumerable<SelectListItem> Obter()
        {
            var lista = new List<SelectListItem>();
            lista.Add(new SelectListItem() { Value = "B", Text = "Branca" });
            lista.Add(new SelectListItem() { Value = "N", Text = "Negra" });
            lista.Add(new SelectListItem() { Value = "P", Text = "Parda" });
            lista.Add(new SelectListItem() { Value = "I", Text = "Indigena" });
            lista.Add(new SelectListItem() { Value = "A", Text = "Amarela" });

            return lista;
        }
    }
}