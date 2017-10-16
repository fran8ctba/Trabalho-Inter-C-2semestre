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
    public class Diagnostico_HistoricoController : Controller
    {
        private VSoftContexto db = new VSoftContexto();

        // GET: Diagnostico_Historico
        public ActionResult Index()
        {
            return View(db.Diagnosticos_Historico.ToList());
        }

        // GET: Diagnostico_Historico/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diagnostico_Historico diagnostico_Historico = db.Diagnosticos_Historico.Find(id);
            if (diagnostico_Historico == null)
            {
                return HttpNotFound();
            }
            return View(diagnostico_Historico);
        }

        // GET: Diagnostico_Historico/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Diagnostico_Historico/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdHistoricoClinico,IdDiagnostico")] Diagnostico_Historico diagnostico_Historico)
        {
            if (ModelState.IsValid)
            {
                db.Diagnosticos_Historico.Add(diagnostico_Historico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(diagnostico_Historico);
        }

        // GET: Diagnostico_Historico/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diagnostico_Historico diagnostico_Historico = db.Diagnosticos_Historico.Find(id);
            if (diagnostico_Historico == null)
            {
                return HttpNotFound();
            }
            return View(diagnostico_Historico);
        }

        // POST: Diagnostico_Historico/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdHistoricoClinico,IdDiagnostico")] Diagnostico_Historico diagnostico_Historico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(diagnostico_Historico).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(diagnostico_Historico);
        }

        // GET: Diagnostico_Historico/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diagnostico_Historico diagnostico_Historico = db.Diagnosticos_Historico.Find(id);
            if (diagnostico_Historico == null)
            {
                return HttpNotFound();
            }
            return View(diagnostico_Historico);
        }

        // POST: Diagnostico_Historico/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Diagnostico_Historico diagnostico_Historico = db.Diagnosticos_Historico.Find(id);
            db.Diagnosticos_Historico.Remove(diagnostico_Historico);
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
