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
/// Describes how time to maturity is reported.
/// </summary>
[IsoId("_USvwUMVbEeiYpLQka876sg")]
[DisplayName("Maturity Term")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MaturityTerm2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MaturityTerm2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MaturityTerm2( RateBasis1Code reqUnit,System.UInt64 reqValue )
    {
        Unit = reqUnit;
        Value = reqValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unit for the rate basis.
    /// </summary>
    [IsoId("_USvwUsVbEeiYpLQka876sg")]
    [DisplayName("Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Unit")]
    #endif
    [IsoXmlTag("Unit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RateBasis1Code Unit { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RateBasis1Code Unit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateBasis1Code Unit { get; init; } 
    #else
    public RateBasis1Code Unit { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the maturity term in number of units.
    /// </summary>
    [IsoId("_USvwUcVbEeiYpLQka876sg")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val")]
    #endif
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max3Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax3Number Value { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 Value { get; init; } 
    #else
    public System.UInt64 Value { get; set; } 
    #endif
    
    
    #nullable disable
    
}
