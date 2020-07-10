using BLL_DORMISIENTA;
using BLL_SONOLIENTA;
using DAO_SONOLIENTA;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DormicientaWeb.Controllers.Admin
{
    public class ContactenosController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.CorreoContacto = ConfigurationManager.AppSettings.Get("CorreoContacto");
            ViewBag.TelefonoContacto = ConfigurationManager.AppSettings.Get("TelefonoContacto");
            return View();
        }

        [HttpPost]
        public ActionResult Index(CONTACTENOS Contactenos)
        {
            BLL_Contactenos BLL_Contactenos = new BLL_Contactenos();
            if (BLL_Contactenos.EnviarMensaje(Contactenos))
            {// pregunta si la funcion de creacion se ejecuto con exito
                return RedirectToAction("Index", "Tienda");
            }
            else
            {// no creado
                return View(Contactenos);
            }
        }

        public ActionResult Mensajes()
        {
            BLL_Login.VerificarSesionActiva();// valida que la sesion este activa

            BLL_Contactenos BLL_Contactenos = new BLL_Contactenos();
            List<CONTACTENOS> Mensajes = BLL_Contactenos.ListarMensajes();
            return View(Mensajes); 
        }


    }
}