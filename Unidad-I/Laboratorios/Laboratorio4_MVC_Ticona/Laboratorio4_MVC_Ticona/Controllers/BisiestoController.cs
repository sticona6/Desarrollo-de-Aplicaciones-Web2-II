using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio4_MVC_Ticona.Models;

namespace Laboratorio4_MVC_Ticona.Controllers
{
    public class BisiestoController : Controller
    {
        // GET: Bisiesto
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MostrarAnios()
        {
            return View();
        }
        public ActionResult CalcularAnios(ClsEjercicio6 eje)
        {
            return View(eje);
        }
    }
}