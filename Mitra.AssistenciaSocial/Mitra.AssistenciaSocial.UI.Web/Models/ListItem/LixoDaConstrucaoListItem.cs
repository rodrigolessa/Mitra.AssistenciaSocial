using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mitra.AssistenciaSocial.UI.Web.Models.ListItem
{
    public static class LixoDaConstrucaoListItem
    {
        public static IEnumerable<SelectListItem> Obter()
        {
            var lista = new List<SelectListItem>();
            lista.Add(new SelectListItem() { Value = "C", Text = "Coleta Pública" });
            lista.Add(new SelectListItem() { Value = "Q", Text = "Queimado" });
            lista.Add(new SelectListItem() { Value = "T", Text = "Joga em terreno" });
            lista.Add(new SelectListItem() { Value = "O", Text = "Outros" });

            return lista;
        }
    }
}