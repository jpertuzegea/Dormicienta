using BLL_SONOLIENTA;
using MODELOS_SONOLIENTA.BD;
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
        public ActionResult Index(UsuariosModel UsuariosModel)
        {
            BLL_Login BLL_Login = new BLL_Login();
            if(BLL_Login.InicarSesion())
            {// Si las credenciales son correctas
                return RedirectToAction("Index", "Inicio");
            }
            else
            {
                ViewBag.Mensaje = "Usuario y Clave No Coinciden ";
                ViewBag.Acceso = "Acceso Denegado";
                return View();
           }
        }

        [HttpGet]
        public ActionResult CerrarSesion()
        {
            BLL_Login BLL_Login = new BLL_Login();
            BLL_Login.CerrarSesion();
            return View("Index","Login");
        }

    }
}