// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Completed card payment transaction to be captured in batch.
/// </summary>
[IsoId("_2tjqEdejEeiJyp_aycJaTw")]
[DisplayName("Card Payment Data Set Transaction")]
public record CardPaymentDataSetTransaction28
{
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    [IsoId("_23Y7gNejEeiJyp_aycJaTw")]
    [DisplayName("Transaction Sequence Counter")]
    [IsoXmlTag("TxSeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

    /// <summary>
    /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
    /// </summary>
    [IsoId("_23Y7gtejEeiJyp_aycJaTw")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public Traceability5? Traceability { get; init; }

    /// <summary>
    /// Data related to the environment of the transaction in a transaction captured in batch.
    /// </summary>
    [IsoId("_23Y7hNejEeiJyp_aycJaTw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment68 Environment { get; init; }

    /// <summary>
    /// Data related to the context of the transaction.
    /// </summary>
    [IsoId("_23Y7htejEeiJyp_aycJaTw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardPaymentContext27? Context { get; init; }

    /// <summary>
    /// Transaction information to be captured.
    /// </summary>
    [IsoId("_23Y7iNejEeiJyp_aycJaTw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction89 Transaction { get; init; }
}
