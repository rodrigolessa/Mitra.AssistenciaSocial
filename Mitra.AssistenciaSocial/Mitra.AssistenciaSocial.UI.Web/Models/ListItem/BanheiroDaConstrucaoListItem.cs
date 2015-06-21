using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mitra.AssistenciaSocial.UI.Web.Models.ListItem
{
    public static class BanheiroDaConstrucaoListItem
    {
        public static IEnumerable<SelectListItem> Obter()
        {
            var lista = new List<SelectListItem>();
            lista.Add(new SelectListItem() { Value = "D", Text = "Dentro de casa" });
            lista.Add(new SelectListItem() { Value = "F", Text = "Fora de casa" });
            lista.Add(new SelectListItem() { Value = "O", Text = "Outros" });

            return lista;
        }
    }
}