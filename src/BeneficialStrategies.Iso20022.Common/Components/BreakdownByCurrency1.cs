// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the cash-in and cash-out flows by currency.
/// </summary>
[IsoId("_RQDQodp-Ed-ak6NoX_4Aeg_1062807624")]
[DisplayName("Breakdown By Currency")]
public partial record BreakdownByCurrency1
{
    #nullable enable
    
    /// <summary>
    /// Currency for which the cash flow is being reported.
    /// </summary>
    [IsoId("_RQDQotp-Ed-ak6NoX_4Aeg_-1284357393")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required ActiveOrHistoricCurrencyCode Currency { get; init; } 
    
    /// <summary>
    /// Cash movement out of the fund as a result of investment funds transactions, eg, redemptions or switch-out.
    /// </summary>
    [IsoId("_RQDQo9p-Ed-ak6NoX_4Aeg_1062808443")]
    [DisplayName("Cash Out Forecast")]
    [IsoXmlTag("CshOutFcst")]
    public CashOutForecast3? CashOutForecast { get; init; } 
    
    /// <summary>
    /// Cash movement into the fund as a result of investment funds transactions, eg, subscriptions or switch-in.
    /// </summary>
    [IsoId("_RQDQpNp-Ed-ak6NoX_4Aeg_1062808015")]
    [DisplayName("Cash In Forecast")]
    [IsoXmlTag("CshInFcst")]
    public CashInForecast3? CashInForecast { get; init; } 
    
    /// <summary>
    /// Net cash as a result of the cash-in and cash-out flows specified for the currency.
    /// </summary>
    [IsoId("_RQDQpdp-Ed-ak6NoX_4Aeg_1062807703")]
    [DisplayName("Net Cash Forecast")]
    [IsoXmlTag("NetCshFcst")]
    public NetCashForecast2? NetCashForecast { get; init; } 
    
    
    #nullable disable
    
}
