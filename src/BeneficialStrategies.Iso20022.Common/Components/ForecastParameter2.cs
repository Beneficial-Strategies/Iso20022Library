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
[IsoId("_UuOnttp-Ed-ak6NoX_4Aeg_215969786")]
[DisplayName("Forecast Parameter")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ForecastParameter2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ForecastParameter2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ForecastParameter2( ReportParameter2Choice_ reqReportParameter )
    {
        ReportParameter = reqReportParameter;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of parameter used for grouping the information in a report, eg, country code, currency code, BIC or a user defined parameter.
    /// </summary>
    [IsoId("_UuOnt9p-Ed-ak6NoX_4Aeg_215969829")]
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
    /// Cash movement in to of a fund as a result of investment funds transactions, eg, subscriptions or switch-out.
    /// </summary>
    [IsoId("_UuOnuNp-Ed-ak6NoX_4Aeg_215969960")]
    [DisplayName("Cash In Forecast Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshInFcstDtls")]
    #endif
    [IsoXmlTag("CshInFcstDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashInForecast1? CashInForecastDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashInForecast1? CashInForecastDetails { get; init; } 
    #else
    public CashInForecast1? CashInForecastDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Cash movement out of a fund as a result of investment funds transactions, eg, redemptions or switch-out.
    /// </summary>
    [IsoId("_UuYYsNp-Ed-ak6NoX_4Aeg_215969925")]
    [DisplayName("Cash Out Forecast Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshOutFcstDtls")]
    #endif
    [IsoXmlTag("CshOutFcstDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashOutForecast1? CashOutForecastDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashOutForecast1? CashOutForecastDetails { get; init; } 
    #else
    public CashOutForecast1? CashOutForecastDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Net cash movements to a fund as a result of investment funds transactions.
    /// </summary>
    [IsoId("_UuYYsdp-Ed-ak6NoX_4Aeg_215969865")]
    [DisplayName("Net Cash Forecast Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetCshFcstDtls")]
    #endif
    [IsoXmlTag("NetCshFcstDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NetCashForecast1? NetCashForecastDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetCashForecast1? NetCashForecastDetails { get; init; } 
    #else
    public NetCashForecast1? NetCashForecastDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
