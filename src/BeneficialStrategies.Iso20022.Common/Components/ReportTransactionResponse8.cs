// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Transaction Report Response message.
/// </summary>
[IsoId("_pajSYbYNEfCUZfsQO4rYeA")]
[DisplayName("Report Transaction Response8")]
public record ReportTransactionResponse8
{
    /// <summary>
    /// Specifies the total number of transactions matching the search criteria.
    /// </summary>
    [IsoId("_pbd4ZbYNEfCUZfsQO4rYeA")]
    [DisplayName("Report Full Size")]
    [IsoXmlTag("RptFullSz")]
    public required IsoPositiveNumber ReportFullSize { get; init; }

    /// <summary>
    /// Index of the first transaction reported in this message within the list of transactions matching the search criteria.
    /// </summary>
    [IsoId("_pbd4a7YNEfCUZfsQO4rYeA")]
    [DisplayName("Block Start")]
    [IsoXmlTag("BlckStart")]
    public required IsoPositiveNumber BlockStart { get; init; }

    /// <summary>
    /// Index of the last transaction reported in this message.
    /// </summary>
    [IsoId("_pbd4cbYNEfCUZfsQO4rYeA")]
    [DisplayName("Block Stop")]
    [IsoXmlTag("BlckStop")]
    public required IsoPositiveNumber BlockStop { get; init; }

    /// <summary>
    /// List of Transaction Report containing one Transaction Report for each transaction matching the search criteria.
    /// </summary>
    [IsoId("_pbd4d7YNEfCUZfsQO4rYeA")]
    [DisplayName("Transaction Report")]
    [IsoXmlTag("TxRpt")]
    public ValueList<ServiceResponse10> TransactionReport { get; init; } = [];
}
