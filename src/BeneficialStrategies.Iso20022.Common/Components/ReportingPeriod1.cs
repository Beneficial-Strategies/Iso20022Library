// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the requested reporting period.
/// </summary>
[IsoId("_T57c9dp-Ed-ak6NoX_4Aeg_566244316")]
[DisplayName("Reporting Period")]
public record ReportingPeriod1
{
    /// <summary>
    /// Specifies a date range.
    /// </summary>
    [IsoId("_T57c9tp-Ed-ak6NoX_4Aeg_566244351")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public required DatePeriodDetails1 FromToDate { get; init; }

    /// <summary>
    /// Specifies a time range.
    /// </summary>
    [IsoId("_T57c99p-Ed-ak6NoX_4Aeg_-966470712")]
    [DisplayName("From To Time")]
    [IsoXmlTag("FrToTm")]
    public required TimePeriodDetails1 FromToTime { get; init; }

    /// <summary>
    /// Specifies whether all matching items need to be reported or only those items that are new or have changed since the last similar request was made.
    /// </summary>
    [IsoId("_T57c-Np-Ed-ak6NoX_4Aeg_-303042847")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required QueryType3Code Type { get; init; }
}
