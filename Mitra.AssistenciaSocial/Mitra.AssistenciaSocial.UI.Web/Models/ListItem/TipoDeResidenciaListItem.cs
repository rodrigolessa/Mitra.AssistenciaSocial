using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mitra.AssistenciaSocial.UI.Web.Models.ListItem
{
    public static class TipoDeResidenciaListItem
    {
        public static IEnumerable<SelectListItem> Obter()
        {
            var lista = new List<SelectListItem>();
            lista.Add(new SelectListItem() { Value = "P", Text = "Própria" });
            lista.Add(new SelectListItem() { Value = "A", Text = "Alugada" });
            lista.Add(new SelectListItem() { Value = "F", Text = "Financiada" });
            lista.Add(new SelectListItem() { Value = "C", Text = "Cedida" });
            lista.Add(new SelectListItem() { Value = "I", Text = "Invadida" });

            return lista;
        }
    }
}