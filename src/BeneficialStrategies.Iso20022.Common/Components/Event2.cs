// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on an event that happened in a system.
/// </summary>
[IsoId("_whUBYU7TEeSGH6dwL1uJcg")]
[DisplayName("Event")]
public partial record Event2
{
    #nullable enable
    
    /// <summary>
    /// Proprietary code used to specify an event that occurred in a system.
    /// </summary>
    [IsoId("_w2BtIU7TEeSGH6dwL1uJcg")]
    [DisplayName("Event Code")]
    [IsoXmlTag("EvtCd")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public required IsoMax4AlphaNumericText EventCode { get; init; } 
    
    /// <summary>
    /// Describes the parameters of an event which occurred in a system.
    /// </summary>
    [IsoId("_w2BtI07TEeSGH6dwL1uJcg")]
    [DisplayName("Event Parameter")]
    [IsoXmlTag("EvtParam")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? EventParameter { get; init; } 
    
    /// <summary>
    /// Free text used to describe an event which occurred in a system.
    /// </summary>
    [IsoId("_w2BtJU7TEeSGH6dwL1uJcg")]
    [DisplayName("Event Description")]
    [IsoXmlTag("EvtDesc")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000 ,MinimumLength = 1)]
    public IsoMax1000Text? EventDescription { get; init; } 
    
    /// <summary>
    /// Date and time at which the event occurred.
    /// </summary>
    [IsoId("_w2BtJ07TEeSGH6dwL1uJcg")]
    [DisplayName("Event Time")]
    [IsoXmlTag("EvtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? EventTime { get; init; } 
    
    
    #nullable disable
    
}
