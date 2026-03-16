// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.VoteInstructionForMeetingResolution2Choice
{
    /// <summary>
    /// Specifies the vote recommendation for resolutions added during the meeting.
    /// </summary>
    [IsoId("_n3g1U16-EeSjaerr_EM7AQ")]
    [DisplayName("Vote Indication")]
    public record VoteIndication : VoteInstructionForMeetingResolution2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the possible types of voting instructions.
        /// </summary>
        [IsoXmlTag("VoteIndctn")]
        public required VoteInstruction4Code Value { get; init; }
    }
}
