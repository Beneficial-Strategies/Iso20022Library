// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details about the schedule change.
/// </summary>
[IsoId("_bMr9gBkcEeapYKOltfjd7A")]
[DisplayName("Schedule Change Entry")]
public partial record ScheduleChangeEntry1
{
    #nullable enable
    
    /// <summary>
    /// Type of the scheduled event.
    /// </summary>
    [IsoId("_MiT-UBkdEeapYKOltfjd7A")]
    [DisplayName("Schedule Event Type")]
    [IsoXmlTag("SchdlEvtTp")]
    public required SystemEventType2Choice_ ScheduleEventType { get; init; } 
    
    /// <summary>
    /// Identificaiton of the scheduled event.
    /// </summary>
    [IsoId("_zvnEQBkdEeapYKOltfjd7A")]
    [DisplayName("Schedule Event Identification")]
    [IsoXmlTag("SchdlEvtId")]
    [IsoSimpleType(IsoSimpleType.Exact1NumericText)]
    public IsoExact1NumericText? ScheduleEventIdentification { get; init; } 
    
    /// <summary>
    /// New frequency of the scheduled event.
    /// </summary>
    [IsoId("_FkCvMBkeEeapYKOltfjd7A")]
    [DisplayName("Event Frequency")]
    [IsoXmlTag("EvtFrqcy")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public IsoMax4Text? EventFrequency { get; init; } 
    
    /// <summary>
    /// Frequency of the scheduled event before change.
    /// </summary>
    [IsoId("_Q3lgABkeEeapYKOltfjd7A")]
    [DisplayName("Event Previous Frequency")]
    [IsoXmlTag("EvtPrvsFrqcy")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public IsoMax4Text? EventPreviousFrequency { get; init; } 
    
    /// <summary>
    /// New scheduled time of the event.
    /// </summary>
    [IsoId("_iFbFABkeEeapYKOltfjd7A")]
    [DisplayName("Event Time")]
    [IsoXmlTag("EvtTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? EventTime { get; init; } 
    
    /// <summary>
    /// Scheduled time of the event before change.
    /// </summary>
    [IsoId("_v_fMIBkeEeapYKOltfjd7A")]
    [DisplayName("Event Previous Time")]
    [IsoXmlTag("EvtPrvsTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? EventPreviousTime { get; init; } 
    
    /// <summary>
    /// Minimum duration of event.
    /// </summary>
    [IsoId("_FBeJICHbEea-Xbqk8qZGYQ")]
    [DisplayName("Event Duration")]
    [IsoXmlTag("EvtDrtn")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? EventDuration { get; init; } 
    
    /// <summary>
    /// Set earlier duration of event.
    /// </summary>
    [IsoId("_xYTUsCHbEea-Xbqk8qZGYQ")]
    [DisplayName("Event Previous Duration")]
    [IsoXmlTag("EvtPrvsDrtn")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? EventPreviousDuration { get; init; } 
    
    /// <summary>
    /// Type of schedule modification (i.e. event cancelled, new event).
    /// </summary>
    [IsoId("_GXOqMBkfEeapYKOltfjd7A")]
    [DisplayName("Change Type")]
    [IsoXmlTag("ChngTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ChangeType { get; init; } 
    
    
    #nullable disable
    
}
