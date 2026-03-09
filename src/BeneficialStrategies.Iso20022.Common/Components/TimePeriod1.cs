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
/// Particular time span specified between a start time and an end time. The time period cannot exceed 24 hours.
/// </summary>
[IsoId("__QUJoZliEeeE1Ya-LgRsuQ")]
[DisplayName("Time Period")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TimePeriod1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TimePeriod1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TimePeriod1( System.TimeOnly reqFromTime,System.TimeOnly reqToTime )
    {
        FromTime = reqFromTime;
        ToTime = reqToTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Time at which the time span starts.
    /// </summary>
    [IsoId("__YnKAZliEeeE1Ya-LgRsuQ")]
    [DisplayName("From Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrTm")]
    #endif
    [IsoXmlTag("FrTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISOTime FromTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.TimeOnly FromTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly FromTime { get; init; } 
    #else
    public System.TimeOnly FromTime { get; set; } 
    #endif
    
    /// <summary>
    /// Time at which the time span ends.
    /// </summary>
    [IsoId("__YnKA5liEeeE1Ya-LgRsuQ")]
    [DisplayName("To Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ToTm")]
    #endif
    [IsoXmlTag("ToTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISOTime ToTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.TimeOnly ToTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly ToTime { get; init; } 
    #else
    public System.TimeOnly ToTime { get; set; } 
    #endif
    
    
    #nullable disable
    
}
