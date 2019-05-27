//------------------------------------------------------------------------------
// <generado automáticamente>
//     Este código fue generado por una herramienta.
//     //
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </generado automáticamente>
//------------------------------------------------------------------------------

namespace WsParam
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="QuoteParamIdentityCardClass", Namespace="http://tempuri.org/")]
    public partial class QuoteParamIdentityCardClass : object
    {
        
        private string ProcessMessageField;
        
        private WsParam.IdentityCardTypeClass[] IdentityCardListField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public WsParam.IdentityCardTypeClass[] IdentityCardList
        {
            get
            {
                return this.IdentityCardListField;
            }
            set
            {
                this.IdentityCardListField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="IdentityCardTypeClass", Namespace="http://tempuri.org/")]
    public partial class IdentityCardTypeClass : object
    {
        
        private int IdentityCardTypeIdField;
        
        private string DescriptionField;
        
        private string SmallDescriptionField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int IdentityCardTypeId
        {
            get
            {
                return this.IdentityCardTypeIdField;
            }
            set
            {
                this.IdentityCardTypeIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string SmallDescription
        {
            get
            {
                return this.SmallDescriptionField;
            }
            set
            {
                this.SmallDescriptionField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ParamAddressType", Namespace="http://tempuri.org/")]
    public partial class ParamAddressType : object
    {
        
        private WsParam.AddressTypeClass[] AddressTypeListField;
        
        private string ProcessMessageField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public WsParam.AddressTypeClass[] AddressTypeList
        {
            get
            {
                return this.AddressTypeListField;
            }
            set
            {
                this.AddressTypeListField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AddressTypeClass", Namespace="http://tempuri.org/")]
    public partial class AddressTypeClass : object
    {
        
        private int AddressTypeCdField;
        
        private string DescriptionField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int AddressTypeCd
        {
            get
            {
                return this.AddressTypeCdField;
            }
            set
            {
                this.AddressTypeCdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ParamCompanyType", Namespace="http://tempuri.org/")]
    public partial class ParamCompanyType : object
    {
        
        private WsParam.CompanyTypeClass[] CompanyTypeClassField;
        
        private string ProcessMessageField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public WsParam.CompanyTypeClass[] CompanyTypeClass
        {
            get
            {
                return this.CompanyTypeClassField;
            }
            set
            {
                this.CompanyTypeClassField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CompanyTypeClass", Namespace="http://tempuri.org/")]
    public partial class CompanyTypeClass : object
    {
        
        private int CompanyTypeCdField;
        
        private string DescriptionField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int CompanyTypeCd
        {
            get
            {
                return this.CompanyTypeCdField;
            }
            set
            {
                this.CompanyTypeCdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ParamListDetail", Namespace="http://tempuri.org/")]
    public partial class ParamListDetail : object
    {
        
        private string ProcessMessageField;
        
        private WsParam.ListDetailClass[] ListDetailListField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public WsParam.ListDetailClass[] ListDetailList
        {
            get
            {
                return this.ListDetailListField;
            }
            set
            {
                this.ListDetailListField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ListDetailClass", Namespace="http://tempuri.org/")]
    public partial class ListDetailClass : object
    {
        
        private int AccesoryCodeField;
        
        private string DescriptionField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int AccesoryCode
        {
            get
            {
                return this.AccesoryCodeField;
            }
            set
            {
                this.AccesoryCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ParamEconomicActivity", Namespace="http://tempuri.org/")]
    public partial class ParamEconomicActivity : object
    {
        
        private WsParam.EconomicActivityClass[] EconomicActivityClassField;
        
        private string ProcessMessageField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public WsParam.EconomicActivityClass[] EconomicActivityClass
        {
            get
            {
                return this.EconomicActivityClassField;
            }
            set
            {
                this.EconomicActivityClassField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="EconomicActivityClass", Namespace="http://tempuri.org/")]
    public partial class EconomicActivityClass : object
    {
        
        private int EconomicActivityCdField;
        
        private string DescriptionField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int EconomicActivityCd
        {
            get
            {
                return this.EconomicActivityCdField;
            }
            set
            {
                this.EconomicActivityCdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ParamListProduct", Namespace="http://tempuri.org/")]
    public partial class ParamListProduct : object
    {
        
        private WsParam.ListProductClass[] ListProductClassField;
        
        private string ProcessMessageField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public WsParam.ListProductClass[] ListProductClass
        {
            get
            {
                return this.ListProductClassField;
            }
            set
            {
                this.ListProductClassField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ListProductClass", Namespace="http://tempuri.org/")]
    public partial class ListProductClass : object
    {
        
        private int PrefixCdField;
        
        private string DescriptionPrefixField;
        
        private int ProductCdField;
        
        private string DescriptionProductField;
        
        private int GroupCoverageCdField;
        
        private string DescriptionGroupField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string DescriptionPrefix
        {
            get
            {
                return this.DescriptionPrefixField;
            }
            set
            {
                this.DescriptionPrefixField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int ProductCd
        {
            get
            {
                return this.ProductCdField;
            }
            set
            {
                this.ProductCdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string DescriptionProduct
        {
            get
            {
                return this.DescriptionProductField;
            }
            set
            {
                this.DescriptionProductField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int GroupCoverageCd
        {
            get
            {
                return this.GroupCoverageCdField;
            }
            set
            {
                this.GroupCoverageCdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string DescriptionGroup
        {
            get
            {
                return this.DescriptionGroupField;
            }
            set
            {
                this.DescriptionGroupField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="QuoteParamRatingZoneClass", Namespace="http://tempuri.org/")]
    public partial class QuoteParamRatingZoneClass : object
    {
        
        private WsParam.RatingZoneClass[] RatingZoneClassField;
        
        private string ProcessMessageField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public WsParam.RatingZoneClass[] RatingZoneClass
        {
            get
            {
                return this.RatingZoneClassField;
            }
            set
            {
                this.RatingZoneClassField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="RatingZoneClass", Namespace="http://tempuri.org/")]
    public partial class RatingZoneClass : object
    {
        
        private int RatingZoneCodeField;
        
        private string DescriptionField;
        
        private string SmallDescriptionField;
        
        private int PrefixCodeField;
        
        private bool IsDefaultField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int RatingZoneCode
        {
            get
            {
                return this.RatingZoneCodeField;
            }
            set
            {
                this.RatingZoneCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string SmallDescription
        {
            get
            {
                return this.SmallDescriptionField;
            }
            set
            {
                this.SmallDescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public bool IsDefault
        {
            get
            {
                return this.IsDefaultField;
            }
            set
            {
                this.IsDefaultField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="QuoteParamVehicleFasecoldaClass", Namespace="http://tempuri.org/")]
    public partial class QuoteParamVehicleFasecoldaClass : object
    {
        
        private WsParam.VehicleParameterDTO VehicleFasecoldaField;
        
        private string ProcessMessageField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public WsParam.VehicleParameterDTO VehicleFasecolda
        {
            get
            {
                return this.VehicleFasecoldaField;
            }
            set
            {
                this.VehicleFasecoldaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="VehicleParameterDTO", Namespace="http://tempuri.org/")]
    public partial class VehicleParameterDTO : object
    {
        
        private int VehicleMakeCodeField;
        
        private int VehicleModelCodeField;
        
        private int VehicleVersionCodeField;
        
        private int VehicleTypeCodeField;
        
        private string MakeDescriptionField;
        
        private string ModelDescriptionField;
        
        private string VersionDescriptionField;
        
        private string VehicleTypeDescriptionField;
        
        private int VehicleYearField;
        
        private decimal VehiclePriceField;
        
        private string FasecoldaMakeIdField;
        
        private string FasecoldaModelIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int VehicleMakeCode
        {
            get
            {
                return this.VehicleMakeCodeField;
            }
            set
            {
                this.VehicleMakeCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int VehicleModelCode
        {
            get
            {
                return this.VehicleModelCodeField;
            }
            set
            {
                this.VehicleModelCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int VehicleVersionCode
        {
            get
            {
                return this.VehicleVersionCodeField;
            }
            set
            {
                this.VehicleVersionCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int VehicleTypeCode
        {
            get
            {
                return this.VehicleTypeCodeField;
            }
            set
            {
                this.VehicleTypeCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string VersionDescription
        {
            get
            {
                return this.VersionDescriptionField;
            }
            set
            {
                this.VersionDescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string VehicleTypeDescription
        {
            get
            {
                return this.VehicleTypeDescriptionField;
            }
            set
            {
                this.VehicleTypeDescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=8)]
        public int VehicleYear
        {
            get
            {
                return this.VehicleYearField;
            }
            set
            {
                this.VehicleYearField = value;
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
        public string FasecoldaMakeId
        {
            get
            {
                return this.FasecoldaMakeIdField;
            }
            set
            {
                this.FasecoldaMakeIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=11)]
        public string FasecoldaModelId
        {
            get
            {
                return this.FasecoldaModelIdField;
            }
            set
            {
                this.FasecoldaModelIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="QuoteParamVehicleClass", Namespace="http://tempuri.org/")]
    public partial class QuoteParamVehicleClass : object
    {
        
        private WsParam.VehicleParameterDTO[] VehicleParameterDTOCoField;
        
        private string ProcessMessageField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public WsParam.VehicleParameterDTO[] VehicleParameterDTOCo
        {
            get
            {
                return this.VehicleParameterDTOCoField;
            }
            set
            {
                this.VehicleParameterDTOCoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="PhoneTypeClass", Namespace="http://tempuri.org/")]
    public partial class PhoneTypeClass : object
    {
        
        private int PhoneTypeCdField;
        
        private string DescriptionField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int PhoneTypeCd
        {
            get
            {
                return this.PhoneTypeCdField;
            }
            set
            {
                this.PhoneTypeCdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AgentModel", Namespace="http://tempuri.org/")]
    public partial class AgentModel : object
    {
        
        private string SurnameField;
        
        private string MotherLastNameField;
        
        private string NameField;
        
        private string TradeNameField;
        
        private int IndividualTypeCdField;
        
        private string MessageField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int IndividualTypeCd
        {
            get
            {
                return this.IndividualTypeCdField;
            }
            set
            {
                this.IndividualTypeCdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
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
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ParamAssistanceClass", Namespace="http://tempuri.org/")]
    public partial class ParamAssistanceClass : object
    {
        
        private WsParam.ParamAssistance[] ParamAssistanceField;
        
        private string ProcessMessageField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public WsParam.ParamAssistance[] ParamAssistance
        {
            get
            {
                return this.ParamAssistanceField;
            }
            set
            {
                this.ParamAssistanceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ParamAssistance", Namespace="http://tempuri.org/")]
    public partial class ParamAssistance : object
    {
        
        private int PrefixCodeField;
        
        private string PrefixDescriptionField;
        
        private int AssitanceCodeField;
        
        private string AssistanceDescriptionField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string PrefixDescription
        {
            get
            {
                return this.PrefixDescriptionField;
            }
            set
            {
                this.PrefixDescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int AssitanceCode
        {
            get
            {
                return this.AssitanceCodeField;
            }
            set
            {
                this.AssitanceCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string AssistanceDescription
        {
            get
            {
                return this.AssistanceDescriptionField;
            }
            set
            {
                this.AssistanceDescriptionField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ParamAssistanceCoverClass", Namespace="http://tempuri.org/")]
    public partial class ParamAssistanceCoverClass : object
    {
        
        private WsParam.ParamAssistanceCover ParamAssistanceCoverField;
        
        private string ProcessMessageField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public WsParam.ParamAssistanceCover ParamAssistanceCover
        {
            get
            {
                return this.ParamAssistanceCoverField;
            }
            set
            {
                this.ParamAssistanceCoverField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ParamAssistanceCover", Namespace="http://tempuri.org/")]
    public partial class ParamAssistanceCover : object
    {
        
        private int PrefixCodeField;
        
        private string PrefixDescriptionField;
        
        private int AssitanceCodeField;
        
        private string AssistanceDescriptionField;
        
        private int TextCodeField;
        
        private string TextDescriptionField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string PrefixDescription
        {
            get
            {
                return this.PrefixDescriptionField;
            }
            set
            {
                this.PrefixDescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int AssitanceCode
        {
            get
            {
                return this.AssitanceCodeField;
            }
            set
            {
                this.AssitanceCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string AssistanceDescription
        {
            get
            {
                return this.AssistanceDescriptionField;
            }
            set
            {
                this.AssistanceDescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int TextCode
        {
            get
            {
                return this.TextCodeField;
            }
            set
            {
                this.TextCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string TextDescription
        {
            get
            {
                return this.TextDescriptionField;
            }
            set
            {
                this.TextDescriptionField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ParamListCountryStateCity", Namespace="http://tempuri.org/")]
    public partial class ParamListCountryStateCity : object
    {
        
        private WsParam.ListCountryStateCityClass[] ListCountryStateCityClassField;
        
        private string ProcessMessageField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public WsParam.ListCountryStateCityClass[] ListCountryStateCityClass
        {
            get
            {
                return this.ListCountryStateCityClassField;
            }
            set
            {
                this.ListCountryStateCityClassField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ListCountryStateCityClass", Namespace="http://tempuri.org/")]
    public partial class ListCountryStateCityClass : object
    {
        
        private int CountryCdField;
        
        private string CountryDescriptionField;
        
        private int StateCdField;
        
        private string StateDescriptionField;
        
        private int CityCdField;
        
        private string CityDescriptionField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int CountryCd
        {
            get
            {
                return this.CountryCdField;
            }
            set
            {
                this.CountryCdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string CountryDescription
        {
            get
            {
                return this.CountryDescriptionField;
            }
            set
            {
                this.CountryDescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int StateCd
        {
            get
            {
                return this.StateCdField;
            }
            set
            {
                this.StateCdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string StateDescription
        {
            get
            {
                return this.StateDescriptionField;
            }
            set
            {
                this.StateDescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int CityCd
        {
            get
            {
                return this.CityCdField;
            }
            set
            {
                this.CityCdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string CityDescription
        {
            get
            {
                return this.CityDescriptionField;
            }
            set
            {
                this.CityDescriptionField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WsParam.IExternalParamService")]
    public interface IExternalParamService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExternalParamService/GenerateIdentityCardTypeList", ReplyAction="http://tempuri.org/IExternalParamService/GenerateIdentityCardTypeListResponse")]
        System.Threading.Tasks.Task<WsParam.GenerateIdentityCardTypeListResponse> GenerateIdentityCardTypeListAsync(WsParam.GenerateIdentityCardTypeListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExternalParamService/GenerateListAdressType", ReplyAction="http://tempuri.org/IExternalParamService/GenerateListAdressTypeResponse")]
        System.Threading.Tasks.Task<WsParam.GenerateListAdressTypeResponse> GenerateListAdressTypeAsync(WsParam.GenerateListAdressTypeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExternalParamService/GenerateListCompanyType", ReplyAction="http://tempuri.org/IExternalParamService/GenerateListCompanyTypeResponse")]
        System.Threading.Tasks.Task<WsParam.GenerateListCompanyTypeResponse> GenerateListCompanyTypeAsync(WsParam.GenerateListCompanyTypeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExternalParamService/GenerateListDetail", ReplyAction="http://tempuri.org/IExternalParamService/GenerateListDetailResponse")]
        System.Threading.Tasks.Task<WsParam.GenerateListDetailResponse> GenerateListDetailAsync(WsParam.GenerateListDetailRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExternalParamService/GenerateListEconomicActivity", ReplyAction="http://tempuri.org/IExternalParamService/GenerateListEconomicActivityResponse")]
        System.Threading.Tasks.Task<WsParam.GenerateListEconomicActivityResponse> GenerateListEconomicActivityAsync(WsParam.GenerateListEconomicActivityRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExternalParamService/GenerateListProduct", ReplyAction="http://tempuri.org/IExternalParamService/GenerateListProductResponse")]
        System.Threading.Tasks.Task<WsParam.GenerateListProductResponse> GenerateListProductAsync(WsParam.GenerateListProductRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExternalParamService/GenerateRatingZoneList", ReplyAction="http://tempuri.org/IExternalParamService/GenerateRatingZoneListResponse")]
        System.Threading.Tasks.Task<WsParam.GenerateRatingZoneListResponse> GenerateRatingZoneListAsync(WsParam.GenerateRatingZoneListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExternalParamService/GenerateVehicleFasecolda", ReplyAction="http://tempuri.org/IExternalParamService/GenerateVehicleFasecoldaResponse")]
        System.Threading.Tasks.Task<WsParam.GenerateVehicleFasecoldaResponse> GenerateVehicleFasecoldaAsync(WsParam.GenerateVehicleFasecoldaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExternalParamService/GenerateVehiclesList", ReplyAction="http://tempuri.org/IExternalParamService/GenerateVehiclesListResponse")]
        System.Threading.Tasks.Task<WsParam.GenerateVehiclesListResponse> GenerateVehiclesListAsync(WsParam.GenerateVehiclesListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExternalParamService/GenereteListPhoneType", ReplyAction="http://tempuri.org/IExternalParamService/GenereteListPhoneTypeResponse")]
        System.Threading.Tasks.Task<WsParam.GenereteListPhoneTypeResponse> GenereteListPhoneTypeAsync(WsParam.GenereteListPhoneTypeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExternalParamService/GetAgent", ReplyAction="http://tempuri.org/IExternalParamService/GetAgentResponse")]
        System.Threading.Tasks.Task<WsParam.GetAgentResponse> GetAgentAsync(WsParam.GetAgentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExternalParamService/GetListAssistance", ReplyAction="http://tempuri.org/IExternalParamService/GetListAssistanceResponse")]
        System.Threading.Tasks.Task<WsParam.GetListAssistanceResponse> GetListAssistanceAsync(WsParam.GetListAssistanceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExternalParamService/GetListAssistanceCover", ReplyAction="http://tempuri.org/IExternalParamService/GetListAssistanceCoverResponse")]
        System.Threading.Tasks.Task<WsParam.GetListAssistanceCoverResponse> GetListAssistanceCoverAsync(WsParam.GetListAssistanceCoverRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExternalParamService/GenerateListCountryStateCity", ReplyAction="http://tempuri.org/IExternalParamService/GenerateListCountryStateCityResponse")]
        System.Threading.Tasks.Task<WsParam.GenerateListCountryStateCityResponse> GenerateListCountryStateCityAsync(WsParam.GenerateListCountryStateCityRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GenerateIdentityCardTypeListRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GenerateIdentityCardTypeList", Namespace="http://tempuri.org/", Order=0)]
        public WsParam.GenerateIdentityCardTypeListRequestBody Body;
        
        public GenerateIdentityCardTypeListRequest()
        {
        }
        
        public GenerateIdentityCardTypeListRequest(WsParam.GenerateIdentityCardTypeListRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GenerateIdentityCardTypeListRequestBody
    {
        
        public GenerateIdentityCardTypeListRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GenerateIdentityCardTypeListResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GenerateIdentityCardTypeListResponse", Namespace="http://tempuri.org/", Order=0)]
        public WsParam.GenerateIdentityCardTypeListResponseBody Body;
        
        public GenerateIdentityCardTypeListResponse()
        {
        }
        
        public GenerateIdentityCardTypeListResponse(WsParam.GenerateIdentityCardTypeListResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GenerateIdentityCardTypeListResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WsParam.QuoteParamIdentityCardClass[] GenerateIdentityCardTypeListResult;
        
        public GenerateIdentityCardTypeListResponseBody()
        {
        }
        
        public GenerateIdentityCardTypeListResponseBody(WsParam.QuoteParamIdentityCardClass[] GenerateIdentityCardTypeListResult)
        {
            this.GenerateIdentityCardTypeListResult = GenerateIdentityCardTypeListResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GenerateListAdressTypeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GenerateListAdressType", Namespace="http://tempuri.org/", Order=0)]
        public WsParam.GenerateListAdressTypeRequestBody Body;
        
        public GenerateListAdressTypeRequest()
        {
        }
        
        public GenerateListAdressTypeRequest(WsParam.GenerateListAdressTypeRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GenerateListAdressTypeRequestBody
    {
        
        public GenerateListAdressTypeRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GenerateListAdressTypeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GenerateListAdressTypeResponse", Namespace="http://tempuri.org/", Order=0)]
        public WsParam.GenerateListAdressTypeResponseBody Body;
        
        public GenerateListAdressTypeResponse()
        {
        }
        
        public GenerateListAdressTypeResponse(WsParam.GenerateListAdressTypeResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GenerateListAdressTypeResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WsParam.ParamAddressType[] GenerateListAdressTypeResult;
        
        public GenerateListAdressTypeResponseBody()
        {
        }
        
        public GenerateListAdressTypeResponseBody(WsParam.ParamAddressType[] GenerateListAdressTypeResult)
        {
            this.GenerateListAdressTypeResult = GenerateListAdressTypeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GenerateListCompanyTypeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GenerateListCompanyType", Namespace="http://tempuri.org/", Order=0)]
        public WsParam.GenerateListCompanyTypeRequestBody Body;
        
        public GenerateListCompanyTypeRequest()
        {
        }
        
        public GenerateListCompanyTypeRequest(WsParam.GenerateListCompanyTypeRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GenerateListCompanyTypeRequestBody
    {
        
        public GenerateListCompanyTypeRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GenerateListCompanyTypeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GenerateListCompanyTypeResponse", Namespace="http://tempuri.org/", Order=0)]
        public WsParam.GenerateListCompanyTypeResponseBody Body;
        
        public GenerateListCompanyTypeResponse()
        {
        }
        
        public GenerateListCompanyTypeResponse(WsParam.GenerateListCompanyTypeResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GenerateListCompanyTypeResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WsParam.ParamCompanyType[] GenerateListCompanyTypeResult;
        
        public GenerateListCompanyTypeResponseBody()
        {
        }
        
        public GenerateListCompanyTypeResponseBody(WsParam.ParamCompanyType[] GenerateListCompanyTypeResult)
        {
            this.GenerateListCompanyTypeResult = GenerateListCompanyTypeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GenerateListDetailRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GenerateListDetail", Namespace="http://tempuri.org/", Order=0)]
        public WsParam.GenerateListDetailRequestBody Body;
        
        public GenerateListDetailRequest()
        {
        }
        
        public GenerateListDetailRequest(WsParam.GenerateListDetailRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GenerateListDetailRequestBody
    {
        
        public GenerateListDetailRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GenerateListDetailResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GenerateListDetailResponse", Namespace="http://tempuri.org/", Order=0)]
        public WsParam.GenerateListDetailResponseBody Body;
        
        public GenerateListDetailResponse()
        {
        }
        
        public GenerateListDetailResponse(WsParam.GenerateListDetailResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GenerateListDetailResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WsParam.ParamListDetail[] GenerateListDetailResult;
        
        public GenerateListDetailResponseBody()
        {
        }
        
        public GenerateListDetailResponseBody(WsParam.ParamListDetail[] GenerateListDetailResult)
        {
            this.GenerateListDetailResult = GenerateListDetailResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GenerateListEconomicActivityRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GenerateListEconomicActivity", Namespace="http://tempuri.org/", Order=0)]
        public WsParam.GenerateListEconomicActivityRequestBody Body;
        
        public GenerateListEconomicActivityRequest()
        {
        }
        
        public GenerateListEconomicActivityRequest(WsParam.GenerateListEconomicActivityRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GenerateListEconomicActivityRequestBody
    {
        
        public GenerateListEconomicActivityRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GenerateListEconomicActivityResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GenerateListEconomicActivityResponse", Namespace="http://tempuri.org/", Order=0)]
        public WsParam.GenerateListEconomicActivityResponseBody Body;
        
        public GenerateListEconomicActivityResponse()
        {
        }
        
        public GenerateListEconomicActivityResponse(WsParam.GenerateListEconomicActivityResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GenerateListEconomicActivityResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WsParam.ParamEconomicActivity[] GenerateListEconomicActivityResult;
        
        public GenerateListEconomicActivityResponseBody()
        {
        }
        
        public GenerateListEconomicActivityResponseBody(WsParam.ParamEconomicActivity[] GenerateListEconomicActivityResult)
        {
            this.GenerateListEconomicActivityResult = GenerateListEconomicActivityResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GenerateListProductRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GenerateListProduct", Namespace="http://tempuri.org/", Order=0)]
        public WsParam.GenerateListProductRequestBody Body;
        
        public GenerateListProductRequest()
        {
        }
        
        public GenerateListProductRequest(WsParam.GenerateListProductRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GenerateListProductRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int prefixCd;
        
        public GenerateListProductRequestBody()
        {
        }
        
        public GenerateListProductRequestBody(int prefixCd)
        {
            this.prefixCd = prefixCd;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GenerateListProductResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GenerateListProductResponse", Namespace="http://tempuri.org/", Order=0)]
        public WsParam.GenerateListProductResponseBody Body;
        
        public GenerateListProductResponse()
        {
        }
        
        public GenerateListProductResponse(WsParam.GenerateListProductResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GenerateListProductResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WsParam.ParamListProduct[] GenerateListProductResult;
        
        public GenerateListProductResponseBody()
        {
        }
        
        public GenerateListProductResponseBody(WsParam.ParamListProduct[] GenerateListProductResult)
        {
            this.GenerateListProductResult = GenerateListProductResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GenerateRatingZoneListRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GenerateRatingZoneList", Namespace="http://tempuri.org/", Order=0)]
        public WsParam.GenerateRatingZoneListRequestBody Body;
        
        public GenerateRatingZoneListRequest()
        {
        }
        
        public GenerateRatingZoneListRequest(WsParam.GenerateRatingZoneListRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GenerateRatingZoneListRequestBody
    {
        
        public GenerateRatingZoneListRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GenerateRatingZoneListResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GenerateRatingZoneListResponse", Namespace="http://tempuri.org/", Order=0)]
        public WsParam.GenerateRatingZoneListResponseBody Body;
        
        public GenerateRatingZoneListResponse()
        {
        }
        
        public GenerateRatingZoneListResponse(WsParam.GenerateRatingZoneListResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GenerateRatingZoneListResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WsParam.QuoteParamRatingZoneClass[] GenerateRatingZoneListResult;
        
        public GenerateRatingZoneListResponseBody()
        {
        }
        
        public GenerateRatingZoneListResponseBody(WsParam.QuoteParamRatingZoneClass[] GenerateRatingZoneListResult)
        {
            this.GenerateRatingZoneListResult = GenerateRatingZoneListResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GenerateVehicleFasecoldaRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GenerateVehicleFasecolda", Namespace="http://tempuri.org/", Order=0)]
        public WsParam.GenerateVehicleFasecoldaRequestBody Body;
        
        public GenerateVehicleFasecoldaRequest()
        {
        }
        
        public GenerateVehicleFasecoldaRequest(WsParam.GenerateVehicleFasecoldaRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GenerateVehicleFasecoldaRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string fasecoldaCd;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int yearVehicle;
        
        public GenerateVehicleFasecoldaRequestBody()
        {
        }
        
        public GenerateVehicleFasecoldaRequestBody(string fasecoldaCd, int yearVehicle)
        {
            this.fasecoldaCd = fasecoldaCd;
            this.yearVehicle = yearVehicle;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GenerateVehicleFasecoldaResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GenerateVehicleFasecoldaResponse", Namespace="http://tempuri.org/", Order=0)]
        public WsParam.GenerateVehicleFasecoldaResponseBody Body;
        
        public GenerateVehicleFasecoldaResponse()
        {
        }
        
        public GenerateVehicleFasecoldaResponse(WsParam.GenerateVehicleFasecoldaResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GenerateVehicleFasecoldaResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WsParam.QuoteParamVehicleFasecoldaClass GenerateVehicleFasecoldaResult;
        
        public GenerateVehicleFasecoldaResponseBody()
        {
        }
        
        public GenerateVehicleFasecoldaResponseBody(WsParam.QuoteParamVehicleFasecoldaClass GenerateVehicleFasecoldaResult)
        {
            this.GenerateVehicleFasecoldaResult = GenerateVehicleFasecoldaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GenerateVehiclesListRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GenerateVehiclesList", Namespace="http://tempuri.org/", Order=0)]
        public WsParam.GenerateVehiclesListRequestBody Body;
        
        public GenerateVehiclesListRequest()
        {
        }
        
        public GenerateVehiclesListRequest(WsParam.GenerateVehiclesListRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GenerateVehiclesListRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int vehicleYearInit;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int vehicleYearEnd;
        
        public GenerateVehiclesListRequestBody()
        {
        }
        
        public GenerateVehiclesListRequestBody(int vehicleYearInit, int vehicleYearEnd)
        {
            this.vehicleYearInit = vehicleYearInit;
            this.vehicleYearEnd = vehicleYearEnd;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GenerateVehiclesListResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GenerateVehiclesListResponse", Namespace="http://tempuri.org/", Order=0)]
        public WsParam.GenerateVehiclesListResponseBody Body;
        
        public GenerateVehiclesListResponse()
        {
        }
        
        public GenerateVehiclesListResponse(WsParam.GenerateVehiclesListResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GenerateVehiclesListResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WsParam.QuoteParamVehicleClass[] GenerateVehiclesListResult;
        
        public GenerateVehiclesListResponseBody()
        {
        }
        
        public GenerateVehiclesListResponseBody(WsParam.QuoteParamVehicleClass[] GenerateVehiclesListResult)
        {
            this.GenerateVehiclesListResult = GenerateVehiclesListResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GenereteListPhoneTypeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GenereteListPhoneType", Namespace="http://tempuri.org/", Order=0)]
        public WsParam.GenereteListPhoneTypeRequestBody Body;
        
        public GenereteListPhoneTypeRequest()
        {
        }
        
        public GenereteListPhoneTypeRequest(WsParam.GenereteListPhoneTypeRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GenereteListPhoneTypeRequestBody
    {
        
        public GenereteListPhoneTypeRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GenereteListPhoneTypeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GenereteListPhoneTypeResponse", Namespace="http://tempuri.org/", Order=0)]
        public WsParam.GenereteListPhoneTypeResponseBody Body;
        
        public GenereteListPhoneTypeResponse()
        {
        }
        
        public GenereteListPhoneTypeResponse(WsParam.GenereteListPhoneTypeResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GenereteListPhoneTypeResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WsParam.PhoneTypeClass[] GenereteListPhoneTypeResult;
        
        public GenereteListPhoneTypeResponseBody()
        {
        }
        
        public GenereteListPhoneTypeResponseBody(WsParam.PhoneTypeClass[] GenereteListPhoneTypeResult)
        {
            this.GenereteListPhoneTypeResult = GenereteListPhoneTypeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAgentRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAgent", Namespace="http://tempuri.org/", Order=0)]
        public WsParam.GetAgentRequestBody Body;
        
        public GetAgentRequest()
        {
        }
        
        public GetAgentRequest(WsParam.GetAgentRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAgentRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int agentCode;
        
        public GetAgentRequestBody()
        {
        }
        
        public GetAgentRequestBody(int agentCode)
        {
            this.agentCode = agentCode;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAgentResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAgentResponse", Namespace="http://tempuri.org/", Order=0)]
        public WsParam.GetAgentResponseBody Body;
        
        public GetAgentResponse()
        {
        }
        
        public GetAgentResponse(WsParam.GetAgentResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAgentResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WsParam.AgentModel GetAgentResult;
        
        public GetAgentResponseBody()
        {
        }
        
        public GetAgentResponseBody(WsParam.AgentModel GetAgentResult)
        {
            this.GetAgentResult = GetAgentResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetListAssistanceRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetListAssistance", Namespace="http://tempuri.org/", Order=0)]
        public WsParam.GetListAssistanceRequestBody Body;
        
        public GetListAssistanceRequest()
        {
        }
        
        public GetListAssistanceRequest(WsParam.GetListAssistanceRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetListAssistanceRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int prefixCd;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int productCd;
        
        public GetListAssistanceRequestBody()
        {
        }
        
        public GetListAssistanceRequestBody(int prefixCd, int productCd)
        {
            this.prefixCd = prefixCd;
            this.productCd = productCd;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetListAssistanceResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetListAssistanceResponse", Namespace="http://tempuri.org/", Order=0)]
        public WsParam.GetListAssistanceResponseBody Body;
        
        public GetListAssistanceResponse()
        {
        }
        
        public GetListAssistanceResponse(WsParam.GetListAssistanceResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetListAssistanceResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WsParam.ParamAssistanceClass[] GetListAssistanceResult;
        
        public GetListAssistanceResponseBody()
        {
        }
        
        public GetListAssistanceResponseBody(WsParam.ParamAssistanceClass[] GetListAssistanceResult)
        {
            this.GetListAssistanceResult = GetListAssistanceResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetListAssistanceCoverRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetListAssistanceCover", Namespace="http://tempuri.org/", Order=0)]
        public WsParam.GetListAssistanceCoverRequestBody Body;
        
        public GetListAssistanceCoverRequest()
        {
        }
        
        public GetListAssistanceCoverRequest(WsParam.GetListAssistanceCoverRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetListAssistanceCoverRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int assistanceCd;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int prefixCd;
        
        public GetListAssistanceCoverRequestBody()
        {
        }
        
        public GetListAssistanceCoverRequestBody(int assistanceCd, int prefixCd)
        {
            this.assistanceCd = assistanceCd;
            this.prefixCd = prefixCd;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetListAssistanceCoverResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetListAssistanceCoverResponse", Namespace="http://tempuri.org/", Order=0)]
        public WsParam.GetListAssistanceCoverResponseBody Body;
        
        public GetListAssistanceCoverResponse()
        {
        }
        
        public GetListAssistanceCoverResponse(WsParam.GetListAssistanceCoverResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetListAssistanceCoverResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WsParam.ParamAssistanceCoverClass[] GetListAssistanceCoverResult;
        
        public GetListAssistanceCoverResponseBody()
        {
        }
        
        public GetListAssistanceCoverResponseBody(WsParam.ParamAssistanceCoverClass[] GetListAssistanceCoverResult)
        {
            this.GetListAssistanceCoverResult = GetListAssistanceCoverResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GenerateListCountryStateCityRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GenerateListCountryStateCity", Namespace="http://tempuri.org/", Order=0)]
        public WsParam.GenerateListCountryStateCityRequestBody Body;
        
        public GenerateListCountryStateCityRequest()
        {
        }
        
        public GenerateListCountryStateCityRequest(WsParam.GenerateListCountryStateCityRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GenerateListCountryStateCityRequestBody
    {
        
        public GenerateListCountryStateCityRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GenerateListCountryStateCityResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GenerateListCountryStateCityResponse", Namespace="http://tempuri.org/", Order=0)]
        public WsParam.GenerateListCountryStateCityResponseBody Body;
        
        public GenerateListCountryStateCityResponse()
        {
        }
        
        public GenerateListCountryStateCityResponse(WsParam.GenerateListCountryStateCityResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GenerateListCountryStateCityResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WsParam.ParamListCountryStateCity[] GenerateListCountryStateCityResult;
        
        public GenerateListCountryStateCityResponseBody()
        {
        }
        
        public GenerateListCountryStateCityResponseBody(WsParam.ParamListCountryStateCity[] GenerateListCountryStateCityResult)
        {
            this.GenerateListCountryStateCityResult = GenerateListCountryStateCityResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface IExternalParamServiceChannel : WsParam.IExternalParamService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class ExternalParamServiceClient : System.ServiceModel.ClientBase<WsParam.IExternalParamService>, WsParam.IExternalParamService
    {
        
    /// <summary>
    /// Implemente este método parcial para configurar el punto de conexión de servicio.
    /// </summary>
    /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
    /// <param name="clientCredentials">Credenciales de cliente</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ExternalParamServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(ExternalParamServiceClient.GetBindingForEndpoint(endpointConfiguration), ExternalParamServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ExternalParamServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ExternalParamServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ExternalParamServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ExternalParamServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ExternalParamServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WsParam.GenerateIdentityCardTypeListResponse> WsParam.IExternalParamService.GenerateIdentityCardTypeListAsync(WsParam.GenerateIdentityCardTypeListRequest request)
        {
            return base.Channel.GenerateIdentityCardTypeListAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsParam.GenerateIdentityCardTypeListResponse> GenerateIdentityCardTypeListAsync()
        {
            WsParam.GenerateIdentityCardTypeListRequest inValue = new WsParam.GenerateIdentityCardTypeListRequest();
            inValue.Body = new WsParam.GenerateIdentityCardTypeListRequestBody();
            return ((WsParam.IExternalParamService)(this)).GenerateIdentityCardTypeListAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WsParam.GenerateListAdressTypeResponse> WsParam.IExternalParamService.GenerateListAdressTypeAsync(WsParam.GenerateListAdressTypeRequest request)
        {
            return base.Channel.GenerateListAdressTypeAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsParam.GenerateListAdressTypeResponse> GenerateListAdressTypeAsync()
        {
            WsParam.GenerateListAdressTypeRequest inValue = new WsParam.GenerateListAdressTypeRequest();
            inValue.Body = new WsParam.GenerateListAdressTypeRequestBody();
            return ((WsParam.IExternalParamService)(this)).GenerateListAdressTypeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WsParam.GenerateListCompanyTypeResponse> WsParam.IExternalParamService.GenerateListCompanyTypeAsync(WsParam.GenerateListCompanyTypeRequest request)
        {
            return base.Channel.GenerateListCompanyTypeAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsParam.GenerateListCompanyTypeResponse> GenerateListCompanyTypeAsync()
        {
            WsParam.GenerateListCompanyTypeRequest inValue = new WsParam.GenerateListCompanyTypeRequest();
            inValue.Body = new WsParam.GenerateListCompanyTypeRequestBody();
            return ((WsParam.IExternalParamService)(this)).GenerateListCompanyTypeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WsParam.GenerateListDetailResponse> WsParam.IExternalParamService.GenerateListDetailAsync(WsParam.GenerateListDetailRequest request)
        {
            return base.Channel.GenerateListDetailAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsParam.GenerateListDetailResponse> GenerateListDetailAsync()
        {
            WsParam.GenerateListDetailRequest inValue = new WsParam.GenerateListDetailRequest();
            inValue.Body = new WsParam.GenerateListDetailRequestBody();
            return ((WsParam.IExternalParamService)(this)).GenerateListDetailAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WsParam.GenerateListEconomicActivityResponse> WsParam.IExternalParamService.GenerateListEconomicActivityAsync(WsParam.GenerateListEconomicActivityRequest request)
        {
            return base.Channel.GenerateListEconomicActivityAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsParam.GenerateListEconomicActivityResponse> GenerateListEconomicActivityAsync()
        {
            WsParam.GenerateListEconomicActivityRequest inValue = new WsParam.GenerateListEconomicActivityRequest();
            inValue.Body = new WsParam.GenerateListEconomicActivityRequestBody();
            return ((WsParam.IExternalParamService)(this)).GenerateListEconomicActivityAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WsParam.GenerateListProductResponse> WsParam.IExternalParamService.GenerateListProductAsync(WsParam.GenerateListProductRequest request)
        {
            return base.Channel.GenerateListProductAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsParam.GenerateListProductResponse> GenerateListProductAsync(int prefixCd)
        {
            WsParam.GenerateListProductRequest inValue = new WsParam.GenerateListProductRequest();
            inValue.Body = new WsParam.GenerateListProductRequestBody();
            inValue.Body.prefixCd = prefixCd;
            return ((WsParam.IExternalParamService)(this)).GenerateListProductAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WsParam.GenerateRatingZoneListResponse> WsParam.IExternalParamService.GenerateRatingZoneListAsync(WsParam.GenerateRatingZoneListRequest request)
        {
            return base.Channel.GenerateRatingZoneListAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsParam.GenerateRatingZoneListResponse> GenerateRatingZoneListAsync()
        {
            WsParam.GenerateRatingZoneListRequest inValue = new WsParam.GenerateRatingZoneListRequest();
            inValue.Body = new WsParam.GenerateRatingZoneListRequestBody();
            return ((WsParam.IExternalParamService)(this)).GenerateRatingZoneListAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WsParam.GenerateVehicleFasecoldaResponse> WsParam.IExternalParamService.GenerateVehicleFasecoldaAsync(WsParam.GenerateVehicleFasecoldaRequest request)
        {
            return base.Channel.GenerateVehicleFasecoldaAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsParam.GenerateVehicleFasecoldaResponse> GenerateVehicleFasecoldaAsync(string fasecoldaCd, int yearVehicle)
        {
            WsParam.GenerateVehicleFasecoldaRequest inValue = new WsParam.GenerateVehicleFasecoldaRequest();
            inValue.Body = new WsParam.GenerateVehicleFasecoldaRequestBody();
            inValue.Body.fasecoldaCd = fasecoldaCd;
            inValue.Body.yearVehicle = yearVehicle;
            return ((WsParam.IExternalParamService)(this)).GenerateVehicleFasecoldaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WsParam.GenerateVehiclesListResponse> WsParam.IExternalParamService.GenerateVehiclesListAsync(WsParam.GenerateVehiclesListRequest request)
        {
            return base.Channel.GenerateVehiclesListAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsParam.GenerateVehiclesListResponse> GenerateVehiclesListAsync(int vehicleYearInit, int vehicleYearEnd)
        {
            WsParam.GenerateVehiclesListRequest inValue = new WsParam.GenerateVehiclesListRequest();
            inValue.Body = new WsParam.GenerateVehiclesListRequestBody();
            inValue.Body.vehicleYearInit = vehicleYearInit;
            inValue.Body.vehicleYearEnd = vehicleYearEnd;
            return ((WsParam.IExternalParamService)(this)).GenerateVehiclesListAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WsParam.GenereteListPhoneTypeResponse> WsParam.IExternalParamService.GenereteListPhoneTypeAsync(WsParam.GenereteListPhoneTypeRequest request)
        {
            return base.Channel.GenereteListPhoneTypeAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsParam.GenereteListPhoneTypeResponse> GenereteListPhoneTypeAsync()
        {
            WsParam.GenereteListPhoneTypeRequest inValue = new WsParam.GenereteListPhoneTypeRequest();
            inValue.Body = new WsParam.GenereteListPhoneTypeRequestBody();
            return ((WsParam.IExternalParamService)(this)).GenereteListPhoneTypeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WsParam.GetAgentResponse> WsParam.IExternalParamService.GetAgentAsync(WsParam.GetAgentRequest request)
        {
            return base.Channel.GetAgentAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsParam.GetAgentResponse> GetAgentAsync(int agentCode)
        {
            WsParam.GetAgentRequest inValue = new WsParam.GetAgentRequest();
            inValue.Body = new WsParam.GetAgentRequestBody();
            inValue.Body.agentCode = agentCode;
            return ((WsParam.IExternalParamService)(this)).GetAgentAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WsParam.GetListAssistanceResponse> WsParam.IExternalParamService.GetListAssistanceAsync(WsParam.GetListAssistanceRequest request)
        {
            return base.Channel.GetListAssistanceAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsParam.GetListAssistanceResponse> GetListAssistanceAsync(int prefixCd, int productCd)
        {
            WsParam.GetListAssistanceRequest inValue = new WsParam.GetListAssistanceRequest();
            inValue.Body = new WsParam.GetListAssistanceRequestBody();
            inValue.Body.prefixCd = prefixCd;
            inValue.Body.productCd = productCd;
            return ((WsParam.IExternalParamService)(this)).GetListAssistanceAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WsParam.GetListAssistanceCoverResponse> WsParam.IExternalParamService.GetListAssistanceCoverAsync(WsParam.GetListAssistanceCoverRequest request)
        {
            return base.Channel.GetListAssistanceCoverAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsParam.GetListAssistanceCoverResponse> GetListAssistanceCoverAsync(int assistanceCd, int prefixCd)
        {
            WsParam.GetListAssistanceCoverRequest inValue = new WsParam.GetListAssistanceCoverRequest();
            inValue.Body = new WsParam.GetListAssistanceCoverRequestBody();
            inValue.Body.assistanceCd = assistanceCd;
            inValue.Body.prefixCd = prefixCd;
            return ((WsParam.IExternalParamService)(this)).GetListAssistanceCoverAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WsParam.GenerateListCountryStateCityResponse> WsParam.IExternalParamService.GenerateListCountryStateCityAsync(WsParam.GenerateListCountryStateCityRequest request)
        {
            return base.Channel.GenerateListCountryStateCityAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsParam.GenerateListCountryStateCityResponse> GenerateListCountryStateCityAsync()
        {
            WsParam.GenerateListCountryStateCityRequest inValue = new WsParam.GenerateListCountryStateCityRequest();
            inValue.Body = new WsParam.GenerateListCountryStateCityRequestBody();
            return ((WsParam.IExternalParamService)(this)).GenerateListCountryStateCityAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IExternalParamService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IExternalParamService1))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IExternalParamService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:4000/External/ExternalParamServices");
            }
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IExternalParamService1))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:4000/ExternalParamServices");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IExternalParamService,
            
            BasicHttpBinding_IExternalParamService1,
        }
    }
}
