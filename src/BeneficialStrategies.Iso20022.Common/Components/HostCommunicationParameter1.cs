// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Configuration parameters to communicate with a host.
/// </summary>
[IsoId("_LYnu0H1DEeCF8NjrBemJWQ_436596133")]
[DisplayName("Host Communication Parameter")]
public record HostCommunicationParameter1
{
    /// <summary>
    /// Identification of the host.
    /// </summary>
    [IsoId("_LYnu0X1DEeCF8NjrBemJWQ_-1252337300")]
    [DisplayName("Host Identification")]
    [IsoXmlTag("HstId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text HostIdentification { get; init; }

    /// <summary>
    /// Network parameters of the host.
    /// </summary>
    [IsoId("_LYnu0n1DEeCF8NjrBemJWQ_-813704955")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public NetworkParameters1? Address { get; init; }

    /// <summary>
    /// Cryptographic key used to communicate with the host.
    /// </summary>
    [IsoId("_LYnu031DEeCF8NjrBemJWQ_-209462385")]
    [DisplayName("Key")]
    [IsoXmlTag("Key")]
    public ValueList<CryptographicKey1> Key { get; init; } = [];
}
