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
[IsoId("_T4cPN9p-Ed-ak6NoX_4Aeg_2145397537")]
[DisplayName("Proxy")]
public record Proxy4
{
    /// <summary>
    /// Specifies the type of proxy.
    /// </summary>
    [IsoId("_T4cPONp-Ed-ak6NoX_4Aeg_2145397569")]
    [DisplayName("Proxy Type")]
    [IsoXmlTag("PrxyTp")]
    public required ProxyType2Code ProxyType { get; init; }

    /// <summary>
    /// Person, other than the Chairman of the meeting, assigned by the security holder as proxy.
    /// </summary>
    [IsoId("_T4cPOdp-Ed-ak6NoX_4Aeg_2145398147")]
    [DisplayName("Person Details")]
    [IsoXmlTag("PrsnDtls")]
    public IndividualPerson17? PersonDetails { get; init; }

    /// <summary>
    /// Indicates the vote instruction for the resolutions which are announced via the meeting agenda in advance of the meeting.
    /// </summary>
    [IsoId("_T4cPOtp-Ed-ak6NoX_4Aeg_2145398085")]
    [DisplayName("Vote Instruction For Agenda Resolution")]
    [IsoXmlTag("VoteInstrForAgndRsltn")]
    public Vote2Choice_? VoteInstructionForAgendaResolution { get; init; }
}
