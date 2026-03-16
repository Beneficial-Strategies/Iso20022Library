// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides reference and status information on the original transactions, included in the original instruction, to which the cancellation request message applies.
/// </summary>
[IsoId("_tPd6YVkyEeGeoaLUQk__nA_-294462167")]
[DisplayName("Payment Transaction")]
public record PaymentTransaction39
{
    /// <summary>
    /// Unique and unambiguous identifier of a cancellation request status, as assigned by the assigner.||Usage: The cancellation status identification can be used for reconciliation or to link tasks relating to the cancellation request.
    /// </summary>
    [IsoId("_tPd6YlkyEeGeoaLUQk__nA_-408301233")]
    [DisplayName("Cancellation Status Identification")]
    [IsoXmlTag("CxlStsId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CancellationStatusIdentification { get; init; }

    /// <summary>
    /// Identifies the resolved case.
    /// </summary>
    [IsoId("_tPd6Y1kyEeGeoaLUQk__nA_-1405373586")]
    [DisplayName("Resolved Case")]
    [IsoXmlTag("RslvdCase")]
    public Case3? ResolvedCase { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_tPd6ZFkyEeGeoaLUQk__nA_1892521357")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    [IsoId("_tPnrYFkyEeGeoaLUQk__nA_895449004")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <summary>
    /// Specifies the status of the transaction cancellation request.
    /// </summary>
    [IsoId("_tPnrYVkyEeGeoaLUQk__nA_-101623349")]
    [DisplayName("Transaction Cancellation Status")]
    [IsoXmlTag("TxCxlSts")]
    public CancellationIndividualStatus1Code? TransactionCancellationStatus { get; init; }

    /// <summary>
    /// Provides detailed information on the cancellation status reason.
    /// </summary>
    [IsoId("_tPnrYlkyEeGeoaLUQk__nA_-1098695702")]
    [DisplayName("Cancellation Status Reason Information")]
    [IsoXmlTag("CxlStsRsnInf")]
    public CancellationStatusReason2? CancellationStatusReasonInformation { get; init; }

    /// <summary>
    /// Amount of money, as provided in the original transaction, to be moved between the debtor and the creditor, before deduction of charges, expressed in the currency, as ordered by the original initiating party.
    /// </summary>
    [IsoId("_tPnrY1kyEeGeoaLUQk__nA_-2095768055")]
    [DisplayName("Original Instructed Amount")]
    [IsoXmlTag("OrgnlInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInstructedAmount { get; init; }

    /// <summary>
    /// Date at which the initiating party originally requested the clearing agent to process the payment.
    /// </summary>
    [IsoId("_tPnrZFkyEeGeoaLUQk__nA_1202126888")]
    [DisplayName("Original Requested Execution Date")]
    [IsoXmlTag("OrgnlReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OriginalRequestedExecutionDate { get; init; }

    /// <summary>
    /// Date at which the creditor originally requested the collection of the amount of money from the debtor.
    /// </summary>
    [IsoId("_tPxcYFkyEeGeoaLUQk__nA_-1482412287")]
    [DisplayName("Original Requested Collection Date")]
    [IsoXmlTag("OrgnlReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OriginalRequestedCollectionDate { get; init; }

    /// <summary>
    /// Key elements used to identify the original transaction that is being referred to.
    /// </summary>
    [IsoId("_tPxcYVkyEeGeoaLUQk__nA_1815482656")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference16? OriginalTransactionReference { get; init; }
}
