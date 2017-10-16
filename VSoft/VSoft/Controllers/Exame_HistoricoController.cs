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
    public class Exame_HistoricoController : Controller
    {
        private VSoftContexto db = new VSoftContexto();

        // GET: Exame_Historico
        public ActionResult Index()
        {
            return View(db.Exames_Historico.ToList());
        }

        // GET: Exame_Historico/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exame_Historico exame_Historico = db.Exames_Historico.Find(id);
            if (exame_Historico == null)
            {
                return HttpNotFound();
            }
            return View(exame_Historico);
        }

        // GET: Exame_Historico/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Exame_Historico/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdExame,IdHitoricoClinico")] Exame_Historico exame_Historico)
        {
            if (ModelState.IsValid)
            {
                db.Exames_Historico.Add(exame_Historico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(exame_Historico);
        }

        // GET: Exame_Historico/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exame_Historico exame_Historico = db.Exames_Historico.Find(id);
            if (exame_Historico == null)
            {
                return HttpNotFound();
            }
            return View(exame_Historico);
        }

        // POST: Exame_Historico/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdExame,IdHitoricoClinico")] Exame_Historico exame_Historico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(exame_Historico).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(exame_Historico);
        }

        // GET: Exame_Historico/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exame_Historico exame_Historico = db.Exames_Historico.Find(id);
            if (exame_Historico == null)
            {
                return HttpNotFound();
            }
            return View(exame_Historico);
        }

        // POST: Exame_Historico/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Exame_Historico exame_Historico = db.Exames_Historico.Find(id);
            db.Exames_Historico.Remove(exame_Historico);
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
