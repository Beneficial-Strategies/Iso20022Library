// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cancelled card payment transaction to be captured in a batch.
/// </summary>
[IsoId("_nGrugdg1EeipBO1pkKK6zg")]
[DisplayName("Card Payment Data Set Transaction")]
public record CardPaymentDataSetTransaction29
{
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    [IsoId("_nQsmIdg1EeipBO1pkKK6zg")]
    [DisplayName("Transaction Sequence Counter")]
    [IsoXmlTag("TxSeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

    /// <summary>
    /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
    /// </summary>
    [IsoId("_nQsmI9g1EeipBO1pkKK6zg")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public ValueList<Traceability5> Traceability { get; init; } = [];

    /// <summary>
    /// Data related to the environment of the cancelled transaction captured in batch.
    /// </summary>
    [IsoId("_nQsmJdg1EeipBO1pkKK6zg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment68 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_nQsmJ9g1EeipBO1pkKK6zg")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardPaymentContext27? Context { get; init; }

    /// <summary>
    /// Card payment cancellation transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_nQsmKdg1EeipBO1pkKK6zg")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction83 Transaction { get; init; }
}
