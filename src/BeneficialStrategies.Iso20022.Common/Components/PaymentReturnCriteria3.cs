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
[IsoId("_733gwKMgEeCJ6YNENx4h-w_-1718054260")]
[DisplayName("Payment Return Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentReturnCriteria3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the original payment transaction message identification is requested.|Usage: this is the former TransactionReference.
    /// </summary>
    [IsoId("_733gwaMgEeCJ6YNENx4h-w_1579840683")]
    [DisplayName("Message Identification Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgIdInd")]
    #endif
    [IsoXmlTag("MsgIdInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? MessageIdentificationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MessageIdentificationIndicator { get; init; } 
    #else
    public System.String? MessageIdentificationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the requested execution date is requested.|Usage: this is the former TransferValueDate.
    /// </summary>
    [IsoId("_733gwqMgEeCJ6YNENx4h-w_468929264")]
    [DisplayName("Requested Execution Date Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdExctnDtInd")]
    #endif
    [IsoXmlTag("ReqdExctnDtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? RequestedExecutionDateIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RequestedExecutionDateIndicator { get; init; } 
    #else
    public System.String? RequestedExecutionDateIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the instruction is requested.
    /// </summary>
    [IsoId("_733gw6MgEeCJ6YNENx4h-w_-1377806057")]
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
    [IsoId("_733gxKMgEeCJ6YNENx4h-w_1036855599")]
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
    [IsoId("_733gxaMgEeCJ6YNENx4h-w_1516938780")]
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
    /// Indicates whether the credit debit indicator is requested.
    /// </summary>
    [IsoId("_733gxqMgEeCJ6YNENx4h-w_1987015190")]
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
    [IsoId("_733gx6MgEeCJ6YNENx4h-w_-1474278279")]
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
    [IsoId("_74BRwKMgEeCJ6YNENx4h-w_-1852896575")]
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
    [IsoId("_74BRwaMgEeCJ6YNENx4h-w_638803782")]
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
    [IsoId("_74BRwqMgEeCJ6YNENx4h-w_-1092131422")]
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
    [IsoId("_74BRw6MgEeCJ6YNENx4h-w_1399568935")]
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
    [IsoId("_74BRxKMgEeCJ6YNENx4h-w_-506184396")]
    [DisplayName("Payment Message Type Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtMTInd")]
    #endif
    [IsoXmlTag("PmtMTInd")]
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
    [IsoId("_74BRxaMgEeCJ6YNENx4h-w_1985515961")]
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
    /// Indicates whether the transaction identification is requested.|Usage: this is the former PaymentInstructionReference.
    /// </summary>
    [IsoId("_74BRxqMgEeCJ6YNENx4h-w_-1884867339")]
    [DisplayName("Transaction Identification Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxIdInd")]
    #endif
    [IsoXmlTag("TxIdInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? TransactionIdentificationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionIdentificationIndicator { get; init; } 
    #else
    public System.String? TransactionIdentificationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the interbank settlement date is requested.|Usage: this is the former InterbankValueDate.
    /// </summary>
    [IsoId("_74BRx6MgEeCJ6YNENx4h-w_529794317")]
    [DisplayName("Interbank Settlement Date Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrBkSttlmDtInd")]
    #endif
    [IsoXmlTag("IntrBkSttlmDtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? InterbankSettlementDateIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InterbankSettlementDateIndicator { get; init; } 
    #else
    public System.String? InterbankSettlementDateIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the end-to-end identification is requested.|Usage: this is the former RelatedReference.
    /// </summary>
    [IsoId("_74LCwKMgEeCJ6YNENx4h-w_-581117102")]
    [DisplayName("End To End Identification Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndToEndIdInd")]
    #endif
    [IsoXmlTag("EndToEndIdInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? EndToEndIdentificationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EndToEndIdentificationIndicator { get; init; } 
    #else
    public System.String? EndToEndIdentificationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the payment method is requested.
    /// </summary>
    [IsoId("_74LCwaMgEeCJ6YNENx4h-w_-1559749832")]
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
    /// Indicates whether the debtor is requested.
    /// </summary>
    [IsoId("_74LCwqMgEeCJ6YNENx4h-w_854911824")]
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
    /// Indicates whether the debtor agent is requested.|Usage: this is the former FirstAgent.
    /// </summary>
    [IsoId("_74LCw6MgEeCJ6YNENx4h-w_-481729494")]
    [DisplayName("Debtor Agent Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAgtInd")]
    #endif
    [IsoXmlTag("DbtrAgtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? DebtorAgentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DebtorAgentIndicator { get; init; } 
    #else
    public System.String? DebtorAgentIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the instructing reimbursement agent is requested.
    /// Usage: this is the former InstructingAgentCorrespondent.
    /// </summary>
    [IsoId("_74LCxKMgEeCJ6YNENx4h-w_1932932162")]
    [DisplayName("Instructing Reimbursement Agent Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstgRmbrsmntAgtInd")]
    #endif
    [IsoXmlTag("InstgRmbrsmntAgtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? InstructingReimbursementAgentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InstructingReimbursementAgentIndicator { get; init; } 
    #else
    public System.String? InstructingReimbursementAgentIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the instructed reimbursement agent is requested.
    /// Usage: this is the former InstructedAgentCorrespondent.
    /// </summary>
    [IsoId("_74LCxaMgEeCJ6YNENx4h-w_725260606")]
    [DisplayName("Instructed Reimbursement Agent Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdRmbrsmntAgtInd")]
    #endif
    [IsoXmlTag("InstdRmbrsmntAgtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? InstructedReimbursementAgentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InstructedReimbursementAgentIndicator { get; init; } 
    #else
    public System.String? InstructedReimbursementAgentIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the intermediary is requested.
    /// </summary>
    [IsoId("_74LCxqMgEeCJ6YNENx4h-w_-1155045034")]
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
    /// Indicates whether the creditor agent is requested.|Usage: this is the former FinalAgent.
    /// </summary>
    [IsoId("_74UMsKMgEeCJ6YNENx4h-w_1803280944")]
    [DisplayName("Creditor Agent Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAgtInd")]
    #endif
    [IsoXmlTag("CdtrAgtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? CreditorAgentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CreditorAgentIndicator { get; init; } 
    #else
    public System.String? CreditorAgentIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the creditor is requested.
    /// </summary>
    [IsoId("_74UMsaMgEeCJ6YNENx4h-w_-77024696")]
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
