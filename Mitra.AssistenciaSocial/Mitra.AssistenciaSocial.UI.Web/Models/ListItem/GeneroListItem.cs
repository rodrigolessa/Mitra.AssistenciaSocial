using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mitra.AssistenciaSocial.UI.Web.Models.ListItem
{
    public static class GeneroListItem
    {
        public static IEnumerable<SelectListItem> Obter()
        {
            var generos = new List<SelectListItem>();
            generos.Add(new SelectListItem() { Value = "M", Text = "Masculino" });
            generos.Add(new SelectListItem() { Value = "F", Text = "Feminino" });

            return generos;
        }
    }
}