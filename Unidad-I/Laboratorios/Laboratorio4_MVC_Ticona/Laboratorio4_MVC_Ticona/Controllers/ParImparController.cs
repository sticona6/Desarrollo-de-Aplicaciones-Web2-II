using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio4_MVC_Ticona.Models;

namespace Laboratorio4_MVC_Ticona.Controllers
{
    public class ParImparController : Controller
    {
        // GET: ParImpar
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MostrarParesImpares()
        {
            return View();
        }
        public ActionResult CalcularParesImpares(ClsParImpar eje)
        {
            return View(eje);
        }
    }
}