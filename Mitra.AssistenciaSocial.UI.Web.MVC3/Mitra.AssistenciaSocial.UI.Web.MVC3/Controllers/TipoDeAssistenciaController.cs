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
    public class TipoDeAssistenciaController : Controller
    {
        private MitraContext db = new MitraContext();

        //
        // GET: /TipoDeAssistencia/

        public ViewResult Index()
        {
            return View(db.TipoDeAssistencias.ToList());
        }

        //
        // GET: /TipoDeAssistencia/Details/5

        public ViewResult Details(int id)
        {
            TipoDeAssistencia tipodeassistencia = db.TipoDeAssistencias.Find(id);
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
 
        public ActionResult Edit(int id)
        {
            TipoDeAssistencia tipodeassistencia = db.TipoDeAssistencias.Find(id);
            return View(tipodeassistencia);
        }

        //
        // POST: /TipoDeAssistencia/Edit/5

        [HttpPost]
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
 
        public ActionResult Delete(int id)
        {
            TipoDeAssistencia tipodeassistencia = db.TipoDeAssistencias.Find(id);
            return View(tipodeassistencia);
        }

        //
        // POST: /TipoDeAssistencia/Delete/5

        [HttpPost, ActionName("Delete")]
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