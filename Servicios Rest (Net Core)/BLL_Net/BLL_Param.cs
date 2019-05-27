using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Net
{
    public class BLL_Param
    {
        private WsParam.ExternalParamServiceClient Cliente = null;
        private string RutaLog = "";

        public BLL_Param(string EndPointParam, string rutaLogs)
        {
            try
            {
                this.RutaLog = rutaLogs;
                Cliente = new WsParam.ExternalParamServiceClient(
                     WsParam.ExternalParamServiceClient.EndpointConfiguration.BasicHttpBinding_IExternalParamService1,
                     EndPointParam);
            }
            catch (Exception Error)
            {
                BLL_Log.EscribirLog(RutaLog, Error.ToString());
                throw;
            }

        }

        public string GenerateIdentityCardTypeList()
        {
            try
            {// try por si la deserializacion del objeto falla con relacion al tipo de dato request
                System.Threading.Tasks.Task<WsParam.GenerateIdentityCardTypeListResponse> Response = Cliente.GenerateIdentityCardTypeListAsync();
                Response.Wait();
                return JsonConvert.SerializeObject(Response.Result.Body.GenerateIdentityCardTypeListResult);
            }
            catch (Exception Error)
            {
                BLL_Log.EscribirLog(RutaLog, Error.ToString()); // escribe el log del Error 
                return JsonConvert.SerializeObject("Error Consumiendo Servicio");
            }
        }

        public string GenerateListAdressType()
        {
            try
            {
                System.Threading.Tasks.Task<WsParam.GenerateListAdressTypeResponse> Response = Cliente.GenerateListAdressTypeAsync();
                Response.Wait();
                return JsonConvert.SerializeObject(Response.Result.Body.GenerateListAdressTypeResult);
            }
            catch (Exception Error)
            {
                BLL_Log.EscribirLog(RutaLog, Error.ToString()); // escribe el log del Error 
                return JsonConvert.SerializeObject("Error Consumiendo Servicio");
            }
        }

        public string GenerateListCompanyType()
        {
            try
            {
                System.Threading.Tasks.Task<WsParam.GenerateListCompanyTypeResponse> Response = Cliente.GenerateListCompanyTypeAsync();
                Response.Wait();
                return JsonConvert.SerializeObject(Response.Result.Body.GenerateListCompanyTypeResult);
            }
            catch (Exception Error)
            {
                BLL_Log.EscribirLog(RutaLog, Error.ToString()); // escribe el log del Error 
                return JsonConvert.SerializeObject("Error Consumiendo Servicio");
            }
        }

        public string GenerateListCountryStateCity()
        {
            try
            {
                System.Threading.Tasks.Task<WsParam.GenerateListCountryStateCityResponse> Response = Cliente.GenerateListCountryStateCityAsync();
                Response.Wait();
                return JsonConvert.SerializeObject(Response.Result.Body.GenerateListCountryStateCityResult);
            }
            catch (Exception Error)
            {
                BLL_Log.EscribirLog(RutaLog, Error.ToString()); // escribe el log del Error 
                return JsonConvert.SerializeObject("Error Consumiendo Servicio");
            }
        }

        public string GenerateListDetail()
        {
            try
            {
                System.Threading.Tasks.Task<WsParam.GenerateListDetailResponse> Response = Cliente.GenerateListDetailAsync();
                Response.Wait();
                return JsonConvert.SerializeObject(Response.Result.Body.GenerateListDetailResult);
            }
            catch (Exception Error)
            {
                BLL_Log.EscribirLog(RutaLog, Error.ToString()); // escribe el log del Error 
                return JsonConvert.SerializeObject("Error Consumiendo Servicio");
            }
        }

        public string GenerateListEconomicActivity()
        {
            try
            {
                System.Threading.Tasks.Task<WsParam.GenerateListEconomicActivityResponse> Response = Cliente.GenerateListEconomicActivityAsync();
                Response.Wait();
                return JsonConvert.SerializeObject(Response.Result.Body.GenerateListEconomicActivityResult);
            }
            catch (Exception Error)
            {
                BLL_Log.EscribirLog(RutaLog, Error.ToString()); // escribe el log del Error 
                return JsonConvert.SerializeObject("Error Consumiendo Servicio");
            }
        }

        public string GenerateListProduct(JObject jObject)
        {
            try
            {// try por si la deserializacion del objeto falla con relacion al tipo de dato request

                System.Threading.Tasks.Task<WsParam.GenerateListProductResponse> Response = Cliente.GenerateListProductAsync((int)jObject["prefixCd"]);
                Response.Wait();
                return JsonConvert.SerializeObject(Response.Result.Body);
            }
            catch (Exception Error)
            {
                BLL_Log.EscribirLog(RutaLog, Error.ToString()); // escribe el log del Error 
                return JsonConvert.SerializeObject("Error Consumiendo Servicio");
            }

        }

        public string GenerateRatingZoneList()
        {
            try
            {// try por si la deserializacion del objeto falla con relacion al tipo de dato request

                System.Threading.Tasks.Task<WsParam.GenerateRatingZoneListResponse> Response = Cliente.GenerateRatingZoneListAsync();
                Response.Wait();
                return JsonConvert.SerializeObject(Response.Result.Body.GenerateRatingZoneListResult);
            }
            catch (Exception Error)
            {
                BLL_Log.EscribirLog(RutaLog, Error.ToString()); // escribe el log del Error 
                return JsonConvert.SerializeObject("Error Consumiendo Servicio");
            }
        }

        public string GenerateVehicleFasecolda(JObject jObject)
        {
            try
            {// try por si la deserializacion del objeto falla con relacion al tipo de dato request 
                System.Threading.Tasks.Task<WsParam.GenerateVehicleFasecoldaResponse> Response = Cliente.GenerateVehicleFasecoldaAsync(jObject["fasecoldaCd"].ToString(), (int)jObject["yearVehicle"]);
                Response.Wait();
                return JsonConvert.SerializeObject(Response.Result.Body.GenerateVehicleFasecoldaResult);
            }
            catch (Exception Error)
            {
                BLL_Log.EscribirLog(RutaLog, Error.ToString()); // escribe el log del Error 
                return JsonConvert.SerializeObject("Error Consumiendo Servicio");
            }
        }

        public string GenerateVehiclesList(JObject jObject)
        {
            try
            {// try por si la deserializacion del objeto falla con relacion al tipo de dato request 
                System.Threading.Tasks.Task<WsParam.GenerateVehiclesListResponse> Response = Cliente.GenerateVehiclesListAsync((int)jObject["vehicleYearInit"], (int)jObject["vehicleYearEnd"]);
                Response.Wait();
                return JsonConvert.SerializeObject(Response.Result.Body.GenerateVehiclesListResult);
            }
            catch (Exception Error)
            {
                BLL_Log.EscribirLog(RutaLog, Error.ToString()); // escribe el log del Error 
                return JsonConvert.SerializeObject("Error Consumiendo Servicio");
            }
        }

        public string GenereteListPhoneType()
        {
            try
            {// try por si la deserializacion del objeto falla con relacion al tipo de dato request 
                System.Threading.Tasks.Task<WsParam.GenereteListPhoneTypeResponse> Response = Cliente.GenereteListPhoneTypeAsync();
                Response.Wait();
                return JsonConvert.SerializeObject(Response.Result.Body.GenereteListPhoneTypeResult);
            }
            catch (Exception Error)
            {
                BLL_Log.EscribirLog(RutaLog, Error.ToString()); // escribe el log del Error 
                return JsonConvert.SerializeObject("Error Consumiendo Servicio");
            }
        }

        public string GetAgent(JObject jObject)
        {
            try
            {// try por si la deserializacion del objeto falla con relacion al tipo de dato request 
                System.Threading.Tasks.Task<WsParam.GetAgentResponse> Response = Cliente.GetAgentAsync((int)jObject["agentCode"]);
                Response.Wait();
                return JsonConvert.SerializeObject(Response.Result.Body.GetAgentResult);
            }
            catch (Exception Error)
            {
                BLL_Log.EscribirLog(RutaLog, Error.ToString()); // escribe el log del Error 
                return JsonConvert.SerializeObject("Error Consumiendo Servicio");
            }
        }

        public string GetListAssistance(JObject jObject)
        {
            try
            {// try por si la deserializacion del objeto falla con relacion al tipo de dato request 
                System.Threading.Tasks.Task<WsParam.GetListAssistanceResponse> Response = Cliente.GetListAssistanceAsync((int)jObject["prefixCd"], (int)jObject["productCd"]);
                Response.Wait();
                return JsonConvert.SerializeObject(Response.Result.Body.GetListAssistanceResult);
            }
            catch (Exception Error)
            {
                BLL_Log.EscribirLog(RutaLog, Error.ToString()); // escribe el log del Error 
                return JsonConvert.SerializeObject("Error Consumiendo Servicio");
            }

        }

        public string GetListAssistanceCover(JObject jObject)
        {
            try
            {// try por si la deserializacion del objeto falla con relacion al tipo de dato request 
                System.Threading.Tasks.Task<WsParam.GetListAssistanceCoverResponse> Response = Cliente.GetListAssistanceCoverAsync((int)jObject["assistanceCd"], (int)jObject["prefixCd"]);
                Response.Wait();
                return JsonConvert.SerializeObject(Response.Result.Body.GetListAssistanceCoverResult);
            }
            catch (Exception Error)
            {
                BLL_Log.EscribirLog(RutaLog, Error.ToString()); // escribe el log del Error 
                return JsonConvert.SerializeObject("Error Consumiendo Servicio");
            }
        }

    }
}