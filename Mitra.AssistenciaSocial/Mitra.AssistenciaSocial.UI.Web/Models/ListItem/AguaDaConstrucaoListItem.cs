﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mitra.AssistenciaSocial.UI.Web.Models.ListItem
{
    public static class AguaDaConstrucaoListItem
    {
        public static IEnumerable<SelectListItem> Obter()
        {
            var lista = new List<SelectListItem>();
            lista.Add(new SelectListItem() { Value = "C", Text = "Canalizada" });
            lista.Add(new SelectListItem() { Value = "P", Text = "Poço" });
            lista.Add(new SelectListItem() { Value = "T", Text = "Torneira Pública" });
            lista.Add(new SelectListItem() { Value = "O", Text = "Outros" });

            return lista;
        }
    }
}