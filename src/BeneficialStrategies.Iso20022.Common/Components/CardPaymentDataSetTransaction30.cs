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
[IsoId("_TrxeoQx7Eeqdx6buGpCCQw")]
[DisplayName("Card Payment Data Set Transaction")]
public record CardPaymentDataSetTransaction30
{
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    [IsoId("_T3C6gQx7Eeqdx6buGpCCQw")]
    [DisplayName("Transaction Sequence Counter")]
    [IsoXmlTag("TxSeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

    /// <summary>
    /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
    /// </summary>
    [IsoId("_T3C6gwx7Eeqdx6buGpCCQw")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public ValueList<Traceability8> Traceability { get; init; } = [];

    /// <summary>
    /// Data related to the environment of the transaction in a transaction captured in batch.
    /// </summary>
    [IsoId("_T3C6hQx7Eeqdx6buGpCCQw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment74 Environment { get; init; }

    /// <summary>
    /// Data related to the context of the transaction.
    /// </summary>
    [IsoId("_T3C6hwx7Eeqdx6buGpCCQw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardPaymentContext28? Context { get; init; }

    /// <summary>
    /// Transaction information to be captured.
    /// </summary>
    [IsoId("_T3C6iQx7Eeqdx6buGpCCQw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction99 Transaction { get; init; }
}
