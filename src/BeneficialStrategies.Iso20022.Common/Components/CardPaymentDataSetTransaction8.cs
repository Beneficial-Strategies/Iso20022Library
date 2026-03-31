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
[IsoId("_aFsscTKNEeOqyZqt0rCZLg")]
[DisplayName("Card Payment Data Set Transaction")]
public record CardPaymentDataSetTransaction8
{
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    [IsoId("_aU3w4TKNEeOqyZqt0rCZLg")]
    [DisplayName("Transaction Sequence Counter")]
    [IsoXmlTag("TxSeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

    /// <summary>
    /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
    /// </summary>
    [IsoId("_aU3w4zKNEeOqyZqt0rCZLg")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public ValueList<Traceability1> Traceability { get; init; } = [];

    /// <summary>
    /// Data related to the environment of the card payment transaction to authorise.
    /// </summary>
    [IsoId("_aU3w5TKNEeOqyZqt0rCZLg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment27 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_aU3w5zKNEeOqyZqt0rCZLg")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardPaymentContext7? Context { get; init; }

    /// <summary>
    /// Card payment transaction to authorise.
    /// </summary>
    [IsoId("_aU3w6TKNEeOqyZqt0rCZLg")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction31 Transaction { get; init; }
}
