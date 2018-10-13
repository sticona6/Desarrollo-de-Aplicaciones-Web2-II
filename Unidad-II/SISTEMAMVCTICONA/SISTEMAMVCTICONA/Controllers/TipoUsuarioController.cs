using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SISTEMAMVCTICONA.Models;

namespace SISTEMAMVCTICONA.Controllers
{
    public class TipoUsuarioController : Controller
    {
        private TipoUsuario tipousuario = new TipoUsuario();
        // GET: TipoUsuario
        public ActionResult Index(string criterio)
        {
            if (criterio == null || criterio == "")
            {
                return View(tipousuario.Listar());
            }
            else {
                return View(tipousuario.Buscar(criterio));
            }
        }

        public ActionResult Ver(int id) {
            return View(tipousuario.Obtener(id));
        }

        public ActionResult Buscar(string criterio) {
            return View(
                criterio == null || criterio == ""
                ? tipousuario.Listar() : tipousuario.Buscar(criterio)
                );
        }

        public ActionResult AgregarEditar(int id = 0) {
            ViewBag.Tipo = tipousuario.Listar();
            return View(
                id == 0 ? new TipoUsuario() //agregar un nuevo objeto
                : tipousuario.Obtener(id)
                );
        }

        public ActionResult Guardar(TipoUsuario tipo){
            if (ModelState.IsValid)
            {
                tipo.Guardar();
                return Redirect("~/TipoUsuario");
            }
            else {
                return View("~/Views/TipoUsuario/AgregarEditar.cshtml",tipo);
            }
        }

        public ActionResult Eliminar(int id) {
            tipousuario.idtipousuario = id;
            tipousuario.Eliminar();
            return Redirect("~/TipoUsuario");
        }
    }
}