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
/// Provides the value, type and source of price.
/// </summary>
[IsoId("_E_XYoaB6EeOEyO7fCl8lLA")]
[DisplayName("Price")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Price6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Price6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Price6( PriceRateOrAmountChoice_ reqRateOrAmount,TypeOfPrice13Code reqType,PriceSource2Code reqSource )
    {
        RateOrAmount = reqRateOrAmount;
        Type = reqType;
        Source = reqSource;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Value of the price expressed as a currency and value or as a rate.
    /// </summary>
    [IsoId("_PsBIkKB6EeOEyO7fCl8lLA")]
    [DisplayName("Rate Or Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RateOrAmt")]
    #endif
    [IsoXmlTag("RateOrAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PriceRateOrAmountChoice_ RateOrAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PriceRateOrAmountChoice_ RateOrAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceRateOrAmountChoice_ RateOrAmount { get; init; } 
    #else
    public PriceRateOrAmountChoice_ RateOrAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specification of the price type.
    /// </summary>
    [IsoId("_VrjpIKB6EeOEyO7fCl8lLA")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TypeOfPrice13Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TypeOfPrice13Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfPrice13Code Type { get; init; } 
    #else
    public TypeOfPrice13Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Source for the price valuation.
    /// </summary>
    [IsoId("_ctv5gKB6EeOEyO7fCl8lLA")]
    [DisplayName("Source")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Src")]
    #endif
    [IsoXmlTag("Src")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PriceSource2Code Source { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PriceSource2Code Source { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceSource2Code Source { get; init; } 
    #else
    public PriceSource2Code Source { get; set; } 
    #endif
    
    
    #nullable disable
    
}
