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
    public partial record VoteIndication : VoteInstructionForMeetingResolution3Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("VoteIndctn")]
        public required VoteInstructionType1Choice_ Value { get; init; }
    }
}
