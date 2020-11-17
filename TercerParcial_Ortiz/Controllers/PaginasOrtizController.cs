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
    }
}
