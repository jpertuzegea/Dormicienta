using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Text;
using static WsQuote.WrapperServiceClient;

namespace BLL_Net
{
    public class BLL_Quote
    {
        private WsQuote.WrapperServiceClient Cliente = null;
        private string RutaLog = "";

        public BLL_Quote(string EndPoint, string rutaLogs)
        {
            try
            {
                this.RutaLog = rutaLogs;
                Cliente = new WsQuote.WrapperServiceClient(
                    EndpointConfiguration.BasicHttpBinding_IWrapperService,
                    EndPoint);
            }
            catch (Exception Error)
            {
                BLL_Log.EscribirLog(RutaLog, Error.ToString());
                throw;
            }

        }

         

        public string Quote(JObject jObject)
        {
            try
            {
                WsQuote.QuoteRequest Request = JsonConvert.DeserializeObject<WsQuote.QuoteRequest>(jObject.ToString());
                System.Threading.Tasks.Task<WsQuote.QuoteResponse> Response = Cliente.QuoteAsync(Request);
                Response.Wait(); 
                return JsonConvert.SerializeObject(Response.Result.listQuoteResult);
            }
            catch (Exception Error)
            {
                BLL_Log.EscribirLog(RutaLog, Error.ToString()); // escribe el log del error 
                return JsonConvert.SerializeObject("Error Consumiendo Servicio");
            } 
        }

    }
}
