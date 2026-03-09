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
/// Ratio expressed as a quotient of quantities.
/// </summary>
[IsoId("_OYixZXeuEeGnSLS4l8GDAA")]
[DisplayName("Long Quantity To Quantity Ratio")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LongQuantityToQuantityRatio2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LongQuantityToQuantityRatio2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LongQuantityToQuantityRatio2( System.UInt64 reqLongQuantity1,System.UInt64 reqLongQuantity2 )
    {
        LongQuantity1 = reqLongQuantity1;
        LongQuantity2 = reqLongQuantity2;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// High precision numerator of the quotient of quantities.
    /// </summary>
    [IsoId("_OYixaHeuEeGnSLS4l8GDAA")]
    [DisplayName("Long Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LngQty1")]
    #endif
    [IsoXmlTag("LngQty1")]
    [IsoSimpleType(IsoSimpleType.LongDecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoLongDecimalNumber LongQuantity1 { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 LongQuantity1 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 LongQuantity1 { get; init; } 
    #else
    public System.UInt64 LongQuantity1 { get; set; } 
    #endif
    
    /// <summary>
    /// High precision denominator of the quotient of quantities.
    /// </summary>
    [IsoId("_OYixa3euEeGnSLS4l8GDAA")]
    [DisplayName("Long Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LngQty2")]
    #endif
    [IsoXmlTag("LngQty2")]
    [IsoSimpleType(IsoSimpleType.LongDecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoLongDecimalNumber LongQuantity2 { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 LongQuantity2 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 LongQuantity2 { get; init; } 
    #else
    public System.UInt64 LongQuantity2 { get; set; } 
    #endif
    
    
    #nullable disable
    
}
