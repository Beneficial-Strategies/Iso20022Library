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
[IsoId("_w3C1oajGEfCzuLlmLrhIvA")]
[DisplayName("Vote Details7")]
public record VoteDetails7
{
    /// <summary>
    /// Vote instructions for the resolutions that are announced via the meeting agenda in advance of the meeting.
    /// </summary>
    [IsoId("_w-jL0ajGEfCzuLlmLrhIvA")]
    [DisplayName("Vote Instruction For Agenda Resolution")]
    [IsoXmlTag("VoteInstrForAgndRsltn")]
    public required Vote17Choice_ VoteInstructionForAgendaResolution { get; init; }

    /// <summary>
    /// Vote instructions for the resolutions that may arise or may be amended at the meeting but were not previously provided in the agenda.
    /// </summary>
    [IsoId("_w-jL06jGEfCzuLlmLrhIvA")]
    [DisplayName("Vote Instruction For Meeting Resolution")]
    [IsoXmlTag("VoteInstrForMtgRsltn")]
    public VoteInstructionForMeetingResolution3Choice_? VoteInstructionForMeetingResolution { get; init; }

    /// <summary>
    /// Investor types that may or may not participate in the event.
    /// </summary>
    [IsoId("_HO3c4fUeEfCnzd_iHo4pAQ")]
    [DisplayName("Investor Type Identification")]
    [IsoXmlTag("InvstrTpId")]
    public InvestorTypeIdentification1? InvestorTypeIdentification { get; init; }
}
