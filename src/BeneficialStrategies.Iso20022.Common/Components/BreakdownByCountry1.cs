// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the cash-in and cash-out flows by country.
/// </summary>
[IsoId("_RQDQptp-Ed-ak6NoX_4Aeg_1416516304")]
[DisplayName("Breakdown By Country")]
public partial record BreakdownByCountry1
{
    #nullable enable
    
    /// <summary>
    /// Country for which the cash flow is being reported.
    /// </summary>
    [IsoId("_RQDQp9p-Ed-ak6NoX_4Aeg_-1411802767")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public required CountryCode Country { get; init; } 
    
    /// <summary>
    /// Cash movement into the fund as a result of investment funds transactions, eg, subscriptions or switch-in.
    /// </summary>
    [IsoId("_RQDQqNp-Ed-ak6NoX_4Aeg_1416516677")]
    [DisplayName("Cash In Forecast")]
    [IsoXmlTag("CshInFcst")]
    public CashInForecast3? CashInForecast { get; init; } 
    
    /// <summary>
    /// Cash movement out of the fund as a result of investment funds transactions, eg, redemptions or switch-out.
    /// </summary>
    [IsoId("_RQNBoNp-Ed-ak6NoX_4Aeg_1416517020")]
    [DisplayName("Cash Out Forecast")]
    [IsoXmlTag("CshOutFcst")]
    public CashOutForecast3? CashOutForecast { get; init; } 
    
    /// <summary>
    /// Net cash as a result of the cash-in and cash-out flows specified for the country.
    /// </summary>
    [IsoId("_RQNBodp-Ed-ak6NoX_4Aeg_1416516582")]
    [DisplayName("Net Cash Forecast")]
    [IsoXmlTag("NetCshFcst")]
    public NetCashForecast2? NetCashForecast { get; init; } 
    
    
    #nullable disable
    
}
