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
    public class MarcaController : Controller
    {
        // GET: Marca
        public ActionResult Index()
        {
            BLL_Login.VerificarSesionActiva();// valida que la sesion este activa

            BLL_Marca BLL_Marca = new BLL_Marca();
            List<MARCA> Marcas = BLL_Marca.ListarMarcas(EnumFiltroEstado.Todos);
            return View(Marcas);
        }

        // GET: MarcaAdd
        public ActionResult MarcaAdd()
        {
            BLL_Login.VerificarSesionActiva();// valida que la sesion este activa

            ViewBag.Estado = new SelectList(FuncionesEnum.ListaEnum<EnumEstados>(), "Value", "Text");
            return View();
        }

        // POST: MarcaAdd
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MarcaAdd(MARCA MARCA)
        {
            BLL_Login.VerificarSesionActiva();// valida que la sesion este activa

            ViewBag.Estado = new SelectList(FuncionesEnum.ListaEnum<EnumEstados>(), "Value", "Text", (int)MARCA.Estado);

            if (ModelState.IsValid)
            {
                BLL_Marca BLL_Marca = new BLL_Marca();
                if (BLL_Marca.GuargarMarca(MARCA))
                {// pregunta si la funcion de creacion se ejecuto con exito
                    return RedirectToAction("Index");
                }
                else
                {// no creado
                    return View(MARCA);
                }
            }
            else
            {
                return View(MARCA);
            }
        }


        //Update
        [HttpGet]
        public ActionResult MarcaUpdt(int id)
        {
            BLL_Login.VerificarSesionActiva();// valida que la sesion este activa

            BLL_Marca BLL_Marca = new BLL_Marca();
            MARCA Marca = BLL_Marca.GetMarcaByMarcaId(id);
            ViewBag.Estado = new SelectList(FuncionesEnum.ListaEnum<EnumEstados>(), "Value", "Text", (int)Marca.Estado);
            return View(Marca);
        }

        //Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MarcaUpdt(MARCA MARCA)
        {
            BLL_Login.VerificarSesionActiva();// valida que la sesion este activa

            ViewBag.Estado = new SelectList(FuncionesEnum.ListaEnum<EnumEstados>(), "Value", "Text", (int)MARCA.Estado);

            if (MARCA != null)
            {
                if (ModelState.IsValid)
                {
                    BLL_Marca BLL_Marca = new BLL_Marca();
                    if (BLL_Marca.ModificarMarca(MARCA))
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View(MARCA);
                    }
                }
                else
                {
                    return View(MARCA);
                }
            }
            else
            {
                return View(MARCA);
            }
        }


    }
}