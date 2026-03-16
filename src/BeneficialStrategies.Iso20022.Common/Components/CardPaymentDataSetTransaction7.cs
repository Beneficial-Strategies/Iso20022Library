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
[IsoId("_YBKwQTKKEeOqyZqt0rCZLg")]
[DisplayName("Card Payment Data Set Transaction")]
public record CardPaymentDataSetTransaction7
{
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    [IsoId("_YQV0sTKKEeOqyZqt0rCZLg")]
    [DisplayName("Transaction Sequence Counter")]
    [IsoXmlTag("TxSeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

    /// <summary>
    /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
    /// </summary>
    [IsoId("_YQV0szKKEeOqyZqt0rCZLg")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public Traceability1? Traceability { get; init; }

    /// <summary>
    /// Data related to the environment of the cancelled transaction captured in batch.
    /// </summary>
    [IsoId("_YQV0tTKKEeOqyZqt0rCZLg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment27 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_YQV0tzKKEeOqyZqt0rCZLg")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardPaymentContext4? Context { get; init; }

    /// <summary>
    /// Card payment cancellation transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_YQV0uTKKEeOqyZqt0rCZLg")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction30 Transaction { get; init; }
}
