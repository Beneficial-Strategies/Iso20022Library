// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters to communicate with a host.
/// </summary>
[IsoId("_5RKOsQ1DEeqjM-rxn3HuXQ")]
[DisplayName("Network Parameters")]
public record NetworkParameters9
{
    /// <summary>
    /// Type of communication network.
    /// </summary>
    [IsoId("_5did0Q1DEeqjM-rxn3HuXQ")]
    [DisplayName("Network Type")]
    [IsoXmlTag("NtwkTp")]
    public required NetworkType1Code NetworkType { get; init; }

    /// <summary>
    /// Value of the address. The value of an internet protocol address contains the IP address or the DNS (Domain Name Server) address, followed by the character &apos;: &apos; and the port number if the default port is not used. The value of a public telephone address contains the phone number with possible prefix and extensions.
    /// </summary>
    [IsoId("_5did0w1DEeqjM-rxn3HuXQ")]
    [DisplayName("Address Value")]
    [IsoXmlTag("AdrVal")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500, MinimumLength = 1)]
    public required IsoMax500Text AddressValue { get; init; }
}
