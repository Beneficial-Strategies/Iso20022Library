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
[IsoId("_IYhj0dpoEeearpaEPXv9UA")]
[DisplayName("Card Payment Data Set Transaction")]
public record CardPaymentDataSetTransaction23
{
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    [IsoId("_Ihw_YdpoEeearpaEPXv9UA")]
    [DisplayName("Transaction Sequence Counter")]
    [IsoXmlTag("TxSeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

    /// <summary>
    /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
    /// </summary>
    [IsoId("_Ihw_Y9poEeearpaEPXv9UA")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public Traceability5? Traceability { get; init; }

    /// <summary>
    /// Data related to the environment of the cancelled transaction captured in batch.
    /// </summary>
    [IsoId("_Ihw_ZdpoEeearpaEPXv9UA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment68 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_Ihw_Z9poEeearpaEPXv9UA")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardPaymentContext26? Context { get; init; }

    /// <summary>
    /// Card payment cancellation transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_Ihw_adpoEeearpaEPXv9UA")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction83 Transaction { get; init; }
}
