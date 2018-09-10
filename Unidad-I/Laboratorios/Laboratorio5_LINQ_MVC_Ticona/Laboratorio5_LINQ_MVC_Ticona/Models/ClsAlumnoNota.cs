using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio5_LINQ_MVC_Ticona.Models
{
	public class ClsAlumnoNota
	{
		public string busqueda { get; set; } = "";
		public string resultado { get; set; } = "";
		public List<string> name { get; set; }
		public List<double> note { get; set; }
		public int row { get; set; }
	}
}