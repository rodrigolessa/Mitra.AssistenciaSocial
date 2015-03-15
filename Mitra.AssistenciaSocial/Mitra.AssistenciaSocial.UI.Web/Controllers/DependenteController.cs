using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mitra.AssistenciaSocial.UI.Web.Models;
using Mitra.AssistenciaSocial.UI.Web.Models.ListItem;

namespace Mitra.AssistenciaSocial.UI.Web.Controllers
{
    [Authorize]
    public class DependenteController : Controller
    {
        private MitraContext db = new MitraContext();

        //
        // GET: /Dependente/

        public ActionResult Index()
        {
            var dependentes = db.Dependentes.Include(d => d.Beneficiario);
            return View(dependentes.ToList());
        }

        //
        // GET: /Dependente/Details/5

        public ActionResult Details(int id = 0)
        {
            Dependente dependente = db.Dependentes.Find(id);
            if (dependente == null)
            {
                return HttpNotFound();
            }
            return View(dependente);
        }

        //
        // GET: /Dependente/Create

        public ActionResult Create()
        {
            ViewBag.id_beneficiario = new SelectList(db.Beneficiarios, "Id", "Nome");
            ViewBag.Parentesco = ParentescoListItem.Obter();
                ViewBag.EstadoCivil = EstadoCivilListItem.Obter();
                ViewBag.GrauDeInstrucao = GrauDeInstrucaoListItem.Obter();
            return View();
        }

        //
        // POST: /Dependente/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Dependente dependente)
        {
            if (ModelState.IsValid)
            {
                db.Dependentes.Add(dependente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_beneficiario = new SelectList(db.Beneficiarios, "Id", "Nome", dependente.id_beneficiario);
            ViewBag.Parentesco = ParentescoListItem.Obter();
            ViewBag.EstadoCivil = EstadoCivilListItem.Obter();
            ViewBag.GrauDeInstrucao = GrauDeInstrucaoListItem.Obter();
            return View(dependente);
        }

        //
        // GET: /Dependente/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Dependente dependente = db.Dependentes.Find(id);
            if (dependente == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_beneficiario = new SelectList(db.Beneficiarios, "Id", "Nome", dependente.id_beneficiario);
            ViewBag.Parentesco = ParentescoListItem.Obter();
            ViewBag.EstadoCivil = EstadoCivilListItem.Obter();
            ViewBag.GrauDeInstrucao = GrauDeInstrucaoListItem.Obter();
            return View(dependente);
        }

        //
        // POST: /Dependente/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Dependente dependente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dependente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_beneficiario = new SelectList(db.Beneficiarios, "Id", "Nome", dependente.id_beneficiario);
            ViewBag.Parentesco = ParentescoListItem.Obter();
            ViewBag.EstadoCivil = EstadoCivilListItem.Obter();
            ViewBag.GrauDeInstrucao = GrauDeInstrucaoListItem.Obter();
            return View(dependente);
        }

        //
        // GET: /Dependente/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Dependente dependente = db.Dependentes.Find(id);
            if (dependente == null)
            {
                return HttpNotFound();
            }
            return View(dependente);
        }

        //
        // POST: /Dependente/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Dependente dependente = db.Dependentes.Find(id);
            db.Dependentes.Remove(dependente);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}