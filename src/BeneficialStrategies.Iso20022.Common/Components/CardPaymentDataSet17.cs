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
[IsoId("_jsnY4ap0EeanIZ10Ka8PnA")]
[DisplayName("Card Payment Data Set")]
public record CardPaymentDataSet17
{
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    [IsoId("_j3Otcap0EeanIZ10Ka8PnA")]
    [DisplayName("Transaction Sequence Counter")]
    [IsoXmlTag("TxSeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

    /// <summary>
    /// Response to the capture of the transaction.
    /// </summary>
    [IsoId("_j3Otc6p0EeanIZ10Ka8PnA")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required ResponseType1 TransactionResponse { get; init; }

    /// <summary>
    /// Data related to the environment of the transaction.
    /// </summary>
    [IsoId("_j3Otdap0EeanIZ10Ka8PnA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment65 Environment { get; init; }

    /// <summary>
    /// Transaction that has been rejected.
    /// </summary>
    [IsoId("_j3Otd6p0EeanIZ10Ka8PnA")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransactionAdviceResponse5 Transaction { get; init; }
}
