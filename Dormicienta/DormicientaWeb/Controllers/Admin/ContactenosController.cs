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
        public ActionResult Index(int dato)
        {
            return View();
        }
    }
}