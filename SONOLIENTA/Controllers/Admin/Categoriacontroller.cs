using BLL_SONOLIENTA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SONOLIENTA.Controllers
{
    public class Categoriacontroller : Controller
    {
        // GET: Categoriacontroller
        public ActionResult Index()
        {
            BLL_Categoria BLL_Categoria = new BLL_Categoria();
            return View(BLL_Categoria.ListarCategorias());
        }



    }
}