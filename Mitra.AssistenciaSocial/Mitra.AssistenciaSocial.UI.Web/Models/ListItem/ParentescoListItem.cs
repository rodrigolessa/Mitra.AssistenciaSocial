using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mitra.AssistenciaSocial.UI.Web.Models.ListItem
{
    public static class ParentescoListItem
    {
        public static IEnumerable<SelectListItem> Obter()
        {
            var lista = new List<SelectListItem>();
            lista.Add(new SelectListItem() { Value = "F", Text = "Filhos" });
            lista.Add(new SelectListItem() { Value = "N", Text = "Netos" });
            lista.Add(new SelectListItem() { Value = "B", Text = "Bisnetos" });
            lista.Add(new SelectListItem() { Value = "T", Text = "Trinetos" });
            lista.Add(new SelectListItem() { Value = "C", Text = "Cônjuge" });
            lista.Add(new SelectListItem() { Value = "A", Text = "Avós" });
            lista.Add(new SelectListItem() { Value = "I", Text = "Irmãos" });
            lista.Add(new SelectListItem() { Value = "P", Text = "Primos" });
            lista.Add(new SelectListItem() { Value = "S", Text = "Sobrinhos" });
            lista.Add(new SelectListItem() { Value = "D", Text = "Tios" });
            lista.Add(new SelectListItem() { Value = "O", Text = "Sogros" });
            lista.Add(new SelectListItem() { Value = "U", Text = "Cunhados" });
            lista.Add(new SelectListItem() { Value = "G", Text = "Genros" });

            return lista;
        }
    }
}