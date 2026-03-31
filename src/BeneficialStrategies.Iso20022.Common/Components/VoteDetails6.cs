// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Vote instruction for an agenda or a meeting resolution.
/// </summary>
[IsoId("_gL1YYTUDEe2tRf29bleifQ")]
[DisplayName("Vote Details")]
public record VoteDetails6
{
    /// <summary>
    /// Vote instructions for the resolutions that are announced via the meeting agenda in advance of the meeting.
    /// </summary>
    [IsoId("_gjhfozUDEe2tRf29bleifQ")]
    [DisplayName("Vote Instruction For Agenda Resolution")]
    [IsoXmlTag("VoteInstrForAgndRsltn")]
    public required Vote15Choice_ VoteInstructionForAgendaResolution { get; init; }

    /// <summary>
    /// Vote instructions for the resolutions that may arise or may be amended at the meeting but were not previously provided in the agenda.
    /// </summary>
    [IsoId("_gjhfpTUDEe2tRf29bleifQ")]
    [DisplayName("Vote Instruction For Meeting Resolution")]
    [IsoXmlTag("VoteInstrForMtgRsltn")]
    public VoteInstructionForMeetingResolution3Choice_? VoteInstructionForMeetingResolution { get; init; }
}
