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

namespace Servicios.Controllers.Printer
{
    public class PrinterController : Controller
    {
        private IConfiguration Configuration;
        BLL_Printer BLL_Printer = null;
        public PrinterController(IConfiguration iConfig)
        {
            Configuration = iConfig;
            string EndPonit = Configuration.GetSection("AppSettings").GetSection("endPonitPrinter").Value;
            string RutaLogs = Configuration.GetSection("AppSettings").GetSection("rutaLogs").Value;
            BLL_Printer = new BLL_Printer(EndPonit, RutaLogs);
        }

        
        [HttpPost]
        [Produces("application/json")]
        [Route("Printer/GenerateWSTempPrinter")]
        [Authorize]
        public string GenerateWSTempPrinter([FromBody] JObject jObject)
        {
            return BLL_Printer.GenerateWSTempPrinter(jObject);
        }


        [HttpPost]
        [Produces("application/json")]
        [Route("Printer/GenerateWSQuotePrinter")]
        [Authorize]
        public string GenerateWSQuotePrinter([FromBody] JObject jObject)
        {
            return BLL_Printer.GenerateWSQuotePrinter(jObject);
        }


        [HttpPost]
        [Produces("application/json")]
        [Route("Printer/GenerateWSPolicyPrinter")]
        [Authorize]
        public string GenerateWSPolicyPrinter([FromBody] JObject jObject)
        {
            return BLL_Printer.GenerateWSPolicyPrinter(jObject);
        }


        [HttpPost]
        [Produces("application/json")]
        [Route("Printer/GenerateWSPolicyFormatCollect")]
        [Authorize]
        public string GenerateWSPolicyFormatCollect([FromBody] JObject jObject)
        {
            return BLL_Printer.GenerateWSPolicyFormatCollect(jObject);
        }

    }
}