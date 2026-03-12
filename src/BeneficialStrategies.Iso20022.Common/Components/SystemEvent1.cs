// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed information about an event occurring on a system, whether planned, eg, cut-off time for a specific type of eligible transfer, or unplanned, eg, an unsolicited failure, as stipulated in the specifications of the system.
/// </summary>
[IsoId("_Sa226dp-Ed-ak6NoX_4Aeg_1763837714")]
[DisplayName("System Event")]
public partial record SystemEvent1
{
    #nullable enable
    
    /// <summary>
    /// Nature of the event that has occurred.
    /// </summary>
    [IsoId("_Sa226tp-Ed-ak6NoX_4Aeg_1771222565")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required SystemEventType1Choice_ Type { get; init; } 
    
    /// <summary>
    /// Date and time at which the event is foreseen to occur.
    /// </summary>
    [IsoId("_Sa2269p-Ed-ak6NoX_4Aeg_1771222643")]
    [DisplayName("Scheduled Time")]
    [IsoXmlTag("SchdldTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ScheduledTime { get; init; } 
    
    /// <summary>
    /// Date and time at which the event effectively takes place.
    /// </summary>
    [IsoId("_Sa227Np-Ed-ak6NoX_4Aeg_1771222972")]
    [DisplayName("Effective Time")]
    [IsoXmlTag("FctvTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? EffectiveTime { get; init; } 
    
    
    #nullable disable
    
}
