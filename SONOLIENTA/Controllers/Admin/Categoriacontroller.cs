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
      
        public ActionResult Index()
        {
            BLL_Categoria BLL_Categoria = new BLL_Categoria();

            AssemblersCategoria AssemblersCategoria = new AssemblersCategoria();
            List<CategoriaModel> Categorias = AssemblersCategoria.List_de_entidades_a_modelos(BLL_Categoria.ListarCategorias());

            return View(Categorias);
        }
        
        // GET: CategoriaAdd
        public ActionResult CategoriaAdd()
        { 
            ViewBag.Estado = new SelectList(Funciones_Enum.mi_lista_enum<EnumEstados>(), "Value", "Text");
            return View();
        }

        // POST: CategoriaAdd
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CategoriaAdd(CategoriaModel CategoriaModel)
        {
            ViewBag.estado = new SelectList(Funciones_Enum.mi_lista_enum<Enum_Estados>(), "Value", "Text", (int)Departamento_Model.estado);

            if (ModelState.IsValid)
            {
                BLL_Categoria BLL_Categoria = new BLL_Categoria();
                if (BLL_Categoria.GuargarCategoria(CategoriaModel))
                {// pregunta si la funcion de creacion se ejecuto con exito
                    return RedirectToAction("Index");
                }
                else
                {// no creado
                    return View(CategoriaModel);
                }
            }
            else
            {
                return View(CategoriaModel);
            }
        }

        //Update
        [HttpGet]
        public ActionResult CategoriaUpdt(int IdCategoria)
        {  
            BLL_Categoria BLL_Categoria = new BLL_Categoria();
            CategoriaModel CategoriaModel = AssemblersCategoria.de_entidad_a_modelo(BLL_Categoria.GetCategoriaByCategoriaId(id));
            ViewBag.Estado = new SelectList(FuncionesEnum.mi_lista_enum<EnumEstados>(), "Value", "Text", (int)CategoriaModel.Estado);
            return View(CategoriaModel);
        }

        //Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CategoriaUpdt(CategoriaModel DCategoriaModel)
        {
           
            ViewBag.Estado = new SelectList(FuncionesEnum.mi_lista_enum<EnumEstados>(), "Value", "Text", (int)CategoriaModel.Estado);

            if (CategoriaModel != null)
            {
                if (ModelState.IsValid)
                {
                    BLL_Categoria BLL_Categoria = new BLL_Categoria();
                    if (BLL_Categoria.ModificarCategoria(CategoriaModel))
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View(CategoriaModel);
                    }
                }
                else
                {
                    return View(CategoriaModel);
                }
            }
            else
            {
                return View(CategoriaModel);
            }
        }

    }
}


