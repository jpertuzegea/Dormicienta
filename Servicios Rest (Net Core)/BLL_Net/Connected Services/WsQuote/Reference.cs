//------------------------------------------------------------------------------
// <generado automáticamente>
//     Este código fue generado por una herramienta.
//     //
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </generado automáticamente>
//------------------------------------------------------------------------------

namespace WsQuote
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WsQuote.IWrapperService")]
    public interface IWrapperService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWrapperService/Quote", ReplyAction="http://tempuri.org/IWrapperService/QuoteResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<WsQuote.QuoteResponse> QuoteAsync(WsQuote.QuoteRequest quoteRequest);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class QuoteRequest
    {
        
        private InsuredQuotation insuredQuotationField;
        
        private PolicyQuotation policyQuotationField;
        
        private RiskQuotation riskQuotationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public InsuredQuotation insuredQuotation
        {
            get
            {
                return this.insuredQuotationField;
            }
            set
            {
                this.insuredQuotationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public PolicyQuotation policyQuotation
        {
            get
            {
                return this.policyQuotationField;
            }
            set
            {
                this.policyQuotationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public RiskQuotation riskQuotation
        {
            get
            {
                return this.riskQuotationField;
            }
            set
            {
                this.riskQuotationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class InsuredQuotation
    {
        
        private int typeCardCodeField;
        
        private string idCardNroField;
        
        private string genderField;
        
        private string nameField;
        
        private string surnameField;
        
        private System.DateTime birthDateField;
        
        private int maritalStatusField;
        
        private int stateCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int typeCardCode
        {
            get
            {
                return this.typeCardCodeField;
            }
            set
            {
                this.typeCardCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string idCardNro
        {
            get
            {
                return this.idCardNroField;
            }
            set
            {
                this.idCardNroField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string surname
        {
            get
            {
                return this.surnameField;
            }
            set
            {
                this.surnameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public System.DateTime birthDate
        {
            get
            {
                return this.birthDateField;
            }
            set
            {
                this.birthDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public int maritalStatus
        {
            get
            {
                return this.maritalStatusField;
            }
            set
            {
                this.maritalStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public int stateCode
        {
            get
            {
                return this.stateCodeField;
            }
            set
            {
                this.stateCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class QuoteResult
    {
        
        private int tempIdField;
        
        private int branchCodeField;
        
        private int sourceCodeField;
        
        private int businessIdField;
        
        private int requestIdField;
        
        private int productIdField;
        
        private string productIdResponseField;
        
        private System.DateTime currentFromField;
        
        private System.DateTime currentToField;
        
        private int userIdField;
        
        private string licensePlateField;
        
        private int coverGroupIdField;
        
        private int assistanceCodeField;
        
        private int limitRcCodeField;
        
        private decimal limitRcSumField;
        
        private int goodExperienceNumField;
        
        private System.Nullable<System.DateTime> maximumVigencyField;
        
        private string isEffectiveDateField;
        
        private int ratingZoneCodeField;
        
        private decimal vehiclePriceField;
        
        private decimal vehiclePriceDetailField;
        
        private decimal premiumAmountField;
        
        private decimal assistanceAmountField;
        
        private decimal expensesAmountField;
        
        private decimal taxAmountField;
        
        private decimal totalPremiumAmountField;
        
        private string processMessageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int TempId
        {
            get
            {
                return this.tempIdField;
            }
            set
            {
                this.tempIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int BranchCode
        {
            get
            {
                return this.branchCodeField;
            }
            set
            {
                this.branchCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int SourceCode
        {
            get
            {
                return this.sourceCodeField;
            }
            set
            {
                this.sourceCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int BusinessId
        {
            get
            {
                return this.businessIdField;
            }
            set
            {
                this.businessIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int RequestId
        {
            get
            {
                return this.requestIdField;
            }
            set
            {
                this.requestIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public int ProductId
        {
            get
            {
                return this.productIdField;
            }
            set
            {
                this.productIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string ProductIdResponse
        {
            get
            {
                return this.productIdResponseField;
            }
            set
            {
                this.productIdResponseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public System.DateTime CurrentFrom
        {
            get
            {
                return this.currentFromField;
            }
            set
            {
                this.currentFromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public System.DateTime CurrentTo
        {
            get
            {
                return this.currentToField;
            }
            set
            {
                this.currentToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public int UserId
        {
            get
            {
                return this.userIdField;
            }
            set
            {
                this.userIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string LicensePlate
        {
            get
            {
                return this.licensePlateField;
            }
            set
            {
                this.licensePlateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public int CoverGroupId
        {
            get
            {
                return this.coverGroupIdField;
            }
            set
            {
                this.coverGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public int AssistanceCode
        {
            get
            {
                return this.assistanceCodeField;
            }
            set
            {
                this.assistanceCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public int LimitRcCode
        {
            get
            {
                return this.limitRcCodeField;
            }
            set
            {
                this.limitRcCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public decimal LimitRcSum
        {
            get
            {
                return this.limitRcSumField;
            }
            set
            {
                this.limitRcSumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public int GoodExperienceNum
        {
            get
            {
                return this.goodExperienceNumField;
            }
            set
            {
                this.goodExperienceNumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=16)]
        public System.Nullable<System.DateTime> MaximumVigency
        {
            get
            {
                return this.maximumVigencyField;
            }
            set
            {
                this.maximumVigencyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=17)]
        public string IsEffectiveDate
        {
            get
            {
                return this.isEffectiveDateField;
            }
            set
            {
                this.isEffectiveDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=18)]
        public int RatingZoneCode
        {
            get
            {
                return this.ratingZoneCodeField;
            }
            set
            {
                this.ratingZoneCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=19)]
        public decimal VehiclePrice
        {
            get
            {
                return this.vehiclePriceField;
            }
            set
            {
                this.vehiclePriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=20)]
        public decimal VehiclePriceDetail
        {
            get
            {
                return this.vehiclePriceDetailField;
            }
            set
            {
                this.vehiclePriceDetailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=21)]
        public decimal PremiumAmount
        {
            get
            {
                return this.premiumAmountField;
            }
            set
            {
                this.premiumAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=22)]
        public decimal AssistanceAmount
        {
            get
            {
                return this.assistanceAmountField;
            }
            set
            {
                this.assistanceAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=23)]
        public decimal ExpensesAmount
        {
            get
            {
                return this.expensesAmountField;
            }
            set
            {
                this.expensesAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=24)]
        public decimal TaxAmount
        {
            get
            {
                return this.taxAmountField;
            }
            set
            {
                this.taxAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=25)]
        public decimal TotalPremiumAmount
        {
            get
            {
                return this.totalPremiumAmountField;
            }
            set
            {
                this.totalPremiumAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=26)]
        public string ProcessMessage
        {
            get
            {
                return this.processMessageField;
            }
            set
            {
                this.processMessageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class QuoteResponse
    {
        
        private QuoteResult[] listQuoteResultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        public QuoteResult[] listQuoteResult
        {
            get
            {
                return this.listQuoteResultField;
            }
            set
            {
                this.listQuoteResultField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class RiskQuotation
    {
        
        private string licensePlateField;
        
        private string engineSerialNumberField;
        
        private string chassisSerialNumberField;
        
        private string fasecoldaMakeIdField;
        
        private string fasecoldaModelIdField;
        
        private int vehicleUseCodeField;
        
        private int vehicleColorCodeField;
        
        private int vehicleYearField;
        
        private bool isNewField;
        
        private decimal vehiclePriceField;
        
        private decimal vehicleAmountDetailField;
        
        private System.Nullable<int> coverGroupIdField;
        
        private System.Nullable<int> assistanceCodeField;
        
        private int limitRcCodeField;
        
        private int ratingZoneCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string licensePlate
        {
            get
            {
                return this.licensePlateField;
            }
            set
            {
                this.licensePlateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string engineSerialNumber
        {
            get
            {
                return this.engineSerialNumberField;
            }
            set
            {
                this.engineSerialNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string chassisSerialNumber
        {
            get
            {
                return this.chassisSerialNumberField;
            }
            set
            {
                this.chassisSerialNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string fasecoldaMakeId
        {
            get
            {
                return this.fasecoldaMakeIdField;
            }
            set
            {
                this.fasecoldaMakeIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string fasecoldaModelId
        {
            get
            {
                return this.fasecoldaModelIdField;
            }
            set
            {
                this.fasecoldaModelIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public int vehicleUseCode
        {
            get
            {
                return this.vehicleUseCodeField;
            }
            set
            {
                this.vehicleUseCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public int vehicleColorCode
        {
            get
            {
                return this.vehicleColorCodeField;
            }
            set
            {
                this.vehicleColorCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public int vehicleYear
        {
            get
            {
                return this.vehicleYearField;
            }
            set
            {
                this.vehicleYearField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public bool isNew
        {
            get
            {
                return this.isNewField;
            }
            set
            {
                this.isNewField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public decimal vehiclePrice
        {
            get
            {
                return this.vehiclePriceField;
            }
            set
            {
                this.vehiclePriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public decimal vehicleAmountDetail
        {
            get
            {
                return this.vehicleAmountDetailField;
            }
            set
            {
                this.vehicleAmountDetailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=11)]
        public System.Nullable<int> coverGroupId
        {
            get
            {
                return this.coverGroupIdField;
            }
            set
            {
                this.coverGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=12)]
        public System.Nullable<int> assistanceCode
        {
            get
            {
                return this.assistanceCodeField;
            }
            set
            {
                this.assistanceCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public int limitRcCode
        {
            get
            {
                return this.limitRcCodeField;
            }
            set
            {
                this.limitRcCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public int ratingZoneCode
        {
            get
            {
                return this.ratingZoneCodeField;
            }
            set
            {
                this.ratingZoneCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class PolicyQuotation
    {
        
        private int sourceCodeField;
        
        private int businessIdField;
        
        private System.Nullable<int> productIdField;
        
        private System.Nullable<int> requestIdField;
        
        private int branchCodeField;
        
        private int policyTypeCodeField;
        
        private int agentCodeField;
        
        private int agentAgencyTypeCodeField;
        
        private System.Nullable<int> allianceIdField;
        
        private System.Nullable<int> allianceBranchIdField;
        
        private System.Nullable<int> allianceSalePointIdField;
        
        private System.Nullable<int> allianceProposalNumberField;
        
        private string accountNameField;
        
        private int currencyCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int sourceCode
        {
            get
            {
                return this.sourceCodeField;
            }
            set
            {
                this.sourceCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int businessId
        {
            get
            {
                return this.businessIdField;
            }
            set
            {
                this.businessIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public System.Nullable<int> productId
        {
            get
            {
                return this.productIdField;
            }
            set
            {
                this.productIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public System.Nullable<int> requestId
        {
            get
            {
                return this.requestIdField;
            }
            set
            {
                this.requestIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int branchCode
        {
            get
            {
                return this.branchCodeField;
            }
            set
            {
                this.branchCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public int policyTypeCode
        {
            get
            {
                return this.policyTypeCodeField;
            }
            set
            {
                this.policyTypeCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public int agentCode
        {
            get
            {
                return this.agentCodeField;
            }
            set
            {
                this.agentCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public int agentAgencyTypeCode
        {
            get
            {
                return this.agentAgencyTypeCodeField;
            }
            set
            {
                this.agentAgencyTypeCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=8)]
        public System.Nullable<int> allianceId
        {
            get
            {
                return this.allianceIdField;
            }
            set
            {
                this.allianceIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
        public System.Nullable<int> allianceBranchId
        {
            get
            {
                return this.allianceBranchIdField;
            }
            set
            {
                this.allianceBranchIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=10)]
        public System.Nullable<int> allianceSalePointId
        {
            get
            {
                return this.allianceSalePointIdField;
            }
            set
            {
                this.allianceSalePointIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=11)]
        public System.Nullable<int> allianceProposalNumber
        {
            get
            {
                return this.allianceProposalNumberField;
            }
            set
            {
                this.allianceProposalNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public string accountName
        {
            get
            {
                return this.accountNameField;
            }
            set
            {
                this.accountNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public int currencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface IWrapperServiceChannel : WsQuote.IWrapperService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class WrapperServiceClient : System.ServiceModel.ClientBase<WsQuote.IWrapperService>, WsQuote.IWrapperService
    {
        
    /// <summary>
    /// Implemente este método parcial para configurar el punto de conexión de servicio.
    /// </summary>
    /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
    /// <param name="clientCredentials">Credenciales de cliente</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public WrapperServiceClient() : 
                base(WrapperServiceClient.GetDefaultBinding(), WrapperServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IWrapperService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WrapperServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(WrapperServiceClient.GetBindingForEndpoint(endpointConfiguration), WrapperServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WrapperServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(WrapperServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WrapperServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(WrapperServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WrapperServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<WsQuote.QuoteResponse> QuoteAsync(WsQuote.QuoteRequest quoteRequest)
        {
            return base.Channel.QuoteAsync(quoteRequest);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IWrapperService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IWrapperService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:4000/External/WrapperService");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return WrapperServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IWrapperService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return WrapperServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IWrapperService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IWrapperService,
        }
    }
}
