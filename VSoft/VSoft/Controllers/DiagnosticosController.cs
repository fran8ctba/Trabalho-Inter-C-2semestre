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
    public class DiagnosticosController : Controller
    {
        private VSoftContexto db = new VSoftContexto();

        // GET: Diagnosticos
        public ActionResult Index()
        {
            return View(db.Diagnosticos.ToList());
        }

        // GET: Diagnosticos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diagnostico diagnostico = db.Diagnosticos.Find(id);
            if (diagnostico == null)
            {
                return HttpNotFound();
            }
            return View(diagnostico);
        }

        // GET: Diagnosticos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Diagnosticos/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,UnMedida,Peso,DiagTexto")] Diagnostico diagnostico)
        {
            if (ModelState.IsValid)
            {
                db.Diagnosticos.Add(diagnostico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(diagnostico);
        }

        // GET: Diagnosticos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diagnostico diagnostico = db.Diagnosticos.Find(id);
            if (diagnostico == null)
            {
                return HttpNotFound();
            }
            return View(diagnostico);
        }

        // POST: Diagnosticos/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,UnMedida,Peso,DiagTexto")] Diagnostico diagnostico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(diagnostico).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(diagnostico);
        }

        // GET: Diagnosticos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diagnostico diagnostico = db.Diagnosticos.Find(id);
            if (diagnostico == null)
            {
                return HttpNotFound();
            }
            return View(diagnostico);
        }

        // POST: Diagnosticos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Diagnostico diagnostico = db.Diagnosticos.Find(id);
            db.Diagnosticos.Remove(diagnostico);
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
