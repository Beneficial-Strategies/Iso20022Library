// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.OriginalActivation2Choice
{
    /// <summary>
    /// Provides the full original activation data.
    /// </summary>
    [IsoId("_UPBU8-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Original Activation Data")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record OriginalActivationData : OriginalActivation2Choice_
    #else
    public partial class OriginalActivationData : OriginalActivation2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a OriginalActivationData instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public OriginalActivationData( RTPPartyIdentification1 reqDebtor,RTPPartyIdentification1 reqDebtorSolutionProvider,RTPPartyIdentification1 reqCreditor )
        {
            Debtor = reqDebtor;
            DebtorSolutionProvider = reqDebtorSolutionProvider;
            Creditor = reqCreditor;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique identification, as assigned by the initiating party, to unambiguously identify the activation.
        /// Usage:
        /// This element may be used for technical reconciliation purpose.
        /// </summary>
        [IsoId("_UQacEeH7Eeqbls7Gk4-ckA")]
        [DisplayName("Debtor Activation Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DbtrActvtnId")]
        #endif
        [IsoXmlTag("DbtrActvtnId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? DebtorActivationIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? DebtorActivationIdentification { get; init; } 
        #else
        public System.String? DebtorActivationIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Name by which the debtor is known, other than legal name, such as the name to be shown to the creditor. 
        /// </summary>
        [IsoId("_UQacE-H7Eeqbls7Gk4-ckA")]
        [DisplayName("Display Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DispNm")]
        #endif
        [IsoXmlTag("DispNm")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax140Text? DisplayName { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? DisplayName { get; init; } 
        #else
        public System.String? DisplayName { get; set; } 
        #endif
        
        /// <summary>
        /// Ultimate party that owes an amount of money to the (ultimate) creditor.
        /// </summary>
        [IsoId("_UQacFeH7Eeqbls7Gk4-ckA")]
        [DisplayName("Ultimate Debtor")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UltmtDbtr")]
        #endif
        [IsoXmlTag("UltmtDbtr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public RTPPartyIdentification1? UltimateDebtor { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public RTPPartyIdentification1? UltimateDebtor { get; init; } 
        #else
        public RTPPartyIdentification1? UltimateDebtor { get; set; } 
        #endif
        
        /// <summary>
        /// Party that owes an amount of money to the (ultimate) creditor.
        /// </summary>
        [IsoId("_UQacF-H7Eeqbls7Gk4-ckA")]
        [DisplayName("Debtor")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Dbtr")]
        #endif
        [IsoXmlTag("Dbtr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required RTPPartyIdentification1 Debtor { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required RTPPartyIdentification1 Debtor { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public RTPPartyIdentification1 Debtor { get; init; } 
        #else
        public RTPPartyIdentification1 Debtor { get; set; } 
        #endif
        
        /// <summary>
        /// Organisation servicing the e-invoicing for the debtor (to which the activation status report must be sent).
        /// </summary>
        [IsoId("_UQacGeH7Eeqbls7Gk4-ckA")]
        [DisplayName("Debtor Solution Provider")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DbtrSolPrvdr")]
        #endif
        [IsoXmlTag("DbtrSolPrvdr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required RTPPartyIdentification1 DebtorSolutionProvider { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required RTPPartyIdentification1 DebtorSolutionProvider { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public RTPPartyIdentification1 DebtorSolutionProvider { get; init; } 
        #else
        public RTPPartyIdentification1 DebtorSolutionProvider { get; set; } 
        #endif
        
        /// <summary>
        /// Unique identifier of the debtor required by the creditor, for example  the reference number or customer number. Unique identification provided by the web bank or web payment services user, with which the creditor may identify the debtor in its system.
        /// </summary>
        [IsoId("_UQacG-H7Eeqbls7Gk4-ckA")]
        [DisplayName("Customer Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CstmrId")]
        #endif
        [IsoXmlTag("CstmrId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Party49Choice_? CustomerIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Party49Choice_? CustomerIdentification { get; init; } 
        #else
        public Party49Choice_? CustomerIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Document format type supported to exchange the contracts.
        /// </summary>
        [IsoId("_UQacHeH7Eeqbls7Gk4-ckA")]
        [DisplayName("Contract Format Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CtrctFrmtTp")]
        #endif
        [IsoXmlTag("CtrctFrmtTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DocumentFormat2Choice_? ContractFormatType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DocumentFormat2Choice_? ContractFormatType { get; init; } 
        #else
        public DocumentFormat2Choice_? ContractFormatType { get; set; } 
        #endif
        
        /// <summary>
        /// Code choice external/prop
        /// Description
        /// identical to the Instruction for Debtor
        /// </summary>
        [IsoId("_UQacH-H7Eeqbls7Gk4-ckA")]
        [DisplayName("Contract Reference")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CtrctRef")]
        #endif
        [IsoXmlTag("CtrctRef")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ContractReference1? ContractReference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ContractReference1? ContractReference { get; init; } 
        #else
        public ContractReference1? ContractReference { get; set; } 
        #endif
        
        /// <summary>
        /// Party to which an amount of money is due.
        /// </summary>
        [IsoId("_UQacIeH7Eeqbls7Gk4-ckA")]
        [DisplayName("Creditor")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Cdtr")]
        #endif
        [IsoXmlTag("Cdtr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required RTPPartyIdentification1 Creditor { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required RTPPartyIdentification1 Creditor { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public RTPPartyIdentification1 Creditor { get; init; } 
        #else
        public RTPPartyIdentification1 Creditor { get; set; } 
        #endif
        
        /// <summary>
        /// Ultimate party to which an amount of money is due.
        /// </summary>
        [IsoId("_UQacI-H7Eeqbls7Gk4-ckA")]
        [DisplayName("Ultimate Creditor")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UltmtCdtr")]
        #endif
        [IsoXmlTag("UltmtCdtr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public RTPPartyIdentification1? UltimateCreditor { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public RTPPartyIdentification1? UltimateCreditor { get; init; } 
        #else
        public RTPPartyIdentification1? UltimateCreditor { get; set; } 
        #endif
        
        /// <summary>
        /// Creditor&apos;s service provider address to which the debtor activation has to be delivered.
        /// </summary>
        [IsoId("_UQacJeH7Eeqbls7Gk4-ckA")]
        [DisplayName("Activation Request Delivery Party")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ActvtnReqDlvryPty")]
        #endif
        [IsoXmlTag("ActvtnReqDlvryPty")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public RTPPartyIdentification1? ActivationRequestDeliveryParty { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public RTPPartyIdentification1? ActivationRequestDeliveryParty { get; init; } 
        #else
        public RTPPartyIdentification1? ActivationRequestDeliveryParty { get; set; } 
        #endif
        
        /// <summary>
        /// Date and time at which the debtor activation will be activated.
        /// </summary>
        [IsoId("_UQacJ-H7Eeqbls7Gk4-ckA")]
        [DisplayName("Start Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="StartDt")]
        #endif
        [IsoXmlTag("StartDt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DateAndDateTime2Choice_? StartDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DateAndDateTime2Choice_? StartDate { get; init; } 
        #else
        public DateAndDateTime2Choice_? StartDate { get; set; } 
        #endif
        
        /// <summary>
        /// Date and time at which the debtor activation will be deactivated.
        /// </summary>
        [IsoId("_UQacKeH7Eeqbls7Gk4-ckA")]
        [DisplayName("End Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="EndDt")]
        #endif
        [IsoXmlTag("EndDt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DateAndDateTime2Choice_? EndDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DateAndDateTime2Choice_? EndDate { get; init; } 
        #else
        public DateAndDateTime2Choice_? EndDate { get; set; } 
        #endif
        
        /// <summary>
        /// Unique, one-time code that a creditor may require from a debtor for activation purposes, and which is known only by the creditor and the debtor.
        /// </summary>
        [IsoId("_UQacMeH7Eeqbls7Gk4-ckA")]
        [DisplayName("Dedicated Activation Code")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DdctdActvtnCd")]
        #endif
        [IsoXmlTag("DdctdActvtnCd")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? DedicatedActivationCode { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? DedicatedActivationCode { get; init; } 
        #else
        public System.String? DedicatedActivationCode { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
