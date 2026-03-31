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
[IsoId("_TDd10wEcEeCQm6a_G2yO_w_-219747414")]
[DisplayName("Card Payment Data Set")]
public record CardPaymentDataSet3
{
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    [IsoId("_TDd11AEcEeCQm6a_G2yO_w_-1598430357")]
    [DisplayName("Transaction Sequence Counter")]
    [IsoXmlTag("TxSeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

    /// <summary>
    /// Response to the capture of the transaction.
    /// </summary>
    [IsoId("_TDd11QEcEeCQm6a_G2yO_w_1380418930")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required ResponseType1 TransactionResponse { get; init; }

    /// <summary>
    /// Data related to the environment of the transaction.
    /// </summary>
    [IsoId("_TDd11gEcEeCQm6a_G2yO_w_-1083625197")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment3 Environment { get; init; }

    /// <summary>
    /// Transaction that has been rejected.
    /// </summary>
    [IsoId("_TDd11wEcEeCQm6a_G2yO_w_-1206093331")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransactionAdviceResponse1 Transaction { get; init; }
}
