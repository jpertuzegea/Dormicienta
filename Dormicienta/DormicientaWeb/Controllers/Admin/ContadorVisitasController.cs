using BLL_DORMISIENTA;
using BLL_SONOLIENTA;
using DAO_SONOLIENTA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace DormicientaWeb.Controllers.Admin
{
    public class ContadorVisitasController : Controller
    {

        public ActionResult Index()
        {
            BLL_Login.VerificarSesionActiva();// valida que la sesion este activa

            BLL_ContadorVisitas BLL_ContadorVisitas = new BLL_ContadorVisitas();
            List<CONTADORVISITAS> List = BLL_ContadorVisitas.ListarVisitas();

            return View(List);
        }

    }
}
