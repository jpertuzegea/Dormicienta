using BLL_DORMISIENTA;
using DAO_DORMISIENTA;
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
    public class TiendaController : Controller
    { // GET: Tienda


        public async Task<ActionResult> Index(string CategoriaId)
        {
            int Categoria = 1;
            if (CategoriaId != null)
            {
                Categoria = Int32.Parse(CategoriaId);
            }
            BLL_Producto BLL_Producto = new BLL_Producto();
            List<PRODUCTO> Producto = BLL_Producto.ListProducto.Where(c => c.Categotia == Categoria && c.Estado == (byte)EnumEstados.Activo).ToList();

            ViewBag.Categoria = Categoria;
            return View(Producto);
        }
    }
}