// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of report.
/// </summary>
[IsoId("_RJ8op9p-Ed-ak6NoX_4Aeg_44495022")]
[DisplayName("Report Type")]
public record ReportType2
{
    /// <summary>
    /// Specifies whether the report is precalculated or current.
    /// </summary>
    [IsoId("_RKFykNp-Ed-ak6NoX_4Aeg_980019859")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ReportType2Code Type { get; init; }
}
