// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status of the transactions sent in a previous batch of card payment transactions.
/// </summary>
[IsoId("_wpOMwWmZEeSQ1udc47rf0A")]
[DisplayName("Card Payment Batch Transfer Response")]
public record CardPaymentBatchTransferResponse3
{
    /// <summary>
    /// Totals of transactions of all the data sets.
    /// </summary>
    [IsoId("_w3aZwWmZEeSQ1udc47rf0A")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public TransactionTotals3? TransactionTotals { get; init; }

    /// <summary>
    /// Information related to the previously sent set of transaction.
    /// </summary>
    [IsoId("_w3aZw2mZEeSQ1udc47rf0A")]
    [DisplayName("Data Set")]
    [IsoXmlTag("DataSet")]
    public CardPaymentDataSet12? DataSet { get; init; }
}
