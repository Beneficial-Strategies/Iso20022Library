// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reference and status on the original transactions, included in the original instruction, to which the cancellation request message applies.
/// </summary>
[IsoId("_p4Nc38QHEemsic1bQcEtLA")]
[DisplayName("Payment Transaction")]
public record PaymentTransaction127
{
    /// <summary>
    /// Unique and unambiguous identifier of a cancellation request status, as assigned by the assigner.||Usage: The cancellation status identification can be used for reconciliation or to link tasks relating to the cancellation request.
    /// </summary>
    [IsoId("_qDvXZcQHEemsic1bQcEtLA")]
    [DisplayName("Cancellation Status Identification")]
    [IsoXmlTag("CxlStsId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CancellationStatusIdentification { get; init; }

    /// <summary>
    /// Identifies the resolved case.
    /// </summary>
    [IsoId("_qDvXZ8QHEemsic1bQcEtLA")]
    [DisplayName("Resolved Case")]
    [IsoXmlTag("RslvdCase")]
    public Case5? ResolvedCase { get; init; }

    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_qDvXacQHEemsic1bQcEtLA")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation29? OriginalGroupInformation { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_qDvXa8QHEemsic1bQcEtLA")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    [IsoId("_qDvXbcQHEemsic1bQcEtLA")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original first instructing agent, to unambiguously identify the transaction.
    /// </summary>
    [IsoId("_qDvXb8QHEemsic1bQcEtLA")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalTransactionIdentification { get; init; }

    /// <summary>
    /// Unique reference, as assigned by the original clearing system, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_qDvXccQHEemsic1bQcEtLA")]
    [DisplayName("Original Clearing System Reference")]
    [IsoXmlTag("OrgnlClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalClearingSystemReference { get; init; }

    /// <summary>
    /// Universally unique identifier to provide the original end-to-end reference of a payment transaction.
    /// </summary>
    [IsoId("_qDvXc8QHEemsic1bQcEtLA")]
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
    public IsoUUIDv4Identifier? OriginalUETR { get; init; }

    /// <summary>
    /// Specifies the status of the transaction cancellation request.
    /// </summary>
    [IsoId("_qDvXdcQHEemsic1bQcEtLA")]
    [DisplayName("Transaction Cancellation Status")]
    [IsoXmlTag("TxCxlSts")]
    public CancellationIndividualStatus1Code? TransactionCancellationStatus { get; init; }

    /// <summary>
    /// Provides detailed information on the cancellation status reason.
    /// </summary>
    [IsoId("_qDvXd8QHEemsic1bQcEtLA")]
    [DisplayName("Cancellation Status Reason Information")]
    [IsoXmlTag("CxlStsRsnInf")]
    public CancellationStatusReason4? CancellationStatusReasonInformation { get; init; }

    /// <summary>
    /// Reference of a return or a reversal transaction that is initiated to fix the case under investigation as part of the resolution.
    /// </summary>
    [IsoId("_qDvXecQHEemsic1bQcEtLA")]
    [DisplayName("Resolution Related Information")]
    [IsoXmlTag("RsltnRltdInf")]
    public ResolutionData2? ResolutionRelatedInformation { get; init; }

    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent, as provided in the original instruction.
    /// </summary>
    [IsoId("_qDvXe8QHEemsic1bQcEtLA")]
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; }

    /// <summary>
    /// Date, as provided in the original transaction, on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_qDvXfcQHEemsic1bQcEtLA")]
    [DisplayName("Original Interbank Settlement Date")]
    [IsoXmlTag("OrgnlIntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OriginalInterbankSettlementDate { get; init; }

    /// <summary>
    /// Party who assigns the case.|Usage: This is also the agent that instructs the next party in the chain to carry out the (set of) cancellation request(s).
    /// </summary>
    [IsoId("_qDvXf8QHEemsic1bQcEtLA")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public Party40Choice_? Assigner { get; init; }

    /// <summary>
    /// Party to which the case is assigned.|Usage: This is also the agent that is instructed by the previous party in the chain to carry out the (set of) cancellation request(s).
    /// </summary>
    [IsoId("_qDvXgcQHEemsic1bQcEtLA")]
    [DisplayName("Assignee")]
    [IsoXmlTag("Assgne")]
    public Party40Choice_? Assignee { get; init; }

    /// <summary>
    /// Key elements used to identify the original transaction that is being referred to.
    /// </summary>
    [IsoId("_qDvXg8QHEemsic1bQcEtLA")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference31? OriginalTransactionReference { get; init; }
}
