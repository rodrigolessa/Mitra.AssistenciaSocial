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
    public class BeneficiarioController : Controller
    {
        private MitraContext db = new MitraContext();

        //
        // GET: /Beneficiario/

        public ActionResult Index()
        {
            var beneficiarios = db.Beneficiarios.Include(b => b.EntidadeSocial).Include(b => b.TipoDeAssistencia);
            return View(beneficiarios.ToList());
        }

        //
        // GET: /Beneficiario/Details/5

        public ActionResult Details(int id = 0)
        {
            Beneficiario beneficiario = db.Beneficiarios.Find(id);
            if (beneficiario == null)
            {
                return HttpNotFound();
            }
            return View(beneficiario);
        }

        //
        // GET: /Beneficiario/Create

        public ActionResult Create()
        {
            ViewBag.id_entidade_social = new SelectList(db.EntidadeSocials, "Id", "Nome");
            ViewBag.id_tipo_assistencia = new SelectList(db.TipoDeAssistencias, "Id", "Descricao");

            ViewBag.EstadoCivil = EstadoCivilListItem.Obter();
            ViewBag.GrauDeInstrucao = GrauDeInstrucaoListItem.Obter();
            ViewBag.Cor = new List<SelectListItem>();
            ViewBag.Sexo = GeneroListItem.Obter();
            ViewBag.Estado = new List<SelectListItem>();
            ViewBag.TipoDeResidencia = new List<SelectListItem>();
            ViewBag.TipoDeConstrucao = new List<SelectListItem>();
            ViewBag.PisoDaConstrucao = new List<SelectListItem>();
            ViewBag.CoberturaDaConstrucao = new List<SelectListItem>();
            ViewBag.EsgotoDaConstrucao = new List<SelectListItem>();
            ViewBag.AguaDaConstrucao = new List<SelectListItem>();
            ViewBag.BanheiroDaConstrucao = new List<SelectListItem>();
            ViewBag.EnergiaEletricaDaConstrucao = new List<SelectListItem>();
            ViewBag.LixoDaConstrucao = new List<SelectListItem>();
            ViewBag.TipoDeConstrucaoOutrosImoveis = new List<SelectListItem>();
            ViewBag.UtilizacaoDoVeiculo = new List<SelectListItem>();
            ViewBag.ComoAdquireMedicamentos = new List<SelectListItem>();

            var beneficiario = new Beneficiario();

            return View(beneficiario);
        }

        //
        // POST: /Beneficiario/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Beneficiario beneficiario)
        {
            if (ModelState.IsValid)
            {
                db.Beneficiarios.Add(beneficiario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_entidade_social = new SelectList(db.EntidadeSocials, "Id", "Nome", beneficiario.id_entidade_social);
            ViewBag.id_tipo_assistencia = new SelectList(db.TipoDeAssistencias, "Id", "Descricao", beneficiario.id_tipo_assistencia);

            ViewBag.EstadoCivil = EstadoCivilListItem.Obter();
            ViewBag.GrauDeInstrucao = GrauDeInstrucaoListItem.Obter();
            ViewBag.Cor = new List<SelectListItem>();
            ViewBag.Sexo = GeneroListItem.Obter();
            ViewBag.Estado = new List<SelectListItem>();
            ViewBag.TipoDeResidencia = new List<SelectListItem>();
            ViewBag.TipoDeConstrucao = new List<SelectListItem>();
            ViewBag.PisoDaConstrucao = new List<SelectListItem>();
            ViewBag.CoberturaDaConstrucao = new List<SelectListItem>();
            ViewBag.EsgotoDaConstrucao = new List<SelectListItem>();
            ViewBag.AguaDaConstrucao = new List<SelectListItem>();
            ViewBag.BanheiroDaConstrucao = new List<SelectListItem>();
            ViewBag.EnergiaEletricaDaConstrucao = new List<SelectListItem>();
            ViewBag.LixoDaConstrucao = new List<SelectListItem>();
            ViewBag.TipoDeConstrucaoOutrosImoveis = new List<SelectListItem>();
            ViewBag.UtilizacaoDoVeiculo = new List<SelectListItem>();
            ViewBag.ComoAdquireMedicamentos = new List<SelectListItem>();

            return View(beneficiario);
        }

        //
        // GET: /Beneficiario/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Beneficiario beneficiario = db.Beneficiarios.Find(id);
            if (beneficiario == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_entidade_social = new SelectList(db.EntidadeSocials, "Id", "Nome", beneficiario.id_entidade_social);
            ViewBag.id_tipo_assistencia = new SelectList(db.TipoDeAssistencias, "Id", "Descricao", beneficiario.id_tipo_assistencia);

            ViewBag.EstadoCivil = EstadoCivilListItem.Obter();
            ViewBag.GrauDeInstrucao = GrauDeInstrucaoListItem.Obter();
            ViewBag.Cor = new List<SelectListItem>();
            ViewBag.Sexo = GeneroListItem.Obter();
            ViewBag.Estado = new List<SelectListItem>();
            ViewBag.TipoDeResidencia = new List<SelectListItem>();
            ViewBag.TipoDeConstrucao = new List<SelectListItem>();
            ViewBag.PisoDaConstrucao = new List<SelectListItem>();
            ViewBag.CoberturaDaConstrucao = new List<SelectListItem>();
            ViewBag.EsgotoDaConstrucao = new List<SelectListItem>();
            ViewBag.AguaDaConstrucao = new List<SelectListItem>();
            ViewBag.BanheiroDaConstrucao = new List<SelectListItem>();
            ViewBag.EnergiaEletricaDaConstrucao = new List<SelectListItem>();
            ViewBag.LixoDaConstrucao = new List<SelectListItem>();
            ViewBag.TipoDeConstrucaoOutrosImoveis = new List<SelectListItem>();
            ViewBag.UtilizacaoDoVeiculo = new List<SelectListItem>();
            ViewBag.ComoAdquireMedicamentos = new List<SelectListItem>();

            return View(beneficiario);
        }

        //
        // POST: /Beneficiario/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
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

            ViewBag.EstadoCivil = EstadoCivilListItem.Obter();
            ViewBag.GrauDeInstrucao = GrauDeInstrucaoListItem.Obter();
            ViewBag.Cor = new List<SelectListItem>();
            ViewBag.Sexo = GeneroListItem.Obter();
            ViewBag.Estado = new List<SelectListItem>();
            ViewBag.TipoDeResidencia = new List<SelectListItem>();
            ViewBag.TipoDeConstrucao = new List<SelectListItem>();
            ViewBag.PisoDaConstrucao = new List<SelectListItem>();
            ViewBag.CoberturaDaConstrucao = new List<SelectListItem>();
            ViewBag.EsgotoDaConstrucao = new List<SelectListItem>();
            ViewBag.AguaDaConstrucao = new List<SelectListItem>();
            ViewBag.BanheiroDaConstrucao = new List<SelectListItem>();
            ViewBag.EnergiaEletricaDaConstrucao = new List<SelectListItem>();
            ViewBag.LixoDaConstrucao = new List<SelectListItem>();
            ViewBag.TipoDeConstrucaoOutrosImoveis = new List<SelectListItem>();
            ViewBag.UtilizacaoDoVeiculo = new List<SelectListItem>();
            ViewBag.ComoAdquireMedicamentos = new List<SelectListItem>();

            return View(beneficiario);
        }

        //
        // GET: /Beneficiario/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Beneficiario beneficiario = db.Beneficiarios.Find(id);
            if (beneficiario == null)
            {
                return HttpNotFound();
            }
            return View(beneficiario);
        }

        //
        // POST: /Beneficiario/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
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