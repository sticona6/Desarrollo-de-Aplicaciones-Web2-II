using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SISTEMAMVCTICONA.Models;

namespace SISTEMAMVCTICONA.Controllers
{
    public class UsuarioController : Controller
    {
        private Usuario usuario = new Usuario();
        private TipoUsuario tipousuario = new TipoUsuario();
        // GET: TipoUsuario
        public ActionResult Index(string criterio)
        {
            if (criterio == null || criterio == "")
            {
                return View(usuario.Listar());
            }
            else
            {
                return View(usuario.Buscar(criterio));
            }
        }

        public ActionResult Ver(int id)
        {
            return View(usuario.Obtener(id));
        }

        public ActionResult Buscar(string criterio)
        {
            return View(
                criterio == null || criterio == ""
                ? usuario.Listar() : usuario.Buscar(criterio)
                );
        }

        public ActionResult AgregarEditar(int id = 0)
        {
            ViewBag.Tipo = tipousuario.Listar();
            return View(
                id == 0 ? new Usuario() //agregar un nuevo objeto
                : usuario.Obtener(id)
                );
        }

        public ActionResult Guardar(Usuario usu)
        {
            if (ModelState.IsValid)
            {
                usu.Guardar();
                return Redirect("~/Usuario");
            }
            else
            {
                return View("~/Views/Usuario/AgregarEditar.cshtml", usu);
            }
        }

        public ActionResult Eliminar(int id)
        {
            usuario.idusuario = id;
            usuario.Eliminar();
            return Redirect("~/Usuario");
        }
    }
}