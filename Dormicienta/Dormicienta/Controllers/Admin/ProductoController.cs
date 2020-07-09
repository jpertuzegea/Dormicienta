using BLL_DORMISIENTA;
using BLL_DORMISIENTA.Utilidades;
using DAO_DORMISIENTA;
using DAO_DORMISIENTA.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dormicienta.Controllers.Admin
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
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
        [HttpPost]
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
        [HttpGet]
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
        [HttpPost]
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




        public ActionResult VerImagen(int ProductoId)
        {
            BLL_Producto BLL_Producto = new BLL_Producto();
            PRODUCTO Producto = BLL_Producto.GetProductoByProductoId(ProductoId);

            return File(Producto.Imagen, Producto.ContetType);
        }


    }
}