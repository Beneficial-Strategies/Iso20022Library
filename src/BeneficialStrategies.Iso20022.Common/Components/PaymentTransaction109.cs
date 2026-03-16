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
[IsoId("_ZUN0O249EeiU9cctagi5ow")]
[DisplayName("Payment Transaction")]
public record PaymentTransaction109
{
    /// <summary>
    /// Unique identification, as assigned by the assigner, to unambiguously identify a cancellation request.||Usage: The cancellation request identification can be used for reconciliation or to link tasks relating to the cancellation request.
    /// </summary>
    [IsoId("_ZeWnsW49EeiU9cctagi5ow")]
    [DisplayName("Cancellation Identification")]
    [IsoXmlTag("CxlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CancellationIdentification { get; init; }

    /// <summary>
    /// Set of elements to uniquely and unambiguously identify an exception or an investigation workflow.
    /// </summary>
    [IsoId("_ZeWns249EeiU9cctagi5ow")]
    [DisplayName("Case")]
    [IsoXmlTag("Case")]
    public Case5? Case { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_ZeWntW49EeiU9cctagi5ow")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    [IsoId("_ZeWnt249EeiU9cctagi5ow")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <summary>
    /// Universally unique identifier to provide an end-to-end reference of a payment transaction.
    /// </summary>
    [IsoId("_JlrxMXrfEeidVZmeoasaWQ")]
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
    public IsoUUIDv4Identifier? OriginalUETR { get; init; }

    /// <summary>
    /// Amount of money, as provided in the original transaction, to be moved between the debtor and the creditor, before deduction of charges, expressed in the currency, as ordered by the original initiating party.
    /// Usage: This amount has to be transported unchanged through the transaction chain.
    /// </summary>
    [IsoId("_ZeWnuW49EeiU9cctagi5ow")]
    [DisplayName("Original Instructed Amount")]
    [IsoXmlTag("OrgnlInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInstructedAmount { get; init; }

    /// <summary>
    /// Date at which the initiating party originally requested the clearing agent to process the payment.
    /// </summary>
    [IsoId("_ZeWnu249EeiU9cctagi5ow")]
    [DisplayName("Original Requested Execution Date")]
    [IsoXmlTag("OrgnlReqdExctnDt")]
    public DateAndDateTime2Choice_? OriginalRequestedExecutionDate { get; init; }

    /// <summary>
    /// Date at which the creditor originally requested the collection of the amount of money from the debtor.
    /// </summary>
    [IsoId("_ZeWnvW49EeiU9cctagi5ow")]
    [DisplayName("Original Requested Collection Date")]
    [IsoXmlTag("OrgnlReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OriginalRequestedCollectionDate { get; init; }

    /// <summary>
    /// Provides detailed information on the cancellation reason.
    /// </summary>
    [IsoId("_ZeWnv249EeiU9cctagi5ow")]
    [DisplayName("Cancellation Reason Information")]
    [IsoXmlTag("CxlRsnInf")]
    public PaymentCancellationReason5? CancellationReasonInformation { get; init; }

    /// <summary>
    /// Key elements used to identify the original transaction that is being referred to.
    /// </summary>
    [IsoId("_ZeWnwW49EeiU9cctagi5ow")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference28? OriginalTransactionReference { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_ZeWnw249EeiU9cctagi5ow")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
