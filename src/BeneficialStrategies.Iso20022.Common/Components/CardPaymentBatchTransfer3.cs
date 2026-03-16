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
[IsoId("_NvxRsWmFEeS7iYydEtv3Ug")]
[DisplayName("Card Payment Batch Transfer")]
public record CardPaymentBatchTransfer3
{
    /// <summary>
    /// Totals of transactions of all the data sets.
    /// </summary>
    [IsoId("_N9gLsWmFEeS7iYydEtv3Ug")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public TransactionTotals3? TransactionTotals { get; init; }

    /// <summary>
    /// Card payment transactions from one data set of transactions.
    /// </summary>
    [IsoId("_N9gLs2mFEeS7iYydEtv3Ug")]
    [DisplayName("Data Set")]
    [IsoXmlTag("DataSet")]
    public CardPaymentDataSet10? DataSet { get; init; }
}
