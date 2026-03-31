// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a proxy appointed to represent a party authorised to vote at a shareholders meeting.
/// </summary>
[IsoId("_ioMbixrfEeyhRdHRjakS2w")]
[DisplayName("Proxy")]
public record Proxy11
{
    /// <summary>
    /// Type of proxy.
    /// </summary>
    [IsoId("_i85gMxrfEeyhRdHRjakS2w")]
    [DisplayName("Proxy Type")]
    [IsoXmlTag("PrxyTp")]
    public required ProxyType3Code ProxyType { get; init; }

    /// <summary>
    /// Person, other than the chairman of the meeting, assigned by the security holder as the proxy.
    /// </summary>
    [IsoId("_i85gNRrfEeyhRdHRjakS2w")]
    [DisplayName("Person Details")]
    [IsoXmlTag("PrsnDtls")]
    public IndividualPerson43? PersonDetails { get; init; }
}
