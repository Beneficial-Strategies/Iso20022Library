// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of transactions to capture, sharing common characteristics.
/// </summary>
[IsoId("_9M9ScbX4EfCUZfsQO4rYeA")]
[DisplayName("Card Payment Data Set43")]
public record CardPaymentDataSet43
{
    /// <summary>
    /// Identification of the data set.
    /// </summary>
    [IsoId("_9OBCZbX4EfCUZfsQO4rYeA")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DataSetIdentification5 DataSetIdentification { get; init; }

    /// <summary>
    /// Identification of partners involved in the data set building.
    /// </summary>
    [IsoId("_9OBCa7X4EfCUZfsQO4rYeA")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public ValueList<Traceability8> Traceability { get; init; } = [];

    /// <summary>
    /// Initiator of the data set.
    /// </summary>
    [IsoId("_9OBCcbX4EfCUZfsQO4rYeA")]
    [DisplayName("Data Set Initiator")]
    [IsoXmlTag("DataSetInitr")]
    public GenericIdentification176? DataSetInitiator { get; init; }

    /// <summary>
    /// Transaction totals of the data set.
    /// </summary>
    [IsoId("_9OBCd7X4EfCUZfsQO4rYeA")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    [MinLength(1)]
    public ValueList<TransactionTotals12> TransactionTotals { get; init; } = [];

    /// <summary>
    /// Data common to all transactions of the data set.
    /// </summary>
    [IsoId("_9OBCfbX4EfCUZfsQO4rYeA")]
    [DisplayName("Common Data")]
    [IsoXmlTag("CmonData")]
    public CommonData15? CommonData { get; init; }

    /// <summary>
    /// Set of transaction to Process.
    /// </summary>
    [IsoId("_9OBCg7X4EfCUZfsQO4rYeA")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    [MinLength(1)]
    public ValueList<CardPaymentDataSetTransaction14Choice_> Transaction { get; init; } = [];
}
