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
[IsoId("_XuYKlRrlEeyhRdHRjakS2w")]
[DisplayName("Specific Instruction Request")]
public partial record SpecificInstructionRequest4
{
    #nullable enable
    
    /// <summary>
    /// Method of voting participation to the general meeting.
    /// </summary>
    [IsoId("_YC8FURrlEeyhRdHRjakS2w")]
    [DisplayName("Participation Method")]
    [IsoXmlTag("PrtcptnMtd")]
    public ParticipationMethod3Choice_? ParticipationMethod { get; init; } 
    
    /// <summary>
    /// Indicates a request to register the securities for the meeting.
    /// </summary>
    [IsoId("_YC8FUxrlEeyhRdHRjakS2w")]
    [DisplayName("Securities Registration")]
    [IsoXmlTag("SctiesRegn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SecuritiesRegistration { get; init; } 
    
    
    #nullable disable
    
}
