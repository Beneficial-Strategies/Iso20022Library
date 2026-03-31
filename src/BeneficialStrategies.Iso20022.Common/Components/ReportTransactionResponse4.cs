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
[IsoId("_QC3YoU0zEeybj420QgWBkA")]
[DisplayName("Report Transaction Response")]
public record ReportTransactionResponse4
{
    /// <summary>
    /// The total number of transactions matching the search criteria.
    /// </summary>
    [IsoId("_QJ3_kU0zEeybj420QgWBkA")]
    [DisplayName("Report Full Size")]
    [IsoXmlTag("RptFullSz")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public required IsoPositiveNumber ReportFullSize { get; init; }

    /// <summary>
    /// Index of the first transaction reported in this message within the list of transactions matching the search criteria.
    /// </summary>
    [IsoId("_QJ3_k00zEeybj420QgWBkA")]
    [DisplayName("Block Start")]
    [IsoXmlTag("BlckStart")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public required IsoPositiveNumber BlockStart { get; init; }

    /// <summary>
    /// Index of the last transaction reported in this message.
    /// </summary>
    [IsoId("_QJ3_lU0zEeybj420QgWBkA")]
    [DisplayName("Block Stop")]
    [IsoXmlTag("BlckStop")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public required IsoPositiveNumber BlockStop { get; init; }

    /// <summary>
    /// List of Transaction Report containing one Transaction Report for each transaction matching the Search criteria. This list may be partial according to requested block.
    /// </summary>
    [IsoId("_QJ3_l00zEeybj420QgWBkA")]
    [DisplayName("Transaction Report")]
    [IsoXmlTag("TxRpt")]
    public ValueList<PointOfInteractionTransactionReport4> TransactionReport { get; init; } = [];
}
