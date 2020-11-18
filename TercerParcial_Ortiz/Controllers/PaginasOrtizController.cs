using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TercerParcial_Ortiz;
using TercerParcial_Ortiz.Models;

namespace TercerParcial_Ortiz.Controllers
{
    public class PaginasOrtizController : Controller
    {
        private OrkutUAAEntities db = new OrkutUAAEntities();

        public ActionResult PaginasOrtiz()
        {
            var lst = db.Pagina.ToList().Take(10);
            return View(lst);
        }

        public ActionResult ParaTiOrtiz()
        {
            var lst = db.Pagina.OrderByDescending(x => x.CantidadLikes).Take(1);
            int cantProgramacion = db.Pagina.Where(x => x.Categoria == "Programación").Count();
            double? promedioLikes = db.Pagina.Where(x => x.Ciudad == "Asuncion").Average(x => x.CantidadLikes);
            ViewBag.cantProgramacion = "Cantidad de paginas de la categoria programacion= " + cantProgramacion;
            ViewBag.Promedio = "El promedio de likes de las páginas que sean de la ciudad de Asunción= " + promedioLikes;
            return View(lst);
        }
    }
}
