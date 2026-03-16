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
[IsoId("_YQodoVFMEeyApZmLzm74zA")]
[DisplayName("Service Provider Parameters")]
public record ServiceProviderParameters2
{
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_YW_kUVFMEeyApZmLzm74zA")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; }

    /// <summary>
    /// Identification of the service provider.
    /// </summary>
    [IsoId("_YW_kU1FMEeyApZmLzm74zA")]
    [DisplayName("Service Provider Identification")]
    [IsoXmlTag("SvcPrvdrId")]
    public ValueList<GenericIdentification176> ServiceProviderIdentification { get; init; } = [];

    // ID for the above is _YW_kU1FMEeyApZmLzm74zA

    /// <summary>
    /// Version of the service provider parameters.
    /// </summary>
    [IsoId("_YW_kVVFMEeyApZmLzm74zA")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public required IsoMax256Text Version { get; init; }

    /// <summary>
    /// Identification of payment application relevant for this service provider.
    /// </summary>
    [IsoId("_YW_kV1FMEeyApZmLzm74zA")]
    [DisplayName("Application Identification")]
    [IsoXmlTag("ApplId")]
    public SimpleValueList<IsoMax35Text> ApplicationIdentification { get; init; } = [];

    /// <summary>
    /// Service provider host configuration.
    /// </summary>
    [IsoId("_YW_kWVFMEeyApZmLzm74zA")]
    [DisplayName("Host")]
    [IsoXmlTag("Hst")]
    public ValueList<AcquirerHostConfiguration9> Host { get; init; } = [];

    /// <summary>
    /// Identification of non financial action supported by the Service Provider.
    /// </summary>
    [IsoId("_YW_kW1FMEeyApZmLzm74zA")]
    [DisplayName("Non Financial Action Supported")]
    [IsoXmlTag("NonFinActnSpprtd")]
    public SimpleValueList<NonFinancialRequestType1Code> NonFinancialActionSupported { get; init; } =
        [];
}
