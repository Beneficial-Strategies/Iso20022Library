// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card payment transactions from one or several data set of transactions.
/// </summary>
[IsoId("_Et_GMS49EeunNvJlR_vCbg")]
[DisplayName("Card Payment Batch Transfer")]
public record CardPaymentBatchTransfer9
{
    /// <summary>
    /// Totals of transactions of all the data sets.
    /// </summary>
    [IsoId("_E5ZsAS49EeunNvJlR_vCbg")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public ValueList<TransactionTotals12> TransactionTotals { get; init; } = [];

    /// <summary>
    /// Card payment transactions from one data set of transactions.
    /// </summary>
    [IsoId("_E5ZsAy49EeunNvJlR_vCbg")]
    [DisplayName("Data Set")]
    [IsoXmlTag("DataSet")]
    public ValueList<CardPaymentDataSet26> DataSet { get; init; } = [];
}
