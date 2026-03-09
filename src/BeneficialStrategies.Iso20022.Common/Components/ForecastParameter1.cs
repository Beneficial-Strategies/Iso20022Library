// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters used to report cash movements,eg, country code, currency code, BIC or a user defined parameter.
/// </summary>
[IsoId("_UwUSYdp-Ed-ak6NoX_4Aeg_-550549340")]
[DisplayName("Forecast Parameter")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ForecastParameter1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ForecastParameter1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ForecastParameter1( ReportParameter2Choice_ reqReportParameter )
    {
        ReportParameter = reqReportParameter;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of parameter used for grouping the information in a report, eg, country code, currency code, BIC or a user defined parameter.
    /// </summary>
    [IsoId("_UwUSYtp-Ed-ak6NoX_4Aeg_-550549314")]
    [DisplayName("Report Parameter")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptParam")]
    #endif
    [IsoXmlTag("RptParam")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReportParameter2Choice_ ReportParameter { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReportParameter2Choice_ ReportParameter { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportParameter2Choice_ ReportParameter { get; init; } 
    #else
    public ReportParameter2Choice_ ReportParameter { get; set; } 
    #endif
    
    /// <summary>
    /// Cash movements into a fund as a result of investment funds transactions, eg, subscriptions or switch-in.
    /// </summary>
    [IsoId("_UwUSY9p-Ed-ak6NoX_4Aeg_-550549201")]
    [DisplayName("Estimated Cash In Forecast Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstmtdCshInFcstDtls")]
    #endif
    [IsoXmlTag("EstmtdCshInFcstDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashInForecast1? EstimatedCashInForecastDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashInForecast1? EstimatedCashInForecastDetails { get; init; } 
    #else
    public CashInForecast1? EstimatedCashInForecastDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Cash movements out of a fund as a result of investment funds transactions, eg, redemptions or switch-out.
    /// </summary>
    [IsoId("_UwUSZNp-Ed-ak6NoX_4Aeg_-550549141")]
    [DisplayName("Estimated Cash Out Forecast Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstmtdCshOutFcstDtls")]
    #endif
    [IsoXmlTag("EstmtdCshOutFcstDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashOutForecast1? EstimatedCashOutForecastDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashOutForecast1? EstimatedCashOutForecastDetails { get; init; } 
    #else
    public CashOutForecast1? EstimatedCashOutForecastDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Net cash movements to a fund as a result of investment funds transactions.
    /// </summary>
    [IsoId("_UwUSZdp-Ed-ak6NoX_4Aeg_-550549260")]
    [DisplayName("Estimated Net Cash Forecast Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstmtdNetCshFcstDtls")]
    #endif
    [IsoXmlTag("EstmtdNetCshFcstDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NetCashForecast1? EstimatedNetCashForecastDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetCashForecast1? EstimatedNetCashForecastDetails { get; init; } 
    #else
    public NetCashForecast1? EstimatedNetCashForecastDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
