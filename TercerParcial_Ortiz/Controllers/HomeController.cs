using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TercerParcial_Ortiz.Controllers
{
    public class HomeController : Controller
    {
        public async System.Threading.Tasks.Task<ActionResult> Index()
        {
            string resultado = await Dolar.ObtenerCambios().ConfigureAwait(false);
            JObject o = JObject.Parse(resultado);
            JObject ob = (JObject)o["dolarpy"];
            var c = ob.SelectToken("maxicambios");
            ViewBag.MaxiCompra = c.SelectToken("compra");
            ViewBag.MaxiVenta = c.SelectToken("venta");
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