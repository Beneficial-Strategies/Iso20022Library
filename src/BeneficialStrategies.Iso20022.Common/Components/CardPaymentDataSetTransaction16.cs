// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card payment transaction to be authorised in a batch.
/// </summary>
[IsoId("_SYIQEY3REeWjkqXgn_0Imw")]
[DisplayName("Card Payment Data Set Transaction")]
public record CardPaymentDataSetTransaction16
{
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    [IsoId("_SlFuAY3REeWjkqXgn_0Imw")]
    [DisplayName("Transaction Sequence Counter")]
    [IsoXmlTag("TxSeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

    /// <summary>
    /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
    /// </summary>
    [IsoId("_SlFuA43REeWjkqXgn_0Imw")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public Traceability5? Traceability { get; init; }

    /// <summary>
    /// Data related to the environment of the card payment transaction to authorise.
    /// </summary>
    [IsoId("_SlFuBY3REeWjkqXgn_0Imw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment53 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_SlFuB43REeWjkqXgn_0Imw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardPaymentContext18? Context { get; init; }

    /// <summary>
    /// Card payment transaction to authorise.
    /// </summary>
    [IsoId("_SlFuCY3REeWjkqXgn_0Imw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction62 Transaction { get; init; }
}
