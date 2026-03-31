// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Vote instruction applying to resolutions added during the meeting.
    /// </summary>
    [KnownType(typeof(VoteInstructionForMeetingResolution2Choice.VoteIndication))]
    [KnownType(typeof(VoteInstructionForMeetingResolution2Choice.Shareholder))]
    [JsonDerivedType(
        typeof(VoteInstructionForMeetingResolution2Choice.VoteIndication),
        nameof(VoteInstructionForMeetingResolution2Choice.VoteIndication)
    )]
    [JsonDerivedType(
        typeof(VoteInstructionForMeetingResolution2Choice.Shareholder),
        nameof(VoteInstructionForMeetingResolution2Choice.Shareholder)
    )]
    [IsoId("_na8OEV6-EeSjaerr_EM7AQ")]
    [DisplayName("Vote Instruction For Meeting Resolution 2 Choice")]
    public abstract record VoteInstructionForMeetingResolution2Choice_ { }
}
