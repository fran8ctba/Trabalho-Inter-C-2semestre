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
    public class TipoExamesController : Controller
    {
        private VSoftContexto db = new VSoftContexto();

        // GET: TipoExames
        public ActionResult Index()
        {
            return View(db.TiposExames.ToList());
        }

        // GET: TipoExames/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoExame tipoExame = db.TiposExames.Find(id);
            if (tipoExame == null)
            {
                return HttpNotFound();
            }
            return View(tipoExame);
        }

        // GET: TipoExames/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoExames/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Descricao")] TipoExame tipoExame)
        {
            if (ModelState.IsValid)
            {
                db.TiposExames.Add(tipoExame);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoExame);
        }

        // GET: TipoExames/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoExame tipoExame = db.TiposExames.Find(id);
            if (tipoExame == null)
            {
                return HttpNotFound();
            }
            return View(tipoExame);
        }

        // POST: TipoExames/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Descricao")] TipoExame tipoExame)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoExame).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoExame);
        }

        // GET: TipoExames/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoExame tipoExame = db.TiposExames.Find(id);
            if (tipoExame == null)
            {
                return HttpNotFound();
            }
            return View(tipoExame);
        }

        // POST: TipoExames/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoExame tipoExame = db.TiposExames.Find(id);
            db.TiposExames.Remove(tipoExame);
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
