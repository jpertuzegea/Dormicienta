using BLL_DORMISIENTA;
using BLL_DORMISIENTA.Utilidades;
using DAO_DORMISIENTA;
using DAO_DORMISIENTA.Enum;
using DAO_SONOLIENTA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DormicientaWeb.Controllers.Admin
{
    public class CategoriaController : Controller
    {
        public ActionResult Index(string Mensaje, string Creado)
        {
            BLL_Login.VerificarSesionActiva();// valida que la sesion este activa

            BLL_Categoria BLL_Categoria = new BLL_Categoria();
            List<CATEGORIA> Categorias = BLL_Categoria.ListarCategorias(EnumFiltroEstado.Todos);

            return View(Categorias);
        }

        // GET: CategoriaAdd
        public ActionResult CategoriaAdd()
        {
            BLL_Login.VerificarSesionActiva();// valida que la sesion este activa

            ViewBag.Estado = new SelectList(FuncionesEnum.ListaEnum<EnumEstados>(), "Value", "Text");
            return View();
        }

        // POST: CategoriaAdd
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CategoriaAdd(CATEGORIA CATEGORIA, HttpPostedFileBase file)
        {
            BLL_Login.VerificarSesionActiva();// valida que la sesion este activa

            ViewBag.estado = new SelectList(FuncionesEnum.ListaEnum<EnumEstados>(), "Value", "Text", (int)CATEGORIA.Estado);

            if (ModelState.IsValid)
            {
                if (file != null && file.ContentLength > 0)
                {
                    BLL_Categoria BLL_Categoria = new BLL_Categoria();
                    if (BLL_Categoria.GuargarCategoria(CATEGORIA, file))
                    {// pregunta si la funcion de creacion se ejecuto con exito
                        return RedirectToAction("Index", new { Mensaje = "Categoria Creada con Exito", Creado = "true" });
                    }
                    else
                    {// no creado
                        return View(CATEGORIA);
                    }
                }
                else
                {// no creado
                    return View(CATEGORIA);
                }
            }
            else
            {
                return View(CATEGORIA);
            }
        }

        //Update
        [HttpGet]
        public ActionResult CategoriaUpdt(int id)
        {
            BLL_Login.VerificarSesionActiva();// valida que la sesion este activa

            BLL_Categoria BLL_Categoria = new BLL_Categoria();
            CATEGORIA CATEGORIA = BLL_Categoria.GetCategoriaByCategoriaId(id);
            ViewBag.Estado = new SelectList(FuncionesEnum.ListaEnum<EnumEstados>(), "Value", "Text", (int)CATEGORIA.Estado);
            return View(CATEGORIA);
        }

        //Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CategoriaUpdt(CATEGORIA CATEGORIA, HttpPostedFileBase file)
        {
            BLL_Login.VerificarSesionActiva();// valida que la sesion este activa

            ViewBag.Estado = new SelectList(FuncionesEnum.ListaEnum<EnumEstados>(), "Value", "Text", (int)CATEGORIA.Estado);

            if (CATEGORIA != null)
            {
                if (ModelState.IsValid)
                {
                    BLL_Categoria BLL_Categoria = new BLL_Categoria();
                    if (BLL_Categoria.ModificarCategoria(CATEGORIA, file))
                    {
                        return RedirectToAction("Index", new { Mensaje = "Categoria Modificada con Exito", Creado = "true" });
                    }
                    else
                    {
                        return View(CATEGORIA);
                    }
                }
                else
                {
                    return View(CATEGORIA);
                }
            }
            else
            {
                return View(CATEGORIA);
            }
        }

        public ActionResult VerImagen(int CategoriaId)
        {
            //   BLL_Login.VerificarSesionActiva();// valida que la sesion este activa

            BLL_Categoria BLL_Categoria = new BLL_Categoria();
            CATEGORIA Categoria = BLL_Categoria.GetCategoriaByCategoriaId(CategoriaId);

            return File(Categoria.Imagen, Categoria.ContetType);
        }

    }
}

