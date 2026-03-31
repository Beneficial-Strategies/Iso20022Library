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
[IsoId("_aIcvEVtiEeSwKe7KuKvXhg")]
[DisplayName("Proxy")]
public record Proxy6
{
    /// <summary>
    /// Specifies the type of proxy.
    /// </summary>
    [IsoId("_ampuBVtiEeSwKe7KuKvXhg")]
    [DisplayName("Proxy Type")]
    [IsoXmlTag("PrxyTp")]
    public required ProxyType2Code ProxyType { get; init; }

    /// <summary>
    /// Person, other than the chairman of the meeting, assigned by the security holder as the proxy.
    /// </summary>
    [IsoId("_ampuB1tiEeSwKe7KuKvXhg")]
    [DisplayName("Person Details")]
    [IsoXmlTag("PrsnDtls")]
    public IndividualPerson26? PersonDetails { get; init; }

    /// <summary>
    /// Indicates the vote instruction for the resolutions that are announced via the meeting agenda in advance of the meeting.
    /// </summary>
    [IsoId("_ampuCVtiEeSwKe7KuKvXhg")]
    [DisplayName("Vote Instruction For Agenda Resolution")]
    [IsoXmlTag("VoteInstrForAgndRsltn")]
    public Vote3Choice_? VoteInstructionForAgendaResolution { get; init; }
}
