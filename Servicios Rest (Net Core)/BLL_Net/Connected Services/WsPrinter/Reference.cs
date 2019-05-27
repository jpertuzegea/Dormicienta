//------------------------------------------------------------------------------
// <generado automáticamente>
//     Este código fue generado por una herramienta.
//     //
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </generado automáticamente>
//------------------------------------------------------------------------------

namespace WsPrinter
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GenerateWSPolicyFormatCollectRequest", Namespace="http://tempuri.org/")]
    public partial class GenerateWSPolicyFormatCollectRequest : object
    {
        
        private int BranchIdField;
        
        private int PrefixNumField;
        
        private long DocumentNumberField;
        
        private int EndorsementIdField;
        
        private string EmailUserField;
        
        private string PrintBinaryField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int EndorsementId
        {
            get
            {
                return this.EndorsementIdField;
            }
            set
            {
                this.EndorsementIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string EmailUser
        {
            get
            {
                return this.EmailUserField;
            }
            set
            {
                this.EmailUserField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string PrintBinary
        {
            get
            {
                return this.PrintBinaryField;
            }
            set
            {
                this.PrintBinaryField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PrinterClass", Namespace="http://tempuri.org/")]
    public partial class PrinterClass : object
    {
        
        private string MessageField;
        
        private string PrinterBinaryField;
        
        private string XMLFTPField;
        
        private string ProcessMessageField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string PrinterBinary
        {
            get
            {
                return this.PrinterBinaryField;
            }
            set
            {
                this.PrinterBinaryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string XMLFTP
        {
            get
            {
                return this.XMLFTPField;
            }
            set
            {
                this.XMLFTPField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="GenerateWSPolicyPrinterRequest", Namespace="http://tempuri.org/")]
    public partial class GenerateWSPolicyPrinterRequest : object
    {
        
        private int BranchIdField;
        
        private int PrefixNumField;
        
        private long DocumentNumberField;
        
        private int EndorsementIdField;
        
        private string EmailUserField;
        
        private int YearEndorsementField;
        
        private int AllInformationField;
        
        private int FrontPageField;
        
        private int PaymentFormatField;
        
        private int AllInsuredField;
        
        private int PaymentField;
        
        private int CoveragesField;
        
        private int AnnexesField;
        
        private int FeeField;
        
        private int ClausesField;
        
        private int CertificateField;
        
        private int AllCertificateField;
        
        private int CertificateSinceField;
        
        private int CertificateUntilField;
        
        private int LetterInstructionField;
        
        private int InsuranceObjectField;
        
        private bool PrintBinaryField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int EndorsementId
        {
            get
            {
                return this.EndorsementIdField;
            }
            set
            {
                this.EndorsementIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string EmailUser
        {
            get
            {
                return this.EmailUserField;
            }
            set
            {
                this.EmailUserField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public int YearEndorsement
        {
            get
            {
                return this.YearEndorsementField;
            }
            set
            {
                this.YearEndorsementField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public int AllInformation
        {
            get
            {
                return this.AllInformationField;
            }
            set
            {
                this.AllInformationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=7)]
        public int FrontPage
        {
            get
            {
                return this.FrontPageField;
            }
            set
            {
                this.FrontPageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=8)]
        public int PaymentFormat
        {
            get
            {
                return this.PaymentFormatField;
            }
            set
            {
                this.PaymentFormatField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=9)]
        public int AllInsured
        {
            get
            {
                return this.AllInsuredField;
            }
            set
            {
                this.AllInsuredField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=10)]
        public int Payment
        {
            get
            {
                return this.PaymentField;
            }
            set
            {
                this.PaymentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=11)]
        public int Coverages
        {
            get
            {
                return this.CoveragesField;
            }
            set
            {
                this.CoveragesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=12)]
        public int Annexes
        {
            get
            {
                return this.AnnexesField;
            }
            set
            {
                this.AnnexesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=13)]
        public int Fee
        {
            get
            {
                return this.FeeField;
            }
            set
            {
                this.FeeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=14)]
        public int Clauses
        {
            get
            {
                return this.ClausesField;
            }
            set
            {
                this.ClausesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=15)]
        public int Certificate
        {
            get
            {
                return this.CertificateField;
            }
            set
            {
                this.CertificateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=16)]
        public int AllCertificate
        {
            get
            {
                return this.AllCertificateField;
            }
            set
            {
                this.AllCertificateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=17)]
        public int CertificateSince
        {
            get
            {
                return this.CertificateSinceField;
            }
            set
            {
                this.CertificateSinceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=18)]
        public int CertificateUntil
        {
            get
            {
                return this.CertificateUntilField;
            }
            set
            {
                this.CertificateUntilField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=19)]
        public int LetterInstruction
        {
            get
            {
                return this.LetterInstructionField;
            }
            set
            {
                this.LetterInstructionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=20)]
        public int InsuranceObject
        {
            get
            {
                return this.InsuranceObjectField;
            }
            set
            {
                this.InsuranceObjectField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=21)]
        public bool PrintBinary
        {
            get
            {
                return this.PrintBinaryField;
            }
            set
            {
                this.PrintBinaryField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GenerateWSQuotePrinterRequest", Namespace="http://tempuri.org/")]
    public partial class GenerateWSQuotePrinterRequest : object
    {
        
        private int TempIdField;
        
        private string EmailUserField;
        
        private string NameField;
        
        private System.Nullable<bool> PrintBinaryField;
        
        private bool JustRecordQuoteField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string EmailUser
        {
            get
            {
                return this.EmailUserField;
            }
            set
            {
                this.EmailUserField = value;
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public System.Nullable<bool> PrintBinary
        {
            get
            {
                return this.PrintBinaryField;
            }
            set
            {
                this.PrintBinaryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public bool JustRecordQuote
        {
            get
            {
                return this.JustRecordQuoteField;
            }
            set
            {
                this.JustRecordQuoteField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GenerateWSTempPrinterRequest", Namespace="http://tempuri.org/")]
    public partial class GenerateWSTempPrinterRequest : object
    {
        
        private int TempIdField;
        
        private int BranchCdField;
        
        private int PrefixNumField;
        
        private long DocumentNumberField;
        
        private string EmailUserField;
        
        private System.Nullable<bool> PrintBinaryField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string EmailUser
        {
            get
            {
                return this.EmailUserField;
            }
            set
            {
                this.EmailUserField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public System.Nullable<bool> PrintBinary
        {
            get
            {
                return this.PrintBinaryField;
            }
            set
            {
                this.PrintBinaryField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WsPrinter.IExternalPrinterService")]
    public interface IExternalPrinterService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExternalPrinterService/GenerateWSPolicyFormatCollect", ReplyAction="http://tempuri.org/IExternalPrinterService/GenerateWSPolicyFormatCollectResponse")]
        System.Threading.Tasks.Task<WsPrinter.GenerateWSPolicyFormatCollectResponse> GenerateWSPolicyFormatCollectAsync(WsPrinter.GenerateWSPolicyFormatCollectRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExternalPrinterService/GenerateWSPolicyPrinter", ReplyAction="http://tempuri.org/IExternalPrinterService/GenerateWSPolicyPrinterResponse")]
        System.Threading.Tasks.Task<WsPrinter.GenerateWSPolicyPrinterResponse> GenerateWSPolicyPrinterAsync(WsPrinter.GenerateWSPolicyPrinterRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExternalPrinterService/GenerateWSQuotePrinter", ReplyAction="http://tempuri.org/IExternalPrinterService/GenerateWSQuotePrinterResponse")]
        System.Threading.Tasks.Task<WsPrinter.GenerateWSQuotePrinterResponse> GenerateWSQuotePrinterAsync(WsPrinter.GenerateWSQuotePrinterRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExternalPrinterService/GenerateWSTempPrinter", ReplyAction="http://tempuri.org/IExternalPrinterService/GenerateWSTempPrinterResponse")]
        System.Threading.Tasks.Task<WsPrinter.GenerateWSTempPrinterResponse> GenerateWSTempPrinterAsync(WsPrinter.GenerateWSTempPrinterRequest1 request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GenerateWSPolicyFormatCollectRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GenerateWSPolicyFormatCollect", Namespace="http://tempuri.org/", Order=0)]
        public WsPrinter.GenerateWSPolicyFormatCollectRequest1Body Body;
        
        public GenerateWSPolicyFormatCollectRequest1()
        {
        }
        
        public GenerateWSPolicyFormatCollectRequest1(WsPrinter.GenerateWSPolicyFormatCollectRequest1Body Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GenerateWSPolicyFormatCollectRequest1Body
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WsPrinter.GenerateWSPolicyFormatCollectRequest generateWSPolicyFormatCollectRequest;
        
        public GenerateWSPolicyFormatCollectRequest1Body()
        {
        }
        
        public GenerateWSPolicyFormatCollectRequest1Body(WsPrinter.GenerateWSPolicyFormatCollectRequest generateWSPolicyFormatCollectRequest)
        {
            this.generateWSPolicyFormatCollectRequest = generateWSPolicyFormatCollectRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GenerateWSPolicyFormatCollectResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GenerateWSPolicyFormatCollectResponse", Namespace="http://tempuri.org/", Order=0)]
        public WsPrinter.GenerateWSPolicyFormatCollectResponseBody Body;
        
        public GenerateWSPolicyFormatCollectResponse()
        {
        }
        
        public GenerateWSPolicyFormatCollectResponse(WsPrinter.GenerateWSPolicyFormatCollectResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GenerateWSPolicyFormatCollectResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WsPrinter.PrinterClass GenerateWSPolicyFormatCollectResult;
        
        public GenerateWSPolicyFormatCollectResponseBody()
        {
        }
        
        public GenerateWSPolicyFormatCollectResponseBody(WsPrinter.PrinterClass GenerateWSPolicyFormatCollectResult)
        {
            this.GenerateWSPolicyFormatCollectResult = GenerateWSPolicyFormatCollectResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GenerateWSPolicyPrinterRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GenerateWSPolicyPrinter", Namespace="http://tempuri.org/", Order=0)]
        public WsPrinter.GenerateWSPolicyPrinterRequest1Body Body;
        
        public GenerateWSPolicyPrinterRequest1()
        {
        }
        
        public GenerateWSPolicyPrinterRequest1(WsPrinter.GenerateWSPolicyPrinterRequest1Body Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GenerateWSPolicyPrinterRequest1Body
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WsPrinter.GenerateWSPolicyPrinterRequest generateWSPolicyPrinterRequest;
        
        public GenerateWSPolicyPrinterRequest1Body()
        {
        }
        
        public GenerateWSPolicyPrinterRequest1Body(WsPrinter.GenerateWSPolicyPrinterRequest generateWSPolicyPrinterRequest)
        {
            this.generateWSPolicyPrinterRequest = generateWSPolicyPrinterRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GenerateWSPolicyPrinterResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GenerateWSPolicyPrinterResponse", Namespace="http://tempuri.org/", Order=0)]
        public WsPrinter.GenerateWSPolicyPrinterResponseBody Body;
        
        public GenerateWSPolicyPrinterResponse()
        {
        }
        
        public GenerateWSPolicyPrinterResponse(WsPrinter.GenerateWSPolicyPrinterResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GenerateWSPolicyPrinterResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WsPrinter.PrinterClass GenerateWSPolicyPrinterResult;
        
        public GenerateWSPolicyPrinterResponseBody()
        {
        }
        
        public GenerateWSPolicyPrinterResponseBody(WsPrinter.PrinterClass GenerateWSPolicyPrinterResult)
        {
            this.GenerateWSPolicyPrinterResult = GenerateWSPolicyPrinterResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GenerateWSQuotePrinterRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GenerateWSQuotePrinter", Namespace="http://tempuri.org/", Order=0)]
        public WsPrinter.GenerateWSQuotePrinterRequest1Body Body;
        
        public GenerateWSQuotePrinterRequest1()
        {
        }
        
        public GenerateWSQuotePrinterRequest1(WsPrinter.GenerateWSQuotePrinterRequest1Body Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GenerateWSQuotePrinterRequest1Body
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WsPrinter.GenerateWSQuotePrinterRequest generateWSQuotePrinterRequest;
        
        public GenerateWSQuotePrinterRequest1Body()
        {
        }
        
        public GenerateWSQuotePrinterRequest1Body(WsPrinter.GenerateWSQuotePrinterRequest generateWSQuotePrinterRequest)
        {
            this.generateWSQuotePrinterRequest = generateWSQuotePrinterRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GenerateWSQuotePrinterResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GenerateWSQuotePrinterResponse", Namespace="http://tempuri.org/", Order=0)]
        public WsPrinter.GenerateWSQuotePrinterResponseBody Body;
        
        public GenerateWSQuotePrinterResponse()
        {
        }
        
        public GenerateWSQuotePrinterResponse(WsPrinter.GenerateWSQuotePrinterResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GenerateWSQuotePrinterResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WsPrinter.PrinterClass GenerateWSQuotePrinterResult;
        
        public GenerateWSQuotePrinterResponseBody()
        {
        }
        
        public GenerateWSQuotePrinterResponseBody(WsPrinter.PrinterClass GenerateWSQuotePrinterResult)
        {
            this.GenerateWSQuotePrinterResult = GenerateWSQuotePrinterResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GenerateWSTempPrinterRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GenerateWSTempPrinter", Namespace="http://tempuri.org/", Order=0)]
        public WsPrinter.GenerateWSTempPrinterRequest1Body Body;
        
        public GenerateWSTempPrinterRequest1()
        {
        }
        
        public GenerateWSTempPrinterRequest1(WsPrinter.GenerateWSTempPrinterRequest1Body Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GenerateWSTempPrinterRequest1Body
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WsPrinter.GenerateWSTempPrinterRequest generateWSTempPrinterRequest;
        
        public GenerateWSTempPrinterRequest1Body()
        {
        }
        
        public GenerateWSTempPrinterRequest1Body(WsPrinter.GenerateWSTempPrinterRequest generateWSTempPrinterRequest)
        {
            this.generateWSTempPrinterRequest = generateWSTempPrinterRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GenerateWSTempPrinterResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GenerateWSTempPrinterResponse", Namespace="http://tempuri.org/", Order=0)]
        public WsPrinter.GenerateWSTempPrinterResponseBody Body;
        
        public GenerateWSTempPrinterResponse()
        {
        }
        
        public GenerateWSTempPrinterResponse(WsPrinter.GenerateWSTempPrinterResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GenerateWSTempPrinterResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WsPrinter.PrinterClass GenerateWSTempPrinterResult;
        
        public GenerateWSTempPrinterResponseBody()
        {
        }
        
        public GenerateWSTempPrinterResponseBody(WsPrinter.PrinterClass GenerateWSTempPrinterResult)
        {
            this.GenerateWSTempPrinterResult = GenerateWSTempPrinterResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface IExternalPrinterServiceChannel : WsPrinter.IExternalPrinterService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class ExternalPrinterServiceClient : System.ServiceModel.ClientBase<WsPrinter.IExternalPrinterService>, WsPrinter.IExternalPrinterService
    {
        
    /// <summary>
    /// Implemente este método parcial para configurar el punto de conexión de servicio.
    /// </summary>
    /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
    /// <param name="clientCredentials">Credenciales de cliente</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ExternalPrinterServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(ExternalPrinterServiceClient.GetBindingForEndpoint(endpointConfiguration), ExternalPrinterServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ExternalPrinterServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ExternalPrinterServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ExternalPrinterServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ExternalPrinterServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ExternalPrinterServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WsPrinter.GenerateWSPolicyFormatCollectResponse> WsPrinter.IExternalPrinterService.GenerateWSPolicyFormatCollectAsync(WsPrinter.GenerateWSPolicyFormatCollectRequest1 request)
        {
            return base.Channel.GenerateWSPolicyFormatCollectAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsPrinter.GenerateWSPolicyFormatCollectResponse> GenerateWSPolicyFormatCollectAsync(WsPrinter.GenerateWSPolicyFormatCollectRequest generateWSPolicyFormatCollectRequest)
        {
            WsPrinter.GenerateWSPolicyFormatCollectRequest1 inValue = new WsPrinter.GenerateWSPolicyFormatCollectRequest1();
            inValue.Body = new WsPrinter.GenerateWSPolicyFormatCollectRequest1Body();
            inValue.Body.generateWSPolicyFormatCollectRequest = generateWSPolicyFormatCollectRequest;
            return ((WsPrinter.IExternalPrinterService)(this)).GenerateWSPolicyFormatCollectAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WsPrinter.GenerateWSPolicyPrinterResponse> WsPrinter.IExternalPrinterService.GenerateWSPolicyPrinterAsync(WsPrinter.GenerateWSPolicyPrinterRequest1 request)
        {
            return base.Channel.GenerateWSPolicyPrinterAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsPrinter.GenerateWSPolicyPrinterResponse> GenerateWSPolicyPrinterAsync(WsPrinter.GenerateWSPolicyPrinterRequest generateWSPolicyPrinterRequest)
        {
            WsPrinter.GenerateWSPolicyPrinterRequest1 inValue = new WsPrinter.GenerateWSPolicyPrinterRequest1();
            inValue.Body = new WsPrinter.GenerateWSPolicyPrinterRequest1Body();
            inValue.Body.generateWSPolicyPrinterRequest = generateWSPolicyPrinterRequest;
            return ((WsPrinter.IExternalPrinterService)(this)).GenerateWSPolicyPrinterAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WsPrinter.GenerateWSQuotePrinterResponse> WsPrinter.IExternalPrinterService.GenerateWSQuotePrinterAsync(WsPrinter.GenerateWSQuotePrinterRequest1 request)
        {
            return base.Channel.GenerateWSQuotePrinterAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsPrinter.GenerateWSQuotePrinterResponse> GenerateWSQuotePrinterAsync(WsPrinter.GenerateWSQuotePrinterRequest generateWSQuotePrinterRequest)
        {
            WsPrinter.GenerateWSQuotePrinterRequest1 inValue = new WsPrinter.GenerateWSQuotePrinterRequest1();
            inValue.Body = new WsPrinter.GenerateWSQuotePrinterRequest1Body();
            inValue.Body.generateWSQuotePrinterRequest = generateWSQuotePrinterRequest;
            return ((WsPrinter.IExternalPrinterService)(this)).GenerateWSQuotePrinterAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WsPrinter.GenerateWSTempPrinterResponse> WsPrinter.IExternalPrinterService.GenerateWSTempPrinterAsync(WsPrinter.GenerateWSTempPrinterRequest1 request)
        {
            return base.Channel.GenerateWSTempPrinterAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsPrinter.GenerateWSTempPrinterResponse> GenerateWSTempPrinterAsync(WsPrinter.GenerateWSTempPrinterRequest generateWSTempPrinterRequest)
        {
            WsPrinter.GenerateWSTempPrinterRequest1 inValue = new WsPrinter.GenerateWSTempPrinterRequest1();
            inValue.Body = new WsPrinter.GenerateWSTempPrinterRequest1Body();
            inValue.Body.generateWSTempPrinterRequest = generateWSTempPrinterRequest;
            return ((WsPrinter.IExternalPrinterService)(this)).GenerateWSTempPrinterAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IExternalPrinterService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IExternalPrinterService1))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IExternalPrinterService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:4000/External/ExternalPrinterServices");
            }
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IExternalPrinterService1))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:4000/ExternalPrinterServices");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IExternalPrinterService,
            
            BasicHttpBinding_IExternalPrinterService1,
        }
    }
}
