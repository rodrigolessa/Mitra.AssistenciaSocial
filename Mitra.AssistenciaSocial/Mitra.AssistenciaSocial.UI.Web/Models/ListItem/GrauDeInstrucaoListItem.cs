﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mitra.AssistenciaSocial.UI.Web.Models.ListItem
{
    public static class GrauDeInstrucaoListItem
    {
        public static IEnumerable<SelectListItem> Obter()
        {
            var lista = new List<SelectListItem>();
            lista.Add(new SelectListItem() { Value = "N", Text = "Nenhum" });
            lista.Add(new SelectListItem() { Value = "F", Text = "Ensino Fundamental" });
            lista.Add(new SelectListItem() { Value = "M", Text = "Ensino Médio" });
            lista.Add(new SelectListItem() { Value = "S", Text = "Ensino Superior" });

            return lista;
        }
    }
}