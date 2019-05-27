using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;

namespace BLL_Net
{
    public class BLL_Policy
    {

        private WsPolicy.ExternalIssuanceServicesClient Cliente = null;
        private string RutaLog = "";

        public BLL_Policy(string EndPoint, string rutaLogs)
        {
            try
            {
                this.RutaLog = rutaLogs;
                // -------  se crean los objetos para el consumo del servicio
                BasicHttpBinding Binding1 = new BasicHttpBinding();
                Binding1.Name = "BasicHttpBinding_IExternalIssuanceServices";
                Binding1.MaxBufferSize = 2147483647;
                Binding1.MaxReceivedMessageSize = 2147483647;
                EndpointAddress Address = new EndpointAddress(EndPoint);
                Cliente = new WsPolicy.ExternalIssuanceServicesClient(Binding1, Address);
                // -------------------------------------------------------------------
            }
            catch (Exception Error)
            {
                BLL_Log.EscribirLog(RutaLog, Error.ToString());
                throw;
            }

        }



        public string PolicyIssuanceVehicle(/*WsPolicy.ExternalPolicyIssuanceVehicleRequest policyIssuanceVehicleRequest*/ JObject jObject)
        {
            try
            {// try por si la deserializacion del objeto falla con relacion al tipo de dato request
                WsPolicy.ExternalPolicyIssuanceVehicleRequest Request = JsonConvert.DeserializeObject<WsPolicy.ExternalPolicyIssuanceVehicleRequest>(jObject.ToString());
                System.Threading.Tasks.Task<WsPolicy.PolicyIssuanceVehicleResponse> Response = Cliente.PolicyIssuanceVehicleAsync(Request);
                Response.Wait(); 
                return JsonConvert.SerializeObject(Response.Result.Body);
            }
            catch (Exception Error)
            {
                BLL_Log.EscribirLog(RutaLog, Error.ToString()); // escribe el log del error 
                return JsonConvert.SerializeObject("Error Consumiendo Servicio");
            }
        }
    }
}
