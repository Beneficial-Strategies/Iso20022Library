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
[IsoId("_RDYtoNp-Ed-ak6NoX_4Aeg_1302554579")]
[DisplayName("Vote Details")]
public record VoteDetails2
{
    /// <summary>
    /// Indicates the vote instruction for the resolutions which are announced via the meeting agenda in advance of the meeting.
    /// </summary>
    [IsoId("_RDYtodp-Ed-ak6NoX_4Aeg_1303474735")]
    [DisplayName("Vote Instruction For Agenda Resolution")]
    [IsoXmlTag("VoteInstrForAgndRsltn")]
    public required Vote2Choice_ VoteInstructionForAgendaResolution { get; init; }

    /// <summary>
    /// Indicates the vote instruction for the resolutions that may arise at the meeting but were not previously provided in the agenda.
    /// </summary>
    [IsoId("_RDYtotp-Ed-ak6NoX_4Aeg_1302554702")]
    [DisplayName("Vote Instruction For Meeting Resolution")]
    [IsoXmlTag("VoteInstrForMtgRsltn")]
    public VoteInstructionForMeetingResolution1Choice_? VoteInstructionForMeetingResolution { get; init; }
}
