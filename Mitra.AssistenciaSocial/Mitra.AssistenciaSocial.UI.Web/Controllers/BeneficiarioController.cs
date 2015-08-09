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
            return View(db.Beneficiarios.ToList());
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
            //ViewBag.id_entidade_social = new SelectList(db.EntidadeSocials, "Id", "Nome");
            //ViewBag.id_tipo_assistencia = new SelectList(db.TipoDeAssistencias, "Id", "Descricao");
            //ViewBag.BeneficioDeEntidade = BitListItem.Obter();
            //ViewBag.PossuiOutrosImoveis = BitListItem.Obter();
            //ViewBag.PossuiVeiculo = BitListItem.Obter();
            //ViewBag.PossuiConvenioMedico = BitListItem.Obter();

            ViewBag.EstadoCivil = EstadoCivilListItem.Obter();
            ViewBag.GrauDeInstrucao = GrauDeInstrucaoListItem.Obter();
            ViewBag.Cor = CorListItem.Obter();
            ViewBag.Sexo = GeneroListItem.Obter();
            ViewBag.Estado = EstadoListItem.Obter();
            ViewBag.TipoDeResidencia = TipoDeResidenciaListItem.Obter();
            ViewBag.TipoDeConstrucao = TipoDeConstrucaoListItem.Obter();
            ViewBag.PisoDaConstrucao = PisoDaConstrucaoListItem.Obter();
            ViewBag.CoberturaDaConstrucao = CoberturaDaConstrucaoListItem.Obter();
            ViewBag.EsgotoDaConstrucao = EsgotoDaConstrucaoListItem.Obter();
            ViewBag.AguaDaConstrucao = AguaDaConstrucaoListItem.Obter();
            ViewBag.BanheiroDaConstrucao = BanheiroDaConstrucaoListItem.Obter();
            ViewBag.EnergiaEletricaDaConstrucao = EnergiaEletricaDaConstrucaoListItem.Obter();
            ViewBag.LixoDaConstrucao = LixoDaConstrucaoListItem.Obter();
            ViewBag.TipoDeConstrucaoOutrosImoveis = TipoDeConstrucaoOutrosImoveisListItem.Obter();
            ViewBag.UtilizacaoDoVeiculo = UtilizacaoDoVeiculoListItem.Obter();
            ViewBag.ComoAdquireMedicamentos = ComoAdquireMedicamentosListItem.Obter();
            ViewBag.RendaFamiliar = RendaFamiliarListItem.Obter();

            var beneficiario = new Beneficiario();

            return View(beneficiario);
        }

        //
        // POST: /Beneficiario/Create

        [HttpPost]
        public ActionResult Create(Beneficiario beneficiario)
        {
            if (ModelState.IsValid)
            {
                db.Beneficiarios.Add(beneficiario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            //ViewBag.id_entidade_social = new SelectList(db.EntidadeSocials, "Id", "Nome", beneficiario.id_entidade_social);
            //ViewBag.id_tipo_assistencia = new SelectList(db.TipoDeAssistencias, "Id", "Descricao", beneficiario.id_tipo_assistencia);
            //ViewBag.BeneficioDeEntidade = BitListItem.Obter();
            //ViewBag.PossuiOutrosImoveis = BitListItem.Obter();
            //ViewBag.PossuiVeiculo = BitListItem.Obter();
            //ViewBag.PossuiConvenioMedico = BitListItem.Obter();

            ViewBag.EstadoCivil = EstadoCivilListItem.Obter();
            ViewBag.GrauDeInstrucao = GrauDeInstrucaoListItem.Obter();
            ViewBag.Cor = CorListItem.Obter();
            ViewBag.Sexo = GeneroListItem.Obter();
            ViewBag.Estado = EstadoListItem.Obter();
            ViewBag.TipoDeResidencia = TipoDeResidenciaListItem.Obter();
            ViewBag.TipoDeConstrucao = TipoDeConstrucaoListItem.Obter();
            ViewBag.PisoDaConstrucao = PisoDaConstrucaoListItem.Obter();
            ViewBag.CoberturaDaConstrucao = CoberturaDaConstrucaoListItem.Obter();
            ViewBag.EsgotoDaConstrucao = EsgotoDaConstrucaoListItem.Obter();
            ViewBag.AguaDaConstrucao = AguaDaConstrucaoListItem.Obter();
            ViewBag.BanheiroDaConstrucao = BanheiroDaConstrucaoListItem.Obter();
            ViewBag.EnergiaEletricaDaConstrucao = EnergiaEletricaDaConstrucaoListItem.Obter();
            ViewBag.LixoDaConstrucao = LixoDaConstrucaoListItem.Obter();
            ViewBag.TipoDeConstrucaoOutrosImoveis = TipoDeConstrucaoOutrosImoveisListItem.Obter();
            ViewBag.UtilizacaoDoVeiculo = UtilizacaoDoVeiculoListItem.Obter();
            ViewBag.ComoAdquireMedicamentos = ComoAdquireMedicamentosListItem.Obter();
            ViewBag.RendaFamiliar = RendaFamiliarListItem.Obter();

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
            //ViewBag.id_entidade_social = new SelectList(db.EntidadeSocials, "Id", "Nome", beneficiario.id_entidade_social);
            //ViewBag.id_tipo_assistencia = new SelectList(db.TipoDeAssistencias, "Id", "Descricao", beneficiario.id_tipo_assistencia);

            ViewBag.EstadoCivil = EstadoCivilListItem.Obter();
            ViewBag.GrauDeInstrucao = GrauDeInstrucaoListItem.Obter();
            ViewBag.Cor = CorListItem.Obter();
            ViewBag.Sexo = GeneroListItem.Obter();
            ViewBag.Estado = EstadoListItem.Obter();
            ViewBag.TipoDeResidencia = TipoDeResidenciaListItem.Obter();
            ViewBag.TipoDeConstrucao = TipoDeConstrucaoListItem.Obter();
            ViewBag.PisoDaConstrucao = PisoDaConstrucaoListItem.Obter();
            ViewBag.CoberturaDaConstrucao = CoberturaDaConstrucaoListItem.Obter();
            ViewBag.EsgotoDaConstrucao = EsgotoDaConstrucaoListItem.Obter();
            ViewBag.AguaDaConstrucao = AguaDaConstrucaoListItem.Obter();
            ViewBag.BanheiroDaConstrucao = BanheiroDaConstrucaoListItem.Obter();
            ViewBag.EnergiaEletricaDaConstrucao = EnergiaEletricaDaConstrucaoListItem.Obter();
            ViewBag.LixoDaConstrucao = LixoDaConstrucaoListItem.Obter();
            ViewBag.TipoDeConstrucaoOutrosImoveis = TipoDeConstrucaoOutrosImoveisListItem.Obter();
            ViewBag.UtilizacaoDoVeiculo = UtilizacaoDoVeiculoListItem.Obter();
            ViewBag.ComoAdquireMedicamentos = ComoAdquireMedicamentosListItem.Obter();
            ViewBag.RendaFamiliar = RendaFamiliarListItem.Obter();

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
            //ViewBag.id_entidade_social = new SelectList(db.EntidadeSocials, "Id", "Nome", beneficiario.id_entidade_social);
            //ViewBag.id_tipo_assistencia = new SelectList(db.TipoDeAssistencias, "Id", "Descricao", beneficiario.id_tipo_assistencia);

            ViewBag.EstadoCivil = EstadoCivilListItem.Obter();
            ViewBag.GrauDeInstrucao = GrauDeInstrucaoListItem.Obter();
            ViewBag.Cor = CorListItem.Obter();
            ViewBag.Sexo = GeneroListItem.Obter();
            ViewBag.Estado = EstadoListItem.Obter();
            ViewBag.TipoDeResidencia = TipoDeResidenciaListItem.Obter();
            ViewBag.TipoDeConstrucao = TipoDeConstrucaoListItem.Obter();
            ViewBag.PisoDaConstrucao = PisoDaConstrucaoListItem.Obter();
            ViewBag.CoberturaDaConstrucao = CoberturaDaConstrucaoListItem.Obter();
            ViewBag.EsgotoDaConstrucao = EsgotoDaConstrucaoListItem.Obter();
            ViewBag.AguaDaConstrucao = AguaDaConstrucaoListItem.Obter();
            ViewBag.BanheiroDaConstrucao = BanheiroDaConstrucaoListItem.Obter();
            ViewBag.EnergiaEletricaDaConstrucao = EnergiaEletricaDaConstrucaoListItem.Obter();
            ViewBag.LixoDaConstrucao = LixoDaConstrucaoListItem.Obter();
            ViewBag.TipoDeConstrucaoOutrosImoveis = TipoDeConstrucaoOutrosImoveisListItem.Obter();
            ViewBag.UtilizacaoDoVeiculo = UtilizacaoDoVeiculoListItem.Obter();
            ViewBag.ComoAdquireMedicamentos = ComoAdquireMedicamentosListItem.Obter();
            ViewBag.RendaFamiliar = RendaFamiliarListItem.Obter();

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