using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mitra.AssistenciaSocial.UI.Web.Models.ListItem
{
    public static class EsgotoDaConstrucaoListItem
    {
        public static IEnumerable<SelectListItem> Obter()
        {
            var lista = new List<SelectListItem>();
            lista.Add(new SelectListItem() { Value = "R", Text = "Rede geral" });
            lista.Add(new SelectListItem() { Value = "S", Text = "Fossa séptica" });
            lista.Add(new SelectListItem() { Value = "R", Text = "Fossa rudimentar" });
            lista.Add(new SelectListItem() { Value = "N", Text = "Não tem" });

            return lista;
        }
    }
}