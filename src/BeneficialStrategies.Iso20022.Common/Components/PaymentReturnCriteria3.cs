// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to report on the payment.
/// </summary>
[IsoId("_733gwKMgEeCJ6YNENx4h-w_-1718054260")]
[DisplayName("Payment Return Criteria")]
public partial record PaymentReturnCriteria3
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the original payment transaction message identification is requested.|Usage: this is the former TransactionReference.
    /// </summary>
    [IsoId("_733gwaMgEeCJ6YNENx4h-w_1579840683")]
    [DisplayName("Message Identification Indicator")]
    [IsoXmlTag("MsgIdInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? MessageIdentificationIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the requested execution date is requested.|Usage: this is the former TransferValueDate.
    /// </summary>
    [IsoId("_733gwqMgEeCJ6YNENx4h-w_468929264")]
    [DisplayName("Requested Execution Date Indicator")]
    [IsoXmlTag("ReqdExctnDtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? RequestedExecutionDateIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the instruction is requested.
    /// </summary>
    [IsoId("_733gw6MgEeCJ6YNENx4h-w_-1377806057")]
    [DisplayName("Instruction Indicator")]
    [IsoXmlTag("InstrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? InstructionIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the instruction status is requested.
    /// </summary>
    [IsoId("_733gxKMgEeCJ6YNENx4h-w_1036855599")]
    [DisplayName("Instruction Status Return Criteria")]
    [IsoXmlTag("InstrStsRtrCrit")]
    public InstructionStatusReturnCriteria? InstructionStatusReturnCriteria { get; init; } 
    
    /// <summary>
    /// Indicates whether the instructed amount is requested.
    /// </summary>
    [IsoId("_733gxaMgEeCJ6YNENx4h-w_1516938780")]
    [DisplayName("Instructed Amount Indicator")]
    [IsoXmlTag("InstdAmtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? InstructedAmountIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the credit debit indicator is requested.
    /// </summary>
    [IsoId("_733gxqMgEeCJ6YNENx4h-w_1987015190")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? CreditDebitIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the interbank settlement amount is requested.
    /// </summary>
    [IsoId("_733gx6MgEeCJ6YNENx4h-w_-1474278279")]
    [DisplayName("Interbank Settlement Amount Indicator")]
    [IsoXmlTag("IntrBkSttlmAmtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? InterbankSettlementAmountIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the payment priority is requested.
    /// </summary>
    [IsoId("_74BRwKMgEeCJ6YNENx4h-w_-1852896575")]
    [DisplayName("Priority Indicator")]
    [IsoXmlTag("PrtyInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? PriorityIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the processing validity time is requested.
    /// </summary>
    [IsoId("_74BRwaMgEeCJ6YNENx4h-w_638803782")]
    [DisplayName("Processing Validity Time Indicator")]
    [IsoXmlTag("PrcgVldtyTmInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? ProcessingValidityTimeIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the transfer reason is requested.
    /// </summary>
    [IsoId("_74BRwqMgEeCJ6YNENx4h-w_-1092131422")]
    [DisplayName("Purpose Indicator")]
    [IsoXmlTag("PurpInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? PurposeIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the instruction copy is requested.
    /// </summary>
    [IsoId("_74BRw6MgEeCJ6YNENx4h-w_1399568935")]
    [DisplayName("Instruction Copy Indicator")]
    [IsoXmlTag("InstrCpyInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? InstructionCopyIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the payment message type is requested.
    /// </summary>
    [IsoId("_74BRxKMgEeCJ6YNENx4h-w_-506184396")]
    [DisplayName("Payment Message Type Indicator")]
    [IsoXmlTag("PmtMTInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? PaymentMessageTypeIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the payment type is requested.
    /// </summary>
    [IsoId("_74BRxaMgEeCJ6YNENx4h-w_1985515961")]
    [DisplayName("Payment Type Indicator")]
    [IsoXmlTag("PmtTpInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? PaymentTypeIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the transaction identification is requested.|Usage: this is the former PaymentInstructionReference.
    /// </summary>
    [IsoId("_74BRxqMgEeCJ6YNENx4h-w_-1884867339")]
    [DisplayName("Transaction Identification Indicator")]
    [IsoXmlTag("TxIdInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? TransactionIdentificationIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the interbank settlement date is requested.|Usage: this is the former InterbankValueDate.
    /// </summary>
    [IsoId("_74BRx6MgEeCJ6YNENx4h-w_529794317")]
    [DisplayName("Interbank Settlement Date Indicator")]
    [IsoXmlTag("IntrBkSttlmDtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? InterbankSettlementDateIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the end-to-end identification is requested.|Usage: this is the former RelatedReference.
    /// </summary>
    [IsoId("_74LCwKMgEeCJ6YNENx4h-w_-581117102")]
    [DisplayName("End To End Identification Indicator")]
    [IsoXmlTag("EndToEndIdInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? EndToEndIdentificationIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the payment method is requested.
    /// </summary>
    [IsoId("_74LCwaMgEeCJ6YNENx4h-w_-1559749832")]
    [DisplayName("Payment Method Indicator")]
    [IsoXmlTag("PmtMtdInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? PaymentMethodIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the debtor is requested.
    /// </summary>
    [IsoId("_74LCwqMgEeCJ6YNENx4h-w_854911824")]
    [DisplayName("Debtor Indicator")]
    [IsoXmlTag("DbtrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? DebtorIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the debtor agent is requested.|Usage: this is the former FirstAgent.
    /// </summary>
    [IsoId("_74LCw6MgEeCJ6YNENx4h-w_-481729494")]
    [DisplayName("Debtor Agent Indicator")]
    [IsoXmlTag("DbtrAgtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? DebtorAgentIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the instructing reimbursement agent is requested.
    /// Usage: this is the former InstructingAgentCorrespondent.
    /// </summary>
    [IsoId("_74LCxKMgEeCJ6YNENx4h-w_1932932162")]
    [DisplayName("Instructing Reimbursement Agent Indicator")]
    [IsoXmlTag("InstgRmbrsmntAgtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? InstructingReimbursementAgentIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the instructed reimbursement agent is requested.
    /// Usage: this is the former InstructedAgentCorrespondent.
    /// </summary>
    [IsoId("_74LCxaMgEeCJ6YNENx4h-w_725260606")]
    [DisplayName("Instructed Reimbursement Agent Indicator")]
    [IsoXmlTag("InstdRmbrsmntAgtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? InstructedReimbursementAgentIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the intermediary is requested.
    /// </summary>
    [IsoId("_74LCxqMgEeCJ6YNENx4h-w_-1155045034")]
    [DisplayName("Intermediary Indicator")]
    [IsoXmlTag("IntrmyInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? IntermediaryIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the creditor agent is requested.|Usage: this is the former FinalAgent.
    /// </summary>
    [IsoId("_74UMsKMgEeCJ6YNENx4h-w_1803280944")]
    [DisplayName("Creditor Agent Indicator")]
    [IsoXmlTag("CdtrAgtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? CreditorAgentIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the creditor is requested.
    /// </summary>
    [IsoId("_74UMsaMgEeCJ6YNENx4h-w_-77024696")]
    [DisplayName("Creditor Indicator")]
    [IsoXmlTag("CdtrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? CreditorIndicator { get; init; } 
    
    
    #nullable disable
    
}
