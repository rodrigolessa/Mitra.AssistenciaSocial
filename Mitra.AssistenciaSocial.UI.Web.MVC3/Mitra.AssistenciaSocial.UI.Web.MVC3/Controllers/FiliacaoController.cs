using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mitra.AssistenciaSocial.UI.Web.MVC3.Models;

namespace Mitra.AssistenciaSocial.UI.Web.MVC3.Controllers
{ 
    public class FiliacaoController : Controller
    {
        private MitraContext db = new MitraContext();

        //
        // GET: /Filiacao/

        public ViewResult Index()
        {
            var filiacaos = db.Filiacaos.Include(f => f.Beneficiario);
            return View(filiacaos.ToList());
        }

        //
        // GET: /Filiacao/Details/5

        public ViewResult Details(string id)
        {
            Filiacao filiacao = db.Filiacaos.Find(id);
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
 
        public ActionResult Edit(string id)
        {
            Filiacao filiacao = db.Filiacaos.Find(id);
            ViewBag.id_beneficiario = new SelectList(db.Beneficiarios, "Id", "Nome", filiacao.id_beneficiario);
            return View(filiacao);
        }

        //
        // POST: /Filiacao/Edit/5

        [HttpPost]
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
 
        public ActionResult Delete(string id)
        {
            Filiacao filiacao = db.Filiacaos.Find(id);
            return View(filiacao);
        }

        //
        // POST: /Filiacao/Delete/5

        [HttpPost, ActionName("Delete")]
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