// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the parameters of the report.
/// </summary>
[IsoId("_QlScZdp-Ed-ak6NoX_4Aeg_-2031836771")]
[DisplayName("Report Parameters")]
public record ReportParameters4
{
    /// <summary>
    /// Unique identification of the report.
    /// </summary>
    [IsoId("_QlScZtp-Ed-ak6NoX_4Aeg_-2013136855")]
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ReportIdentification { get; init; }

    /// <summary>
    /// Date and time of the report.
    /// </summary>
    [IsoId("_QlScZ9p-Ed-ak6NoX_4Aeg_-1387002249")]
    [DisplayName("Report Date And Time")]
    [IsoXmlTag("RptDtAndTm")]
    public required DateAndDateTimeChoice_ ReportDateAndTime { get; init; }
}
