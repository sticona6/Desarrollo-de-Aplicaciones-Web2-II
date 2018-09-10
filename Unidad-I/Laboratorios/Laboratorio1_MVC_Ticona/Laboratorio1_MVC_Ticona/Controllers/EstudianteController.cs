using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio1_MVC_Ticona.Models;

namespace Laboratorio1_MVC_Ticona.Controllers
{
    public class EstudianteController : Controller
    {
        // GET: Estudiante
        public ActionResult Index()
        {
            return View();
        }
        //Accion mostrar datos
        public ActionResult MostrarDatos(ClsEstudiante ObjEstudiante)
        {
            ObjEstudiante.nombre ="Sergio Alexis";
            ObjEstudiante.apellido = "Ticona Arcaya";
            ObjEstudiante.edad = 22;
            ObjEstudiante.peso = 70.5;

            return View("MostrarDatos", ObjEstudiante);
        }
    }
}