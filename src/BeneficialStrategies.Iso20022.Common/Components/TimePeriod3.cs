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
[IsoId("_r8aHYVo6Ee23K4GXSpBSeg")]
[DisplayName("Time Period")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TimePeriod3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Time at which the time span starts.
    /// </summary>
    [IsoId("_r90coVo6Ee23K4GXSpBSeg")]
    [DisplayName("From Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrTm")]
    #endif
    [IsoXmlTag("FrTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? FromTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? FromTime { get; init; } 
    #else
    public System.TimeOnly? FromTime { get; set; } 
    #endif
    
    /// <summary>
    /// Time at which the time span ends.
    /// </summary>
    [IsoId("_r90co1o6Ee23K4GXSpBSeg")]
    [DisplayName("To Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ToTm")]
    #endif
    [IsoXmlTag("ToTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? ToTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? ToTime { get; init; } 
    #else
    public System.TimeOnly? ToTime { get; set; } 
    #endif
    
    
    #nullable disable
    
}
