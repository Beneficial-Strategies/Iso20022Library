// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Voting participation method at a general meeting.
/// </summary>
[IsoId("_yhcMIa7BEemG7MmivSuE5g")]
[DisplayName("Specific Instruction Request")]
public record SpecificInstructionRequest2
{
    /// <summary>
    /// Method of voting participation to the general meeting.
    /// </summary>
    [IsoId("_eE71Ma-REemJ1NnLPsTFaw")]
    [DisplayName("Participation Method")]
    [IsoXmlTag("PrtcptnMtd")]
    public required ParticipationMethod1Choice_ ParticipationMethod { get; init; }

    /// <summary>
    /// Indicates a request to register the securities for the meeting.
    /// </summary>
    [IsoId("_y2RMpa7BEemG7MmivSuE5g")]
    [DisplayName("Securities Registration")]
    [IsoXmlTag("SctiesRegn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SecuritiesRegistration { get; init; }
}
