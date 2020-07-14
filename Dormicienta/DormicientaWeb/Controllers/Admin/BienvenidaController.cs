using BLL_DORMISIENTA;
using BLL_SONOLIENTA;
using DAO_DORMISIENTA.Enum;
using DAO_SONOLIENTA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DormicientaWeb.Controllers.Admin
{
    public class BienvenidaController : Controller
    {

        public async Task<ActionResult> Index()
        {
            BLL_ContadorVisitas BLL_ContadorVisitas = new BLL_ContadorVisitas();
            BLL_ContadorVisitas.RegistrarVisita();
            return View();
        }

    }
}