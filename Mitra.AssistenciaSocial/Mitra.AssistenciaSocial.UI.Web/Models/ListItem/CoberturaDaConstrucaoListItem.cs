using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mitra.AssistenciaSocial.UI.Web.Models.ListItem
{
    public static class CoberturaDaConstrucaoListItem
    {
        public static IEnumerable<SelectListItem> Obter()
        {
            var lista = new List<SelectListItem>();
            lista.Add(new SelectListItem() { Value = "L", Text = "Laje" });
            lista.Add(new SelectListItem() { Value = "A", Text = "Telhado de amianto" });
            lista.Add(new SelectListItem() { Value = "B", Text = "Telhado de barro" });
            lista.Add(new SelectListItem() { Value = "Z", Text = "Telha de zinco" });
            lista.Add(new SelectListItem() { Value = "O", Text = "Outros" });

            return lista;
        }
    }
}