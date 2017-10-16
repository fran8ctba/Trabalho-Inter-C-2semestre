using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VSoft.AcessoDados;
using VSoft.Models;

namespace VSoft.Controllers
{
    public class HistoricoMedicamentosController : Controller
    {
        private VSoftContexto db = new VSoftContexto();

        // GET: HistoricoMedicamentos
        public ActionResult Index()
        {
            return View(db.HistoricosMedicamentos.ToList());
        }

        // GET: HistoricoMedicamentos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HistoricoMedicamento historicoMedicamento = db.HistoricosMedicamentos.Find(id);
            if (historicoMedicamento == null)
            {
                return HttpNotFound();
            }
            return View(historicoMedicamento);
        }

        // GET: HistoricoMedicamentos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HistoricoMedicamentos/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,DtAplicacao,QtDiasProxima,Doses,Tipo,IdAnimal,IdProduto")] HistoricoMedicamento historicoMedicamento)
        {
            if (ModelState.IsValid)
            {
                db.HistoricosMedicamentos.Add(historicoMedicamento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(historicoMedicamento);
        }

        // GET: HistoricoMedicamentos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HistoricoMedicamento historicoMedicamento = db.HistoricosMedicamentos.Find(id);
            if (historicoMedicamento == null)
            {
                return HttpNotFound();
            }
            return View(historicoMedicamento);
        }

        // POST: HistoricoMedicamentos/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,DtAplicacao,QtDiasProxima,Doses,Tipo,IdAnimal,IdProduto")] HistoricoMedicamento historicoMedicamento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(historicoMedicamento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(historicoMedicamento);
        }

        // GET: HistoricoMedicamentos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HistoricoMedicamento historicoMedicamento = db.HistoricosMedicamentos.Find(id);
            if (historicoMedicamento == null)
            {
                return HttpNotFound();
            }
            return View(historicoMedicamento);
        }

        // POST: HistoricoMedicamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HistoricoMedicamento historicoMedicamento = db.HistoricosMedicamentos.Find(id);
            db.HistoricosMedicamentos.Remove(historicoMedicamento);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
