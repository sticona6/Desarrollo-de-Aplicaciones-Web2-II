using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio3_MVC_Ticona.Models
{
    public class ClsVenta
    {
        public string nombre {get;set;}
        public string direccion { get; set; }
        public bool productoUSB { get; set; }
        public bool productoMOUSE { get; set; }
        public bool productoTECLADO { get; set; }
        public bool productoDISCODURO { get; set; }
        public double subtotal { get; set; }
        public double igv { get; set; }
        public double total { get; set; }
    }
}