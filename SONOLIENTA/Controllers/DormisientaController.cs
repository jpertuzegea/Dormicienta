using BLL_DORMISIENTA;
using DAO_DORMISIENTA;
using DAO_DORMISIENTA.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SONOLIENTA.Controllers
{
    public class DormisientaController : Controller
    {
        // GET: Dormisienta
        public ActionResult Index()
        {
            BLL_Categoria BLL_Categoria = new BLL_Categoria();
            BLL_Producto BLL_Producto = new BLL_Producto();

            List<CATEGORIA> Categorias = BLL_Categoria.ListarCategorias(EnumFiltroEstado.Activo);
            ViewBag.ListProductos = BLL_Producto.ListarProductos(EnumFiltroEstado.Activo);// se usa en la vista parcial

            return View(Categorias);          
        }
    }
}