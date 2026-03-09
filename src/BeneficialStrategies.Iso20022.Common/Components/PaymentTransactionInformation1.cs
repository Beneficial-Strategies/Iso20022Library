// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information concerning the original transactions, to which the status report message refers.
/// </summary>
[IsoId("_PsqLS9p-Ed-ak6NoX_4Aeg_-1746248440")]
[DisplayName("Payment Transaction Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentTransactionInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification as assigned by an instructing party for an instructed party to unambiguously identify the reported status.
    /// </summary>
    [IsoId("_PsqLTNp-Ed-ak6NoX_4Aeg_-1746248422")]
    [DisplayName("Status Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsId")]
    #endif
    [IsoXmlTag("StsId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? StatusIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? StatusIdentification { get; init; } 
    #else
    public System.String? StatusIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier of the original payment information block as assigned by the original sending party.
    /// </summary>
    [IsoId("_PsqLTdp-Ed-ak6NoX_4Aeg_-1746248388")]
    [DisplayName("Original Payment Information Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlPmtInfId")]
    #endif
    [IsoXmlTag("OrgnlPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalPaymentInformationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalPaymentInformationIdentification { get; init; } 
    #else
    public System.String? OriginalPaymentInformationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Original unique instruction identification as assigned by an instructing party for an instructed party to unambiguously identify the original instruction.||Usage: the original instruction identification is the original point to point reference used between the instructing party and the instructed party to refer to the original instruction.
    /// </summary>
    [IsoId("_Psz8QNp-Ed-ak6NoX_4Aeg_-1746248345")]
    [DisplayName("Original Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlInstrId")]
    #endif
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalInstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalInstructionIdentification { get; init; } 
    #else
    public System.String? OriginalInstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Original unique identification assigned by the initiating party to unambiguously identify the original transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain.
    /// </summary>
    [IsoId("_Psz8Qdp-Ed-ak6NoX_4Aeg_-1746248093")]
    [DisplayName("Original End To End Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlEndToEndId")]
    #endif
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalEndToEndIdentification { get; init; } 
    #else
    public System.String? OriginalEndToEndIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Original identification of a transaction, as assigned by the first instructing agent and passed on, unchanged, throughout the entire interbank chain.
    /// </summary>
    [IsoId("_Psz8Qtp-Ed-ak6NoX_4Aeg_-1746248051")]
    [DisplayName("Original Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlTxId")]
    #endif
    [IsoXmlTag("OrgnlTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalTransactionIdentification { get; init; } 
    #else
    public System.String? OriginalTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the status of a transaction, in a coded form.
    /// </summary>
    [IsoId("_Psz8Q9p-Ed-ak6NoX_4Aeg_-899379634")]
    [DisplayName("Transaction Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSts")]
    #endif
    [IsoXmlTag("TxSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionIndividualStatus1Code? TransactionStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIndividualStatus1Code? TransactionStatus { get; init; } 
    #else
    public TransactionIndividualStatus1Code? TransactionStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed information on the status reason.
    /// </summary>
    [IsoId("_Psz8RNp-Ed-ak6NoX_4Aeg_-759927206")]
    [DisplayName("Status Reason Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsRsnInf")]
    #endif
    [IsoXmlTag("StsRsnInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatusReasonInformation1? StatusReasonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatusReasonInformation1? StatusReasonInformation { get; init; } 
    #else
    public StatusReasonInformation1? StatusReasonInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information on charges related to the processing of the rejection of the instruction.||Usage: ChargesInformation is past on for information purposes only. Settlement of the charges will be done separately.
    /// </summary>
    [IsoId("_Psz8Rdp-Ed-ak6NoX_4Aeg_-1746247473")]
    [DisplayName("Charges Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsInf")]
    #endif
    [IsoXmlTag("ChrgsInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChargesInformation1? ChargesInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargesInformation1? ChargesInformation { get; init; } 
    #else
    public ChargesInformation1? ChargesInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Point in time when the payment order from the initiating party meets the processing conditions of the account servicing agent (debtor&apos;s agent in case of a credit transfer, creditor&apos;s agent in case of a direct debit). This means - amongst others - that the account servicing agent has received the payment order and has applied checks as eg, authorisation, availability of funds.
    /// </summary>
    [IsoId("_Psz8Rtp-Ed-ak6NoX_4Aeg_-25727012")]
    [DisplayName("Acceptance Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AccptncDtTm")]
    #endif
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? AcceptanceDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? AcceptanceDateTime { get; init; } 
    #else
    public System.DateTime? AcceptanceDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_Psz8R9p-Ed-ak6NoX_4Aeg_813463923")]
    [DisplayName("Instructing Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstgAgt")]
    #endif
    [IsoXmlTag("InstgAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification3? InstructingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification3? InstructingAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification3? InstructingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_Psz8SNp-Ed-ak6NoX_4Aeg_813464102")]
    [DisplayName("Instructed Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdAgt")]
    #endif
    [IsoXmlTag("InstdAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification3? InstructedAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification3? InstructedAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification3? InstructedAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Set of key elements of the original transaction being referred to.
    /// </summary>
    [IsoId("_Ps9tQNp-Ed-ak6NoX_4Aeg_-1746247378")]
    [DisplayName("Original Transaction Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlTxRef")]
    #endif
    [IsoXmlTag("OrgnlTxRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalTransactionReference1? OriginalTransactionReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalTransactionReference1? OriginalTransactionReference { get; init; } 
    #else
    public OriginalTransactionReference1? OriginalTransactionReference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
