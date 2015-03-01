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
    public class BeneficiarioController : Controller
    {
        private MitraContext db = new MitraContext();

        //
        // GET: /Beneficiario/

        public ViewResult Index()
        {
            var beneficiarios = db.Beneficiarios.Include(b => b.EntidadeSocial).Include(b => b.TipoDeAssistencia);
            return View(beneficiarios.ToList());
        }

        //
        // GET: /Beneficiario/Details/5

        public ViewResult Details(int id)
        {
            Beneficiario beneficiario = db.Beneficiarios.Find(id);
            return View(beneficiario);
        }

        //
        // GET: /Beneficiario/Create

        public ActionResult Create()
        {
            ViewBag.id_entidade_social = new SelectList(db.EntidadeSocials, "Id", "Nome");
            ViewBag.id_tipo_assistencia = new SelectList(db.TipoDeAssistencias, "Id", "Descricao");
            var generos = new List<SelectListItem>();
            var masculino = new SelectListItem();
            masculino.Value = "M";
            masculino.Text = "Masculino";
            var feminino = new SelectListItem();
            feminino.Value = "F";
            feminino.Text = "Feminino";
            generos.Add(masculino);
            generos.Add(feminino);
            ViewBag.Sexo = generos;
            return View();
        } 

        //
        // POST: /Beneficiario/Create

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
        // GET: /Beneficiario/Edit/5
 
        public ActionResult Edit(int id)
        {
            Beneficiario beneficiario = db.Beneficiarios.Find(id);
            ViewBag.id_entidade_social = new SelectList(db.EntidadeSocials, "Id", "Nome", beneficiario.id_entidade_social);
            ViewBag.id_tipo_assistencia = new SelectList(db.TipoDeAssistencias, "Id", "Descricao", beneficiario.id_tipo_assistencia);
            return View(beneficiario);
        }

        //
        // POST: /Beneficiario/Edit/5

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
        // GET: /Beneficiario/Delete/5
 
        public ActionResult Delete(int id)
        {
            Beneficiario beneficiario = db.Beneficiarios.Find(id);
            return View(beneficiario);
        }

        //
        // POST: /Beneficiario/Delete/5

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