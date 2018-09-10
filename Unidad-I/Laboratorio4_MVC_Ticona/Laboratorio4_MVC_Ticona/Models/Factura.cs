using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Laboratorio4_MVC_Ticona.Models
{
    public class Factura
    {
        public string producto { get; set; }
        public int cantidad { get; set; }
        public double precioU { get; set; }
        public double IGV { get; set; }
        public double Total { get; set; }
        public List<int> Lcantidad { get; set; }
        public List<string> Lproducto { get; set; }
        public List<double> LprecioU { get; set; }
        public List<double> LsubT { get; set; }
    }
}