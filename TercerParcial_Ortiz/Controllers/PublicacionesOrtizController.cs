using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using TercerParcial_Ortiz.Models;

namespace TercerParcial_Ortiz.Controllers
{
    public class PublicacionesOrtizController : Controller
    {
        private OrkutUAAEntities db = new OrkutUAAEntities();

        // GET: PublicacionesOrtiz
        public ActionResult Index()
        {
            return View(db.Publicacion.ToList());
        }

        // GET: PublicacionesOrtiz/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Publicacion publicacion = db.Publicacion.Find(id);
            if (publicacion == null)
            {
                return HttpNotFound();
            }
            return View(publicacion);
        }

        // GET: PublicacionesOrtiz/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PublicacionesOrtiz/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Fecha,Mes,Titulo,Texto")] Publicacion publicacion)
        {
            if (ModelState.IsValid)
            {
                publicacion.Mes = DateTime.Now.Month;
                publicacion.Fecha = DateTime.Now;
                db.Publicacion.Add(publicacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(publicacion);
        }

        // GET: PublicacionesOrtiz/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Publicacion publicacion = db.Publicacion.Find(id);
            if (publicacion == null)
            {
                return HttpNotFound();
            }
            return View(publicacion);
        }

        // POST: PublicacionesOrtiz/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Fecha,Mes,Titulo,Texto")] Publicacion publicacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(publicacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(publicacion);
        }

        // GET: PublicacionesOrtiz/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Publicacion publicacion = db.Publicacion.Find(id);
            if (publicacion == null)
            {
                return HttpNotFound();
            }
            return View(publicacion);
        }

        // POST: PublicacionesOrtiz/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Publicacion publicacion = db.Publicacion.Find(id);
            db.Publicacion.Remove(publicacion);
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

        public ActionResult MesOrtiz(int? mes)
        {
            if (mes == null)
            {
                mes = 11;
            }
            var lstpublicacion = db.Publicacion.ToList().Where(x => x.Mes == mes);
            return View(lstpublicacion);
        }
    }
}
