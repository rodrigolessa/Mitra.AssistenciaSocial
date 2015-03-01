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
    public class EntidadeSocialController : Controller
    {
        private MitraContext db = new MitraContext();

        //
        // GET: /EntidadeSocial/

        public ViewResult Index()
        {
            return View(db.EntidadeSocials.ToList());
        }

        //
        // GET: /EntidadeSocial/Details/5

        public ViewResult Details(int id)
        {
            EntidadeSocial entidadesocial = db.EntidadeSocials.Find(id);
            return View(entidadesocial);
        }

        //
        // GET: /EntidadeSocial/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /EntidadeSocial/Create

        [HttpPost]
        public ActionResult Create(EntidadeSocial entidadesocial)
        {
            if (ModelState.IsValid)
            {
                db.EntidadeSocials.Add(entidadesocial);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(entidadesocial);
        }
        
        //
        // GET: /EntidadeSocial/Edit/5
 
        public ActionResult Edit(int id)
        {
            EntidadeSocial entidadesocial = db.EntidadeSocials.Find(id);
            return View(entidadesocial);
        }

        //
        // POST: /EntidadeSocial/Edit/5

        [HttpPost]
        public ActionResult Edit(EntidadeSocial entidadesocial)
        {
            if (ModelState.IsValid)
            {
                db.Entry(entidadesocial).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(entidadesocial);
        }

        //
        // GET: /EntidadeSocial/Delete/5
 
        public ActionResult Delete(int id)
        {
            EntidadeSocial entidadesocial = db.EntidadeSocials.Find(id);
            return View(entidadesocial);
        }

        //
        // POST: /EntidadeSocial/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            EntidadeSocial entidadesocial = db.EntidadeSocials.Find(id);
            db.EntidadeSocials.Remove(entidadesocial);
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