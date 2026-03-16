// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card Payment Batch Transfer Response12.
/// </summary>
[IsoId("_dXJdsaE2Ee-MRKYsaX6JDg")]
[DisplayName("Card Payment Batch Transfer Response12")]
public record CardPaymentBatchTransferResponse12
{
    /// <summary>
    /// Data Set.
    /// </summary>
    [DisplayName("Data Set")]
    [IsoXmlTag("DataSet")]
    public ValueList<CardPaymentDataSet39> DataSet { get; init; } = [];

    /// <summary>
    /// Transaction Totals.
    /// </summary>
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public ValueList<TransactionTotals12> TransactionTotals { get; init; } = [];
}
