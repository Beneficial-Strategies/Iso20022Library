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
[IsoId("_t4GiMS8OEeKW5usMQLtzqw")]
[DisplayName("Card Payment Data Set Transaction")]
public record CardPaymentDataSetTransaction4
{
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    [IsoId("_uBxblS8OEeKW5usMQLtzqw")]
    [DisplayName("Transaction Sequence Counter")]
    [IsoXmlTag("TxSeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

    /// <summary>
    /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
    /// </summary>
    [IsoId("_uBxbnC8OEeKW5usMQLtzqw")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public ValueList<Traceability1> Traceability { get; init; } = [];

    /// <summary>
    /// Data related to the environment of the card payment transaction to authorise.
    /// </summary>
    [IsoId("_uBxboy8OEeKW5usMQLtzqw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment14 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_gM7JIDVEEeKdge4xeUaMrg")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardPaymentContext4? Context { get; init; }

    /// <summary>
    /// Card payment transaction to authorise.
    /// </summary>
    [IsoId("_uBxbqi8OEeKW5usMQLtzqw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction19 Transaction { get; init; }
}
