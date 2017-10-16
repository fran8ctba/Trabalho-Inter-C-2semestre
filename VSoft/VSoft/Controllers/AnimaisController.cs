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
    public class AnimaisController : Controller
    {
        private VSoftContexto db = new VSoftContexto();

        // GET: Animais
        public ActionResult Index()
        {
            var animais = db.Animais.Include(a => a.Dono).Include(a => a.HistoricoClinico).Include(a => a.Porte).Include(a => a.Raca).Include(a => a.Sexo);
            return View(animais.ToList());
        }

        // GET: Animais/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Animal animal = db.Animais.Find(id);
            if (animal == null)
            {
                return HttpNotFound();
            }
            return View(animal);
        }

        // GET: Animais/Create
        public ActionResult Create()
        {
            ViewBag.DonoId = new SelectList(db.Donos, "Id", "Email");
            ViewBag.HistoricoClinicoId = new SelectList(db.HistoricosClinicos, "Id", "Descricao");
            ViewBag.PorteId = new SelectList(db.Portes, "Id", "Descricao");
            ViewBag.RacaId = new SelectList(db.Racas, "Id", "Descricao");
            ViewBag.SexoId = new SelectList(db.Sexos, "Id", "Descricao");
            return View();
        }

        // POST: Animais/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Idade,Anilha,ConsumoRacao,Pelagem,Pedigree,DonoId,HistoricoClinicoId,SexoId,RacaId,PorteId")] Animal animal)
        {
            if (ModelState.IsValid)
            {
                db.Animais.Add(animal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DonoId = new SelectList(db.Donos, "Id", "Email", animal.DonoId);
            ViewBag.HistoricoClinicoId = new SelectList(db.HistoricosClinicos, "Id", "Descricao", animal.HistoricoClinicoId);
            ViewBag.PorteId = new SelectList(db.Portes, "Id", "Descricao", animal.PorteId);
            ViewBag.RacaId = new SelectList(db.Racas, "Id", "Descricao", animal.RacaId);
            ViewBag.SexoId = new SelectList(db.Sexos, "Id", "Descricao", animal.SexoId);
            return View(animal);
        }

        // GET: Animais/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Animal animal = db.Animais.Find(id);
            if (animal == null)
            {
                return HttpNotFound();
            }
            ViewBag.DonoId = new SelectList(db.Donos, "Id", "Email", animal.DonoId);
            ViewBag.HistoricoClinicoId = new SelectList(db.HistoricosClinicos, "Id", "Descricao", animal.HistoricoClinicoId);
            ViewBag.PorteId = new SelectList(db.Portes, "Id", "Descricao", animal.PorteId);
            ViewBag.RacaId = new SelectList(db.Racas, "Id", "Descricao", animal.RacaId);
            ViewBag.SexoId = new SelectList(db.Sexos, "Id", "Descricao", animal.SexoId);
            return View(animal);
        }

        // POST: Animais/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Idade,Anilha,ConsumoRacao,Pelagem,Pedigree,DonoId,HistoricoClinicoId,SexoId,RacaId,PorteId")] Animal animal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(animal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DonoId = new SelectList(db.Donos, "Id", "Email", animal.DonoId);
            ViewBag.HistoricoClinicoId = new SelectList(db.HistoricosClinicos, "Id", "Descricao", animal.HistoricoClinicoId);
            ViewBag.PorteId = new SelectList(db.Portes, "Id", "Descricao", animal.PorteId);
            ViewBag.RacaId = new SelectList(db.Racas, "Id", "Descricao", animal.RacaId);
            ViewBag.SexoId = new SelectList(db.Sexos, "Id", "Descricao", animal.SexoId);
            return View(animal);
        }

        // GET: Animais/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Animal animal = db.Animais.Find(id);
            if (animal == null)
            {
                return HttpNotFound();
            }
            return View(animal);
        }

        // POST: Animais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Animal animal = db.Animais.Find(id);
            db.Animais.Remove(animal);
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
