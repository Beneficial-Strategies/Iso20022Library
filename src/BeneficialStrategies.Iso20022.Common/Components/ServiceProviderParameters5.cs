// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Service provider parameters of the point of interaction (POI).
/// </summary>
[IsoId("_rm8VMbaAEfCUZfsQO4rYeA")]
[DisplayName("Service Provider Parameters5")]
public record ServiceProviderParameters5
{
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_rn2UJbaAEfCUZfsQO4rYeA")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; }

    /// <summary>
    /// Identification of the service provider.
    /// </summary>
    [IsoId("_rn2UK7aAEfCUZfsQO4rYeA")]
    [DisplayName("Service Provider Identification")]
    [IsoXmlTag("SvcPrvdrId")]
    [MinLength(1)]
    public ValueList<GenericIdentification176> ServiceProviderIdentification { get; init; } = [];

    /// <summary>
    /// Version of the service provider parameters.
    /// </summary>
    [IsoId("_rn2UMbaAEfCUZfsQO4rYeA")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    public required IsoMax256Text Version { get; init; }

    /// <summary>
    /// Identification of payment application relevant for this service provider.
    /// </summary>
    [IsoId("_rn2UN7aAEfCUZfsQO4rYeA")]
    [DisplayName("Application Identification")]
    [IsoXmlTag("ApplId")]
    public SimpleValueList<IsoMax35Text> ApplicationIdentification { get; init; } = [];

    /// <summary>
    /// Service provider host configuration.
    /// </summary>
    [IsoId("_rn2UPbaAEfCUZfsQO4rYeA")]
    [DisplayName("Host")]
    [IsoXmlTag("Hst")]
    public ValueList<AcquirerHostConfiguration11> Host { get; init; } = [];

    /// <summary>
    /// Identification of non financial action supported by the Service Provider.
    /// </summary>
    [IsoId("_rn2UQ7aAEfCUZfsQO4rYeA")]
    [DisplayName("Non Financial Action Supported")]
    [IsoXmlTag("NonFinActnSpprtd")]
    public SimpleValueList<NonFinancialRequestType2Code> NonFinancialActionSupported { get; init; } = [];
}
