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
[IsoId("_d60JMdejEeiJyp_aycJaTw")]
[DisplayName("Card Payment Data Set Transaction")]
public record CardPaymentDataSetTransaction27
{
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    [IsoId("_eEpaodejEeiJyp_aycJaTw")]
    [DisplayName("Transaction Sequence Counter")]
    [IsoXmlTag("TxSeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

    /// <summary>
    /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
    /// </summary>
    [IsoId("_eEpao9ejEeiJyp_aycJaTw")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public ValueList<Traceability5> Traceability { get; init; } = [];

    /// <summary>
    /// Data related to the environment of the card payment transaction to authorise.
    /// </summary>
    [IsoId("_eEpapdejEeiJyp_aycJaTw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment68 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_eEpap9ejEeiJyp_aycJaTw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardPaymentContext27? Context { get; init; }

    /// <summary>
    /// Card payment transaction to authorise.
    /// </summary>
    [IsoId("_eEpaqdejEeiJyp_aycJaTw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction87 Transaction { get; init; }
}
