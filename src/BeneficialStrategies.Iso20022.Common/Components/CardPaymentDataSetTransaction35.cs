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
[IsoId("__eB2MS5BEeunNvJlR_vCbg")]
[DisplayName("Card Payment Data Set Transaction")]
public record CardPaymentDataSetTransaction35
{
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    [IsoId("__pkX0S5BEeunNvJlR_vCbg")]
    [DisplayName("Transaction Sequence Counter")]
    [IsoXmlTag("TxSeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

    /// <summary>
    /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
    /// </summary>
    [IsoId("__pkX0y5BEeunNvJlR_vCbg")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public Traceability8? Traceability { get; init; }

    /// <summary>
    /// Data related to the environment of the cancelled transaction captured in batch.
    /// </summary>
    [IsoId("__pkX1S5BEeunNvJlR_vCbg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment77 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("__pkX1y5BEeunNvJlR_vCbg")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardPaymentContext28? Context { get; init; }

    /// <summary>
    /// Card payment cancellation transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("__pkX2S5BEeunNvJlR_vCbg")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction104 Transaction { get; init; }
}
