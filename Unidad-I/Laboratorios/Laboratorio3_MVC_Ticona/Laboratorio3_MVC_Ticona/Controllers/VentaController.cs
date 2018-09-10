using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio3_MVC_Ticona.Models;
namespace Laboratorio3_MVC_Ticona.Controllers
{
    public class VentaController : Controller
    {
        public static double precioUSB =120;
        public static double precioMOUSE = 50;
        public static double precioTECLADO = 85;
        public static double precioDISCODURO = 350;


        // GET: Venta
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CalcularVenta(ClsVenta ObjVenta)
        {
            if (ObjVenta.productoUSB == true) {
                ObjVenta.subtotal = ObjVenta.subtotal + precioUSB;
            }
            if (ObjVenta.productoMOUSE == true)
            {
                ObjVenta.subtotal = ObjVenta.subtotal + precioMOUSE;
            }
            if (ObjVenta.productoTECLADO == true)
            {
                ObjVenta.subtotal = ObjVenta.subtotal + precioTECLADO;
            }
            if (ObjVenta.productoDISCODURO == true)
            {
                ObjVenta.subtotal = ObjVenta.subtotal + precioDISCODURO;
            }

            ObjVenta.igv = ObjVenta.subtotal * 0.18;
            ObjVenta.total = ObjVenta.subtotal + ObjVenta.igv;

            return View("CalcularVenta",ObjVenta);
        }

    }
}