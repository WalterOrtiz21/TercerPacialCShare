using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TercerParcial_Ortiz.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CaracteristicasOrtiz()
        {
            ViewBag.Message = "Mis caracteristicas de la pagina";
            ViewBag.Caracteristica1 = "Mis caracteristicas de la pagina1";
            ViewBag.Caracteristica2 = "Mis caracteristicas de la pagina2";
            ViewBag.Caracteristica3 = "Mis caracteristicas de la pagina3";

            return View();
        }
    }
}