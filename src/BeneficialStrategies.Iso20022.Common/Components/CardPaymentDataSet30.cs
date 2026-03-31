// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction for whose batch capture has been rejected.
/// </summary>
[IsoId("_6jN60VIBEey4xOoMoOPSJQ")]
[DisplayName("Card Payment Data Set")]
public record CardPaymentDataSet30
{
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    [IsoId("_6rhiQVIBEey4xOoMoOPSJQ")]
    [DisplayName("Transaction Sequence Counter")]
    [IsoXmlTag("TxSeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

    /// <summary>
    /// Response to the capture of the transaction.
    /// </summary>
    [IsoId("_6rhiQ1IBEey4xOoMoOPSJQ")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required ResponseType10 TransactionResponse { get; init; }

    /// <summary>
    /// Data related to the environment of the transaction.
    /// </summary>
    [IsoId("_6rhiRVIBEey4xOoMoOPSJQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment78 Environment { get; init; }

    /// <summary>
    /// Transaction that has been rejected.
    /// </summary>
    [IsoId("_6rhiR1IBEey4xOoMoOPSJQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransactionAdviceResponse5 Transaction { get; init; }
}
