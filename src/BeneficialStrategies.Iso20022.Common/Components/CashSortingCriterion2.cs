// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Criterion by which the cash movements are broken down.
/// </summary>
[IsoId("_Uw6IRdp-Ed-ak6NoX_4Aeg_1035399646")]
[DisplayName("Cash Sorting Criterion")]
public partial record CashSortingCriterion2
{
    #nullable enable
    
    /// <summary>
    /// Type of criterion by which the cash flow is being broken down, ie, country, institution, currency code or a user defined type, such as a region or distribution channel.
    /// </summary>
    [IsoId("_Uw6IRtp-Ed-ak6NoX_4Aeg_1035399672")]
    [DisplayName("Sorting Criterion Type")]
    [IsoXmlTag("SrtgCritnTp")]
    public required SortCriteria1Choice_ SortingCriterionType { get; init; } 
    
    /// <summary>
    /// Parameter for which the cash movements are reported.
    /// </summary>
    [IsoId("_Uw6IR9p-Ed-ak6NoX_4Aeg_1035399862")]
    [DisplayName("Forecast Breakdown Details")]
    [IsoXmlTag("FcstBrkdwnDtls")]
    public ValueList<ForecastParameter2> ForecastBreakdownDetails { get; init; } = [];
    // ID for the above is _Uw6IR9p-Ed-ak6NoX_4Aeg_1035399862
    
    
    #nullable disable
    
}
