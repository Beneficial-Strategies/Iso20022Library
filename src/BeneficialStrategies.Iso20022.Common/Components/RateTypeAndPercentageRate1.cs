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
/// Specifies the value expressed as a rate type and a percentage rate.
/// </summary>
[IsoId("_uI7O4CeEEeOXAt_43VmZGw")]
[DisplayName("Rate Type And Percentage Rate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RateTypeAndPercentageRate1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RateTypeAndPercentageRate1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RateTypeAndPercentageRate1( RateType28Choice_ reqRateType,System.Decimal reqRate )
    {
        RateType = reqRateType;
        Rate = reqRate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Value expressed as a rate type.
    /// </summary>
    [IsoId("_83lbsCeEEeOXAt_43VmZGw")]
    [DisplayName("Rate Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RateTp")]
    #endif
    [IsoXmlTag("RateTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RateType28Choice_ RateType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RateType28Choice_ RateType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateType28Choice_ RateType { get; init; } 
    #else
    public RateType28Choice_ RateType { get; set; } 
    #endif
    
    /// <summary>
    /// Value expressed as a rate.
    /// </summary>
    [IsoId("_91nxQCeEEeOXAt_43VmZGw")]
    [DisplayName("Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rate")]
    #endif
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate Rate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal Rate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal Rate { get; init; } 
    #else
    public System.Decimal Rate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
