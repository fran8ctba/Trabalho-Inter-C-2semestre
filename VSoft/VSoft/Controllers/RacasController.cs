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
    public class RacasController : Controller
    {
        private VSoftContexto db = new VSoftContexto();

        // GET: Racas
        public ActionResult Index()
        {
            var racas = db.Racas.Include(r => r.Especie);
            return View(racas.ToList());
        }

        // GET: Racas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Raca raca = db.Racas.Find(id);
            if (raca == null)
            {
                return HttpNotFound();
            }
            return View(raca);
        }

        // GET: Racas/Create
        public ActionResult Create()
        {
            ViewBag.EspecieId = new SelectList(db.Especies, "Id", "Descricao");
            return View();
        }

        // POST: Racas/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Descricao,EspecieId")] Raca raca)
        {
            if (ModelState.IsValid)
            {
                db.Racas.Add(raca);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EspecieId = new SelectList(db.Especies, "Id", "Descricao", raca.EspecieId);
            return View(raca);
        }

        // GET: Racas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Raca raca = db.Racas.Find(id);
            if (raca == null)
            {
                return HttpNotFound();
            }
            ViewBag.EspecieId = new SelectList(db.Especies, "Id", "Descricao", raca.EspecieId);
            return View(raca);
        }

        // POST: Racas/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Descricao,EspecieId")] Raca raca)
        {
            if (ModelState.IsValid)
            {
                db.Entry(raca).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EspecieId = new SelectList(db.Especies, "Id", "Descricao", raca.EspecieId);
            return View(raca);
        }

        // GET: Racas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Raca raca = db.Racas.Find(id);
            if (raca == null)
            {
                return HttpNotFound();
            }
            return View(raca);
        }

        // POST: Racas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Raca raca = db.Racas.Find(id);
            db.Racas.Remove(raca);
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
