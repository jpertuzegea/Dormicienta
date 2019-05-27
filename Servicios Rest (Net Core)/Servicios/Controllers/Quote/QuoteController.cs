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

namespace Servicios.Controllers.Quote
{
    public class QuoteController : Controller
    {
        private IConfiguration Configuration;
        BLL_Net.BLL_Quote BLL_Quote = null;
        public QuoteController(IConfiguration iConfig)
        {
            Configuration = iConfig;
            string EndPonit = Configuration.GetSection("AppSettings").GetSection("endPonitQuote").Value;
            string RutaLogs = Configuration.GetSection("AppSettings").GetSection("rutaLogs").Value;
            BLL_Quote = new BLL_Quote(EndPonit, RutaLogs);
        }



        [HttpPost]
        [Produces("application/json")]
        [Route("Quote/Quote")]
        [Authorize]
        public string Quote([FromBody] JObject jObject)
        { 
            return BLL_Quote.Quote(jObject);
        }




    }
}