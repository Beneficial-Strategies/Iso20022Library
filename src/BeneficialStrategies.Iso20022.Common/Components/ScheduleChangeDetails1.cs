// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Changes in the schedule.
/// </summary>
[IsoId("_7X0dsBkbEeapYKOltfjd7A")]
[DisplayName("Schedule Change Details")]
public partial record ScheduleChangeDetails1
{
    #nullable enable
    
    /// <summary>
    /// Date on which the schedule changes became effective.
    /// </summary>
    [IsoId("_PZrpgBkcEeapYKOltfjd7A")]
    [DisplayName("Schedule Change Effective Date")]
    [IsoXmlTag("SchdlChngFctvDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ScheduleChangeEffectiveDate { get; init; } 
    
    /// <summary>
    /// Information about schedule.
    /// </summary>
    [IsoId("_ZLwAgBkcEeapYKOltfjd7A")]
    [DisplayName("Schedule Entry")]
    [IsoXmlTag("SchdlNtry")]
    public ValueList<ScheduleChangeEntry1> ScheduleEntry { get; init; } = [];
    // ID for the above is _ZLwAgBkcEeapYKOltfjd7A
    
    
    #nullable disable
    
}
