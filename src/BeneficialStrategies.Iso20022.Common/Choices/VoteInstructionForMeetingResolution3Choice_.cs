// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Vote instruction applying to resolutions added during the meeting.
    /// </summary>
    [KnownType(typeof(VoteInstructionForMeetingResolution3Choice.VoteIndication))]
    [KnownType(typeof(VoteInstructionForMeetingResolution3Choice.Shareholder))]
    [JsonDerivedType(typeof(VoteInstructionForMeetingResolution3Choice.VoteIndication),nameof(VoteInstructionForMeetingResolution3Choice.VoteIndication))]
    [JsonDerivedType(typeof(VoteInstructionForMeetingResolution3Choice.Shareholder),nameof(VoteInstructionForMeetingResolution3Choice.Shareholder))]
    [IsoId("_nguqQa4dEemG7MmivSuE5g")]
    [DisplayName("Vote Instruction For Meeting Resolution 3 Choice")]
    public abstract partial record VoteInstructionForMeetingResolution3Choice_
    {
    }
}
