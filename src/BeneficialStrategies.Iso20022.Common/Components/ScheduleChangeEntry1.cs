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
/// Details about the schedule change.
/// </summary>
[IsoId("_bMr9gBkcEeapYKOltfjd7A")]
[DisplayName("Schedule Change Entry")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ScheduleChangeEntry1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ScheduleChangeEntry1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ScheduleChangeEntry1( SystemEventType2Choice_ reqScheduleEventType,System.String reqChangeType )
    {
        ScheduleEventType = reqScheduleEventType;
        ChangeType = reqChangeType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of the scheduled event.
    /// </summary>
    [IsoId("_MiT-UBkdEeapYKOltfjd7A")]
    [DisplayName("Schedule Event Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SchdlEvtTp")]
    #endif
    [IsoXmlTag("SchdlEvtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SystemEventType2Choice_ ScheduleEventType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SystemEventType2Choice_ ScheduleEventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemEventType2Choice_ ScheduleEventType { get; init; } 
    #else
    public SystemEventType2Choice_ ScheduleEventType { get; set; } 
    #endif
    
    /// <summary>
    /// Identificaiton of the scheduled event.
    /// </summary>
    [IsoId("_zvnEQBkdEeapYKOltfjd7A")]
    [DisplayName("Schedule Event Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SchdlEvtId")]
    #endif
    [IsoXmlTag("SchdlEvtId")]
    [IsoSimpleType(IsoSimpleType.Exact1NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact1NumericText? ScheduleEventIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ScheduleEventIdentification { get; init; } 
    #else
    public System.String? ScheduleEventIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// New frequency of the scheduled event.
    /// </summary>
    [IsoId("_FkCvMBkeEeapYKOltfjd7A")]
    [DisplayName("Event Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtFrqcy")]
    #endif
    [IsoXmlTag("EvtFrqcy")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4Text? EventFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EventFrequency { get; init; } 
    #else
    public System.String? EventFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Frequency of the scheduled event before change.
    /// </summary>
    [IsoId("_Q3lgABkeEeapYKOltfjd7A")]
    [DisplayName("Event Previous Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtPrvsFrqcy")]
    #endif
    [IsoXmlTag("EvtPrvsFrqcy")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4Text? EventPreviousFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EventPreviousFrequency { get; init; } 
    #else
    public System.String? EventPreviousFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// New scheduled time of the event.
    /// </summary>
    [IsoId("_iFbFABkeEeapYKOltfjd7A")]
    [DisplayName("Event Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtTm")]
    #endif
    [IsoXmlTag("EvtTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? EventTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? EventTime { get; init; } 
    #else
    public System.TimeOnly? EventTime { get; set; } 
    #endif
    
    /// <summary>
    /// Scheduled time of the event before change.
    /// </summary>
    [IsoId("_v_fMIBkeEeapYKOltfjd7A")]
    [DisplayName("Event Previous Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtPrvsTm")]
    #endif
    [IsoXmlTag("EvtPrvsTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? EventPreviousTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? EventPreviousTime { get; init; } 
    #else
    public System.TimeOnly? EventPreviousTime { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum duration of event.
    /// </summary>
    [IsoId("_FBeJICHbEea-Xbqk8qZGYQ")]
    [DisplayName("Event Duration")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtDrtn")]
    #endif
    [IsoXmlTag("EvtDrtn")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3NumericText? EventDuration { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EventDuration { get; init; } 
    #else
    public System.String? EventDuration { get; set; } 
    #endif
    
    /// <summary>
    /// Set earlier duration of event.
    /// </summary>
    [IsoId("_xYTUsCHbEea-Xbqk8qZGYQ")]
    [DisplayName("Event Previous Duration")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtPrvsDrtn")]
    #endif
    [IsoXmlTag("EvtPrvsDrtn")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3NumericText? EventPreviousDuration { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EventPreviousDuration { get; init; } 
    #else
    public System.String? EventPreviousDuration { get; set; } 
    #endif
    
    /// <summary>
    /// Type of schedule modification (i.e. event cancelled, new event).
    /// </summary>
    [IsoId("_GXOqMBkfEeapYKOltfjd7A")]
    [DisplayName("Change Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChngTp")]
    #endif
    [IsoXmlTag("ChngTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ChangeType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ChangeType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ChangeType { get; init; } 
    #else
    public System.String ChangeType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
