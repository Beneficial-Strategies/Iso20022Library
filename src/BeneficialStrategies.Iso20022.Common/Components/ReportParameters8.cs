// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Report Parameters8.
/// </summary>
[IsoId("_Bq0hAZIWEe-HRNGM304Vlw")]
[DisplayName("Report Parameters8")]
public record ReportParameters8
{
    /// <summary>
    /// Report Date And Time.
    /// </summary>
    [DisplayName("Report Date And Time")]
    [IsoXmlTag("RptDtAndTm")]
    public required DateAndDateTime2Choice_ ReportDateAndTime { get; init; }

    /// <summary>
    /// Report Identification.
    /// </summary>
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    public required IsoMax35Text ReportIdentification { get; init; }
}
