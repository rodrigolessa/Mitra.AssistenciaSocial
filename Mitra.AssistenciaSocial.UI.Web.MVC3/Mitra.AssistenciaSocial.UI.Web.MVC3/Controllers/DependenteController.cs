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
    public class DependenteController : Controller
    {
        private MitraContext db = new MitraContext();

        //
        // GET: /Dependente/

        public ViewResult Index()
        {
            var beneficiarios = db.Beneficiarios.Include(b => b.EntidadeSocial).Include(b => b.TipoDeAssistencia);
            return View(beneficiarios.ToList());
        }

        //
        // GET: /Dependente/Details/5

        public ViewResult Details(int id)
        {
            Beneficiario beneficiario = db.Beneficiarios.Find(id);
            return View(beneficiario);
        }

        //
        // GET: /Dependente/Create

        public ActionResult Create()
        {
            ViewBag.id_entidade_social = new SelectList(db.EntidadeSocials, "Id", "Nome");
            ViewBag.id_tipo_assistencia = new SelectList(db.TipoDeAssistencias, "Id", "Descricao");
            return View();
        } 

        //
        // POST: /Dependente/Create

        [HttpPost]
        public ActionResult Create(Beneficiario beneficiario)
        {
            if (ModelState.IsValid)
            {
                beneficiario.DataDeCadastro = DateTime.Now;
                db.Beneficiarios.Add(beneficiario);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.id_entidade_social = new SelectList(db.EntidadeSocials, "Id", "Nome", beneficiario.id_entidade_social);
            ViewBag.id_tipo_assistencia = new SelectList(db.TipoDeAssistencias, "Id", "Descricao", beneficiario.id_tipo_assistencia);
            return View(beneficiario);
        }
        
        //
        // GET: /Dependente/Edit/5
 
        public ActionResult Edit(int id)
        {
            Beneficiario beneficiario = db.Beneficiarios.Find(id);
            ViewBag.id_entidade_social = new SelectList(db.EntidadeSocials, "Id", "Nome", beneficiario.id_entidade_social);
            ViewBag.id_tipo_assistencia = new SelectList(db.TipoDeAssistencias, "Id", "Descricao", beneficiario.id_tipo_assistencia);
            return View(beneficiario);
        }

        //
        // POST: /Dependente/Edit/5

        [HttpPost]
        public ActionResult Edit(Beneficiario beneficiario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(beneficiario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_entidade_social = new SelectList(db.EntidadeSocials, "Id", "Nome", beneficiario.id_entidade_social);
            ViewBag.id_tipo_assistencia = new SelectList(db.TipoDeAssistencias, "Id", "Descricao", beneficiario.id_tipo_assistencia);
            return View(beneficiario);
        }

        //
        // GET: /Dependente/Delete/5
 
        public ActionResult Delete(int id)
        {
            Beneficiario beneficiario = db.Beneficiarios.Find(id);
            return View(beneficiario);
        }

        //
        // POST: /Dependente/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Beneficiario beneficiario = db.Beneficiarios.Find(id);
            db.Beneficiarios.Remove(beneficiario);
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