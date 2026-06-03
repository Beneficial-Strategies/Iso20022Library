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
    [IsoId("_w-jL0ajGEfCzuLlmLrhIvA")]
    [DisplayName("Vote Instruction For Agenda Resolution")]
    [IsoXmlTag("VoteInstrForAgndRsltn")]
    public required Vote17Choice VoteInstructionForAgendaResolution { get; init; }

    [IsoId("_w-jL06jGEfCzuLlmLrhIvA")]
    [DisplayName("Vote Instruction For Meeting Resolution")]
    [IsoXmlTag("VoteInstrForMtgRsltn")]
    public VoteInstructionForMeetingResolution3Choice? VoteInstructionForMeetingResolution { get; init; }

    [IsoId("_HO3c4fUeEfCnzd_iHo4pAQ")]
    [DisplayName("Investor Type Identification")]
    [IsoXmlTag("InvstrTpId")]
    public InvestorTypeIdentification1? InvestorTypeIdentification { get; init; }
}
