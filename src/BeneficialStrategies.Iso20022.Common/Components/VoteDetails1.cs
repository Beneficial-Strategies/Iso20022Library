// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies detailed voting instructions.
/// </summary>
[IsoId("_RW6Gldp-Ed-ak6NoX_4Aeg_863026858")]
[DisplayName("Vote Details")]
public record VoteDetails1
{
    /// <summary>
    /// Indicates the vote instruction for the resolutions which are announced via the meeting agenda in advance of the meeting.
    /// </summary>
    [IsoId("_RW6Gltp-Ed-ak6NoX_4Aeg_1746833601")]
    [DisplayName("Vote Instruction For Agenda Resolution")]
    [IsoXmlTag("VoteInstrForAgndRsltn")]
    public required Vote1Choice_ VoteInstructionForAgendaResolution { get; init; }

    /// <summary>
    /// Indicates the vote instruction for the resolutions that will be added during the meeting.
    /// </summary>
    [IsoId("_RW6Gl9p-Ed-ak6NoX_4Aeg_1677569668")]
    [DisplayName("Vote Instruction For Meeting Resolution")]
    [IsoXmlTag("VoteInstrForMtgRsltn")]
    public VoteInstructionForMeetingResolution1? VoteInstructionForMeetingResolution { get; init; }
}
