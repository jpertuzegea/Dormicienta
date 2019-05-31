using BLL_SONOLIENTA;
using DAO_SONOLIENTA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SONOLIENTA.Controllers.Admin
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        // POST: Login
        [HttpPost]
        public ActionResult Index(USUARIO USUARIO)
        {
            BLL_Login BLL_Login = new BLL_Login();
            if (BLL_Login.InicarSesion(USUARIO))
            {// Si las credenciales son correctas
                return RedirectToAction("Index", "Inicio");
            }
            else
            {
                ViewBag.Mensaje = "Usuario y Clave No Coinciden ";
                ViewBag.Acceso = "Acceso Denegado";
                return View();
            }
            return View();
        }

        [HttpGet]
        public ActionResult CerrarSesion()
        {
            BLL_Login BLL_Login = new BLL_Login();
            BLL_Login.CerrarSesion();
            return RedirectToAction("Index", "Login"); // direcciona hacia el inicio de sesion
        }

    }
}