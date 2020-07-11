using BLL_DORMISIENTA;
using BLL_DORMISIENTA.Utilidades;
using DAO_DORMISIENTA;
using DAO_DORMISIENTA.Enum;
using DAO_SONOLIENTA;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace DormicientaWeb.Controllers.Admin
{
    public class ProductoController : Controller
    {


        // GET: Producto
        public async Task<ActionResult> Index()
        {
            BLL_Login.VerificarSesionActiva();// valida que la sesion este activa

            BLL_Producto BLL_Producto = new BLL_Producto();
            List<PRODUCTO> Producto = BLL_Producto.ListarProductos(EnumFiltroEstado.Todos);
            return View(Producto);
        }

        // GET: MarcaAdd
        public ActionResult ProductoAdd()
        {
            BLL_Login.VerificarSesionActiva();// valida que la sesion este activa

            BLL_Categoria BLL_Categoria = new BLL_Categoria();
            List<SelectListItem> lista = BLL_Categoria.ArmarSelectCategorias(EnumFiltroEstado.Activo);
            ViewBag.Categoria = new SelectList(lista, "Value", "Text");

            ViewBag.Estado = new SelectList(FuncionesEnum.ListaEnum<EnumEstados>(), "Value", "Text");
            return View();
        }

        // POST: MarcaAdd
        [System.Web.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductoAdd(PRODUCTO Producto, HttpPostedFileBase file)
        {
            BLL_Login.VerificarSesionActiva();// valida que la sesion este activa

            BLL_Categoria BLL_Categoria = new BLL_Categoria();
            List<SelectListItem> lista = BLL_Categoria.ArmarSelectCategorias(EnumFiltroEstado.Activo);
            ViewBag.Categoria = new SelectList(lista, "Value", "Text", Producto.Categotia);

            ViewBag.Estado = new SelectList(FuncionesEnum.ListaEnum<EnumEstados>(), "Value", "Text", (int)Producto.Estado);

            if (ModelState.IsValid)
            {
                if (file != null && file.ContentLength > 0)
                {
                    BLL_Producto BLL_Producto = new BLL_Producto();
                    if (BLL_Producto.GuargarProducto(Producto, file))
                    {// pregunta si la funcion de creacion se ejecuto con exito
                        return RedirectToAction("Index");
                    }
                    else
                    {// no creado
                        return View(Producto);
                    }
                }
                else
                {// no creado
                    return View(Producto);
                }
            }
            else
            {
                return View(Producto);
            }
        }

        //Update
        [System.Web.Mvc.HttpGet]
        public ActionResult ProductoUpdt(int id)
        {
            BLL_Login.VerificarSesionActiva();// valida que la sesion este activa

            BLL_Producto BLL_Producto = new BLL_Producto();
            PRODUCTO Producto = BLL_Producto.GetProductoByProductoId(id);

            BLL_Categoria BLL_Categoria = new BLL_Categoria();
            List<SelectListItem> lista = BLL_Categoria.ArmarSelectCategorias(EnumFiltroEstado.Activo);
            ViewBag.Categoria = new SelectList(lista, "Value", "Text", Producto.Categotia);

            ViewBag.Estado = new SelectList(FuncionesEnum.ListaEnum<EnumEstados>(), "Value", "Text", (int)Producto.Estado);

            return View(Producto);
        }

        //Update
        [System.Web.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductoUpdt(PRODUCTO Producto, HttpPostedFileBase file)
        {
            BLL_Login.VerificarSesionActiva();// valida que la sesion este activa

            BLL_Categoria BLL_Categoria = new BLL_Categoria();
            List<SelectListItem> lista = BLL_Categoria.ArmarSelectCategorias(EnumFiltroEstado.Activo);
            ViewBag.Categoria = new SelectList(lista, "Value", "Text", Producto.Categotia);

            ViewBag.Estado = new SelectList(FuncionesEnum.ListaEnum<EnumEstados>(), "Value", "Text", (int)Producto.Estado);

            if (Producto != null)
            {
                if (ModelState.IsValid)
                {
                    BLL_Producto BLL_Producto = new BLL_Producto();
                    if (BLL_Producto.ModificarProducto(Producto, file))
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View(Producto);
                    }
                }
                else
                {
                    return View(Producto);
                }
            }
            else
            {
                return View(Producto);
            }
        }

        [System.Web.Mvc.HttpGet]
        public ActionResult DetalleProducto(int id)
        {
            BLL_Producto BLL_Producto = new BLL_Producto();
            PRODUCTO Producto = BLL_Producto.GetProductoByProductoId(id);

            BLL_Categoria BLL_Categoria = new BLL_Categoria();
            List<SelectListItem> lista = BLL_Categoria.ArmarSelectCategorias(EnumFiltroEstado.Activo);
            ViewBag.Categoria = new SelectList(lista, "Value", "Text", Producto.Categotia);
            ViewBag.CorreoContacto = ConfigurationManager.AppSettings.Get("CorreoContacto");
            ViewBag.TelefonoContacto = ConfigurationManager.AppSettings.Get("TelefonoContacto");
            return View(Producto);
        }

        public async Task<ActionResult> VerImagen(int ProductoId)
        {
            PRODUCTO Producto = BLL_Producto.ListProducto.Where(x => x.ProductoId == ProductoId).FirstOrDefault();
            return File(Producto.Imagen, Producto.ContetType);

            //BLL_Producto BLL_Producto = new BLL_Producto();
            //var Producto = await BLL_Producto.GetProductoByProductoId(ProductoId);

            //return File(Producto.Imagen, Producto.ContetType);
        }

        //[System.Web.Mvc.HttpPost]
        //public ActionResult ValidarCodigoProducto([System.Web.Http.FromBody] string Codigo)
        //{
        //    BLL_Login.VerificarSesionActiva();// valida que la sesion este activa 

        //    BLL_Producto BLL_Producto = new BLL_Producto();
        //    var Result = BLL_Producto.ValidarCodigoProducto(Codigo);
        //    return Result;

        //}

    }
}