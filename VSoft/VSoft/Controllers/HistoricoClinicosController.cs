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
    public class HistoricoClinicosController : Controller
    {
        private VSoftContexto db = new VSoftContexto();

        // GET: HistoricoClinicos
        public ActionResult Index()
        {
            return View(db.HistoricosClinicos.ToList());
        }

        // GET: HistoricoClinicos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HistoricoClinico historicoClinico = db.HistoricosClinicos.Find(id);
            if (historicoClinico == null)
            {
                return HttpNotFound();
            }
            return View(historicoClinico);
        }

        // GET: HistoricoClinicos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HistoricoClinicos/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Descricao,Peso")] HistoricoClinico historicoClinico)
        {
            if (ModelState.IsValid)
            {
                db.HistoricosClinicos.Add(historicoClinico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(historicoClinico);
        }

        // GET: HistoricoClinicos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HistoricoClinico historicoClinico = db.HistoricosClinicos.Find(id);
            if (historicoClinico == null)
            {
                return HttpNotFound();
            }
            return View(historicoClinico);
        }

        // POST: HistoricoClinicos/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Descricao,Peso")] HistoricoClinico historicoClinico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(historicoClinico).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(historicoClinico);
        }

        // GET: HistoricoClinicos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HistoricoClinico historicoClinico = db.HistoricosClinicos.Find(id);
            if (historicoClinico == null)
            {
                return HttpNotFound();
            }
            return View(historicoClinico);
        }

        // POST: HistoricoClinicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HistoricoClinico historicoClinico = db.HistoricosClinicos.Find(id);
            db.HistoricosClinicos.Remove(historicoClinico);
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
