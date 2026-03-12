// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Voting participation method at a general meeting.
/// </summary>
[IsoId("_xVOZAfNoEeqRfth943bvEA")]
[DisplayName("Specific Instruction Request")]
public partial record SpecificInstructionRequest3
{
    #nullable enable
    
    /// <summary>
    /// Method of voting participation to the general meeting.
    /// </summary>
    [IsoId("_xpKBofNoEeqRfth943bvEA")]
    [DisplayName("Participation Method")]
    [IsoXmlTag("PrtcptnMtd")]
    public ParticipationMethod1Choice_? ParticipationMethod { get; init; } 
    
    /// <summary>
    /// Indicates a request to register the securities for the meeting.
    /// </summary>
    [IsoId("_xpKBo_NoEeqRfth943bvEA")]
    [DisplayName("Securities Registration")]
    [IsoXmlTag("SctiesRegn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SecuritiesRegistration { get; init; } 
    
    
    #nullable disable
    
}
