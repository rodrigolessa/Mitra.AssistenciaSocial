using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mitra.AssistenciaSocial.UI.Web.Models.ListItem
{
    public static class UtilizacaoDoVeiculoListItem
    {
        public static IEnumerable<SelectListItem> Obter()
        {
            var lista = new List<SelectListItem>();
            lista.Add(new SelectListItem() { Value = "L", Text = "Para lazer" });
            lista.Add(new SelectListItem() { Value = "T", Text = "Para trabalho" });

            return lista;
        }
    }
}