using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio4_MVC_Ticona.Models;

namespace Laboratorio4_MVC_Ticona.Controllers
{
    public class BilletesController : Controller
    {
        // GET: Billetes
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CalcularAltaDenominacion(ClsBilletes billetes)
        {
            int cantidadTotal;
            cantidadTotal = billetes.monto;

            int cant100, cant50, cant20, cant10;
            int res100, res50, res20, res10;

            cant100 = cantidadTotal / 100;
            res100 = cantidadTotal % 100;

            cant50 = res100 / 50;
            res50 = res100 % 50;

            cant20 = res50 / 20;
            res20 = res50 % 20;

            cant10 = res20 / 10;
            res10 = res20 % 10;

            billetes.b100 = cant100;
            billetes.b50 = cant50;
            billetes.b20 = cant20;
            billetes.b10 = cant10;

            return View(billetes);
        }

    }
}