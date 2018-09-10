using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio5_LINQ_MVC_Ticona.Models;

namespace Laboratorio5_LINQ_MVC_Ticona.Controllers
{
    public class EjercicioPropuestoController : Controller
    {
		public String[] alumnos = { "Luis Linares Quispe", "Maria Gutierrez Mendoza", "Carlos Flores Colque", "Ignacio Quenta Diaz", "Karla Honojosa"};
		
		public String[] notas = { "15.0", "8.5", "13.0", "8.0", "2.0"};

		// GET: EjercicioPropuesto
		public ActionResult Index(ClsAlumnoNota ObjEjercicioPropuesto)
        {
			string busqueda;
			ObjEjercicioPropuesto.name = new List<string>();
			ObjEjercicioPropuesto.note = new List<double>();

			if (ObjEjercicioPropuesto.busqueda != null)
			{
				busqueda = ObjEjercicioPropuesto.busqueda;

				var query = (from a in alumnos.Select((alumno, index) => new { alumno, index })
							 join n in notas.Select((nota, index) => new { nota, index })
							 on a.index equals n.index
							 where a.alumno.Contains(busqueda)
							 select new { a.alumno, n.nota }).ToList();
				foreach (var item in query)
				{
					ObjEjercicioPropuesto.name.Add(Convert.ToString(item.alumno));
					ObjEjercicioPropuesto.note.Add(Convert.ToDouble(item.nota));
				}
			}
			else
			{
				var query = (from a in alumnos.Select((alumno, index) => new { alumno, index })
							 join n in notas.Select((nota, index) => new { nota, index })
							 on a.index equals n.index
							 select new { a.alumno, n.nota }).ToList();

				foreach (var item in query)
				{
					ObjEjercicioPropuesto.name.Add(Convert.ToString(item.alumno));
					ObjEjercicioPropuesto.note.Add(Convert.ToDouble(item.nota));
				}
			}
			ObjEjercicioPropuesto.row = ObjEjercicioPropuesto.name.Count();
			return View(ObjEjercicioPropuesto);
		}
    }
}