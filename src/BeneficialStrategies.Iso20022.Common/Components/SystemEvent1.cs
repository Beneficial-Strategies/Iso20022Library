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
/// Detailed information about an event occurring on a system, whether planned, eg, cut-off time for a specific type of eligible transfer, or unplanned, eg, an unsolicited failure, as stipulated in the specifications of the system.
/// </summary>
[IsoId("_Sa226dp-Ed-ak6NoX_4Aeg_1763837714")]
[DisplayName("System Event")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SystemEvent1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SystemEvent1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SystemEvent1( SystemEventType1Choice_ reqType,System.DateTime reqScheduledTime )
    {
        Type = reqType;
        ScheduledTime = reqScheduledTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Nature of the event that has occurred.
    /// </summary>
    [IsoId("_Sa226tp-Ed-ak6NoX_4Aeg_1771222565")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SystemEventType1Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SystemEventType1Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemEventType1Choice_ Type { get; init; } 
    #else
    public SystemEventType1Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the event is foreseen to occur.
    /// </summary>
    [IsoId("_Sa2269p-Ed-ak6NoX_4Aeg_1771222643")]
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
    [IsoId("_Sa227Np-Ed-ak6NoX_4Aeg_1771222972")]
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
    
    
    #nullable disable
    
}
