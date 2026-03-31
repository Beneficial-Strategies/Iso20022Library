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
[IsoId("_YRsG8dtPEee9e6xduATmQg")]
[DisplayName("Card Payment Data Set")]
public record CardPaymentDataSet20
{
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    [IsoId("_YbBCEdtPEee9e6xduATmQg")]
    [DisplayName("Transaction Sequence Counter")]
    [IsoXmlTag("TxSeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

    /// <summary>
    /// Response to the capture of the transaction.
    /// </summary>
    [IsoId("_YbBCE9tPEee9e6xduATmQg")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required ResponseType1 TransactionResponse { get; init; }

    /// <summary>
    /// Data related to the environment of the transaction.
    /// </summary>
    [IsoId("_YbBCFdtPEee9e6xduATmQg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment69 Environment { get; init; }

    /// <summary>
    /// Transaction that has been rejected.
    /// </summary>
    [IsoId("_YbBCF9tPEee9e6xduATmQg")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransactionAdviceResponse5 Transaction { get; init; }
}
