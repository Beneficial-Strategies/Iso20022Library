// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of the header for a trade transaction query message.
/// </summary>
[IsoId("_7oH-8cWBEeijrI2SDYOAOw")]
[DisplayName("Trade Query Header")]
public record TradeQueryHeader4
{
    /// <summary>
    /// Indicates the day that the query was executed.
    /// </summary>
    [IsoId("_70_WQcWBEeijrI2SDYOAOw")]
    [DisplayName("Query Execution Date")]
    [IsoXmlTag("QryExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? QueryExecutionDate { get; init; }

    /// <summary>
    /// Page number of the message (within the report) and continuation indicator to indicate that the report is to continue or that the message is the last page of the report.
    /// </summary>
    [IsoId("_71JHQcWBEeijrI2SDYOAOw")]
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public required Pagination1 MessagePagination { get; init; }

    /// <summary>
    /// Indicates the number of records in the page.
    /// </summary>
    [IsoId("_71JHQ8WBEeijrI2SDYOAOw")]
    [DisplayName("Number Records")]
    [IsoXmlTag("NbRcrds")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber NumberRecords { get; init; }
}
