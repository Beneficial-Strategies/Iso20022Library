// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the elements that identify a proxy appointed to represent a party authorised to vote at a shareholders meeting.
/// </summary>
[IsoId("_T4lZJtp-Ed-ak6NoX_4Aeg_1754568643")]
[DisplayName("Proxy")]
public record Proxy2
{
    /// <summary>
    /// Specifies the type of proxy.
    /// </summary>
    [IsoId("_T4lZJ9p-Ed-ak6NoX_4Aeg_1754568668")]
    [DisplayName("Proxy Type")]
    [IsoXmlTag("PrxyTp")]
    public required ProxyType2Code ProxyType { get; init; }

    /// <summary>
    /// Person, other than the Chairman of the meeting, assigned by the security holder as proxy.
    /// </summary>
    [IsoId("_T4lZKNp-Ed-ak6NoX_4Aeg_-1908706979")]
    [DisplayName("Person Details")]
    [IsoXmlTag("PrsnDtls")]
    public IndividualPerson13? PersonDetails { get; init; }

    /// <summary>
    /// Indicates the vote instruction for the resolutions which are announced via the meeting agenda in advance of the meeting.
    /// </summary>
    [IsoId("_T4lZKdp-Ed-ak6NoX_4Aeg_1360073767")]
    [DisplayName("Vote Instruction For Agenda Resolution")]
    [IsoXmlTag("VoteInstrForAgndRsltn")]
    public Vote1Choice_? VoteInstructionForAgendaResolution { get; init; }
}
