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
[IsoId("_RKFykdp-Ed-ak6NoX_4Aeg_1945213198")]
[DisplayName("Report Type")]
public record ReportType3
{
    /// <summary>
    /// Specifies whether the report is for a matched or pre-matched data set.
    /// </summary>
    [IsoId("_RKFyktp-Ed-ak6NoX_4Aeg_-2108712606")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required InstructionType3Code Type { get; init; }
}
