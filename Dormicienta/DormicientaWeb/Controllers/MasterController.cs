using BLL_DORMISIENTA;
using DAO_DORMISIENTA.Enum;
using DAO_SONOLIENTA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace DormicientaWeb.Controllers
{
    public class MasterController : Controller
    {
        public ActionResult MasterMenu() {
            BLL_Categoria BLL_Categoria = new BLL_Categoria();
            List<CATEGORIA> Categorias = BLL_Categoria.ListarCategorias(EnumFiltroEstado.Activo);
            return PartialView(Categorias);
        }
    }
}
