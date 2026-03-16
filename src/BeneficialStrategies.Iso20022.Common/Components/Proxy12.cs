// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a proxy appointed to represent a party authorised to vote at a shareholders meeting and proxy vote.
/// </summary>
[IsoId("_ww1xRRrfEeyhRdHRjakS2w")]
[DisplayName("Proxy")]
public record Proxy12
{
    /// <summary>
    /// Type of proxy.
    /// </summary>
    [IsoId("_xFQiBRrfEeyhRdHRjakS2w")]
    [DisplayName("Proxy Type")]
    [IsoXmlTag("PrxyTp")]
    public required ProxyType3Code ProxyType { get; init; }

    /// <summary>
    /// Person, other than the chairman of the meeting, assigned by the security holder as the proxy.
    /// </summary>
    [IsoId("_xFQiBxrfEeyhRdHRjakS2w")]
    [DisplayName("Person Details")]
    [IsoXmlTag("PrsnDtls")]
    public IndividualPerson42? PersonDetails { get; init; }
}
