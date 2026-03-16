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
[IsoId("_NI6SUXISEe2OqYulmHWukQ")]
[DisplayName("Service Provider Parameters")]
public record ServiceProviderParameters3
{
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_NPs20XISEe2OqYulmHWukQ")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; }

    /// <summary>
    /// Identification of the service provider.
    /// </summary>
    [IsoId("_NPs203ISEe2OqYulmHWukQ")]
    [DisplayName("Service Provider Identification")]
    [IsoXmlTag("SvcPrvdrId")]
    public ValueList<GenericIdentification176> ServiceProviderIdentification { get; init; } = [];

    // ID for the above is _NPs203ISEe2OqYulmHWukQ

    /// <summary>
    /// Version of the service provider parameters.
    /// </summary>
    [IsoId("_NPs21XISEe2OqYulmHWukQ")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public required IsoMax256Text Version { get; init; }

    /// <summary>
    /// Identification of payment application relevant for this service provider.
    /// </summary>
    [IsoId("_NPs213ISEe2OqYulmHWukQ")]
    [DisplayName("Application Identification")]
    [IsoXmlTag("ApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ApplicationIdentification { get; init; }

    /// <summary>
    /// Service provider host configuration.
    /// </summary>
    [IsoId("_NPs22XISEe2OqYulmHWukQ")]
    [DisplayName("Host")]
    [IsoXmlTag("Hst")]
    public AcquirerHostConfiguration9? Host { get; init; }

    /// <summary>
    /// Identification of non financial action supported by the Service Provider.
    /// </summary>
    [IsoId("_NPs223ISEe2OqYulmHWukQ")]
    [DisplayName("Non Financial Action Supported")]
    [IsoXmlTag("NonFinActnSpprtd")]
    public NonFinancialRequestType2Code? NonFinancialActionSupported { get; init; }
}
