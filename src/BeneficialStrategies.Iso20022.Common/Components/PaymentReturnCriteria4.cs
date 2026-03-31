// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to report on the payment.
/// </summary>
[IsoId("_yV4-y5lbEeeE1Ya-LgRsuQ")]
[DisplayName("Payment Return Criteria")]
public record PaymentReturnCriteria4
{
    /// <summary>
    /// Indicates whether the original payment transaction message identification is requested.|Usage: this is the former TransactionReference.
    /// </summary>
    [IsoId("_ydzkoZlbEeeE1Ya-LgRsuQ")]
    [DisplayName("Message Identification Indicator")]
    [IsoXmlTag("MsgIdInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? MessageIdentificationIndicator { get; init; }

    /// <summary>
    /// Indicates whether the requested execution date is requested.|Usage: this is the former TransferValueDate.
    /// </summary>
    [IsoId("_ydzko5lbEeeE1Ya-LgRsuQ")]
    [DisplayName("Requested Execution Date Indicator")]
    [IsoXmlTag("ReqdExctnDtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? RequestedExecutionDateIndicator { get; init; }

    /// <summary>
    /// Indicates whether the instruction is requested.
    /// </summary>
    [IsoId("_ydzkpZlbEeeE1Ya-LgRsuQ")]
    [DisplayName("Instruction Indicator")]
    [IsoXmlTag("InstrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? InstructionIndicator { get; init; }

    /// <summary>
    /// Indicates whether the instruction status is requested.
    /// </summary>
    [IsoId("_ydzkp5lbEeeE1Ya-LgRsuQ")]
    [DisplayName("Instruction Status Return Criteria")]
    [IsoXmlTag("InstrStsRtrCrit")]
    public InstructionStatusReturnCriteria1? InstructionStatusReturnCriteria { get; init; }

    /// <summary>
    /// Indicates whether the instructed amount is requested.
    /// </summary>
    [IsoId("_ydzkqZlbEeeE1Ya-LgRsuQ")]
    [DisplayName("Instructed Amount Indicator")]
    [IsoXmlTag("InstdAmtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? InstructedAmountIndicator { get; init; }

    /// <summary>
    /// Indicates whether the credit debit indicator is requested.
    /// </summary>
    [IsoId("_ydzkq5lbEeeE1Ya-LgRsuQ")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? CreditDebitIndicator { get; init; }

    /// <summary>
    /// Indicates whether the interbank settlement amount is requested.
    /// </summary>
    [IsoId("_ydzkrZlbEeeE1Ya-LgRsuQ")]
    [DisplayName("Interbank Settlement Amount Indicator")]
    [IsoXmlTag("IntrBkSttlmAmtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? InterbankSettlementAmountIndicator { get; init; }

    /// <summary>
    /// Indicates whether the payment priority is requested.
    /// </summary>
    [IsoId("_ydzkr5lbEeeE1Ya-LgRsuQ")]
    [DisplayName("Priority Indicator")]
    [IsoXmlTag("PrtyInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? PriorityIndicator { get; init; }

    /// <summary>
    /// Indicates whether the processing validity time is requested.
    /// </summary>
    [IsoId("_ydzksZlbEeeE1Ya-LgRsuQ")]
    [DisplayName("Processing Validity Time Indicator")]
    [IsoXmlTag("PrcgVldtyTmInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? ProcessingValidityTimeIndicator { get; init; }

    /// <summary>
    /// Indicates whether the transfer reason is requested.
    /// </summary>
    [IsoId("_ydzks5lbEeeE1Ya-LgRsuQ")]
    [DisplayName("Purpose Indicator")]
    [IsoXmlTag("PurpInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? PurposeIndicator { get; init; }

    /// <summary>
    /// Indicates whether the instruction copy is requested.
    /// </summary>
    [IsoId("_ydzktZlbEeeE1Ya-LgRsuQ")]
    [DisplayName("Instruction Copy Indicator")]
    [IsoXmlTag("InstrCpyInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? InstructionCopyIndicator { get; init; }

    /// <summary>
    /// Indicates whether the payment message type is requested.
    /// </summary>
    [IsoId("_ydzkt5lbEeeE1Ya-LgRsuQ")]
    [DisplayName("Payment Message Type Indicator")]
    [IsoXmlTag("PmtMTInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? PaymentMessageTypeIndicator { get; init; }

    /// <summary>
    /// Indicates whether the payment type is requested.
    /// </summary>
    [IsoId("_ydzkuZlbEeeE1Ya-LgRsuQ")]
    [DisplayName("Payment Type Indicator")]
    [IsoXmlTag("PmtTpInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? PaymentTypeIndicator { get; init; }

    /// <summary>
    /// Indicates whether the transaction identification is requested.|Usage: this is the former PaymentInstructionReference.
    /// </summary>
    [IsoId("_ydzku5lbEeeE1Ya-LgRsuQ")]
    [DisplayName("Transaction Identification Indicator")]
    [IsoXmlTag("TxIdInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? TransactionIdentificationIndicator { get; init; }

    /// <summary>
    /// Indicates whether the interbank settlement date is requested.|Usage: this is the former InterbankValueDate.
    /// </summary>
    [IsoId("_ydzkvZlbEeeE1Ya-LgRsuQ")]
    [DisplayName("Interbank Settlement Date Indicator")]
    [IsoXmlTag("IntrBkSttlmDtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? InterbankSettlementDateIndicator { get; init; }

    /// <summary>
    /// Indicates whether the end-to-end identification is requested.|Usage: this is the former RelatedReference.
    /// </summary>
    [IsoId("_ydzkv5lbEeeE1Ya-LgRsuQ")]
    [DisplayName("End To End Identification Indicator")]
    [IsoXmlTag("EndToEndIdInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? EndToEndIdentificationIndicator { get; init; }

    /// <summary>
    /// Indicates whether the payment method is requested.
    /// </summary>
    [IsoId("_ydzkwZlbEeeE1Ya-LgRsuQ")]
    [DisplayName("Payment Method Indicator")]
    [IsoXmlTag("PmtMtdInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? PaymentMethodIndicator { get; init; }

    /// <summary>
    /// Indicates whether the debtor is requested.
    /// </summary>
    [IsoId("_ydzkw5lbEeeE1Ya-LgRsuQ")]
    [DisplayName("Debtor Indicator")]
    [IsoXmlTag("DbtrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? DebtorIndicator { get; init; }

    /// <summary>
    /// Indicates whether the debtor agent is requested.|Usage: this is the former FirstAgent.
    /// </summary>
    [IsoId("_ydzkxZlbEeeE1Ya-LgRsuQ")]
    [DisplayName("Debtor Agent Indicator")]
    [IsoXmlTag("DbtrAgtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? DebtorAgentIndicator { get; init; }

    /// <summary>
    /// Indicates whether the instructing reimbursement agent is requested.
    /// Usage: this is the former InstructingAgentCorrespondent.
    /// </summary>
    [IsoId("_ydzkx5lbEeeE1Ya-LgRsuQ")]
    [DisplayName("Instructing Reimbursement Agent Indicator")]
    [IsoXmlTag("InstgRmbrsmntAgtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? InstructingReimbursementAgentIndicator { get; init; }

    /// <summary>
    /// Indicates whether the instructed reimbursement agent is requested.
    /// Usage: this is the former InstructedAgentCorrespondent.
    /// </summary>
    [IsoId("_ydzkyZlbEeeE1Ya-LgRsuQ")]
    [DisplayName("Instructed Reimbursement Agent Indicator")]
    [IsoXmlTag("InstdRmbrsmntAgtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? InstructedReimbursementAgentIndicator { get; init; }

    /// <summary>
    /// Indicates whether the intermediary is requested.
    /// </summary>
    [IsoId("_ydzky5lbEeeE1Ya-LgRsuQ")]
    [DisplayName("Intermediary Indicator")]
    [IsoXmlTag("IntrmyInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? IntermediaryIndicator { get; init; }

    /// <summary>
    /// Indicates whether the creditor agent is requested.|Usage: this is the former FinalAgent.
    /// </summary>
    [IsoId("_ydzkzZlbEeeE1Ya-LgRsuQ")]
    [DisplayName("Creditor Agent Indicator")]
    [IsoXmlTag("CdtrAgtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? CreditorAgentIndicator { get; init; }

    /// <summary>
    /// Indicates whether the creditor is requested.
    /// </summary>
    [IsoId("_ydzkz5lbEeeE1Ya-LgRsuQ")]
    [DisplayName("Creditor Indicator")]
    [IsoXmlTag("CdtrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? CreditorIndicator { get; init; }
}
