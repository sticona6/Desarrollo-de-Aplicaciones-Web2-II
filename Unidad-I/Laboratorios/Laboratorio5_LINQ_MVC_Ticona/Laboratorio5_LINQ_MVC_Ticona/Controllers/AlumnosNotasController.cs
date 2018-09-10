using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio5_LINQ_MVC_Ticona.Models;

namespace Laboratorio5_LINQ_MVC_Ticona.Controllers
{
    public class AlumnosNotasController : Controller
    {
		// GET: AlumnosNotas
		public String[] alumnos = { "Carlos", "Leonardo", "Ana", "Maria", "Miquel", "Sergio", "Luis", "Hernan" };
		public String[] notas = { "20", "15", "12", "14", "16", "18", "20", "20" };
		
		public ActionResult Index(ClsAlumnoNota objAlumnoNota)
		{
			string busqueda;

			if (objAlumnoNota.busqueda != null)
			{
				busqueda = objAlumnoNota.busqueda;

				var query = (from a in alumnos.Select((alumno, index) => new { alumno, index })
							 join n in notas.Select((nota, index) => new { nota, index })
							 on a.index equals n.index
							 where a.alumno.Contains(busqueda)
							 select new { a.alumno, n.nota }).ToList();
				foreach (var item in query)
				{
					objAlumnoNota.resultado += Convert.ToString(item) + "\n";
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
					objAlumnoNota.resultado += Convert.ToString(item) + "\n";

				}
			}
			return View(objAlumnoNota);
		}
	}
}