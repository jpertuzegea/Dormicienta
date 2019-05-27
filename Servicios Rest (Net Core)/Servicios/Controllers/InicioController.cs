using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Servicios.Controllers
{
    public class InicioController : Controller
    {
        [Route("api/[controller]")]
        public ActionResult Index()
        {
            return View();
        }

    }
}