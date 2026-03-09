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
/// Changes in the schedule.
/// </summary>
[IsoId("_7X0dsBkbEeapYKOltfjd7A")]
[DisplayName("Schedule Change Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ScheduleChangeDetails1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ScheduleChangeDetails1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ScheduleChangeDetails1( System.DateOnly reqScheduleChangeEffectiveDate )
    {
        ScheduleChangeEffectiveDate = reqScheduleChangeEffectiveDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date on which the schedule changes became effective.
    /// </summary>
    [IsoId("_PZrpgBkcEeapYKOltfjd7A")]
    [DisplayName("Schedule Change Effective Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SchdlChngFctvDt")]
    #endif
    [IsoXmlTag("SchdlChngFctvDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ScheduleChangeEffectiveDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly ScheduleChangeEffectiveDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ScheduleChangeEffectiveDate { get; init; } 
    #else
    public System.DateOnly ScheduleChangeEffectiveDate { get; set; } 
    #endif
    
    /// <summary>
    /// Information about schedule.
    /// </summary>
    [IsoId("_ZLwAgBkcEeapYKOltfjd7A")]
    [DisplayName("Schedule Entry")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SchdlNtry")]
    #endif
    [IsoXmlTag("SchdlNtry")]
    public ValueList<ScheduleChangeEntry1> ScheduleEntry { get; init; } = new ValueList<ScheduleChangeEntry1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _ZLwAgBkcEeapYKOltfjd7A
    
    
    #nullable disable
    
}
