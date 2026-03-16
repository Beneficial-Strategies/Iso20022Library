// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction to capture in the batch.
/// </summary>
[IsoId("_SxR5qAEcEeCQm6a_G2yO_w_1194711550")]
[DisplayName("Card Payment Data Set Transaction")]
public record CardPaymentDataSetTransaction1
{
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    [IsoId("_SxR5qQEcEeCQm6a_G2yO_w_-1965275448")]
    [DisplayName("Transaction Sequence Counter")]
    [IsoXmlTag("TxSeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

    /// <summary>
    /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
    /// </summary>
    [IsoId("_SxR5qgEcEeCQm6a_G2yO_w_-1696191127")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public ValueList<Traceability1> Traceability { get; init; } = [];

    /// <summary>
    /// Data related to the environment of the transaction in a transaction captured in batch.
    /// </summary>
    [IsoId("_SxR5qwEcEeCQm6a_G2yO_w_332578266")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment6 Environment { get; init; }

    /// <summary>
    /// Data related to the context of the transaction.
    /// </summary>
    [IsoId("_SxR5rAEcEeCQm6a_G2yO_w_-979316908")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardPaymentContext3? Context { get; init; }

    /// <summary>
    /// Transaction information to be captured.
    /// </summary>
    [IsoId("_SxR5rQEcEeCQm6a_G2yO_w_-1734031655")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction4 Transaction { get; init; }
}
