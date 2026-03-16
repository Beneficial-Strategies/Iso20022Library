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
[IsoId("_lFIOvTq3EeWZFYSPlduMhw")]
[DisplayName("Payment Transaction")]
public record PaymentTransaction66
{
    /// <summary>
    /// Unique and unambiguous identifier of a cancellation request status, as assigned by the assigner.||Usage: The cancellation status identification can be used for reconciliation or to link tasks relating to the cancellation request.
    /// </summary>
    [IsoId("_lNbPAzq3EeWZFYSPlduMhw")]
    [DisplayName("Cancellation Status Identification")]
    [IsoXmlTag("CxlStsId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CancellationStatusIdentification { get; init; }

    /// <summary>
    /// Identifies the resolved case.
    /// </summary>
    [IsoId("_lNbPBTq3EeWZFYSPlduMhw")]
    [DisplayName("Resolved Case")]
    [IsoXmlTag("RslvdCase")]
    public Case3? ResolvedCase { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_lNbPBzq3EeWZFYSPlduMhw")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    [IsoId("_lNbPCTq3EeWZFYSPlduMhw")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <summary>
    /// Specifies the status of the transaction cancellation request.
    /// </summary>
    [IsoId("_lNbPCzq3EeWZFYSPlduMhw")]
    [DisplayName("Transaction Cancellation Status")]
    [IsoXmlTag("TxCxlSts")]
    public CancellationIndividualStatus1Code? TransactionCancellationStatus { get; init; }

    /// <summary>
    /// Provides detailed information on the cancellation status reason.
    /// </summary>
    [IsoId("_lNbPDTq3EeWZFYSPlduMhw")]
    [DisplayName("Cancellation Status Reason Information")]
    [IsoXmlTag("CxlStsRsnInf")]
    public ValueList<CancellationStatusReason2> CancellationStatusReasonInformation { get; init; } =
        [];

    /// <summary>
    /// Amount of money, as provided in the original transaction, to be moved between the debtor and the creditor, before deduction of charges, expressed in the currency, as ordered by the original initiating party.
    /// Usage: This amount has to be transported unchanged through the transaction chain.
    /// </summary>
    [IsoId("_lNbPDzq3EeWZFYSPlduMhw")]
    [DisplayName("Original Instructed Amount")]
    [IsoXmlTag("OrgnlInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInstructedAmount { get; init; }

    /// <summary>
    /// Date at which the initiating party originally requested the clearing agent to process the payment.
    /// </summary>
    [IsoId("_lNbPETq3EeWZFYSPlduMhw")]
    [DisplayName("Original Requested Execution Date")]
    [IsoXmlTag("OrgnlReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OriginalRequestedExecutionDate { get; init; }

    /// <summary>
    /// Date at which the creditor originally requested the collection of the amount of money from the debtor.
    /// </summary>
    [IsoId("_lNbPEzq3EeWZFYSPlduMhw")]
    [DisplayName("Original Requested Collection Date")]
    [IsoXmlTag("OrgnlReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OriginalRequestedCollectionDate { get; init; }

    /// <summary>
    /// Key elements used to identify the original transaction that is being referred to.
    /// </summary>
    [IsoId("_lNbPFTq3EeWZFYSPlduMhw")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference22? OriginalTransactionReference { get; init; }
}
