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
[IsoId("_DnK60QuEEeqYM5yH99IYQw")]
[DisplayName("Card Payment Batch Transfer")]
public record CardPaymentBatchTransfer8
{
    /// <summary>
    /// Totals of transactions of all the data sets.
    /// </summary>
    [IsoId("_DzA-cQuEEeqYM5yH99IYQw")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public TransactionTotals7? TransactionTotals { get; init; }

    /// <summary>
    /// Card payment transactions from one data set of transactions.
    /// </summary>
    [IsoId("_DzA-cwuEEeqYM5yH99IYQw")]
    [DisplayName("Data Set")]
    [IsoXmlTag("DataSet")]
    public CardPaymentDataSet23? DataSet { get; init; }
}
