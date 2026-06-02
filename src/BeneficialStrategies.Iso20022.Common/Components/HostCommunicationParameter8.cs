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
[IsoId("_bHh5QbZ8EfCUZfsQO4rYeA")]
[DisplayName("Host Communication Parameter8")]
public record HostCommunicationParameter8
{
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_bIcfRbZ8EfCUZfsQO4rYeA")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; }

    /// <summary>
    /// Identification of the host.
    /// </summary>
    [IsoId("_bIcfS7Z8EfCUZfsQO4rYeA")]
    [DisplayName("Host Identification")]
    [IsoXmlTag("HstId")]
    public required IsoMax35Text HostIdentification { get; init; }

    /// <summary>
    /// Network parameters of the host.
    /// </summary>
    [IsoId("_bIcfUbZ8EfCUZfsQO4rYeA")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public NetworkParameters7? Address { get; init; }

    /// <summary>
    /// Cryptographic key used to communicate with the host.
    /// </summary>
    [IsoId("_bIcfV7Z8EfCUZfsQO4rYeA")]
    [DisplayName("Key")]
    [IsoXmlTag("Key")]
    public ValueList<CryptographicKey19> Key { get; init; } = [];

    /// <summary>
    /// Access information to reach an intermediate network service provider.
    /// </summary>
    [IsoId("_bIcfXbZ8EfCUZfsQO4rYeA")]
    [DisplayName("Network Service Provider")]
    [IsoXmlTag("NtwkSvcPrvdr")]
    public NetworkParameters7? NetworkServiceProvider { get; init; }

    /// <summary>
    /// Physical interface where the host is connected.
    /// </summary>
    [IsoId("_bIcfY7Z8EfCUZfsQO4rYeA")]
    [DisplayName("Physical Interface")]
    [IsoXmlTag("PhysIntrfc")]
    public PhysicalInterfaceParameter1? PhysicalInterface { get; init; }

    /// <summary>
    /// Type of exchange supported by the host.
    /// </summary>
    [IsoId("_bIcfabZ8EfCUZfsQO4rYeA")]
    [DisplayName("Exchange Mode")]
    [IsoXmlTag("XchgMd")]
    public CAPEExchangeMode1Code? ExchangeMode { get; init; }

    /// <summary>
    /// Type of encoding mode used by the exchange mode supported by the host.
    /// </summary>
    [IsoId("_bIcfa7Z8EfCUZfsQO4rYeA")]
    [DisplayName("Encoding Mode")]
    [IsoXmlTag("NcodgMd")]
    public CAPEEncodingMode1Code? EncodingMode { get; init; }
}
