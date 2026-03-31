// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides header details on the report.
/// </summary>
[IsoId("_6Q_lh5qlEeGSON8vddiWzQ_-723206236")]
[DisplayName("Report Header")]
public record ReportHeader3
{
    /// <summary>
    /// Identification of a report billing statement.
    /// </summary>
    [IsoId("_6RJWgJqlEeGSON8vddiWzQ_-75011154")]
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ReportIdentification { get; init; }

    /// <summary>
    /// Provides details on the page number of the message.
    /// Usage: The pagination of the message is only allowed when agreed between the parties.
    /// </summary>
    [IsoId("_6RJWgZqlEeGSON8vddiWzQ_922061199")]
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public Pagination? MessagePagination { get; init; }
}
