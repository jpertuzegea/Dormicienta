using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL_Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Servicios.Helpers;

namespace Servicios.Controllers.Param
{
    public class ParamController : Controller
    {
        private IConfiguration Configuration;
        BLL_Net.BLL_Param Bll_Param = null;
        public ParamController(IConfiguration iConfig)
        {
            Configuration = iConfig;
            string EndPonitParam = Configuration.GetSection("AppSettings").GetSection("endPointParam").Value;
            string RutaLogs = Configuration.GetSection("AppSettings").GetSection("rutaLogs").Value;
            Bll_Param = new  BLL_Param(EndPonitParam, RutaLogs);
        }


        [HttpGet]
        [Produces("application/json")]
        [Route("Param/GenerateIdentityCardTypeList")]
        [Authorize]
        public string GenerateIdentityCardTypeList()
        {
            return Bll_Param.GenerateIdentityCardTypeList();
        }


        [HttpGet]
        [Produces("application/json")]
        [Route("Param/GenerateListAdressType")]
        [Authorize]
        public string GenerateListAdressType()
        {
            return Bll_Param.GenerateListAdressType();
        }


        [HttpGet]
        [Produces("application/json")]
        [Route("Param/GenerateListCompanyType")]
        [Authorize]
        public string GenerateListCompanyType()
        {
            return Bll_Param.GenerateListCompanyType();
        }


        [HttpGet]
        [Produces("application/json")]
        [Route("Param/GenerateListCountryStateCity")]
        [Authorize]
        public string GenerateListCountryStateCity()
        {
            return Bll_Param.GenerateListCountryStateCity();
        }


        [HttpGet]
        [Produces("application/json")]
        [Route("Param/GenerateListDetail")]
        [Authorize]
        public string GenerateListDetail()
        {
            return Bll_Param.GenerateListDetail();
        }


        [HttpGet]
        [Produces("application/json")]
        [Route("Param/GenerateListEconomicActivity")]
        [Authorize]
        public string GenerateListEconomicActivity()
        {
            return Bll_Param.GenerateListEconomicActivity();
        }


        [HttpPost]
        [Produces("application/json")]
        [Route("Param/GenerateListProduct")]
        [Authorize]
        public string GenerateListProduct([FromBody] JObject jObject)
        {
            return Bll_Param.GenerateListProduct(jObject);
        }


        [HttpGet]
        [Produces("application/json")]
        [Route("Param/GenerateRatingZoneList")]
        [Authorize]
        public string GenerateRatingZoneList()
        {
            return Bll_Param.GenerateRatingZoneList();
        }


        [HttpPost]
        [Produces("application/json")]
        [Route("Param/GenerateVehicleFasecolda")]
        [Authorize]
        public string GenerateVehicleFasecolda([FromBody] JObject jObject)
        {
            return Bll_Param.GenerateVehicleFasecolda(jObject);
        }


        [HttpPost]
        [Produces("application/json")]
        [Route("Param/GenerateVehiclesList")]
        [Authorize]
        public string GenerateVehiclesList([FromBody] JObject jObject)
        {
            return Bll_Param.GenerateVehiclesList(jObject);
        }


        [HttpGet]
        [Produces("application/json")]
        [Route("Param/GenereteListPhoneType")]
        [Authorize]
        public string GenereteListPhoneType()
        {
            return Bll_Param.GenereteListPhoneType();
        }


        [HttpPost]
        [Produces("application/json")]
        [Route("Param/Agent")]
        [Authorize]
        public string Agent([FromBody] JObject jObject)
        {
            return Bll_Param.GetAgent(jObject);
        }


        [HttpPost]
        [Produces("application/json")]
        [Route("Param/ListAssistance")]
        [Authorize]
        public string ListAssistance([FromBody] JObject jObject)
        {
            return Bll_Param.GetListAssistance(jObject);
        }


        [HttpPost]
        [Produces("application/json")]
        [Route("Param/ListAssistanceCover")]
        [Authorize]
        public string ListAssistanceCover([FromBody] JObject jObject)
        {
            return Bll_Param.GetListAssistanceCover(jObject);
        }

    }
}