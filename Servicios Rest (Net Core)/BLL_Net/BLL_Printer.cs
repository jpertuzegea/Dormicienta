using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Net
{
    public class BLL_Printer
    {

        private WsPrinter.ExternalPrinterServiceClient Cliente = null;
        private string RutaLog = "";

        public BLL_Printer(string EndPoint, string rutaLogs)
        {
            try
            {
                this.RutaLog = rutaLogs;
                Cliente = new WsPrinter.ExternalPrinterServiceClient(
                    WsPrinter.ExternalPrinterServiceClient.EndpointConfiguration.BasicHttpBinding_IExternalPrinterService,
                    EndPoint);
            }
            catch (Exception Error)
            {
                BLL_Log.EscribirLog(RutaLog, Error.ToString());
                throw;
            }
        }

        public string GenerateWSTempPrinter(JObject jObject)
        {
            try
            {// try por si la deserializacion del objeto falla con relacion al tipo de dato request
                WsPrinter.GenerateWSTempPrinterRequest Request = JsonConvert.DeserializeObject<WsPrinter.GenerateWSTempPrinterRequest>(jObject.ToString());
                System.Threading.Tasks.Task<WsPrinter.GenerateWSTempPrinterResponse> Response = Cliente.GenerateWSTempPrinterAsync(Request);
                Response.Wait();
                return JsonConvert.SerializeObject(Response.Result.Body);
            }
            catch (Exception Error)
            {
                BLL_Log.EscribirLog(RutaLog, Error.ToString()); // escribe el log del Error 
                return JsonConvert.SerializeObject("Error Consumiendo Servicio");
            }
        }

        public string GenerateWSQuotePrinter(JObject jObject)
        {
            try
            {// try por si la deserializacion del objeto falla con relacion al tipo de dato request
                WsPrinter.GenerateWSQuotePrinterRequest Request = JsonConvert.DeserializeObject<WsPrinter.GenerateWSQuotePrinterRequest>(jObject.ToString());
                System.Threading.Tasks.Task<WsPrinter.GenerateWSQuotePrinterResponse> Response = Cliente.GenerateWSQuotePrinterAsync(Request);
                Response.Wait();
                return JsonConvert.SerializeObject(Response.Result.Body);
            }
            catch (Exception Error)
            {
                BLL_Log.EscribirLog(RutaLog, Error.ToString()); // escribe el log del Error 
                return JsonConvert.SerializeObject("Error Consumiendo Servicio");
            }

        }

        public string GenerateWSPolicyPrinter(JObject jObject)
        {
            try
            {// try por si la deserializacion del objeto falla con relacion al tipo de dato request

                WsPrinter.GenerateWSPolicyPrinterRequest Request = JsonConvert.DeserializeObject<WsPrinter.GenerateWSPolicyPrinterRequest>(jObject.ToString());
                System.Threading.Tasks.Task<WsPrinter.GenerateWSPolicyPrinterResponse> Response = Cliente.GenerateWSPolicyPrinterAsync(Request);
                Response.Wait();
                return JsonConvert.SerializeObject(Response.Result.Body);
            }
            catch (Exception Error)
            {
                BLL_Log.EscribirLog(RutaLog, Error.ToString()); // escribe el log del Error 
                return JsonConvert.SerializeObject("Error Consumiendo Servicio");
            }
        }

        public string GenerateWSPolicyFormatCollect(JObject jObject)
        {
            try
            {// try por si la deserializacion del objeto falla con relacion al tipo de dato request

                WsPrinter.GenerateWSPolicyFormatCollectRequest Request = JsonConvert.DeserializeObject<WsPrinter.GenerateWSPolicyFormatCollectRequest>(jObject.ToString());
                System.Threading.Tasks.Task<WsPrinter.GenerateWSPolicyFormatCollectResponse> Response = Cliente.GenerateWSPolicyFormatCollectAsync(Request);
                Response.Wait();
                return JsonConvert.SerializeObject(Response.Result.Body);
            }
            catch (Exception Error)
            {
                BLL_Log.EscribirLog(RutaLog, Error.ToString()); // escribe el log del Error 
                return JsonConvert.SerializeObject("Error Consumiendo Servicio");
            }
        }

    }
}
