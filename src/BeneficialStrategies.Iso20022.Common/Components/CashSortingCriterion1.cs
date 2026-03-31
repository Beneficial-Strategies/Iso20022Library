// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Criterion by which the cash movements are broken down.
/// </summary>
[IsoId("_Uw6IQtp-Ed-ak6NoX_4Aeg_1294908608")]
[DisplayName("Cash Sorting Criterion")]
public record CashSortingCriterion1
{
    /// <summary>
    /// Type of criterion by which the estimated cash flow is being broken down, ie, country, institution, currency code or a user defined type, such as a region or distribution channel.
    /// </summary>
    [IsoId("_Uw6IQ9p-Ed-ak6NoX_4Aeg_1294908625")]
    [DisplayName("Sorting Criterion Type")]
    [IsoXmlTag("SrtgCritnTp")]
    public required SortCriteria1Choice_ SortingCriterionType { get; init; }

    /// <summary>
    /// Parameter for which the cash movements are reported.
    /// </summary>
    [IsoId("_Uw6IRNp-Ed-ak6NoX_4Aeg_1294908661")]
    [DisplayName("Forecast Breakdown Details")]
    [IsoXmlTag("FcstBrkdwnDtls")]
    public ValueList<ForecastParameter1> ForecastBreakdownDetails { get; init; } = [];
    // ID for the above is _Uw6IRNp-Ed-ak6NoX_4Aeg_1294908661
}
