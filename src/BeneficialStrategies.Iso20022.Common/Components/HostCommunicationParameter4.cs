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
[IsoId("_PDwmYY3_EeWRwov1g9WL_A")]
[DisplayName("Host Communication Parameter")]
public record HostCommunicationParameter4
{
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_YkadQI3_EeWRwov1g9WL_A")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; }

    /// <summary>
    /// Identification of the host.
    /// </summary>
    [IsoId("_POMUwY3_EeWRwov1g9WL_A")]
    [DisplayName("Host Identification")]
    [IsoXmlTag("HstId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text HostIdentification { get; init; }

    /// <summary>
    /// Network parameters of the host.
    /// </summary>
    [IsoId("_POMUw43_EeWRwov1g9WL_A")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public NetworkParameters3? Address { get; init; }

    /// <summary>
    /// Cryptographic key used to communicate with the host.
    /// </summary>
    [IsoId("_POMUxY3_EeWRwov1g9WL_A")]
    [DisplayName("Key")]
    [IsoXmlTag("Key")]
    public ValueList<KEKIdentifier5> Key { get; init; } = [];

    /// <summary>
    /// Access information to reach an intermediate network service provider.
    /// </summary>
    [IsoId("_EXHBAI4AEeWRwov1g9WL_A")]
    [DisplayName("Network Service Provider")]
    [IsoXmlTag("NtwkSvcPrvdr")]
    public NetworkParameters5? NetworkServiceProvider { get; init; }
}
