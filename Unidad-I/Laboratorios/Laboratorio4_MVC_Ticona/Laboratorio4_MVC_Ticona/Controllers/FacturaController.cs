using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio4_MVC_Ticona.Models;

namespace Laboratorio4_MVC_Ticona.Controllers
{
    public class FacturaController : Controller
    {
        // GET: Factura
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CalcularFactura(Factura ObjFactura)
        {
            if (ModelState.IsValid)
            {
                //Almaceno en la session
                if (Session["PROD"] != null && Session["CANT"]!=null && Session["PREU"] != null&&Session["TOT"]!=null)
                {
                    ObjFactura.Lproducto = Session["PROD"] as List<string>;
                    ObjFactura.Lcantidad = Session["CANT"] as List<int>;
                    ObjFactura.LprecioU = Session["PREU"] as List<double>;

                    ObjFactura.LsubT = Session["TOT"] as List<double>;
                }
                else
                {
                    //Creamos una nueva lista
                    ObjFactura.Lproducto = new List<string>();
                    ObjFactura.Lcantidad = new List<int>();
                    ObjFactura.LprecioU = new List<double>();
                    ObjFactura.LsubT = new List<double>();
                }

                ObjFactura.Lproducto.Add(ObjFactura.producto);
                ObjFactura.Lcantidad.Add(ObjFactura.cantidad);
                ObjFactura.LprecioU.Add(ObjFactura.precioU);

                ObjFactura.LsubT.Add(ObjFactura.precioU * ObjFactura.cantidad);

                //Calculamos
                

                //Almacenamos los cambios en la sesión
                Session["CANT"] = ObjFactura.Lcantidad;
                Session["PROD"] = ObjFactura.Lproducto;
                Session["PREU"] = ObjFactura.LprecioU;
                Session["TOT"] = ObjFactura.LsubT;

               double LIGV = 0.18;
               List<double>STotal = Session["TOT"] as List<double>;
               ObjFactura.IGV =STotal.Sum()*LIGV;
               ObjFactura.Total = STotal.Sum()+ObjFactura.IGV;


            }

            return View(ObjFactura);
        }
    }
}