using BLL_DORMISIENTA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DormicientaWeb.Controllers.Admin
{
    public class InicioController : Controller
    {
        public ActionResult Index()
        {
            BLL_Login.VerificarSesionActiva();// valida que la sesion este activa
            return View();
        }

    }
}