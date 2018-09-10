using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio3_MVC_Ticona.Models;

namespace Laboratorio3_MVC_Ticona.Controllers
{
    public class RuletaController : Controller
    {
        // GET: Ruleta
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GenerarRuleta(ClsRuleta ObjRuleta)
        {
            Random random = new Random();
            ObjRuleta.valor1 = random.Next(3);
            ObjRuleta.valor2 = random.Next(3);
            ObjRuleta.valor3 = random.Next(3);

            if ((ObjRuleta.valor1 == ObjRuleta.valor2) && (ObjRuleta.valor2 == ObjRuleta.valor3))
            {
                ObjRuleta.resultado = "Ganaste el Premio Mayor $100,000";
            }
            else {
                ObjRuleta.resultado = "Sigue Intentándolo... La próxima lo lograras";
            }

            return View("GenerarRuleta", ObjRuleta);
        }
    }
}