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
/// Amount of money for which goods or services are offered, sold, or bought.
/// </summary>
[IsoId("_1FBhMWp7EemmaZLSPtWX5A")]
[DisplayName("Price")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Price8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Price8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Price8( PriceRateOrAmount3Choice_ reqValue )
    {
        Value = reqValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of value in which the price is expressed.
    /// </summary>
    [IsoId("_1RIqkWp7EemmaZLSPtWX5A")]
    [DisplayName("Value Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValTp")]
    #endif
    [IsoXmlTag("ValTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceValueType3Code? ValueType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceValueType3Code? ValueType { get; init; } 
    #else
    public PriceValueType3Code? ValueType { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_1RIqn2p7EemmaZLSPtWX5A")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val")]
    #endif
    [IsoXmlTag("Val")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PriceRateOrAmount3Choice_ Value { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PriceRateOrAmount3Choice_ Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceRateOrAmount3Choice_ Value { get; init; } 
    #else
    public PriceRateOrAmount3Choice_ Value { get; set; } 
    #endif
    
    /// <summary>
    /// Type and information about a price.
    /// </summary>
    [IsoId("_1RIqrWp7EemmaZLSPtWX5A")]
    [DisplayName("Price Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricTp")]
    #endif
    [IsoXmlTag("PricTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TypeOfPrice1Code? PriceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfPrice1Code? PriceType { get; init; } 
    #else
    public TypeOfPrice1Code? PriceType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
