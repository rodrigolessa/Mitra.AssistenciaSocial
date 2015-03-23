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
    public class AssistenciaPorMesController : Controller
    {
        private MitraContext db = new MitraContext();

        //
        // GET: /AssistenciaPorMes/

        public ActionResult Index()
        {
            var assistenciapormes = db.AssistenciaPorMes.Include(a => a.Beneficiario).Include(a => a.EntidadeSocial).Include(a => a.TipoDeAssistencia);
            return View(assistenciapormes.ToList());
        }

        //
        // GET: /AssistenciaPorMes/Details/5

        public ActionResult Details(int id = 0)
        {
            AssistenciaPorMe assistenciaporme = db.AssistenciaPorMes.Find(id);
            if (assistenciaporme == null)
            {
                return HttpNotFound();
            }
            return View(assistenciaporme);
        }

        //
        // GET: /AssistenciaPorMes/Create

        public ActionResult Create()
        {
            ViewBag.id_beneficiario = new SelectList(db.Beneficiarios, "Id", "Nome");
            ViewBag.id_entidade_social = new SelectList(db.EntidadeSocials, "Id", "Nome");
            ViewBag.id_tipo_assistencia = new SelectList(db.TipoDeAssistencias, "Id", "Descricao");
            return View();
        }

        //
        // POST: /AssistenciaPorMes/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AssistenciaPorMe assistenciaporme)
        {
            if (ModelState.IsValid)
            {
                db.AssistenciaPorMes.Add(assistenciaporme);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_beneficiario = new SelectList(db.Beneficiarios, "Id", "Nome", assistenciaporme.id_beneficiario);
            ViewBag.id_entidade_social = new SelectList(db.EntidadeSocials, "Id", "Nome", assistenciaporme.id_entidade_social);
            ViewBag.id_tipo_assistencia = new SelectList(db.TipoDeAssistencias, "Id", "Descricao", assistenciaporme.id_tipo_assistencia);
            return View(assistenciaporme);
        }

        //
        // GET: /AssistenciaPorMes/Edit/5

        public ActionResult Edit(int id = 0)
        {
            AssistenciaPorMe assistenciaporme = db.AssistenciaPorMes.Find(id);
            if (assistenciaporme == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_beneficiario = new SelectList(db.Beneficiarios, "Id", "Nome", assistenciaporme.id_beneficiario);
            ViewBag.id_entidade_social = new SelectList(db.EntidadeSocials, "Id", "Nome", assistenciaporme.id_entidade_social);
            ViewBag.id_tipo_assistencia = new SelectList(db.TipoDeAssistencias, "Id", "Descricao", assistenciaporme.id_tipo_assistencia);
            return View(assistenciaporme);
        }

        //
        // POST: /AssistenciaPorMes/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AssistenciaPorMe assistenciaporme)
        {
            if (ModelState.IsValid)
            {
                db.Entry(assistenciaporme).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_beneficiario = new SelectList(db.Beneficiarios, "Id", "Nome", assistenciaporme.id_beneficiario);
            ViewBag.id_entidade_social = new SelectList(db.EntidadeSocials, "Id", "Nome", assistenciaporme.id_entidade_social);
            ViewBag.id_tipo_assistencia = new SelectList(db.TipoDeAssistencias, "Id", "Descricao", assistenciaporme.id_tipo_assistencia);
            return View(assistenciaporme);
        }

        //
        // GET: /AssistenciaPorMes/Delete/5

        public ActionResult Delete(int id = 0)
        {
            AssistenciaPorMe assistenciaporme = db.AssistenciaPorMes.Find(id);
            if (assistenciaporme == null)
            {
                return HttpNotFound();
            }
            return View(assistenciaporme);
        }

        //
        // POST: /AssistenciaPorMes/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AssistenciaPorMe assistenciaporme = db.AssistenciaPorMes.Find(id);
            db.AssistenciaPorMes.Remove(assistenciaporme);
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