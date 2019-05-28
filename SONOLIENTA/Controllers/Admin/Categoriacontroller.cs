using BLL_SONOLIENTA;
using BLL_SONOLIENTA.Utilidades;
using DAO_SONOLIENTA;
using DAO_SONOLIENTA.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SONOLIENTA.Controllers
{
    public class Categoriacontroller : Controller
    {

        public ActionResult Index()
        {
            BLL_Categoria BLL_Categoria = new BLL_Categoria();

            List<CATEGORIA> Categorias = BLL_Categoria.ListarCategorias(EnumFiltroEstado.Todos);

            return View(Categorias);
        }

        // GET: CategoriaAdd
        public ActionResult CategoriaAdd()
        {
            ViewBag.Estado = new SelectList(FuncionesEnum.ListaEnum<EnumEstados>(), "Value", "Text");
            return View();
        }

        // POST: CategoriaAdd
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CategoriaAdd(CATEGORIA CATEGORIA)
        {
            ViewBag.estado = new SelectList(FuncionesEnum.ListaEnum<EnumEstados>(), "Value", "Text", (int)CATEGORIA.Estado);

            if (ModelState.IsValid)
            {
                BLL_Categoria BLL_Categoria = new BLL_Categoria();
                if (BLL_Categoria.GuargarCategoria(CATEGORIA))
                {// pregunta si la funcion de creacion se ejecuto con exito
                    return RedirectToAction("Index");
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
        public ActionResult CategoriaUpdt(int IdCategoria)
        {
            BLL_Categoria BLL_Categoria = new BLL_Categoria();
            CATEGORIA CATEGORIA = BLL_Categoria.GetCategoriaByCategoriaId(IdCategoria);
            ViewBag.Estado = new SelectList(FuncionesEnum.ListaEnum<EnumEstados>(), "Value", "Text", (int)CATEGORIA.Estado);
            return View(CATEGORIA);
        }

        //Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CategoriaUpdt(CATEGORIA CATEGORIA)
        {

            ViewBag.Estado = new SelectList(FuncionesEnum.ListaEnum<EnumEstados>(), "Value", "Text", (int)CATEGORIA.Estado);

            if (CATEGORIA != null)
            {
                if (ModelState.IsValid)
                {
                    BLL_Categoria BLL_Categoria = new BLL_Categoria();
                    if (BLL_Categoria.ModificarCategoria(CATEGORIA))
                    {
                        return RedirectToAction("Index");
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

    }
}


