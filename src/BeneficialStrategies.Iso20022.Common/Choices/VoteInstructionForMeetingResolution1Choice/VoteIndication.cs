// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.VoteInstructionForMeetingResolution1Choice
{
    /// <summary>
    /// Specifies the vote recommendation for resolutions added during the meeting.
    /// </summary>
    [IsoId("_TK1iUdp-Ed-ak6NoX_4Aeg_853994670")]
    [DisplayName("Vote Indication")]
    public partial record VoteIndication : VoteInstructionForMeetingResolution1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Identifies the possible types of voting instructions for resolutions proposed at the meeting.
        /// </summary>
        [IsoXmlTag("VoteIndctn")]
        public required VoteInstructionAtMeeting1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
