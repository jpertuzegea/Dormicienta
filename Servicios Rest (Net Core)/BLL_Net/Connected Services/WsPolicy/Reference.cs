//------------------------------------------------------------------------------
// <generado automáticamente>
//     Este código fue generado por una herramienta.
//     //
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </generado automáticamente>
//------------------------------------------------------------------------------

namespace WsPolicy
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExternalPolicyIssuanceVehicleRequest", Namespace="http://tempuri.org/")]
    public partial class ExternalPolicyIssuanceVehicleRequest : object
    {
        
        private int TempIdField;
        
        private System.DateTime CurrentFromField;
        
        private System.Nullable<int> PaymentScheduleCodeField;
        
        private WsPolicy.ExternalAlliance AllianceField;
        
        private bool IsHolderInsuredField;
        
        private WsPolicy.ExternalHolder HolderField;
        
        private WsPolicy.ExternalRiskVehicle RiskVehicleField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int TempId
        {
            get
            {
                return this.TempIdField;
            }
            set
            {
                this.TempIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public System.DateTime CurrentFrom
        {
            get
            {
                return this.CurrentFromField;
            }
            set
            {
                this.CurrentFromField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public System.Nullable<int> PaymentScheduleCode
        {
            get
            {
                return this.PaymentScheduleCodeField;
            }
            set
            {
                this.PaymentScheduleCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public WsPolicy.ExternalAlliance Alliance
        {
            get
            {
                return this.AllianceField;
            }
            set
            {
                this.AllianceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public bool IsHolderInsured
        {
            get
            {
                return this.IsHolderInsuredField;
            }
            set
            {
                this.IsHolderInsuredField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public WsPolicy.ExternalHolder Holder
        {
            get
            {
                return this.HolderField;
            }
            set
            {
                this.HolderField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public WsPolicy.ExternalRiskVehicle RiskVehicle
        {
            get
            {
                return this.RiskVehicleField;
            }
            set
            {
                this.RiskVehicleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExternalAlliance", Namespace="http://tempuri.org/")]
    public partial class ExternalAlliance : object
    {
        
        private int CodeField;
        
        private int BranchCodeField;
        
        private int SalePointCodeField;
        
        private int ProposalNumberField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Code
        {
            get
            {
                return this.CodeField;
            }
            set
            {
                this.CodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public int BranchCode
        {
            get
            {
                return this.BranchCodeField;
            }
            set
            {
                this.BranchCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int SalePointCode
        {
            get
            {
                return this.SalePointCodeField;
            }
            set
            {
                this.SalePointCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int ProposalNumber
        {
            get
            {
                return this.ProposalNumberField;
            }
            set
            {
                this.ProposalNumberField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExternalHolder", Namespace="http://tempuri.org/")]
    public partial class ExternalHolder : object
    {
        
        private WsPolicy.ExternalNaturalPerson NaturalPersonField;
        
        private WsPolicy.ExternalLegalPerson LegalPersonField;
        
        private WsPolicy.ExternalAddress AddressField;
        
        private WsPolicy.ExternalEmail EmailField;
        
        private WsPolicy.ExternalPhone PhoneField;
        
        private System.Nullable<bool> IsCommercialClientField;
        
        private System.Nullable<bool> IsSmsField;
        
        private System.Nullable<bool> IsMailAddressField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public WsPolicy.ExternalNaturalPerson NaturalPerson
        {
            get
            {
                return this.NaturalPersonField;
            }
            set
            {
                this.NaturalPersonField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public WsPolicy.ExternalLegalPerson LegalPerson
        {
            get
            {
                return this.LegalPersonField;
            }
            set
            {
                this.LegalPersonField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public WsPolicy.ExternalAddress Address
        {
            get
            {
                return this.AddressField;
            }
            set
            {
                this.AddressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public WsPolicy.ExternalEmail Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public WsPolicy.ExternalPhone Phone
        {
            get
            {
                return this.PhoneField;
            }
            set
            {
                this.PhoneField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public System.Nullable<bool> IsCommercialClient
        {
            get
            {
                return this.IsCommercialClientField;
            }
            set
            {
                this.IsCommercialClientField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public System.Nullable<bool> IsSms
        {
            get
            {
                return this.IsSmsField;
            }
            set
            {
                this.IsSmsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=7)]
        public System.Nullable<bool> IsMailAddress
        {
            get
            {
                return this.IsMailAddressField;
            }
            set
            {
                this.IsMailAddressField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExternalRiskVehicle", Namespace="http://tempuri.org/")]
    public partial class ExternalRiskVehicle : object
    {
        
        private string LicensePlateField;
        
        private string EngineSerialNumberField;
        
        private string ChassisSerialNumberField;
        
        private WsPolicy.ExternalInsured InsuredField;
        
        private bool IsInsuredBeneficiaryField;
        
        private WsPolicy.ExternalBeneficiary[] ListBeneficiaryField;
        
        private WsPolicy.ExternalAccesory[] ListAccesoryField;
        
        private string ObservationsField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string LicensePlate
        {
            get
            {
                return this.LicensePlateField;
            }
            set
            {
                this.LicensePlateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string EngineSerialNumber
        {
            get
            {
                return this.EngineSerialNumberField;
            }
            set
            {
                this.EngineSerialNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string ChassisSerialNumber
        {
            get
            {
                return this.ChassisSerialNumberField;
            }
            set
            {
                this.ChassisSerialNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public WsPolicy.ExternalInsured Insured
        {
            get
            {
                return this.InsuredField;
            }
            set
            {
                this.InsuredField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public bool IsInsuredBeneficiary
        {
            get
            {
                return this.IsInsuredBeneficiaryField;
            }
            set
            {
                this.IsInsuredBeneficiaryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public WsPolicy.ExternalBeneficiary[] ListBeneficiary
        {
            get
            {
                return this.ListBeneficiaryField;
            }
            set
            {
                this.ListBeneficiaryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public WsPolicy.ExternalAccesory[] ListAccesory
        {
            get
            {
                return this.ListAccesoryField;
            }
            set
            {
                this.ListAccesoryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string Observations
        {
            get
            {
                return this.ObservationsField;
            }
            set
            {
                this.ObservationsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExternalNaturalPerson", Namespace="http://tempuri.org/")]
    public partial class ExternalNaturalPerson : object
    {
        
        private int TypeCardCodeField;
        
        private string IdCardNoField;
        
        private string NameField;
        
        private string SurnameField;
        
        private string MotherLastNameField;
        
        private int MaritalStatusCodeField;
        
        private string GenderField;
        
        private System.DateTime BirthDateField;
        
        private int EconomicActivityCodeField;
        
        private int NationalityCodeField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int TypeCardCode
        {
            get
            {
                return this.TypeCardCodeField;
            }
            set
            {
                this.TypeCardCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string IdCardNo
        {
            get
            {
                return this.IdCardNoField;
            }
            set
            {
                this.IdCardNoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Surname
        {
            get
            {
                return this.SurnameField;
            }
            set
            {
                this.SurnameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string MotherLastName
        {
            get
            {
                return this.MotherLastNameField;
            }
            set
            {
                this.MotherLastNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public int MaritalStatusCode
        {
            get
            {
                return this.MaritalStatusCodeField;
            }
            set
            {
                this.MaritalStatusCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string Gender
        {
            get
            {
                return this.GenderField;
            }
            set
            {
                this.GenderField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=7)]
        public System.DateTime BirthDate
        {
            get
            {
                return this.BirthDateField;
            }
            set
            {
                this.BirthDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=8)]
        public int EconomicActivityCode
        {
            get
            {
                return this.EconomicActivityCodeField;
            }
            set
            {
                this.EconomicActivityCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=9)]
        public int NationalityCode
        {
            get
            {
                return this.NationalityCodeField;
            }
            set
            {
                this.NationalityCodeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExternalLegalPerson", Namespace="http://tempuri.org/")]
    public partial class ExternalLegalPerson : object
    {
        
        private int TributaryTypeCodeField;
        
        private string TributaryIdNoField;
        
        private string TradeNameField;
        
        private System.Nullable<int> CompanyTypeCodeField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int TributaryTypeCode
        {
            get
            {
                return this.TributaryTypeCodeField;
            }
            set
            {
                this.TributaryTypeCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string TributaryIdNo
        {
            get
            {
                return this.TributaryIdNoField;
            }
            set
            {
                this.TributaryIdNoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string TradeName
        {
            get
            {
                return this.TradeNameField;
            }
            set
            {
                this.TradeNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public System.Nullable<int> CompanyTypeCode
        {
            get
            {
                return this.CompanyTypeCodeField;
            }
            set
            {
                this.CompanyTypeCodeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExternalAddress", Namespace="http://tempuri.org/")]
    public partial class ExternalAddress : object
    {
        
        private int TypeCodeField;
        
        private string StreetField;
        
        private int CountryCodeField;
        
        private int StateCodeField;
        
        private int CityCodeField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int TypeCode
        {
            get
            {
                return this.TypeCodeField;
            }
            set
            {
                this.TypeCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Street
        {
            get
            {
                return this.StreetField;
            }
            set
            {
                this.StreetField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int CountryCode
        {
            get
            {
                return this.CountryCodeField;
            }
            set
            {
                this.CountryCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int StateCode
        {
            get
            {
                return this.StateCodeField;
            }
            set
            {
                this.StateCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int CityCode
        {
            get
            {
                return this.CityCodeField;
            }
            set
            {
                this.CityCodeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExternalEmail", Namespace="http://tempuri.org/")]
    public partial class ExternalEmail : object
    {
        
        private System.Nullable<int> TypeCodeField;
        
        private string EmailField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<int> TypeCode
        {
            get
            {
                return this.TypeCodeField;
            }
            set
            {
                this.TypeCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExternalPhone", Namespace="http://tempuri.org/")]
    public partial class ExternalPhone : object
    {
        
        private int TypeCodeField;
        
        private long NumberField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int TypeCode
        {
            get
            {
                return this.TypeCodeField;
            }
            set
            {
                this.TypeCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public long Number
        {
            get
            {
                return this.NumberField;
            }
            set
            {
                this.NumberField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExternalInsured", Namespace="http://tempuri.org/")]
    public partial class ExternalInsured : object
    {
        
        private WsPolicy.ExternalNaturalPerson NaturalPersonField;
        
        private WsPolicy.ExternalLegalPerson LegalPersonField;
        
        private WsPolicy.ExternalAddress AddressField;
        
        private WsPolicy.ExternalEmail EmailField;
        
        private WsPolicy.ExternalPhone PhoneField;
        
        private System.Nullable<bool> IsCommercialClientField;
        
        private System.Nullable<bool> IsSmsField;
        
        private System.Nullable<bool> IsMailAddressField;
        
        private int WorkerTypeCodeField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public WsPolicy.ExternalNaturalPerson NaturalPerson
        {
            get
            {
                return this.NaturalPersonField;
            }
            set
            {
                this.NaturalPersonField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public WsPolicy.ExternalLegalPerson LegalPerson
        {
            get
            {
                return this.LegalPersonField;
            }
            set
            {
                this.LegalPersonField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public WsPolicy.ExternalAddress Address
        {
            get
            {
                return this.AddressField;
            }
            set
            {
                this.AddressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public WsPolicy.ExternalEmail Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public WsPolicy.ExternalPhone Phone
        {
            get
            {
                return this.PhoneField;
            }
            set
            {
                this.PhoneField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public System.Nullable<bool> IsCommercialClient
        {
            get
            {
                return this.IsCommercialClientField;
            }
            set
            {
                this.IsCommercialClientField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public System.Nullable<bool> IsSms
        {
            get
            {
                return this.IsSmsField;
            }
            set
            {
                this.IsSmsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=7)]
        public System.Nullable<bool> IsMailAddress
        {
            get
            {
                return this.IsMailAddressField;
            }
            set
            {
                this.IsMailAddressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=8)]
        public int WorkerTypeCode
        {
            get
            {
                return this.WorkerTypeCodeField;
            }
            set
            {
                this.WorkerTypeCodeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExternalBeneficiary", Namespace="http://tempuri.org/")]
    public partial class ExternalBeneficiary : object
    {
        
        private int TypeCodeField;
        
        private WsPolicy.ExternalNaturalPerson NaturalPersonField;
        
        private WsPolicy.ExternalLegalPerson LegalPersonField;
        
        private WsPolicy.ExternalAddress AddressField;
        
        private WsPolicy.ExternalEmail EmailField;
        
        private WsPolicy.ExternalPhone PhoneField;
        
        private decimal ParticipationPctField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int TypeCode
        {
            get
            {
                return this.TypeCodeField;
            }
            set
            {
                this.TypeCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public WsPolicy.ExternalNaturalPerson NaturalPerson
        {
            get
            {
                return this.NaturalPersonField;
            }
            set
            {
                this.NaturalPersonField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public WsPolicy.ExternalLegalPerson LegalPerson
        {
            get
            {
                return this.LegalPersonField;
            }
            set
            {
                this.LegalPersonField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public WsPolicy.ExternalAddress Address
        {
            get
            {
                return this.AddressField;
            }
            set
            {
                this.AddressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public WsPolicy.ExternalEmail Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public WsPolicy.ExternalPhone Phone
        {
            get
            {
                return this.PhoneField;
            }
            set
            {
                this.PhoneField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public decimal ParticipationPct
        {
            get
            {
                return this.ParticipationPctField;
            }
            set
            {
                this.ParticipationPctField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExternalAccesory", Namespace="http://tempuri.org/")]
    public partial class ExternalAccesory : object
    {
        
        private int DetailCodeField;
        
        private string MakeDescriptionField;
        
        private string ModelDescriptionField;
        
        private decimal ValueField;
        
        private System.Nullable<bool> IsOriginalField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int DetailCode
        {
            get
            {
                return this.DetailCodeField;
            }
            set
            {
                this.DetailCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string MakeDescription
        {
            get
            {
                return this.MakeDescriptionField;
            }
            set
            {
                this.MakeDescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string ModelDescription
        {
            get
            {
                return this.ModelDescriptionField;
            }
            set
            {
                this.ModelDescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public decimal Value
        {
            get
            {
                return this.ValueField;
            }
            set
            {
                this.ValueField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public System.Nullable<bool> IsOriginal
        {
            get
            {
                return this.IsOriginalField;
            }
            set
            {
                this.IsOriginalField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExternalPolicyIssuanceVehicleResult", Namespace="http://tempuri.org/")]
    public partial class ExternalPolicyIssuanceVehicleResult : object
    {
        
        private long PolicyNumberField;
        
        private int BranchCodeField;
        
        private int PrefixCodeField;
        
        private int EndorsementNumberField;
        
        private int ProductIdField;
        
        private System.DateTime CurrentFromField;
        
        private System.DateTime CurrentToField;
        
        private string LicensePlateField;
        
        private decimal LimitRcSumField;
        
        private decimal VehiclePriceField;
        
        private decimal VehiclePriceDetailField;
        
        private decimal PremiumAmountField;
        
        private decimal AssistanceAmountField;
        
        private decimal ExpensesAmountField;
        
        private decimal TaxAmountField;
        
        private decimal TotalPremiumAmountField;
        
        private bool StatusField;
        
        private string ProcessMessageField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public long PolicyNumber
        {
            get
            {
                return this.PolicyNumberField;
            }
            set
            {
                this.PolicyNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public int BranchCode
        {
            get
            {
                return this.BranchCodeField;
            }
            set
            {
                this.BranchCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int PrefixCode
        {
            get
            {
                return this.PrefixCodeField;
            }
            set
            {
                this.PrefixCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int EndorsementNumber
        {
            get
            {
                return this.EndorsementNumberField;
            }
            set
            {
                this.EndorsementNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int ProductId
        {
            get
            {
                return this.ProductIdField;
            }
            set
            {
                this.ProductIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public System.DateTime CurrentFrom
        {
            get
            {
                return this.CurrentFromField;
            }
            set
            {
                this.CurrentFromField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public System.DateTime CurrentTo
        {
            get
            {
                return this.CurrentToField;
            }
            set
            {
                this.CurrentToField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string LicensePlate
        {
            get
            {
                return this.LicensePlateField;
            }
            set
            {
                this.LicensePlateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=8)]
        public decimal LimitRcSum
        {
            get
            {
                return this.LimitRcSumField;
            }
            set
            {
                this.LimitRcSumField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=9)]
        public decimal VehiclePrice
        {
            get
            {
                return this.VehiclePriceField;
            }
            set
            {
                this.VehiclePriceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=10)]
        public decimal VehiclePriceDetail
        {
            get
            {
                return this.VehiclePriceDetailField;
            }
            set
            {
                this.VehiclePriceDetailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=11)]
        public decimal PremiumAmount
        {
            get
            {
                return this.PremiumAmountField;
            }
            set
            {
                this.PremiumAmountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=12)]
        public decimal AssistanceAmount
        {
            get
            {
                return this.AssistanceAmountField;
            }
            set
            {
                this.AssistanceAmountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=13)]
        public decimal ExpensesAmount
        {
            get
            {
                return this.ExpensesAmountField;
            }
            set
            {
                this.ExpensesAmountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=14)]
        public decimal TaxAmount
        {
            get
            {
                return this.TaxAmountField;
            }
            set
            {
                this.TaxAmountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=15)]
        public decimal TotalPremiumAmount
        {
            get
            {
                return this.TotalPremiumAmountField;
            }
            set
            {
                this.TotalPremiumAmountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=16)]
        public bool Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                this.StatusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=17)]
        public string ProcessMessage
        {
            get
            {
                return this.ProcessMessageField;
            }
            set
            {
                this.ProcessMessageField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PolicyRenewalRequest", Namespace="http://tempuri.org/")]
    public partial class PolicyRenewalRequest : object
    {
        
        private int BranchCdField;
        
        private int PrefixCdField;
        
        private long DocumentNumberField;
        
        private string AccountNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int BranchCd
        {
            get
            {
                return this.BranchCdField;
            }
            set
            {
                this.BranchCdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int PrefixCd
        {
            get
            {
                return this.PrefixCdField;
            }
            set
            {
                this.PrefixCdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public long DocumentNumber
        {
            get
            {
                return this.DocumentNumberField;
            }
            set
            {
                this.DocumentNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string AccountName
        {
            get
            {
                return this.AccountNameField;
            }
            set
            {
                this.AccountNameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResponsePolicyRenewal", Namespace="http://tempuri.org/")]
    public partial class ResponsePolicyRenewal : object
    {
        
        private bool StateField;
        
        private string MessageField;
        
        private bool HasEventsField;
        
        private WsPolicy.Event[] EventsField;
        
        private int TempIdField;
        
        private int BranchCdField;
        
        private int PrefixCdField;
        
        private long DocumentNumberField;
        
        private int EndorsementNumberField;
        
        private decimal InsuredAmountField;
        
        private decimal PremiumAmountField;
        
        private decimal TaxAmountField;
        
        private decimal ExpensesAmountField;
        
        private bool IsBenfeficiaryOnerosoField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool State
        {
            get
            {
                return this.StateField;
            }
            set
            {
                this.StateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Message
        {
            get
            {
                return this.MessageField;
            }
            set
            {
                this.MessageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public bool HasEvents
        {
            get
            {
                return this.HasEventsField;
            }
            set
            {
                this.HasEventsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public WsPolicy.Event[] Events
        {
            get
            {
                return this.EventsField;
            }
            set
            {
                this.EventsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int TempId
        {
            get
            {
                return this.TempIdField;
            }
            set
            {
                this.TempIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public int BranchCd
        {
            get
            {
                return this.BranchCdField;
            }
            set
            {
                this.BranchCdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public int PrefixCd
        {
            get
            {
                return this.PrefixCdField;
            }
            set
            {
                this.PrefixCdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=7)]
        public long DocumentNumber
        {
            get
            {
                return this.DocumentNumberField;
            }
            set
            {
                this.DocumentNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=8)]
        public int EndorsementNumber
        {
            get
            {
                return this.EndorsementNumberField;
            }
            set
            {
                this.EndorsementNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=9)]
        public decimal InsuredAmount
        {
            get
            {
                return this.InsuredAmountField;
            }
            set
            {
                this.InsuredAmountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=10)]
        public decimal PremiumAmount
        {
            get
            {
                return this.PremiumAmountField;
            }
            set
            {
                this.PremiumAmountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=11)]
        public decimal TaxAmount
        {
            get
            {
                return this.TaxAmountField;
            }
            set
            {
                this.TaxAmountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=12)]
        public decimal ExpensesAmount
        {
            get
            {
                return this.ExpensesAmountField;
            }
            set
            {
                this.ExpensesAmountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=13)]
        public bool IsBenfeficiaryOneroso
        {
            get
            {
                return this.IsBenfeficiaryOnerosoField;
            }
            set
            {
                this.IsBenfeficiaryOnerosoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Event", Namespace="http://tempuri.org/")]
    public partial class Event : object
    {
        
        private int EventIdField;
        
        private string EventDescriptionField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int EventId
        {
            get
            {
                return this.EventIdField;
            }
            set
            {
                this.EventIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string EventDescription
        {
            get
            {
                return this.EventDescriptionField;
            }
            set
            {
                this.EventDescriptionField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PolicyRenewalByAllianceRequest", Namespace="http://tempuri.org/")]
    public partial class PolicyRenewalByAllianceRequest : object
    {
        
        private int AgentCdField;
        
        private int AgentTypeCdField;
        
        private int AllianceCodeField;
        
        private string ProposalNumberField;
        
        private string AccountNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int AgentCd
        {
            get
            {
                return this.AgentCdField;
            }
            set
            {
                this.AgentCdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int AgentTypeCd
        {
            get
            {
                return this.AgentTypeCdField;
            }
            set
            {
                this.AgentTypeCdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int AllianceCode
        {
            get
            {
                return this.AllianceCodeField;
            }
            set
            {
                this.AllianceCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string ProposalNumber
        {
            get
            {
                return this.ProposalNumberField;
            }
            set
            {
                this.ProposalNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string AccountName
        {
            get
            {
                return this.AccountNameField;
            }
            set
            {
                this.AccountNameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResponseFirmRenewalPolicy", Namespace="http://tempuri.org/")]
    public partial class ResponseFirmRenewalPolicy : object
    {
        
        private long DocumentNumberField;
        
        private int BranchIdField;
        
        private int PrefixNumField;
        
        private int EndorsementNumberField;
        
        private int ProductIdField;
        
        private System.DateTime CurrentFromField;
        
        private System.DateTime CurrentToField;
        
        private string LicensePlateField;
        
        private decimal LimitRcSumField;
        
        private decimal VehiclePriceField;
        
        private decimal VehiclePriceDetailField;
        
        private decimal PremiumAmountField;
        
        private decimal AssistanceAmountField;
        
        private decimal ExpensesAmountField;
        
        private decimal TaxAmountField;
        
        private decimal TotalPremiumAmountField;
        
        private int StatusField;
        
        private string ResultRenewalField;
        
        private bool HasEventsField;
        
        private WsPolicy.Event[] EventsField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public long DocumentNumber
        {
            get
            {
                return this.DocumentNumberField;
            }
            set
            {
                this.DocumentNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public int BranchId
        {
            get
            {
                return this.BranchIdField;
            }
            set
            {
                this.BranchIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int PrefixNum
        {
            get
            {
                return this.PrefixNumField;
            }
            set
            {
                this.PrefixNumField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int EndorsementNumber
        {
            get
            {
                return this.EndorsementNumberField;
            }
            set
            {
                this.EndorsementNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int ProductId
        {
            get
            {
                return this.ProductIdField;
            }
            set
            {
                this.ProductIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public System.DateTime CurrentFrom
        {
            get
            {
                return this.CurrentFromField;
            }
            set
            {
                this.CurrentFromField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public System.DateTime CurrentTo
        {
            get
            {
                return this.CurrentToField;
            }
            set
            {
                this.CurrentToField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string LicensePlate
        {
            get
            {
                return this.LicensePlateField;
            }
            set
            {
                this.LicensePlateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=8)]
        public decimal LimitRcSum
        {
            get
            {
                return this.LimitRcSumField;
            }
            set
            {
                this.LimitRcSumField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=9)]
        public decimal VehiclePrice
        {
            get
            {
                return this.VehiclePriceField;
            }
            set
            {
                this.VehiclePriceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=10)]
        public decimal VehiclePriceDetail
        {
            get
            {
                return this.VehiclePriceDetailField;
            }
            set
            {
                this.VehiclePriceDetailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=11)]
        public decimal PremiumAmount
        {
            get
            {
                return this.PremiumAmountField;
            }
            set
            {
                this.PremiumAmountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=12)]
        public decimal AssistanceAmount
        {
            get
            {
                return this.AssistanceAmountField;
            }
            set
            {
                this.AssistanceAmountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=13)]
        public decimal ExpensesAmount
        {
            get
            {
                return this.ExpensesAmountField;
            }
            set
            {
                this.ExpensesAmountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=14)]
        public decimal TaxAmount
        {
            get
            {
                return this.TaxAmountField;
            }
            set
            {
                this.TaxAmountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=15)]
        public decimal TotalPremiumAmount
        {
            get
            {
                return this.TotalPremiumAmountField;
            }
            set
            {
                this.TotalPremiumAmountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=16)]
        public int Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                this.StatusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=17)]
        public string ResultRenewal
        {
            get
            {
                return this.ResultRenewalField;
            }
            set
            {
                this.ResultRenewalField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=18)]
        public bool HasEvents
        {
            get
            {
                return this.HasEventsField;
            }
            set
            {
                this.HasEventsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=19)]
        public WsPolicy.Event[] Events
        {
            get
            {
                return this.EventsField;
            }
            set
            {
                this.EventsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResponseAuthorizationPolicies", Namespace="http://tempuri.org/")]
    public partial class ResponseAuthorizationPolicies : object
    {
        
        private int IdField;
        
        private int NumberField;
        
        private decimal DocumentNumberField;
        
        private int IdPrefixField;
        
        private int IdBranchField;
        
        private int UserIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Number
        {
            get
            {
                return this.NumberField;
            }
            set
            {
                this.NumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public decimal DocumentNumber
        {
            get
            {
                return this.DocumentNumberField;
            }
            set
            {
                this.DocumentNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int IdPrefix
        {
            get
            {
                return this.IdPrefixField;
            }
            set
            {
                this.IdPrefixField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int IdBranch
        {
            get
            {
                return this.IdBranchField;
            }
            set
            {
                this.IdBranchField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public int UserId
        {
            get
            {
                return this.UserIdField;
            }
            set
            {
                this.UserIdField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WsPolicy.IExternalIssuanceServices")]
    public interface IExternalIssuanceServices
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExternalIssuanceServices/PolicyIssuanceVehicle", ReplyAction="http://tempuri.org/IExternalIssuanceServices/PolicyIssuanceVehicleResponse")]
        System.Threading.Tasks.Task<WsPolicy.PolicyIssuanceVehicleResponse> PolicyIssuanceVehicleAsync(WsPolicy.PolicyIssuanceVehicleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExternalIssuanceServices/PolicyRenewal", ReplyAction="http://tempuri.org/IExternalIssuanceServices/PolicyRenewalResponse")]
        System.Threading.Tasks.Task<WsPolicy.PolicyRenewalResponse> PolicyRenewalAsync(WsPolicy.PolicyRenewalRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExternalIssuanceServices/PolicyRenewalByAlliance", ReplyAction="http://tempuri.org/IExternalIssuanceServices/PolicyRenewalByAllianceResponse")]
        System.Threading.Tasks.Task<WsPolicy.PolicyRenewalByAllianceResponse> PolicyRenewalByAllianceAsync(WsPolicy.PolicyRenewalByAllianceRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExternalIssuanceServices/FirmRenewalPolicy", ReplyAction="http://tempuri.org/IExternalIssuanceServices/FirmRenewalPolicyResponse")]
        System.Threading.Tasks.Task<WsPolicy.FirmRenewalPolicyResponse> FirmRenewalPolicyAsync(WsPolicy.FirmRenewalPolicyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExternalIssuanceServices/AuthorizationPolicies", ReplyAction="http://tempuri.org/IExternalIssuanceServices/AuthorizationPoliciesResponse")]
        System.Threading.Tasks.Task<WsPolicy.AuthorizationPoliciesResponse> AuthorizationPoliciesAsync(WsPolicy.AuthorizationPoliciesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExternalIssuanceServices/CreateEndorsementFromJson", ReplyAction="http://tempuri.org/IExternalIssuanceServices/CreateEndorsementFromJsonResponse")]
        System.Threading.Tasks.Task<WsPolicy.CreateEndorsementFromJsonResponse> CreateEndorsementFromJsonAsync(WsPolicy.CreateEndorsementFromJsonRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PolicyIssuanceVehicleRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PolicyIssuanceVehicle", Namespace="http://tempuri.org/", Order=0)]
        public WsPolicy.PolicyIssuanceVehicleRequestBody Body;
        
        public PolicyIssuanceVehicleRequest()
        {
        }
        
        public PolicyIssuanceVehicleRequest(WsPolicy.PolicyIssuanceVehicleRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class PolicyIssuanceVehicleRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WsPolicy.ExternalPolicyIssuanceVehicleRequest policyIssuanceVehicleRequest;
        
        public PolicyIssuanceVehicleRequestBody()
        {
        }
        
        public PolicyIssuanceVehicleRequestBody(WsPolicy.ExternalPolicyIssuanceVehicleRequest policyIssuanceVehicleRequest)
        {
            this.policyIssuanceVehicleRequest = policyIssuanceVehicleRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PolicyIssuanceVehicleResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PolicyIssuanceVehicleResponse", Namespace="http://tempuri.org/", Order=0)]
        public WsPolicy.PolicyIssuanceVehicleResponseBody Body;
        
        public PolicyIssuanceVehicleResponse()
        {
        }
        
        public PolicyIssuanceVehicleResponse(WsPolicy.PolicyIssuanceVehicleResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class PolicyIssuanceVehicleResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WsPolicy.ExternalPolicyIssuanceVehicleResult PolicyIssuanceVehicleResult;
        
        public PolicyIssuanceVehicleResponseBody()
        {
        }
        
        public PolicyIssuanceVehicleResponseBody(WsPolicy.ExternalPolicyIssuanceVehicleResult PolicyIssuanceVehicleResult)
        {
            this.PolicyIssuanceVehicleResult = PolicyIssuanceVehicleResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PolicyRenewalRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PolicyRenewal", Namespace="http://tempuri.org/", Order=0)]
        public WsPolicy.PolicyRenewalRequest1Body Body;
        
        public PolicyRenewalRequest1()
        {
        }
        
        public PolicyRenewalRequest1(WsPolicy.PolicyRenewalRequest1Body Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class PolicyRenewalRequest1Body
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WsPolicy.PolicyRenewalRequest policyRenewalRequest;
        
        public PolicyRenewalRequest1Body()
        {
        }
        
        public PolicyRenewalRequest1Body(WsPolicy.PolicyRenewalRequest policyRenewalRequest)
        {
            this.policyRenewalRequest = policyRenewalRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PolicyRenewalResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PolicyRenewalResponse", Namespace="http://tempuri.org/", Order=0)]
        public WsPolicy.PolicyRenewalResponseBody Body;
        
        public PolicyRenewalResponse()
        {
        }
        
        public PolicyRenewalResponse(WsPolicy.PolicyRenewalResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class PolicyRenewalResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WsPolicy.ResponsePolicyRenewal PolicyRenewalResult;
        
        public PolicyRenewalResponseBody()
        {
        }
        
        public PolicyRenewalResponseBody(WsPolicy.ResponsePolicyRenewal PolicyRenewalResult)
        {
            this.PolicyRenewalResult = PolicyRenewalResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PolicyRenewalByAllianceRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PolicyRenewalByAlliance", Namespace="http://tempuri.org/", Order=0)]
        public WsPolicy.PolicyRenewalByAllianceRequest1Body Body;
        
        public PolicyRenewalByAllianceRequest1()
        {
        }
        
        public PolicyRenewalByAllianceRequest1(WsPolicy.PolicyRenewalByAllianceRequest1Body Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class PolicyRenewalByAllianceRequest1Body
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WsPolicy.PolicyRenewalByAllianceRequest policyRenewalByAllianceRequest;
        
        public PolicyRenewalByAllianceRequest1Body()
        {
        }
        
        public PolicyRenewalByAllianceRequest1Body(WsPolicy.PolicyRenewalByAllianceRequest policyRenewalByAllianceRequest)
        {
            this.policyRenewalByAllianceRequest = policyRenewalByAllianceRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PolicyRenewalByAllianceResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PolicyRenewalByAllianceResponse", Namespace="http://tempuri.org/", Order=0)]
        public WsPolicy.PolicyRenewalByAllianceResponseBody Body;
        
        public PolicyRenewalByAllianceResponse()
        {
        }
        
        public PolicyRenewalByAllianceResponse(WsPolicy.PolicyRenewalByAllianceResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class PolicyRenewalByAllianceResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WsPolicy.ResponsePolicyRenewal PolicyRenewalByAllianceResult;
        
        public PolicyRenewalByAllianceResponseBody()
        {
        }
        
        public PolicyRenewalByAllianceResponseBody(WsPolicy.ResponsePolicyRenewal PolicyRenewalByAllianceResult)
        {
            this.PolicyRenewalByAllianceResult = PolicyRenewalByAllianceResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FirmRenewalPolicyRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FirmRenewalPolicy", Namespace="http://tempuri.org/", Order=0)]
        public WsPolicy.FirmRenewalPolicyRequestBody Body;
        
        public FirmRenewalPolicyRequest()
        {
        }
        
        public FirmRenewalPolicyRequest(WsPolicy.FirmRenewalPolicyRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FirmRenewalPolicyRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public System.Nullable<int> TempId;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public System.Nullable<int> BranchId;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public System.Nullable<int> PrefixNum;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public System.Nullable<long> DocumentNumber;
        
        public FirmRenewalPolicyRequestBody()
        {
        }
        
        public FirmRenewalPolicyRequestBody(System.Nullable<int> TempId, System.Nullable<int> BranchId, System.Nullable<int> PrefixNum, System.Nullable<long> DocumentNumber)
        {
            this.TempId = TempId;
            this.BranchId = BranchId;
            this.PrefixNum = PrefixNum;
            this.DocumentNumber = DocumentNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FirmRenewalPolicyResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FirmRenewalPolicyResponse", Namespace="http://tempuri.org/", Order=0)]
        public WsPolicy.FirmRenewalPolicyResponseBody Body;
        
        public FirmRenewalPolicyResponse()
        {
        }
        
        public FirmRenewalPolicyResponse(WsPolicy.FirmRenewalPolicyResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FirmRenewalPolicyResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WsPolicy.ResponseFirmRenewalPolicy FirmRenewalPolicyResult;
        
        public FirmRenewalPolicyResponseBody()
        {
        }
        
        public FirmRenewalPolicyResponseBody(WsPolicy.ResponseFirmRenewalPolicy FirmRenewalPolicyResult)
        {
            this.FirmRenewalPolicyResult = FirmRenewalPolicyResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AuthorizationPoliciesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AuthorizationPolicies", Namespace="http://tempuri.org/", Order=0)]
        public WsPolicy.AuthorizationPoliciesRequestBody Body;
        
        public AuthorizationPoliciesRequest()
        {
        }
        
        public AuthorizationPoliciesRequest(WsPolicy.AuthorizationPoliciesRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AuthorizationPoliciesRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int tempId;
        
        public AuthorizationPoliciesRequestBody()
        {
        }
        
        public AuthorizationPoliciesRequestBody(int tempId)
        {
            this.tempId = tempId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AuthorizationPoliciesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AuthorizationPoliciesResponse", Namespace="http://tempuri.org/", Order=0)]
        public WsPolicy.AuthorizationPoliciesResponseBody Body;
        
        public AuthorizationPoliciesResponse()
        {
        }
        
        public AuthorizationPoliciesResponse(WsPolicy.AuthorizationPoliciesResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AuthorizationPoliciesResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WsPolicy.ResponseAuthorizationPolicies AuthorizationPoliciesResult;
        
        public AuthorizationPoliciesResponseBody()
        {
        }
        
        public AuthorizationPoliciesResponseBody(WsPolicy.ResponseAuthorizationPolicies AuthorizationPoliciesResult)
        {
            this.AuthorizationPoliciesResult = AuthorizationPoliciesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateEndorsementFromJsonRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateEndorsementFromJson", Namespace="http://tempuri.org/", Order=0)]
        public WsPolicy.CreateEndorsementFromJsonRequestBody Body;
        
        public CreateEndorsementFromJsonRequest()
        {
        }
        
        public CreateEndorsementFromJsonRequest(WsPolicy.CreateEndorsementFromJsonRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CreateEndorsementFromJsonRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string listCompanyVehicleLikeJson;
        
        public CreateEndorsementFromJsonRequestBody()
        {
        }
        
        public CreateEndorsementFromJsonRequestBody(string listCompanyVehicleLikeJson)
        {
            this.listCompanyVehicleLikeJson = listCompanyVehicleLikeJson;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateEndorsementFromJsonResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateEndorsementFromJsonResponse", Namespace="http://tempuri.org/", Order=0)]
        public WsPolicy.CreateEndorsementFromJsonResponseBody Body;
        
        public CreateEndorsementFromJsonResponse()
        {
        }
        
        public CreateEndorsementFromJsonResponse(WsPolicy.CreateEndorsementFromJsonResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class CreateEndorsementFromJsonResponseBody
    {
        
        public CreateEndorsementFromJsonResponseBody()
        {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface IExternalIssuanceServicesChannel : WsPolicy.IExternalIssuanceServices, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class ExternalIssuanceServicesClient : System.ServiceModel.ClientBase<WsPolicy.IExternalIssuanceServices>, WsPolicy.IExternalIssuanceServices
    {
        
        public ExternalIssuanceServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WsPolicy.PolicyIssuanceVehicleResponse> WsPolicy.IExternalIssuanceServices.PolicyIssuanceVehicleAsync(WsPolicy.PolicyIssuanceVehicleRequest request)
        {
            return base.Channel.PolicyIssuanceVehicleAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsPolicy.PolicyIssuanceVehicleResponse> PolicyIssuanceVehicleAsync(WsPolicy.ExternalPolicyIssuanceVehicleRequest policyIssuanceVehicleRequest)
        {
            WsPolicy.PolicyIssuanceVehicleRequest inValue = new WsPolicy.PolicyIssuanceVehicleRequest();
            inValue.Body = new WsPolicy.PolicyIssuanceVehicleRequestBody();
            inValue.Body.policyIssuanceVehicleRequest = policyIssuanceVehicleRequest;
            return ((WsPolicy.IExternalIssuanceServices)(this)).PolicyIssuanceVehicleAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WsPolicy.PolicyRenewalResponse> WsPolicy.IExternalIssuanceServices.PolicyRenewalAsync(WsPolicy.PolicyRenewalRequest1 request)
        {
            return base.Channel.PolicyRenewalAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsPolicy.PolicyRenewalResponse> PolicyRenewalAsync(WsPolicy.PolicyRenewalRequest policyRenewalRequest)
        {
            WsPolicy.PolicyRenewalRequest1 inValue = new WsPolicy.PolicyRenewalRequest1();
            inValue.Body = new WsPolicy.PolicyRenewalRequest1Body();
            inValue.Body.policyRenewalRequest = policyRenewalRequest;
            return ((WsPolicy.IExternalIssuanceServices)(this)).PolicyRenewalAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WsPolicy.PolicyRenewalByAllianceResponse> WsPolicy.IExternalIssuanceServices.PolicyRenewalByAllianceAsync(WsPolicy.PolicyRenewalByAllianceRequest1 request)
        {
            return base.Channel.PolicyRenewalByAllianceAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsPolicy.PolicyRenewalByAllianceResponse> PolicyRenewalByAllianceAsync(WsPolicy.PolicyRenewalByAllianceRequest policyRenewalByAllianceRequest)
        {
            WsPolicy.PolicyRenewalByAllianceRequest1 inValue = new WsPolicy.PolicyRenewalByAllianceRequest1();
            inValue.Body = new WsPolicy.PolicyRenewalByAllianceRequest1Body();
            inValue.Body.policyRenewalByAllianceRequest = policyRenewalByAllianceRequest;
            return ((WsPolicy.IExternalIssuanceServices)(this)).PolicyRenewalByAllianceAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WsPolicy.FirmRenewalPolicyResponse> WsPolicy.IExternalIssuanceServices.FirmRenewalPolicyAsync(WsPolicy.FirmRenewalPolicyRequest request)
        {
            return base.Channel.FirmRenewalPolicyAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsPolicy.FirmRenewalPolicyResponse> FirmRenewalPolicyAsync(System.Nullable<int> TempId, System.Nullable<int> BranchId, System.Nullable<int> PrefixNum, System.Nullable<long> DocumentNumber)
        {
            WsPolicy.FirmRenewalPolicyRequest inValue = new WsPolicy.FirmRenewalPolicyRequest();
            inValue.Body = new WsPolicy.FirmRenewalPolicyRequestBody();
            inValue.Body.TempId = TempId;
            inValue.Body.BranchId = BranchId;
            inValue.Body.PrefixNum = PrefixNum;
            inValue.Body.DocumentNumber = DocumentNumber;
            return ((WsPolicy.IExternalIssuanceServices)(this)).FirmRenewalPolicyAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WsPolicy.AuthorizationPoliciesResponse> WsPolicy.IExternalIssuanceServices.AuthorizationPoliciesAsync(WsPolicy.AuthorizationPoliciesRequest request)
        {
            return base.Channel.AuthorizationPoliciesAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsPolicy.AuthorizationPoliciesResponse> AuthorizationPoliciesAsync(int tempId)
        {
            WsPolicy.AuthorizationPoliciesRequest inValue = new WsPolicy.AuthorizationPoliciesRequest();
            inValue.Body = new WsPolicy.AuthorizationPoliciesRequestBody();
            inValue.Body.tempId = tempId;
            return ((WsPolicy.IExternalIssuanceServices)(this)).AuthorizationPoliciesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WsPolicy.CreateEndorsementFromJsonResponse> WsPolicy.IExternalIssuanceServices.CreateEndorsementFromJsonAsync(WsPolicy.CreateEndorsementFromJsonRequest request)
        {
            return base.Channel.CreateEndorsementFromJsonAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsPolicy.CreateEndorsementFromJsonResponse> CreateEndorsementFromJsonAsync(string listCompanyVehicleLikeJson)
        {
            WsPolicy.CreateEndorsementFromJsonRequest inValue = new WsPolicy.CreateEndorsementFromJsonRequest();
            inValue.Body = new WsPolicy.CreateEndorsementFromJsonRequestBody();
            inValue.Body.listCompanyVehicleLikeJson = listCompanyVehicleLikeJson;
            return ((WsPolicy.IExternalIssuanceServices)(this)).CreateEndorsementFromJsonAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
    }
}
