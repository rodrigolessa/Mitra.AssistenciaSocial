using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mitra.AssistenciaSocial.UI.Web.Models.ListItem
{
    public static class PisoDaConstrucaoListItem
    {
        public static IEnumerable<SelectListItem> Obter()
        {
            var lista = new List<SelectListItem>();
            lista.Add(new SelectListItem() { Value = "C", Text = "Cerâmica" });
            lista.Add(new SelectListItem() { Value = "C", Text = "Cimento" });
            lista.Add(new SelectListItem() { Value = "T", Text = "Terra" });
            lista.Add(new SelectListItem() { Value = "M", Text = "Madeira" });
            lista.Add(new SelectListItem() { Value = "O", Text = "Outros" });

            return lista;
        }
    }
}