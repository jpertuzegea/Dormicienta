using BLL_DORMISIENTA;
using DAO_DORMISIENTA;
using DAO_DORMISIENTA.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DormicientaWeb.Controllers.Admin
{
    public class TiendaController : Controller
    { // GET: Tienda

        public ActionResult Index(string Categoria)
        {
            if (Categoria == null)
            {
                BLL_Categoria BLL_Categoria = new BLL_Categoria();
                Categoria = BLL_Categoria.ListarCategorias(EnumFiltroEstado.Activo).FirstOrDefault().Nombre;
            }

            BLL_Producto BLL_Producto = new BLL_Producto();
            List<PRODUCTO> Producto = BLL_Producto.ListarProductos(EnumFiltroEstado.Activo);
            Producto.Where(x => x.CATEGORIA.Nombre == Categoria);
            ViewBag.Categoria = Categoria;
            return View(Producto);
        }
    }
}