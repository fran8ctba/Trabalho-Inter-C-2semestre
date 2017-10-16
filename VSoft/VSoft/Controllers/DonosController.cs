using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Dynamic;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VSoft.AcessoDados;
using VSoft.Models;

namespace VSoft.Controllers
{
    public class DonosController : Controller
    {
        private VSoftContexto db = new VSoftContexto();

        // GET: Donos
        public ActionResult Index()
        {
            return View();
        }

         public JsonResult Listar(string searchPhrase, int current = 1, int rowCount = 5)
        {
            //sort[Nome] || sort[RG]  || sort[CPF] || sort[Telefone] || sort[Cidade]
            string chave = Request.Form.AllKeys.Where(k => k.StartsWith("sort")).First();

            string ordenacao = Request[chave];

            //trasformando "sort[" e "]" em espaco para pegar apenas o que o usuario quer ordenar  
            string compo = chave.Replace("sort[", String.Empty).Replace("]", String.Empty);

            var donos = db.Donos.Include(c => c.Cidade);

            int total = donos.Count();

            if (!String.IsNullOrWhiteSpace(searchPhrase))
            {
                //ele tentara converter search em inteiro se e for possivel ele coloca dentro de ano 
                long cpf = 0;
                long.TryParse(searchPhrase, out cpf);
                long rg = 0;
                long.TryParse(searchPhrase, out rg);
                long telefone = 0;
                long.TryParse(searchPhrase, out telefone);
                long celular = 0;
                long.TryParse(searchPhrase, out celular);

                donos = donos.Where("Nome.Contains(@0) OR RG == @1 OR CPF == @1 OR Celular == @1 OR Telefone == @1", searchPhrase, cpf, rg, telefone, celular);
            }


            //...aqui usando dynamic linq
            string compoOrdenacao = String.Format("{0} {1}", compo, ordenacao);

            var donosPaginados = donos.OrderBy(compoOrdenacao).Skip((current - 1) * rowCount).Take(rowCount);

            return Json(new
            {
                rows = donosPaginados.ToList(),
                current = current,
                rowCount = rowCount,
                total = total
            }
                , JsonRequestBehavior.AllowGet);
        }



        // GET: Donos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dono dono = db.Donos.Find(id);
            if (dono == null)
            {
                return HttpNotFound();
            }
            return View(dono);
        }

        // GET: Donos/Create
        public ActionResult Create()
        {
            ViewBag.IdCidade = new SelectList(db.Cidades, "Id", "Nome");
            return View();
        }

        // POST: Donos/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Email,Senha,Nome,DtNascimento,RG,CPF,Celular,Telefone,Endereco,Bairro,CEP,IdCidade")] Dono dono)
        {
            if (ModelState.IsValid)
            {
                db.Donos.Add(dono);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdCidade = new SelectList(db.Cidades, "Id", "NMCidade", dono.CidadeId);
            return View(dono);
        }

        // GET: Donos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dono dono = db.Donos.Find(id);
            if (dono == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdCidade = new SelectList(db.Cidades, "Id", "NMCidade", dono.CidadeId);
            return View(dono);
        }

        // POST: Donos/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Email,Senha,Nome,DtNascimento,RG,CPF,Celular,Telefone,Endereco,Bairro,CEP,IdCidade")] Dono dono)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dono).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdCidade = new SelectList(db.Cidades, "Id", "NMCidade", dono.CidadeId);
            return View(dono);
        }

        // GET: Donos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dono dono = db.Donos.Find(id);
            if (dono == null)
            {
                return HttpNotFound();
            }
            return View(dono);
        }

        // POST: Donos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Dono dono = db.Donos.Find(id);
            db.Donos.Remove(dono);
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
