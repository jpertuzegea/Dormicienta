using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL_Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Servicios.Controllers.Policy
{
    public class PolicyController : Controller
    {
        private IConfiguration Configuration;
        BLL_Net.BLL_Policy BLL_Policy = null;
        public PolicyController(IConfiguration iConfig)
        {
            Configuration = iConfig;
            string EndPonitPolicy = Configuration.GetSection("AppSettings").GetSection("endPonitPolicy").Value;
            string RutaLogs = Configuration.GetSection("AppSettings").GetSection("rutaLogs").Value;
            BLL_Policy = new BLL_Policy(EndPonitPolicy, RutaLogs);
        }



        [HttpPost]
        [Produces("application/json")]
        [Route("Policy/PolicyIssuanceVehicle")]
        [Authorize]
        public string PolicyIssuanceVehicle([FromBody] JObject jObject)
        {
            return BLL_Policy.PolicyIssuanceVehicle(jObject);

        }




    }
}