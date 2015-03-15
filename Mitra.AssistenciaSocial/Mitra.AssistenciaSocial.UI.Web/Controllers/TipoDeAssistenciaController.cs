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
    [Authorize]
    public class TipoDeAssistenciaController : Controller
    {
        private MitraContext db = new MitraContext();

        //
        // GET: /TipoDeAssistencia/

        public ActionResult Index()
        {
            return View(db.TipoDeAssistencias.ToList());
        }

        //
        // GET: /TipoDeAssistencia/Details/5

        public ActionResult Details(int id = 0)
        {
            TipoDeAssistencia tipodeassistencia = db.TipoDeAssistencias.Find(id);
            if (tipodeassistencia == null)
            {
                return HttpNotFound();
            }
            return View(tipodeassistencia);
        }

        //
        // GET: /TipoDeAssistencia/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TipoDeAssistencia/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TipoDeAssistencia tipodeassistencia)
        {
            if (ModelState.IsValid)
            {
                db.TipoDeAssistencias.Add(tipodeassistencia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipodeassistencia);
        }

        //
        // GET: /TipoDeAssistencia/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TipoDeAssistencia tipodeassistencia = db.TipoDeAssistencias.Find(id);
            if (tipodeassistencia == null)
            {
                return HttpNotFound();
            }
            return View(tipodeassistencia);
        }

        //
        // POST: /TipoDeAssistencia/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TipoDeAssistencia tipodeassistencia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipodeassistencia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipodeassistencia);
        }

        //
        // GET: /TipoDeAssistencia/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TipoDeAssistencia tipodeassistencia = db.TipoDeAssistencias.Find(id);
            if (tipodeassistencia == null)
            {
                return HttpNotFound();
            }
            return View(tipodeassistencia);
        }

        //
        // POST: /TipoDeAssistencia/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoDeAssistencia tipodeassistencia = db.TipoDeAssistencias.Find(id);
            db.TipoDeAssistencias.Remove(tipodeassistencia);
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