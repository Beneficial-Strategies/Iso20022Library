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
/// Provides details on an event occurring in a system, whether planned or unplanned as stipulated in the specifications of the system.
/// </summary>
[IsoId("_dw2Oi3hkEeidzqjNEfehPg")]
[DisplayName("System Event")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SystemEvent3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SystemEvent3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SystemEvent3( SystemEventType4Choice_ reqType,System.DateTime reqScheduledTime )
    {
        Type = reqType;
        ScheduledTime = reqScheduledTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Nature of the event that has occurred.
    /// </summary>
    [IsoId("_d6_pA3hkEeidzqjNEfehPg")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SystemEventType4Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SystemEventType4Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemEventType4Choice_ Type { get; init; } 
    #else
    public SystemEventType4Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the event is foreseen to occur.
    /// </summary>
    [IsoId("_d6_pBXhkEeidzqjNEfehPg")]
    [DisplayName("Scheduled Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SchdldTm")]
    #endif
    [IsoXmlTag("SchdldTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime ScheduledTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime ScheduledTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime ScheduledTime { get; init; } 
    #else
    public System.DateTime ScheduledTime { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the event effectively takes place.
    /// </summary>
    [IsoId("_d6_pB3hkEeidzqjNEfehPg")]
    [DisplayName("Effective Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FctvTm")]
    #endif
    [IsoXmlTag("FctvTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? EffectiveTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? EffectiveTime { get; init; } 
    #else
    public System.DateTime? EffectiveTime { get; set; } 
    #endif
    
    /// <summary>
    /// Time at which the event starts.
    /// </summary>
    [IsoId("_d6_pCXhkEeidzqjNEfehPg")]
    [DisplayName("Start Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StartTm")]
    #endif
    [IsoXmlTag("StartTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? StartTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? StartTime { get; init; } 
    #else
    public System.DateTime? StartTime { get; set; } 
    #endif
    
    /// <summary>
    /// Time at which the event ends.
    /// </summary>
    [IsoId("_d6_pC3hkEeidzqjNEfehPg")]
    [DisplayName("End Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndTm")]
    #endif
    [IsoXmlTag("EndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? EndTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? EndTime { get; init; } 
    #else
    public System.DateTime? EndTime { get; set; } 
    #endif
    
    
    #nullable disable
    
}
