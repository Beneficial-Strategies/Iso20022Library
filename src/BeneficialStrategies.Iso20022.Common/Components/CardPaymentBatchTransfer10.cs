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
[IsoId("_-xhWAU0ZEeybj420QgWBkA")]
[DisplayName("Card Payment Batch Transfer")]
public record CardPaymentBatchTransfer10
{
    /// <summary>
    /// Totals of transactions of all the data sets.
    /// </summary>
    [IsoId("_-4UhkU0ZEeybj420QgWBkA")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public ValueList<TransactionTotals12> TransactionTotals { get; init; } = [];

    /// <summary>
    /// Card payment transactions from one data set of transactions.
    /// </summary>
    [IsoId("_-4Uhk00ZEeybj420QgWBkA")]
    [DisplayName("Data Set")]
    [IsoXmlTag("DataSet")]
    public ValueList<CardPaymentDataSet29> DataSet { get; init; } = [];
}
