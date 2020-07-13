using BLL_DORMISIENTA;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DormicientaWeb.Controllers.Admin.WebApis
{
    public class ProductosWebApiController : ApiController
    {

        [HttpPost]
        [Route("ProductosWebApi/ValidarCodigo")]
        // [Authorize]
        public bool ValidarCodigo(JObject jObject)
        {
            try
            {
                BLL_Producto BLL_Producto = new BLL_Producto();
                return BLL_Producto.ValidarCodigoProducto(jObject["Codigo"].ToString());
            }
            catch (Exception error)
            {
                BLL_File.Escribir_Log(error.ToString());
                return false;
            }
        }
    }
}
