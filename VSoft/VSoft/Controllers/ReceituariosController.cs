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
    public class ReceituariosController : Controller
    {
        private VSoftContexto db = new VSoftContexto();

        // GET: Receituarios
        public ActionResult Index()
        {
            return View(db.Receituarios.ToList());
        }

        // GET: Receituarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Receituario receituario = db.Receituarios.Find(id);
            if (receituario == null)
            {
                return HttpNotFound();
            }
            return View(receituario);
        }

        // GET: Receituarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Receituarios/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Data,UNMedida,Peso,ReceitaTexto,IdHistoricoClinico,IdHistoricoMedicamento")] Receituario receituario)
        {
            if (ModelState.IsValid)
            {
                db.Receituarios.Add(receituario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(receituario);
        }

        // GET: Receituarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Receituario receituario = db.Receituarios.Find(id);
            if (receituario == null)
            {
                return HttpNotFound();
            }
            return View(receituario);
        }

        // POST: Receituarios/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Data,UNMedida,Peso,ReceitaTexto,IdHistoricoClinico,IdHistoricoMedicamento")] Receituario receituario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(receituario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(receituario);
        }

        // GET: Receituarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Receituario receituario = db.Receituarios.Find(id);
            if (receituario == null)
            {
                return HttpNotFound();
            }
            return View(receituario);
        }

        // POST: Receituarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Receituario receituario = db.Receituarios.Find(id);
            db.Receituarios.Remove(receituario);
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
