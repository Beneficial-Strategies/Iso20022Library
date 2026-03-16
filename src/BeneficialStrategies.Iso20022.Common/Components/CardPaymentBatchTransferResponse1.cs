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
[IsoId("_E2LswC45EeKIarvwWcPThw")]
[DisplayName("Card Payment Batch Transfer Response")]
public record CardPaymentBatchTransferResponse1
{
    /// <summary>
    /// Totals of transactions of all the data sets.
    /// </summary>
    [IsoId("_EyGBgC46EeKIarvwWcPThw")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public required TransactionTotals2 TransactionTotals { get; init; }

    /// <summary>
    /// Information related to the previously sent set of transaction.
    /// </summary>
    [IsoId("_K_Bd0C46EeKIarvwWcPThw")]
    [DisplayName("Data Set")]
    [IsoXmlTag("DataSet")]
    public CardPaymentDataSet5? DataSet { get; init; }
}
