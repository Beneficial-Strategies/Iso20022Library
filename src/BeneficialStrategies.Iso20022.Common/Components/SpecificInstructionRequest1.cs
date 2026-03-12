// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Request to execute specific instructions, such as participation registration, securities registration or blocking of securities.
/// </summary>
[IsoId("_RVH95Np-Ed-ak6NoX_4Aeg_-1758177157")]
[DisplayName("Specific Instruction Request")]
public partial record SpecificInstructionRequest1
{
    #nullable enable
    
    /// <summary>
    /// Request to register for participation to the meeting.
    /// </summary>
    [IsoId("_RVH95dp-Ed-ak6NoX_4Aeg_-2054390611")]
    [DisplayName("Participation Registration")]
    [IsoXmlTag("PrtcptnRegn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ParticipationRegistration { get; init; } 
    
    /// <summary>
    /// Request to block the securities.
    /// </summary>
    [IsoId("_RVH95tp-Ed-ak6NoX_4Aeg_-1707147689")]
    [DisplayName("Blocking Securities")]
    [IsoXmlTag("BlckgScties")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? BlockingSecurities { get; init; } 
    
    /// <summary>
    /// Request to register the securities for the meeting.
    /// </summary>
    [IsoId("_RVH959p-Ed-ak6NoX_4Aeg_-1592630247")]
    [DisplayName("Securities Registration")]
    [IsoXmlTag("SctiesRegn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SecuritiesRegistration { get; init; } 
    
    
    #nullable disable
    
}
