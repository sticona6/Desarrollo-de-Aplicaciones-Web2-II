using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laboratorio1_MVC_Ticona.Controllers
{
    public class VisualizarDatosController : Controller
    {
        // GET: VisualizarDatos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MostrarDatos()
        {
            ViewBag.Curso = "Desarrollo de Aplicaciones Web II";
            ViewBag.Nombre = "Sergio A.Ticona Arcaya";
            ViewData["Carrera"] = "Ingeniería de Sistemas";
            ViewData["FechaHora"] = DateTime.Now.ToString();
            return View();
        }
    }
}