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
/// Funding sources used to finance margin loans.
/// </summary>
[IsoId("_Z9DqP2uBEeu7Sr851GoLXg")]
[DisplayName("Funding Source")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FundingSource3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FundingSource3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FundingSource3( FundingSourceType1Code reqType,AmountAndDirection53 reqMarketValue )
    {
        Type = reqType;
        MarketValue = reqMarketValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of a funding used.
    /// </summary>
    [IsoId("_Z-6rYWuBEeu7Sr851GoLXg")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FundingSourceType1Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FundingSourceType1Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundingSourceType1Code Type { get; init; } 
    #else
    public FundingSourceType1Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Market value of funding sources in base currency.
    /// </summary>
    [IsoId("_Z-6rY2uBEeu7Sr851GoLXg")]
    [DisplayName("Market Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktVal")]
    #endif
    [IsoXmlTag("MktVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection53 MarketValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection53 MarketValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection53 MarketValue { get; init; } 
    #else
    public AmountAndDirection53 MarketValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
