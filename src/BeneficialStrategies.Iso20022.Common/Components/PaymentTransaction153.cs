// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment Transaction153.
/// </summary>
[IsoId("_9WQwazEsEe6GxLzpkVnWYg")]
[DisplayName("Payment Transaction153")]
public record PaymentTransaction153
{
    /// <summary>
    /// Cancellation Status Identification.
    /// </summary>
    [DisplayName("Cancellation Status Identification")]
    [IsoXmlTag("CxlStsId")]
    public IsoMax35Text? CancellationStatusIdentification { get; init; }

    /// <summary>
    /// Cancellation Status Reason Information.
    /// </summary>
    [DisplayName("Cancellation Status Reason Information")]
    [IsoXmlTag("CxlStsRsnInf")]
    public ValueList<CancellationStatusReason5> CancellationStatusReasonInformation { get; init; } =
        [];

    /// <summary>
    /// Original End To End Identification.
    /// </summary>
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <summary>
    /// Original Instructed Amount.
    /// </summary>
    [DisplayName("Original Instructed Amount")]
    [IsoXmlTag("OrgnlInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInstructedAmount { get; init; }

    /// <summary>
    /// Original Instruction Identification.
    /// </summary>
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <summary>
    /// Original Requested Collection Date.
    /// </summary>
    [DisplayName("Original Requested Collection Date")]
    [IsoXmlTag("OrgnlReqdColltnDt")]
    public IsoISODate? OriginalRequestedCollectionDate { get; init; }

    /// <summary>
    /// Original Requested Execution Date.
    /// </summary>
    [DisplayName("Original Requested Execution Date")]
    [IsoXmlTag("OrgnlReqdExctnDt")]
    public DateAndDateTime2Choice_? OriginalRequestedExecutionDate { get; init; }

    /// <summary>
    /// Original Transaction Reference.
    /// </summary>
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference42? OriginalTransactionReference { get; init; }

    /// <summary>
    /// Resolved Case.
    /// </summary>
    [DisplayName("Resolved Case")]
    [IsoXmlTag("RslvdCase")]
    public Case6? ResolvedCase { get; init; }

    /// <summary>
    /// Transaction Cancellation Status.
    /// </summary>
    [DisplayName("Transaction Cancellation Status")]
    [IsoXmlTag("TxCxlSts")]
    public CancellationIndividualStatus1Code? TransactionCancellationStatus { get; init; }

    /// <summary>
    /// UETR.
    /// </summary>
    [DisplayName("UETR")]
    [IsoXmlTag("UETR")]
    public IsoUUIDv4Identifier? UETR { get; init; }
}
