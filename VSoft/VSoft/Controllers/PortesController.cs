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
    public class PortesController : Controller
    {
        private VSoftContexto db = new VSoftContexto();

        // GET: Portes
        public ActionResult Index()
        {
            return View(db.Portes.ToList());
        }

        // GET: Portes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Porte porte = db.Portes.Find(id);
            if (porte == null)
            {
                return HttpNotFound();
            }
            return View(porte);
        }

        // GET: Portes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Portes/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Descricao")] Porte porte)
        {
            if (ModelState.IsValid)
            {
                db.Portes.Add(porte);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(porte);
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
