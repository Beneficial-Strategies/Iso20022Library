// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a cash forecast report.
/// </summary>
[IsoId("_Uu-Omtp-Ed-ak6NoX_4Aeg_1656814301")]
[DisplayName("Fund Detailed Confirmed Cash Forecast Report")]
public partial record FundDetailedConfirmedCashForecastReport1
{
    #nullable enable
    
    /// <summary>
    /// Information related to the cash-in and cash-out flows for a specific trade date as a result of investment fund transactions, for example, subscriptions, redemptions or switches to/from a specified investment fund. The information provided is sorted by pre-defined criteria such as country, institution, currency or user defined criteria.
    /// </summary>
    [IsoId("_UvH_kNp-Ed-ak6NoX_4Aeg_490161983")]
    [DisplayName("Fund Cash Forecast Details")]
    [IsoXmlTag("FndCshFcstDtls")]
    public ValueList<FundCashForecast2> FundCashForecastDetails { get; init; } = new ValueList<FundCashForecast2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _UvH_kNp-Ed-ak6NoX_4Aeg_490161983
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_UvH_kdp-Ed-ak6NoX_4Aeg_556654600")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; } 
    
    
    #nullable disable
    
}
