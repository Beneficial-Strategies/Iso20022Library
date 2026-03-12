// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters used to report cash movements,eg, country code, currency code, BIC or a user defined parameter.
/// </summary>
[IsoId("_UwUSYdp-Ed-ak6NoX_4Aeg_-550549340")]
[DisplayName("Forecast Parameter")]
public partial record ForecastParameter1
{
    #nullable enable
    
    /// <summary>
    /// Type of parameter used for grouping the information in a report, eg, country code, currency code, BIC or a user defined parameter.
    /// </summary>
    [IsoId("_UwUSYtp-Ed-ak6NoX_4Aeg_-550549314")]
    [DisplayName("Report Parameter")]
    [IsoXmlTag("RptParam")]
    public required ReportParameter2Choice_ ReportParameter { get; init; } 
    
    /// <summary>
    /// Cash movements into a fund as a result of investment funds transactions, eg, subscriptions or switch-in.
    /// </summary>
    [IsoId("_UwUSY9p-Ed-ak6NoX_4Aeg_-550549201")]
    [DisplayName("Estimated Cash In Forecast Details")]
    [IsoXmlTag("EstmtdCshInFcstDtls")]
    public CashInForecast1? EstimatedCashInForecastDetails { get; init; } 
    
    /// <summary>
    /// Cash movements out of a fund as a result of investment funds transactions, eg, redemptions or switch-out.
    /// </summary>
    [IsoId("_UwUSZNp-Ed-ak6NoX_4Aeg_-550549141")]
    [DisplayName("Estimated Cash Out Forecast Details")]
    [IsoXmlTag("EstmtdCshOutFcstDtls")]
    public CashOutForecast1? EstimatedCashOutForecastDetails { get; init; } 
    
    /// <summary>
    /// Net cash movements to a fund as a result of investment funds transactions.
    /// </summary>
    [IsoId("_UwUSZdp-Ed-ak6NoX_4Aeg_-550549260")]
    [DisplayName("Estimated Net Cash Forecast Details")]
    [IsoXmlTag("EstmtdNetCshFcstDtls")]
    public NetCashForecast1? EstimatedNetCashForecastDetails { get; init; } 
    
    
    #nullable disable
    
}
