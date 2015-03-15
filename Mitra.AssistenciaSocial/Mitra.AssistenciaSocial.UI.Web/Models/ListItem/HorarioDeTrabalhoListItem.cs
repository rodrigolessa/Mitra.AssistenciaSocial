using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mitra.AssistenciaSocial.UI.Web.Models.ListItem
{
    public static class HorarioDeTrabalhoListItem
    {
        public static IEnumerable<SelectListItem> Obter()
        {
            var lista = new List<SelectListItem>();
            lista.Add(new SelectListItem() { Value = "M", Text = "Manhã" });
            lista.Add(new SelectListItem() { Value = "T", Text = "Tarde" });
            lista.Add(new SelectListItem() { Value = "N", Text = "Noite" });

            return lista;
        }
    }
}