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
/// Possible valuation factors.
/// </summary>
[IsoId("_Lh2DkDYoEeuD7rm9md9zvg")]
[DisplayName("Valuation Factor Breakdown")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ValuationFactorBreakdown1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Aggregated adjustment applied on the liability/collateral to calculate the position. It is the sum of the inflation, the haircut/margin and pool factors.
    /// </summary>
    [IsoId("_wQR6YTYoEeuD7rm9md9zvg")]
    [DisplayName("Valuation Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnFctr")]
    #endif
    [IsoXmlTag("ValtnFctr")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOneRate? ValuationFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ValuationFactor { get; init; } 
    #else
    public System.Decimal? ValuationFactor { get; set; } 
    #endif
    
    /// <summary>
    /// Adjustment related to inflation applied on the liability/collateral to calculate the position. 
    /// </summary>
    [IsoId("_w_l3cTYoEeuD7rm9md9zvg")]
    [DisplayName("Inflation Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InfltnFctr")]
    #endif
    [IsoXmlTag("InfltnFctr")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOneRate? InflationFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? InflationFactor { get; init; } 
    #else
    public System.Decimal? InflationFactor { get; set; } 
    #endif
    
    /// <summary>
    /// Haircut or margin on the security  expressed as a percentage.
    /// </summary>
    [IsoId("_xxRzETYoEeuD7rm9md9zvg")]
    [DisplayName("Haircut")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hrcut")]
    #endif
    [IsoXmlTag("Hrcut")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOneRate? Haircut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? Haircut { get; init; } 
    #else
    public System.Decimal? Haircut { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage that applies to price of the securities following a redemption.
    /// </summary>
    [IsoId("_yzoA4TYoEeuD7rm9md9zvg")]
    [DisplayName("Pool Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PoolFctr")]
    #endif
    [IsoXmlTag("PoolFctr")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOneRate? PoolFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? PoolFactor { get; init; } 
    #else
    public System.Decimal? PoolFactor { get; set; } 
    #endif
    
    
    #nullable disable
    
}
