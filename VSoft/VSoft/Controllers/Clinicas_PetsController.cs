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
    public class Clinicas_PetsController : Controller
    {
        private VSoftContexto db = new VSoftContexto();

        // GET: Clinicas_Pets
        public ActionResult Index()
        {
            return View(db.Clinicas_Pets.ToList());
        }

        // GET: Clinicas_Pets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clinica_Pet clinica_Pet = db.Clinicas_Pets.Find(id);
            if (clinica_Pet == null)
            {
                return HttpNotFound();
            }
            return View(clinica_Pet);
        }

        // GET: Clinicas_Pets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clinicas_Pets/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Endereco,Numero,CNPJ")] Clinica_Pet clinica_Pet)
        {
            if (ModelState.IsValid)
            {
                db.Clinicas_Pets.Add(clinica_Pet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clinica_Pet);
        }

        // GET: Clinicas_Pets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clinica_Pet clinica_Pet = db.Clinicas_Pets.Find(id);
            if (clinica_Pet == null)
            {
                return HttpNotFound();
            }
            return View(clinica_Pet);
        }

        // POST: Clinicas_Pets/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Endereco,Numero,CNPJ")] Clinica_Pet clinica_Pet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clinica_Pet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clinica_Pet);
        }

        // GET: Clinicas_Pets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clinica_Pet clinica_Pet = db.Clinicas_Pets.Find(id);
            if (clinica_Pet == null)
            {
                return HttpNotFound();
            }
            return View(clinica_Pet);
        }

        // POST: Clinicas_Pets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Clinica_Pet clinica_Pet = db.Clinicas_Pets.Find(id);
            db.Clinicas_Pets.Remove(clinica_Pet);
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
