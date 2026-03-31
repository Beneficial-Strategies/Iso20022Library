// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.VoteInstructionForMeetingResolution3Choice
{
    /// <summary>
    /// Vote recommendation for resolutions added during the meeting.
    /// </summary>
    [IsoId("_n0rhA64dEemG7MmivSuE5g")]
    [DisplayName("Vote Indication")]
    public record VoteIndication : VoteInstructionForMeetingResolution3Choice_ { }
}
