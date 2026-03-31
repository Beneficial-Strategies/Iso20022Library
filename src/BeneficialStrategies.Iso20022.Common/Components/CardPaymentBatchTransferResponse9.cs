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
[IsoId("_g8HvYVICEey4xOoMoOPSJQ")]
[DisplayName("Card Payment Batch Transfer Response")]
public record CardPaymentBatchTransferResponse9
{
    /// <summary>
    /// Totals of transactions of all the data sets.
    /// </summary>
    [IsoId("_hDY1AVICEey4xOoMoOPSJQ")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public ValueList<TransactionTotals12> TransactionTotals { get; init; } = [];

    /// <summary>
    /// Information related to the previously sent set of transaction.
    /// </summary>
    [IsoId("_hDY1A1ICEey4xOoMoOPSJQ")]
    [DisplayName("Data Set")]
    [IsoXmlTag("DataSet")]
    public ValueList<CardPaymentDataSet31> DataSet { get; init; } = [];
}
