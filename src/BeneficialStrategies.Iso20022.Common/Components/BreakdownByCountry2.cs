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
/// Specifies the cash-in and cash-out flows by country.
/// </summary>
[IsoId("_K78-cQatEeS3lpTattq7hg")]
[DisplayName("Breakdown By Country")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BreakdownByCountry2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BreakdownByCountry2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BreakdownByCountry2( string reqCountry )
    {
        Country = reqCountry;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Country for which the cash flow is being reported.
    /// </summary>
    [IsoId("_LVijEQatEeS3lpTattq7hg")]
    [DisplayName("Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctry")]
    #endif
    [IsoXmlTag("Ctry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CountryCode Country { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string Country { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string Country { get; init; } 
    #else
    public string Country { get; set; } 
    #endif
    
    /// <summary>
    /// Cash movement into the fund as a result of transactions in shares in an investment fund, for example, subscriptions or switch-ins.
    /// </summary>
    [IsoId("_LVijEwatEeS3lpTattq7hg")]
    [DisplayName("Cash In Forecast")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshInFcst")]
    #endif
    [IsoXmlTag("CshInFcst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashInForecast5? CashInForecast { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashInForecast5? CashInForecast { get; init; } 
    #else
    public CashInForecast5? CashInForecast { get; set; } 
    #endif
    
    /// <summary>
    /// Cash movement out of the fund as a result of transactions in shares in an investment fund, for example, redemptions or switch-outs.
    /// </summary>
    [IsoId("_LVijFQatEeS3lpTattq7hg")]
    [DisplayName("Cash Out Forecast")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshOutFcst")]
    #endif
    [IsoXmlTag("CshOutFcst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashOutForecast5? CashOutForecast { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashOutForecast5? CashOutForecast { get; init; } 
    #else
    public CashOutForecast5? CashOutForecast { get; set; } 
    #endif
    
    /// <summary>
    /// Net cash as a result of the cash-in and cash-out flows specified for the country.
    /// </summary>
    [IsoId("_LVijFwatEeS3lpTattq7hg")]
    [DisplayName("Net Cash Forecast")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetCshFcst")]
    #endif
    [IsoXmlTag("NetCshFcst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NetCashForecast4? NetCashForecast { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetCashForecast4? NetCashForecast { get; init; } 
    #else
    public NetCashForecast4? NetCashForecast { get; set; } 
    #endif
    
    
    #nullable disable
    
}
