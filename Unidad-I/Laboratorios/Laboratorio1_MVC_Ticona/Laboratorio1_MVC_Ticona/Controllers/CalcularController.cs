using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio1_MVC_Ticona.Models;

namespace Laboratorio1_MVC_Ticona.Controllers
{
    public class CalcularController : Controller
    {
        // GET: Calcular
        public ActionResult Index()
        { 
            return View();
        }
        //Calcular Suma
        public ActionResult Suma(ClsSuma ObjSuma)
        {
            ObjSuma.resultado = ObjSuma.numero1 + ObjSuma.numero2;
            return View("Suma", ObjSuma);
        }
        public ActionResult Suma2(ClsSuma ObjSuma2)
        {
            ObjSuma2.numero1 = Convert.ToDouble(Request.Form["Valor1"]);
            ObjSuma2.numero2 = Convert.ToDouble(Request.Form["Valor2"]);
            ObjSuma2.resultado = ObjSuma2.numero1 + ObjSuma2.numero2;
            return View(ObjSuma2);
        }
    }
}