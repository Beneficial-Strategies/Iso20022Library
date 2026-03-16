// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Vote instruction applying to resolutions added during the meeting.
    /// </summary>
    [KnownType(typeof(VoteInstructionForMeetingResolution1Choice.VoteIndication))]
    [KnownType(typeof(VoteInstructionForMeetingResolution1Choice.Shareholder))]
    [JsonDerivedType(
        typeof(VoteInstructionForMeetingResolution1Choice.VoteIndication),
        nameof(VoteInstructionForMeetingResolution1Choice.VoteIndication)
    )]
    [JsonDerivedType(
        typeof(VoteInstructionForMeetingResolution1Choice.Shareholder),
        nameof(VoteInstructionForMeetingResolution1Choice.Shareholder)
    )]
    [IsoId("_TK1iUNp-Ed-ak6NoX_4Aeg_853994638")]
    [DisplayName("Vote Instruction For Meeting Resolution 1 Choice")]
    public abstract record VoteInstructionForMeetingResolution1Choice_ { }
}
