using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mitra.AssistenciaSocial.UI.Web.Models;

namespace Mitra.AssistenciaSocial.UI.Web.Controllers
{
    public class FiliacaoController : Controller
    {
        private MitraContext db = new MitraContext();

        //
        // GET: /Filiacao/

        public ActionResult Index()
        {
            var filiacaos = db.Filiacaos.Include(f => f.Beneficiario);
            return View(filiacaos.ToList());
        }

        //
        // GET: /Filiacao/Details/5

        public ActionResult Details(string id = null)
        {
            Filiacao filiacao = db.Filiacaos.Find(id);
            if (filiacao == null)
            {
                return HttpNotFound();
            }
            return View(filiacao);
        }

        //
        // GET: /Filiacao/Create

        public ActionResult Create()
        {
            ViewBag.id_beneficiario = new SelectList(db.Beneficiarios, "Id", "Nome");
            return View();
        }

        //
        // POST: /Filiacao/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Filiacao filiacao)
        {
            if (ModelState.IsValid)
            {
                db.Filiacaos.Add(filiacao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_beneficiario = new SelectList(db.Beneficiarios, "Id", "Nome", filiacao.id_beneficiario);
            return View(filiacao);
        }

        //
        // GET: /Filiacao/Edit/5

        public ActionResult Edit(string id = null)
        {
            Filiacao filiacao = db.Filiacaos.Find(id);
            if (filiacao == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_beneficiario = new SelectList(db.Beneficiarios, "Id", "Nome", filiacao.id_beneficiario);
            return View(filiacao);
        }

        //
        // POST: /Filiacao/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Filiacao filiacao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(filiacao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_beneficiario = new SelectList(db.Beneficiarios, "Id", "Nome", filiacao.id_beneficiario);
            return View(filiacao);
        }

        //
        // GET: /Filiacao/Delete/5

        public ActionResult Delete(string id = null)
        {
            Filiacao filiacao = db.Filiacaos.Find(id);
            if (filiacao == null)
            {
                return HttpNotFound();
            }
            return View(filiacao);
        }

        //
        // POST: /Filiacao/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Filiacao filiacao = db.Filiacaos.Find(id);
            db.Filiacaos.Remove(filiacao);
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