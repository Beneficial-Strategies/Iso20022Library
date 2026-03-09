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
/// Defines the criteria used to report on the payment.
/// </summary>
[IsoId("_RKiehdp-Ed-ak6NoX_4Aeg_-1663577418")]
[DisplayName("Payment Return Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentReturnCriteria2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the transaction reference is requested.
    /// </summary>
    [IsoId("_RKiehtp-Ed-ak6NoX_4Aeg_-1662656188")]
    [DisplayName("Transaction Reference Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxRefInd")]
    #endif
    [IsoXmlTag("TxRefInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? TransactionReferenceIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionReferenceIndicator { get; init; } 
    #else
    public System.String? TransactionReferenceIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the transfer value date is requested.
    /// </summary>
    [IsoId("_RKieh9p-Ed-ak6NoX_4Aeg_-1662656651")]
    [DisplayName("Transfer Value Date Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfValDtInd")]
    #endif
    [IsoXmlTag("TrfValDtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? TransferValueDateIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransferValueDateIndicator { get; init; } 
    #else
    public System.String? TransferValueDateIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the instruction is requested.
    /// </summary>
    [IsoId("_RKieiNp-Ed-ak6NoX_4Aeg_-1662657196")]
    [DisplayName("Instruction Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrInd")]
    #endif
    [IsoXmlTag("InstrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? InstructionIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InstructionIndicator { get; init; } 
    #else
    public System.String? InstructionIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the instruction status is requested.
    /// </summary>
    [IsoId("_RKsPgNp-Ed-ak6NoX_4Aeg_-1662657076")]
    [DisplayName("Instruction Status Return Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrStsRtrCrit")]
    #endif
    [IsoXmlTag("InstrStsRtrCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InstructionStatusReturnCriteria? InstructionStatusReturnCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructionStatusReturnCriteria? InstructionStatusReturnCriteria { get; init; } 
    #else
    public InstructionStatusReturnCriteria? InstructionStatusReturnCriteria { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the instructed amount is requested.
    /// </summary>
    [IsoId("_RKsPgdp-Ed-ak6NoX_4Aeg_-1662657136")]
    [DisplayName("Instructed Amount Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdAmtInd")]
    #endif
    [IsoXmlTag("InstdAmtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? InstructedAmountIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InstructedAmountIndicator { get; init; } 
    #else
    public System.String? InstructedAmountIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the Payment Instruction Reference is requested.
    /// </summary>
    [IsoId("_RKsPgtp-Ed-ak6NoX_4Aeg_351278396")]
    [DisplayName("Credit Debit Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtDbtInd")]
    #endif
    [IsoXmlTag("CdtDbtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? CreditDebitIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CreditDebitIndicator { get; init; } 
    #else
    public System.String? CreditDebitIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the interbank settlement amount is requested.
    /// </summary>
    [IsoId("_RKsPg9p-Ed-ak6NoX_4Aeg_-1662656807")]
    [DisplayName("Interbank Settlement Amount Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrBkSttlmAmtInd")]
    #endif
    [IsoXmlTag("IntrBkSttlmAmtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? InterbankSettlementAmountIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InterbankSettlementAmountIndicator { get; init; } 
    #else
    public System.String? InterbankSettlementAmountIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the payment priority is requested.
    /// </summary>
    [IsoId("_RKsPhNp-Ed-ak6NoX_4Aeg_-1662657291")]
    [DisplayName("Priority Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtyInd")]
    #endif
    [IsoXmlTag("PrtyInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? PriorityIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PriorityIndicator { get; init; } 
    #else
    public System.String? PriorityIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the processing validity time is requested.
    /// </summary>
    [IsoId("_RKsPhdp-Ed-ak6NoX_4Aeg_-1662657231")]
    [DisplayName("Processing Validity Time Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcgVldtyTmInd")]
    #endif
    [IsoXmlTag("PrcgVldtyTmInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? ProcessingValidityTimeIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProcessingValidityTimeIndicator { get; init; } 
    #else
    public System.String? ProcessingValidityTimeIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the transfer reason is requested.
    /// </summary>
    [IsoId("_RKsPhtp-Ed-ak6NoX_4Aeg_-1662656360")]
    [DisplayName("Purpose Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PurpInd")]
    #endif
    [IsoXmlTag("PurpInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? PurposeIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PurposeIndicator { get; init; } 
    #else
    public System.String? PurposeIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the instruction copy is requested.
    /// </summary>
    [IsoId("_RKsPh9p-Ed-ak6NoX_4Aeg_-1662656248")]
    [DisplayName("Instruction Copy Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrCpyInd")]
    #endif
    [IsoXmlTag("InstrCpyInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? InstructionCopyIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InstructionCopyIndicator { get; init; } 
    #else
    public System.String? InstructionCopyIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the payment message type is requested.
    /// </summary>
    [IsoId("_RKsPiNp-Ed-ak6NoX_4Aeg_-1662656300")]
    [DisplayName("Payment Message Type Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtMsgTpInd")]
    #endif
    [IsoXmlTag("PmtMsgTpInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? PaymentMessageTypeIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PaymentMessageTypeIndicator { get; init; } 
    #else
    public System.String? PaymentMessageTypeIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the payment type is requested.
    /// </summary>
    [IsoId("_RK1ZcNp-Ed-ak6NoX_4Aeg_-1663577399")]
    [DisplayName("Payment Type Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtTpInd")]
    #endif
    [IsoXmlTag("PmtTpInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? PaymentTypeIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PaymentTypeIndicator { get; init; } 
    #else
    public System.String? PaymentTypeIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the Payment Instruction Reference is requested.
    /// </summary>
    [IsoId("_RK1Zcdp-Ed-ak6NoX_4Aeg_-1175959206")]
    [DisplayName("Payment Instruction Reference Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtInstrRefInd")]
    #endif
    [IsoXmlTag("PmtInstrRefInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? PaymentInstructionReferenceIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PaymentInstructionReferenceIndicator { get; init; } 
    #else
    public System.String? PaymentInstructionReferenceIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the Interbank Value Date is requested.
    /// </summary>
    [IsoId("_RK1Zctp-Ed-ak6NoX_4Aeg_313679236")]
    [DisplayName("Interbank Value Date Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrBkValDtInd")]
    #endif
    [IsoXmlTag("IntrBkValDtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? InterbankValueDateIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InterbankValueDateIndicator { get; init; } 
    #else
    public System.String? InterbankValueDateIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the Related Reference is requested.
    /// </summary>
    [IsoId("_RK1Zc9p-Ed-ak6NoX_4Aeg_211167351")]
    [DisplayName("Related Reference Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRefInd")]
    #endif
    [IsoXmlTag("RltdRefInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? RelatedReferenceIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RelatedReferenceIndicator { get; init; } 
    #else
    public System.String? RelatedReferenceIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the Payment Method is requested.
    /// </summary>
    [IsoId("_RK1ZdNp-Ed-ak6NoX_4Aeg_1203028604")]
    [DisplayName("Payment Method Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtMtdInd")]
    #endif
    [IsoXmlTag("PmtMtdInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? PaymentMethodIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PaymentMethodIndicator { get; init; } 
    #else
    public System.String? PaymentMethodIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the Debtor is requested.
    /// </summary>
    [IsoId("_RK_KcNp-Ed-ak6NoX_4Aeg_-754618295")]
    [DisplayName("Debtor Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrInd")]
    #endif
    [IsoXmlTag("DbtrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? DebtorIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DebtorIndicator { get; init; } 
    #else
    public System.String? DebtorIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the First Agent is requested.
    /// </summary>
    [IsoId("_RK_Kcdp-Ed-ak6NoX_4Aeg_-484951167")]
    [DisplayName("First Agent Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrstAgtInd")]
    #endif
    [IsoXmlTag("FrstAgtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? FirstAgentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FirstAgentIndicator { get; init; } 
    #else
    public System.String? FirstAgentIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the correspondent of the Instructing Agent is requested.
    /// </summary>
    [IsoId("_RK_Kctp-Ed-ak6NoX_4Aeg_-470172535")]
    [DisplayName("Instructing Agent Correspondent Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstgAgtCrspdtInd")]
    #endif
    [IsoXmlTag("InstgAgtCrspdtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? InstructingAgentCorrespondentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InstructingAgentCorrespondentIndicator { get; init; } 
    #else
    public System.String? InstructingAgentCorrespondentIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the correspondent of the Instructed Agent is requested.
    /// </summary>
    [IsoId("_RK_Kc9p-Ed-ak6NoX_4Aeg_-444314494")]
    [DisplayName("Instructed Agent Correspondent Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdAgtCrspdtInd")]
    #endif
    [IsoXmlTag("InstdAgtCrspdtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? InstructedAgentCorrespondentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InstructedAgentCorrespondentIndicator { get; init; } 
    #else
    public System.String? InstructedAgentCorrespondentIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the Intermediary is requested.
    /// </summary>
    [IsoId("_RK_KdNp-Ed-ak6NoX_4Aeg_-424921485")]
    [DisplayName("Intermediary Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyInd")]
    #endif
    [IsoXmlTag("IntrmyInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? IntermediaryIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? IntermediaryIndicator { get; init; } 
    #else
    public System.String? IntermediaryIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the Final Agent is requested.
    /// </summary>
    [IsoId("_RK_Kddp-Ed-ak6NoX_4Aeg_-411070416")]
    [DisplayName("Final Agent Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FnlAgtInd")]
    #endif
    [IsoXmlTag("FnlAgtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? FinalAgentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FinalAgentIndicator { get; init; } 
    #else
    public System.String? FinalAgentIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the Creditor is requested.
    /// </summary>
    [IsoId("_RK_Kdtp-Ed-ak6NoX_4Aeg_-398141338")]
    [DisplayName("Creditor Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrInd")]
    #endif
    [IsoXmlTag("CdtrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? CreditorIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CreditorIndicator { get; init; } 
    #else
    public System.String? CreditorIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
