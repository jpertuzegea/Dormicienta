using BLL_DORMISIENTA;
using DAO_DORMISIENTA;
using DAO_DORMISIENTA.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Dormicienta.Controllers.Tienda
{
    public class DormicientaController : Controller
    {
        [System.Web.Mvc.HttpGet]
        public ActionResult Index(string Categoria)
        {
            BLL_Producto BLL_Producto = new BLL_Producto();
            List<PRODUCTO> Producto = BLL_Producto.ListarProductos(EnumFiltroEstado.Todos);
            ViewBag.Categoria = Categoria;
            return View(Producto); 
        }
    }
}