using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mitra.AssistenciaSocial.UI.Web.Models.ListItem
{
    public static class EstadoCivilListItem
    {
        public static IEnumerable<SelectListItem> Obter()
        {
            var lista = new List<SelectListItem>();
            lista.Add(new SelectListItem() { Value = "S", Text = "Solteiro(a)" });
            lista.Add(new SelectListItem() { Value = "C", Text = "Casado(a)" });
            lista.Add(new SelectListItem() { Value = "D", Text = "Divorciado(a)" });
            lista.Add(new SelectListItem() { Value = "V", Text = "Viúvo(a)" });

            return lista;
        }
    }
}